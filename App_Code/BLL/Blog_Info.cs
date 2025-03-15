using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections;


namespace BLL
{
    /// <summary>
    /// Summary description for Blog_Info
    /// </summary>
    public class Blog_Info : DAL.BaseClass
    {
        public Blog_Info()
            : base(ConfigurationManager.AppSettings["Cnn"])
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataTable InsertBlog_User(string U_Name, string U_Email, string U_Address, string U_Cell_No,
            Int32 U_Type, string LogInID, string LogIn_Password, DateTime Make_Date,Byte U_status )
        {
            ArrayList arrParam = new ArrayList();
            arrParam.Add(new SqlParameter("@U_Name", U_Name));      
            arrParam.Add(new SqlParameter("@U_Email", U_Email));
            arrParam.Add(new SqlParameter("@U_Address", U_Address));
            arrParam.Add(new SqlParameter("@U_Cell_No", U_Cell_No));
            arrParam.Add(new SqlParameter("@U_Type", U_Type));
            arrParam.Add(new SqlParameter("@LogInID", LogInID));
            arrParam.Add(new SqlParameter("@LogIn_Password", LogIn_Password));
            arrParam.Add(new SqlParameter("@Make_Date", Make_Date));
            arrParam.Add(new SqlParameter("@u_Status", U_status));


            return this.ExecuteStoredProcedureDataTable("tbl_Blog_User_Insert", arrParam);
        }

        public object UpdatetBlog_User(string U_ID, string U_Name, string U_Email, string U_Address, string U_Cell_No,
          Int32 U_Type, string LogInID, string LogIn_Password, DateTime Make_Date)
        {
            ArrayList arrParam = new ArrayList();
            arrParam.Add(new SqlParameter("@U_ID", U_ID));
            arrParam.Add(new SqlParameter("@U_Name", U_Name));          
            arrParam.Add(new SqlParameter("@U_Email", U_Email));
            arrParam.Add(new SqlParameter("@U_Address", U_Address));
            arrParam.Add(new SqlParameter("@U_Cell_No", U_Cell_No));
            arrParam.Add(new SqlParameter("@U_Type", U_Type));
            arrParam.Add(new SqlParameter("@LogInID", LogInID));
            arrParam.Add(new SqlParameter("@LogIn_Password", LogIn_Password));
            arrParam.Add(new SqlParameter("@Make_Date", Make_Date));           
            return this.ExecuteStoredProcedureScalar("tbl_Blog_User_Update", arrParam);
        }
        public DataTable GetBlog_User(String ID)
        {
            ArrayList arrParam = new ArrayList();
            arrParam.Add(new SqlParameter("@U_ID", ID));
            return this.ExecuteStoredProcedureDataTable("Sp_Select_tbl_Blog_User ", arrParam);
        }

        public DataTable Get_user_name(String User)
        {
            ArrayList arrParam = new ArrayList();
            arrParam.Add(new SqlParameter("@U_Name", User));
            return this.ExecuteStoredProcedureDataTable("Sp_select_varify_user  ", arrParam);
        }

        //public string InsertBlog(string iuserId, string blogTitle, string blogDescription, int published, String Image_Name, String Image_Path, string caption1, String Image_Name1, String Image_Path1, string caption2, String Image_Name2, String Image_Path2, string caption3)
        //{
        //    object ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
        //        CommandType.StoredProcedure,
        //        "dae_BlogInsert",
        //        new SqlParameter("@iuserId", iuserId),
        //        new SqlParameter("@blogTitle", blogTitle),
        //        new SqlParameter("@blogDescription", blogDescription),
        //        new SqlParameter("@publishStatus", published),
        //         new SqlParameter("@Image_Name", Image_Name),
        //          new SqlParameter("@Image_Path", Image_Path),
        //          new SqlParameter("@Caption1", caption1),
        //        //
        //        new SqlParameter("@Image_Name_2", Image_Name1),
        //          new SqlParameter("@Image_Path_2", Image_Path1),
        //          new SqlParameter("@Caption_2", caption2),
        //        //
        //          new SqlParameter("@Image_Name_3", Image_Name2),
        //          new SqlParameter("@Image_Path_3", Image_Path2),
        //          new SqlParameter("@Caption_3", caption3)
        //    );
        //    return Convert.ToString(ret);
        //}

        public DataTable InsertBlog(string iuserId, string blogTitle, string blogDescription, int published, String Image_Name, String Image_Path, string caption1, String Image_Name1,
            String Image_Path1, string caption2, String Image_Name2, String Image_Path2, string caption3)
        {
            ArrayList arrParam = new ArrayList();
            arrParam.Add(new SqlParameter("@iuserId", iuserId));
            arrParam.Add(new SqlParameter("@blogTitle", blogTitle));
            arrParam.Add(new SqlParameter("@blogDescription", blogDescription));
            arrParam.Add(new SqlParameter("@published", published));
            arrParam.Add(new SqlParameter("@Image_Name", Image_Name));
            arrParam.Add(new SqlParameter("@Image_Path", Image_Path));
            arrParam.Add(new SqlParameter("@caption1", caption1));
            arrParam.Add(new SqlParameter("@Image_Name1", Image_Name1));
            arrParam.Add(new SqlParameter("@Image_Path2", Image_Path2));
            arrParam.Add(new SqlParameter("@caption3", caption3));


            return this.ExecuteStoredProcedureDataTable("tbl_Oiio_blog_Insert", arrParam);
        }


        public DataTable UpdateBlog(string blogId, string updatedBy, string blogTitle, string blogDescription, int published, String Image_Name, 
            String Image_Path, string caption1,  String Image_Name2, String Image_Path2, string caption2,String Image_Name3, String Image_Path3, string caption3)
        {
            ArrayList arrParam = new ArrayList();
            arrParam.Add(new SqlParameter("@blogId", blogId));
            arrParam.Add(new SqlParameter("@updatedBy", updatedBy));
            arrParam.Add(new SqlParameter("@blogTitle", blogTitle));
            arrParam.Add(new SqlParameter("@blogDescription", blogDescription));
            arrParam.Add(new SqlParameter("@published", published));
            arrParam.Add(new SqlParameter("@Image_Name", Image_Name));
            arrParam.Add(new SqlParameter("@Image_Path", Image_Path));
            arrParam.Add(new SqlParameter("@caption1", caption1));
            arrParam.Add(new SqlParameter("@Image_Name2", Image_Name2));
            arrParam.Add(new SqlParameter("@Image_Path2", Image_Path2));
            arrParam.Add(new SqlParameter("@caption2", caption2));
            arrParam.Add(new SqlParameter("@Image_Name3", Image_Name3));
            arrParam.Add(new SqlParameter("@Image_Path3", Image_Path3));            ;
            arrParam.Add(new SqlParameter("@caption3", caption3));


            return this.ExecuteStoredProcedureDataTable("tbl_Oiio_blog_Update", arrParam);
        }
    }
}