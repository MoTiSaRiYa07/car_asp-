using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

public partial class user_login_signup : System.Web.UI.Page
{
    myconn x = new myconn();
    SqlCommand cmd = new SqlCommand();
    string str;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_signup_Click(object sender, EventArgs e)
    {

        if (Checkname()==true)
        {
            lblStatus.Text = "YOUR USER NAME ARE SAME";
            txtname.BackColor = System.Drawing.Color.Red;
        }

        else if (Checkemail()==true)
        {
            lblStatus.Text = "YOUR EMAIL ID ARE SAME";
            txtemail.BackColor = System.Drawing.Color.Red;

        }

        else
        {
            x.cnopen();
            str = "insert into tbl_user values('" + txtname.Text + "','" + txtlname.Text + "','" + txtpno.Text + "','" + txtciy.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "')";
            cmd = new SqlCommand(str, x.cn);
            cmd.ExecuteNonQuery();
            Session["email"] = txtemail.Text;
            Response.Redirect("~/user/home.aspx");

            clear();
            x.cnclose();


        }
    }

    private Boolean Checkname()
    {
        
        Boolean nameavailble = false;
         SqlConnection cn = new SqlConnection(@"Data Source=JAYRAMAPIR\SQLEXPRESS04;Initial Catalog=""E:\AUTO MOBILE\APP_DATA\DATABASE.MDF"";Integrated Security=True;Encrypt=False");
    string query = "select * from tbl_user where name ='" + txtname.Text + "'";
        SqlCommand cmd = new SqlCommand(query,cn);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet(); 
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            nameavailble = true;
        }
        cn.Close();
        return nameavailble;
 }

    private Boolean Checkemail()
    {

        Boolean nameavailble = false;
        SqlConnection cn = new SqlConnection(@"Data Source=JAYRAMAPIR\SQLEXPRESS04;Initial Catalog=""E:\AUTO MOBILE\APP_DATA\DATABASE.MDF"";Integrated Security=True;Encrypt=False");
        string query = "select * from tbl_user where email ='" + txtemail.Text + "'";
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            nameavailble = true;
        }
        cn.Close();
        return nameavailble;
    }




    protected void btnlogin_Click(object sender, EventArgs e)
    {
    //    x.cnopen();
    //    str = "select * from tbl_user where email='" + txt_email.Text + "' and password='" + txt_pass.Text + "'";
    //    cmd = new SqlCommand(str, x.cn);
    //    dr = cmd.ExecuteReader();
    //    if (dr.HasRows)
    //    {
    //        Session["email"] = txt_email.Text;
    //        Response.Redirect("~/user/home.aspx");

    //    }
    //    else
    //    {

    //    }
    //    x.cnclose();
    }

    public void clear()
    {
        txtname.Text = "";
        txtlname.Text = "";
        txtemail.Text = "";
        txtpassword.Text = "";
        txtre_pass.Text = "";

        txtpno.Text = "";
    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
       

    }

    protected void btn_login_Click1(object sender, EventArgs e)
    {
      

    }

    protected void Button1_Click(object sender, EventArgs e)
    {



    }
}