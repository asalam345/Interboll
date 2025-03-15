using System.Web;
using System.Data;
using System.Linq;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services.Protocols;

/// <summary>
/// Summary description for Service_CS
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public partial class Service : System.Web.Services.WebService
{

    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string[] GetCustomers(string prefix) 
    {
        List<string> list = new List<string>();
        string conString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(conString))
        {
            using (SqlCommand cmd = new SqlCommand("spAutoCompleteTextBox", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchText", prefix);
                conn.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        list.Add(string.Format("{0}", sdr["getResult"]));
                    }
                }
                conn.Close();
            }
        }
        return list.ToArray();
    }
}