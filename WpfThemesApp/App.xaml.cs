using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfThemesApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        System.Threading.Mutex mutex;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //bool appNew;
            //string mutexName = "Application";
            //mutex = new System.Threading.Mutex(true, mutexName, out appNew);
            //if (!appNew)
            //    this.Shutdown();
        }
    }
}
