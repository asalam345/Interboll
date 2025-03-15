using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Share : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            string ru = "Default.aspx";
            string t = "";
            string d = "";
            string l = "";
            string p = "";
            if (!String.IsNullOrEmpty(Request.QueryString["ru"])) { ru = Request.QueryString["ru"].ToString(); }
            if (!String.IsNullOrEmpty(Request.QueryString["t"])) { t = Request.QueryString["t"].ToString(); }
            if (!String.IsNullOrEmpty(Request.QueryString["d"])) { d = Request.QueryString["d"].ToString(); }
            if (!String.IsNullOrEmpty(Request.QueryString["l"])) { l = Request.QueryString["l"].ToString(); }
            if (!String.IsNullOrEmpty(Request.QueryString["p"])) { p = Request.QueryString["p"].ToString(); }
            Response.Redirect("Home.aspx?shareurl=http://www.interboll.com/Share.aspx&ru=" + ru + "&t=" + t + "&d=" + d + "&l=" + l + "&p=" + p, true);

        }

        string userid = Session["userid"].ToString();
        HtmlString h = null;//your html string
        //if ((Request.QueryString["l"] != null) && (Request.QueryString["l"] != ""))
        if (!String.IsNullOrEmpty(Request.QueryString["l"]))
        {
            h = new HtmlString("<a href='" + Request.QueryString["l"].ToString() + "' target='_blank'>");
        }
        //if ((Request.QueryString["p"] != null) || (Request.QueryString["p"] != ""))
        if (!String.IsNullOrEmpty(Request.QueryString["p"]))
        {
            h = new HtmlString(h + "<img src='" + Request.QueryString["p"].ToString() + "' style='width:350px; height:250px;'/>");
        }
        //if ((Request.QueryString["t"] != null) || (Request.QueryString["t"] != ""))
        if (!String.IsNullOrEmpty(Request.QueryString["t"]))
        {

            h = new HtmlString(h + "<h1>" + Request.QueryString["t"].ToString() + "</h1><p>" + Request.QueryString["d"].ToString() + "</p>");
        }
        //if ((Request.QueryString["l"] != null) || (Request.QueryString["l"] != ""))
        if (!String.IsNullOrEmpty(Request.QueryString["l"]))
        {
            h = new HtmlString(h + "</a>");
        }
        if(h != null)
        htmlpage.InnerHtml = h.ToString();
    }
    protected void btnShare_Click(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            string userid = Session["userid"].ToString();
            string articleId = ClPost.Insert_Add_tbl_Post("", htmlpage.InnerText, 1, 1, Convert.ToInt32(userid), 1, DateTime.Now.Date, "", 1, 1, "", "");

            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('close.html', '_self', null);", true);
            //string ru = "Default.aspx";
           
            //if (!String.IsNullOrEmpty(Request.QueryString["ru"])) { ru = Request.QueryString["ru"].ToString(); }
            //ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true); //Response.Redirect(ru, true);

            //DataSet ds = ClPost.Get_Max_P_Id_User_Wise(Convert.ToInt32(userid));

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    DataRow row = ds.Tables[0].Rows[0];
            //    ImagePostid = Convert.ToString(row["P_Id"]);


            //}

            //string fileName = System.DateTime.Now.ToString("_ddMMyyhhmmss") + Path.GetFileName(postedFile.FileName);
            //file_upload.SaveAs(Server.MapPath("~/images/Items/" + fileName));// + Path.GetFileName(file.FileName));
            //string articleId = ClPost.Insert_Post_Pic(Convert.ToInt32(ImagePostid), Convert.ToInt32(userid), fileName, fileName);
        }
        else
        {
            Response.Redirect("Home.aspx", true);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('close.html', '_self', null);", true);
        string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
        base.Response.Write(close);
    }
}