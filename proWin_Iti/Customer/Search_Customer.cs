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
    public partial class Search_Customer : Form
    {
        public Search_Customer()
        {
            InitializeComponent();
            data();
        }
        private void data()
        {
            dataGridView1.DataSource = AddCustomer.returnlist_AccountUser();
            dataGridView1.Columns["ID_users"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "PDF (*.pdf)| *.pdf";
            //    save.FileName = "Result.pdf";

            //    bool ErrorMessage = false;

            //    if (save.ShowDialog() == DialogResult.OK)

            //    {

            //        if (File.Exists(save.FileName))

            //        {

            //            try

            //            {

            //                File.Delete(save.FileName);

            //            }

            //            catch (Exception ex)

            //            {

            //                ErrorMessage = true;

            //                MessageBox.Show("Unable to wride data in disk" + ex.Message);

            //            }

            //        }

            //        if (!ErrorMessage)

            //        {

            //            try

            //            {

            //                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

            //                pTable.DefaultCell.Padding = 2;

            //                pTable.WidthPercentage = 100;

            //                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

            //                foreach (DataGridViewColumn col in dataGridView1.Columns)

            //                {

            //                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

            //                    pTable.AddCell(pCell);

            //                }

            //                foreach (DataGridViewRow viewRow in dataGridView1.Rows)

            //                {

            //                    foreach (DataGridViewCell dcell in viewRow.Cells)

            //                    {

            //                        pTable.AddCell(dcell.Value.ToString());

            //                    }

            //                }

            //                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

            //                {

            //                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

            //                    PdfWriter.GetInstance(document, fileStream);

            //                    document.Open();

            //                    document.Add(pTable);

            //                    document.Close();

            //                    fileStream.Close();

            //                }

            //                MessageBox.Show("Data Export Successfully", "info");

            //            }

            //            catch (Exception ex)

            //            {

            //                MessageBox.Show("Error while exporting Data" + ex.Message);

            //            }

            //        }

            //    }

            //}

            //else

            //{

            //    MessageBox.Show("No Record Found", "Info");

            //}
        }
    }
}
