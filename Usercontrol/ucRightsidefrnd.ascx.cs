using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Mars.Utility;
using System.Text;


using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Usercontrol_ucRightsidefrnd : System.Web.UI.UserControl
{
    DateTime hitsDate;
    string catid;
    string query;
    string pagename;
    Int32 catid1;
    Byte curencyid;
    int total1 = 0;
    int total2 = 0;
    decimal itemprice;
    decimal discount;
    decimal subtola;


    Byte Gender;
    Byte MStatus = 1;
    String User_Dob;
    String P_Image;
    String C_Image;
    String UserProfileName;

    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
    Int32 CountryId = 1;
    Byte occupationId = 1;
    Byte ReligionId = 1;

    String U_University;
    String U_College;
    String U_School;
    String U_Contact;
    String U_Website;



    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        // Label1.Text = Application["Date"].ToString();
        //    getHits();
        if (!Page.IsPostBack)
        {




            loginname();
            ShowAdata();
            ShowADetail_Datadata();
            loadPost_Image();
            //load_Frnd_Search();     //Friends Search
            // load_Frnd_Search_Request(); //Friends Request Send
            //  load_Frnd_Search_Following(); //Friends Request Follow me
            load_Frnd_Followers();//Frnd list
            //   Get_user_Id_Wise_Post();

            string path = Path.GetFileName(Request.Url.AbsolutePath);
            


        }

    }

    private void loginname()
    {


        if (Session["User_Name"] == null)
        {


            //Response.Redirect("Home.aspx", true);
            Response.Redirect("Home.aspx");
        }


        else
        {


            lblFirstname.Text = Session["First_Name"].ToString();

            //  Response.Redirect("Default.aspx"); 

        }
    }


    private void ShowADetail_Datadata()
    {


        string userid = Session["FrnId"].ToString();// Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Detail_Id_Wise_Home_Page(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);

            MStatus = Convert.ToByte(ds.Tables[0].Rows[0]["Meritial_Status"]);
            lblMyself.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Intro"]);

            lblFamily.Text = Convert.ToString(ds.Tables[0].Rows[0]["No_Of_Children"]);

            CountryId = Convert.ToInt32(ds.Tables[0].Rows[0]["Country_Id"]);
            lblCountry.Text = Convert.ToString(ds.Tables[0].Rows[0]["Country_Name"]);
            lblRelesonship.Text = Convert.ToString(ds.Tables[0].Rows[0]["Maritial_Status_Name"]);
            lblRelation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Maritial_Status_Name"]);
            occupationId = Convert.ToByte(ds.Tables[0].Rows[0]["Occupation"]);
            lblOcupation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Occupation_Name"]);
            lblPresentWorkstatus.Text = Convert.ToString(ds.Tables[0].Rows[0]["Present_Working_Status"]);
            lblPastExperiance.Text = Convert.ToString(ds.Tables[0].Rows[0]["Past_Experiance"]);

            lblpresentAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["Present_Address"]);


            ReligionId = Convert.ToByte(ds.Tables[0].Rows[0]["Religious"]);


            lblContactNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_Contact"]);
            lblWebsite.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_Website"]);

            lblCollege.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_College"]);
            lblSchool.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_School"]);



            lblAdprofile.Text = "Edit Profile";



        }

        else
        {

            lblAdprofile.Text = "Add Profile";


        }

    }

    private void ShowAdata()
    {



        string userid = Session["FrnId"].ToString();// Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Id_Wise(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            lblName.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            lblProfileName1.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            lok2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            lok1.Text = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);



            //String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();

            UserProfileName = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);

            Gender = Convert.ToByte(ds.Tables[0].Rows[0]["U_Gender"]);
            if (Convert.ToByte(Gender) == 1)
            {

                lblGender.Text = "Male";

            }
            else
            {
                lblGender.Text = "FeMale";

            }



            string pImage = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            string Cimage = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);



            User_Dob = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); // DateTime.Now.ToString();
            // lblDob.Text = User_Dob;

            DateTime dt1 = Convert.ToDateTime(ds.Tables[0].Rows[0]["dob"]);
            lblDob.Text = dt1.ToString("MMMM dd, yyyy");

            String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();

        }
    }



    private void loadPost_Image()
    {

        SqlConnection.ClearAllPools();
        con.Open();
        string userid = Session["FrnId"].ToString();
        // string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Pic(userid);

        dlPostImage.DataSource = ds;
        dlPostImage.DataBind();


        dlPostimage1.DataSource = ds;
        dlPostimage1.DataBind();
        con.Close();

    }



    private void load_Frnd_Search()
    {

        SqlConnection.ClearAllPools();
        con.Open();
        string userid = Session["FrnId"].ToString();
        //string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_frend_Search(Convert.ToInt32(userid));

        rptSearchFrnd.DataSource = ds;
        rptSearchFrnd.DataBind();
        con.Close();

    }

    protected void btnReplyClicked(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int frindId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DateTime Postdate = DateTime.Now;

        DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 0);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        else
        {

            string articleId1 = ClPost.Insert_p_tbl_tbUser_Friends(Convert.ToInt32(userid), frindId, 0, false, Postdate, Postdate);
            load_Frnd_Search_Request();

        }




    }

    private void load_Frnd_Search_Request()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_frend_Search_Send_Request(Convert.ToInt32(userid));

        rptRequest.DataSource = ds;
        rptRequest.DataBind();
        con.Close();

    }

    private void load_Frnd_Search_Following()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_frend_Search_Following(Convert.ToInt32(userid));

        rptFollowing.DataSource = ds;
        rptFollowing.DataBind();
        con.Close();

    }


    protected void btnReplyClicked1(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int frindId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DateTime Postdate = DateTime.Now;

        DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 1);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        else
        {

            string articleId1 = ClPost.Insert_p_tbl_tbUser_Friends(Convert.ToInt32(userid), frindId, 1, false, Postdate, Postdate);

            ClPost.Update_Frnd_Status(frindId, Convert.ToInt32(userid), 1);
            load_Frnd_Search_Following();

        }




    }

    private void load_Frnd_Followers()
    {

        SqlConnection.ClearAllPools();
        con.Open();
        string userid = Session["FrnId"].ToString();
        //   string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Frends_Followers(Convert.ToInt32(userid));

        rptFollowers.DataSource = ds;
        rptFollowers.DataBind();

        rptFriends.DataSource = ds;
        rptFriends.DataBind();
        con.Close();

    }


    private void Get_user_Id_Wise_Post()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Post(userid,1);

        rptPost.DataSource = ds;
        rptPost.DataBind();
        con.Close();

    }



}







