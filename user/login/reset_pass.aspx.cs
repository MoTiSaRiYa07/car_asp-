using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class user_login_reser_pass : System.Web.UI.Page
{
    myconn x = new myconn();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_reset_Click(object sender, EventArgs e)
    {
         lbl.Text=Request.QueryString["uid"].ToString();

        str = "SELECT tbl_code.userid, tbl_code.code FROM tbl_code INNER JOIN   tbl_user ON tbl_code.userid = tbl_user.userid WHERE (tbl_code.userid = " + lbl.Text + ")";
        da = new SqlDataAdapter(str, x.cn);
        ds = new DataSet();
        da.Fill(ds);
        x.cnopen();
        str = "update tbl_user set password= '" + txtpass.Text +"' where userid=" + lbl.Text +" ";
        cmd = new SqlCommand(str, x.cn);
        cmd.ExecuteNonQuery();
        Response.Redirect("login_signup.aspx");
        x.cnclose();
    }
}