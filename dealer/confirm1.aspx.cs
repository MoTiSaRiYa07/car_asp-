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
public partial class dealer_confirm1 : System.Web.UI.Page
{
    myconn x = new myconn();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds;
    string str, pno;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.QueryString.Get("uname");
        str = "select * from tbl_testdrive where user_name='" + Label1.Text + "'";
        da = new SqlDataAdapter(str, x.cn);
        ds = new DataSet();
        da.Fill(ds);
        pno = ds.Tables[0].Rows[0]["phoneno"].ToString();

        string Password = "krishna2220";
        string Msg = "Your Test drive booking is confirmed.";
        string OPTINS = "DHCODE";
        string MobileNumber = pno;
        //string type = "3";
        string strUrl = "https://www.bulksmsgateway.in/sendmessage.php?user=krishna2010&password=" + Password + "&message=" + Msg + "&sender=" + OPTINS + "&mobile=" + MobileNumber + "&type=" + 3;
        System.Net.WebRequest request = System.Net.WebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        Response.Write("Sent");
        Response.Redirect("testdrive_bookings.aspx");
    }
}