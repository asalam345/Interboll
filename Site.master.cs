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
using System.Collections;
public partial class SiteMaster : System.Web.UI.MasterPage
{
    DbContext dbContext = new DbContext();

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
    Byte MStatus=1;
    String User_Dob;
    String P_Image;
    String C_Image;
    String UserProfileName;

    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
    Int32 CountryId=1;
    Byte occupationId=1;
    Byte ReligionId=1;

    String U_University;
	String U_College;
	String 	U_School;
	String U_Contact;
    String U_Website;

    Int32 countryid;

    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        // Label1.Text = Application["Date"].ToString();
        //    getHits();
        if (!Page.IsPostBack)
        {
               
                
                
                
                loginname();
                ShowAdata();
          //  ShowADetail_Datadata();
                loadPost_Image();
                load_Frnd_Search();     //Friends Search
                load_Frnd_Search_Request(); //Friends Request Send
                load_Frnd_Search_Following(); //Friends Request Follow me
                load_Frnd_Followers();//Frnd list
                //Get_user_Id_Wise_Post();   //out line
                Get_user_Id_Wise_Notification();
                BindItemsListAlbum();
                FillLAddType();
                string path = Path.GetFileName(Request.Url.AbsolutePath);
                if (path == "eventdefault.aspx")
                {

                    leftevent1.Visible = true;

                }

                else
                {

                    left1.Visible = true;
                }
               

                
        }

