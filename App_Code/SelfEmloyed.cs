using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SelfEmloyed
/// </summary>
public class SelfEmloyed
{

    //jan 25 jan Self Employment


    public static string Insert_tbl_Entrepreneur(String P_Name, String P_Description, String C_Description, Byte Country_Id, Byte City_Id, String P_Address, String P_Email, String P_Contactl, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
        String Filename6, Byte A_User_Id, Byte E_Status, String Remarks)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sptbl_Entrepreneur_Insert",
                new SqlParameter("@P_Name", P_Name),
                new SqlParameter("@P_Description", P_Description),
                new SqlParameter("@C_Description", C_Description),
                new SqlParameter("@City_id", City_Id),
                new SqlParameter("@P_Address", P_Address),
                new SqlParameter("@P_Email", P_Email),
                new SqlParameter("@P_Contactl", P_Contactl),
                 new SqlParameter("@Country_Id", Country_Id),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Image_Path", path),
                new SqlParameter("@Image_Path2", Filename2),
                new SqlParameter("@Image_Path3", Filename3),
                new SqlParameter("@Image_Path4", Filename4),
                new SqlParameter("@Image_Path5", Filename5),
                new SqlParameter("@Image_Path6", Filename6),
                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@E_Status", E_Status),
                new SqlParameter("@Remarks", Remarks)

                          );

        return Convert.ToString(ret);


    }



    public static void Update_tbl_Entrepreneur(string P_Id, String P_Name, String P_Description, String C_Description, Byte Country_Id, Byte City_Id, String P_Address, String P_Email, String P_Contactl, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
        String Filename6, Byte A_User_Id, Byte E_Status, String Remarks)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Entrepreneur_Update",
                new SqlParameter("@P_Id", P_Id),
                new SqlParameter("@P_Name", P_Name),
                new SqlParameter("@P_Description", P_Description),
                new SqlParameter("@C_Description", C_Description),
                new SqlParameter("@City_id", City_Id),
                  new SqlParameter("@Country_Id", Country_Id),
                new SqlParameter("@P_Address", P_Address),
                new SqlParameter("@P_Email", P_Email),
                new SqlParameter("@P_Contactl", P_Contactl),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Image_Path", path),
                new SqlParameter("@Image_Path2", Filename2),
                new SqlParameter("@Image_Path3", Filename3),
                new SqlParameter("@Image_Path4", Filename4),
                new SqlParameter("@Image_Path5", Filename5),
                new SqlParameter("@Image_Path6", Filename6),
                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@E_Status", E_Status),
                new SqlParameter("@Remarks", Remarks)



       );

    }

    public static DataSet Get_Country_All()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Country_Select"

            );
        return ds;
    }

    public static DataSet Get_Country_Wise_City(Int16 coun_id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_City_Country_Wise",
            new SqlParameter("@coun_id", coun_id)
            );
        return ds;
    }


    public static DataSet Get_Entrepreneur_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Entrepreneur_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet List_of_Entrepreneur()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Entrepreneur_List"


            );
        return ds;
    }

    public static DataSet Get_Load_City()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_City"

            );
        return ds;
    }

    public static string Insert_tbl_Job(Byte Job_Category_Id, Byte Job_Sub_Category_Id, Byte Entrepreneur_Id, String Job_Post_Name, string Filename, string path, String Job_SL_Number, Decimal Salary_Range_From, Decimal Salary_Range_To, Byte Job_Type,
        Byte Vacancy, String WHO_MAY_APPLY, String Job_Summary, String DUTIES, String QUALIFICATIONS, String BENEFITS_Others, String Job_Location, Byte Country_id, Byte City_id, Decimal Change_S_Range_From, Decimal Change_S_Range_To, Byte Currency_Id, String Currency,
        String Change_Currency, DateTime Job_Apply_Date, DateTime Job_End_Date,DateTime Post_Date, Byte A_User_Id, String Job_Post_By, Byte P_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Job_Item_Insert",
               new SqlParameter("@Job_Category_Id", Job_Category_Id),
               new SqlParameter("@Job_Sub_Category_Id", Job_Sub_Category_Id),
               new SqlParameter("@Entrepreneur_Id", Entrepreneur_Id),
               new SqlParameter("@Job_Post_Name", Job_Post_Name),
               new SqlParameter("@Job_SL_Number", Job_SL_Number),
               new SqlParameter("@Image_Name", Filename),
               new SqlParameter("@Image_Path", path),
               new SqlParameter("@Salary_Range_From", Salary_Range_From),
               new SqlParameter("@Salary_Range_To", Salary_Range_To),
               new SqlParameter("@Job_Type", Job_Type),
               new SqlParameter("@Vacancy", Vacancy),
               new SqlParameter("@WHO_MAY_APPLY", WHO_MAY_APPLY),
               new SqlParameter("@Job_Summary", Job_Summary),
               new SqlParameter("@DUTIES", DUTIES),
               new SqlParameter("@QUALIFICATIONS", QUALIFICATIONS),
                new SqlParameter("@BENEFITS_Others", BENEFITS_Others),
               new SqlParameter("@Job_Location", Job_Location),
               new SqlParameter("@Country_id", Country_id),
               new SqlParameter("@City_id", City_id),
               new SqlParameter("@Change_S_Range_From", Change_S_Range_From),
               new SqlParameter("@Change_S_Range_To", Change_S_Range_To),
               new SqlParameter("@Currency_Id", Currency_Id),
               new SqlParameter("@Currency", Currency),
               new SqlParameter("@Change_Currency", Change_Currency),        
               new SqlParameter("@Job_Apply_Date", Job_Apply_Date),
               new SqlParameter("@Job_End_Date", Job_End_Date),
                  new SqlParameter("@Post_Date", Post_Date),
                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@Job_Post_By", Job_Post_By),
                new SqlParameter("@P_Status", P_Status)

                 );


        return Convert.ToString(ret);
    }


    public static void Update_tbl_Job(string P_Id, Byte Job_Category_Id, Byte Job_Sub_Category_Id, Byte Entrepreneur_Id, String Job_Post_Name, string Filename, string path, String Job_SL_Number, Decimal Salary_Range_From, Decimal Salary_Range_To, Byte Job_Type,
        Byte Vacancy, String WHO_MAY_APPLY, String Job_Summary, String DUTIES, String QUALIFICATIONS, String BENEFITS_Others, String Job_Location, Byte Country_id, Byte City_id, Decimal Change_S_Range_From, Decimal Change_S_Range_To, Byte Currency_Id, String Currency,
        String Change_Currency, DateTime Job_Apply_Date, DateTime Job_End_Date, DateTime Post_Date, Byte A_User_Id, String Job_Post_By, Byte P_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Job_Item_Update",
              new SqlParameter("@P_Id", P_Id),
               new SqlParameter("@Job_Category_Id", Job_Category_Id),
               new SqlParameter("@Job_Sub_Category_Id", Job_Sub_Category_Id),
               new SqlParameter("@Entrepreneur_Id", Entrepreneur_Id),
               new SqlParameter("@Job_Post_Name", Job_Post_Name),
              new SqlParameter("@Image_Name", Filename),
               new SqlParameter("@Image_Path", path),
               new SqlParameter("@Job_SL_Number", Job_SL_Number),
               new SqlParameter("@Salary_Range_From", Salary_Range_From),
               new SqlParameter("@Salary_Range_To", Salary_Range_To),
               new SqlParameter("@Job_Type", Job_Type),
               new SqlParameter("@Vacancy", Vacancy),
               new SqlParameter("@WHO_MAY_APPLY", WHO_MAY_APPLY),
               new SqlParameter("@Job_Summary", Job_Summary),
               new SqlParameter("@DUTIES", DUTIES),
               new SqlParameter("@QUALIFICATIONS", QUALIFICATIONS),
                  new SqlParameter("@BENEFITS_Others", BENEFITS_Others),

               new SqlParameter("@Job_Location", Job_Location),
               new SqlParameter("@Country_id", Country_id),
               new SqlParameter("@City_id", City_id),
               new SqlParameter("@Change_S_Range_From", Change_S_Range_From),
               new SqlParameter("@Change_S_Range_To", Change_S_Range_To),
               new SqlParameter("@Currency_Id", Currency_Id),
               new SqlParameter("@Currency", Currency),
               new SqlParameter("@Change_Currency", Change_Currency),

               new SqlParameter("@Job_Apply_Date", Job_Apply_Date),
               new SqlParameter("@Job_End_Date", Job_End_Date),
                 new SqlParameter("@Post_Date", Post_Date),
                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@Job_Post_By", Job_Post_By),
                new SqlParameter("@P_Status", P_Status)
       );

    }

    public static DataSet Get_Weeding_Job_Category()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Weeding_Job_Category"

            );
        return ds;
    }

    public static DataSet Get_Category_Wise_subcat(Int16 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Subcategory_w_Category_wise",
            new SqlParameter("@CategoryID", CategoryID)
            );
        return ds;
    }

    public static DataSet Get_Load_Entrepreneur()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Entrepreneur"

            );
        return ds;
    }

    public static DataSet Get_Jobs_Id_Wise(string A_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Jobs_Id_Wise",
            new SqlParameter("@P_Id", A_Id)
            );
        return ds;
    }

    public static DataSet List_of_Job()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Job_List"


            );
        return ds;
    }

    public static DataSet Get_Wed_subcat_All()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Subcategory_wedding-All"
           
            );
        return ds;
    }


    public static void Update_tbl_Employers(string P_Id, String P_Name, DateTime DOB, String P_Description, String Present_Working_Status, String Past_Experiance, String QUALIFICATIONS, Byte Country_Id, Byte City_Id, String P_Address, String P_Email, String P_Contactl, string Filename, string path, Byte A_User_Id, Byte E_Status, String Remarks)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Employer_Update",
                new SqlParameter("@P_Id", P_Id),           
                 new SqlParameter("@P_Name", P_Name),
                      new SqlParameter("@DOB", DOB),
                new SqlParameter("@P_Description", P_Description),
                new SqlParameter("@Present_Working_Status", Present_Working_Status),

                  new SqlParameter("@Past_Experiance", Past_Experiance),
                    new SqlParameter("@QUALIFICATIONS", QUALIFICATIONS),

                new SqlParameter("@City_id", City_Id),
                new SqlParameter("@P_Address", P_Address),
                new SqlParameter("@P_Email", P_Email),
                new SqlParameter("@P_Contactl", P_Contactl),
                 new SqlParameter("@Country_Id", Country_Id),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Image_Path", path),

                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@E_Status", E_Status),
                new SqlParameter("@Remarks", Remarks)



       );

    }

    public static string Insert_tbl_Employers(String P_Name, DateTime DOB, String P_Description, String Present_Working_Status, String Past_Experiance, String QUALIFICATIONS, Byte Country_Id, Byte City_Id, String P_Address, String P_Email, String P_Contactl, string Filename, string path, Byte A_User_Id, Byte E_Status, String Remarks)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Employeer_Insert",
                new SqlParameter("@P_Name", P_Name),
                    new SqlParameter("@DOB", DOB),
                new SqlParameter("@P_Description", P_Description),
                new SqlParameter("@Present_Working_Status", Present_Working_Status),

                  new SqlParameter("@Past_Experiance", Past_Experiance),
                    new SqlParameter("@QUALIFICATIONS", QUALIFICATIONS),

                new SqlParameter("@City_id", City_Id),
                new SqlParameter("@P_Address", P_Address),
                new SqlParameter("@P_Email", P_Email),
                new SqlParameter("@P_Contactl", P_Contactl),
                 new SqlParameter("@Country_Id", Country_Id),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Image_Path", path),

                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@E_Status", E_Status),
                new SqlParameter("@Remarks", Remarks)

                          );

        return Convert.ToString(ret);


    }

    //27 jan 2016

    public static DataSet Get_Employee_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employee_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet List_of_Employee()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employee_List"


            );
        return ds;
    }

    public static DataSet Get_Job_List()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_job_List"

            );
        return ds;
    }

    public static DataSet Get_Employee_List()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Employee_List"

            );
        return ds;
    }

    public static DataSet List_of_Employess_Project_Id_wise(string V_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employee_Project_Id_Wise",
            new SqlParameter("@P_Id", V_Id)
            );
        return ds;
    }


    public static string Insert_tbl_Employee_Project(Byte Employer_Id, String Project_Name, String Project_Description, string Filename, Int32 Job_Category_Id, DateTime P_Start_Date, DateTime P_End_Date)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Employee_Project_Insert",
                new SqlParameter("@Employer_Id", Employer_Id),
                 new SqlParameter("@Project_Name", Project_Name),
                new SqlParameter("@Project_Description", Project_Description),
                new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Job_Category_Id", Job_Category_Id),
               new SqlParameter("@P_Start_Date", P_Start_Date),
               new SqlParameter("@P_End_Date", P_End_Date)
 
                 );


        return Convert.ToString(ret);
    }

    public static void Update_tbl_Employee_Project(string P_Detail_Id, Byte Employer_Id, String Project_Name, String Project_Description, string Filename, Int32 Job_Category_Id, DateTime P_Start_Date, DateTime P_End_Date)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Employee_Project_Update",
                new SqlParameter("@P_Detail_Id", P_Detail_Id),
                 new SqlParameter("@Employer_Id", Employer_Id),
                 new SqlParameter("@Project_Name", Project_Name),
                new SqlParameter("@Project_Description", Project_Description),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Job_Category_Id", Job_Category_Id),
               new SqlParameter("@P_Start_Date", P_Start_Date),
               new SqlParameter("@P_End_Date", P_End_Date)
       );

    }


    public static DataSet Get_Employee_Project_Id_Wise(string F_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Employee_ProjectId_Wise",
            new SqlParameter("@P_Id", F_Id)
            );
        return ds;
    }

    public static DataSet Get_Emp_Profile_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Employee_List_Emp_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet List_of_Employe_Project_Id_wise(string V_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employer_Project",
            new SqlParameter("@V_Id", V_Id)
            );
        return ds;
    }


    public static DataSet Get_User_data(string LoginName)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
            "Sp_Get_User_Data",
            new SqlParameter("@LoginName", LoginName)
         
            );
        return ds;
    }

    public static DataSet Get_Employee_user_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employee_UserId_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static string Insert_Job_Detail(Int32 Job_Id, Int32 A_User_Id, Int32 Job_Category_Id, DateTime Post_Date)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_JobDetail_Insert",
            new SqlParameter("@Job_Id", Job_Id),
            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Job_Category_Id", Job_Category_Id),
            new SqlParameter("@Post_Date", Post_Date)

       );
        return Convert.ToString(ret);
    }


    public static DataSet Get_User_data_Job(Int32 Job_Id, Int32 A_User_Id)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
            "Sp_Get_User_Data_Job",
            new SqlParameter("@Job_Id", Job_Id),
             new SqlParameter("@A_User_Id", A_User_Id)

            );
        return ds;
    }


    public static DataSet Get_Entrepreneur_User_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Entrepreneur_User_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet Get_Job_List_Ent_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_job_List_En_Id_Wise",
              new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet List_of_Employe_Applying_Job(string User_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employee_Apply_Job",
            new SqlParameter("@V_Id", User_Id)
            );
        return ds;
    }


    //public static DataSet Get_Employee_User_Id_Wise(string P_Id)
    //{
    //    DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
    //        CommandType.StoredProcedure,
    //        "sp_tbl_Employee_Id_Wise",
    //        new SqlParameter("@P_Id", P_Id)
    //        );
    //    return ds;
    //}


    public static DataSet List_of_Employe_Applying_Job_List(string User_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Employee_Applying_List_Job",
            new SqlParameter("@Job_Id", User_Id)
            );
        return ds;
    }

    public static DataSet Get_Jobs_Id_IID_Wise(string A_Id, string A_User_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Jobs_Id_IID_Wise",
            new SqlParameter("@P_Id", A_Id),
              new SqlParameter("@A_User_Id", A_User_Id)
            );
        return ds;
    }

   

}