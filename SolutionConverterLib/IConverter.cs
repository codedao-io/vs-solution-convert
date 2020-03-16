// <copyright file="IConverter.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-18-2010</date>
// <summary>An interface describing all converter objects.</summary>

namespace SolutionConverterLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// An interface describing all converter objects.
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Gets the name of the solution or project the converter is working on.
        /// </summary>
        /// <value>The name of the solution or project.</value>
        string Name { get; }

        /// <summary>
        /// Gets the visual studio version the solution or project is intended for.
        /// </summary>
        /// <value>The visual studio version.</value>
        VisualStudioVersion VisualStudioVersion { get; }

        /// <summary>
        /// Gets the IDE version the solution or project is intended for.
        /// </summary>
        /// <value>The IDE version.</value>
        IdeVersion IdeVersion { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is ready.
        /// </summary>
        /// <value><c>true</c> if this instance is ready; otherwise, <c>false</c>.</value>
        bool IsReady { get; }

        /// <summary>
        /// Loads the solution or project.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns><c>true</c> if successful; <c>false</c> otherwise.</returns>
        bool Load(string path);

        /// <summary>
        /// Reloads the solution or project.
        /// </summary>
        /// <returns><c>true</c> if successful; <c>false</c> otherwise.</returns>
        bool Reload();

        /// <summary>
        /// Converts the solution or project to another version.
        /// </summary>
        /// <param name="visualStudioVersion">The Visual Studio version.</param>
        /// <returns><c>true</c> if the conversion succeeded; otherwise, <c>false</c>.</returns>
        ConversionResult ConvertTo(VisualStudioVersion visualStudioVersion);

        /// <summary>
        /// Converts the solution or project to another version.
        /// </summary>
        /// <param name="visualStudioVersion">The Visual Studio version.</param>
        /// <param name="ideVersion">The IDE version.</param>
        /// <returns><c>true</c> if the conversion succeeded; otherwise, <c>false</c>.</returns>
        ConversionResult ConvertTo(VisualStudioVersion visualStudioVersion, IdeVersion ideVersion);
    }
}
