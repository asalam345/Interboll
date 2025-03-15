using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Globalization;

public partial class Usercontrol_Profile : System.Web.UI.UserControl
{
    String P_Image;
    String C_Image;
    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
    Byte Gender;

    Byte MStatus;
    Int32 CountryId;
    Byte occupationId;
    Byte ReligionId;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowAdata();
            ShowADetail_Datadata();
            //sale.Visible = false;
        }

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Save1();
        ShowAdata();


    }

    private void ShowAdata()
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Id_Wise(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            profileName.Value = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            Gender = Convert.ToByte(ds.Tables[0].Rows[0]["U_Gender"]);
            string pImage = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            string Cimage = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);

            profileImage.ImageUrl = "../"+ pImage;

            CoverImage.ImageUrl = "../" + Cimage;
            Label1.Text = pImage;//
            Label2.Text = Cimage;

            String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();
            load_Month();
            load_Date();
            load_Year();
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
    private void Save1()
    {

        byte Photo_Status = Convert.ToByte(dlphotostat1.SelectedItem.Value);
        if (Photo_Status == 0)
        {
            if (fileUpload1.HasFile)
            {
                string imagename = fileUpload1.PostedFile.FileName;
                //  string fileExtension = System.IO.Path.GetExtension(imagename);
                // string fname = System.IO.Path.GetFileName(imagename);
                string lok1 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;
                fileUpload1.SaveAs(Server.MapPath("images/Items/" + lok1));

                P_Image = ("images/Items/" + lok1);
                //
            }
            else
            {
                P_Image = Label1.Text;

            }
        }
        else
        {
            P_Image = "";

        }
        //2nd image
        Photo_Status = Convert.ToByte(dlphotostat2.SelectedItem.Value);
        if (Photo_Status == 0)
        {
            if (fileUpload2.HasFile)
            {
                string imagename = fileUpload2.PostedFile.FileName;
                String filename2 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;
                fileUpload2.SaveAs(Server.MapPath("images/Items/" + filename2));
                C_Image = ("images/Items/" + filename2);
                //
                //
            }
            else
            {
                C_Image = Label2.Text;

            }
        }
        else
        {
            C_Image = "";
        }


        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        //Date of Birth
        string gid = Convert.ToString(ddlgender.SelectedItem.Value);
        string dd = Convert.ToString(ddlDate.SelectedItem.Value);
        string mm = Convert.ToString(DdlMonth.SelectedItem.Value);
        string yyy = Convert.ToString(ddlYear.SelectedItem.Value);

        //end Date of Birth
        DateTime DOB1 = Convert.ToDateTime(yyy + '-' + mm + '-' + dd);

        string userid = Session["userid"].ToString();



        ClPost.Update_Cover_Profile_Pic(userid, profileName.Value, P_Image, C_Image, Convert.ToByte(gid), DOB1);
    }

    //load detail table data


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


    private void load_Religious()
    {

        DataSet ds = ClPost.Load_Religious();
        ddlReligious.DataSource = ds;
        ddlReligious.DataTextField = "A_Name";
        ddlReligious.DataValueField = "A_Id";
        ddlReligious.SelectedIndex = ReligionId - 1;
        ddlReligious.DataBind();

    }


    private void load_Religious1()
    {

        DataSet ds = ClPost.Load_Religious();
        ddlReligious.DataSource = ds;
        ddlReligious.DataTextField = "A_Name";
        ddlReligious.DataValueField = "A_Id";
        ddlReligious.SelectedValue = Convert.ToString(ReligionId.ToString());
        ddlReligious.DataBind();

    }


    //end

    private void ShowADetail_Datadata()
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Detail_Id_Wise(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);
            txtP_Intro.Value = Convert.ToString(ds.Tables[0].Rows[0]["P_Intro"]);
            MStatus = Convert.ToByte(ds.Tables[0].Rows[0]["Meritial_Status"]);
            txtFamily.Value = Convert.ToString(ds.Tables[0].Rows[0]["No_Of_Children"]);
            CountryId = Convert.ToInt32(ds.Tables[0].Rows[0]["Country_Id"]);
            txtPresentAddress.Value = Convert.ToString(ds.Tables[0].Rows[0]["Present_Address"]);
            txtParmanent.Value = Convert.ToString(ds.Tables[0].Rows[0]["Parmanent_Address"]);
            occupationId = Convert.ToByte(ds.Tables[0].Rows[0]["Occupation"]);

            txtPresentWorkingStatus.Value = Convert.ToString(ds.Tables[0].Rows[0]["Present_Working_Status"]);
            txtPastworkingstatus.Value = Convert.ToString(ds.Tables[0].Rows[0]["Past_Experiance"]);
            txtQualification.Value = Convert.ToString(ds.Tables[0].Rows[0]["QUALIFICATIONS"]);
            txtPoliticalView.Value = Convert.ToString(ds.Tables[0].Rows[0]["Political_View"]);
            ReligionId = Convert.ToByte(ds.Tables[0].Rows[0]["Religious"]);

            txtSports.Value = Convert.ToString(ds.Tables[0].Rows[0]["Sports"]);
            txtHobby.Value = Convert.ToString(ds.Tables[0].Rows[0]["HobbY"]);
            txtFavfoods.Value = Convert.ToString(ds.Tables[0].Rows[0]["Foods"]);


            load_Country1();
            load_MeritialStatus1();
            load_Occupation1();
            load_Religious1();



        }

        else
        {

            load_Country();
            load_MeritialStatus();
            load_Occupation();
            load_Religious();


        }


    }
    protected void btnLogin1_Click(object sender, EventArgs e)
    {
        Save2();
        // ShowAdata();


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
        String Present_Address = txtPresentAddress.Value;
        String Parmanent_Address = txtParmanent.Value;
        Byte Occupation = Convert.ToByte(ddlocupation.SelectedItem.Value);
        Byte Occupation_V = 1;
        String Present_Working_Status = txtPastworkingstatus.Value;
        Byte Present_Working_Status_V = 1;
        String Past_Experiance = txtPastworkingstatus.Value;
        Byte Past_Experiance_V = 1;
        String QUALIFICATIONS = txtQualification.Value;
        Byte QUALIFICATIONS_V = 1;
        String Political_View = txtPoliticalView.Value;
        Byte Political_View_V = 1;
        Byte Religious = Convert.ToByte(ddlReligious.SelectedItem.Value);
        Byte Religious_V = 1;
        String Sports = txtSports.Value;
        String HobbY = txtHobby.Value;
        String Foods = txtFavfoods.Value;
        Int32 A_User_Id = Convert.ToInt32(userid);
        String Fav_Movie = txtFavfoods.Value;





        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

        //    ClPost.Update_User_Detail(hidArticleId.Value, P_Intro, Meritial_Status, Meritial_Status_V, No_Of_Children, No_Of_Children_V, Country_Id, City_Id, Present_Address, Parmanent_Address
        //, Occupation, Occupation_V, Present_Working_Status, Present_Working_Status_V, Past_Experiance, Past_Experiance_V, QUALIFICATIONS, QUALIFICATIONS_V, Political_View, Political_View_V, Religious, Religious_V, Sports
        //, HobbY, Foods, A_User_Id, Fav_Movie);
        }
        else
        {
        //    // add as a new article
        //    string articleId = ClPost.Insert_Add_User_Detail(P_Intro, Meritial_Status, Meritial_Status_V, No_Of_Children, No_Of_Children_V, Country_Id, City_Id, Present_Address, Parmanent_Address
        //, Occupation, Occupation_V, Present_Working_Status, Present_Working_Status_V, Past_Experiance, Past_Experiance_V, QUALIFICATIONS, QUALIFICATIONS_V, Political_View, Political_View_V, Religious, Religious_V, Sports
        //, HobbY, Foods, A_User_Id, Fav_Movie);

          //  Response.Redirect("P_Profile.aspx");

        }
    }
}
