// <copyright file="SolutionVersion.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-14-2010</date>
// <summary>Holds enums listing the solution and IDE types.</summary>

namespace SolutionConverterLib
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Lists all possible solution versions.
    /// </summary>
    public enum VisualStudioVersion
    {
        /// <summary>
        /// Unknown Visual Studio version.
        /// </summary>
        [StringValue("Unknown")]
        Unknown,
        
        /// <summary>
        /// Visual Studio 2002.
        /// </summary>
        [StringValue("Format Version 7.00")]
        VisualStudio2002 = 2002,

        /// <summary>
        /// Visual Studio 2003.
        /// </summary>
        [StringValue("Format Version 8.00")]
        VisualStudio2003 = 2003,

        /// <summary>
        /// Visual Studio 2005.
        /// </summary>
        [StringValue("Format Version 9.00")]
        VisualStudio2005 = 2005,

        /// <summary>
        /// Visual Studio 2008.
        /// </summary>
        [StringValue("Format Version 10.00")]
        VisualStudio2008 = 2008,

        /// <summary>
        /// Visual Studio 2010.
        /// </summary>
        [StringValue("Format Version 11.00")]
        VisualStudio2010 = 2010,
    }

    /// <summary>
    /// Lists all possible IDE versions.
    /// </summary>
    public enum IdeVersion
    {
        /// <summary>
        /// Using the default version or Unknown.
        /// </summary>
        [StringValue("None")]
        Default,

        /// <summary>
        /// The full Visual Studio version.
        /// </summary>
        [StringValue("Visual Studio")]
        VisualStudio,

        /// <summary>
        /// C# Exoress Edition.
        /// </summary>
        [StringValue("Visual C# Express")]
        CSExpress,

        /// <summary>
        /// Visual Basic Express Edition.
        /// </summary>
        [StringValue("Visual Basic Express")]
        VBExpress
    }
}
