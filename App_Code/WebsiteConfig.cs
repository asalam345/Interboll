using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;


public static class WebsiteConfig
{
    #region Properties

    private static string _connectionString;
    public static string ConnectionString
    {
        get { return _connectionString; }
    }

    private static string _paypalEmail;
    public static string PaypalEmail
    {
        get { return _paypalEmail; }
    }

    private static string _adminEmail;
    public static string AdminEmail
    {
        get { return _adminEmail; }
    }

    private static string _noreplyEmail;
    public static string NoreplyEmail
    {
        get { return _noreplyEmail; }
    }

    private static string _mailTemplateFolder;
    public static string MailTemplateFolder
    {
        get { return _mailTemplateFolder; }
    }

    #endregion

    #region constructor
    static WebsiteConfig()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;

        _adminEmail = ConfigurationManager.AppSettings["AdminEmail"].ToString();

        _mailTemplateFolder = ConfigurationManager.AppSettings["MailTemplateFolder"].ToString();
        _noreplyEmail = ConfigurationManager.AppSettings["NoReplyEmail"].ToString();
    }
    #endregion

    public enum Application
    {
        ProjectManagementSystem = 1,
        FeedbackSystem = 2,
        eBaySellerHelper = 3
    }

    public enum AttachmentFor
    {
        General = 1,
        Task = 2,
        Discussion = 3
    }

    public static string UserFilesRootFolder
    {
        get
        {
            //D:/host/IDriveSync Explorer/uf/skydx/
            //D:/host/IDriveSync Explorer/uf/skydx/ fb/p1/1/
            //D:/host/IDriveSync Explorer/uf/skydx/ desk/p1/1/

            //return ConfigurationManager.AppSettings["UserFilesRootFolder"] + appName + "/p1/" + companyId + "/";
            return ConfigurationManager.AppSettings["UserFilesRootFolder"];
        }
    }
    
    public static string TempFolder
    {
        get
        {
            string path = System.IO.Path.Combine(WebsiteConfig.UserFilesRootFolder, @"temp\");
            return path;   //@"D:\Host\uf\skydx\cache\";
        }
    }

    public static string FilesFolder
    {
        get { return WebsiteConfig.UserFilesRootFolder + @"files\original\"; }  // view
    }
    public static string FilesFolderImg50
    {
        get { return WebsiteConfig.UserFilesRootFolder + @"files\img50\"; }  // mini
    }
    public static string FilesFolderImg100
    {
        get { return WebsiteConfig.UserFilesRootFolder + @"files\img100\"; }  // thumb
    }
    public static string FilesFolderImg200
    {
        get { return WebsiteConfig.UserFilesRootFolder + @"files\img200\"; } // med
    }
    public static string FilesFolderImg500
    {
        get { return WebsiteConfig.UserFilesRootFolder + @"files\img500\"; }  // five
    }

    public enum FolderNickname
    {
        mini,
        thumb,
        med,
        five,
        view
    }

    public static string GetFilesFolder(string folderNickname)
    {
        string folderPath = FilesFolder;

        if (folderNickname == FolderNickname.mini.ToString())
            folderPath = FilesFolderImg50;
        else if (folderNickname == FolderNickname.thumb.ToString())
            folderPath = WebsiteConfig.FilesFolderImg100;
        else if (folderNickname == FolderNickname.med.ToString())
            folderPath = WebsiteConfig.FilesFolderImg200;
        else if (folderNickname == FolderNickname.five.ToString())
            folderPath = WebsiteConfig.FilesFolderImg500;
        else if (folderNickname == FolderNickname.view.ToString())
            folderPath = WebsiteConfig.FilesFolder;

        return folderPath;
    }

    /// <summary>
    /// kept without last slash so will also work if returns empty string
    /// </summary>
    public static string httpsDomain
    {
        get
        {
            //return "https://www.skydx.com";
            return ConfigurationManager.AppSettings["httpsDomain"];
        }
    }
    public static string httpDomain
    {
        get
        {
            //return "http://www.skydx.com";
            return ConfigurationManager.AppSettings["httpDomain"];
        }
    }

    public static string SiteName
    {
        get
        {
            //return "skydx.com";
            return ConfigurationManager.AppSettings["SiteName"];
        }
    }

    public static bool IsLive
    {
        get
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["IsLive"]);
        }
    }

    public static string LoginPageUrl
    {
        get { return "/site/login"; }
    }

    /*
    public static string GlobalDateFormatAsp
    {
        get { return "dd/MMM/yyyy"; }
    }
    public static string GlobalDateTimeFormatAsp
    {
        get { return "dd/MMM/yyyy"; }
    }
    */


    /// <summary>
    /// this is for java script internal use
    /// </summary>
    public static string JSInputDateTimeFormat
    {
        get { return "dd, MMM yyyy hh:mm tt"; }
    }

    public static string ReferrerCode
    {
        get
        {
            if (HttpContext.Current.Request.Cookies["ReferrerCode"] != null)
            {
                HttpCookie oCookie = (HttpCookie)HttpContext.Current.Request.Cookies["ReferrerCode"];
                if (oCookie.Value.Length > 0)
                    return oCookie.Value;
                else
                    return "";
            }
            else
                return "";
        }
        set
        {
            HttpCookie oCookie = new HttpCookie("ReferrerCode");
            //Set Cookie to expire in 1 month
            oCookie.Expires = DateTime.Now.AddMonths(1);
            oCookie.Value = value;
            HttpContext.Current.Response.Cookies.Add(oCookie);
        }
    }


    public static void RedirectToMemberPage()
    {
        // redirect to appropriate page
        if (HttpContext.Current.User.IsInRole("Pal_Admin"))
            HttpContext.Current.Response.Redirect("~/dataentry/");
        else
            HttpContext.Current.Response.Redirect("~/member/company");
    }
}