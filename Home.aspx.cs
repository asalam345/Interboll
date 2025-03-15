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
using System.Collections;
using System.Text;

public partial class Home : System.Web.UI.Page
{
    DbContext dbContext = new DbContext();

    string firstname;
    string lastname;
    string email;
    string pasword;
    string phnnumber;
    string pass;
    Int32 gp;
    string user;
    Byte Date;
    Byte Month;
    Byte Year;

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
        if (!Page.IsPostBack)
        {
            load_Month();
            load_Date();
            load_Year();
            if (Request.Cookies["userid"] != null)
            {
                Session["userid"] = Request.Cookies["userid"].Value;
            }
            if (Session["userid"] != null)
            {
                GoToPage();
            }
        }
    }


    private void load_Month()
    {

        DataSet ds = ClPost.Load_Month();
        DdlMonth.DataSource = ds;
        DdlMonth.DataTextField = "A_Name";
        DdlMonth.DataValueField = "A_id";
        DdlMonth.SelectedIndex = Month - 1;
        DdlMonth.DataBind();

    }
    private void load_Date()
    {

        DataSet ds = ClPost.Load_Date();
        ddlDate.DataSource = ds;
        ddlDate.DataTextField = "A_Name";
        ddlDate.DataValueField = "A_id";
        ddlDate.SelectedIndex = Date - 1;
        ddlDate.DataBind();

    }
    private void load_Year()
    {

        DataSet ds = ClPost.Load_Year();
        ddlYear.DataSource = ds;
        ddlYear.DataTextField = "A_Name";
        ddlYear.DataValueField = "A_id";
        ddlYear.SelectedIndex = Year - 1;
        ddlYear.DataBind();

    }

    protected void ChatLogin()
    {
        try
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(new SqlParameter("@u_loginEmail", ProviderUserName));
            arrayList1.Add(new SqlParameter("@u_loginPassword", ProviderPassword));
            DataTable dt1 = dbContext.GetSelectedData_StoredProcedure("spUser_login", arrayList1);

            if (dt1.Rows.Count > 0)
            {

                Session["CurrentUserId"] = dt1.Rows[0]["IID"].ToString();
                Session["CurrentUserEmail"] = dt1.Rows[0]["LoginName"].ToString();
                Session["CurrentUserFirstName"] = dt1.Rows[0]["First_Name"].ToString();
                Session["CurrentUserLastName"] = dt1.Rows[0]["Last_Name"].ToString();
                Session["CurrentUserProfilePhoto"] = dt1.Rows[0]["Profile_Image"].ToString();

                ArrayList arrayList2 = new ArrayList();
                arrayList2.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
                arrayList2.Add(new SqlParameter("@isOnline", true));
                dbContext.UpdateData_StoredProcedure("spUser_update_online", arrayList2);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void AddCookie(string userid)
    {
       // HttpCookie cookie = new HttpCookie("userid", userid);
       // cookie.Expires = DateTime.UtcNow.AddDays(1);
       // cookie.Domain = ".interboll.com";
       //// UserCookie.Expires = DateTime.Now.AddYears(2);
       // Response.Cookies.Add(cookie);
        //HttpCookie UserCookie = new HttpCookie("userid");
        //UserCookie.Value = userid;
        //UserCookie.Secure = false;
        //UserCookie.Shareable = true;
        //UserCookie.HttpOnly = false;
        //UserCookie.Path = "/";
        //UserCookie.Domain = ".interboll.com";
        //UserCookie.Expires = DateTime.Now.AddYears(2);
        //Response.Cookies.Add(UserCookie);
        //Response.Cookies.Set(UserCookie);
        //FormsAuthentication.SetAuthCookie(userid, false);
        //Response.AppendCookie(UserCookie);
        //Response.SetCookie(UserCookie);
        //Request.Cookies.Set(UserCookie);
        //Response.Redirect("http://www.interboll.com/Home.aspx");
        HttpCookie hcookie = new HttpCookie("userid", userid);
        hcookie.Domain = ".interboll.com";
        hcookie.Path = "/";
        hcookie.Secure = false;
        hcookie.Shareable = true;
        hcookie.HttpOnly = false;
        hcookie.Expires = DateTime.Now.AddYears(10);
        Response.Cookies.Add(hcookie);
        Response.Cookies.Set(hcookie);
        Response.AppendCookie(hcookie);
        //string pageToGo = "http://www.interboll.com/Default.aspx";
        //if (Request.Cookies["pagename"] != null)
        //{
        //    userid = blog.Encrypt(userid);
        //    pageToGo = Request.Cookies["pagename"].Value + "?url=" + userid;
        //}
        //Response.Redirect(pageToGo, true);
    }

    public void GoToPage()
    {
        string pageToGo = "http://www.interboll.com/Default.aspx";
        if (!String.IsNullOrEmpty(Request.QueryString["url"]))
        {
            string userid = Session["userid"].ToString();
            userid = blog.Encrypt(userid);
            pageToGo = Request.QueryString["url"].ToString() + "?id=" + userid;
        }
        else if (!String.IsNullOrEmpty(Request.QueryString["shareurl"]))
        {
            string ru = "Default.aspx";
            if (!String.IsNullOrEmpty(Request.QueryString["ru"]))
            {
                ru = Request.QueryString["ru"].ToString();
            }
            pageToGo = "Share.aspx?ru=" + ru + "&t=" + Request.QueryString["t"].ToString() + "&d=" + Request.QueryString["d"].ToString() + "&l=" + Request.QueryString["l"].ToString() + "&p=" + Request.QueryString["p"].ToString();
        }
        else if (Session["pagename"] != null)
        {
            pageToGo = Session["pagename"].ToString();
        }

        Response.Redirect(pageToGo, true);
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Ali 1
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
                Session["First_Name"] = litFirstname.Text;
                Session["UserGroupID"] = litGroup.Text;
                ChatLogin();

                GoToPage();
               
                //AddCookie(userid);
                //string pageToGo = "Default.aspx";
                //if(Request.Cookies["pagename"] != null)
                //{
                //    pageToGo = Request.Cookies["pagename"].Value;
                //}

                ////string x = (Session["pagename"].ToString());
                //if (Session["pagename"] != null)
                //{
                //    ChatLogin();
                    
                //    //pageToGo = Response.Cookies["pagename"].Value.ToString();
                //    Response.Redirect(pageToGo, true);
                //    //Response.Redirect(pagename);

                //}
                //else
                //{
                    
                    // Session["User_Name"] = "0";

                    //Response.Redirect(pageToGo, true);//
                    //  return;
                //}



                //Ali For Chat System ---------------------------------------------------Start
              
                //Ali For Chat System ---------------------------------------------------End

             


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

    public void Getk_UserId()
    {
        DataSet ds = Articles.Check_User_data(ProviderUserName, ProviderPassword);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            Litgrp.Text = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);
            litFirstname.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            litGroup.Text = Convert.ToString(ds.Tables[0].Rows[0]["UserGroupID"]);
            Session["Picture"] = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
        }

        //if (txtPassword.Text.Length < 6 ||  (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
        //     {
        //         return;
        //     }
        // }


    }

    protected void btnLogin1_Click(object sender, EventArgs e)
    {
        savedate();

        //Ali 2

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            ClearField();
            Response.Redirect("~/Home.aspx");
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


        //      Session["Gender_Id"] = Convert.ToString(ddlgender.SelectedItem.Value);



        string gid = Convert.ToString(ddlgender.SelectedItem.Value);
        string dd = Convert.ToString(ddlDate.SelectedItem.Value);
        string mm = Convert.ToString(DdlMonth.SelectedItem.Value);
        string yyy = Convert.ToString(ddlYear.SelectedItem.Text);

        DateTime DOB1 = Convert.ToDateTime(yyy + '-' + mm + '-' + dd);


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
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

            }

            //if (txtPassword.Text.Length < 6 || (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
            //{
            //    return;
            //}

            txtConfirmPassword.Text = txtPassword.Text;

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                var encriptedPass = txtPassword.Text.Trim();
                encriptedPass = blog.Encrypt(encriptedPass);
                pass = encriptedPass;
                var salt = blog.Salt;

            }
            //Int32 UserGroupID, String First_Name, String Last_Name, String LoginName, String LoginPassword, String Salt, 
            //        Int32 AdGiverID, Boolean IsActiveUser, Int32 CreatedBy, DateTime CreatedDate, Int32 ModifiedBy,
            //        DateTime ModifiedDate, Boolean IsRemoved,Int32 LeavingCausesID,String Comments,Boolean IsEmail,Boolean IsSMS)

            //2345


            if (txtPassword.Text == string.Empty || txtPassword.Text == "")
            {
                labelMessage.Text = "Please enter your password";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
            //else if (txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
            //{
            //    labelMessage.Text = "Please comfirm your password";
            //}
            //else if (txtPassword.Text != txtConfirmPassword.Text)
            //{
            //    labelMessage.Text = "password doesn't match";
            //}
            else if (txtPassword.Text.Length < 6)
            {
                labelMessage.Text = "password too short, enter at least 6 character";

                return;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
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

                string articleId = Articles.OiiO_User_Insert(0, firstname, lastname, email, pass, "salt", 1, Post_Date, Post_Date, DOB1, 1, Convert.ToByte(gid));
                labelMessage.Text = "you have registered successfully...and your user ID is " + email;
                //   mail();
                labelMessage.ForeColor = System.Drawing.Color.Green;

                //Session["userid"] = userid;
                Session["User_Name"] = txtEmail.Text;
                Session["First_Name"] = txtFirstName.Text;
                Session["CurrentUserFirstName"] = txtFirstName.Text;
                Session["CurrentUserEmail"] = txtEmail.Text;
                Session["CurrentUserLastName"] = "";
                DataSet ds = ClPost.Get_User_Data_User_Name_Wise(txtEmail.Text);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    Session["userid"] = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);

                    Session["CurrentUserId"] = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);

                    Session["CurrentUserProfilePhoto"] = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);

                    //Ali For Chat System ---------------------------------------------------Start
                    ArrayList arrayList2 = new ArrayList();
                    arrayList2.Add(new SqlParameter("@u_id", ds.Tables[0].Rows[0]["IID"].ToString()));
                    arrayList2.Add(new SqlParameter("@isOnline", false));
                    arrayList2.Add(new SqlParameter("@isBusy", false));
                    arrayList2.Add(new SqlParameter("@isRemoved", false));
                    dbContext.SaveData_StoredProcedure("spUser_Online_Status_Insert", arrayList2);

                    ChatLogin();
                    //Response.Redirect("Default.aspx", true);

                    //Ali For Chat System ---------------------------------------------------End

                }

                //Session["pagename"] = pagename.ToString();
                string x = "";// (Session["pagename"].ToString());

                Response.Redirect("Default.aspx", true);

                ClearField();
            }
        }
    }

    public void ClearField()
    {
        txtFirstName.Text = string.Empty;

        txtEmail.Text = string.Empty;
        //  txtConEmailAdd.Text = string.Empty;
        txtConfirmPassword.Text = string.Empty;
        txtPassword.Text = string.Empty;
        // txtConfirmPassword.Text = string.Empty;


    }
    public void check_Data()
    {
        //  bool IsThisEmailAlreadyExist 
        string em = Articles.Check_Email_Id(txtEmail.Text);

        if (!string.IsNullOrEmpty(em))
        {
            return;

        }


        //if (txtPassword.Text.Length < 6 || (txtPassword.Text != txtConfirmPassword.Text) || txtPassword.Text == string.Empty || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == string.Empty)
        //{
        //    return;
        //}
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


    [System.Web.Services.WebMethod]
    public static void ClientInfo(string cname, string tZone, string ip)
    {
        HttpContext.Current.Session["CountryName"] = cname;
        HttpContext.Current.Session["TZone"] = tZone;
        HttpContext.Current.Session["IP"] = ip;
    }
}