        //Ali For Chat System ---------------------------------------------------Start
        if (Session["CurrentUserEmail"] == null)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            Response.Redirect("Home.aspx", true);
        }
        //Ali For Chat System ---------------------------------------------------End
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
           
           
            lblFirstname.Text= Session["First_Name"].ToString(); 
            
          //  Response.Redirect("Default.aspx"); 

        }
    }


    private void ShowADetail_Datadata()
    {

        
        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Detail_Id_Wise_Home_Page(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);
        
           MStatus = Convert.ToByte(ds.Tables[0].Rows[0]["Meritial_Status"]);
       
    

        
          
            CountryId = Convert.ToInt32(ds.Tables[0].Rows[0]["Country_Id"]);
           
           occupationId = Convert.ToByte(ds.Tables[0].Rows[0]["Occupation"]);
           

         

           
           ReligionId = Convert.ToByte(ds.Tables[0].Rows[0]["Religious"]);

           


          

           lblAdprofile.Text = "Edit Profile"; 



        }

        else
        {

            lblAdprofile.Text = "Add Profile"; 


        }
      
    }

    private void ShowAdata()
    {

        

        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Id_Wise(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            lblName.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
           
            lok2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            lok1.Text = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);

            

            //String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();

            UserProfileName = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
 
           


            string pImage = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            string Cimage = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);

            profileImage.ImageUrl = pImage;

            CoverImage.ImageUrl = Cimage;
            Label1.Text = pImage;//
            Label2.Text = Cimage;

            User_Dob = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); // DateTime.Now.ToString();
           // lblDob.Text = User_Dob;

            DateTime dt1 = Convert.ToDateTime(ds.Tables[0].Rows[0]["dob"]);
         

            String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();
        //    load_Month();
          //  load_Date();
           // load_Year();
            //comboLoad();

            //comboLoad();

        }
    }

    private void loadPost_Image()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
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

       string userid = Session["userid"].ToString();
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

             DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId,0);

             if (ds.Tables[0].Rows.Count > 0)
             {

                 return;

             }

             else

             {

                 string articleId1 = ClPost.Insert_p_tbl_tbUser_Friends(Convert.ToInt32(userid), frindId, 0, false, Postdate, Postdate);
                 load_Frnd_Search_Request();
                 load_Frnd_Search();
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

              
          rptFollowersDL.DataSource = ds;
          rptFollowersDL.DataBind();

          int s = ds.Tables[0].Rows.Count;

          if (s > 0)
          { lblcountfolower.Text = Convert.ToString(s);

          lblcountfolower.Visible = true;
          }

          else
          {
             
              lblcountfolower.Visible = false;
          }
          

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

        saveFollowerRequest(frindId);


    }


    protected void btnReplyClickedConfirm(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int frindId = int.Parse((sender as Button).CommandArgument);

        saveFollowerRequest(frindId);


    }


    protected void btnReplyClickedDelete(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }
        
        int frindId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DateTime Postdate = DateTime.Now;

        DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 2);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        else
        {

            string articleId1 = ClPost.Insert_p_tbl_tbUser_Friends(Convert.ToInt32(userid), frindId, 2, false, Postdate, Postdate);

            ClPost.Update_Frnd_Status(frindId, Convert.ToInt32(userid), 2);
            load_Frnd_Search_Following();
            load_Frnd_Followers();

        }


    }

    private void saveFollowerRequest(Int32 frindId )

    {

       // int frindId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DateTime Postdate = DateTime.Now;

        DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 1);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 2);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ClPost.Update_Frnd_Status(Convert.ToInt32(userid), frindId, 1);
            ClPost.Update_Frnd_Status(frindId, Convert.ToInt32(userid), 1);
            load_Frnd_Search_Following();
            load_Frnd_Followers();
            return;

        }


        ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 0);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ClPost.Update_Frnd_Status(Convert.ToInt32(userid), frindId,1);
            ClPost.Update_Frnd_Status(frindId, Convert.ToInt32(userid), 1);
            load_Frnd_Search_Following();
            load_Frnd_Followers();
            return;

        }

       

        else
        {

            string articleId1 = ClPost.Insert_p_tbl_tbUser_Friends(Convert.ToInt32(userid), frindId, 1, false, Postdate, Postdate);

            ClPost.Update_Frnd_Status(frindId, Convert.ToInt32(userid), 1);
            load_Frnd_Search_Following();
            load_Frnd_Followers();

        }

    
    
    }


    private void load_Frnd_Followers()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Frends_Followers(Convert.ToInt32(userid));

        rptFollowers.DataSource = ds;
        rptFollowers.DataBind();

        rptFriends.DataSource = ds;
        rptFriends.DataBind();
        con.Close();

    }


   

    protected void btnProfileImage_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
             Response.Redirect("Home.aspx");
        }

        Save1();

    }

    protected void btnCoverImage_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save1();

    }
    private void Save1()
    {

        ShowAdata();
       
            if (fileUploadProfileImage.HasFile)
            {
                string imagename = fileUploadProfileImage.PostedFile.FileName;
                //  string fileExtension = System.IO.Path.GetExtension(imagename);
                // string fname = System.IO.Path.GetFileName(imagename);
                string lok1 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;
                fileUploadProfileImage.SaveAs(Server.MapPath("images/Items/" + lok1));

                P_Image = ("images/Items/" + lok1);
                //
            }
            else
            {
                P_Image = Label1.Text;

            }

       
        //2nd image
       
        
        if (fileUploadCoverimage.HasFile)
          
        {
            string imagename = fileUploadCoverimage.PostedFile.FileName;
                String filename2 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;
                fileUploadCoverimage.SaveAs(Server.MapPath("images/Items/" + filename2));
                C_Image = ("images/Items/" + filename2);
                //
                //
            }
            else
            {
                C_Image = Label2.Text;

            }
  
       

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        //Date of Birth
        //string gid = Convert.ToString(ddlgender.SelectedItem.Value);
        //string dd = Convert.ToString(ddlDate.SelectedItem.Value);
        //string mm = Convert.ToString(DdlMonth.SelectedItem.Value);
        //string yyy = Convert.ToString(ddlYear.SelectedItem.Value);

        //end Date of Birth                             
      //  DateTime DOB1 = Convert.ToDateTime(yyy + '-' + mm + '-' + dd);

        string userid = Session["userid"].ToString();
        string userptofile = UserProfileName;
        DateTime DOB1 = Convert.ToDateTime(User_Dob);

        ClPost.Update_Cover_Profile_Pic(userid, userptofile, P_Image, C_Image, Convert.ToByte(Gender), DOB1);
        ShowAdata();
    }

    protected void btnLoginProfile1_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

     
        ShowAdata();
        ShowADetail_Datadata();

    }

    protected void btnLoginProfile2_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

      
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile3_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }


        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile4_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

      
        ShowAdata();
        ShowADetail_Datadata();
    }
    protected void btnLoginProfile5_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

     
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile6_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

    
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile7_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

       
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile8_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

    
        ShowAdata();
        ShowADetail_Datadata();

    }
  

   

   

    private void Get_user_Id_Wise_Notification()
    {
         //lok
        SqlConnection.ClearAllPools();
        con.Open();
        if (Session["CountryName"] == "")
        {

            lblContry.Text = "";
            Session["CountryName"] = "";
        }


        //lblContry.Text = Session["CountryName"].ToString();
        if (!string.IsNullOrEmpty(Session["CountryName"].ToString()))
        {

            lblContry.Text = Session["CountryName"].ToString();
        }
        else
        {
            lblContry.Text = "";

        }

        if (lblContry.Text == "Bangladesh")
        {
            countryid = 1;

        }

        else if (lblContry.Text == "United Kingdom")
        {

            countryid = 2;
        }

        else if (lblContry.Text == "India")
        {

            countryid = 3;
        }

        else if (lblContry.Text == "Sri Lanka")
        {

            countryid = 4;
        }

        else if (lblContry.Text == "Pakistan")
        {

            countryid = 5;
        }
        else if (lblContry.Text == "Maldives")
        {

            countryid = 6;
        }
        else if (lblContry.Text == "Bhutan")
        {

            countryid = 7;
        }
        else if (lblContry.Text == "Nepal")
        {

            countryid = 8;
        }


        else if (lblContry.Text == "China")
        {

            countryid = 9;
        }

        else if (lblContry.Text == "Japan")
        {

            countryid = 10;
        }

            //Pakistan
        //    Nepal      Maldives Bhutan  China

        else
        {
            countryid = 0;
        }

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Notification(userid,1);

        dlNotification.DataSource = ds;
        dlNotification.DataBind();
        int s = ds.Tables[0].Rows.Count;

        if (s > 0)
        {
            lblCountNtification.Text = Convert.ToString(s);
            lblCountNtification.Visible = true;
        }
        else
        {
            lblCountNtification.Visible = false;


        }
      
        con.Close();

    }

    protected void BindItemsListAlbum()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Album_List(userid);

        dlalbum.DataSource = ds;
        dlalbum.DataBind();

        dlalbum2.DataSource = ds;
        dlalbum2.DataBind();

        con.Close();
    }

    private void FillLAddType()
    {
        DataSet ds = ClPost.Get_Add_More();
        rptMore.DataSource = ds;
        rptMore.DataBind();



    }


    protected void btnReplyClicked12(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int frindId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DateTime Postdate = DateTime.Now;

        DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 2);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        else
        {
          
            ClPost.Update_Frnd_Status(Convert.ToInt32(userid),frindId, 2);
          //  load_Frnd_Search_Following();

        }



         ds = ClPost.Get_Check_Data_Folowers( frindId,Convert.ToInt32(userid), 2);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        else
        {

            ClPost.Update_Frnd_Status(frindId,Convert.ToInt32(userid), 2);
            //  load_Frnd_Search_Following();

        }

        load_Frnd_Followers();
        Response.Redirect("~/Default.aspx");

    }


   
}

   






