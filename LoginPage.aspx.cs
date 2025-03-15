using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DAL;
using BLL;
using System.IO;
using System.Data.SqlClient;
public partial class LoginPage : System.Web.UI.Page
{    Int32 gp;
string user;
    protected string ProviderUserName
        {
            get { return (string)ViewState["ProviderUserName"] ?? String.Empty; }
            private set { ViewState["ProviderUserName"] = value; }
        }

        protected string ProviderPassword
        {
            get { return (string)ViewState["ProviderPassword"] ?? String.Empty; }
            private set { ViewState["ProviderPassword"] = value; }
        }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LogIn(object sender, EventArgs e)
    {
        try
        {
            if (IsValid)
            {
                ProviderUserName = UserName.Text.Trim();
                ProviderPassword = blog.Encrypt(Password.Text.Trim());

                //var _userExists = true;//_userInformationRT.IsUserExists(ProviderUserName, ProviderPassword);
                //var _findUser = "";////_userInformationRT.FindUser(ProviderUserName, ProviderPassword);
                string em = Articles.Check_User(ProviderUserName, ProviderPassword);

                if (!string.IsNullOrEmpty(em))
                
                {
                    String  objUserGroup = "";// _userInformationRT.FindUserGroup(_findUser != null ? _findUser.UserGroupID : default(Int64));
                    check_UserGroup();
                    FormsAuthentication.SetAuthCookie(ProviderUserName, true);
                    Session["LoginStatus"] = "Log out";
                    Session["UserName"] = ProviderUserName;

                    objUserGroup = Litgrp.Text;

                    int objgrp = Convert.ToInt32(objUserGroup);

                    if (objUserGroup != null)
                    {
                        // if (Convert.ToInt32(objUserGroup.TypeID) == Convert.ToInt32(OH.Utilities.EnumCollection.UserGrpType.Management) || Convert.ToInt32(objUserGroup.TypeID) == Convert.ToInt32(OH.Utilities.EnumCollection.UserGrpType.Control_User))
                        if (objgrp == 1)
                        {
                            adminpanel();// Response.Redirect("~/Admin/adminpanel.aspx.aspx");
                        }
                        else if (objgrp == 2)
                        {
                            varifYblog_User();  // Response.Redirect("~/MaterialWF.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/Default.aspx");
                        }
                    }
                }
                else
                {
                    Session["LoginStatus"] = "Login";
                    FailureText.Text = "Invalid username or password.";
                    Password.Text = default(string);
                    //ErrorMessage.Visible = true;
                    //Response.Redirect("~/LoginPage.aspx");
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    public void adminpanel()

    { 
    
       //bool ok = FormsAuthentication.m(username.Text, password.Text);
        bool ok = Membership.ValidateUser( UserName.Text.Trim(), Password.Text);

        if (ok)
        {
            FormsAuthentication.SetAuthCookie(UserName.Text, true);

            //   username.Text = "Admin";
            

            if (UserName.Text == "Admin")
            {
                // FormsAuthentication.SetAuthCookie(username.Text) = "Admin";
                //WebsiteConfig.RedirectToMemberPage();

                //if (!string.IsNullOrEmpty(Request.QueryString["returnUrl"]))
                //    Response.Redirect(Request.QueryString["returnUrl"]);
                //else
                //Response.Redirect("~/");
                Response.Redirect("Admin/adminpanel.aspx");
            }
            else
            {

                Response.Redirect("Admin/Admin_Panel1.aspx");
            }
        }
        else
        {
            FailureText.Text = "Invalid username or password.";
        }

    }

    private void varifYblog_User()
    {

        string User = UserName.Text.Trim();
        //lblStatus.Text = "";
        //user = txtUserID.Text.Trim();
         
    Int32 Userid;
    string Pass;
    Int32 UserType;

        Blog_Info obCar = new Blog_Info();
        DataTable dt = obCar.Get_user_name(User);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (dt.Rows.Count > 0)
            {
                Userid = Convert.ToByte(dt.Rows[i][0]);
                //Road_ID = Convert.ToByte(dt.Rows[i][0]);
                Pass = Convert.ToString(dt.Rows[i][7]);
                UserType = Convert.ToByte(dt.Rows[i][5]);
                Session["UserID"] = user;
                Session["UserIDINDB"] = Convert.ToInt32(dt.Rows[i]["U_ID"].ToString());


            }
            else
            {
               // Response.Redirect("User_Reg.aspx");
                return;


            }


            if (UserType == 4)
            {
                Response.Redirect("AdminHome.aspx");
            }


            else if (UserType == 2)
            {
                //  Response.Redirect("IUserHome.aspx");
                Response.Redirect("Blog/Blog_Page.aspx?UserID" + Userid + "&Name=" + User + "&User=" + Userid);
               // return;
            }


            else
            {
                //Response.Redirect("User_Reg.aspx");
                return;



            }

        }



        Response.Redirect("User_Reg.aspx");

    }
    

    public void check_UserGroup()
    {
        DataSet ds = Articles.Check_User_data(ProviderUserName, ProviderPassword);

         if (ds.Tables[0].Rows.Count > 0)
         {
             DataRow row = ds.Tables[0].Rows[0];

             Litgrp.Text = Convert.ToString(ds.Tables[0].Rows[0]["UserGroupID"]);
             
         }

       //if (txtPassword.Text.Length < 6 ||  (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
       //     {
       //         return;
       //     }
       // }
              
   
}
}