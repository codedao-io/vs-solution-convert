// <copyright file="Program.cs" company="ALCPU">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Arthur Liberman</author>
// <email>Arthur_Liberman@hotmail.com</email>
// <date>04-14-2010</date>
// <summary>Holds the entry point function.</summary>

namespace SolutionConverter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// The main class which holds the program's entry point method.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                Application.Run(new Form1(args[0]));
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
