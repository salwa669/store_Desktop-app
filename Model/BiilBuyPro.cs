using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proWin_Iti.Model
{
    internal class BiilBuyPro
    {
        public int ID_bill { get; set; }
        public int Qountity { get;  set; }
        public double Sum_Total { get;  set; }
        public double price { get; set; }
        public string proname { get; set; }
        public string suppname { get; set; }
        public string catoname { get; set; }
        public DateTime date_Bill { get; set; }

        public BiilBuyPro(int iD_bill, double price, int qountity, double sum_Total, string proname, string suppname, string catoname, DateTime date_bill)
        {
            ID_bill = iD_bill;
            this.price = price;
            Qountity = qountity;
            Sum_Total = sum_Total;
            this.proname = proname;
            this.suppname = suppname;
            this.catoname = catoname;
            this.date_Bill = date_bill;
        }

    }
}
