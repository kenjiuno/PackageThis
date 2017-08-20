// Copyright (c) Microsoft Corporation.  All rights reserved.

namespace PackageThis
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToHxsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TOCTreeView = new System.Windows.Forms.TreeView();
            this.TreeViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectSiblingNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectThisNodeAndAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsGrid = new System.Windows.Forms.DataGridView();
            this.contentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContentDataSet = new PackageThis.Content();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openWorkdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TreeViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.localeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1575, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToHxsFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.openWorkdirToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.loadToolStripMenuItem.Text = "Load And add Selections...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.saveToolStripMenuItem.Text = "&Save Selections...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(361, 6);
            // 
            // exportToHxsFileToolStripMenuItem
            // 
            this.exportToHxsFileToolStripMenuItem.Name = "exportToHxsFileToolStripMenuItem";
            this.exportToHxsFileToolStripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.exportToHxsFileToolStripMenuItem.Text = "Export to Hxs File...";
            this.exportToHxsFileToolStripMenuItem.Click += new System.EventHandler(this.exportToHxsFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(364, 30);
            this.toolStripMenuItem2.Text = "Export to Chm File...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(361, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // localeToolStripMenuItem
            // 
            this.localeToolStripMenuItem.Name = "localeToolStripMenuItem";
            this.localeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.localeToolStripMenuItem.Text = "Locale";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1575, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TOCTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DocsGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1575, 807);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // TOCTreeView
            // 
            this.TOCTreeView.CheckBoxes = true;
            this.TOCTreeView.ContextMenuStrip = this.TreeViewMenu;
            this.TOCTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TOCTreeView.Location = new System.Drawing.Point(0, 0);
            this.TOCTreeView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TOCTreeView.Name = "TOCTreeView";
            this.TOCTreeView.Size = new System.Drawing.Size(523, 807);
            this.TOCTreeView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.TOCTreeView, "Nodes in red are not available in the content service.");
            this.TOCTreeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.TOCTreeView_BeforeCheck);
            this.TOCTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TOCTreeView_BeforeExpand);
            this.TOCTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOCTreeView_MouseDown);
            // 
            // TreeViewMenu
            // 
            this.TreeViewMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TreeViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSiblingNodesToolStripMenuItem,
            this.deselectThisNodeAndAllChildrenToolStripMenuItem});
            this.TreeViewMenu.Name = "TreeViewMenu";
            this.TreeViewMenu.Size = new System.Drawing.Size(366, 64);
            // 
            // selectSiblingNodesToolStripMenuItem
            // 
            this.selectSiblingNodesToolStripMenuItem.Name = "selectSiblingNodesToolStripMenuItem";
            this.selectSiblingNodesToolStripMenuItem.Size = new System.Drawing.Size(365, 30);
            this.selectSiblingNodesToolStripMenuItem.Text = "Select This Node and All Children...";
            this.selectSiblingNodesToolStripMenuItem.Click += new System.EventHandler(this.selectNodeAndChildrenToolStripMenuItem_Click);
            // 
            // deselectThisNodeAndAllChildrenToolStripMenuItem
            // 
            this.deselectThisNodeAndAllChildrenToolStripMenuItem.Name = "deselectThisNodeAndAllChildrenToolStripMenuItem";
            this.deselectThisNodeAndAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(365, 30);
            this.deselectThisNodeAndAllChildrenToolStripMenuItem.Text = "Deselect This Node and All Children";
            this.deselectThisNodeAndAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.deselectThisNodeAndAllChildrenToolStripMenuItem_Click);
            // 
            // DocsGrid
            // 
            this.DocsGrid.AllowUserToAddRows = false;
            this.DocsGrid.AllowUserToDeleteRows = false;
            this.DocsGrid.AllowUserToOrderColumns = true;
            this.DocsGrid.AllowUserToResizeRows = false;
            this.DocsGrid.AutoGenerateColumns = false;
            this.DocsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DocsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DocsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.versionIdDataGridViewTextBoxColumn,
            this.assetIdDataGridViewTextBoxColumn,
            this.picturesDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.DocsGrid.DataSource = this.itemsBindingSource;
            this.DocsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocsGrid.Location = new System.Drawing.Point(0, 0);
            this.DocsGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DocsGrid.Name = "DocsGrid";
            this.DocsGrid.ReadOnly = true;
            this.DocsGrid.RowHeadersVisible = false;
            this.DocsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocsGrid.Size = new System.Drawing.Size(1045, 807);
            this.DocsGrid.TabIndex = 0;
            // 
            // contentIdDataGridViewTextBoxColumn
            // 
            this.contentIdDataGridViewTextBoxColumn.DataPropertyName = "ContentId";
            this.contentIdDataGridViewTextBoxColumn.HeaderText = "ContentId";
            this.contentIdDataGridViewTextBoxColumn.Name = "contentIdDataGridViewTextBoxColumn";
            this.contentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentIdDataGridViewTextBoxColumn.Width = 117;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 78;
            // 
            // versionIdDataGridViewTextBoxColumn
            // 
            this.versionIdDataGridViewTextBoxColumn.DataPropertyName = "VersionId";
            this.versionIdDataGridViewTextBoxColumn.HeaderText = "VersionId";
            this.versionIdDataGridViewTextBoxColumn.Name = "versionIdDataGridViewTextBoxColumn";
            this.versionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.versionIdDataGridViewTextBoxColumn.Width = 113;
            // 
            // assetIdDataGridViewTextBoxColumn
            // 
            this.assetIdDataGridViewTextBoxColumn.DataPropertyName = "AssetId";
            this.assetIdDataGridViewTextBoxColumn.HeaderText = "AssetId";
            this.assetIdDataGridViewTextBoxColumn.Name = "assetIdDataGridViewTextBoxColumn";
            this.assetIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetIdDataGridViewTextBoxColumn.Width = 99;
            // 
            // picturesDataGridViewTextBoxColumn
            // 
            this.picturesDataGridViewTextBoxColumn.DataPropertyName = "Pictures";
            this.picturesDataGridViewTextBoxColumn.HeaderText = "Pictures";
            this.picturesDataGridViewTextBoxColumn.Name = "picturesDataGridViewTextBoxColumn";
            this.picturesDataGridViewTextBoxColumn.ReadOnly = true;
            this.picturesDataGridViewTextBoxColumn.Width = 106;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 76;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Item";
            this.itemsBindingSource.DataSource = this.ContentDataSet;
            // 
            // ContentDataSet
            // 
            this.ContentDataSet.DataSetName = "Content";
            this.ContentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML files|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML files|*.xml";
            this.openFileDialog1.Multiselect = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(361, 6);
            // 
            // openWorkdirToolStripMenuItem
            // 
            this.openWorkdirToolStripMenuItem.Name = "openWorkdirToolStripMenuItem";
            this.openWorkdirToolStripMenuItem.Size = new System.Drawing.Size(364, 30);
            this.openWorkdirToolStripMenuItem.Text = "Open workdir";
            this.openWorkdirToolStripMenuItem.Click += new System.EventHandler(this.openWorkdirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 864);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Package This! Ex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TreeViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DocsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TOCTreeView;
        private System.Windows.Forms.DataGridView DocsGrid;
        private System.Windows.Forms.ToolStripMenuItem localeToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private Content ContentDataSet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exportToHxsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ContextMenuStrip TreeViewMenu;
        private System.Windows.Forms.ToolStripMenuItem selectSiblingNodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectThisNodeAndAllChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openWorkdirToolStripMenuItem;
    }
}

