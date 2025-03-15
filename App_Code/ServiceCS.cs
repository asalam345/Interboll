using System;
using System.Web;
using System.Data;
using System.Linq;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services.Protocols;
using System.Text;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for ServiceCS
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class ServiceCS : System.Web.Services.WebService
{
    string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
   // string CurrentUserId = System.Web.HttpContext.Current.Session["userid"] != null ? System.Web.HttpContext.Current.Session["userid"].ToString() : string.Empty;
    string setBlankImagePath = "USERPANEL/img/upload/blank_user.png";
    string InsertData;
    public ServiceCS()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetDetails(string name, String myvalue1, String name1)
    {
        DateTime Postdate = DateTime.Now;
      //  string userid = Session["userid"].ToString();
        string articleId1 = ClPost.Insert_tbl_Post_Comment(Convert.ToInt32(myvalue1), Convert.ToInt32(name1), name, Postdate, "", 1);
      //  return string.Format("Name: {0}{2}Age: {1}{2}TimeStamp: {3}", name, myvalue1, Environment.NewLine, DateTime.Now.ToString());

        return InsertData;
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<CommentAjax> CommentRefresh(int id)
    {
        //Repeater dlPostImage = (Repeater)e.Item.FindControl("dlcomment");
        //dlPostImage.Visible = true;
        DataSet dataSet = ClPost.List_of_Post_Wise_Comment(id);
        DataTable table = dataSet.Tables[0];

        List<CommentAjax> commentList = new List<CommentAjax>();
        CommentAjax comment = new CommentAjax();
        for(int i = 0; i < table.Rows.Count; i++)
        {
            comment = new CommentAjax();
            int intaaa = table.Rows.Count;
            comment.Comment = table.Rows[i]["P_Comment"].ToString();
            comment.PostId = Convert.ToInt32(table.Rows[i]["Post_Id"]);
            //comment.Id = Convert.ToInt32(table.Rows[i]["P_Id"]);
            comment.Commenter = table.Rows[i]["First_Name"].ToString();
            comment.Picture = table.Rows[i]["Profile_Image"].ToString();
            comment.Date = table.Rows[i]["P_Date"].ToString();

            commentList.Add(comment);
        }

        return commentList;
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
    public string DeleteComment(int PostId, string userid)
    {
        ClPost.Delete_Post_Comment(PostId, Convert.ToInt32(userid));
        return "ok";
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string Like(int PostId, string userid)
    {
        DataSet ds = ClPost.Get_Check_Like_clik(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);
            Byte Likeid1 = 1;
            if (Likeid == 0)
            {
                Likeid1 = 1;
                ClPost.Updade_tbl_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
                return "Liked";

            }

            else //if (Likeid == 1)
            {
                Likeid1 = 0;
                ClPost.Updade_tbl_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
                return "Like";
            }
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            return "Liked";
        }


      
    }


    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string share(int PostId, string userid)
    {
        DataSet ds = ClPost.Get_Check_Share(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Share_Type"]);
            Byte Likeid1 = 1;
            if (Likeid == 0)
            {
                Likeid1 = 1;
                ClPost.Updade_tbl_Share(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
                return "Shared";

            }

            else //if (Likeid == 1)
            {
                Likeid1 = 0;
                ClPost.Updade_tbl_Share(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
                return "Share";
            }
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_Share(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            return "Shared";
        }



    }

}

public class CommentAjax
{
    public int Id { set; get; }
    public string Comment { set; get; }
    public string Date { set; get; }
    public string Commenter { set; get; }
    public string Picture { set; get; }
    public int PostId { set; get; }
}
