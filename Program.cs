using proWin_Iti.Loading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using proWin_Iti.log;
using proWin_Iti.admin;
using proWin_Iti.Order;

namespace proWin_Iti
{
    internal static class Program
    {


        public static string salesMan;
        public static string Type_User_by_login_BYID;
        public static bool state;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading_Page());
            
            //Loading_Page
            //Logg
            //Bill
            //Add_countUser
            //AddCustomer
            //adduser
            //Home_Page

        }
    }
}
