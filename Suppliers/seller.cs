using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti
{
   public class seller
    {
        public string Name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string store_name { get; set; }
        public seller(string name, string address, string phone, string email,string store_name)
        {
            Name = name;
            this.phone = phone;
            this.address = address;
            Email = email;
            this.store_name = store_name;
        }
        //List<seller> sellers = new List<seller>();


    }
}
