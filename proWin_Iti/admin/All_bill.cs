using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace proWin_Iti.admin
{
    public partial class All_bill : Form
    {
        public All_bill()
        {
            InitializeComponent();
        }

        private void All_bill_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bill.returnlist_Bill();
            dataGridView1.Columns["ID_bill"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Phone"].Visible = false;
            dataGridView1.Columns["Details_Bill"].Visible = false;
        }

       
      

        int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Delete this item", "List Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Bill b = new Bill(id, true);
                dataGridView1.DataSource = Bill.returnlist_Bill();
                dataGridView1.Columns["ID_bill"].Visible = false;
                dataGridView1.Columns["Email"].Visible = false;
                dataGridView1.Columns["Phone"].Visible = false;
                dataGridView1.Columns["Details_Bill"].Visible = false;

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Delete All item", "List Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Bill b = new Bill(id, false);
                 dataGridView1.DataSource = Bill.returnlist_Bill();
            dataGridView1.Columns["ID_bill"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Phone"].Visible = false;
                dataGridView1.Columns["Details_Bill"].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var data = Bill.returnlist_Bill();
            var res = data.Where(x => x.date_Bill.Day == dateTimePicker1.Value.Day).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = res;
        }
    }
}
