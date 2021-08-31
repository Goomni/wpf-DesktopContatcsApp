using DesktopContatcsApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopContatcsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            databaseName = "Contacts.db";
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            databasePath = System.IO.Path.Combine(folderPath, databaseName);           
        }

        public static string databaseName;
        public static string folderPath;
        public static string databasePath;
    }
}
