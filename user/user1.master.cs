using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_user1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            hllogin.Visible = true;
            hllogout.Visible = false;
        }
        else
        {
            hllogin.Visible = false;
            hllogout.Visible = true;
        }
    }
    protected void btnlogout_Click(object sender, EventArgs e)
    {
        if (Session["email"] != null)
        {
            Session.Remove("email");
            Response.Redirect("home.aspx");
        }

    }
}
