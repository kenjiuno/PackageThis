// Copyright (c) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using ContentServiceLibrary;
using System.Linq;

namespace PackageThis {
    public partial class MainForm : Form {
        static private AppController appController;
        static private string currentLocale = CultureInfo.CurrentCulture.Name.ToLower();
        static private string workingDir;
        static private string tempPath;
        static private string tempDir;

        static string tocLocale = currentLocale.ToLower();

        public MainForm() {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Unicode Start of String, chosen to avoid collisions possible with default sep
            // when we serialize the path to a file.
            TOCTreeView.PathSeparator = "\x0098";

            CreateTempDir();

            rootContentItem.currentLibrary = Properties.Settings.Default.currentLibrary;

            //statusStrip1.Items.Add(workingDir);
            statusStrip1.Items.Add(rootContentItem.name);

            populateLocaleMenu();
            populateLibraryMenu();

            appController = new AppController(rootContentItem.contentId, currentLocale, rootContentItem.version,
                TOCTreeView, workingDir);

            Text += " " + Application.ProductVersion;
        }

        private void selectLocale_Click(object sender, EventArgs e) {
            ToolStripMenuItem selected = sender as ToolStripMenuItem;

        }

        private void populateLocaleMenu() {
            SortedDictionary<string, string> locales;

            int i = 0;

            locales = Utility.GetLocales();

            foreach (string displayName in locales.Keys) {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(displayName, null,
                    localeToolStripMenuItem_Click);


                menuItem.Name = locales[displayName];

                localeToolStripMenuItem.DropDownItems.Insert(i++, menuItem);

                if (currentLocale == locales[displayName])
                    menuItem.Checked = true;

            }

        }

        private void populateLibraryMenu() {
            for (int i = 0; i < rootContentItem.libraries.Count; i++) {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(rootContentItem.libraries[i], null,
                    libraryToolStripMenuItem_Click);

                menuItem.Name = rootContentItem.libraries[i];
                libraryToolStripMenuItem.DropDownItems.Insert(i, menuItem);

                if (rootContentItem.currentLibrary == i)
                    menuItem.Checked = true;
                else
                    menuItem.Checked = false;
            }


        }

        private void populateTreeView() {
        }

        private void TOCTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            appController.ExpandNode(e.Node);
        }

        private void localeToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem selected = sender as ToolStripMenuItem;

            if (selected.Checked == true)
                return;


            for (int i = 0; i < localeToolStripMenuItem.DropDownItems.Count; i++) {
                if ((localeToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem).Checked == true) {
                    (localeToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem).Checked = false;
                }
            }

            selected.Checked = true;


            tocLocale = selected.Name;
            reloadLibrary();

        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem selected = sender as ToolStripMenuItem;

            if (selected.Checked == true)
                return;

            for (int i = 0; i < libraryToolStripMenuItem.DropDownItems.Count; i++) {
                if ((libraryToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem).Checked == true) {
                    (libraryToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem).Checked = false;
                }
            }

            selected.Checked = true;

            rootContentItem.currentLibrary = Properties.Settings.Default.currentLibrary =
                rootContentItem.libraries.IndexOf(selected.Name);
            Properties.Settings.Default.Save();

