﻿using System;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Models;



namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            string connectionString = "Data Source=SchoolDb.db;Version=3;";


            Migration.CreateTables(connectionString);

           // Application.Run(new LoginForm());
            //Application.Run(new MainPanelForm());
            //Application.Run(new MarkForm());
            Application.Run(new CourseForm());
            
        }
    }
}
