// <copyright file="ConversionResult.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-18-2010</date>
// <summary>Holds enums listing the possible Conversion Status and conversion results.</summary>

namespace SolutionConverterLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Describes the conversion status.
    /// </summary>
    public enum ConversionStatus
    {
        /// <summary>
        /// Marks a successful conversion.
        /// </summary>
        [StringValue("The conversion completed successfully.")]
        Succeeded,

        /// <summary>
        /// Marks a failure to convert.
        /// </summary>
        [StringValue("The conversion failed to complete.")]
        Failed,

        /// <summary>
        /// Marks a partially completed conversion.
        /// </summary>
        [StringValue("The conversion completed with errors.")]
        Partial,

        /// <summary>
        /// Marks a failure to convert due to the converter not being ready.
        /// </summary>
        [StringValue("The converter is not ready, no conversion occured.")]
        NotReady
    }

    public struct ConversionResult
    {
        /// <summary>
        /// The status of the conversion.
        /// </summary>
        public ConversionStatus ConversionStatus;

        /// <summary>
        /// A reference to the converter.
        /// </summary>
        public IConverter ConverterReference;
    }
}
