using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Self_signout : System.Web.UI.Page
{
    DbContext dbContext = new DbContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userid"] != null)
        {
            HttpCookie c = new HttpCookie("userid");
            c.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c);
        }
        Session["User_Name"] = null;
        Session["FrnId"] = null;
        Session["First_Name"] = "";
        Session["First_Name"] = null;
        Session["userid"] = null;

        //Ali For Chat System ---------------------------------------------------Start
        if (Session["CurrentUserId"] != null)
        {
            try
            {
                ArrayList arrayList2 = new ArrayList();
                arrayList2.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
                arrayList2.Add(new SqlParameter("@isOnline", false));
                dbContext.UpdateData_StoredProcedure("spUser_update_online", arrayList2);
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                ArrayList arrayList2 = new ArrayList();
                arrayList2.Add(new SqlParameter("@u_id", Session["CurrentUserId"].ToString()));
                arrayList2.Add(new SqlParameter("@isBusy", false));
                dbContext.UpdateData_StoredProcedure("spUser_update_online_busy", arrayList2);
            }
            catch (Exception)
            {
                throw;
            }

            if (Session["GetFriendId"] != null)
            {
                ArrayList arrayList11 = new ArrayList();
                arrayList11.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
                arrayList11.Add(new SqlParameter("@u_whomRequestId", Session["GetFriendId"].ToString()));
                DataTable dt11 = dbContext.GetSelectedData_StoredProcedure("spUser_Chat_Request_Check_Update", arrayList11);
                
                if (dt11.Rows.Count > 0)
                {
                    ArrayList arrayList33 = new ArrayList();
                    arrayList33.Add(new SqlParameter("@u_fromRequestId", Session["CurrentUserId"].ToString()));
                    arrayList33.Add(new SqlParameter("@u_whomRequestId", Session["GetFriendId"].ToString()));
                    arrayList33.Add(new SqlParameter("@isRequested", false));
                    dbContext.UpdateData_StoredProcedure("spUser_Chat_Request_Update", arrayList33);
                }
            }

            Session["CurrentUserId"] = null;
            Session["CurrentUserEmail"] = null;
            Session["CurrentUserFirstName"] = null;
            Session["CurrentUserLastName"] = null;
            Session["CurrentUserProfilePhoto"] = null;

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            Response.Redirect("Home.aspx");
        }
        //Ali For Chat System ---------------------------------------------------End

        Response.Redirect("Home.aspx");
    }
}
