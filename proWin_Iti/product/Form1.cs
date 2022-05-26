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
    public partial class Form1 : Form

    {
        public static Form1 instance;
      
       static List<Product> products = new List<Product>();
        int counter = 0;
        public int Qountity { get; set; }
        public string namepro { get; set; }
        public Form1()
        {
            InitializeComponent();

            instance = this;
        }
        public Form1(int qountity, string namepro)
        {
            this.Qountity = qountity;
            this.namepro = namepro;
            calldata();
        }
        private void calldata()
        {
            var a = products.Where(x => x.name == this.namepro).FirstOrDefault();
            a.quantity = a.quantity - this.Qountity;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1 || comboBox2.SelectedIndex <= -1) return;
            if (textBox4.Text == Convert.ToString(0)) return;
            string catog = comboBox1.SelectedItem.ToString();
            string location = comboBox2.SelectedItem.ToString();
            try
            {
                
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || txtQountity.Text =="")
                {
                    throw new Exception();
                }

                Product product = new Product(++counter, textBox2.Text,int.Parse(txtQountity.Text), Convert.ToDouble(textBox4.Text), dateTimePicker1.Value, catog, location);
              
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value) == textBox2.Text && Convert.ToString(row.Cells[3].Value) == textBox4.Text && Convert.ToString(row.Cells[4].Value) == comboBox1.SelectedItem.ToString() && Convert.ToString(row.Cells[5].Value) == dateTimePicker1.Value.ToString() && Convert.ToString(row.Cells[6].Value) == comboBox2.SelectedItem.ToString())
                        {
                            return;
                        }
                    }
                 }
                products.Add(product);
                dataGridView1.Rows.Add(product.id, product.name, product.quantity, product.price, catog, product.ExpiredDate, product.store);
            

            }
            catch(Exception ex)
            {
                MessageBox.Show("You Must Fill the Text Boxes !");
            }
           

        }

        void CheckTextBox(TextBox tb, TextBox tb2, TextBox tb3,ComboBox c1,ComboBox c2)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int ID;
            if (comboBox1.SelectedIndex <= -1 || comboBox2.SelectedIndex <= -1) return;
            string catog = comboBox1.SelectedItem.ToString();
            string location = comboBox2.SelectedItem.ToString();
            try
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    throw new Exception();
                }
                if (dataGridView1.CurrentRow != null)
                {



                    dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
                  
                    dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = catog;
                    dataGridView1.CurrentRow.Cells[5].Value = dateTimePicker1.Value.ToShortDateString();
                    dataGridView1.CurrentRow.Cells[6].Value = location;

                }
                for (int index = 0; index < products.Count; index++)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        if (products[index].id == ID)
                        {

                            products[index].name = textBox2.Text;
                          
                            products[index].price = Convert.ToDouble(textBox4.Text);
                            products[index].categoray = catog;

                            products[index].ExpiredDate = dateTimePicker1.Value;
                            products[index].store = location;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("must be full");
            }
            }
            


       

       
        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            
            if (dataGridView1.CurrentRow != null)
            {
               
         
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
               
                for (int i = products.Count - 1; i >= 0; i--)
                {

                   
                    if (products[i].id == ID)
                    {
                        products.RemoveAt(i);

                    }
                   

                }
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string pName =textBox5.Text;
            pName.ToLower();
            for(int index=0;index<products.Count;index++)
            {
                if(products[index].name==pName)
                {
                    dataGridView1.Rows.Add(products[index].id, products[index].name, products[index].quantity, products[index].price,products[index].categoray, dateTimePicker1.Value.ToShortDateString(),products[index].store);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
           
            for (int index = 0; index < products.Count; index++)
            {
               
                
             dataGridView1.Rows.Add(products[index].id, products[index].name, products[index].quantity, products[index].price, products[index].categoray, dateTimePicker1.Value.ToShortDateString(), products[index].store);
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int idgrid;
            if (dataGridView1.CurrentRow != null)
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    if (dataGridView1.Rows[index].Cells[0].Selected || dataGridView1.Rows[index].Cells[1].Selected || dataGridView1.Rows[index].Cells[2].Selected || dataGridView1.Rows[index].Cells[3].Selected || dataGridView1.Rows[index].Cells[4].Selected || dataGridView1.Rows[index].Cells[5].Selected)
                    {
                        idgrid = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].id == idgrid)
                            {
                              
                                textBox2.Text = products[i].name;
                              
                                textBox4.Text = Convert.ToString(products[i].price);
                                comboBox1.SelectedItem = products[i].categoray;
                                dateTimePicker1.Value = Convert.ToDateTime(products[i].ExpiredDate);
                                comboBox2.SelectedItem = products[i].store;

                            }
                        }
                    }
                }
            }
        }
        public static List<Product> fillproduct()
        {
            return products;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           comboBox1.Items.Clear();
            textBox3.Text = Convert.ToString(0);
            textBox3.Hide();

            List<Category> l = catigory.clist();

            List<Store> l2 = Form4.fillstore();
            
            foreach (Category c in l)
            {
                comboBox1.Items.Add(c.Name);
            }

            foreach (Store sl in l2)
            {
                comboBox2.Items.Add(sl.Name);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
          
            frm3.Show();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar <=0)
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
      {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Order.BillSallfromResources b = new Order.BillSallfromResources();
            b.Show();
        }
    }
}
