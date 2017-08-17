// Copyright (c) Microsoft Corporation.  All rights reserved.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PackageThis {
    public partial class ExportChmForm : Form {
        public ExportChmForm() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(ChmFileTextBox.Text) == false &&
                String.IsNullOrEmpty(TitleTextBox.Text) == false)
                OKBtn.Enabled = true;
            else
                OKBtn.Enabled = false;
        }

        private void BrowseBtn_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = ChmFileTextBox.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                ChmFileTextBox.Text = saveFileDialog1.FileName;
                this.ActiveControl = TitleTextBox;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(linkUrl.GetToolTip((Control)sender));
        }

        private void ExportChmForm_Load(object sender, EventArgs e) {
            hhpEncoding.Items.Add(Encoding.Default.WebName);
            hhpEncoding.Items.Add("utf-8");
            hhpEncoding.Text = Encoding.Default.WebName;
        }

        private void OKBtn_Click(object sender, EventArgs e) {

        }
    }
}