using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

public partial class user_testdrive : System.Web.UI.Page
{
    myconn x = new myconn();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds;
    string str,qry;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            Response.Redirect("~/user/login/login_signup.aspx");
        }
        else
        {


        }
    }
    protected void btnbook_Click(object sender, EventArgs e)
    {
       
        x.cnopen();
        

        str = "insert into tbl_testdrive3 values('" + txtname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "','" + txtphoneno.Text + "'," + ddlcomp.SelectedValue + "," + ddlmodel.SelectedValue + ",'" + ddlcity.SelectedItem + "','" + txtdate.Text + "'," + Label1.Text + ")";
        cmd = new SqlCommand(str, x.cn);
        cmd.ExecuteNonQuery();

        //Response.Redirect("~/user/pyment/Pyment.aspx");
        //Response.Redirect(string.Format("~/user/pyment/che.aspx?Name={0}&Lname={1}&date={2}", txtname, txtlname.Text, txtdate.Text));




    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtdate.Text = Calendar1.SelectedDate.ToString("dd'-'MM'-'yy");
    }


    protected void ddlcity_SelectedIndexChanged(object sender, EventArgs e)
    {
        x.cnopen();
        qry = "SELECT distinct tbl_dealer.dealerid,tbl_dealer.dealername,tbl_dealer.email, tbl_dealer.phoeno, tbl_dealer.address, tbl_dealer_model.modelid,tbl_dealer_model.compid,tbl_dealer_model.modelid FROM tbl_dealer INNER JOIN  tbl_dealer_model ON tbl_dealer.dealerid = tbl_dealer_model.dealerid where tbl_dealer.address='" + ddlcity.SelectedItem + "' and tbl_dealer_model.compid=" + ddlcomp.SelectedItem.Value + " and tbl_dealer_model.modelid=" + ddlmodel.SelectedItem.Value + "";
        da = new SqlDataAdapter(qry, x.cn);
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
     

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        Label1.Text = GridView1.SelectedRow.Cells[1].Text;
        
        
    }

    protected void ddlcomp_SelectedIndexChanged(object sender, EventArgs e)
    {
        x.cnopen();
        str = "SELECT DISTINCT tbl_dealer.address, tbl_dealer_model.compid FROM tbl_dealer_model INNER JOIN tbl_dealer ON tbl_dealer_model.dealerid = tbl_dealer.dealerid WHERE tbl_dealer_model.compid = " + ddlcomp.SelectedValue;

        da = new SqlDataAdapter(str, x.cn);
        ds = new DataSet();
        da.Fill(ds);
        ddlcity.DataSource = ds.Tables[0];
        ddlcity.DataBind();
        ddlcity.DataValueField = "address";
        ddlcity.DataTextField = "address";

        ddlcity.DataBind();
        x.cnclose();


    }
}