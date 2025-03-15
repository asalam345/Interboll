using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack && Page.PreviousPage != null)
        {
            ViewState.Add("PreviousPageURL", Page.PreviousPage.Request.Url.AbsoluteUri);
            LoginAdmin.DestinationPageUrl = Page.PreviousPage.Request.Url.AbsoluteUri;
        }

    }




    protected void LoginAdmin_LoggedIn(object sender, EventArgs e)
    {
        Session["LOGIN"] = "ok";

        //if (ViewState["PreviousPageURL"] != null)
        //    Response.Redirect(ViewState["PreviousPageURL"].ToString());

        //Response.Redirect("Default.aspx");
    }
}
