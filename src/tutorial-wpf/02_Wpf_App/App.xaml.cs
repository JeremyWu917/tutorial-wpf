using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _02_Wpf_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            MainWindow wnd = new();
            // Do stuff here, e.g. to the window
            // wnd.Title = "Something else";
            if (e.Args.Length == 1)
            {
                _ = MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            }
            // Show the window
            wnd.Show();
        }
    }
}
