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
    public partial class Search_Employee : Form
    {
        public Search_Employee()
        {
            InitializeComponent();
            dataGridView1.DataSource = Setting_employee.returnlist_AccountUser();
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["Id_Admin"].Visible = false;
            dataGridView1.Columns["address"].Visible = false; 
            dataGridView1.Columns["state"].Visible = false; 

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
