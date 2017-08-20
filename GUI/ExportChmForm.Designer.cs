// Copyright (c) Microsoft Corporation.  All rights reserved.
//
namespace PackageThis
{
    partial class ExportChmForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChmFileTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkUrl = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.hhpEncoding = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guessTitles = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chm File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // ChmFileTextBox
            // 
            this.ChmFileTextBox.Location = new System.Drawing.Point(147, 8);
            this.ChmFileTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChmFileTextBox.Name = "ChmFileTextBox";
            this.ChmFileTextBox.ReadOnly = true;
            this.ChmFileTextBox.Size = new System.Drawing.Size(642, 25);
            this.ChmFileTextBox.TabIndex = 1;
            this.ChmFileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(147, 50);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(642, 25);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(802, 6);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(125, 32);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.Text = "&Browse...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Enabled = false;
            this.OKBtn.Location = new System.Drawing.Point(322, 206);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(125, 32);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(502, 206);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 32);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "chm";
            this.saveFileDialog1.Filter = "Chm files|*.chm";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(144, 261);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(253, 18);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Microsoft HTML Help Downloads";
            this.linkUrl.SetToolTip(this.linkLabel1, "https://msdn.microsoft.com/ja-jp/library/windows/desktop/ms669985%28v=vs.85%29.as" +
        "px?f=255&MSPPError=-2147217396");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = ".HHP encoding:";
            // 
            // hhpEncoding
            // 
            this.hhpEncoding.FormattingEnabled = true;
            this.hhpEncoding.Location = new System.Drawing.Point(147, 90);
            this.hhpEncoding.Name = "hhpEncoding";
            this.hhpEncoding.Size = new System.Drawing.Size(161, 26);
            this.hhpEncoding.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "* UTF-8/Unicode .hhp files aren\'t understood by help compiler!\r\n* Suitable encodi" +
    "ng is already selected and don\'t change it.\r\n* Select UTF-8 for other purpose th" +
    "an compile.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guessTitles);
            this.groupBox1.Location = new System.Drawing.Point(802, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title suggestions:";
            // 
            // guessTitles
            // 
            this.guessTitles.AutoScroll = true;
            this.guessTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessTitles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.guessTitles.Location = new System.Drawing.Point(3, 21);
            this.guessTitles.Name = "guessTitles";
            this.guessTitles.Size = new System.Drawing.Size(160, 260);
            this.guessTitles.TabIndex = 0;
            // 
            // ExportChmForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(980, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hhpEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ChmFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportChmForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export to Chm";
            this.Load += new System.EventHandler(this.ExportChmForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.TextBox ChmFileTextBox;
        public System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip linkUrl;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox hhpEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.FlowLayoutPanel guessTitles;
    }
}