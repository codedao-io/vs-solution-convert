// <copyright file="Form1.Designer.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-14-2010</date>

namespace SolutionConverter
{
    /// <summary>
    /// Form1 class.
    /// </summary>
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Open dialog control.
        /// </summary>
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        /// <summary>
        /// button1 on form.
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkVS2002 = new System.Windows.Forms.CheckBox();
            this.chkVS2003 = new System.Windows.Forms.CheckBox();
            this.chkVS2005 = new System.Windows.Forms.CheckBox();
            this.chkVS2008 = new System.Windows.Forms.CheckBox();
            this.chkVS2010 = new System.Windows.Forms.CheckBox();
            this.chkVS = new System.Windows.Forms.CheckBox();
            this.chkCsExp = new System.Windows.Forms.CheckBox();
            this.chkVbExp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdoVS2002 = new System.Windows.Forms.RadioButton();
            this.rdoVS2003 = new System.Windows.Forms.RadioButton();
            this.rdoVS2005 = new System.Windows.Forms.RadioButton();
            this.rdoVS2008 = new System.Windows.Forms.RadioButton();
            this.rdoVS2010 = new System.Windows.Forms.RadioButton();
            this.rdoVS = new System.Windows.Forms.RadioButton();
            this.rdoCsExp = new System.Windows.Forms.RadioButton();
            this.rdoVbExp = new System.Windows.Forms.RadioButton();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.CurrentSolutionLbl = new System.Windows.Forms.Label();
            this.SolutionPathLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Visual Studio Solution|*.sln";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenSolution_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertBtn.Location = new System.Drawing.Point(359, 256);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(104, 23);
            this.ConvertBtn.TabIndex = 2;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 223);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current version";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chkVS2002);
            this.panel1.Controls.Add(this.chkVS2003);
            this.panel1.Controls.Add(this.chkVS2005);
            this.panel1.Controls.Add(this.chkVS2008);
            this.panel1.Controls.Add(this.chkVS2010);
            this.panel1.Controls.Add(this.chkVS);
            this.panel1.Controls.Add(this.chkCsExp);
            this.panel1.Controls.Add(this.chkVbExp);
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 198);
            this.panel1.TabIndex = 0;
            // 
            // chkVS2002
            // 
            this.chkVS2002.AutoCheck = false;
            this.chkVS2002.AutoSize = true;
            this.chkVS2002.Location = new System.Drawing.Point(3, 3);
            this.chkVS2002.Name = "chkVS2002";
            this.chkVS2002.Size = new System.Drawing.Size(114, 17);
            this.chkVS2002.TabIndex = 24;
            this.chkVS2002.Text = "Visual Studio 2002";
            this.chkVS2002.UseVisualStyleBackColor = true;
            // 
            // chkVS2003
            // 
            this.chkVS2003.AutoCheck = false;
            this.chkVS2003.AutoSize = true;
            this.chkVS2003.Location = new System.Drawing.Point(3, 26);
            this.chkVS2003.Name = "chkVS2003";
            this.chkVS2003.Size = new System.Drawing.Size(114, 17);
            this.chkVS2003.TabIndex = 25;
            this.chkVS2003.Text = "Visual Studio 2003";
            this.chkVS2003.UseVisualStyleBackColor = true;
            // 
            // chkVS2005
            // 
            this.chkVS2005.AutoCheck = false;
            this.chkVS2005.AutoSize = true;
            this.chkVS2005.Location = new System.Drawing.Point(3, 49);
            this.chkVS2005.Name = "chkVS2005";
            this.chkVS2005.Size = new System.Drawing.Size(114, 17);
            this.chkVS2005.TabIndex = 26;
            this.chkVS2005.Text = "Visual Studio 2005";
            this.chkVS2005.UseVisualStyleBackColor = true;
            // 
            // chkVS2008
            // 
            this.chkVS2008.AutoCheck = false;
            this.chkVS2008.AutoSize = true;
            this.chkVS2008.Location = new System.Drawing.Point(3, 72);
            this.chkVS2008.Name = "chkVS2008";
            this.chkVS2008.Size = new System.Drawing.Size(114, 17);
            this.chkVS2008.TabIndex = 27;
            this.chkVS2008.Text = "Visual Studio 2008";
            this.chkVS2008.UseVisualStyleBackColor = true;
            // 
            // chkVS2010
            // 
            this.chkVS2010.AutoCheck = false;
            this.chkVS2010.AutoSize = true;
            this.chkVS2010.Location = new System.Drawing.Point(3, 95);
            this.chkVS2010.Name = "chkVS2010";
            this.chkVS2010.Size = new System.Drawing.Size(114, 17);
            this.chkVS2010.TabIndex = 28;
            this.chkVS2010.Text = "Visual Studio 2010";
            this.chkVS2010.UseVisualStyleBackColor = true;
            // 
            // chkVS
            // 
            this.chkVS.AutoCheck = false;
            this.chkVS.AutoSize = true;
            this.chkVS.Location = new System.Drawing.Point(3, 127);
            this.chkVS.Name = "chkVS";
            this.chkVS.Size = new System.Drawing.Size(128, 17);
            this.chkVS.TabIndex = 29;
            this.chkVS.Text = "Visual Studio Solution";
            this.chkVS.UseVisualStyleBackColor = true;
            // 
            // chkCsExp
            // 
            this.chkCsExp.AutoCheck = false;
            this.chkCsExp.AutoSize = true;
            this.chkCsExp.Location = new System.Drawing.Point(3, 150);
            this.chkCsExp.Name = "chkCsExp";
            this.chkCsExp.Size = new System.Drawing.Size(152, 17);
            this.chkCsExp.TabIndex = 30;
            this.chkCsExp.Text = "Visual C# Express Solution";
            this.chkCsExp.UseVisualStyleBackColor = true;
            // 
            // chkVbExp
            // 
            this.chkVbExp.AutoCheck = false;
            this.chkVbExp.AutoSize = true;
            this.chkVbExp.Location = new System.Drawing.Point(3, 173);
            this.chkVbExp.Name = "chkVbExp";
            this.chkVbExp.Size = new System.Drawing.Size(164, 17);
            this.chkVbExp.TabIndex = 31;
            this.chkVbExp.Text = "Visual Basic Express Solution";
            this.chkVbExp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(228, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output version";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2002);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2003);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2005);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2008);
            this.splitContainer1.Panel1.Controls.Add(this.rdoVS2010);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rdoVS);
            this.splitContainer1.Panel2.Controls.Add(this.rdoCsExp);
            this.splitContainer1.Panel2.Controls.Add(this.rdoVbExp);
            this.splitContainer1.Size = new System.Drawing.Size(214, 198);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
            // 
            // rdoVS2002
            // 
            this.rdoVS2002.AutoSize = true;
            this.rdoVS2002.Enabled = false;
            this.rdoVS2002.Location = new System.Drawing.Point(3, 3);
            this.rdoVS2002.Name = "rdoVS2002";
            this.rdoVS2002.Size = new System.Drawing.Size(113, 17);
            this.rdoVS2002.TabIndex = 6;
            this.rdoVS2002.TabStop = true;
            this.rdoVS2002.Text = "Visual Studio 2002";
            this.rdoVS2002.UseVisualStyleBackColor = true;
            // 
            // rdoVS2003
            // 
            this.rdoVS2003.AutoSize = true;
            this.rdoVS2003.Enabled = false;
            this.rdoVS2003.Location = new System.Drawing.Point(3, 26);
            this.rdoVS2003.Name = "rdoVS2003";
            this.rdoVS2003.Size = new System.Drawing.Size(113, 17);
            this.rdoVS2003.TabIndex = 5;
            this.rdoVS2003.TabStop = true;
            this.rdoVS2003.Text = "Visual Studio 2003";
            this.rdoVS2003.UseVisualStyleBackColor = true;
            // 
            // rdoVS2005
            // 
            this.rdoVS2005.AutoSize = true;
            this.rdoVS2005.Location = new System.Drawing.Point(3, 49);
            this.rdoVS2005.Name = "rdoVS2005";
            this.rdoVS2005.Size = new System.Drawing.Size(113, 17);
            this.rdoVS2005.TabIndex = 8;
            this.rdoVS2005.TabStop = true;
            this.rdoVS2005.Text = "Visual Studio 2005";
            this.rdoVS2005.UseVisualStyleBackColor = true;
            // 
            // rdoVS2008
            // 
            this.rdoVS2008.AutoSize = true;
            this.rdoVS2008.Location = new System.Drawing.Point(3, 72);
            this.rdoVS2008.Name = "rdoVS2008";
            this.rdoVS2008.Size = new System.Drawing.Size(113, 17);
            this.rdoVS2008.TabIndex = 7;
            this.rdoVS2008.TabStop = true;
            this.rdoVS2008.Text = "Visual Studio 2008";
            this.rdoVS2008.UseVisualStyleBackColor = true;
            // 
            // rdoVS2010
            // 
            this.rdoVS2010.AutoSize = true;
            this.rdoVS2010.Checked = true;
            this.rdoVS2010.Location = new System.Drawing.Point(3, 95);
            this.rdoVS2010.Name = "rdoVS2010";
            this.rdoVS2010.Size = new System.Drawing.Size(113, 17);
            this.rdoVS2010.TabIndex = 2;
            this.rdoVS2010.TabStop = true;
            this.rdoVS2010.Text = "Visual Studio 2010";
            this.rdoVS2010.UseVisualStyleBackColor = true;
            // 
            // rdoVS
            // 
            this.rdoVS.AutoSize = true;
            this.rdoVS.Checked = true;
            this.rdoVS.Location = new System.Drawing.Point(3, 7);
            this.rdoVS.Name = "rdoVS";
            this.rdoVS.Size = new System.Drawing.Size(127, 17);
            this.rdoVS.TabIndex = 5;
            this.rdoVS.TabStop = true;
            this.rdoVS.Text = "Visual Studio Solution";
            this.rdoVS.UseVisualStyleBackColor = true;
            // 
            // rdoCsExp
            // 
            this.rdoCsExp.AutoSize = true;
            this.rdoCsExp.Location = new System.Drawing.Point(3, 30);
            this.rdoCsExp.Name = "rdoCsExp";
            this.rdoCsExp.Size = new System.Drawing.Size(151, 17);
            this.rdoCsExp.TabIndex = 7;
            this.rdoCsExp.TabStop = true;
            this.rdoCsExp.Text = "Visual C# Express Solution";
            this.rdoCsExp.UseVisualStyleBackColor = true;
            // 
            // rdoVbExp
            // 
            this.rdoVbExp.AutoSize = true;
            this.rdoVbExp.Location = new System.Drawing.Point(3, 53);
            this.rdoVbExp.Name = "rdoVbExp";
            this.rdoVbExp.Size = new System.Drawing.Size(163, 17);
            this.rdoVbExp.TabIndex = 6;
            this.rdoVbExp.TabStop = true;
            this.rdoVbExp.Text = "Visual Basic Express Solution";
            this.rdoVbExp.UseVisualStyleBackColor = true;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutBtn.Location = new System.Drawing.Point(185, 256);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(104, 23);
            this.AboutBtn.TabIndex = 4;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // CurrentSolutionLbl
            // 
            this.CurrentSolutionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentSolutionLbl.AutoSize = true;
            this.CurrentSolutionLbl.Enabled = false;
            this.CurrentSolutionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSolutionLbl.Location = new System.Drawing.Point(15, 9);
            this.CurrentSolutionLbl.Name = "CurrentSolutionLbl";
            this.CurrentSolutionLbl.Size = new System.Drawing.Size(100, 13);
            this.CurrentSolutionLbl.TabIndex = 5;
            this.CurrentSolutionLbl.Text = "Current solution:";
            // 
            // SolutionPathLbl
            // 
            this.SolutionPathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SolutionPathLbl.AutoEllipsis = true;
            this.SolutionPathLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SolutionPathLbl.Enabled = false;
            this.SolutionPathLbl.Location = new System.Drawing.Point(121, 9);
            this.SolutionPathLbl.Name = "SolutionPathLbl";
            this.SolutionPathLbl.Size = new System.Drawing.Size(336, 15);
            this.SolutionPathLbl.TabIndex = 6;
            this.SolutionPathLbl.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 291);
            this.Controls.Add(this.SolutionPathLbl);
            this.Controls.Add(this.CurrentSolutionLbl);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Solution Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rdoVS2002;
        private System.Windows.Forms.RadioButton rdoVS2003;
        private System.Windows.Forms.RadioButton rdoVS2005;
        private System.Windows.Forms.RadioButton rdoVS2008;
        private System.Windows.Forms.RadioButton rdoVS2010;
        private System.Windows.Forms.RadioButton rdoVS;
        private System.Windows.Forms.RadioButton rdoCsExp;
        private System.Windows.Forms.RadioButton rdoVbExp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkVS2002;
        private System.Windows.Forms.CheckBox chkVS2003;
        private System.Windows.Forms.CheckBox chkVS2005;
        private System.Windows.Forms.CheckBox chkVS2008;
        private System.Windows.Forms.CheckBox chkVS2010;
        private System.Windows.Forms.CheckBox chkVS;
        private System.Windows.Forms.CheckBox chkCsExp;
        private System.Windows.Forms.CheckBox chkVbExp;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Label CurrentSolutionLbl;
        private System.Windows.Forms.Label SolutionPathLbl;
    }
}

