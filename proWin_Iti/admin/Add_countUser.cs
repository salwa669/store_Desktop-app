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

namespace proWin_Iti.admin
{
    internal partial class Add_countUser : Form
    {

        public Add_countUser()
        {
            InitializeComponent();
        }
       static List<Admin> list = new List<Admin>();
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bool state = false;
            if (radioButton1.Checked)
                state = true;
            else
                state = false;
            Admin a = new Admin(++counter, txtname.Text, txtphone.Text, txtemail.Text, txtpass.Text, txtaddress.Text,state);

            list.Add(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.ToList();
            dataGridView1.Columns["Id_Admin"].Visible = false;
            clear();

        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            var a = list.Where(x => x.Id_Admin == id).FirstOrDefault();
            a.Email = txtemail.Text;
            a.UserName = txtname.Text;
            a.Phone = txtphone.Text;
            a.password = txtpass.Text;
            if (radioButton1.Checked)
                a.state = true;
            else
                a.state = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.ToList();
            dataGridView1.Columns["Id_Admin"].Visible = false;
            clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var a = list.Where(x => x.Id_Admin == id).FirstOrDefault();
            txtname.Text = a.UserName;
            txtemail.Text = a.Email;
            txtpass.Text = a.password;
            txtphone.Text = a.Phone;
            txtaddress.Text = a.address;
            if (a.state)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
           

        }
        private void clear()
        {
            txtname.Text = txtemail.Text = txtpass.Text = txtphone.Text =txtaddress.Text= "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var a = list.Where(x => x.Id_Admin == id).FirstOrDefault();
            list.Remove(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=list.ToList();
            dataGridView1.Columns["Id_Admin"].Visible = false;
        }

        //public static List<Admin> returnlist_AccountUser()
        //{
        //    List<Admin> li = list.ToList();
        //    return li;
        //}
    }
}
