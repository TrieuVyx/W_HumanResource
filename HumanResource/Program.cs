﻿using System;
using System.Windows.Forms;
using HumanResource.src.View.Auth;
using 
namespace HumanResource
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
            //Application.Run(new SignUpForm());            
            //Application.Run(new LoginForm());
            Application.Run(new MainApplication());
        }
    }
}
