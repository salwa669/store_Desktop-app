
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
    public partial class catigory : Form
    {
        public static catigory instance2;
        static List<Category> list = new List<Category>();
        public catigory()
        {
            InitializeComponent();
            instance2 = this;
        }
        int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtNamePro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXderbation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNamePro.Text == "" && TXderbation.Text == "")
                {
                    throw new Exception();
                }
                if(TxtNamePro.Text == "")
                {

                    throw new Exception();
                }
                if (TXderbation.Text == "")
                {
                    throw new Exception();
                }
                Category c = new Category(++counter, TxtNamePro.Text, TXderbation.Text);
                list.Add(c);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;

                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("you must Fill the Text Boxes before adding!");
            }
        }
        public static List<Category> clist()
        {
            List<Category> list2 = list;
            return list2;
        }
        private void clear()
        {
            TXderbation.Text = TxtNamePro.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = list.Find(x => x.ID == id);
            list.Remove(result);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            clear();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNamePro.Text == "" && TXderbation.Text == "")
                {
                    throw new Exception();
                }
                if (TxtNamePro.Text == "")
                {

                    throw new Exception();
                }
                if (TXderbation.Text == "")
                {
                    throw new Exception();
                }
                var result = list.Find(x => x.ID == id);
                    list.Remove(result);
                    Category c = new Category(id, TxtNamePro.Text, TXderbation.Text);
                    list.Add(c);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                    clear();

               
            }
            catch(Exception ex)
            {
                MessageBox.Show("You Must Fill The Text Boxes before editting !");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void catigory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            sellers frm1 = new sellers();
            frm1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXderbation_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
    }
}
