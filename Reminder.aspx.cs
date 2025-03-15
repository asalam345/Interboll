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

public partial class Reminder : System.Web.UI.Page
{

    Byte P_Type;


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

        
    }
    private void load_Date()
    {

        

    }
    private void load_Year()
    {

       
    }



    private void load_Event_Type()
    {

       

    }


   


  

    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
       


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

        {

         

           
            loadPost();

        }



    }
    private void loadPost()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Reminder(userid);

        rptEvenpost.DataSource = ds;
        rptEvenpost.DataBind();
        con.Close();

    }


    private void loadPost_Upcomming()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Reminder(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];


            P_Type = Convert.ToByte(row["P_Type"]);

        //    rptUpcamming.DataSource = ds;
           // rptUpcamming.DataBind();

        }
        con.Close();


        loadPost_Past_Releted(P_Type);

    }


    private void loadPost_Past_Releted(Byte P_Type)
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Frnd_Calendar_Reminder(userid);

        rptFrndCalendar.DataSource = ds;
        rptFrndCalendar.DataBind();
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

       // rptPopular.DataSource = ds;
      //  rptPopular.DataBind();
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
                dy = "0" + datevalue.Day.ToString();

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