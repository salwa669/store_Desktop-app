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

namespace proWin_Iti.Customer
{
    public partial class Add_customer : Form
    {
        public Add_customer()
        {
            InitializeComponent();
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtaddress.Text != "" && txtemail.Text.Contains("@") && txtemail.Text !="" && txtname.Text !=""&& txtphone.Text !="" )
            {
                AddCustomer c = new AddCustomer(txtname.Text,txtemail.Text,txtphone.Text,txtaddress.Text);
                MessageBox.Show("Success insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("must be insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clear()
        {
            txtaddress.Text = txtemail.Text = txtname.Text = txtphone.Text = "";
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtname_keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
