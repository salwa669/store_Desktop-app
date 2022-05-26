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

namespace proWin_Iti.Order
{
    internal partial class AddCustomer : Form
    {
        public string Name2 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer( string name, string email, string phone,string address)
        {
            Name2 = name;
            Email = email;
            Phone = phone;
            this.address = address;
            Users u = new Users(++counter, Name2, Email, Phone);
            list_user.Add(u);

        }
        static List<Users> list_user = new List<Users>();
        public static List<Users> returnlist_AccountUser()
        {
            List<Users> li = list_user.ToList();
            return li;
        }
        int counter = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtemail.Text.Contains("@") && txtemail.Text != "" && txtname.Text != "" && txtphone.Text != "")
            {
                Users u = new Users(++counter, txtname.Text, txtemail.Text, txtphone.Text);
                list_user.Add(u);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list_user.ToList();
                dataGridView1.Columns["ID_users"].Visible = false;
                clear();
            }
           
                 else
                {
                    MessageBox.Show("data must be inserted !", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtemail.Text != "" && txtphone.Text != "")
            {

                var a = list_user.Where(x => x.ID_users == id).FirstOrDefault();
                a.Email = txtemail.Text;
                a.Name = txtname.Text;
                a.Phone = txtphone.Text;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list_user.ToList();
                dataGridView1.Columns["ID_users"].Visible = false;
                clear();
                MessageBox.Show("Success insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("must be insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var a = list_user.Where(x => x.ID_users == id).FirstOrDefault();
            txtname.Text = a.Name;
            txtemail.Text = a.Email;
            txtphone.Text = a.Phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                var a = list_user.Where(x => x.Name.Contains(txtsearch.Text) || x.Email.Contains(txtsearch.Text) || x.Phone.Contains(txtsearch.Text)).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = a.ToList();
                clear();
                Bill b = new Bill();
                b.Show();
            }
            else
            {
                MessageBox.Show("must be insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clear()
        {
            txtname.Text = txtemail.Text = txtphone.Text =  "";
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = list_user.Where(x => x.ID_users == id).FirstOrDefault();
            list_user.Remove(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list_user.ToList();
            dataGridView1.Columns["ID_users"].Visible = false;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtphone_keypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {

                if (Char.IsDigit(e.KeyChar))
                {
                    if (txtphone.Text.Length > 10)
                    {
                        e.Handled = true;

                    }
                }
            }
        }
    }
}
