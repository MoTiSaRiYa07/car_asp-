using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using System.Web;


public partial class admin_add_company : System.Web.UI.Page
{
    company x = new company();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds;
    SqlCommand cmd = new SqlCommand();
    myconn x1 = new myconn();
    string qry;

    public object XMLWorkerHelper { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["aname"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                PopulateData();
            }
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string str;
        Boolean msg = false;


        str = Server.MapPath("company_logo/");
        if (fu1.HasFile)
        {
            str = str + fu1.FileName;
            fu1.SaveAs(str);
            msg = true;

        }


        qry = "insert into tbl_comp values('" + txtcname.Text + "','" + fu1.FileName + "'," + ddlstatus.SelectedValue + ")";
        x.compins(qry);
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

        qry = "select * from tbl_comp where compname like '" + txtcname.Text + "'";
        x.compsele(qry);

        GridView1.DataSource = x.ds;
        GridView1.DataBind();

    }



    public void DeleteRow(object sender, GridViewDeleteEventArgs e)
    {
        var compid = GridView1.DataKeys[e.RowIndex].Value;

        x1.cnopen();
        {
            qry = "Delete from tbl_comp" + " where compid = @compid";
            using (SqlCommand cmd = new SqlCommand(qry, x1.cn))
            {
                cmd.Parameters.AddWithValue("@compid", compid);
                cmd.ExecuteNonQuery();
                x1.cnclose();
            }
        }
        lblMessage.Text = "Record has been deleted successfully !";
        lblMessage.ForeColor = System.Drawing.Color.Red;
        this.PopulateData();

    }


    public void PopulateData()
    {
        DataTable table = new DataTable();
        x1.cnopen();
        {
            string sql = "Select * from tbl_comp";

            da = new SqlDataAdapter(sql, x1.cn);
            da.Fill(table);


        }
        GridView1.DataSource = table;
        GridView1.DataBind();
    }

    protected void EditRow(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        this.PopulateData();
    }


    protected void CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        this.PopulateData();
    }


    protected void ChangePage(object sender, GridViewPageEventArgs e)
    {

        GridView1.PageIndex = e.NewPageIndex;
        this.PopulateData();
    }




    protected void UpdateRow(object sendedr, GridViewUpdateEventArgs e)
    {
        var compid = GridView1.DataKeys[e.RowIndex].Value;
        GridViewRow row = GridView1.Rows[e.RowIndex] as GridViewRow;

        TextBox tcompname = row.FindControl("txtcompname") as TextBox;
        FileUpload fu1 = row.FindControl("fu1") as FileUpload;
        DropDownList ddlstatus = row.FindControl("ddlstatus") as DropDownList;
        string str;
        Boolean msg = false;


        str = Server.MapPath("company_logo/");
        if (fu1.HasFile)
        {
            str = str + fu1.FileName;
            fu1.SaveAs(str);
            msg = true;

        }

        x1.cnopen();

        string sql = "Update tbl_comp set compname = @compname,complogo=@complogo,status= @status   where compid = @compid";
        cmd = new SqlCommand(sql, x1.cn);
        cmd.Parameters.AddWithValue(
        "@compname", tcompname.Text.Trim());

        cmd.Parameters.AddWithValue(
        "@complogo", fu1.FileName.Trim());
        cmd.Parameters.AddWithValue(
        "@status", ddlstatus.SelectedValue.Trim());

        cmd.Parameters.AddWithValue(
        "@compid", compid);

        cmd.ExecuteNonQuery();
        x1.cnclose();
        lblMessage.Text = "Record updated successfully !";
        GridView1.EditIndex = -1;
        this.PopulateData();
    }




    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Clear();
        Response.Buffer = true;
        Response.ContentType = "application/ms-excel";
        Response.AddHeader("content-disposition", "attachment; filename=UserInfo.xls");
        Response.Charset = "";
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        GridView1.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.End();
      


    }


    public override void VerifyRenderingInServerForm(Control control)
    {
        // Verifies that the control is rendered
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   

   
   
}

    





