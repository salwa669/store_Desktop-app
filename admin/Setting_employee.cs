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
    internal partial class Setting_employee : Form
    {
        public int Id_Admin { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public bool state { get; set; }

        public Setting_employee()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        public Setting_employee( string userName, string phone, string email, string password, string address, bool state)
        {
            
            UserName = userName;
            Phone = phone;
            Email = email;
            this.password = password;
            this.address = address;
            this.state = state;

            Admin a = new Admin(++counter, UserName, Phone, Email, this.password, this.address, this.state);
            list.Add(a);
            
        }

        static List<Admin> list = new List<Admin>();
        int counter = 0;
        public static List<Admin> returnlist_AccountUser()
        {
            List<Admin> li = list.ToList();
            return li;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text != ""&& txtemail.Text.Contains("@") && txtpass.Text !="" && txtphone.Text !=""&& txtemail.Text !=""&& txtaddress.Text !="")
            {
                if (radioButton1.Checked)
                    state = true;
                else
                    state = false;

                Admin a = new Admin(++counter, txtname.Text, txtphone.Text, txtemail.Text, txtpass.Text, txtaddress.Text,state);

                list.Add(a);
              
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns["Id_Admin"].Visible = false;
                clear();
            }
            else
            {
                MessageBox.Show("plz enter data ", "List Show", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void clear()
        {
            txtname.Text = txtemail.Text = txtpass.Text = txtphone.Text = txtaddress.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        int id = 0;
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

        private void button4_Click(object sender, EventArgs e)
        {
            var a = list.Where(x => x.Id_Admin == id).FirstOrDefault();
            list.Remove(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.ToList();
            dataGridView1.Columns["Id_Admin"].Visible = false;
            clear();
        }

        private void adduser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("must be input number not text");
            }
        }
    }
}