            reloadLibrary();

        }

        private void reloadLibrary() {
            CleanUpTempDir();
            CreateTempDir();

            statusStrip1.Items.Clear();
            //statusStrip1.Items.Add(workingDir);
            statusStrip1.Items.Add(rootContentItem.name);

            TOCTreeView.BeginUpdate();
            TOCTreeView.Nodes.Clear();

            appController = new AppController(rootContentItem.contentId, tocLocale,
                rootContentItem.version, TOCTreeView, workingDir);

            TOCTreeView.EndUpdate();

            if (ContentDataSet.Tables["ItemInstance"] != null)
                ContentDataSet.Tables["ItemInstance"].Clear();

            if (ContentDataSet.Tables["Item"] != null)
                ContentDataSet.Tables["Item"].Clear();

            if (ContentDataSet.Tables["Picture"] != null)
                ContentDataSet.Tables["Picture"].Clear();

        }


        private void TOCTreeView_BeforeCheck(object sender, TreeViewCancelEventArgs e) {
            string[] split = e.Node.FullPath.Split(new char[] { '\x0098' });


            if (e.Node.Checked == false) {
                if (appController.WriteContent(e.Node, ContentDataSet) == false)
                    e.Cancel = true;
            }
            else {
                appController.RemoveContent(e.Node, ContentDataSet);
            }
        }

        private void TOCTreeView_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                TOCTreeView.SelectedNode = TOCTreeView.GetNodeAt(e.X, e.Y);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                ContentDataSet.Tables["ItemInstance"].WriteXml(saveFileDialog1.FileName, XmlWriteMode.WriteSchema);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                foreach (var filePath in openFileDialog1.FileNames) {
                    var dataSet = new Content();
                    dataSet.EnforceConstraints = false;
                    dataSet.ReadXml(filePath);
                    foreach (Content.ItemInstanceRow row in dataSet.ItemInstance.Select()) {
                        findAndCheckNode(TOCTreeView.Nodes, row.FullPath);
                    }
                    saveFileDialog1.FileName = openFileDialog1.FileName;
                }
            }
        }

        private void findAndCheckNode(TreeNodeCollection nodes, string fullPath) {
            Update();

            var oneAndMore = fullPath.Split(new char[] { '\x0098' }, 2);
            foreach (TreeNode subNode in nodes) {
                if (subNode.Text != oneAndMore[0]) {
                    continue;
                }
                subNode.Expand();
                if (oneAndMore.Length == 2) {
                    // walk child
                    findAndCheckNode(subNode.Nodes, oneAndMore[1]);
                }
                else {
                    // uncheck first
                    if (subNode.Checked) {
                        subNode.Checked = false;
                    }
                    // check me
                    subNode.Checked = true;
                }
            }
        }

        private void selectNodeAndChildrenToolStripMenuItem_Click(object sender, EventArgs e) {
            DownloadProgressForm dpf = new DownloadProgressForm(TOCTreeView.SelectedNode,
                ContentDataSet);

            dpf.ShowDialog();

        }

        private void deselectThisNodeAndAllChildrenToolStripMenuItem_Click(object sender, EventArgs e) {
            appController.UncheckNodes(TOCTreeView.SelectedNode);

        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            CleanUpTempDir();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        // TODO: Move this to AppController.

        private void CleanUpTempDir() {
            // Do some sanity checks on workingDir so we don't, due to a bug,
            // delete too much.

            if (workingDir.StartsWith(tempPath) != true)
                return;

            if (workingDir.Contains(tempDir) != true)
                return;

            try {
                Directory.Delete(workingDir, true);
            }
            catch (IOException ex) {
            }

        }

        private void CreateTempDir() {
            tempPath = Path.GetTempPath();
            tempDir = Path.GetRandomFileName();
            workingDir = Path.Combine(tempPath, tempDir) + "\\";
            Directory.CreateDirectory(workingDir);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {

            ExportChmForm ecf = new ExportChmForm();

            var titles = guessTitles();
            {
                var title = titles.First();
                ecf.ChmFileTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), title + ".chm");
                ecf.TitleTextBox.Text = title;
            }

            foreach (var _ in titles) {
                var title = _;
                var b = new Button();
                b.AutoSize = true;
                b.Text = title;
                b.Click += delegate {
                    ecf.ChmFileTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), title + ".chm");
                    ecf.TitleTextBox.Text = title;
                };
                b.Margin = System.Windows.Forms.Padding.Empty;
                ecf.guessTitles.Controls.Add(b);
            }

            if (ecf.ShowDialog() != DialogResult.OK)
                return;

            appController.CreateChm(ecf.ChmFileTextBox.Text, ecf.TitleTextBox.Text,
                tocLocale, ContentDataSet, Encoding.GetEncoding(ecf.hhpEncoding.Text));


        }

        private IEnumerable<string> guessTitles() {
            List<string> fullPaths = new List<string>(
                getAllCheckedNodes().Select(node => node.FullPath)
                );
            if (fullPaths.Count == 0) {
                yield return "No Contents";
                yield break;
            }
            var firstNodePathParts = fullPaths[0].Split(new string[] { TOCTreeView.PathSeparator }, StringSplitOptions.None);
            for (int x = firstNodePathParts.Length; x > 0; x--) {
                var basePath = String.Join(TOCTreeView.PathSeparator, firstNodePathParts, 0, x);
                if (fullPaths.All(fullPath => fullPath.StartsWith(basePath))) {
                    yield return firstNodePathParts[x - 1];
                }
            }
            yield return rootContentItem.name;
        }

        private IEnumerable<TreeNode> getAllCheckedNodes() {
            Stack<TreeNodeCollection> nodeCollections = new Stack<TreeNodeCollection>();
            nodeCollections.Push(TOCTreeView.Nodes);
            while (nodeCollections.Count != 0) {
                var nodeCollection = nodeCollections.Pop();
                foreach (TreeNode subNode in nodeCollection) {
                    if (subNode.Checked) {
                        yield return subNode;
                    }
                    nodeCollections.Push(subNode.Nodes);
                }
            }
        }

        private void exportToHxsFileToolStripMenuItem_Click(object sender, EventArgs e) {
            GenerateHxsForm exportDialog = new GenerateHxsForm();

            var titles = guessTitles();
            var title = titles.First();
            exportDialog.FileTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), title + ".hxs");
            exportDialog.TitleTextBox.Text = title;

            if (exportDialog.ShowDialog() != DialogResult.OK) {
                return;
            }

            appController.CreateHxs(exportDialog.FileTextBox.Text,
                exportDialog.TitleTextBox.Text,
                exportDialog.CopyrightComboBox.Text,
                tocLocale,
                ContentDataSet);

        }

        private void clearAllSelectionsToolStripMenuItem_Click(object sender, EventArgs e) {
            // very SLOW! it is better choice if you restart app.
            uncheckAll(TOCTreeView.Nodes);
        }

        private void uncheckAll(TreeNodeCollection nodes) {
            foreach (TreeNode subNode in nodes) {
                if (subNode.Checked) {
                    subNode.Checked = false;
                }
                uncheckAll(subNode.Nodes);
            }
        }

        private void openWorkdirToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(workingDir);
        }
    }
}