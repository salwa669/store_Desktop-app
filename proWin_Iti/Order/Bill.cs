using proWin_Iti.admin;
using proWin_Iti.Model;
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

namespace proWin_Iti
{
    internal partial class Bill : Form
    {
        public int IDBill { get; set; }
        public bool state { get; set; }
        public Bill()
        {
            InitializeComponent();
            CreateDataTabile();
            list_intilization();
            Add_compBox();
        }
        List<Product> list_product = new List<Product>();
        List<Users> listUser = AddCustomer.returnlist_AccountUser();
        public Bill(int iDBill, bool state)
        {
            IDBill = iDBill;
            this.state = state;

            if (state == true)
                delete_item();
            else
                delteteAll();
        }

        private void delteteAll()
        {

            BillClassList.Clear();
        }
        private void delete_item()
        {
            var a = BillClassList.Where(x => x.ID_bill == IDBill).FirstOrDefault();
            BillClassList.Remove(a);
        }

        void list_intilization()
        {

            if (Form1.fillproduct() != null)
            {
            List<Product> l = Form1.fillproduct();
                list_product = l;
            }
        }
        void Add_compBox()
        {
            tx_name_salesman.Text = Program.salesMan;
            tx_number_bill.Text = (++counter).ToString();
            tx_pro.ValueMember = "ID";
            tx_pro.DisplayMember = "Name";
            tx_pro.DataSource = list_product.ToList();

            comboBoxClient.ValueMember = "ID_users";
            comboBoxClient.DisplayMember = "Name";
            comboBoxClient.DataSource = listUser.ToList();
        }
        private void clear()
        {
         textBox1.Text= tx_describtion.Text= TxtPrice.Text=TxtDescound.Text =TxtQountity.Text= TxtSum.Text= TxtDescound.Text= TxtTotal.Text=TxtAddress_users.Text=TxtPhone_Usrs.Text=Txt_email_users.Text="";
            dt.Clear();
            dataGridView1.Refresh();
        }

        DataTable dt = new DataTable();
        void CreateDataTabile()
        {

            dt.Columns.Add("Name Users");
            dt.Columns.Add("Phone Users");
            dt.Columns.Add("Number Bill");
            dt.Columns.Add("Name Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qountity");
            dt.Columns.Add("Sum");
            dt.Columns.Add("% Descound");
            dt.Columns.Add("Total Sum");

            dataGridView1.DataSource = dt;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void tx_number_bill_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
        private void txtDescound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = dt.NewRow();
                //try
                //{
                if (Txt_email_users.Text.Contains("@")&&TxtQountity.Text != "" && TxtSum.Text != "" && TxtDescound.Text != "" && TxtTotal.Text != "" && tx_number_bill.Text != "" && tx_name_salesman.Text != "" && tx_describtion.Text != "" && tx_describtion.Text != "" && comboBoxClient.Text != "" && Txt_email_users.Text != "" && TxtPhone_Usrs.Text != "" && TxtAddress_users.Text != "")
                {
                    //r[0] = a.ID_pro.ToString();
                    r[0] = comboBoxClient.Text;
                    r[1] = TxtPhone_Usrs.Text;
                    r[2] = tx_number_bill.Text;
                    r[3] = tx_pro.Text;
                    r[4] = TxtPrice.Text;
                    r[5] = TxtQountity.Text;
                    r[6] = TxtSum.Text;
                    r[7] = TxtDescound.Text;
                    r[8] = TxtTotal.Text;
              
                    dt.Rows.Add(r);
                    dataGridView1.DataSource = dt;
                    textBox1.Text = TxtTotal.Text;
                }
                else
                {
                    MessageBox.Show("must be insert vaild data");
                }
              //  }
            //catch (Exception)
            //{

            //    MessageBox.Show("invaild add bill try again plz", "list", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            //}
           //     clear();
            }
        }
        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }
        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                comboBoxClient.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtPhone_Usrs.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tx_pro.DisplayMember = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TxtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtQountity.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                TxtSum.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TxtDescound.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                TxtSum.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                TxtQountity.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("invaild Show data again plz", "List Show", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        
        static List<Users> list_user = new List<Users>();
        static List<BillClass> BillClassList = new List<BillClass>();
        private void new_buy_btn_Click(object sender, EventArgs e)
        {
            ++counter;
            tx_number_bill.Text = (counter).ToString();
            clear();


        }
        public static List<Users> returnlist_User()
        {
            List<Users> li = list_user.ToList();
            return li;
        }
        public static List<BillClass> returnlist_Bill()
        {
            List<BillClass> li = BillClassList.ToList();
            return li;
        }

        private void tx_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue_pro = Convert.ToInt32(tx_pro.SelectedValue);
            var a = list_product.Where(ww => ww.id == selectedValue_pro).First();
            TxtPrice.Text = a.price.ToString();
            TxtQountity.Focus();
        }
        private void TxtQountity_TextChanged(object sender, EventArgs e)
        {
            if (TxtQountity.Text != string.Empty && TxtQountity.Text != "")
            {
                TxtSum.Text = (Convert.ToDouble(TxtQountity.Text) * Convert.ToDouble(TxtPrice.Text)).ToString();
                //tx_descound.Focus();
            }
        }
        private void TxtQountity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtDescound.Focus();
            }
        }
        private void TxtQountity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("must be input number not text");
            }
        }
        private void TxtQountity_KeyUp(object sender, KeyEventArgs e)
        {
            var a = list_product.Where(ww => ww.name == tx_pro.Text).First();
            try
            {
                if (int.Parse(TxtQountity.Text) > a.quantity)
                {
                    MessageBox.Show("sorry Quantity is not enough = " + a.quantity, "list info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    calc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sorry. again plz");
            }
           

        }
        private void calc()
        {
            if (TxtQountity.Text != string.Empty && TxtDescound.Text != string.Empty && TxtSum.Text != string.Empty)
            {
                double discound = Convert.ToDouble(TxtDescound.Text);
                double summ = Convert.ToDouble(TxtSum.Text);
                double totalAmount = summ - (summ * (discound / 100));
                TxtTotal.Text = totalAmount.ToString();
              
            }
        }

        private void TxtDescound_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer();
          //  f.MdiParent = this;
            f.Show();
        }
        int counter = 0;
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >0)
            {
                    BillClassList.Add(new BillClass
                    {
               

                Name = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                Phone = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                ID_bill = int.Parse(tx_number_bill.Text),
                name_product= this.dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                price = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[4].Value),
                Qountity = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value),
                Descound = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[7].Value),
                Sum_Total = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[8].Value),
                Name_Caher = Program.salesMan,
                 date_Bill = DateTime.Now,
                    });
                Form1 f = new Form1(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value), this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                MessageBox.Show("Success insert data ", "List Show", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dt.Clear();
                dataGridView1.Refresh();
                clear();
            }
            else
            {
                MessageBox.Show("plz enter data ", "List Show", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPhone_Usrs_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("must be input number not text");
            }
        }

        private void TxtPhone_Usrs_KeyUp(object sender, KeyEventArgs e)
        {
          

        }
    }
}
