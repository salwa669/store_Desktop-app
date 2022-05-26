using proWin_Iti.admin;
using proWin_Iti.Loading;
using proWin_Iti.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proWin_Iti.log
{
    public partial class Logg : Form
    {
        public Logg()
        {
            InitializeComponent();
            txtName.Focus();
        }

        private void Logg_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtName.Text = txtpassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Admin> list = Setting_employee.returnlist_AccountUser();
            Admin ad = new Admin(1, "test", "01111", "test@gmail.com", "123", "test", true);
            list.Add(ad);
            var query = list.Where(ww => ww.UserName == txtName.Text && ww.password == txtpassword.Text).FirstOrDefault();
            if (query == null)
            {
                MessageBox.Show("Invaild Insert data ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Program.state = query.state;
                Program.salesMan = query.UserName;
                this.Visible = false;
                Home_Page b = new Home_Page();
                b.ShowDialog();
                this.Visible = false;
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
