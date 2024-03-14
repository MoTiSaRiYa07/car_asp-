using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

public partial class dealer_confirm1 : System.Web.UI.Page
{
    myconn x = new myconn();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds;
    string str, pno,email;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.QueryString.Get("uname");
        str = "select * from tbl_testdrive3 where user_name='" + Label1.Text + "'";
        da = new SqlDataAdapter(str, x.cn);
        ds = new DataSet();
        da.Fill(ds);

        //email = ds.Tables[0].Rows[0]["email"].ToString();
        email = Request.QueryString.Get("email");
        MailMessage mail = new MailMessage();
        string mailid = email;
        mail.To.Add(mailid);
        mail.From = new MailAddress("kingofembroidery@gmail.com");
        mail.Subject = "Registration";
        string Body = "TEST DRIVE SUESSFULL BOOK";
        mail.Body = Body;
        mail.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new System.Net.NetworkCredential("kingofembroidery@gmail.com", "nhucdvtnfsemscnv");
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.Send(mail);
        Response.Redirect("dealer_home.aspx");

    }
}