using iTextSharp.text;
using iTextSharp.text.pdf;
using proWin_Iti.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace proWin_Iti.Order
{
    public partial class BillSallfromResources : Form
    {
        List<Category> c = catigory.clist();
        List<Product> p = Form1.fillproduct();
        List<seller> s = sellers.clist();
        List<BiilBuyPro> bills = new List<BiilBuyPro>();
        public BillSallfromResources()
        {
            InitializeComponent();
        }
        private void BillSallfromResources_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bills;
            foreach (Category ci in c)
            {
                combCAtegory.Items.Add(ci.Name);
            }
            foreach(Product pi in p )
            {
                combProduct.Items.Add(pi.name);
            }
            foreach(seller si in s)
            {
                ComboSuppliers.Items.Add(si.Name);
            }
        }
        private void ComboSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void combProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string proname = combProduct.SelectedItem.ToString();
            foreach(Product pi in p)
            {
                if(pi.name==proname)
                {
                    txtPrice.Text = Convert.ToString(pi.price);
                    txtQountity.Text = Convert.ToString(pi.quantity);
                    combCAtegory.SelectedItem = pi.categoray;
                }
            }
        }
        int counter = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQountity.Text == " " || txtPrice.Text == " " || TxtSum.Text == " ")
                {
                    throw new Exception();
                }
                if (txtQountity.Text == Convert.ToString(0) || TxtSum.Text == Convert.ToString(0)) return;
                if (combCAtegory.SelectedIndex <= -1 || combProduct.SelectedIndex <= -1 || ComboSuppliers.SelectedIndex <= -1) return;

                BiilBuyPro bill = new BiilBuyPro(++counter, Convert.ToDouble(txtPrice.Text), Convert.ToInt32(txtQountity.Text), Convert.ToDouble(TxtSum.Text), combProduct.Text, ComboSuppliers.Text, combCAtegory.Text, dateTimePicker1.Value);
                bills.Add(bill);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bills;
            }
            catch(Exception ex)
            {
                MessageBox.Show("please enter valid data");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrice.Text = txtQountity.Text = TxtSum.Text = "";
            dataGridView1.Refresh();
        }
        private void txtQountity_KeyPress(object sender, KeyPressEventArgs e)
      {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 || e.KeyChar <=0)
            {
                e.Handled = true;
            }
        }
        private void txtQountity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtSum.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQountity.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("please enter valid data");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)| *.pdf";
                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var res = bills.Where(x => x.date_Bill.Day == dateTimePicker2.Value.Day).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = res;
        }
    }
}
