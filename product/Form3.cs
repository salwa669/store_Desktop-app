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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            List<Category> l2 = catigory.clist();
            List<Store> s2 = Form4.fillstore();
            foreach(Category c in l2)
            {
                comboBox1.Items.Add(c.Name);
            }
            foreach(Store s in s2)
            {
                comboBox2.Items.Add(s.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex <= -1 || comboBox2.SelectedIndex <= -1) return;
            List<Product> l3 = Form1.fillproduct();
            string catogary = comboBox1.SelectedItem.ToString();
            string location = comboBox2.SelectedItem.ToString();
            dataGridView1.Rows.Clear();
            for (int index=0;index<l3.Count;index++)
            {
               if(l3[index].categoray== catogary && l3[index].store==location)
                {
                    dataGridView1.Rows.Add(l3[index].id, l3[index].name, l3[index].quantity, l3[index].price, l3[index].categoray,l3[index].ExpiredDate,l3[index].store);
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
