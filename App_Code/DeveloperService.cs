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
using Newtonsoft.Json;
using Newtonsoft;
//using System.Web.Http.Cors;
/// <summary>
/// Summary description for ServiceCS
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]



[System.ComponentModel.ToolboxItem(false)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
public class DeveloperService : System.Web.Services.WebService
{
    string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
    // string CurrentUserId = System.Web.HttpContext.Current.Session["userid"] != null ? System.Web.HttpContext.Current.Session["userid"].ToString() : string.Empty;
    //string setBlankImagePath = "USERPANEL/img/upload/blank_user.png";
    //string InsertData;
    public bool IsMatch(string url, string charecter)
    {
        int domain = Articles.MatchDomainSecret(url, charecter).Tables[0].Rows.Count;
        if (domain > 0)
        {
            return true;
        }
        return false;
    }

    public long GetDomainId(string url, string charecter)
    {
        DataSet ds = Articles.MatchDomainSecret(url, charecter);
        DataTable dt = ds.Tables[0];
        long id = 0;
        if (dt.Rows.Count > 0)
        {
            id = Convert.ToInt64(dt.Rows[0][0]);
        }
        return id;
    }

    //public bool SignIn(string email, string password)
    //{
    //    tbUser user = db.User.Where(w => w.Email == email && w.Password == password).FirstOrDefault();
    //    if (user != null)
    //    {
    //        Session["UserId"] = user.Id;
    //        return true;
    //    }

    //    return false;
    //}
    public bool IsUserAgreeToShowProfile(long userId, long domainId)
    {
        DataSet ds = Articles.IsUserAgreeToShowProfile(userId, domainId);
        DataTable dt = ds.Tables[0];

        if (dt.Rows.Count > 0)
        {
            return true;
        }
        return false;
    }


    public UserProfileIsShow UserAgreeToShowProfile(long userId)
    {
        DataSet ds = Articles.UserProfile(userId);
        DataTable dt = ds.Tables[0];

        UserProfileIsShow profile = new UserProfileIsShow();

        profile.Result = true;
        profile.Email = dt.Rows[0]["LoginName"].ToString();
        profile.FName = dt.Rows[0]["First_Name"].ToString();
        profile.LName = dt.Rows[0]["Last_Name"].ToString();
        profile.Picture = dt.Rows[0]["Profile_Image"].ToString();
        profile.Gender = dt.Rows[0]["U_Gender"].ToString();
        return profile;
    }

    public DeveloperService()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //[WebMethod]
    //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    //public string GetDetails(string name, String myvalue1, String name1)
    //{
    //    DateTime Postdate = DateTime.Now;
    //    //  string userid = Session["userid"].ToString();
    //    string articleId1 = ClPost.Insert_tbl_Post_Comment(Convert.ToInt32(myvalue1), Convert.ToInt32(name1), name, Postdate, "", 1);
    //    //  return string.Format("Name: {0}{2}Age: {1}{2}TimeStamp: {3}", name, myvalue1, Environment.NewLine, DateTime.Now.ToString());

    //    return InsertData;
    //}

   // [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    [WebMethod(EnableSession = true,Description = "return pure JSON")]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string SigninByInterboll(string sk)
    {
        //string strUrl = "http://www.oiiorecipe.com/";
        //string strUrl = HttpContext.Current.Request.Url.AbsoluteUri.ToString();
        string strPathAndQuery = HttpContext.Current.Request.UrlReferrer.PathAndQuery;
        string strUrl = HttpContext.Current.Request.UrlReferrer.AbsoluteUri.Replace(strPathAndQuery, "/");
        //HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*");
        ////HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "http://localhost:31930/DeveloperService.asmx/SigninByInterboll");
        //HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Headers", "X-Custom-Header");
        //HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Methods", "PUT");
        //HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Credentials", "true");
        if (IsMatch(strUrl, sk))
        {
            long dId = GetDomainId(strUrl, sk);
            if (HttpContext.Current.Session["CurrentUserEmail"] == null && HttpContext.Current.Session["CurrentUserId"] == null)
            {
                long uId = Convert.ToInt64(Session["CurrentUserId"]);

                bool flag = IsUserAgreeToShowProfile(dId, uId);
                if (flag)
                {
                    UserProfileIsShow profile = UserAgreeToShowProfile(uId);
                    //List<UserProfileIsShow> profile = new List<UserProfileIsShow>();
                    string json = JsonConvert.SerializeObject(profile, Formatting.Indented);
                    //return profile;
                    return json;
                }
                else
                {
                    string result = strUrl + " wants your email and public profile.";
                    UserProfileIsShow profile = new UserProfileIsShow();
                    profile.Result = false;
                    profile.Message = result;
                    profile.Condition = 2;
                    //return profile;
                    string json = JsonConvert.SerializeObject(profile, Formatting.Indented);
                    return json;
                }
            }
            else
            {

                //HttpContext.Current.Response.Redirect("~/Home.aspx",);
                //HttpContext.Current.Response.Write("<script>window.open ('Home.aspx','_blank');</script>");
                UserProfileIsShow profile = new UserProfileIsShow();
                profile.Result = false;
                profile.Message = "Home.aspx";
                profile.Condition = 2;
                //return profile;
                string json = JsonConvert.SerializeObject(profile, Formatting.Indented);
                return json;
            }
        }
        else
        {
            //HttpContext.Current.Response.Redirect("~/Developer/NotMatch.aspx");
            //HttpContext.Current.Response.Write("/Developer/NotMatch.aspx");
            UserProfileIsShow profile = new UserProfileIsShow();
            profile.Result = false;
            //profile.Message = "/Developer/NotMatch.aspx";
            profile.Message = strUrl;
            profile.Condition = 2;
            //return profile;
            string json = JsonConvert.SerializeObject(profile, Formatting.Indented);
            return json;
        }
        //return Json(null, JsonRequestBehavior.AllowGet);
    }
}

public class UserProfileIsShow
{
    public bool Result { set; get; }
    public string Message { set; get; }
    public int Condition { set; get; }
    public string Email { set; get; }
    public string FName { set; get; }
    public string LName { set; get; }
    public string Picture { set; get; }
    public string Gender { set; get; }
    public string RedirectLink { set; get; }
}