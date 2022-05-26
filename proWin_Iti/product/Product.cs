using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string categoray { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string store { get; set; }
        public Product(int id,string name,int quantity,double price, DateTime expiredate,string categoray,string store)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.categoray = categoray;
            this.ExpiredDate = expiredate;
            this.store = store;
        }
       

    }
}
