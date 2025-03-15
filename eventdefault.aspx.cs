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

public partial class eventdefault : System.Web.UI.Page
{
    Byte Date;
    Byte Month;
    Byte Year;
    Byte Type;
    String P_Image;
    Byte  Duration;
    Byte P_Type;
    String ImagePostid;

    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }
            load_Month();
            load_Date();
            load_Year();
            load_Event_Type();
            loadPost();
            loadPost_Upcomming();
            loadPost_Past();
            loadPost_Favourite();
            loadPost_frnd_Calendar();
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

        DataSet ds = ClPost.Load_Year1();
        ddlYear.DataSource = ds;
        ddlYear.DataTextField = "A_Name";
        ddlYear.DataValueField = "A_id";
        ddlYear.SelectedIndex = Year - 1;
        ddlYear.DataBind();

    }

   

    private void load_Event_Type()
    {

        DataSet ds = ClPost.Load_Event_Type();
        ddlEventType.DataSource = ds;
        ddlEventType.DataTextField = "T_Name";
        ddlEventType.DataValueField = "T_id";
        ddlEventType.SelectedIndex = Type - 1;
        ddlEventType.DataBind();

    }


    private void savedate()
    {
        //LOK daya

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        if (file_upload.HasFile)
        {
            string imagename = file_upload.PostedFile.FileName;
            //  string fileExtension = System.IO.Path.GetExtension(imagename);
            // string fname = System.IO.Path.GetFileName(imagename);
            string lok1 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;
            file_upload.SaveAs(Server.MapPath("images/Event/" + lok1));

            P_Image = ("images/Event/" + lok1);
            //
        }
        else
        {
            P_Image = Label1.Text;

        }

        string userid = Session["userid"].ToString();// = userid;
        String User_Name = Session["User_Name"].ToString();// = ProviderUserName;


           string dd = Convert.ToString(ddlDate.SelectedItem.Value);
        string mm = Convert.ToString(DdlMonth.SelectedItem.Value);
        string yyy = Convert.ToString(ddlYear.SelectedItem.Value);

        //end Date of Birth
        DateTime eventStartDate = Convert.ToDateTime(yyy + '-' + mm + '-' + dd);


        string x = txtDuration.Text;
        if (x == "")
        {
            Duration = 1;
        }
        else
        {
            Duration = Convert.ToByte(txtDuration.Text);
        }





        string tagid = "";// Lblsname.Text;

        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        Byte EventType = Convert.ToByte(ddlEventType.SelectedItem.Value);
        Byte F_Status = 1;// Convert.ToByte(ddlFstatus.SelectedItem.Value);
        //  string checkin = ddlCity.SelectedItem.Text;
        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Event_Post(hidArticleId.Value, txtEventName.Value, txtLocation.Value, txtTime.Value, txtdes.Value, EventType,
                Convert.ToInt32(userid), 1, Post_Date, P_Image, 1, 1, "", eventStartDate, Duration, tagid);
        }
        else
        {
            if (txtdes.Value == "")
            {

                return;
            }
            else
            {
                string articleId = ClPost.Insert_Add_tbl_Event_Post(txtEventName.Value, txtLocation.Value, txtTime.Value, txtdes.Value, EventType,
                    Convert.ToInt32(userid), 1, Post_Date, P_Image, 1, 1, "", eventStartDate, Duration, tagid);



                if (!string.IsNullOrEmpty(hidArticleId.Value))
                {
                    ImagePostid = hidArticleId.Value;
                }

                else
                {
                    DataSet ds = ClPost.Get_Max_Event_P_Id_User_Wise(Convert.ToInt32(userid));

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        ImagePostid = Convert.ToString(row["P_Id"]);


                    }

                }

                
                    tagadd(ImagePostid);

               


                txtEventName.Value = "";
                txtLocation.Value = "";
                txtTime.Value = "";
                txtdes.InnerText = "";

                file_upload.Attributes.Clear();
                Response.Redirect("refresh.aspx", true);
            }
        }


       


       
    }


    private void tagadd(String ImagePostid1)
    {
        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_FrndList(Convert.ToInt32(userid));

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblfrndlist.Text = Convert.ToString(ds.Tables[0].Rows[0]["results"]);
          

        }
        
        
        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
     
        string s = lblfrndlist.Text;
        string[] values = s.Split(',');
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = values[i].Trim();

            string articleId1 = ClPost.Insert_Add_tbl_Event_Tag(Convert.ToInt32(ImagePostid1), Convert.ToInt32(values[i].ToString()), Convert.ToInt32(userid), Post_Date, 1, 1);

        }

    }

    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
        foreach (RepeaterItem ri in rptEvenpost.Items)
        {
            Label lblUserpost = ri.FindControl("lblpostid") as Label;
            Label lblUserId = ri.FindControl("lblUserid") as Label;
           


            if (lblUserpost != null)
            {
                lbllokPost.Text = lblUserpost.Text;
                lbllokUser.Text = lblUserId.Text;

            }


          


            string userid = Session["userid"].ToString();




            DataSet ds = ClPost.Get_Check_UserPost_Event(Convert.ToInt32(lbllokPost.Text), userid);
            Label btnedit = ri.FindControl("Button1") as Label;
            Button deleteButton = ri.FindControl("deleteButton") as Button;

            if (ds.Tables[0].Rows.Count > 0)
            {

                btnedit.Visible = true;
                deleteButton.Visible = true;

            }
            else
            {

                btnedit.Visible = false;
                deleteButton.Visible = false;
                //  LinkButton1.Visible = false;
            }


           








        }

    }


    protected void btnReplyClicked1(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {

            Response.Redirect("Home.aspx", true);

        }
        int PostId = int.Parse((sender as Button).CommandArgument);

        


    }

    protected void btnReplyDelete(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int PostId = int.Parse((sender as Button).CommandArgument);
        string userid = Session["userid"].ToString();



        ClPost.Update_Post_Event_Status(PostId, Convert.ToInt32(userid), 2);

        loadPost();
        



    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (txtdes.Value == "")
        {

            return;
        }
        else
        {

            savedate();

            txtEventName.Value="";
            txtLocation.Value="";
            txtTime.Value="";
            txtdes.Value = "";
            loadPost();

        }



    }
    private void loadPost()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event(userid);

        rptEvenpost.DataSource = ds;
        rptEvenpost.DataBind();
        con.Close();

    }


    private void loadPost_Upcomming()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Upcomming(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];


            P_Type = Convert.ToByte(row["P_Type"]);

            rptUpcamming.DataSource = ds;
            rptUpcamming.DataBind();

        }
        con.Close();


        loadPost_Past_Releted(P_Type);

    }


    private void loadPost_Past_Releted(Byte P_Type)
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Releted(userid, P_Type);

        rptReleted.DataSource = ds;
        rptReleted.DataBind();
        con.Close();

    }


    private void loadPost_Past()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Past(userid);

        rptPastevent.DataSource = ds;
        rptPastevent.DataBind();
        con.Close();

    }

    private void loadPost_Favourite()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Popular(userid);

        rptPopular.DataSource = ds;
        rptPopular.DataBind();
        con.Close();

    }

    private void loadPost_frnd_Calendar()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
       // DataSet ds = ClPost.List_of_Frnd_Calendar(userid);
        DataSet ds = ClPost.Show_Calendar_Month_Year(userid);
      
        rptCalendar.DataSource = ds;
        rptCalendar.DataBind();
        con.Close();

    }

    protected void rptFrndCalendar_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Label lblMonthYear = (Label)e.Item.FindControl("lblMonthYear");


            Repeater childRepeater = (Repeater)e.Item.FindControl("rptdaydate");

           
            {
                string userid = Session["userid"].ToString();
                childRepeater.Visible = true;
                DataSet ds2 = ClPost.Show_Calendar(lblMonthYear.Text);
                childRepeater.DataSource = ds2;
                childRepeater.DataBind();
            }


           


        }

    }
    protected void rptdaydate_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Label lbldate = (Label)e.Item.FindControl("lbldate");
            

            
          //  String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();
            String sDate = lbldate.Text;//
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();
            int NumLen = Convert.ToInt32(dy).ToString().Length;
            int NumLen1 = Convert.ToInt32(mn).ToString().Length;

            if (NumLen == 1)

            {
                dy = "0"+datevalue.Day.ToString();
            
            }

            if (NumLen1 == 1)
            {
                mn = "0" + datevalue.Month.ToString();

            }

            DateTime DOB1 = Convert.ToDateTime(mn + '-' + dy);
            String DOBDate = Convert.ToString(mn + '-' + dy);

          
            
            Repeater childRepeater = (Repeater)e.Item.FindControl("rptFrndList");


            string userid = Session["userid"].ToString();
            DataSet ds = ClPost.List_of_Frnd_Calendar(userid, DOBDate);

            childRepeater.DataSource = ds;
            childRepeater.DataBind();




        }



    }
    protected void rptFrndList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

         
            Label lbldate1 = (Label)e.Item.FindControl("lblProfileName");

            string x = lbldate1.Text;

            Image img1 = (Image)e.Item.FindControl("Image1");

            if (!string.IsNullOrEmpty(lbldate1.Text))
            //  img1.Attributes["tittle"] = lbldate1.Text;
            {
                img1.ToolTip = lbldate1.Text;
            }
            else

            { 
            
            
            }
           
        }
    }
}