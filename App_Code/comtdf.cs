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


/// <summary>
/// Summary description for comtdf
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class comtdf : System.Web.Services.WebService
{
    string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
    string CurrentUserId = System.Web.HttpContext.Current.Session["CurrentUserId"] != null ? System.Web.HttpContext.Current.Session["CurrentUserId"].ToString() : string.Empty;
    string setBlankImagePath = "USERPANEL/img/upload/blank_user.png";

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public bool DataInsertUser(string u_idTo, string message)
    {
        bool InsertData;
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spUser_Message_Insert_Check_Friend_ChatBoxOpen", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", u_idTo);
                cmd.Parameters.AddWithValue("@LName", message);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int Result = cmd.ExecuteNonQuery();
                if (Result > 0)
                {
                    InsertData = true;
                }
                else
                {
                    InsertData = false;
                }
                return InsertData;  
       
            }
        }
    }
    
}
