using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for BusinessPage
/// </summary>
public class ContentPage
{
    public ContentPage()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string InsertPage(string companyId, string menuTitle, string pageTitle, string keywords, string summary, string pageContent, string createdBy, 
            string pageThemeId, string status)
    {
        object ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dx_PageInsert",
            new SqlParameter("@companyId", companyId), 
            new SqlParameter("@menuTitle", menuTitle), 
            new SqlParameter("@pageTitle", pageTitle), 
            new SqlParameter("@keywords", keywords), 
            new SqlParameter("@summary", summary), 
            new SqlParameter("@pageContent", pageContent), 
            new SqlParameter("@createdBy", createdBy), 
            new SqlParameter("@pageThemeId", pageThemeId), 
            new SqlParameter("@status", status)
       );
        return Convert.ToString(ret);
    }

    public DataSet GetPage(string pageId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dx_PageSelect",
            new SqlParameter("@pageId", pageId)
            );
        return ds;
    }

    public DataSet ListPageForIndex(string companyId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dx_PageSelectAllForIndex",
            new SqlParameter("@companyId", companyId)
            );
        return ds;
    }


    public string DeletePage(string inquiryId)
    {
        object ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dx_InquiryDelete",
            new SqlParameter("@inquiryId", inquiryId)
       );
        return Convert.ToString(ret);
    }


    public string UpdatePage(string pageId, string companyId, string menuTitle, string pageTitle, string keywords, string summary, 
        string pageContent, string pageThemeId, string status)
    {
        object ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "dx_PageUpdate",
            new SqlParameter("@pageId", pageId),
            new SqlParameter("@companyId", companyId),
            new SqlParameter("@menuTitle", menuTitle),
            new SqlParameter("@pageTitle", pageTitle),
            new SqlParameter("@keywords", keywords),
            new SqlParameter("@summary", summary),
            new SqlParameter("@pageContent", pageContent),
            new SqlParameter("@pageThemeId", pageThemeId),
            new SqlParameter("@status", status)
       );
        return Convert.ToString(ret);
    }
}