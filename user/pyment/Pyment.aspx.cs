using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_pyment_Pyment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect(string.Format("che.aspx?Name={0}&Email={1}&Amount={2}", txtName.Text, txtEmail.Text, txtAmount.Text));
    }
}