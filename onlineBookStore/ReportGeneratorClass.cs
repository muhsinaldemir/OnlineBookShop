using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;

namespace OnlineBookStore
{
    class ReportGeneratorClass
    {
        public ReportGeneratorClass()
        {
        }

        public enum ReportType
        {
            BestSellerBooks,
            BestSellerMagazines,
            BestSellerMusicCDs,
            RichestCustomers,
        }

        public void generate(List<ItemToPurchaseClass> list,ReportType reportType)
        {
            string subTitle = null;
            switch (reportType)
            {
                case ReportType.BestSellerBooks:
                    {
                        subTitle = "Best Seller Books";
                        break;
                    }
                case ReportType.BestSellerMagazines:
                    {
                        subTitle = "Best Seller Magazines";
                        break;
                    }
                case ReportType.BestSellerMusicCDs:
                    {
                        subTitle = "Best Seller MusicCDs";
                        break;
                    }
                case ReportType.RichestCustomers:
                    {
                        subTitle = "Richest Customers";
                        break;
                    }
            }

            System.IO.FileStream fs = new FileStream(AppConstants.REPORTS_FILE_LOCATION+subTitle + "-Report.pdf", FileMode.Create);
            // Create an instance of the document class which represents the PDF document itself.  
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF   
            // Writer class using the document and the filestrem in the constructor.  

            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            // Add meta information to the document  
            /*
            document.AddAuthor("Micke Blomquist");
            document.AddCreator("Sample application using iTextSharp");
            document.AddKeywords("PDF tutorial education");
            document.AddSubject("Document subject - Describing the steps creating a PDF document");
            document.AddTitle("The document title - PDF creation using iTextSharp");
            */


            // Open the document to enable you to write to the document  
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner  
            //document.Add(new Paragraph("Kitap Kurdu - Reports!"));

            string title = @"Kitap Kurdu - Reports";
            Paragraph paragraphForTitle = new Paragraph();
            paragraphForTitle.SpacingBefore = 20;
            paragraphForTitle.SpacingAfter = 20;
            paragraphForTitle.Alignment = Element.ALIGN_CENTER;
            paragraphForTitle.Font = FontFactory.GetFont(FontFactory.HELVETICA, 20f, BaseColor.RED);
            paragraphForTitle.Add(title);
            document.Add(paragraphForTitle);



            Paragraph paragraphForSubtitle = new Paragraph();
            paragraphForSubtitle.SpacingBefore = 10;
            paragraphForSubtitle.SpacingAfter = 10;
            paragraphForSubtitle.Alignment = Element.ALIGN_CENTER;
            paragraphForSubtitle.Font = FontFactory.GetFont(FontFactory.HELVETICA, 18f, BaseColor.GREEN);
            paragraphForSubtitle.Add(subTitle);
            document.Add(paragraphForSubtitle);
            document.Add(createParagraphWithTab("Number","Item Id","Product Name","Sold Quantity","Unit Price"));


            int i = 1;
            foreach (var item in list)
            {                
                document.Add(createParagraphWithTab(i.ToString(), item.product.id,item.product.name, item.quantity.ToString(),item.product.price.ToString()+ " " + AppConstants.Currency_TRY));
                i++;
            }

            
            /*
            string text = @"you are successfully created PDF file.";
            Paragraph paragraph = new Paragraph();
            paragraph.SpacingBefore = 10;
            paragraph.SpacingAfter = 10;
            paragraph.Alignment = Element.ALIGN_LEFT;
            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.GREEN);
            paragraph.Add(text);
            document.Add(paragraph);
            */
            // Close the document  
            document.Close();
            // Close the writer instance  
            writer.Close();
            // Always close open filehandles explicity  
            fs.Close();
        }

        public Paragraph createParagraphWithTab(String key, String value1, String value2, String value3, String value4)
        {
            Paragraph p = new Paragraph();
            p.TabSettings = new TabSettings(100f);
            p.Add(key);
            p.Add(Chunk.TABBING);
            p.Add(value1);
            p.Add(Chunk.TABBING);
            p.Add(value2);
            p.Add(Chunk.TABBING);
            p.Add(value3);
            p.Add(Chunk.TABBING);
            p.Add(value4);
            return p;
        }
    }
}
