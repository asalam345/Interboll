using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Knot
/// </summary>
public class ClPost
{


    public static DataSet Get_Load_M_subcategory(Byte M_Category_Id)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_M_Subcategory",
            new SqlParameter("@CategoryID", M_Category_Id)
            );
        return ds;
    }

    public static DataSet List_of_Post_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_lookup_Post_Type_List"


            );
        return ds;
    }


    public static DataSet Get_Knot_Item_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Knot_Item_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet Get_Sub_Category_Name_Wise(Byte P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_get_M_Subcategory_Name",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

   


    public static DataSet Get_M_Category()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_M_Category_Select"

            );
        return ds;
    }

    public static DataSet SelectSub_M_Category(Int32 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "LookUp_M_SubCategory_Category_Id_Wise",
         new SqlParameter("@CategoryID", CategoryID));
        return ds;
    }


    public static DataSet Get_Knot_Id_Wise_Detail(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Home_Id_Wise_Detail",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet Get_Knot_Wise_Detail(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Knot_Id_Wise_Detail",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet Get_Knot_Wise_Detail(Int32 P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Knot_Id_Wise_Detail",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet Load_Date()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Date"

            );
        return ds;
    }

    public static DataSet Load_Month()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Month"

            );
        return ds;
    }

    public static DataSet Load_Year()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Year"

            );
        return ds;
    }

    public static DataSet Load_Year1()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Year"

            );
        return ds;
    }

    public static DataSet check_Subcat(String Code, Int32 CategoryID, Int32 SubCategoryID, byte for_id)
    {
       

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
         "check_subcategory",
            new SqlParameter("@Code", Code),
           new SqlParameter("@CategoryID", CategoryID),
           new SqlParameter("@SubCategoryID", SubCategoryID),
           new SqlParameter("@for_id", for_id)
            );
        return ds;
    }


    public static DataSet Delete_Subcategory_data(String Code, Int32 CategoryID, Int32 SubCategoryID, Byte For_Id)
    {


        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
         "delete_subcategory",
            new SqlParameter("@Code", Code),
           new SqlParameter("@CategoryID", CategoryID),
           new SqlParameter("@SubCategoryID", SubCategoryID),
            new SqlParameter("@For_Id", For_Id)
            );
        return ds;
    }


    public static DataSet Selectget_partner_date(String Knot_Id, Byte CategoryID, Byte For_it)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "get_partner_date",
            new SqlParameter("@Knot_Id", Knot_Id),
           new SqlParameter("@CategoryID", CategoryID),
            new SqlParameter("@For_it", For_it)
            );
        return ds;
    }

   

    public static DataSet Get_Knot_User_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Knot_User_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static string Updade_Personal_Info1(string P_Id, Byte Hair_Color, Byte Eye_Color, Byte Height, Byte Body_Type, Byte Meritial_Status, Byte EduCation)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_Info1",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Hair_Color", Hair_Color),
            new SqlParameter("@Eye_Color ", Eye_Color),
            new SqlParameter("@Height", Height),
            new SqlParameter("@Body_Type", Body_Type),
            new SqlParameter("@Meritial_Status", Meritial_Status),
            new SqlParameter("@EduCation", EduCation)

        );
        return Convert.ToString(ret12);
    }


    public static string Updade_Personal_Info2(string P_Id, Byte No_Of_Children, Byte More_Kids, Byte Political_View, Byte Religious, Byte Salary_Range, Byte Occupation)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_Info2",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@No_Of_Children", No_Of_Children),
            new SqlParameter("@More_Kids ", More_Kids),
            new SqlParameter("@Political_View", Political_View),
            new SqlParameter("@Religious", Religious),
            new SqlParameter("@Salary_Range", Salary_Range),
            new SqlParameter("@Occupation", Occupation)

        );
        return Convert.ToString(ret12);
    }

    public static string Updade_Personal_Info3(string P_Id, Byte Smoke, Byte Drinks, Byte Exersize, Byte Origin)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_Info3",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Smoke", Smoke),
            new SqlParameter("@Drinks ", Drinks),
            new SqlParameter("@Exersize", Exersize),
            new SqlParameter("@Origin", Origin)
     

        );
        return Convert.ToString(ret12);
    }


   

    public static string Updade_Personal_Info5(string P_Id, String Rexently_Read, String Fav_Movie)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_Info5",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Rexently_Read", Rexently_Read),
            new SqlParameter("@Fav_Movie ", Fav_Movie)

        );
        return Convert.ToString(ret12);
    }

    public static string Updade_Personal_Info6(string P_Id,  String P_Intro)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_Info6",
            new SqlParameter("@P_Id ", P_Id),

            new SqlParameter("@P_Intro ", P_Intro)

        );
        return Convert.ToString(ret12);
    }

    public static string Updade_Personal_User_Id(string Email_Id, Byte A_User_Id)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_UId",
            new SqlParameter("@Email_Id", Email_Id),
            new SqlParameter("@A_User_Id", A_User_Id)
         

        );
        return Convert.ToString(ret12);
    }


    public static string Updade_Personal_Info7(string P_Id, String Image_Name)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Personal_Info7",
            new SqlParameter("@P_Id ", P_Id),

            new SqlParameter("@Image_Name ", Image_Name)

        );
        return Convert.ToString(ret12);
    }

    public static DataSet Selectget_partner_data_Profile_Page(String Knot_Id, Byte CategoryID, Byte For_it)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "get_partner_data_Profile_Page",
            new SqlParameter("@Knot_Id", Knot_Id),
           new SqlParameter("@CategoryID", CategoryID),
            new SqlParameter("@For_it", For_it)
            );
        return ds;
    }

    public static DataSet Get_Knot_Item_Id_Wise_Profile_Page(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Knot_Item_Id_Wise_Profile",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet Get_PartnerList_List(Byte PartnerId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Partner_List",
              new SqlParameter("@PartnerId", PartnerId)

            );
        return ds;
    }

    public static DataSet Get_PartnerList_List_Between_Age(Byte PartnerId, Int32 Agefrom, Int32 AgeTo)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Partner_List_Between_Age",
              new SqlParameter("@PartnerId", PartnerId),
                new SqlParameter("@Agefrom ", Agefrom),
                  new SqlParameter("@AgeTo", AgeTo)

            );
        return ds;
    }

    public static string Insert_Add_tbl_Knot_Image(String Knot_Id, String Image_Name, String Image_Path)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Knot_Image_Insert",
            new SqlParameter("@Knot_Id", Knot_Id),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@Image_Path", Image_Path)
           

       );
        return Convert.ToString(ret);
    }


    public static DataSet Get_Knot_Image(String Knot_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Knot_Image",
              new SqlParameter("@Knot_Id", Knot_Id)

            );
        return ds;
    }


    public static DataSet Get_Knot_Image_Id_Wise(string Image_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Knot_Image_Id_Wise",
            new SqlParameter("@Image_Id", Image_Id)
            );
        return ds;
    }

    public static string Updade_Knot_Image_Id_Wise(string Image_Id, String Image_Name, String Image_Path)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Knot_Update_Image",
            new SqlParameter("@Image_Id ", Image_Id),
            new SqlParameter("@Image_Name ", Image_Name),
            new SqlParameter("@Image_Path ", Image_Path)

        );
        return Convert.ToString(ret12);
    }


    public static DataSet Update_Nappies_Hit(String Nappies_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_Knots_Hit",
            new SqlParameter("@Nappies_Id", Nappies_Id)
            );
        return ds;
    }


    public static DataSet Get_Match_List_Between_Age(Byte PartnerId, Int32 Agefrom, Int32 AgeTo)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Partner_Match_Between_Age",
              new SqlParameter("@PartnerId", PartnerId),
                new SqlParameter("@Agefrom ", Agefrom),
                  new SqlParameter("@AgeTo", AgeTo)

            );
        return ds;
    }

    public static DataSet Get_Check_Like(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Like_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }


    //  08-02-16
   


    public static DataSet Get_Knot_Check_Like(string P_Id, string Partner_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Knot_Like_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@Partner_Id", Partner_Id)
            );
        return ds;
    }


    public static string Insert_Add_tbl_Knot_Like(String Knot_Id, Int32 Partner_Id, DateTime Post_Date)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Knot_Like_Insert",
            new SqlParameter("@Knot_Id", Knot_Id),
            new SqlParameter("@Partner_Id", Partner_Id),
           new SqlParameter("@Post_Date", Post_Date)


       );
        return Convert.ToString(ret);
    }

    public static DataSet Get_Like_P_Profile(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_P_Like_Profile",
              new SqlParameter("@PersonalId", PersonalId)
             

            );
        return ds;
    }


    public static DataSet Get_Favourite_P_Profile(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_P_Favourite_Profile",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }



    ///10 feb 2016
  

    public static DataSet Get_Like_sent_To_Partner(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Like_Partner_Profile",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }


    public static DataSet Get_Like_sent_To_Partner_List(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Like_Partner_Profile_Kist",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }



    public static DataSet Get_Like_Recive_fromPartner_List(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Like_From_Partner_Profile_Kist",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }



    public static DataSet Get_Fav_sent_To_Partner(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Fav_Partner_Profile",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }

    public static DataSet Get_Fav_Recive_fromPartner_List(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Fav_From_Partner_Profile_Kist",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }

    public static DataSet Get_Fav_sent_To_Partner_List(String PersonalId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Get_Fav_Partner_Profile_Kist",
              new SqlParameter("@PersonalId", PersonalId)


            );
        return ds;
    }

    public static DataSet Get_User_Data_User_Name_Wise(String U_Name)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_select_Data_User_Name_Wise",
              new SqlParameter("@U_Name", U_Name)


            );
        return ds;
    }

    public static DataSet List_of_Post(String Useid,Int32 CcountryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_All_User_Wise",
              new SqlParameter("@userid", Useid) ,
               new SqlParameter("@CcountryID", CcountryID)
            );
        return ds;
    }

    public static string Insert_Add_tbl_Like(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Like_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }


    public static string Updade_tbl_Like(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Like_Update",
         
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type)

        );
        return Convert.ToString(ret12);
    }


    public static DataSet Get_Check_UserPost(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_User_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }


    public static DataSet Get_Post_Post_Id_Wise(Int32 PostId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Id_Wise",
              new SqlParameter("@PostId", PostId)
            );
        return ds;
    }

    public static string Insert_Add_tbl_Post(String P_Name, String P_Description, Int32 Country_id, Int32 City_id, Int32 A_User_Id, Byte V_Status, DateTime P_Date, String P_Image, Byte P_Status, Byte F_Status, String checking, String E_Video)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Insert",
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Country_id", Country_id),
            new SqlParameter("@City_id", City_id),

            new SqlParameter("@A_User_Id", A_User_Id),
            new SqlParameter("@V_Status", V_Status),
            new SqlParameter("@P_Date", P_Date),
            new SqlParameter("@P_Image", P_Image) ,
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@F_Status", F_Status),
            new SqlParameter("@checking", checking),
            new SqlParameter("@E_Video", E_Video)

       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_Post(string P_Id, String P_Name, String P_Description, Int32 Country_id, Int32 City_id, Int32 A_User_Id, Byte V_Status, DateTime P_Date, String P_Image, Byte P_Status, Byte F_Status, String checking, String E_Video)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Post_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
           new SqlParameter("@Country_id", Country_id),
           new SqlParameter("@City_id", City_id),

           new SqlParameter("@A_User_Id", A_User_Id),
            new SqlParameter("@V_Status", V_Status),
           new SqlParameter("@P_Date", P_Date),
           new SqlParameter("@P_Image", P_Image) ,
             new SqlParameter("@P_Status", P_Status),
             new SqlParameter("@F_Status", F_Status) ,
               new SqlParameter("@checking", checking),
                  new SqlParameter("@E_Video", E_Video)
       );

    }
  /// <summary>
  /// After up
  /// </summary>
  /// <param name="PostId"></param>
  /// <returns></returns>
    public static DataSet Get_Max_P_Id_User_Wise(Int32 Userid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Id_A_User_Id_Wise",
              new SqlParameter("@Userid", Userid)
            );
        return ds;
    }

    public static string Insert_Post_Pic(Int32 Post_Id, Int32 A_User_Id, String Image_Name, String Image_Path)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Image_Insert",
            new SqlParameter("@Post_Id", Post_Id),
            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@Image_Path", Image_Path)


       );
        return Convert.ToString(ret);
    }
    public static DataSet Get_P_Id_User_Image(Int32 PostId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Id_A_Image",
              new SqlParameter("@PostId", PostId)
            );
        return ds;
    }


    public static DataSet Post_Wise_Image(Int32 PostId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Wise_Image",
              new SqlParameter("@PostId", PostId)
            );
        return ds;
    }

              //29 08 16
    public static DataSet Get_user_Id_Wise(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }


    public static void Update_Cover_Profile_Pic(string IID, String First_Name, String Profile_Image, String Cover_Image, Byte U_Gender, DateTime dob)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Cover_Image_Update",
            new SqlParameter("@IID", IID),
            new SqlParameter("@First_Name", First_Name),
            new SqlParameter("@Profile_Image", Profile_Image),
              new SqlParameter("@U_Gender", U_Gender),
              new SqlParameter("@dob", dob),
           new SqlParameter("@Cover_Image", Cover_Image)
       );

    }


    public static DataSet Load_Maretial_Status()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_M_Status"

            );
        return ds;
    }


    public static DataSet Load_Countrys()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Country"

            );
        return ds;
    }


    public static DataSet Load_Occupation()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Occupation"

            );
        return ds;
    }

    public static DataSet Load_Religious()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Religious"

            );
        return ds;
    }

    public static DataSet Get_user_Detail_Id_Wise(string A_User_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Detail_Id_Wise",
            new SqlParameter("@A_User_Id", A_User_Id)
            );
        return ds;
    }



    public static string Insert_Add_User_Detail(String P_Intro, Byte Meritial_Status,Byte Meritial_Status_V,String No_Of_Children,Byte No_Of_Children_V,
        Int32 Country_Id, Int32 City_Id, String Present_Address,String Parmanent_Address, Byte Occupation, Byte Occupation_V,String Present_Working_Status, Byte Present_Working_Status_V,
       String Past_Experiance, Byte Past_Experiance_V, String QUALIFICATIONS, Byte QUALIFICATIONS_V, String Political_View, Byte Political_View_V,Byte Religious,
       Byte Religious_V, String Sports, String HobbY, String Foods, Int32 A_User_Id, String Fav_Movie, String U_University, String U_College , String U_School , String U_Contact    , String U_Website )
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_User_Detail_Insert",
            new SqlParameter("@P_Intro", P_Intro),
            new SqlParameter("@Meritial_Status", Meritial_Status),
            new SqlParameter("@Meritial_Status_V", Meritial_Status_V),
            new SqlParameter("@No_Of_Children", No_Of_Children),
            new SqlParameter("@No_Of_Children_V", No_Of_Children_V),
            new SqlParameter("@Country_Id", Country_Id),
            new SqlParameter("@City_Id", City_Id),   
            new SqlParameter("@Present_Address", Present_Address),
           new SqlParameter("@Parmanent_Address", Parmanent_Address),
           new SqlParameter("@Occupation", Occupation),
           new SqlParameter("@Occupation_V", Occupation_V),
           new SqlParameter("@Present_Working_Status", Present_Working_Status),
           new SqlParameter("@Present_Working_Status_V", Present_Working_Status_V),


            new SqlParameter("@Past_Experiance", Past_Experiance),
            new SqlParameter("@Past_Experiance_V", Past_Experiance_V),
            new SqlParameter("@QUALIFICATIONS", QUALIFICATIONS),
            new SqlParameter("@QUALIFICATIONS_V", QUALIFICATIONS_V),
            new SqlParameter("@Political_View", Political_View),
            new SqlParameter("@Political_View_V", Political_View_V),
           new SqlParameter("@Religious", Religious),
           new SqlParameter("@Religious_V", Religious_V),
           new SqlParameter("@Sports", Sports),
           new SqlParameter("@HobbY", HobbY),
           new SqlParameter("@Foods", Foods),
           new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Fav_Movie", Fav_Movie),

           new SqlParameter("@U_University", U_University),
           new SqlParameter("@U_College", U_College),
           new SqlParameter("@U_School", U_School),
           new SqlParameter("@U_Contact", U_Contact),
             new SqlParameter("@U_Website", U_Website) 



       );
        return Convert.ToString(ret);
    }


    public static void Update_User_Detail(string P_Id, String P_Intro, Byte Meritial_Status, Byte Meritial_Status_V, String No_Of_Children, Byte No_Of_Children_V,
        Int32 Country_Id, Int32 City_Id, String Present_Address, String Parmanent_Address, Byte Occupation, Byte Occupation_V, String Present_Working_Status, Byte Present_Working_Status_V,
       String Past_Experiance, Byte Past_Experiance_V, String QUALIFICATIONS, Byte QUALIFICATIONS_V, String Political_View, Byte Political_View_V, Byte Religious,
       Byte Religious_V, String Sports, String HobbY, String Foods, Int32 A_User_Id, String Fav_Movie, String U_University, String U_College, String U_School, String U_Contact, String U_Website)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "User_Info_Detail_Update",
            new SqlParameter("@P_Id", P_Id),
             new SqlParameter("@P_Intro", P_Intro),
            new SqlParameter("@Meritial_Status", Meritial_Status),
            new SqlParameter("@Meritial_Status_V", Meritial_Status_V),
            new SqlParameter("@No_Of_Children", No_Of_Children),
            new SqlParameter("@No_Of_Children_V", No_Of_Children_V),
            new SqlParameter("@Country_Id", Country_Id),
            new SqlParameter("@City_Id", City_Id),
            new SqlParameter("@Present_Address", Present_Address),
           new SqlParameter("@Parmanent_Address", Parmanent_Address),
           new SqlParameter("@Occupation", Occupation),
           new SqlParameter("@Occupation_V", Occupation_V),
           new SqlParameter("@Present_Working_Status", Present_Working_Status),
           new SqlParameter("@Present_Working_Status_V", Present_Working_Status_V),


            new SqlParameter("@Past_Experiance", Past_Experiance),
            new SqlParameter("@Past_Experiance_V", Past_Experiance_V),
            new SqlParameter("@QUALIFICATIONS", QUALIFICATIONS),
            new SqlParameter("@QUALIFICATIONS_V", QUALIFICATIONS_V),
            new SqlParameter("@Political_View", Political_View),
            new SqlParameter("@Political_View_V", Political_View_V),
           new SqlParameter("@Religious", Religious),
           new SqlParameter("@Religious_V", Religious_V),
           new SqlParameter("@Sports", Sports),
           new SqlParameter("@HobbY", HobbY),
           new SqlParameter("@Foods", Foods),
           new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Fav_Movie", Fav_Movie),
                   new SqlParameter("@U_University", U_University),
           new SqlParameter("@U_College", U_College),
           new SqlParameter("@U_School", U_School),
           new SqlParameter("@U_Contact", U_Contact),
            new SqlParameter("@U_Website", U_Website) 

       );

    }

    public static DataSet Get_user_Detail_Id_Wise_Home_Page(string A_User_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Detail_Id_Wise_Home",
            new SqlParameter("@A_User_Id", A_User_Id)
            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise_Pic(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise_Pic",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }

    //31 August 2016
    public static string Insert_tbl_Post_Comment(Int32 Post_Id, Int32 Comment_User_Id, String P_Comment, DateTime Post_Date, String P_Image, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Comment_Insert",
            new SqlParameter("@Post_Id", Post_Id),
            new SqlParameter("@Comment_User_Id", Comment_User_Id),
           new SqlParameter("@P_Comment", P_Comment),         
            new SqlParameter("@P_Date", Post_Date),  
            new SqlParameter("@P_Image", P_Image),
            new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }


    public static DataSet List_of_Post_Wise_Comment(Int32 PostId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Wise_Comment",
              new SqlParameter("@Post_Id", PostId)
            );
        return ds;
    }

    public static DataSet Get_frend_Search(Int32 IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Frnd_Search",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }

    public static string Insert_p_tbl_tbUser_Friends(Int32 u_id, Int32 u_friendId, Byte u_friendStatus, Boolean isRemoved, DateTime createdDate, DateTime modifiedDate)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_tbUser_Friends_Insert",
            new SqlParameter("@u_id", u_id),
            new SqlParameter("@u_friendId", u_friendId),
           new SqlParameter("@u_friendStatus", u_friendStatus),
            new SqlParameter("@isRemoved", isRemoved),
           new SqlParameter("@createdDate", createdDate),
           new SqlParameter("@modifiedDate", modifiedDate)
         

       );
        return Convert.ToString(ret);
    }


    public static DataSet Get_frend_Search_Send_Request(Int32 IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Frnd_RequestSearch",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }

    public static DataSet Get_Check_Data_Folowers(Int32 A_User_IID, Int32 FrndId, Byte Fstatus)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Check_Frnd_Request",
               new SqlParameter("@A_User_IID", A_User_IID),
            new SqlParameter("@FrndId", FrndId),      
           new SqlParameter("@Fstatus", Fstatus)

            );
        return ds;
    }

    public static DataSet Get_frend_Search_Following(Int32 IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Frnd_Followers",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }


    public static void Update_Frnd_Status(Int32 A_User_IID, Int32 FrndId, Byte Fstatus)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Update_Frnd_Request",
             new SqlParameter("@A_User_IID", A_User_IID),
            new SqlParameter("@FrndId", FrndId),
           new SqlParameter("@Fstatus", Fstatus)

       );

    }

    public static DataSet Get_Frends_Followers(Int32 IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_User_Frnd_Followers",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise_Post(string IID, Int32 CountryId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_All_User_Wise_Profile",
            new SqlParameter("@userid", IID)
        , new SqlParameter("@CcountryID", CountryId)
            );
        return ds;
    }

    public static DataSet List_of_Post_Friends(String Useid, Int32 CcountryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_All_User_Wise_Friends",
              new SqlParameter("@userid", Useid),
               new SqlParameter("@CcountryID", CcountryID)
            );
        return ds;
    }

    public static void Update_Post_Status(Int32 P_Id, Int32 A_User_Id, Byte P_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Update_Tbl_Post_Status",
             new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@P_Status", P_Status)

       );

    }

    //  05 08 16
    public static DataSet Get_Check_Share(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Share_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }


    public static string Insert_Add_tbl_Share(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Share_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Share_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }
    public static string Updade_tbl_Share(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Share_Update",

            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Share_Type", Like_Type)

        );
        return Convert.ToString(ret12);
    }


    public static DataSet Get_Check_Share_Post(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Share_Check_Post",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise_Notification(string IID, Int32 CcountryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Notification_Userid_Wise",
            new SqlParameter("@userid", IID) ,         
                 new SqlParameter("@CcountryID", CcountryID)
            );
        return ds;
    }

    //6 sep 2016

    public static DataSet List_of_Post_Id_Wise(Int32 P_Id, Int32 CcountryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Id_Wise_View_Page",
              new SqlParameter("@P_Id", P_Id),
               new SqlParameter("@CcountryID", CcountryID)
            );
        return ds;
    }


    public static DataSet Update_Notification(Int32 P_Id, Byte Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_notification",
            new SqlParameter("@P_Id", P_Id),
               new SqlParameter("@Product_Id", Product_Id)


            );
        return ds;
    }


    public static DataSet List_of_Search1(String Search1)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_Login",
              new SqlParameter("@searchString", Search1)
            );
        return ds;
    }



    public static DataSet List_of_Search2(String Search1)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_Post",
              new SqlParameter("@searchString", Search1)
            );
        return ds;
    }

    public static DataSet Get_Check_search_Frnd(Int32 u_id, Int32 u_friendId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_frnd_Check_Search",
            new SqlParameter("@UserId", u_id),
                 new SqlParameter("@u_friendId", u_friendId)
            );
        return ds;
    }

    public static DataSet List_of_U_Status()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_lookup_U_Status_List"


            );
        return ds;
    }

    public static DataSet List_ofCity()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_lookup_City"


            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise_Frndlist(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Userid_Wise_Frnd",
            new SqlParameter("@userid", IID)
            );
        return ds;
    }

    public static DataSet List_of_Post_Wise_Tag(String  PostId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Wise_Tag",
              new SqlParameter("@Ptagid", PostId)
            );
        return ds;
    }

    public static string Insert_Add_tbl_Photo_Album(Int32 A_User_Id, String Album_Name, String About_Album, String Album_Place, String Image_Path, String Tag_People,  Byte A_Type, Byte A_Status,DateTime P_Date)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Photo_Album_Insert",
            new SqlParameter("@A_User_Id", A_User_Id),
            new SqlParameter("@Album_Name", Album_Name),
           new SqlParameter("@About_Album", About_Album),
           new SqlParameter("@Album_Place", Album_Place),

           new SqlParameter("@Image_Path", Image_Path),
            new SqlParameter("@Tag_People", Tag_People),
           new SqlParameter("@P_Date", P_Date),
           new SqlParameter("@A_Type", A_Type),
             new SqlParameter("@A_Status", A_Status)
          

       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_Photo_Album(string Album_Id, Int32 A_User_Id, String Album_Name, String About_Album, String Album_Place, String Image_Path, String Tag_People, Byte A_Type, Byte A_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Photo_Album_Update",
            new SqlParameter("@Album_Id", Album_Id),
            new SqlParameter("@A_User_Id", A_User_Id),
            new SqlParameter("@Album_Name", Album_Name),
           new SqlParameter("@About_Album", About_Album),
           new SqlParameter("@Album_Place", Album_Place),

           new SqlParameter("@Image_Path", Image_Path),
            new SqlParameter("@Tag_People", Tag_People),
        
           new SqlParameter("@A_Type", A_Type),
             new SqlParameter("@A_Status", A_Status)
       );

    }

    public static DataSet Get_user_Id_Wise_Album_List(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Album_List_User_Wise",
            new SqlParameter("@userid", IID)
            );
        return ds;
    }



    public static string Insert_Album_Pic(Int32 Album_Id, Int32 A_User_Id, String Image_Name, String Image_Path, DateTime P_Date)
   
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Album_Image_Insert",
            new SqlParameter("@Album_Id", Album_Id),
            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@Image_Path", Image_Path),
            new SqlParameter("@P_Date", P_Date)


       );
        return Convert.ToString(ret);
    }

    public static DataSet Get_Album_Wise_Image(Int32 IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_IamgeList_Album_Wise",
            new SqlParameter("@Album_Id", IID)
            );
        return ds;
    }


    //date 19 september 2016

    public static DataSet Load_Event_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Load_Event_Type"

            );
        return ds;
    }


    public static string Insert_Add_tbl_Event_Post(String P_Name, String P_Location, String P_Time, String P_Description, Byte P_Type,
        Int32 A_User_Id, Byte V_Status, DateTime P_Date, String P_Image, Byte P_Status, Byte F_Status, String P_URL, DateTime Event_Satrt_Date, Byte duration, String Tag_Id)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Event_Insert",
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Location", P_Location),
           new SqlParameter("@P_Time", P_Time),
           new SqlParameter("@P_Description", P_Description),  
           new SqlParameter("@P_Type", P_Type),

            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@V_Status", V_Status),
           new SqlParameter("@P_Date", P_Date),

             new SqlParameter("@P_Image", P_Image),
             new SqlParameter("@P_Status", P_Status),

             new SqlParameter("@F_Status", F_Status),
             new SqlParameter("@P_URL", P_URL),
             new SqlParameter("@Event_Satrt_Date", Event_Satrt_Date),

             new SqlParameter("@duration", duration),
             new SqlParameter("@Tag_Id", Tag_Id)

       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_Event_Post(string P_Id, String P_Name, String P_Location, String P_Time, String P_Description, Byte P_Type,
        Int32 A_User_Id, Byte V_Status, DateTime P_Date, String P_Image, Byte P_Status, Byte F_Status, String P_URL, DateTime Event_Satrt_Date, Byte duration, String Tag_Id)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Post_Event_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Location", P_Location),
           new SqlParameter("@P_Time", P_Time),
           new SqlParameter("@P_Description", P_Description),
           new SqlParameter("@P_Type", P_Type),

            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@V_Status", V_Status),
           new SqlParameter("@P_Date", P_Date),

             new SqlParameter("@P_Image", P_Image),
             new SqlParameter("@P_Status", P_Status),

             new SqlParameter("@F_Status", F_Status),
             new SqlParameter("@P_URL", P_URL),
             new SqlParameter("@Event_Satrt_Date", Event_Satrt_Date),

             new SqlParameter("@duration", duration),
             new SqlParameter("@Tag_Id", Tag_Id)
       );

    }

    public static DataSet List_of_Post_Event(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_All_User_Wise",
              new SqlParameter("@userid", Useid)
            );
        return ds;
    }


       //20 sep 2016

    public static DataSet Get_Check_UserPost_Event(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Event_User_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }

    public static DataSet Get_Post_Post_Event_Id_Wise(Int32 PostId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_Id_Wise",
              new SqlParameter("@PostId", PostId)
            );
        return ds;
    }


    public static void Update_Post_Event_Status(Int32 P_Id, Int32 A_User_Id, Byte P_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Update_Tbl_Post_Event_Status",
             new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@P_Status", P_Status)

       );

    }

    public static DataSet List_of_Post_Event_Upcomming(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_All_User_Wise_Upcomming",
              new SqlParameter("@userid", Useid)
            );
        return ds;
    }


    public static DataSet List_of_Post_Event_Past(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_All_User_Wise_Past",
              new SqlParameter("@userid", Useid)
            );
        return ds;
    }

    public static DataSet List_of_Post_Event_Releted(String Useid, Byte P_Type)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_All_User_Wise_Releted",
              new SqlParameter("@userid", Useid),
              new SqlParameter("@P_Type", P_Type)
            );
        return ds;
    }

   // date 22 september 2016
    public static DataSet Get_Check_LikeEvent(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Like_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }


    public static string Insert_Add_tbl_Event_Like(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Like_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }


    public static string Updade_Add_tbl_Event_Like(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Like_Update",

            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type)

        );
        return Convert.ToString(ret12);
    }


    public static DataSet Get_Check_Going_Event(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Going_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }

    public static string Insert_Add_tbl_Event_Going(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Going_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }

    public static string Updade_Add_tbl_Event_Going(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Going_Update",

            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type)

        );
        return Convert.ToString(ret12);   
    }


    public static DataSet List_of_Post_Event_Popular(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_Popular_Wise",
              new SqlParameter("@userid", Useid)
          
            );
        return ds;
    }


   

    //date 26 2016
    public static DataSet Get_Add_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Add_Select"

            );
        return ds;
    }

    public static DataSet List_of_Items_Product_Wise(Byte Categoryid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[sp_Items_Select_Product_Wise]",
            new SqlParameter("@Category_Id", Categoryid)

            );
        return ds;
    }

    public static DataSet List_of_Items()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Items_Select"
            );
        return ds;
    }

    public static string Insert_tbl_Add_Item(Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Add_Post_Insert",
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
            new SqlParameter("@Segment", Segment)
           
   

       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_Add_Item(string P_Id, Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date,Byte Segment)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Add_Item_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date) ,
             new SqlParameter("@Segment", Segment)
       );

    }

    public static DataSet Get_Item_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Item_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet Get_List_Seg1(string Segment)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Seg1",
            new SqlParameter("@Segment", Segment)
            );
        return ds;
    }

    //  date 27 sept 2016

    public static DataSet List_of_Video()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_tblFiles"
            );
        return ds;
    }


    public static void Update_tbl_Add_Video1(string Id, String Name, String ContentType, Byte[] Data, Byte p_sl, String P_Title,Byte p_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Add_Video_Update",
            new SqlParameter("@Id", Id),
            new SqlParameter("@Name", Name),
               new SqlParameter("@ContentType", ContentType),
            new SqlParameter("@Data", Data),
            new SqlParameter("@p_sl", p_sl),
           new SqlParameter("@P_Title", P_Title),

           new SqlParameter("@p_Status", p_Status)

       );

    }


    public static DataSet Get_Video_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Video_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static void Update_tbl_Add_Video2(string Id, String Name, String ContentType,  Byte p_sl, String P_Title, Byte p_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Add_Video_Update1",
            new SqlParameter("@Id", Id),
            new SqlParameter("@Name", Name),
               new SqlParameter("@ContentType", ContentType),
         
            new SqlParameter("@p_sl", p_sl),
           new SqlParameter("@P_Title", P_Title),

           new SqlParameter("@p_Status", p_Status)

       );

    }

    public static DataSet Get_List_Video1()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[sp_Get_Video1]"
          
            );
        return ds;
    }


    public static DataSet Get_List_Video2()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[sp_Get_Video2]"

            );
        return ds;
    }

    public static void Update_Video_Status(Int32 P_Id,  Byte P_Status)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Update_Tbl_Video_Status",
             new SqlParameter("@P_Id", P_Id),           
           new SqlParameter("@P_Status", P_Status)

       );

    }

    //More 
    public static DataSet List_of_Items_More()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Items_More_Select"
            );
        return ds;
    }

    public static DataSet List_of_More_Product_Wise(Byte Categoryid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Items_More_Select_Product_Wise",
            new SqlParameter("@Category_Id", Categoryid)

            );
        return ds;
    }


    public static DataSet Get_Add_More()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_More_Select"

            );
        return ds;
    }


    public static string Insert_tbl_Item_More(Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_More_Insert",
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
            new SqlParameter("@Segment", Segment)



       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_Item_More(string P_Id, Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Item_More_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@Segment", Segment)
       );

    }

    public static DataSet Get_Item_More_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Item_More_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet List_of_More_List(String Useid, byte Category_Id, Byte Like_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Item_More_User_Wise",
              new SqlParameter("@userid", Useid),
               new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@Like_Id", Like_Id)
            );
        return ds;
    }


    public static DataSet List_of_More_List1(String Useid, byte Category_Id , Byte Like_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Item_More_User_Wise1",
             new SqlParameter("@userid", Useid),
               new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@Like_Id", Like_Id)
            );
        return ds;
    }


    public static string Insert_Add_tbl_More_Like(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_More_Like_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }

    public static string Updade_tbl_More_Like(Int32 P_Id, Int32 Friend_Id, DateTime Post_Date, Byte Like_Type)
    {
        object ret12;
        ret12 = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_More_Like_Update",

            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type)

        );
        return Convert.ToString(ret12);
    }
    public static DataSet Get_Check_More_Like(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_More_Like_Check",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }



    public static DataSet List_of_More_List_SegmentWise(String Useid, byte Category_Id, Byte Like_Id, Byte Segment)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Item_More_User_Seg_Wise",
              new SqlParameter("@userid", Useid),
               new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@Like_Id", Like_Id),
                new SqlParameter("@Segment", Segment)
            );
        return ds;
    }


    public static DataSet Get_LookuP_More_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_TLookup_More_Id_Wise",
            new SqlParameter("@T_id", P_Id)
            );
        return ds;
    }


    public static DataSet Get_Check_Like_clik(Int32 P_Id, string UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Like_Check1",
            new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@UserId", UserId)
            );
        return ds;
    }


    public static DataSet Update_Notification_Status(String Nappies_Id, Byte Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_Notification_Status",
            new SqlParameter("@Nappies_Id", Nappies_Id),
               new SqlParameter("@Product_Id", Product_Id)


            );
        return ds;
    }

    public static DataSet List_of_Post_Id_Wise_Like(Int32 P_Id, Byte Product)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Id_Wise_View_Page_Like",
              new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@Product", Product)
            );
        return ds;
    }

    //31 october 2016

    public static string Insert_Add_tbl_Tag(Int32 P_Id, Int32 Friend_Id, Int32 A_User_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Tag_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
             new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }


     //01nov 2016

    public static DataSet Get_FrndList(Int32 UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_get_frnd_List",
            new SqlParameter("@u_id", UserId)
             
            );
        return ds;
    }

    public static string Insert_Add_tbl_Event_Tag(Int32 P_Id, Int32 Friend_Id, Int32 A_User_Id, DateTime Post_Date, Byte Like_Type, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Event_Tag_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
             new SqlParameter("@A_User_Id", A_User_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@Like_Type", Like_Type),
             new SqlParameter("@N_Status", N_Status)


       );
        return Convert.ToString(ret);
    }

    public static DataSet Get_Max_Event_P_Id_User_Wise(Int32 Userid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Event_Id_A_User_Id_Wise",
              new SqlParameter("@Userid", Userid)
            );
        return ds;
    }


    public static DataSet Get_Delete_Image(Int32 Album_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Delete_Album",
            new SqlParameter("@Album_Id", Album_Id)
            );
        return ds;
    }


    public static DataSet Show_Calendar(String MonthYear)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Calendar",
              new SqlParameter("@MonthYear", MonthYear)

            );
        return ds;
    }

    public static DataSet Show_Calendar_Month_Year(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Calendar_Month_Year",
              new SqlParameter("@userid", Useid)

            );
        return ds;
    }

    public static DataSet List_of_Frnd_Calendar(String Useid, String BDATE)
    {
       
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Userid_Wise_Frnd_Event",
              new SqlParameter("@userid", Useid)  ,
                new SqlParameter("@BDATE", BDATE)

            );
        return ds;
    }


    // 6 November 2016

    public static DataSet List_of_Post_Event_Releted_Left_Side(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_All_User_Wise_Releted_LeftSide",
              new SqlParameter("@userid", Useid)
            
            );
        return ds;
    }


    public static DataSet List_of_Frnd_Calendar_Left_side(String Useid)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Userid_Wise_Frnd_B_Day",
              new SqlParameter("@userid", Useid)
             

            );
        return ds;
    }


    //help

    public static DataSet List_of_Help_Items()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Items_Select_Help"
            );
        return ds;
    }


    public static string Insert_tbl_Add_Item_Help(Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Add_Help_Insert",
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
            new SqlParameter("@Segment", Segment)



       );
        return Convert.ToString(ret);
    }

    public static void Update_tbl_Add_Help(string P_Id, Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Add_Item_Help_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@Segment", Segment)
       );

    }

    public static DataSet Get_Item_Id_Wise_Help(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Item_Id_Wise_Help",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise_Frndlist_Setting(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Userid_Wise_Frnd_Blog",
            new SqlParameter("@userid", IID)
            );
        return ds;
    }



    public static void Update_Frnd_Status_Blok(Int32 A_User_IID, Int32 FrndId, Byte Fstatus)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Update_User_Settings",
             new SqlParameter("@A_User_IID", A_User_IID),
            new SqlParameter("@FrndId", FrndId),
           new SqlParameter("@Fstatus", Fstatus)

       );

    }


    public static DataSet Get_Check_Blog(Int32 A_User_IID, Int32 FrndId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Block_Check1",
            new SqlParameter("@A_User_Id", A_User_IID),
                 new SqlParameter("@Friend_Id", FrndId)
            );
        return ds;
    }



    public static string Insert_Add_tbl_Blpck(Int32 A_User_Id, Int32 Friend_Id, DateTime Post_Date, Byte N_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Block_Insert",
            new SqlParameter("@A_User_Id", A_User_Id),
            new SqlParameter("@Friend_Id", Friend_Id),
           new SqlParameter("@Post_Date", Post_Date),
           new SqlParameter("@N_Status", N_Status)
             


       );
        return Convert.ToString(ret);
    }


    public static DataSet List_of_Post_Event_Reminder(String Useid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Event_All_User_Wise_Remincer",
              new SqlParameter("@userid", Useid)
            );
        return ds;
    }


    public static DataSet List_of_Frnd_Calendar_Reminder(String Useid)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Userid_Wise_Frnd_Reminder",
              new SqlParameter("@userid", Useid)
               
            );
        return ds;
    }


    //  Notes

    public static string Insert_Add_tbl_Post_Notes(String P_Name,   String P_Description, Int32 A_User_Id, 
         DateTime P_Date, String P_Image, Byte P_Status)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Post_Note_Insert",
            new SqlParameter("@P_Name", P_Name),         
               new SqlParameter("@P_Description", P_Description),        
            new SqlParameter("@A_User_Id", A_User_Id),           
           new SqlParameter("@P_Date", P_Date),
           new SqlParameter("@P_Image", P_Image),
           new SqlParameter("@P_Status", P_Status)            
       );
        return Convert.ToString(ret);
    }


    public static DataSet Get_user_Id_Wise_Note_List(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Notes_User_Wise",
            new SqlParameter("@userid", IID)
            );
        return ds;
    }

    public static DataSet Get_Delete_Notes(Int32 P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Delete_Notes",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet List_of_Help_Items_Privecy()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Items_Select_Privacy"
            );
        return ds;
    }


    public static void Update_tbl_Add_Privacy(string P_Id, Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Add_Item_Privacy_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@Segment", Segment)
       );

    }

    public static string Insert_tbl_Add_Item_Privacy(Byte Category_Id, String P_Name, String P_Description, String Image_Name, String C_Name, String P_Url, Byte P_Status, Byte P_Sl, DateTime Post_Date, Byte Segment)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Add_Privacy_Insert",
            new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
           new SqlParameter("@C_Name", C_Name),

           new SqlParameter("@P_Url", P_Url),
            new SqlParameter("@P_Status", P_Status),
            new SqlParameter("@P_Sl", P_Sl),
           new SqlParameter("@Post_Date", Post_Date),
            new SqlParameter("@Segment", Segment)



       );
        return Convert.ToString(ret);
    }

    public static DataSet Get_Item_Id_Wise_Privacy(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Tbl_Item_Id_Wise_Privacy",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet Get_Check_UserPost_Comment_Check(Int32 P_Id, Int32  UserId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Post_Wise_Comment_For_delete_Check",
            new SqlParameter("@Post_Id", P_Id),
                 new SqlParameter("@Comment_User_Id", UserId)
            );
        return ds;
    }
    public static void Delete_Post_Comment(Int32 P_Id, Int32 UserId)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Delete_Tbl_tbl_Post_Comment",
             new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@A_User_Id", UserId)
         

       );

    }




}