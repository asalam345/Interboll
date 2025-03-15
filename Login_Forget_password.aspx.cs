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
using DAL;
using BLL;
using System.IO;
using System.Data.SqlClient;
using System.Net.Mail;

using System.Net;


public partial class Login_Forget_password : System.Web.UI.Page
{
      private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();

        // string Email = Txtemail.Text.ToString().Trim();
        Showpass();

        string em = lblpass.Text.Trim();
        //Response.Redirect("Manage_TB_User.aspx");
        if (string.IsNullOrEmpty(em))
        {
            labelMessage.Text = "wrong Email Id ";
            labelMessage.ForeColor = System.Drawing.Color.Green;
            return;

        }
        else
        {

            mail();

            labelMessage.Text = "Please  Check your Email..... ";
            labelMessage.ForeColor = System.Drawing.Color.Green;
            return;

        }
    }
    public void mail()
    {
        MailData();
        string email = Txtemail.Text.ToString().Trim();
        string pass = blog.Decrypt(lblpass.Text.Trim());
        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        // MailAddress mafrom = new MailAddress("mahfuz.latif@gmail.com");
       // MailAddress mafrom = new MailAddress("customerservice@oiiogifts.com");
        MailAddress mafrom = new MailAddress(lblfrom.Text);
        MailAddress mato = new MailAddress(email);
        MailMessage mymsg = new MailMessage(mafrom, mato);
        //mail.From = new MailAddress("customerservice@oiiogifts.com");
        mail.From = new MailAddress(lblfrom.Text); 
       
        mail.Subject = "Mail From Oiio";

        mymsg.Subject = "hi";
        string body = lbldes.Text + pass;
        mymsg.Body = body;

     //   message.From = new MailAddress(YourEmail.Text.ToString());  
 // message.To.Add(new MailAddress("me@domain.com"));  
 // message.CC.Add(new MailAddress("copy@domain.com"));  
  mymsg.Subject = "Message via My Site from " +lblfrom.Text.ToString();  
  mymsg.IsBodyHtml = true;  
  mymsg.Body = "<html><body>" + lbldes.Text.ToString()  + pass +"</body></html>";
 // mymsg.Attachments = (Server.MapPath("../images/Brand/");
  //SmtpClient client = new SmtpClient();  
  //client.Host = "127.0.0.1";  
  //client.Send(mymsg);    


       // SmtpClient smptc = new SmtpClient("smtpout.asia.secureserver.net", 25);
        SmtpClient smptc = new SmtpClient(lblsmptc.Text.Trim(), 25);
        // smptc.UseDefaultCredentials = false;
        smptc.EnableSsl = false;

        smptc.Credentials = new NetworkCredential(lblfrom.Text, lblfrompassword.Text);
        smptc.Send(mymsg);
    }
    //oiioangel.com/
    private void Showpass()
    {
        //Int32 id1 = Convert.ToInt32(Label1.Text);
        string Email = Txtemail.Text.ToString().Trim();
        SqlConnection.ClearAllPools();
        con.Open();

        DataSet ds = Articles.Check_User_Password(Email);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblpass.Text = Convert.ToString(ds.Tables[0].Rows[0]["LoginPassword"]);
       

            con.Close();
        }
    }


    private void MailData()
    {
        //Int32 id1 = Convert.ToInt32(Label1.Text);
        string Email = Txtemail.Text.ToString().Trim();
        SqlConnection.ClearAllPools();
        con.Open();

        DataSet ds = Articles.Get_Email_Id_wise("1");
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblfrompassword.Text = Convert.ToString(ds.Tables[0].Rows[0]["E_Password"]);
            lblfrom.Text = Convert.ToString(ds.Tables[0].Rows[0]["E_From"]);
            lblsmptc.Text = Convert.ToString(ds.Tables[0].Rows[0]["smptc"]);
            lbldes.Text = Convert.ToString(ds.Tables[0].Rows[0]["E_Description"]);


            con.Close();
        }
    }
}