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

public partial class eventdetails1 : System.Web.UI.Page
{
    Int32 PostId;
    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
    Byte Likeid1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }

            String Nappies_Id = Request.QueryString["ID"];
            PostId = Convert.ToInt32(Nappies_Id);
            if (!string.IsNullOrEmpty(Nappies_Id))
            {
                PostId = Convert.ToInt32(Request.QueryString["ID"]);
                // Int32 PostId1 = Convert.ToInt32(StringCipher.Decrypt(Request.QueryString["ID1"]).ToString());

                Session["PostId"] = PostId.ToString();
            }
            else
            {
                // Response.Redirect("~/Mortgages.aspx", false);
            }
            loadpost();
            Update_Notification();
        }



    }


    private void loadpost()
    {

        if (Session["User_Name"] == null)
        {

            Response.Redirect("Home.aspx", true);

        }


        DataSet ds = ClPost.Get_Post_Post_Event_Id_Wise(PostId);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblDescription.Text = Convert.ToString(row["P_Description"]);
            //  lblAbout.Text = Convert.ToString(row["P_Description"]);
            lblEventName.Text = Convert.ToString(row["P_Name"]);
            lblEventName1.Text = Convert.ToString(row["P_Name"]);
            lblEventName2.Text = Convert.ToString(row["P_Name"]);
            lblLocation.Text = Convert.ToString(row["P_Location"]);
            lblLocation1.Text = Convert.ToString(row["P_Location"]);
            lblLocation2.Text = Convert.ToString(row["P_Location"]);
            lblTime.Text = Convert.ToString(row["P_Time"]);

            lblimage.Text = Convert.ToString(row["P_Image"]);

            lblinterestedCount.Text = Convert.ToString(row["InterestCount"]);
            lblgoingCount.Text = Convert.ToString(row["GoingCount"]);


            DateTime dt1 = Convert.ToDateTime(ds.Tables[0].Rows[0]["Event_Satrt_Date"]);
            lblDate.Text = dt1.ToString("MMMM dd, yyyy");
            lblDate1.Text = dt1.ToString("MMMM dd, yyyy");
            lblDate2.Text = dt1.ToString("MMMM dd, yyyy");

            string s = lblDate2.Text;

            String sDate = Convert.ToString(ds.Tables[0].Rows[0]["Event_Satrt_Date"]); ;// DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();

            load_Month();
            load_Date();

        }
        string userid = Session["userid"].ToString();
        DataSet ds1 = ClPost.Get_Check_LikeEvent(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds1.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds1.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);

            if (Likeid == 0)
            {
                lblIntersted.Text = "Interested";

            }

            else if (Likeid == 1)
            {
                ///Likeid1 = 0;
                lblIntersted.Text = "You Interested";
            }

        }

        DataSet ds2 = ClPost.Get_Check_Going_Event(PostId, userid);

        if (ds2.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds2.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);

            if (Likeid == 0)
            {
                LblGoing.Text = "Going";

            }

            else if (Likeid == 1)
            {
                ///Likeid1 = 0;
                LblGoing.Text = "You will go";
            }

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
        string S = DdlMonth.SelectedItem.Text;
        lblmonth.Text = S.Substring(0, 3);
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
        lblDay.Text = ddlDate.SelectedItem.Text;

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        PostId = Convert.ToInt32(Request.QueryString["ID"]);
        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Check_LikeEvent(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);

            if (Likeid == 0)
            {
                Likeid1 = 1;

            }

            else if (Likeid == 1)
            {
                Likeid1 = 0;

            }




            ClPost.Updade_Add_tbl_Event_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
            loadpost();
            return;
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_Event_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            loadpost();
            return;
        }


    }
    protected void btnLogin1_Click(object sender, EventArgs e)
    {
        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        PostId = Convert.ToInt32(Request.QueryString["ID"]);
        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Check_Going_Event(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);

            if (Likeid == 0)
            {
                Likeid1 = 1;

            }

            else if (Likeid == 1)
            {
                Likeid1 = 0;

            }




            ClPost.Updade_Add_tbl_Event_Going(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
            loadpost();
            return;
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_Event_Going(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            loadpost();
            return;
        }

    }

    protected void Update_Notification()
    {

        String Nappies_Id = Request.QueryString["ID"];
        Byte Product = Convert.ToByte(Request.QueryString["Product"]);

        ClPost.Update_Notification_Status(Nappies_Id, 5);


    }


}