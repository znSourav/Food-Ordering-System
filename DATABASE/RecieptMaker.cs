using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ENTITY;
using System.IO;
using System.Drawing.Printing;
using RawPrint;

namespace DATABASE
{
    public class RecieptMaker
    {
        private string memID;

        public RecieptMaker(string memID)
        {
            this.memID = memID;
        }

        public void PrintReceipt()
        {
            try
            {
                //Footer Section
                PdfPTable pdfTableFooter = new PdfPTable(1);
                pdfTableFooter.DefaultCell.BorderWidth = 0;
                pdfTableFooter.WidthPercentage = 100;
                pdfTableFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPTable pdfTable1 = new PdfPTable(1);//Here 1 is Used For Count of Column
                pdfTable1.WidthPercentage = 80;
                pdfTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                pdfTable1.DefaultCell.BorderWidth = 0;

                PdfPTable pdfTable2 = new PdfPTable(1);
                pdfTable2.WidthPercentage = 80;
                pdfTable2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable2.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                pdfTable2.DefaultCell.BorderWidth = 0;

                Chunk c1 = new Chunk("\n\n\nMC DONALD'S RESTAURANT \n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 15));
                c1.Font.Color = new BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                Phrase p1 = new Phrase();
                p1.Add(c1);
                pdfTable1.AddCell(p1);

                Chunk c2 = new Chunk("28/3 Road No: 7, Banani, Dhaka", FontFactory.GetFont("Times New Roman"));
                c2.Font.Color = new BaseColor(0, 0, 0);
                c2.Font.SetStyle(0);//0 For Normal Font
                c2.Font.Size = 11;
                Phrase p2 = new Phrase();
                p2.Add(c2);
                pdfTable2.AddCell(p2);

                Chunk c3 = new Chunk("Customer Care : +88018987982 / +88018799899   Email: help@mcdonalds.com \n\n ", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 10;
                Phrase p3 = new Phrase();
                p3.Add(c3);
                pdfTable2.AddCell(p3);

                Chunk c4 = new Chunk("MEMO ID: " + memID + "\nDATE: " + DateTime.Now.ToString() + "\n\n\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10));
                c4.Font.Color = new BaseColor(0, 0, 0);
                c4.Font.SetStyle(0);
                Phrase p4 = new Phrase();
                p4.Add(c4);
                pdfTable2.AddCell(p4);

                // LIST
                PdfPTable list = new PdfPTable(3);
                list.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                // Table Header input begins here
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.CYAN;
                Paragraph p = new Paragraph("ITEM", FontFactory.GetFont(FontFactory.HELVETICA_BOLD));
                p.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(p);
                list.AddCell(cell);

                PdfPCell cell2 = new PdfPCell();
                cell2.BackgroundColor = BaseColor.CYAN;
                Paragraph px1 = new Paragraph("QTY", FontFactory.GetFont(FontFactory.HELVETICA_BOLD));
                px1.Alignment = Element.ALIGN_CENTER;
                cell2.AddElement(px1);
                list.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell();
                cell3.BackgroundColor = BaseColor.CYAN;
                Paragraph px2 = new Paragraph("PRICE", FontFactory.GetFont(FontFactory.HELVETICA_BOLD));
                px2.Alignment = Element.ALIGN_CENTER;
                cell3.AddElement(px2);
                list.AddCell(cell3);
                // Table header input ends here

                double totalCost = 0;
                List<SoldInfo> info = (new MemoCrud()).GetMemo(memID);
                for (int i = 0; i < info.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 0) list.AddCell(info[i].Name);
                        else if (j == 1) list.AddCell(info[i].Quantity.ToString());
                        else if (j == 2) list.AddCell("$" + info[i].Price.ToString());
                    }
                    totalCost += info[i].Price;
                }

                Chunk cnkFooter = new Chunk("\n\nTOTAL : $" + totalCost.ToString(), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                cnkFooter.Font.Size = 10;
                pdfTableFooter.AddCell(new Phrase(cnkFooter));

                // GENERATING PDF
                string folderPath = Environment.CurrentDirectory.ToString().Remove(Environment.CurrentDirectory.Length - 13) + @"DATABASE\memo\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                //File Name
                string strFileName = "MEMO " + memID + ".pdf";
                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(pdfTable1);
                    pdfDoc.Add(pdfTable2);
                    pdfDoc.Add(list);
                    pdfDoc.Add(pdfTableFooter);
                    pdfDoc.NewPage();

                    pdfDoc.Close();
                    stream.Close();
                }

                this.SendToPrinter();
                //DISPLAY PDF
                //System.Diagnostics.Process.Start(folderPath + "\\" + strFileName);
            }
            catch
            {
                throw;
            }
        }

        private void SendToPrinter()
        {
            string folderPath = Environment.CurrentDirectory.ToString().Remove(Environment.CurrentDirectory.Length - 13) + @"DATABASE\memo\";

            // Absolute path to your PDF to print (with filename)
            string Filepath = folderPath + "MEMO " + memID + ".pdf";
            // The name of the PDF that will be printed (just to be shown in the print queue)
            string Filename = "MEMO " + memID + ".pdf";
            // The name of the printer that you want to use
            // Note: Check step 1 from the B alternative to see how to list
            // the names of all the available printers with C#
            string PrinterName = "Microsoft Print to PDF";

            // Create an instance of the Printer
            IPrinter printer = new Printer();

            // Print the file
            printer.PrintRawFile(PrinterName, Filepath, Filename);
        }
    }
}
