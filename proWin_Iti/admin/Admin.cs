using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti.Model
{
    internal class Admin
    {
        public int Id_Admin { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public bool state { get; set; }

        public Admin(int id_Admin, string userName, string phone, string email, string password, string address, bool state)
        {
            Id_Admin = id_Admin;
            UserName = userName;
            Phone = phone;
            Email = email;
            this.password = password;
            this.address = address;
            this.state = state;
        }
    }
}
