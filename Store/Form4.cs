using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proWin_Iti
{
    internal partial class Form4 : Form
    {
        public static Form4 instance4;
       static List<Store> stores = new List<Store>();
        public Form4()
        {
            InitializeComponent();
            instance4 = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
                {
                    throw new Exception();
                }
                if (textBox3.Text.Length != 11)
                {
                    throw new Exception();
                }

                string mangername = comboBox1.SelectedItem.ToString();
                Store store = new Store(textBox1.Text, textBox2.Text, textBox3.Text, mangername);
                stores.Add(store);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = stores;

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Must Fill the Text Boxes  !");
            }
        }
        private void clear()
        {
            textBox1.Text=textBox2.Text=textBox3.Text = "";
        }
        public static List<Store> fillstore()
        {
            List<Store> s = stores.ToList();
            return s;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""  )
                {
                    throw new Exception();
                }
                if (textBox3.Text.Length != 11)
                {
                    throw new Exception();
                }

                var result = stores.Find(x => x.Name == name_temp);
                stores.Remove(result);
                Store s = new Store(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString());
                stores.Add(s);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = stores;
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("You Must Fill the Text Boxes Correctly before adding!");
            }
           
        }
        string name_temp = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name_temp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = stores.Find(x => x.Name == name_temp);
            stores.Remove(result);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stores;
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            catigory catog = new catigory();
            catog.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_keypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {

                if (Char.IsDigit(e.KeyChar))
                {
                    if (textBox3.Text.Length > 10)
                    {
                        e.Handled = true;

                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
