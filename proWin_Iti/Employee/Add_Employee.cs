using proWin_Iti.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proWin_Iti.Employee
{
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
            clear();
        }

        private void clear()
        {
            txtname.Text=txtphone.Text= txtemail.Text= txtpass.Text=txtaddress.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtaddress.Text !=""&& txtemail.Text.Contains("@") &&txtemail.Text !=""&& txtname.Text !=""&& txtpass.Text !=""&& txtphone.Text !="")
            {
                bool state = false;
                if (radioButton1.Checked)
                    state = true;
                else
                    state = false;
                Setting_employee a = new Setting_employee(txtname.Text, txtphone.Text, txtemail.Text, txtpass.Text, txtaddress.Text, state);
                clear();
                MessageBox.Show("Success insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("must be insert data", "list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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


        private void label1_Click(object sender, EventArgs e)
        {

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
