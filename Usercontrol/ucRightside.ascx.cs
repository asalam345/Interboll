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

public partial class Usercontrol_ucRightside : System.Web.UI.UserControl
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
            load_Frnd_Search();     //Friends Search
            load_Frnd_Search_Request(); //Friends Request Send
            load_Frnd_Search_Following(); //Friends Request Follow me
            load_Frnd_Followers();//Frnd list

            Get_user_Id_Wise_Notification();
            BindItemsListAlbum();
            string path = Path.GetFileName(Request.Url.AbsolutePath);
            FillLAddType();
            if (path == "eventdefault.aspx")
            {

             //   leftevent1.Visible = true;

            }

            else
            {

              //  left1.Visible = true;
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

        if (!Page.IsPostBack)
        {
            ChatBoxOpen();
        }
        FriendListView();
        OnlineFriendCount();
        FriendChatRequestView();

        //Ali For Chat System ---------------------------------------------------End
    }

    //Ali For Chat System ---------------------------------------------------Start
    protected void ChatBoxOpen()
    {
        try
        {
            ArrayList arrayList20 = new ArrayList();
            arrayList20.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            DataTable dt20 = dbContext.GetSelectedData_StoredProcedure("sptbUser_ChatBox_Open_All", arrayList20);
          //  rpChatBoxOpen.DataSource = dt20;
           // rpChatBoxOpen.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void OnlineFriendCount()
    {
        try
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            //DataTable dt = dbContext.GetSelectedData_StoredProcedure("spUser_FriendListOnlineCount_Show", arrayList);
            //if (dt.Rows.Count > 0)
            //  //  lbOnlineUserShow.Text = dt.Rows[0]["onlineUser"].ToString();
            //else
            //   // lbOnlineUserShow.Text = "";
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void FriendListView()
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            DataTable dt = dbContext.GetSelectedData_StoredProcedure("spUser_FriendList_Show", arrayList);
         //   rpOnlineUsers.DataSource = dt;
           // rpOnlineUsers.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void FriendChatRequestView()
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@u_whomRequestId", Session["CurrentUserId"].ToString()));
            DataTable dt = dbContext.GetSelectedData_StoredProcedure("spUser_Chat_Request_View", arrayList);
         //   rpChatRequest.DataSource = dt;
            //rpChatRequest.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btFriendList_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        RepeaterItem item = (RepeaterItem)lbtn.NamingContainer;
        HiddenField hfFirstName = item.FindControl("hfFirstName") as HiddenField;
        string getFirstName = hfFirstName.Value.ToString();
        HiddenField hfLastName = item.FindControl("hfLastName") as HiddenField;
        string getLastName = hfLastName.Value.ToString();

        Session["GetFriendId"] = lbtn.CommandArgument.ToString();

        ArrayList arrayList2 = new ArrayList();
        arrayList2.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
        arrayList2.Add(new SqlParameter("@isBusy", true));
        dbContext.UpdateData_StoredProcedure("spUser_update_online_busy", arrayList2);

        ArrayList arrayList10 = new ArrayList();
        arrayList10.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
        arrayList10.Add(new SqlParameter("@u_friendId", lbtn.CommandArgument.ToString()));
        DataTable dt10 = dbContext.GetSelectedData_StoredProcedure("sptbUser_ChatBox_Open_Check_Insert", arrayList10);
        if (dt10.Rows.Count == 0)
        {
            ArrayList arrayList30 = new ArrayList();
            arrayList30.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            arrayList30.Add(new SqlParameter("@u_friendId", lbtn.CommandArgument.ToString()));
            arrayList30.Add(new SqlParameter("@u_isBoxActive", true));
            arrayList30.Add(new SqlParameter("@isRemoved", false));
            dbContext.SaveData_StoredProcedure("sptbUser_ChatBox_Open_Insert", arrayList30);
        }
        else
        {
            ArrayList arrayList301 = new ArrayList();
            arrayList301.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            arrayList301.Add(new SqlParameter("@u_friendId", lbtn.CommandArgument.ToString()));
            arrayList301.Add(new SqlParameter("@u_isBoxActive", true));
            dbContext.UpdateData_StoredProcedure("sptbUser_ChatBox_Open_Update", arrayList301);
        }

        ArrayList arrayList1 = new ArrayList();
        arrayList1.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
        arrayList1.Add(new SqlParameter("@u_whomRequestId", lbtn.CommandArgument.ToString()));
        DataTable dt1 = dbContext.GetSelectedData_StoredProcedure("spUser_Chat_Request_Check_Insert", arrayList1);
        if (dt1.Rows.Count == 0)
        {
            ArrayList arrayList3 = new ArrayList();
            arrayList3.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
            arrayList3.Add(new SqlParameter("@u_whomRequestId", lbtn.CommandArgument.ToString()));
            arrayList3.Add(new SqlParameter("@isRequested", true));
            arrayList3.Add(new SqlParameter("@isRemoved", false));
            dbContext.SaveData_StoredProcedure("spUser_Chat_Request_Insert", arrayList3);
        }
        else
        {
            ArrayList arrayList11 = new ArrayList();
            arrayList11.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
            arrayList11.Add(new SqlParameter("@u_whomRequestId", lbtn.CommandArgument.ToString()));
            DataTable dt11 = dbContext.GetSelectedData_StoredProcedure("spUser_Chat_Request_Check_Update", arrayList11);
            if (dt11.Rows.Count == 0)
            {
                ArrayList arrayList33 = new ArrayList();
                arrayList33.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
                arrayList33.Add(new SqlParameter("@u_whomRequestId", lbtn.CommandArgument.ToString()));
                arrayList33.Add(new SqlParameter("@isRequested", true));
                dbContext.UpdateData_StoredProcedure("spUser_Chat_Request_Update", arrayList33);
            }
        }

        Response.Redirect("Default.aspx", true);
    }

    protected void rpOnlineUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField fhIsOnline = e.Item.FindControl("fhIsOnline") as HiddenField;
        bool getIsOnline = bool.Parse(fhIsOnline.Value);
        HiddenField fhIsBusy = e.Item.FindControl("fhIsBusy") as HiddenField;
        bool getIsBusy = bool.Parse(fhIsBusy.Value);
        HtmlGenericControl faIsOnline = e.Item.FindControl("faIsOnline") as HtmlGenericControl;
        HtmlGenericControl faIsBusy = e.Item.FindControl("faIsBusy") as HtmlGenericControl;

        if (getIsOnline)
        {
            faIsOnline.Attributes.Add("class", "fa fa-dot-circle-o chatexmargin2");
            faIsOnline.Attributes.Add("style", "color:red;");
        }

        if (getIsBusy)
        {
            faIsBusy.Attributes.Add("class", "fa fa-commenting-o chatexmargin2");
            faIsBusy.Attributes.Add("style", "color:red;");
        }

    }

    protected void timerEvent()
    {
        if (Session["GetFriendId"] != null)
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(new SqlParameter("@u_idFrom", Session["CurrentUserId"].ToString()));
            arrayList1.Add(new SqlParameter("@u_idTo", Session["GetFriendId"].ToString()));
            DataTable dt1 = dbContext.GetSelectedData_StoredProcedure("spMessage_View", arrayList1);
        //    rpChatMessageShow.DataSource = dt1;
          //  rpChatMessageShow.DataBind();
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        //timerEvent();
    }

    protected void Timer2_Tick(object sender, EventArgs e)
    {
        //timerEvent();
    }

    protected void Timer3_Tick(object sender, EventArgs e)
    {
        //timerEvent();
    }

    protected void btChatSend_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        RepeaterItem item = (RepeaterItem)lbtn.NamingContainer;
        HiddenField hfChatFriendId = item.FindControl("hfChatFriendId") as HiddenField;
        Int32 gethfChatFriendId = Convert.ToInt32(hfChatFriendId.Value);
        TextBox txChatMessage = item.FindControl("txChatMessage") as TextBox;

        if (Session["CurrentUserId"] != null)
        {
            if (txChatMessage.Text != string.Empty)
            {
                try
                {
                    ArrayList arrayList = new ArrayList();
                    arrayList.Add(new SqlParameter("@u_idFrom", Session["CurrentUserId"].ToString()));
                    arrayList.Add(new SqlParameter("@u_idTo", gethfChatFriendId));
                    arrayList.Add(new SqlParameter("@m_textMessage", txChatMessage.Text.Trim()));
                    arrayList.Add(new SqlParameter("@m_attachFile", null));
                    arrayList.Add(new SqlParameter("@m_fileName", null));
                    arrayList.Add(new SqlParameter("@m_fileExtension", null));
                    arrayList.Add(new SqlParameter("@m_sendReceiveStatus", true)); //true for send, false for receive
                    arrayList.Add(new SqlParameter("@m_readUnreadStatus", false)); //true for read, false for unread
                    arrayList.Add(new SqlParameter("@isRemovedFrom", false));
                    arrayList.Add(new SqlParameter("@isRemovedTo", false));
                    dbContext.SaveData_StoredProcedure("spMessage_Insert", arrayList);

                    Response.Redirect("Default.aspx", true);
                    //ArrayList arrayList1 = new ArrayList();
                    //arrayList1.Add(new SqlParameter("@u_idFrom", Session["CurrentUserId"].ToString()));
                    //arrayList1.Add(new SqlParameter("@u_idTo", gethfChatFriendId));
                    //DataTable dt = dbContext.GetSelectedData_StoredProcedure("spMessage_View", arrayList1);
                    //rpChatMessageShow.DataSource = dt;
                    //rpChatMessageShow.DataBind();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
    protected void btChatBoxClose_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        RepeaterItem item = (RepeaterItem)lbtn.NamingContainer;
        HiddenField hfChatFriendId = item.FindControl("hfChatFriendId") as HiddenField;
        Int32 gethfChatFriendId = Convert.ToInt32(hfChatFriendId.Value);

        ArrayList arrayList30 = new ArrayList();
        arrayList30.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
        arrayList30.Add(new SqlParameter("@u_friendId", gethfChatFriendId));
        arrayList30.Add(new SqlParameter("@u_isBoxActive", false));
        dbContext.UpdateData_StoredProcedure("sptbUser_ChatBox_Open_Update", arrayList30);

        ArrayList arrayList11 = new ArrayList();
        arrayList11.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
        arrayList11.Add(new SqlParameter("@u_whomRequestId", gethfChatFriendId));
        DataTable dt11 = dbContext.GetSelectedData_StoredProcedure("spUser_Chat_Request_Check_Update", arrayList11);
        if (dt11.Rows.Count > 0)
        {
            ArrayList arrayList33 = new ArrayList();
            arrayList33.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
            arrayList33.Add(new SqlParameter("@u_whomRequestId", gethfChatFriendId));
            arrayList33.Add(new SqlParameter("@isRequested", false));
            dbContext.UpdateData_StoredProcedure("spUser_Chat_Request_Update", arrayList33);
        }

        ArrayList arrayList2 = new ArrayList();
        arrayList2.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
        arrayList2.Add(new SqlParameter("@isBusy", false));
        dbContext.UpdateData_StoredProcedure("spUser_update_online_busy", arrayList2);

        Response.Redirect("Default.aspx", true);
    }

    protected void rpChatBoxOpen_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField hfChatFriendId = e.Item.FindControl("hfChatFriendId") as HiddenField;
        Int32 gethfChatFriendId = Convert.ToInt32(hfChatFriendId.Value);
        Repeater rpChatMessageShow = e.Item.FindControl("rpChatMessageShow") as Repeater;

        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@u_idFrom", Session["CurrentUserId"].ToString()));
            arrayList.Add(new SqlParameter("@u_idTo", gethfChatFriendId));
            DataTable dt = dbContext.GetSelectedData_StoredProcedure("spMessage_View", arrayList);
            rpChatMessageShow.DataSource = dt;
            rpChatMessageShow.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void rpChatMessageShow_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField hfUserIdFrom = e.Item.FindControl("hfUserIdFrom") as HiddenField;
        Int32 gethfUserIdFrom = Convert.ToInt32(hfUserIdFrom.Value);
        Int32 gethfUserISession = Convert.ToInt32(Session["CurrentUserId"].ToString());
        System.Web.UI.WebControls.Image messagePhoto = e.Item.FindControl("messagePhoto") as System.Web.UI.WebControls.Image;
        HtmlGenericControl messageTextDiv = e.Item.FindControl("messageText") as HtmlGenericControl;
        HtmlGenericControl messagePhotoDiv = e.Item.FindControl("messagePhotoDiv") as HtmlGenericControl;
        HtmlGenericControl textSpan = e.Item.FindControl("textSpan") as HtmlGenericControl;
        HiddenField hfFromPhoto = e.Item.FindControl("hfFromPhoto") as HiddenField;
        string getFromPhoto = hfFromPhoto.Value.ToString();
        HiddenField hfToPhoto = e.Item.FindControl("hfToPhoto") as HiddenField;
        string getToPhoto = hfToPhoto.Value.ToString();

        if (gethfUserIdFrom == gethfUserISession)
        {
            messageTextDiv.Attributes.Add("style", "background:#4080FF; padding:5px 10px 5px 10px; border-radius:20px;color:#fff;text-align:right;float: right;margin-right: -30px;margin-left: 5px;");
            messagePhoto.ImageUrl = getFromPhoto;
            messagePhoto.Attributes.Add("class", "pull-right");
            messagePhotoDiv.Attributes.Add("class", "pull-right");
            textSpan.Attributes.Add("style", "margin-top: 34px;margin-right: -30px;font-size:8px;");
        }
        else
        {
            messagePhoto.ImageUrl = getToPhoto;
            messageTextDiv.Attributes.Add("style", "background:#F1F0F0; padding:5px 10px 5px 10px; border-radius:20px;color:#000;float: left;");
        }
    }
    protected void btRefress_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        RepeaterItem item = (RepeaterItem)lbtn.NamingContainer;
        HiddenField hfChatFriendId = item.FindControl("hfChatFriendId") as HiddenField;
        Int32 gethfChatFriendId = Convert.ToInt32(hfChatFriendId.Value);
        Repeater rpChatMessageShow = item.FindControl("rpChatMessageShow") as Repeater;

        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@u_idFrom", Session["CurrentUserId"].ToString()));
            arrayList.Add(new SqlParameter("@u_idTo", gethfChatFriendId));
            DataTable dt = dbContext.GetSelectedData_StoredProcedure("spMessage_View", arrayList);
            rpChatMessageShow.DataSource = dt;
            rpChatMessageShow.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    //Ali For Chat System ---------------------------------------------------End

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


        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Detail_Id_Wise_Home_Page(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);

            MStatus = Convert.ToByte(ds.Tables[0].Rows[0]["Meritial_Status"]);
          //  lblMyself.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Intro"]);


            CountryId = Convert.ToInt32(ds.Tables[0].Rows[0]["Country_Id"]);
          //  lblCountry.Text = Convert.ToString(ds.Tables[0].Rows[0]["Country_Name"]);
           // lblRelesonship.Text = Convert.ToString(ds.Tables[0].Rows[0]["Maritial_Status_Name"]);
          //  lblRelation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Maritial_Status_Name"]);
            occupationId = Convert.ToByte(ds.Tables[0].Rows[0]["Occupation"]);
          //  lblOcupation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Occupation_Name"]);
         //   lblPresentWorkstatus.Text = Convert.ToString(ds.Tables[0].Rows[0]["Present_Working_Status"]);
          //  lblPastExperiance.Text = Convert.ToString(ds.Tables[0].Rows[0]["Past_Experiance"]);

          ///  lblpresentAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["Present_Address"]);

        
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
          //  lblProfileName1.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
            lok2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            lok1.Text = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);



            //String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();

            UserProfileName = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
          
            Gender = Convert.ToByte(ds.Tables[0].Rows[0]["U_Gender"]);
            //if (Convert.ToByte(Gender) == 1)
            //{

            //    lblGender.Text = "Male";

            //}
            //else
            //{
            //    lblGender.Text = "FeMale";

        //    }



            string pImage = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
            string Cimage = Convert.ToString(ds.Tables[0].Rows[0]["Cover_Image"]);

            profileImage.ImageUrl = pImage;

            CoverImage.ImageUrl = Cimage;
            Label1.Text = pImage;//
            Label2.Text = Cimage;

            User_Dob = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); // DateTime.Now.ToString();
            // lblDob.Text = User_Dob;

            DateTime dt1 = Convert.ToDateTime(ds.Tables[0].Rows[0]["dob"]);
            //lblDob.Text = dt1.ToString("MMMM dd, yyyy");

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

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Pic(userid);

     //   dlPostImage.DataSource = ds;
       // dlPostImage.DataBind();


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


        rptFollowersDL.DataSource = ds;
        rptFollowersDL.DataBind();
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

        }


    }

    private void saveFollowerRequest(Int32 frindId)
    {

        // int frindId = int.Parse((sender as Button).CommandArgument);

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

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Frends_Followers(Convert.ToInt32(userid));

        rptFollowers.DataSource = ds;
        rptFollowers.DataBind();

       // rptFriends.DataSource = ds;
       // rptFriends.DataBind();
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

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Notification(userid,1);

        dlNotification.DataSource = ds;
        dlNotification.DataBind();
        int s = ds.Tables[0].Rows.Count;
        lblCountNtification.Text = Convert.ToString(s);
        con.Close();

    }

    protected void BindItemsListAlbum()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Album_List(userid);

       // dlalbum.DataSource = ds;
        //dlalbum.DataBind();

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

}








