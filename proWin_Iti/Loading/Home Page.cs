using proWin_Iti.admin;
using proWin_Iti.Customer;
using proWin_Iti.Employee;
using proWin_Iti.log;
using proWin_Iti.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proWin_Iti.Loading
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
           
        }
        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void addNewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.ShowDialog();
        }

        private void allBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_bill a = new All_bill();
            a.ShowDialog();
        }
        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_customer c = new Add_customer();
            c.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logg l = new Logg();
            l.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Employee a = new Add_Employee();
            a.ShowDialog();
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Employee s = new Search_Employee();
            s.ShowDialog();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void settingEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting_employee s = new Setting_employee();
            s.ShowDialog();
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Customer s = new Search_Customer();
            s.ShowDialog();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer aa = new AddCustomer();
            aa.ShowDialog();
        }

        private void Home_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Home_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.salesMan = "";
            Program.state = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.ShowDialog();
        }

        private void settingToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_customer c = new Add_customer();
            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Employee a = new Add_Employee();
            a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void addNewProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void searchAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.ShowDialog();
        }

        private void catToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            catigory c = new catigory();
            c.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void billBySuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.BillSallfromResources b = new Order.BillSallfromResources();
            b.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var emp = Setting_employee.returnlist_AccountUser();
            if (emp.Count > 0)
            {
                branchToolStripMenuItem.Enabled = true;
            }
            List<Store> st = Form4.fillstore();
            if (st.Count > 0)
            {
                catToolStripMenuItem.Enabled = true;
                suppliersToolStripMenuItem.Enabled = true;
            }
            if (Form1.fillproduct().Count() > 0)
            {
                customerToolStripMenuItem.Enabled = true;
            }
            if (catigory.clist().Count > 0)
            {
                productToolStripMenuItem.Enabled = true;
            }
            if (billBySuppliersToolStripMenuItem.Enabled==true)
            {
                billToolStripMenuItem.Enabled = true;
            }
            if (billToolStripMenuItem.Enabled == true)
            {
                panel2.Enabled = true;
                timer2.Stop();
            }
            if(Form1.fillproduct().Count() > 0 && sellers.clist().Count>0 && AddCustomer.returnlist_AccountUser().Count() > 0 && catigory.clist().Count > 0 && st.Count > 0 )
            {
                billBySuppliersToolStripMenuItem.Enabled = true;
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sellers s = new sellers();
            s.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellers s = new sellers();
            s.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Logg l = new Logg();
            l.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.salesMan = "";
            Program.state = false;
        }
    }
}
