// <copyright file="Form1.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-14-2010</date>

namespace SolutionConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using SolutionConverterLib;

    /// <summary>
    /// Form1 class.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Reference to the currently loaded solution.
        /// </summary>
        private SolutionConverter solutionConverter;

        /// <summary>
        /// The path to the solution.
        /// </summary>
        private string solutionPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.solutionConverter = null;
            this.solutionPath = null;
            this.ResetForm();

            // ProjectConverter a = new ProjectConverter(@"E:\F\BackUp\My Projects\HIT\Year2\C-Sharp\SolutionConverter\SolutionConverter\bin\Debug\TotalLineAccumulator.csproj");
            // a.ConvertTo(VisualStudioVersion.VisualStudio2010);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        /// <param name="solutionPath">The solution path.</param>
        public Form1(string solutionPath) : this()
        {
            this.solutionPath = solutionPath;
        }

        /// <summary>
        /// Loads the solution.
        /// </summary>
        /// <param name="solutionPath">The solution path.</param>
        private void LoadSolution(string solutionPath)
        {
            if (solutionPath != null)
            {
                this.solutionConverter = new SolutionConverter(solutionPath);
                if (this.solutionConverter.IsReady)
                {
                    this.Text = "Solution Converter - " + this.solutionConverter.Name;
                    this.SolutionPathLbl.Text = this.solutionConverter.Name + " (" + solutionPath + ")";
                    this.SolutionPathLbl.Enabled = true;
                    this.CurrentSolutionLbl.Enabled = true;
                    switch (this.solutionConverter.VisualStudioVersion)
                    {
                        case VisualStudioVersion.VisualStudio2002:
                            this.chkVS2002.Checked = true;
                            break;
                        case VisualStudioVersion.VisualStudio2003:
                            this.chkVS2003.Checked = true;
                            break;
                        case VisualStudioVersion.VisualStudio2005:
                            this.chkVS2005.Checked = true;
                            this.ConvertBtn.Enabled = true;
                            break;
                        case VisualStudioVersion.VisualStudio2008:
                            this.chkVS2008.Checked = true;
                            this.ConvertBtn.Enabled = true;
                            break;
                        case VisualStudioVersion.VisualStudio2010:
                            this.chkVS2010.Checked = true;
                            this.ConvertBtn.Enabled = true;
                            break;
                    }

                    switch (this.solutionConverter.IdeVersion)
                    {
                        case IdeVersion.VisualStudio:
                            this.chkVS.Checked = true;
                            break;
                        case IdeVersion.CSExpress:
                            this.chkCsExp.Checked = true;
                            break;
                        case IdeVersion.VBExpress:
                            this.chkVbExp.Checked = true;
                            break;
                    }                    
                }
            }
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void ResetForm()
        {
            this.Text = "Solution Converter";

            foreach (Control chkBox in this.panel1.Controls)
            {
                (chkBox as CheckBox).Checked = false;
            }

            this.SolutionPathLbl.Text = "N/A";
            this.SolutionPathLbl.Enabled = false;
            this.CurrentSolutionLbl.Enabled = false;
            this.ConvertBtn.Enabled = false;
            this.solutionPath = null;
            this.solutionConverter = null;
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OpenSolution_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.solutionPath = this.openFileDialog1.FileName;
                this.LoadSolution(this.solutionPath);
            }
        }

        /// <summary>
        /// Handles the Click event of the ConvertBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            VisualStudioVersion solVer = VisualStudioVersion.Unknown;
            IdeVersion ideVer = IdeVersion.Default;

            if (this.rdoCsExp.Checked == true)
            {
                ideVer = IdeVersion.CSExpress;
            }
            else if (this.rdoVbExp.Checked == true)
            {
                ideVer = IdeVersion.VBExpress;
            }
            else if (this.rdoVS.Checked == true)
            {
                ideVer = IdeVersion.VisualStudio;
            }

            if (this.rdoVS2002.Checked == true)
            {
                solVer = VisualStudioVersion.VisualStudio2002;
            }
            else if (this.rdoVS2003.Checked == true)
            {
                solVer = VisualStudioVersion.VisualStudio2003;
            }
            else if (this.rdoVS2005.Checked == true)
            {
                solVer = VisualStudioVersion.VisualStudio2005;
            }
            else if (this.rdoVS2008.Checked == true)
            {
                solVer = VisualStudioVersion.VisualStudio2008;
            }
            else if (this.rdoVS2010.Checked == true)
            {
                solVer = VisualStudioVersion.VisualStudio2010;
            }

            ConversionResult result = this.solutionConverter.ConvertTo(solVer, ideVer);
            if (result.ConversionStatus == ConversionStatus.Succeeded)
            {
                MessageBox.Show(ConversionStatus.Succeeded.GetStringValue(), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetForm();
            }
            else if (result.ConversionStatus == ConversionStatus.Partial)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine(ConversionStatus.Partial.GetStringValue());
                this.solutionConverter.ProjectConversionResults.ForEach(delegate(ConversionResult conversionResult)
                {
                    message.AppendLine(conversionResult.ConverterReference.Name + ": " + conversionResult.ConversionStatus.GetStringValue());
                });
                MessageBox.Show(message.ToString(), "Partial success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(ConversionStatus.Failed.GetStringValue(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.solutionPath != null)
            {
                this.LoadSolution(this.solutionPath);
            }
        }

        /// <summary>
        /// Handles the Click event of the AboutBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This program was created by Arthur Liberman.\n\n© 2010\n\nVisual Studio 2002 & 2003 conversion may be enabled in the future.", 
                "About",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
