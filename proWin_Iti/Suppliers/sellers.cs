using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace proWin_Iti
{
    public partial class sellers : Form
    {
     public static List<seller> list = new List<seller>();
        public static sellers instance5;
        public sellers()
        {
            InitializeComponent();
            instance5 = this;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void sellers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list.ToList();
            List<Store> l = Form4.fillstore();
            foreach (Store s in l)
            {
                comboBox1.Items.Add(s.Name);
            }
        }
        string name_comp = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name_comp= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.SelectedItem= dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                    || textBox4.Text == ""   )
                {
                    throw new Exception();
                }
               if (textBox2.Text.Length != 11)
                {
                    throw new Exception();
                }
               if(Regex.IsMatch(textBox4.Text,pattern)==false)
                {
                    throw new Exception();
                }
                    seller s = new seller(textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, comboBox1.SelectedItem.ToString());
                    list.Add(s);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                    clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Must Fill the Text Boxes Correctly before adding  !");
            }

        }
        private void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        public  static List<seller> clist()
        {
            
            return list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = list.Find(x => x.Name == textBox1.Text);
            list.Remove(result);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                    || textBox4.Text == "")
                {
                    throw new Exception();
                }
                if (textBox2.Text.Length !=11)
                {
                    throw new Exception();
                }
                if (Regex.IsMatch(textBox4.Text, pattern) == false)
                {
                    throw new Exception();
                }
                var result = list.Find(x => x.Name == name_comp);
                    list.Remove(result);
                    seller s = new seller(textBox1.Text, textBox2.Text,
                        textBox3.Text, textBox4.Text, comboBox1.SelectedItem.ToString());
                    list.Add(s);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                    clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Must Fill the Text Boxes  !");
            }
           
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
               
                if (Char.IsDigit(e.KeyChar))
                {
                    if (textBox2.Text.Length > 10)
                    {
                        e.Handled = true;

                    }
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        private void textBox4_Leave(object sender, EventArgs e)
        {
          
            if(Regex.IsMatch(textBox4.Text,pattern))
                {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox4, "please enter a valid Email");
               
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}