using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Getk_UserId()
    {
        DataSet ds = Articles.Check_User_data(UserName.Text.Trim(), blog.Encrypt(Password.Text.Trim()));

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Session["User_Name"] = UserName.Text.Trim();
            Session["userid"] = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);
            Session["First_Name"] = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            Session["Picture"] = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
        }
    }
    
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Ali 1
        labelMessage.Text = "";
        FailureText.Text = "";
        if (IsValid)
        {
           string ProviderUserName = UserName.Text.Trim();
           string  ProviderPassword = blog.Encrypt(Password.Text.Trim());

            //var _userExists = true;//_userInformationRT.IsUserExists(ProviderUserName, ProviderPassword);
            //var _findUser = "";////_userInformationRT.FindUser(ProviderUserName, ProviderPassword);
            string em = Articles.Check_User(ProviderUserName, ProviderPassword);
            
            if (!string.IsNullOrEmpty(em))
            {
                //Session["userid"] = ProviderUserName;
                Session["User_Name"] = ProviderUserName;


                Getk_UserId();

                string fn = "";
                if (Session["First_Name"] != null)
                {
                    fn = Session["First_Name"].ToString();
                }
                string userid = "0";
                if (Session["userid"] != null)
                {
                    userid = Session["userid"].ToString();
                }
                string orgin = Request.QueryString["orgin"].ToString();
                string url = Request.QueryString["url"].ToString();
                string newUrl = "Agreement.aspx?orgin=" + orgin + "&url=" + url;
                string redirect = null;
                if (Request.QueryString["redirect"] != null)
                {
                    redirect = Request.QueryString["redirect"].ToString();
                    newUrl = "Agreement.aspx?orgin=" + orgin + "&url=" + url + "&redirect=" + redirect;
                }
                
                

                Response.Redirect(newUrl, true);
            }
            else
            {
                Session["LoginStatus"] = "Login";
                FailureText.Text = "Invalid username or password.";
                Password.Text = default(string);
                //ErrorMessage.Visible = true;
                //Response.Redirect("~/LoginPage.aspx");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
        }
        //}
        //catch (Exception ex)
        //{

        //}
    }
}