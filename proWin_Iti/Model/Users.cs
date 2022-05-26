using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti.Model
{
    internal class Users
    {
        public int ID_users { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Users(int iD_users, string name, string email, string phone)
        {
            ID_users = iD_users;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
