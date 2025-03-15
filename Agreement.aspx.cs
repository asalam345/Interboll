using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agreement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblUrl.Text = Request.QueryString["orgin"].ToString();
        if (Session["userid"] == null)
        {
            Response.Redirect("Signin.aspx", true);
        }


    }

    public void AddCookie(string userid, string fn, string email, string picPath, string domain)
    {
        //HttpCookie hcookie = new HttpCookie("Accept", userid);
        //hcookie.Domain = ".interboll.com";
        //hcookie.Expires = DateTime.UtcNow.AddDays(2);
        //hcookie.Path = "/";
        //hcookie.Secure = false;
        //hcookie.Shareable = true;
        //hcookie.HttpOnly = false;
        //hcookie.Expires = DateTime.Now.AddDays(2);
        //Response.Cookies.Add(hcookie);
        //Response.Cookies.Set(hcookie);
        //Response.AppendCookie(hcookie);
       
        //Response.Redirect(pageToGo, true);
        //HttpCookie UserCookie = new HttpCookie("Accept");
        ////UserCookie.Values.Add("Id", userid);
        ////UserCookie.Values.Add("FN", fn);
        ////UserCookie.Values.Add("Email", email);
        //UserCookie.Value = email + "," + fn;
        //if (!String.IsNullOrEmpty(picPath))
        //{
        //    UserCookie.Value = email + "," + fn + "," + picPath;
        //}
       
        //UserCookie.Secure = false;
        //UserCookie.Shareable = true;
        //UserCookie.HttpOnly = false;
        //UserCookie.Domain = domain;
        //UserCookie.Expires = DateTime.Now.AddYears(2);
        //Response.Cookies.Add(UserCookie);
        ////FormsAuthentication.SetAuthCookie(email, false);
        ////FormsAuthentication.SetAuthCookie(email, false);
        //FormsAuthentication.SetAuthCookie(email, true);
        //Response.AppendCookie(UserCookie);
    }
    protected void btnAccept_Click(object sender, EventArgs e)
    {
         string url = Request.QueryString["url"].ToString();
            string newUrl = url;
        if (Session["userid"] != null && Session["First_Name"] != null && Session["User_Name"] != null && Session["Picture"] != null)
        {
            //AddCookie(Session["userid"].ToString(), Session["First_Name"].ToString(), Session["User_Name"].ToString(), Session["Picture"].ToString(), url);

           
            string redirect = null;
            if (Request.QueryString["redirect"] != null)
            {
                redirect = Request.QueryString["redirect"].ToString();
                newUrl = redirect;
            }



            Response.Redirect(newUrl + "?email=" + Session["User_Name"].ToString() + "&fn=" + Session["First_Name"].ToString() + "&image=" + Session["Picture"].ToString(), true);
        }
        else
        {
            Response.Redirect(url, true);
        }
    }

     protected void btnCancel_Click(object sender, EventArgs e)
    {
         string url = Request.QueryString["url"].ToString();

         Response.Redirect(url, true);
    }
}