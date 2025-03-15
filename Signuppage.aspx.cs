using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class Signuppage : System.Web.UI.Page
{ private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
      


        if (!Page.IsPostBack)
        {
            SignUp();
        }
    }


    protected void SignUp()
    {
        
        
        
        string Emailid  = Request.QueryString["Emailid"];
      
        SqlConnection.ClearAllPools();
        con.Open();
        // check_signumail();
        string em = Articles.Check_Signup_Id(Emailid);

        if (!string.IsNullOrEmpty(em))
        {
            labelMessage.Text = "You have already Sign up ";
            return;
        }
        else
        {
            string articleId = Articles.OiiO_User_Sign_UpInsert(Emailid);
            labelMessage.Text = "you have  Sign up successfully...";

            labelMessage.ForeColor = System.Drawing.Color.Green;
        }

        con.Close();

    }

}