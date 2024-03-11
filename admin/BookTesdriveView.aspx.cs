﻿using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default555 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        Button3.Visible = false;
        Button5.Visible = false;
        Button2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button3.Visible = true;
        Button5.Visible = true;
        Button2.Visible = true;

        String mycon = "Data Source=JAYRAMAPIR\\SQLEXPRESS04;Initial Catalog=E:\\AUTO MOBILE\\APP_DATA\\DATABASE.MDF;Integrated Security=True;Encrypt=False";

        string myquery = "Select * from tbl_testdrive where testdrive_id=" + TextBox1.Text;
        SqlConnection x = new SqlConnection(mycon);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = x;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Panel1.Visible = true;
            Labelid.Text = TextBox1.Text;
            Labelfn.Text = ds.Tables[0].Rows[0]["user_name"].ToString();
            Labelln.Text = ds.Tables[0].Rows[0]["last_name"].ToString();
            Labelcon.Text = ds.Tables[0].Rows[0]["phoneno"].ToString();
            Labelci.Text = ds.Tables[0].Rows[0]["compid"].ToString();
            Labelmi.Text = ds.Tables[0].Rows[0]["modelid"].ToString();
            Labelcity.Text = ds.Tables[0].Rows[0]["city"].ToString();
            Labeldate.Text = ds.Tables[0].Rows[0]["date"].ToString();
            Labeldid.Text = ds.Tables[0].Rows[0]["dealerid"].ToString();
        }
        else
        {
            Label22.Text = "SORRY TESTDRIVE ID NOT FOUND";
        }
        x.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        Response.Clear();
        Response.Buffer = true;
        Response.ContentType = "application/ms-excel";
        Response.AddHeader("content-disposition", "attachment; filename=UserInfo.xls");
        Response.Charset = "";
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        Panel1.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.End();
        Button3.Visible = false;


    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            // Create a Document
            using (Document document = new Document())
            {
                try
                {
                    PdfWriter.GetInstance(document, ms);

                    // Open the Document for writing
                    document.Open();

                    // Add text to the document
                    document.Add(new Paragraph("TEST DRIVE ID SHOW DATA"));
                    document.Add(new Paragraph("TEST DRIVE BOOK SUESFULL"));

                    document.Add(Chunk.NEWLINE); // Add new line

                    // Add panel data to the document
                    PdfPTable table = new PdfPTable(2); // 2 columns
                    table.WidthPercentage = 100;

                    // Add labels and their corresponding data from the panel
                    string[] labels = { "Your ENTER ID ", "Your FIRST NAME", "Your LAST NAME", "Your PHONE NUMBER", "Your COMPANY ID", "Your MODEL ID", "Your CITY", "Your BOOKING DATE", "Your DEALER ID" };
                    Label[] dataLabels = { Labelid, Labelfn, Labelln, Labelcon, Labelci, Labelmi, Labelcity, Labeldate, Labeldid,Label23 };

                    for (int i = 0; i < labels.Length; i++)
                    {
                        PdfPCell labelCell = new PdfPCell(new Phrase(labels[i]));
                        PdfPCell dataCell = new PdfPCell(new Phrase(dataLabels[i].Text));

                        // Add cells to the table
                        table.AddCell(labelCell);
                        table.AddCell(dataCell);
                    }

                    // Add the table to the document
                    document.Add(table);

                    // Add image to the document
                    
                    string imagePath = Server.MapPath("~/admin/company_logo/LOGO.jpg");
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
                    img.ScaleToFit(200f, 200f); // Adjust width and height here
                        document.Add(img);
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Response.Write(ex.Message);
                }
                finally
                {
                    // Close the Document
                    document.Close();
                }
            }

            // Send the PDF file to the client for download
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=DATASHOWTESTDRIVE.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.BinaryWrite(ms.ToArray());
            Response.End();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("~/admin/PAY/PYMENTSEND.aspx"); // Change the path to your desired file

    }
}
       