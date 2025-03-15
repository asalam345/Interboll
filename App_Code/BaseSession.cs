using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BaseSession
/// </summary>
public static class BaseSession
{
    public static string iUserId
    {
        get
        {
            DataSet ds = new DataSet();
             ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
          CommandType.StoredProcedure,
          "dae_ProfileSelect",
           new SqlParameter("@userName", HttpContext.Current.User.Identity.Name)
      );
            return Convert.ToString(ds.Tables[0].Rows[0]["iuserId"]);
        }
    }
}