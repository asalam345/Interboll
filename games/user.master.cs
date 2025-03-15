using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class games_user : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserGroupID"].ToString() != "90" && Session["userid"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        Label1.Text = Session["User_Name"].ToString();
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/signout.aspx", true);
    }
}
