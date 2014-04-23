using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baker
{
    public class PdfProcessing
    {
        public void SendToPDF(string heading, string filename, DataGridView dataGridView, DataTable dataTable)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 30, 30, 20, 20);

                string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!Directory.Exists("Rapoarte"))
                    Directory.CreateDirectory("Rapoarte");

                PdfWriter.GetInstance(doc, new FileStream("Rapoarte\\" + filename + ".pdf", FileMode.Append, FileAccess.Write));

                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                iTextSharp.text.Font tableFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                iTextSharp.text.Font headerfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);            

                float[] widths = new float[dataGridView.Columns.Count];

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                    widths[i] = dataGridView.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);

                table.SetWidths(widths);
                table.HorizontalAlignment = 1;
                table.SpacingBefore = 2.0F;

                PdfPCell cell = null;

                doc.Open();
                Phrase p = new Phrase(new Chunk(heading, titleFont));
                doc.Add(p);

                foreach (DataGridViewColumn c in dataGridView.Columns)
                {
                    cell = new PdfPCell(new Phrase(new Chunk(c.HeaderText, headerfont)));
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);
                }

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            cell = new PdfPCell(new Phrase(dr[i].ToString(), tableFont));
                            cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                            if (dataTable.Rows.IndexOf(dr) % 2 != 0)
                                cell.BackgroundColor = new BaseColor(System.Drawing.Color.LightBlue);

                            table.AddCell(cell);
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteToLog("PdfProcessing", "SendToPDF", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }
    }
}
