using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopContatcsApp.Classes
{
    public sealed class Contact
    {
        public Contact()
            : this("","","")
        {

        }
        public Contact(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        [PrimaryKey, AutoIncrement]
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void Clear()
        {
            ID = 0;
            Name = "";
            Email = "";
            PhoneNumber = "";
        }
    }
}
