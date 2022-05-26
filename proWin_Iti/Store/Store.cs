using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti
{
    public class Store
    {
        public string Name { get; set; }
        public string Address{ get; set; }
        public string Phone{ get; set; }
        public string StoreManager { get; set; }

        public Store(string Name,string Address,string Phone,string StoreManager)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.StoreManager = StoreManager;
        }





        public Store(string name)
        {
            Name = name;
        }
    }
}
