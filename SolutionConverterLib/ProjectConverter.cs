// <copyright file="ProjectConverter.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-16-2010</date>
// <summary>Holds the class responsible for converting between project versions.</summary>

namespace SolutionConverterLib
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Converts from one Visual Studio project version to another.
    /// </summary>
    public class ProjectConverter : IConverter
    {
        /// <summary>
        /// Represents the namespace the project files use.
        /// </summary>
        private readonly string namespaceName = "http://schemas.microsoft.com/developer/msbuild/2003";

        /// <summary>
        /// The path to the project file.
        /// </summary>
        private string projectPath;

        /// <summary>
        /// The 'ToolsVersion' attribute.
        /// </summary>
        private XAttribute toolsVersion;

        /// <summary>
        /// The 'ProductVersion' element.
        /// </summary>
        private XElement productVersion;

        /// <summary>
        /// The 'TargetFrameworkVersion' element.
        /// </summary>
        private XElement targetFrameworkVersion;

        /// <summary>
        /// The 'Import' element's 'Project' attribute.
        /// </summary>
        private XAttribute importProject;

        /// <summary>
        /// The project's representation in an Xml object.
        /// </summary>
        private XDocument project;

        /// <summary>
        /// The version of the current project.
        /// </summary>
        private VisualStudioVersion vsVersion;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectConverter"/> class.
        /// </summary>
        /// <param name="projectPath">The solution path.</param>
        public ProjectConverter(string projectPath)
        {
            this.Load(projectPath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectConverter"/> class.
        /// </summary>
        protected ProjectConverter()
        {
        }

        /// <summary>
        /// Gets the visual studio version the project is intended for.
        /// </summary>
        /// <value>The visual studio version.</value>
        public VisualStudioVersion VisualStudioVersion
        {
            get { return this.vsVersion; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is ready.
        /// </summary>
        /// <value><c>true</c> if this instance is ready; otherwise, <c>false</c>.</value>
        public bool IsReady { get; protected set; }

        /// <summary>
        /// Gets the name of the solution or project the converter is working on.
        /// </summary>
        /// <value>The name of the solution or project.</value>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the IDE version the solution or project is intended for.
        /// </summary>
        /// <value>The IDE version.</value>
        public IdeVersion IdeVersion
        {
            get;
            protected set;
        }

        /// <summary>
        /// Loads the project.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <returns><c>true</c> if successful; <c>false</c> otherwise.</returns>
        public bool Load(string projectPath)
        {
            if (projectPath == null)
            {
                throw new Exception("projectPath can't be null");
            }

            this.projectPath = projectPath;
            return this.Reload();
        }

        /// <summary>
        /// Reloads the current project.
        /// </summary>
        /// <returns><c>true</c> if successful; <c>false</c> otherwise.</returns>
        public bool Reload()
        {
            try
            {
                this.project = XDocument.Load(this.projectPath);
            }
            catch (Exception)
            {
                this.project = null;
            }

            bool ret = false;
            this.vsVersion = VisualStudioVersion.Unknown;
            this.IsReady = false;
            if (this.project != null)
            {
                this.toolsVersion = this.project.Root.Attribute(XName.Get("ToolsVersion"));
                this.productVersion = this.project.Root.Element(XName.Get("PropertyGroup", this.namespaceName)).Element(XName.Get("ProductVersion", this.namespaceName));
                this.targetFrameworkVersion = this.project.Root.Element(XName.Get("PropertyGroup", this.namespaceName)).Element(XName.Get("TargetFrameworkVersion", this.namespaceName));
                this.importProject = this.project.Root.Element(XName.Get("Import", this.namespaceName)).Attribute(XName.Get("Project"));
                this.Name = Path.GetFileNameWithoutExtension(this.projectPath);

                this.vsVersion = this.GetVsVersion();
                this.IsReady = true;
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// Converts a project to another version.
        /// </summary>
        /// <param name="vsVersion">The Visual Studio version.</param>
        /// <returns><c>true</c> if the conversion succeeded; otherwise, <c>false</c>.</returns>
        public ConversionResult ConvertTo(VisualStudioVersion vsVersion)
        {
            ConversionResult ret = new ConversionResult();
            ret.ConverterReference = this;
            if (!this.IsReady)
            {
                ret.ConversionStatus = ConversionStatus.NotReady;
                return ret;
            }

            // Calling the relevant method for editing the attributes and elements of the XML.
            switch (vsVersion)
            {
                case VisualStudioVersion.VisualStudio2002:
                    this.ConvertToVs2002(vsVersion);
                    break;
                case VisualStudioVersion.VisualStudio2003:
                    this.ConvertToVs2003(vsVersion);
                    break;
                case VisualStudioVersion.VisualStudio2005:
                    this.ConvertToVs2005(vsVersion);
                    break;
                case VisualStudioVersion.VisualStudio2008:
                    this.ConvertToVs2008(vsVersion);
                    break;
                case VisualStudioVersion.VisualStudio2010:
                    this.ConvertToVs2010(vsVersion);
                    break;
            }

            // Saving the Project XML file.
            FileStream fileStream = null;
            XmlTextWriter writer = null;
            ret.ConverterReference = this;
            try
            {
                fileStream = new FileStream(this.projectPath, FileMode.Create);
                writer = new XmlTextWriter(fileStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                this.project.WriteTo(writer);
                ret.ConversionStatus = ConversionStatus.Succeeded;
            }
            catch (Exception)
            {
                ret.ConversionStatus = ConversionStatus.Failed;
            }
            finally
            {
                this.IsReady = false;
                if (writer != null)
                {
                    writer.Close();
                }
            }

            return ret;
        }

        /// <summary>
        /// Converts the solution or project to another version.
        /// </summary>
        /// <param name="visualStudioVersion">The Visual Studio version.</param>
        /// <param name="ideVersion">The IDE version.</param>
        /// <returns><c>true</c> if the conversion succeeded; otherwise, <c>false</c>.</returns>
        public ConversionResult ConvertTo(VisualStudioVersion visualStudioVersion, IdeVersion ideVersion)
        {
            return this.ConvertTo(visualStudioVersion, SolutionConverterLib.IdeVersion.Default);
        }

        /// <summary>
        /// Gets the Visual Studio version of the current project.
        /// </summary>
        /// <returns>The version of the current project.</returns>
        private VisualStudioVersion GetVsVersion()
        {
            VisualStudioVersion vsVer = VisualStudioVersion.Unknown;
            
            double product;
            if (Double.TryParse(this.productVersion.Value, out product))
            {
                if (product == 7)
                {
                    vsVer = VisualStudioVersion.VisualStudio2002;
                }
                else if (product == 7.1)
                {
                    vsVer = VisualStudioVersion.VisualStudio2003;
                }
                else if (product == 8)
                {
                    vsVer = VisualStudioVersion.VisualStudio2005;
                }
                else if (product == 9)
                {
                    vsVer = VisualStudioVersion.VisualStudio2008;
                }
                else if (product == 10)
                {
                    vsVer = VisualStudioVersion.VisualStudio2010;
                }
            }

            return vsVer;
        }

        #region Convert Functions

        /// <summary>
        /// Converts to VS2002 version.
        /// </summary>
        /// <param name="vsVersion">The Visual Studio version.</param>
        private void ConvertToVs2002(VisualStudioVersion vsVersion)
        {
            if (this.toolsVersion != null)
            {
                this.toolsVersion.Remove();
            }

            if (this.targetFrameworkVersion != null)
            {
                this.targetFrameworkVersion.Remove();
            }

            if (this.productVersion != null)
            {
                this.productVersion.Value = "7.0.0000";
            }

            if (this.importProject != null && !this.importProject.Value.Contains("$(MSBuildBinPath)"))
            {
                this.importProject.Value = this.importProject.Value.Replace("$(MSBuildToolsPath)", "$(MSBuildBinPath)");
            }
        }

        /// <summary>
        /// Converts to VS2003 version.
        /// </summary>
        /// <param name="vsVersion">The Visual Studio version.</param>
        private void ConvertToVs2003(VisualStudioVersion vsVersion)
        {
            if (this.toolsVersion != null)
            {
                this.toolsVersion.Remove();
            }

            if (this.targetFrameworkVersion != null)
            {
                this.targetFrameworkVersion.Remove();
            }

            if (this.productVersion != null)
            {
                this.productVersion.Value = "7.1.0000";
            }

            if (this.importProject != null && !this.importProject.Value.Contains("$(MSBuildBinPath)"))
            {
                this.importProject.Value = this.importProject.Value.Replace("$(MSBuildToolsPath)", "$(MSBuildBinPath)");
            }
        }

        /// <summary>
        /// Converts to VS2005 version.
        /// </summary>
        /// <param name="vsVersion">The Visual Studio version.</param>
        private void ConvertToVs2005(VisualStudioVersion vsVersion)
        {
            if (this.toolsVersion != null)
            {
                this.toolsVersion.Remove();
            }

            if (this.targetFrameworkVersion != null)
            {
                this.targetFrameworkVersion.Remove();
            }

            if (this.productVersion != null)
            {
                this.productVersion.Value = "8.0.50727";
            }

            if (this.importProject != null && !this.importProject.Value.Contains("$(MSBuildBinPath)"))
            {
                this.importProject.Value = this.importProject.Value.Replace("$(MSBuildToolsPath)", "$(MSBuildBinPath)");
            }
        }

        /// <summary>
        /// Converts to VS2008 version.
        /// </summary>
        /// <param name="vsVersion">The Visual Studio version.</param>
        private void ConvertToVs2008(VisualStudioVersion vsVersion)
        {
            if (this.toolsVersion != null)
            {
                double tools;
                if (Double.TryParse(this.toolsVersion.Value, out tools) && tools != 3.5)
                {
                    this.toolsVersion.Value = "3.5";
                }
            }
            else
            {
                this.project.Root.Add(new XAttribute(XName.Get("ToolsVersion"), "3.5"));
            }

            if (this.productVersion != null)
            {
                this.productVersion.Value = "9.0.21022";
            }

            if (this.targetFrameworkVersion != null)
            {
                double framework;
                if (Double.TryParse(
                    this.targetFrameworkVersion.Value.Substring(1, this.targetFrameworkVersion.Value.Length - 2),
                    out framework) &&
                    framework > 3.5)
                {
                    this.targetFrameworkVersion.Value = "v3.5";
                }
            }
            else
            {
                XElement newToolsVersion = new XElement(XName.Get("TargetFrameworkVersion", this.namespaceName), "v2.0");
                this.project.Root.Element(XName.Get("PropertyGroup", this.namespaceName)).Add(newToolsVersion);
            }

            if (this.importProject != null && !this.importProject.Value.Contains("$(MSBuildToolsPath)"))
            {
                this.importProject.Value = this.importProject.Value.Replace("$(MSBuildBinPath)", "$(MSBuildToolsPath)");
            }
        }

        /// <summary>
        /// Converts to VS2010 version.
        /// </summary>
        /// <param name="vsVersion">The Visual Studio version.</param>
        private void ConvertToVs2010(VisualStudioVersion vsVersion)
        {
            if (this.toolsVersion != null)
            {
                double tools;
                if (Double.TryParse(this.toolsVersion.Value, out tools) && tools != 4.0)
                {
                    this.toolsVersion.Value = "4.0";
                }
            }
            else
            {
                this.project.Root.Add(new XAttribute(XName.Get("ToolsVersion"), "4.0"));
            }

            if (this.productVersion != null)
            {
                this.productVersion.Value = "10.0.30319.1";
            }

            if (this.targetFrameworkVersion == null)
            {
                XElement newToolsVersion = new XElement(XName.Get("TargetFrameworkVersion", this.namespaceName), "v2.0");
                this.project.Root.Element(XName.Get("PropertyGroup", this.namespaceName)).Add(newToolsVersion);
            }

            if (this.importProject != null && !this.importProject.Value.Contains("$(MSBuildToolsPath)"))
            {
                this.importProject.Value = this.importProject.Value.Replace("$(MSBuildBinPath)", "$(MSBuildToolsPath)");
            }
        }

        #endregion

        #region IConvter Members

        #endregion
    }
}
