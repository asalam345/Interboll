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

public partial class Loginuser : System.Web.UI.Page
{
    string firstname;
    string lastname;
    string email;
    string pasword;
    string phnnumber;
    string pass;
    Int32 gp;
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
        labelMessage.Text = "";
        FailureText.Text = "";
            if (IsValid)
            {
                ProviderUserName = UserName.Text.Trim();
                ProviderPassword = blog.Encrypt(Password.Text.Trim());

                //var _userExists = true;//_userInformationRT.IsUserExists(ProviderUserName, ProviderPassword);
                //var _findUser = "";////_userInformationRT.FindUser(ProviderUserName, ProviderPassword);
                string em = Articles.Check_User(ProviderUserName, ProviderPassword);
                Getk_UserId();
                if (!string.IsNullOrEmpty(em))
                {
                    string userid = Litgrp.Text.Trim();
                    Session["userid"] = userid;
                    Session["User_Name"] = ProviderUserName;
                    //Session["pagename"] = pagename.ToString();
                  string x=(Session["pagename"].ToString());
                  if ((x == null) || x == "")
                    {
                       // Session["User_Name"] = "0";
                        Response.Redirect("UserProfile.aspx",true);
                      //  return;

                    }
                    else

                    {
                        string pageToGo = Session["pagename"].ToString();
                        Response.Redirect(pageToGo);
                        //Response.Redirect(pagename);
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
        //}
        //catch (Exception ex)
        //{

        //}
    }

    public void Getk_UserId()
    {
        DataSet ds = Articles.Check_User_data(ProviderUserName, ProviderPassword);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            Litgrp.Text = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);

        }

        //if (txtPassword.Text.Length < 6 ||  (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
        //     {
        //         return;
        //     }
        // }


    }

    protected void btn_CreateAccount_Click(object sender, EventArgs e)
    {
        savedate();

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            ClearField();
            Response.Redirect("~/Default.aspx");
        }
        catch (Exception ex)
        {

        }
        // mail();

    }
    private void savedate()
    {
        labelMessage.Text = "";
        FailureText.Text = "";
        firstname = txtFirstName.Text;
        lastname = txtLastname.Text;
        email = txtEmail.Text;
        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());

        Boolean IsActiveUser;

        {



            // check_Data();

            string em = Articles.Check_Email_Id(txtEmail.Text);

            if (!string.IsNullOrEmpty(em))
            {
                labelMessage.Text = "You have already registered ";
                labelMessage.ForeColor = System.Drawing.Color.Green;
                return;

            }

            if (txtPassword.Text.Length < 6 || (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
            {
                return;
            }



            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                var encriptedPass = txtPassword.Text.Trim();
                encriptedPass = blog.Encrypt(encriptedPass);
                pass = encriptedPass;
                var salt = blog.Salt;

                //aUserInfo.Salt = salt;
                // aUserInfo.LoginPassword = encriptedPass;
            }
            //Int32 UserGroupID, String First_Name, String Last_Name, String LoginName, String LoginPassword, String Salt, 
            //        Int32 AdGiverID, Boolean IsActiveUser, Int32 CreatedBy, DateTime CreatedDate, Int32 ModifiedBy,
            //        DateTime ModifiedDate, Boolean IsRemoved,Int32 LeavingCausesID,String Comments,Boolean IsEmail,Boolean IsSMS)

            //2345


            if (txtPassword.Text == string.Empty || txtPassword.Text == "")
            {
                labelMessage.Text = "Please enter your password";
            }
            else if (txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
            {
                labelMessage.Text = "Please comfirm your password";
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                labelMessage.Text = "password doesn't match";
            }
            else if (txtPassword.Text.Length < 6)
            {
                labelMessage.Text = "password too short, enter at least 6 character";
                return;
            }
            //else
            //{
            //    labelMessage.Text = string.Format("The email address {0} already registered ",
            //        txtEmail.Text.Trim());
            //}
            //labelMessage.ForeColor = System.Drawing.Color.Red;
            ////ClearField();
            //return;
            else
            {

              //  string articleId = Articles.OiiO_User_Insert(0, firstname, lastname, email, pass, "salt", 1, true, 1, Post_Date, 1, Post_Date, false, 1, "comment", true, true, Post_Date, 1);
                labelMessage.Text = "you have registered successfully...and your user ID is " + email;
                //   mail();
                labelMessage.ForeColor = System.Drawing.Color.Green;
                ClearField();
            }
        }






    }
    public void ClearField()
    {
        txtFirstName.Text = string.Empty;
        txtLastname.Text = string.Empty;
        txtEmail.Text = string.Empty;
      //  txtConEmailAdd.Text = string.Empty;
        txtConfirmPassword.Text = string.Empty;
        txtPassword.Text = string.Empty;
        // txtConfirmPassword.Text = string.Empty;
        txtContactNo.Text = string.Empty;

    }
    public void check_Data()
    {
        //  bool IsThisEmailAlreadyExist 
        string em = Articles.Check_Email_Id(txtEmail.Text);

        if (!string.IsNullOrEmpty(em))
        {
            return;

        }

        if (txtPassword.Text.Length < 6 || (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
        {
            return;
        }
    }
    //public void mail()
    //{
    //    //string email = "abulink@yahoo.com";
    //    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
    //    // MailAddress mafrom = new MailAddress("mahfuz.latif@gmail.com");
    //    MailAddress mafrom = new MailAddress("customerservice@oiiotoys.com");
    //    MailAddress mato = new MailAddress(email);
    //    MailMessage mymsg = new MailMessage(mafrom, mato);
    //    mail.From = new MailAddress("customerservice@oiiotoys.com");
    //    mail.Subject = "Mail From Oiio";

    //    mymsg.Subject = "hi";
    //    mymsg.Body = "Thanks For ur Registraion. in oiiotoys .. ";

    //    SmtpClient smptc = new SmtpClient("smtpout.asia.secureserver.net", 25);
    //    // smptc.UseDefaultCredentials = false;
    //    smptc.EnableSsl = false;

    //    smptc.Credentials = new NetworkCredential("customerservice@oiiotoys.com", "oiio_toys2015");
    //    smptc.Send(mymsg);
    //}

}