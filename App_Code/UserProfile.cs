using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserProfile
/// </summary>
public static class UserProfile
{

    public static string iuserId
    {
        get
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                DataSet ds = SelectProfile(HttpContext.Current.User.Identity.Name);
                return ds.Tables[0].Rows[0]["iuserId"].ToString();
            }
            else
                return "";
        }
    }

    public static DataSet ListProfile()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_ProfileSelectAll"
            );
        return ds;
    }

    public static DataSet ListProfileForDealNotification()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "lts_ProfileSelectForDealNotification"
            );
        return ds;
    }

    public static void UpdateProfileLastEmailSent(string iuserId)
    {
        SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "lts_ProfileUpdateLastEmailSent",
            new SqlParameter("@iuserId", iuserId)
            );
    }

    public static DataSet SelectProfile(string email)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
               CommandType.StoredProcedure,
               "lts_ProfileSelect",
               new SqlParameter("@email", email)
               );
        return ds;
    }

    public static string InsertProfile(string userName, string title, string firstname, string lastname, string designation, string region, string district, string address, string contactno)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Oiio_ProfileInsert",
            new SqlParameter("@userName", userName),
            new SqlParameter("@title", title),
            new SqlParameter("@firstName", firstname),
            new SqlParameter("@lastName", lastname),
            new SqlParameter("@designationId", designation),
            new SqlParameter("@regionId", region),
            new SqlParameter("@districtId", district),
            new SqlParameter("@address", address),
            new SqlParameter("@contactno", contactno)
        );
        return Convert.ToString(ret);
    }
    public static DataSet SelectProfileAll()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_ProfileSelectAll");
        return ds;
    }

      public static DataSet SelectProfileAll_Data()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_ProfileSelectAll_data");
        return ds;
    }

      public static DataSet SelectDistrict()
      {
          DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "dae_DistrictSelect");
          return ds;
      }
    public static DataSet SelectProfileSummary(string accountId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "pal_ProfileSelectSummary",
       new SqlParameter("@accountId", accountId));
        return ds;
    }

    public static DataSet SelectRegion()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_RegionSelect");
        return ds;
    }

    public static DataSet SelectRegion1()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_RegionSelect_view_Page");
        return ds;
    }

    public static DataSet SelectDistrict(Int32 AreaSysID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_DistrictSelect",
         new SqlParameter("@AreaSysID", AreaSysID));
        return ds;
    }

    public static DataSet SelectDesignation()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_DesignationSelect");
        return ds;
    }

    public static string UpdateProfile(int iuserId, string firstname, string userName)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_ProfileUpdate_Data",
      
            new SqlParameter("@iuserId", iuserId),
            new SqlParameter("@firstName", firstname), 
             new SqlParameter("@userName", userName)       
                        
      
        );
        return Convert.ToString(ret12);
    }



    public static string Updateqa(int Id, string Q_Replay, Byte Q_status)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_qa_Update_Data",

            new SqlParameter("@Id", Id),
            new SqlParameter("@Q_Replay", Q_Replay),
             new SqlParameter("@Q_status", Q_status)


        );
        return Convert.ToString(ret12);
    }
    public static DataSet SelectQAAll_Data()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_QASelectAll");
        return ds;
    }

    //public static DataSet DeletetQ_Data(int qid)
    //{
    //    DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
    //        CommandType.StoredProcedure,
    //        "dae_qaDelete",
    //        new SqlParameter("@qid", qid);
         
    //    return ds;
    //}

    public static void DeletetQ_Data(int qid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_qaDelete",
            new SqlParameter("@qid", qid)
            );
      
    }

    public static DataSet SelectSubDistrict(Int32 DistrictSysID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[dae_Sub_DistrictSelect]",
         new SqlParameter("@DistrictSysID", DistrictSysID));
        return ds;
    }

    public static DataSet SelectDistrict_Home(Int32 AreaSysID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_DistrictSelect_home",
         new SqlParameter("@AreaSysID", AreaSysID));
        return ds;
    }


    public static DataSet SelectKrishi_Home(Int32 AreaSysID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_Krishi_Name_home",
         new SqlParameter("@Krishi_Id", AreaSysID));
        return ds;
    }


    public static DataSet SelectKreshi()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dae_KreshiSelect");
        return ds;
    }

    public static DataSet SelectAuthor()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Author_Select");
        return ds;
    }


    public static DataSet SelecMenue()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Menu");
        return ds;
    }

    public static DataSet Get_Load_Menue(Byte M_Category_Id)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[sp_get_Submenue]",
            new SqlParameter("@P_Id", M_Category_Id)
            );
        return ds;
    }

}