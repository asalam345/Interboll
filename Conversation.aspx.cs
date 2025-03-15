using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Configuration;
using System.Drawing;
using System.Collections;
using System.Web.UI.HtmlControls;

public partial class Conversation : System.Web.UI.Page
{
    DbContext dbContext = new DbContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUserEmail"] == null)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            Response.Redirect("Home.aspx", true);
        }

        lbUserLogin.PostBackUrl = "#";
        lbUserLogin.Text = "Welcome! " + Session["CurrentUserFirstName"] + " | ";
        lbUserLogin.ForeColor = System.Drawing.Color.White;
        lbUserRegister.PostBackUrl = "signout.aspx";
        lbUserRegister.Text = "Sign Out";
        lbUserRegister.ForeColor = System.Drawing.Color.White;

        if(!Page.IsPostBack)
        {
            ChatBoxOpen();
        }
        FriendListView();
        OnlineFriendCount();
        FriendChatRequestView();
    }

    protected void ChatBoxOpen()
    {
        try
        {
            ArrayList arrayList20 = new ArrayList();
            arrayList20.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            DataTable dt20 = dbContext.GetSelectedData_StoredProcedure("sptbUser_ChatBox_Open_All", arrayList20);
            rpChatBoxOpen.DataSource = dt20;
            rpChatBoxOpen.DataBind();
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
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
            DataTable dt = dbContext.GetSelectedData_StoredProcedure("spUser_FriendListOnlineCount_Show", arrayList);
            if (dt.Rows.Count > 0) 
                lbOnlineUserShow.Text = dt.Rows[0]["onlineUser"].ToString();
            else 
                lbOnlineUserShow.Text = "0";
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
            rpOnlineUsers.DataSource = dt;
            rpOnlineUsers.DataBind();
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
            rpChatRequest.DataSource = dt;
            rpChatRequest.DataBind();
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

        Response.Redirect("Conversation.aspx", true);
    }

    protected void rpOnlineUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField fhIsOnline = e.Item.FindControl("fhIsOnline") as HiddenField;
        bool getIsOnline = bool.Parse(fhIsOnline.Value);
        HiddenField fhIsBusy = e.Item.FindControl("fhIsBusy") as HiddenField;
        bool getIsBusy = bool.Parse(fhIsBusy.Value);
        HtmlGenericControl faIsOnline = e.Item.FindControl("faIsOnline") as HtmlGenericControl;
        HtmlGenericControl faIsBusy = e.Item.FindControl("faIsBusy") as HtmlGenericControl;

        if(getIsOnline)
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
        ArrayList arrayList1 = new ArrayList();
        arrayList1.Add(new SqlParameter("@u_idFrom", Session["CurrentUserId"].ToString()));
        arrayList1.Add(new SqlParameter("@u_idTo", Session["GetFriendId"].ToString()));
        DataTable dt1 = dbContext.GetSelectedData_StoredProcedure("spMessage_View", arrayList1);
        rpChatMessageShow.DataSource = dt1;
        rpChatMessageShow.DataBind();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        timerEvent();
    }

    protected void Timer2_Tick(object sender, EventArgs e)
    {
        timerEvent();
    }

    protected void Timer3_Tick(object sender, EventArgs e)
    {
        timerEvent();
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

                    Response.Redirect("Conversation.aspx", true);
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
        
        Response.Redirect("Conversation.aspx", true);
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
}