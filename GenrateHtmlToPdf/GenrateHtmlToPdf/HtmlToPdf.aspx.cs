﻿
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace GenrateHtmlToPdf
{
    public partial class HtmlToPdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_PDF_Click(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("<header class='clearfix'>");
            //sb.Append("<h1>INVOICE</h1>");
            //sb.Append("<div id='company' class='clearfix'>");
            //sb.Append("<div>Company Name</div>");
            //sb.Append("<div>455 John Tower,<br /> AZ 85004, US</div>");
            //sb.Append("<div>(602) 519-0450</div>");
            //sb.Append("<div><a href='mailto:company@example.com'>company@example.com</a></div>");
            //sb.Append("</div>");
            //sb.Append("<div id='project'>");
            //sb.Append("<div><span>PROJECT</span> Website development</div>");
            //sb.Append("<div><span>CLIENT</span> John Doe</div>");
            //sb.Append("<div><span>ADDRESS</span> 796 Silver Harbour, TX 79273, US</div>");
            //sb.Append("<div><span>EMAIL</span> <a href='mailto:john@example.com'>john@example.com</a></div>");
            //sb.Append("<div><span>DATE</span> April 13, 2016</div>");
            //sb.Append("<div><span>DUE DATE</span> May 13, 2016</div>");
            //sb.Append("</div>");
            //sb.Append("</header>");
            //sb.Append("<main>");
            //sb.Append("<table style='border - style:solid ;'>");
            //sb.Append("<thead>");
            //sb.Append("<tr>");
            //sb.Append("<th class='service'>SERVICE</th>");
            //sb.Append("<th class='desc' style='color: red;'>DESCRIPTION</th>");
            //sb.Append("<th>PRICE</th>");
            //sb.Append("<th>QTY</th>");
            //sb.Append("<th>TOTAL</th>");
            //sb.Append("</tr>");
            //sb.Append("</thead>");
            //sb.Append("<tbody>");
            //sb.Append("<tr>");
            //sb.Append("<td class='service'>Design</td>");
            //sb.Append("<td class='desc'>Creating a recognizable design solution based on the company's existing visual identity</td>");
            //sb.Append("<td class='unit'>$400.00</td>");
            //sb.Append("<td class='qty'>2</td>");
            //sb.Append("<td class='total'>$800.00</td>");
            //sb.Append("</tr>");
            //sb.Append("<tr>");
            //sb.Append("<td colspan='4'>SUBTOTAL</td>");
            //sb.Append("<td class='total'>$800.00</td>");
            //sb.Append("</tr>");
            //sb.Append("<tr>");
            //sb.Append("<td colspan='4'>TAX 25%</td>");
            //sb.Append("<td class='total'>$200.00</td>");
            //sb.Append("</tr>");
            //sb.Append("<tr>");
            //sb.Append("<td colspan='4' class='grand total'>GRAND TOTAL</td>");
            //sb.Append("<td class='grand total'>$1,000.00</td>");
            //sb.Append("</tr>");
            //sb.Append("</tbody>");
            //sb.Append("</table>");
            //sb.Append("<div id='notices'>");
            //sb.Append("<div>NOTICE:</div>");
            //sb.Append("<div class='notice'>A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>");
            //sb.Append("</div>");
            //sb.Append("</main>");
            //sb.Append("<footer>");
            //sb.Append("Invoice was created on a computer and is valid without the signature and seal.");
            //sb.Append("</footer>");
            //htmlbind.InnerHtml = sb.ToString();
            StringBuilder sb = new StringBuilder();
            var strArr = System.IO.File.ReadAllLines(@"D:\SANOJ SAHANI\POC_Project\GenrateHtmlToPdf\GenrateHtmlToPdf\Screenshot.html");

            for (var c = 0; c < strArr.Length; c++)
            {
                sb.Append(strArr[c].ToString());
               
                
            }

            StringReader sr = new StringReader(sb.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                htmlparser.Parse(sr);
                pdfDoc.Close();

                byte[] bytes = memoryStream.ToArray();
                memoryStream.Close();
                Response.Clear();
                // Gets or sets the HTTP MIME type of the output stream.
                Response.ContentType = "application/pdf";
                // Adds an HTTP header to the output stream
                Response.AddHeader("Content-Disposition", "attachment; filename=Invoice.pdf");

                //Gets or sets a value indicating whether to buffer output and send it after
                // the complete response is finished processing.
                Response.Buffer = true;
                // Sets the Cache-Control header to one of the values of System.Web.HttpCacheability.
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                // Writes a string of binary characters to the HTTP output stream. it write the generated bytes .
                Response.BinaryWrite(bytes);

                // Sends all currently buffered output to the client, stops execution of the
                // page, and raises the System.Web.HttpApplication.EndRequest event.
                Response.End();
                // Closes the socket connection to a client. it is a necessary step as you must close the response after doing work.its best approach.
                Response.Close();
            }

        }
    }
}