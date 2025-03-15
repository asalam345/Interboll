using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;

public partial class setting : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
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


    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
    Int32 CountryId = 1;
    Byte occupationId = 1;
    Byte ReligionId = 1;

    protected string ProviderPassword
    {
        get { return (string)ViewState["ProviderPassword"] ?? String.Empty; }
        private set { ViewState["ProviderPassword"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loginname();
            ShowAdata();
            ShowADetail_Datadata();

            BindItemsListFrndlist();
        }




     //   FillLAddType();


    }

    protected void BindItemsListFrndlist()
    {


        SqlConnection.ClearAllPools();
      
        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Frndlist_Setting(userid);

        rptPost.DataSource = ds;
        rptPost.DataBind();

       
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
            //lblProfileName1.Text = lblFirstname.Text;
            //  Response.Redirect("Default.aspx"); 
            lbllogin.Text = (Session["User_Name"].ToString());

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
            lblMyself.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Intro"]);
            txtP_Intro.Value = Convert.ToString(ds.Tables[0].Rows[0]["P_Intro"]);

            txtFamily.Value = Convert.ToString(ds.Tables[0].Rows[0]["No_Of_Children"]);
            lblFamily.Text = Convert.ToString(ds.Tables[0].Rows[0]["No_Of_Children"]);

            CountryId = Convert.ToInt32(ds.Tables[0].Rows[0]["Country_Id"]);
            lblCountry.Text = Convert.ToString(ds.Tables[0].Rows[0]["Country_Name"]);
            lblRelesonship.Text = Convert.ToString(ds.Tables[0].Rows[0]["Maritial_Status_Name"]);
            lblRelation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Maritial_Status_Name"]);
            occupationId = Convert.ToByte(ds.Tables[0].Rows[0]["Occupation"]);
            lblOcupation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Occupation_Name"]);
            lblPresentWorkstatus.Text = Convert.ToString(ds.Tables[0].Rows[0]["Present_Working_Status"]);
            txtPresentWorkingStatus.Value = Convert.ToString(ds.Tables[0].Rows[0]["Present_Working_Status"]);
            lblPastExperiance.Text = Convert.ToString(ds.Tables[0].Rows[0]["Past_Experiance"]);
            txtPastexperiance.Value = Convert.ToString(ds.Tables[0].Rows[0]["Past_Experiance"]);
            lblpresentAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["Present_Address"]);

            txtQualification.Value = Convert.ToString(ds.Tables[0].Rows[0]["QUALIFICATIONS"]);
            txtPoliticalView.Value = Convert.ToString(ds.Tables[0].Rows[0]["Political_View"]);
            lblPoliticalView.Text = Convert.ToString(ds.Tables[0].Rows[0]["Political_View"]);

            ReligionId = Convert.ToByte(ds.Tables[0].Rows[0]["Religious"]);

            txtSports.Value = Convert.ToString(ds.Tables[0].Rows[0]["Sports"]);
            lblSports.Text = Convert.ToString(ds.Tables[0].Rows[0]["Sports"]);

            txtHobby.Value = Convert.ToString(ds.Tables[0].Rows[0]["HobbY"]);
            lblHobby.Text = Convert.ToString(ds.Tables[0].Rows[0]["HobbY"]);
            
            txtFavfoods.Value = Convert.ToString(ds.Tables[0].Rows[0]["Foods"]);
            lblFabfood.Text = Convert.ToString(ds.Tables[0].Rows[0]["Foods"]);

            lblContactNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_Contact"]);
            lblWebsite.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_Website"]);
            txtUniversity.Value = Convert.ToString(ds.Tables[0].Rows[0]["U_University"]);
            lblCollege.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_College"]);
            lblSchool.Text = Convert.ToString(ds.Tables[0].Rows[0]["U_School"]);
            lblQualification.Text = Convert.ToString(ds.Tables[0].Rows[0]["QUALIFICATIONS"]);



            txtContactno.Value = Convert.ToString(ds.Tables[0].Rows[0]["U_Contact"]);
            txtWebsite.Value = Convert.ToString(ds.Tables[0].Rows[0]["U_Website"]);
            txtUniversity.Value = Convert.ToString(ds.Tables[0].Rows[0]["U_University"]);
            txtCollegename.Value = Convert.ToString(ds.Tables[0].Rows[0]["U_College"]);
            txtSchoolname.Value = Convert.ToString(ds.Tables[0].Rows[0]["U_School"]);

            //  lblAdprofile.Text = "Edit Profile"; 



        }

        else
        {

            //lblAdprofile.Text = "Add Profile"; 


        }
        load_Country1();
        load_Occupation1();
        load_MeritialStatus1();

    }

    private void ShowAdata()
    {



        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Id_Wise(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            profileName.Value = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            lblProfileName1.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            lok2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            lok1.Text = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);






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

            // profileImage.ImageUrl = pImage;

            //CoverImage.ImageUrl = Cimage;
            Label1.Text = pImage;//
            Label2.Text = Cimage;

            User_Dob = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); // DateTime.Now.ToString();
            // lblDob.Text = User_Dob;

            DateTime dt1 = Convert.ToDateTime(ds.Tables[0].Rows[0]["dob"]);
            lblDob.Text = dt1.ToString("MMMM dd, yyyy");

            String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();
            load_Month();
            load_Date();
            load_Year();
            comboLoad();

            comboLoad();

        }
    }
    private void load_Month()
    {

        DataSet ds = ClPost.Load_Month();
        DdlMonth.DataSource = ds;
        DdlMonth.DataTextField = "A_Name";
        DdlMonth.DataValueField = "A_id";
        //  DdlMonth.SelectedIndex = Month - 1;
        DdlMonth.SelectedValue = Convert.ToString(mn.ToString());
        DdlMonth.DataBind();

    }
    private void load_Date()
    {

        DataSet ds = ClPost.Load_Date();
        ddlDate.DataSource = ds;
        ddlDate.DataTextField = "A_Name";
        ddlDate.DataValueField = "A_id";
        //ddlDate.SelectedIndex = Date - 1;
        ddlDate.SelectedValue = Convert.ToString(dy.ToString());
        ddlDate.DataBind();

    }
    private void load_Year()
    {

        DataSet ds = ClPost.Load_Year();
        ddlYear.DataSource = ds;
        ddlYear.DataTextField = "A_Name";
        ddlYear.DataValueField = "A_id";
        ddlYear.SelectedValue = Convert.ToString(yy.ToString());

        //  ddlYear.Text = yy;

        ddlYear.DataBind();

    }

    public void comboLoad()
    {
        ddlgender.SelectedIndex = Gender - 1;
        ddlgender.DataBind();
    }
    private void load_Country()
    {

        DataSet ds = ClPost.Load_Countrys();
        ddlCountry.DataSource = ds;
        ddlCountry.DataTextField = "Name";
        ddlCountry.DataValueField = "IId";
        ddlCountry.SelectedIndex = CountryId - 1;
        ddlCountry.DataBind();

    }


    private void load_Country1()
    {

        DataSet ds = ClPost.Load_Countrys();
        ddlCountry.DataSource = ds;
        ddlCountry.DataTextField = "Name";
        ddlCountry.DataValueField = "IId";
        ddlCountry.SelectedValue = Convert.ToString(CountryId.ToString());
        ddlCountry.DataBind();

    }

    private void load_Occupation()
    {

        DataSet ds = ClPost.Load_Occupation();
        ddlocupation.DataSource = ds;
        ddlocupation.DataTextField = "A_Name";
        ddlocupation.DataValueField = "A_Id";
        ddlocupation.SelectedIndex = occupationId - 1;
        ddlocupation.DataBind();

    }


    private void load_Occupation1()
    {

        DataSet ds = ClPost.Load_Occupation();
        ddlocupation.DataSource = ds;
        ddlocupation.DataTextField = "A_Name";
        ddlocupation.DataValueField = "A_Id";
        ddlocupation.SelectedValue = Convert.ToString(occupationId.ToString());
        ddlocupation.DataBind();

    }

    private void load_MeritialStatus()
    {

        DataSet ds = ClPost.Load_Maretial_Status();
        DDlMerial.DataSource = ds;
        DDlMerial.DataTextField = "F_Name";
        DDlMerial.DataValueField = "F_id";
        DDlMerial.SelectedIndex = MStatus - 1;
        DDlMerial.DataBind();

    }
    private void load_MeritialStatus1()
    {

        DataSet ds = ClPost.Load_Maretial_Status();
        DDlMerial.DataSource = ds;
        DDlMerial.DataTextField = "F_Name";
        DDlMerial.DataValueField = "F_id";
        DDlMerial.SelectedValue = Convert.ToString(MStatus.ToString());
        DDlMerial.DataBind();

    }

    private void Save2()
    {


        string userid = Session["userid"].ToString();

        String P_Intro = txtP_Intro.Value;
        Byte Meritial_Status = Convert.ToByte(DDlMerial.SelectedItem.Value);
        Byte Meritial_Status_V = 1;
        String No_Of_Children = txtFamily.Value;
        Byte No_Of_Children_V = 1;
        Int32 Country_Id = Convert.ToInt32(ddlCountry.SelectedItem.Value);
        Int32 City_Id = 1;
        String Present_Address = txtpresentAddress.Value;
        String Parmanent_Address = txtparmanentAddress.Value;
        Byte Occupation = Convert.ToByte(ddlocupation.SelectedItem.Value);
        Byte Occupation_V = 1;
        String Present_Working_Status = txtPresentWorkingStatus.Value;
        Byte Present_Working_Status_V = 1;
        String Past_Experiance = txtPastexperiance.Value;
        Byte Past_Experiance_V = 1;
        String QUALIFICATIONS = txtQualification.Value;
        Byte QUALIFICATIONS_V = 1;
        String Political_View = txtPoliticalView.Value;
        Byte Political_View_V = 1;
        Byte Religious = 0;// Convert.ToByte(ddlReligious.SelectedItem.Value);
        Byte Religious_V = 1;
        String Sports = txtSports.Value;
        String HobbY = txtHobby.Value;
        String Foods = txtFavfoods.Value;
        Int32 A_User_Id = Convert.ToInt32(userid);
        String Fav_Movie = txtFavfoods.Value;

        String U_University = txtUniversity.Value;
        String U_College = txtCollegename.Value;
        String U_School = txtSchoolname.Value;
        String U_Contact = txtContactno.Value;
        String U_Website = txtWebsite.Value;



        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_User_Detail(hidArticleId.Value, P_Intro, Meritial_Status, Meritial_Status_V, No_Of_Children, No_Of_Children_V, Country_Id, City_Id, Present_Address, Parmanent_Address
        , Occupation, Occupation_V, Present_Working_Status, Present_Working_Status_V, Past_Experiance, Past_Experiance_V, QUALIFICATIONS, QUALIFICATIONS_V, Political_View, Political_View_V, Religious, Religious_V, Sports
        , HobbY, Foods, A_User_Id, Fav_Movie, U_University, U_College, U_School, U_Contact, U_Website);
        }
        else
        {
            // add as a new article
            string articleId = ClPost.Insert_Add_User_Detail(P_Intro, Meritial_Status, Meritial_Status_V, No_Of_Children, No_Of_Children_V, Country_Id, City_Id, Present_Address, Parmanent_Address
        , Occupation, Occupation_V, Present_Working_Status, Present_Working_Status_V, Past_Experiance, Past_Experiance_V, QUALIFICATIONS, QUALIFICATIONS_V, Political_View, Political_View_V, Religious, Religious_V, Sports
          , HobbY, Foods, A_User_Id, Fav_Movie, U_University, U_College, U_School, U_Contact, U_Website);

            // Response.Redirect("P_Profile.aspx");

        }

        string gid = Convert.ToString(ddlgender.SelectedItem.Value);
        string dd = Convert.ToString(ddlDate.SelectedItem.Value);
        string mm = Convert.ToString(DdlMonth.SelectedItem.Value);
        string yyy = Convert.ToString(ddlYear.SelectedItem.Value);

        //end Date of Birth
        DateTime DOB1 = Convert.ToDateTime(yyy + '-' + mm + '-' + dd);



        P_Image = Label1.Text;
        C_Image = Label2.Text;


        ClPost.Update_Cover_Profile_Pic(userid, profileName.Value, P_Image, C_Image, Convert.ToByte(gid), DOB1);
    }









    protected void btnLoginProfile1_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile2_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile3_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile4_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();
    }
    protected void btnLoginProfile5_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile6_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile7_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }
    protected void btnLoginProfile8_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        Save2();
        ShowAdata();
        ShowADetail_Datadata();

    }

    protected void btnReplyClicked12(object sender, EventArgs e)
    {




    }
    
   

    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Button Button2 = (Button)e.Item.FindControl("Button2");
            Label status = (Label)e.Item.FindControl("Label6");

            if (status.Text.Trim() == "ACTIVE")
            {
                Button2.Text = "BLOCK";
            }
            else
            {
                Button2.Text = "Un BLOCK";
            }


        }



       
    }

    protected void itemRepeater_ItemCreated(object source, RepeaterCommandEventArgs e)
    {
      
        string userid = Session["userid"].ToString();
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
          
            Button Button3 = (Button)e.Item.FindControl("Button3");
            Button Button2 = (Button)e.Item.FindControl("Button2");
            Label status = (Label)e.Item.FindControl("Label6");
            Byte sid;

            if (status.Text.Trim() == "ACTIVE")

            {
                sid = 1;
            }
            else
            {
                sid = 0;
            }

            if (e.CommandName == "lokin") // check command is cmd_delete
            {
                // get you required value
                
                
                int CustomerID = Convert.ToInt32(e.CommandArgument);

              
                //  Repeater rptAttValue = (Repeater)e.Item.FindControl("divlok");

                DataSet ds = ClPost.Get_Check_Blog(Convert.ToInt32(userid), CustomerID);
                DateTime Postdate = DateTime.Now;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];




                    ClPost.Update_Frnd_Status_Blok(Convert.ToInt32(userid), Convert.ToInt32(CustomerID), sid);
                   // loadPost();
                    BindItemsListFrndlist();
                    return;
                }

                else
                {


                    string articleId1 = ClPost.Insert_Add_tbl_Blpck(Convert.ToInt32(userid), Convert.ToInt32(CustomerID), Postdate, 1);
                   // loadPost();
                    BindItemsListFrndlist();
                    return;
                }




            }
        }
    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Ali 1

        ProviderPassword = blog.Encrypt(txtPassword.Text.Trim());


        string em = Articles.Check_User((Session["User_Name"].ToString()), ProviderPassword);
           
            if (!string.IsNullOrEmpty(em))
            {


                if (string.IsNullOrEmpty(txtnewpass.Text))

                    {

                        return;
                    }
                
                
                string  ProviderPassword1 = blog.Encrypt(txtnewpass.Text.Trim());


                Articles.Update_user_Password((Session["User_Name"].ToString()), ProviderPassword1);

                Response.Redirect("Home.aspx");
            }
            else
            {
               lblMessege.Visible=true;
               lblMessege.Text = "Password is not Valid";
 
            }
        }
      
    }

    

