///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley O, owenrm1@etsu.edu, Josh, xxxx@xxx.xxx, Daniel L, lynchda@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: This code is the main entry point for the application.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
