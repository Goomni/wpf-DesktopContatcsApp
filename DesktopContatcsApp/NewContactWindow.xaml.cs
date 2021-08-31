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
using System.Windows.Shapes;

namespace DesktopContatcsApp
{
    /// <summary>
    /// NewContactWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        } 

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // save Contact
            using SQLiteConnection sqlConn = new(App.databasePath);
            var newContact = new Contact(nameTextBox.Text, emailTextBox.Text, phoneNumberTextBox.Text);
            sqlConn.Insert(newContact);
            MainWindow.contactsDic[newContact.ID] = newContact;
            this.Close();
        }
    }
}
