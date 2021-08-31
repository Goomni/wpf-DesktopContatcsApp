using DesktopContatcsApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopContatcsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadDatabase();
        }

        static public Dictionary<long, Contact> contactsDic = new Dictionary<long, Contact>();

        private void newContactButton_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog();
        }
        void loadDatabase()
        {
            using var sqlConn = new SQLiteConnection(App.databasePath);
            sqlConn.CreateTable<Contact>();
            foreach(var contact in sqlConn.Table<Contact>())
            {
                contactsDic[contact.ID] = contact;
            }
        }
    }
}
