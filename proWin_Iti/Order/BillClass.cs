using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti.Model
{
    internal class BillClass
    {
        public int ID_bill { get; set; }
        public double price { get; set; }
        public string name_product { get; set; }
        public int Qountity { get; set; }
        public double Sum_Total { get; set; }
        public int Descound { get; set; }
        public string Details_Bill { get; set; }
        public string Name_Caher { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime date_Bill { get; set; }
        public string proname { get; set; }
        public string suppname { get; set; }
        public string catoname { get; set; }
        public BillClass(int iD_bill, double price, int qountity, double sum_Total, int descound, string details_Bill, string name_Caher, string name, string email, string phone,DateTime date_bill)
        {
            ID_bill = iD_bill;
            this.price = price;
            Qountity = qountity;
            Sum_Total = sum_Total;
            Descound = descound;
            Details_Bill = details_Bill;
            Name_Caher = name_Caher;
            Name = name;
            Email = email;
            Phone = phone;
            this.date_Bill = date_bill;
        }

        public BillClass()
        {
        }
    }
}
