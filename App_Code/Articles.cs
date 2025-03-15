using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;


public static class Articles
{
    


    public static DataSet Get_Category()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Category_Select"

            );
        return ds;
    }

    public static DataSet Get_sub_Cat()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_SubCat_Select"

            );
        return ds;
    }

    public static DataSet Get_Category_Id_Wise(string catid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_Lookup_Category_Id_wise",
              new SqlParameter("@catid", catid)
              );
        return ds;
    }



    public static DataSet Get_Cat_Id_Wise(string catid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_Lookup_Sub_Cat_Id_wise",
              new SqlParameter("@catid", catid)
              );
        return ds;
    }

    public static DataSet GetCategory_Wise_Subcategory(Int16 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Category_Select",
            new SqlParameter("@CategoryID", CategoryID)
            );
        return ds;
    }


   


    public static DataSet GetCategory_Wise_Subcategory()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Category_All"
    
            );
        return ds;
    }
    public static string Insert_Add_Sub_Category(string SubCategory_Name, Byte Category, Byte Active, String Title, String P_Description, string Filename, string path, string Caption, Byte subCatid)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_SubCategory_Insert",
            new SqlParameter("@SubCategory_Name", SubCategory_Name),
            new SqlParameter("@CategoryID", Category),
           new SqlParameter("@Active", Active),
             new SqlParameter("@Title", Title),
               new SqlParameter("@P_Description", P_Description),
              new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Caption1", Caption),
             new SqlParameter("@subCatid", subCatid)

       );
        return Convert.ToString(ret);
    }

    public static void Update_Sub_Category(string SubCategoryID, string SubCategory_Name, Byte Category, Byte Active, String Title, String P_Description, string Filename, string path, string Caption)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_SubCategory_Update",
            new SqlParameter("@SubCategoryID", SubCategoryID),
            new SqlParameter("@SubCategory_Name", SubCategory_Name),
            new SqlParameter("@CategoryID", Category),
            new SqlParameter("@Active", Active),
           new SqlParameter("@Title", Title),
           new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Caption1", Caption)
            );
    }

    public static DataSet GetSubCategory_Id_Wise(string SubCategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "LookUp_SubCategory_Id_Wise",
            new SqlParameter("@SubCategoryID", SubCategoryID)
            );
        return ds;
    }




    


    public static DataSet SelectSub_Category(Int32 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "LookUp_SubCategory_Category_Id_Wise",
         new SqlParameter("@CategoryID", CategoryID));
        return ds;
    }

   

    public static DataSet List_of_Product()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Lookup_Product_Select"
            );
        return ds;
    }


    public static string Insert_Add_Product(String Product_Name, String title, String Summery, String img1, String img2, String img3, String img4, String img5, String img6)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_Product_Insert",
            new SqlParameter("@Product_Name", Product_Name),
            new SqlParameter("@title", title),
            new SqlParameter("@Summery", Summery),
            new SqlParameter("@img1", img1),
            new SqlParameter("@img2", img2),
            new SqlParameter("@img3", img3),
            new SqlParameter("@img4", img4),
            new SqlParameter("@img5", img5),
            new SqlParameter("@img6", img6)
       );
        return Convert.ToString(ret);
    }


    public static void Update_Product(string Product_Id, String Product_Name, String title, String Summery, String img1, String img2, String img3, String img4, String img5, String img6)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_Product_Update",
            new SqlParameter("@Product_Id", Product_Id),
               new SqlParameter("@Product_Name", Product_Name),
           new SqlParameter("@title", title),
          new SqlParameter("@Summery", Summery),
            new SqlParameter("@img1", img1),
            new SqlParameter("@img2", img2),
            new SqlParameter("@img3", img3),
            new SqlParameter("@img4", img4),
            new SqlParameter("@img5", img5),
            new SqlParameter("@img6", img6)
            );
    }




    public static DataSet Get_Product_Id_wise(string Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Product_Id_Wise",
            new SqlParameter("@Product_Id", Product_Id)
            );
        return ds;
    }


    


    //Sports Itemsss
    public static string Insert_tbl_Items(Byte P_For, Byte Category_Id, Byte Sub_Category_Id, Byte Silhouette_Id, Byte Length_Id, Byte Size_Id, Byte Fabric_Id, Byte Feaure_Id, Byte Season_Id, Byte Collection_Id, Byte Year_Id, Byte Neckline, Byte Embellishments_Id, Byte Back_Id, Byte Waist_Id,
        String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Gift_id, Byte Brand_id, Byte Colors_id, Byte A_User_Id, String Remarks)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Items_Insert",
                new SqlParameter("@P_For", P_For),
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@Sub_Category_Id", Sub_Category_Id),
                new SqlParameter("@Silhouette_Id", Silhouette_Id),
                new SqlParameter("@Length_Id", Length_Id),
                new SqlParameter("@Size_Id", Size_Id),
                new SqlParameter("@Fabric_Id", Fabric_Id),
                new SqlParameter("@Feauture_Id", Feaure_Id),
                new SqlParameter("@Season_Id", Season_Id),
                new SqlParameter("@Collection_Id", Collection_Id),
                new SqlParameter("@Year_Id", Year_Id),
                new SqlParameter("@Neckline", Neckline), 
           
                //
                   new SqlParameter("@Embellishments_Id", Embellishments_Id),
                   new SqlParameter("@Back_Id", Back_Id),
                   new SqlParameter("@Waist_Id", Waist_Id),       
                //

                new SqlParameter("@P_Name", P_Name),
                new SqlParameter("@P_Description", P_Description),
              
                new SqlParameter("@P_Price", P_Price),
                new SqlParameter("@Currency_Id", Currency_Id),
                new SqlParameter("@Currency", Currency),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Image_Path", path),
                new SqlParameter("@Image_Path2", Filename2),
                new SqlParameter("@Image_Path3", Filename3),
                new SqlParameter("@Image_Path4", Filename4),
                new SqlParameter("@Image_Path5", Filename5),
                new SqlParameter("@Image_Path6", Filename6),       
                new SqlParameter("@Sale_Product", Sale_Product),
                new SqlParameter("@sale_enddate", sale_enddate),
                new SqlParameter("@Sale_price", Sale_price),
                new SqlParameter("@Product_Key", Product_Key),    
                new SqlParameter("@change_Price", change_Price),
                new SqlParameter("@change_SalePrice", change_SalePrice),
                new SqlParameter("@Change_Curency", Change_Curency),
                new SqlParameter("@New_Product", New_Product),
                new SqlParameter("@Post_Date", Post_Date),
                new SqlParameter("@Hit", Hit),
                new SqlParameter("@qty", qty),
                new SqlParameter("@Gift_id", Gift_id),
                new SqlParameter("@Brand_id", Brand_id),
                new SqlParameter("@Colors_id", Colors_id),
                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@Remarks", Remarks)
                 );
       

        return Convert.ToString(ret);
    }


    public static void Update_tbl_Item(string P_Id, Byte P_For, Byte Category_Id, Byte Sub_Category_Id, Byte Silhouette_Id, Byte Length_Id, Byte Size_Id, Byte Fabric_Id, Byte Feaure_Id, Byte Season_Id, Byte Collection_Id, Byte Year_Id, Byte Neckline, Byte Embellishments_Id, Byte Back_Id, Byte Waist_Id,
        String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Gift_id, Byte Brand_id, Byte Colors_id, Byte A_User_Id, String Remarks)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Item_Update",
                new SqlParameter("@P_Id", P_Id),
                new SqlParameter("@P_For", P_For),
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@Sub_Category_Id", Sub_Category_Id),
                new SqlParameter("@Silhouette_Id", Silhouette_Id),
                new SqlParameter("@Length_Id", Length_Id),
                new SqlParameter("@Size_Id", Size_Id),
                new SqlParameter("@Fabric_Id", Fabric_Id),
                  new SqlParameter("@Feauture_Id", Feaure_Id),
                new SqlParameter("@Season_Id", Season_Id),
                new SqlParameter("@Collection_Id", Collection_Id),
                new SqlParameter("@Year_Id", Year_Id),
                new SqlParameter("@Neckline", Neckline),

                //
                 new SqlParameter("@Embellishments_Id", Embellishments_Id),
                   new SqlParameter("@Back_Id", Back_Id),
                   new SqlParameter("@Waist_Id", Waist_Id),       
                //
                new SqlParameter("@P_Name", P_Name),
                new SqlParameter("@P_Description", P_Description),

                new SqlParameter("@P_Price", P_Price),
                new SqlParameter("@Currency_Id", Currency_Id),
                new SqlParameter("@Currency", Currency),
                new SqlParameter("@Image_Name", Filename),
                new SqlParameter("@Image_Path", path),
                new SqlParameter("@Image_Path2", Filename2),
                new SqlParameter("@Image_Path3", Filename3),
                new SqlParameter("@Image_Path4", Filename4),
                new SqlParameter("@Image_Path5", Filename5),
                new SqlParameter("@Image_Path6", Filename6),
                new SqlParameter("@Sale_Product", Sale_Product),
                new SqlParameter("@sale_enddate", sale_enddate),
                new SqlParameter("@Sale_price", Sale_price),
                new SqlParameter("@Product_Key", Product_Key),
                new SqlParameter("@change_Price", change_Price),
                new SqlParameter("@change_SalePrice", change_SalePrice),
                new SqlParameter("@Change_Curency", Change_Curency),
                new SqlParameter("@New_Product", New_Product),
                new SqlParameter("@Post_Date", Post_Date),
                new SqlParameter("@Hit", Hit),
                new SqlParameter("@qty", qty),
                new SqlParameter("@Gift_id", Gift_id),
                new SqlParameter("@Brand_id", Brand_id),
                new SqlParameter("@Colors_id", Colors_id),
                new SqlParameter("@A_User_Id", A_User_Id),
                new SqlParameter("@Remarks", Remarks)
       );

    }






    public static string Insert_tbl_S_Acc(Byte P_For, Byte Category_Id, Byte Sub_Category_Id, Byte P_Type_Id, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
        String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Gift_id, Byte Brand_id, Byte Colors_id, Byte Sub_Product_id, String Remarks)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_S_Acc",
               new SqlParameter("@P_For", P_For),
               new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@Sub_Category_Id", Sub_Category_Id),
               new SqlParameter("@P_Type_Id", P_Type_Id),
               new SqlParameter("@P_Name", P_Name),
               new SqlParameter("@P_Description", P_Description),

             new SqlParameter("@P_Price", P_Price),
              new SqlParameter("@Currency_Id", Currency_Id),
              new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
            new SqlParameter("@Sale_Product", Sale_Product),
            new SqlParameter("@sale_enddate", sale_enddate),
            new SqlParameter("@Sale_price", Sale_price),
            new SqlParameter("@Product_Key", Product_Key),
             new SqlParameter("@change_Price", change_Price),
            new SqlParameter("@change_SalePrice", change_SalePrice),
            new SqlParameter("@Change_Curency", Change_Curency),
            new SqlParameter("@New_Product", New_Product),
            new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@Hit", Hit),
            new SqlParameter("@qty", qty),
            new SqlParameter("@Gift_id", Gift_id),
             new SqlParameter("@Brand_id", Brand_id),
            new SqlParameter("@Colors_id", Colors_id),
             new SqlParameter("@Sub_Product_id", Sub_Product_id),
            new SqlParameter("@Remarks", Remarks)
                 );


        return Convert.ToString(ret);
    }


    public static void Update_tbl_S_Acc(string P_Id, Byte P_For, Byte Category_Id, Byte Sub_Category_Id, Byte P_Type_Id, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Gift_id, Byte Brand_id, Byte Colors_id, Byte Sub_Product_id, String Remarks)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_S_Acc_Update",
            new SqlParameter("@P_Id", P_Id),
           new SqlParameter("@P_For", P_For),
               new SqlParameter("@Category_Id", Category_Id),
               new SqlParameter("@Sub_Category_Id", Sub_Category_Id),
               new SqlParameter("@P_Type_Id", P_Type_Id),
               new SqlParameter("@P_Name", P_Name),
               new SqlParameter("@P_Description", P_Description),

             new SqlParameter("@P_Price", P_Price),
              new SqlParameter("@Currency_Id", Currency_Id),
              new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
            new SqlParameter("@Sale_Product", Sale_Product),
            new SqlParameter("@sale_enddate", sale_enddate),
            new SqlParameter("@Sale_price", Sale_price),
            new SqlParameter("@Product_Key", Product_Key),
             new SqlParameter("@change_Price", change_Price),
            new SqlParameter("@change_SalePrice", change_SalePrice),
            new SqlParameter("@Change_Curency", Change_Curency),
            new SqlParameter("@New_Product", New_Product),
            new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@Hit", Hit),
            new SqlParameter("@qty", qty),
            new SqlParameter("@Gift_id", Gift_id),
             new SqlParameter("@Brand_id", Brand_id),
            new SqlParameter("@Colors_id", Colors_id),
             new SqlParameter("@Sub_Product_id", Sub_Product_id),
            new SqlParameter("@Remarks", Remarks)
       );

    }

    
    
    public static DataSet List_of_Items()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Items_Select"
            );
        return ds;
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

 


   

    public static DataSet Get_View()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_view_Select"

            );
        return ds;
    }

    public static DataSet Get_ProductID_Search(String SearchId, Int32 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_product",
            new SqlParameter("@sbid", SearchId),
           new SqlParameter("@CategoryID", CategoryID)
            );
        return ds;
    }


       
    public static DataSet Get_Accesories_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Accessories_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet List_of_Accessories()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Accessories_Select"
            );
        return ds;
    }


    //Accesorries

    //for all product search   
    public static DataSet Get_Search_Product_wise(String SearchId, Int32 CategoryID, Int32 Product)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_product_Wise",
            new SqlParameter("@sbid", SearchId),
           new SqlParameter("@CategoryID", CategoryID),
           new SqlParameter("@Product", Product)
            );
        return ds;
    }

    public static DataSet Get_Search_Product_wise_For_Sale(String SearchId, Int32 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_product_Wise_for_Sale",
            new SqlParameter("@sbid", SearchId),
           new SqlParameter("@CategoryID", CategoryID)

            );
        return ds;
    }

  
    public static DataSet Get_ProductID_Search_OiiO(String SearchId, Int32 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_product_OiiO",
            new SqlParameter("@sbid", SearchId),
           new SqlParameter("@CategoryID", CategoryID)
            );
        return ds;
    }

  



   

  
    public static DataSet Get_Blog_List()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Published_Blog_List"
            );
        return ds;
    }

    public static DataSet Get_New_Arrival_Home()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sptbl_Langerie_Select_For_Home"

            );
        return ds;
    }
    public static DataSet Get_New_Arrival_Home_All()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_new_Arrival_Select_For_Home_all"

            );
        return ds;
    }

    public static DataSet Get_Best_seller_Home()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Best_seller_Home"

            );
        return ds;
    }


    public static DataSet Get_Popular_Home()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Popular_Home"

            );
        return ds;
    }

    public static DataSet Get_Blog_Home()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Blog_Select_For_Home"

            );
        return ds;
    }

    //public static void Update_Nappies_Hit(string Nappies_Id)
    //{

    //    SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
    //        CommandType.StoredProcedure,
    //        "Sp_Update_Nappies_Hit",
    //        new SqlParameter("@Nappies_Id", Nappies_Id)

    //        );
    //}

    public static DataSet Update_Nappies_Hit(String Nappies_Id, Byte Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_Nappies_Hit",
            new SqlParameter("@Nappies_Id", Nappies_Id),
               new SqlParameter("@Product_Id", Product_Id)


            );
        return ds;
    }
   

    public static void Update_blog_Hit(string blogId)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[Sp_Update_Blog_Hit]",
            new SqlParameter("@blogId", blogId)
            );
    }

    //

    



    public static DataSet Get_Blog_Other(string iuserId, String blogId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "blog_Other",
            new SqlParameter("@iuserId", iuserId),
            new SqlParameter("@blogId", blogId)

            );
        return ds;
    }


    

    public static String Check_Email_Id(string Email)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_chk_Email_Id",
            new SqlParameter("@Email_Id", Email)
            );
        return Convert.ToString(ret);
    }



    public static String Check_User(string LoginName, String LoginPassword)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_chk_User",
            new SqlParameter("@LoginName", LoginName),
             new SqlParameter("@LoginPassword", LoginPassword)
            );
        return Convert.ToString(ret);
    }



    public static DataSet Check_User_data(string LoginName, String LoginPassword)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
            "Sp_chk_User",
            new SqlParameter("@LoginName", LoginName),
             new SqlParameter("@LoginPassword", LoginPassword)
            );
        return ds;
    }

    public static DataSet List_of_User()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_User_List"
            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise",
            new SqlParameter("@IID", IID)
            );
        return ds;
    }

    public static DataSet Get_Group()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_user_Group_Select"

            );
        return ds;
    }


    public static void Update_User(string IID, int group_Id, Int32 ModifiedBy, DateTime ModifiedDate, Boolean IsRemoved, Boolean IsActiveUser)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_User_Update",
            new SqlParameter("@IID", IID),
             new SqlParameter("@UserGroupID", group_Id),
           new SqlParameter("@ModifiedBy", ModifiedBy),
            new SqlParameter("@ModifiedDate", ModifiedDate),
            new SqlParameter("@IsRemoved", IsRemoved),
            new SqlParameter("@IsActiveUser", IsActiveUser)

       );






    }
    public static String Check_Blog_Id(string Email)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_select_varify_user",
            new SqlParameter("@U_Name", Email)
            );
        return Convert.ToString(ret);
    }

    public static DataSet Get_popular_Home_Al()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_more_popular"

            );
        return ds;
    }



    public static DataSet Get_serch_b_size_name_wize(string Bsize)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_serch_b_name_wise",
            new SqlParameter("@B_size_Name", Bsize)
            );
        return ds;
    }

    public static string OiiO_User_Sign_UpInsert(String EmailSignup)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_OiiO_User_Sign_Up_Insert",
            new SqlParameter("@s_Email_Id", EmailSignup)

       );
        return Convert.ToString(ret);
    }

    public static String Check_Signup_Id(string Email)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_chk_sign_up_Email_Id",
            new SqlParameter("@s_Email_Id", Email)
            );
        return Convert.ToString(ret);
    }


    public static string Insert_Add_Footer_Content(String Page_Title, String Content_Title, String Content_Description, String Imagname1, String imgpath1, String Imagname2, String imgpath2)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Footer_Content_Insert",
            new SqlParameter("@Page_Title", Page_Title),
            new SqlParameter("@Content_Title", Content_Title),
             new SqlParameter("@Content_Description", Content_Description),
             new SqlParameter("@Image1_name", Imagname1),
             new SqlParameter("@Image1Path", imgpath1),
             new SqlParameter("@Image2Name", Imagname2),
             new SqlParameter("@Image2Path", imgpath2)
       );
        return Convert.ToString(ret);
    }


    public static void Update_Footer_Content(string Id, String Page_Title, String Content_Title, String Content_Description, String Imagname1, String imgpath1, String Imagname2, String imgpath2)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Footer_Content_Update",
            new SqlParameter("@Id", Id),
               new SqlParameter("@Page_Title", Page_Title),
           new SqlParameter("@Content_Title", Content_Title),
          new SqlParameter("@Content_Description", Content_Description),
          new SqlParameter("@Image1_name", Imagname1),
             new SqlParameter("@Image1Path", imgpath1),
             new SqlParameter("@Image2Name", Imagname2),
             new SqlParameter("@Image2Path", imgpath2)
       );


    }

    public static DataSet Get_Bag_Other(String Nappies_Id, Byte Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Nappies_Other",
            new SqlParameter("@Nappies_Id", Nappies_Id),
               new SqlParameter("@Product_Id", Product_Id)


            );
        return ds;
    }
   


   

   


   
  



    ///nnn
    ///
    public static DataSet Get_footer_Content(string Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Footer_Content_Id_Wise",
            new SqlParameter("@Id", Id)
            );
        return ds;
    }

    public static DataSet List_of_Footer_Content()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Footer_Content_List"
            );
        return ds;
    }

    public static DataSet List_of_Sign_Up_Id()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_sign_upList"
            );
        return ds;
    }

    ///

    public static DataSet Get_Search_oiio(String searchString)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_oiio_site",
            new SqlParameter("@searchString", searchString)


            );
        return ds;
    }


    public static DataSet Get_Data_Footer_Page_id_wise(String contentId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Footer_Content_List_id_wise",
            new SqlParameter("@contentId", contentId)


            );
        return ds;
    }

    public static DataSet List_of_Footer_Comment()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Footer_comment_List"
            );
        return ds;
    }


    ///16 sept
    ///
    public static DataSet Check_User_Password(string LoginName)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
            "Sp_chk_User_Password",
            new SqlParameter("@LoginName", LoginName)

            );
        return ds;
    }

    public static DataSet Get_Menue()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Menue_Select"

            );
        return ds;
    }



    public static DataSet GetMenue_Wise_SubMenu(Int16 MenuidID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Menu_Select",
            new SqlParameter("@MenuidID", MenuidID)
            );
        return ds;
    }

    public static DataSet Get_Sub_menue_Id_wise(string Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_sub_menue_Id_Wise",
            new SqlParameter("@Sub_Menue_Id", Product_Id)
            );
        return ds;
    }
    public static string Insert_Add_Sub_Menue(String SubMenu_Name, Int32 MenuidID, String Title, String Description, String tagid)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_Sub_Menue_Insert",
            new SqlParameter("@SubMenu_Name", SubMenu_Name),
            new SqlParameter("@MenuidID", MenuidID),
            new SqlParameter("@Title", Title),
             new SqlParameter("@Description", Description),
             new SqlParameter("@tagid", tagid)
       );
        return Convert.ToString(ret);
    }

    public static void Update_Submenu(string SubMenuID, String SubMenu_Name, Int32 MenuidID, String Title, String Description, String tagid)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_submenue_Update",
            new SqlParameter("@SubMenuID", SubMenuID),
               new SqlParameter("@SubMenu_Name", SubMenu_Name),
            new SqlParameter("@MenuidID", MenuidID),
               new SqlParameter("@Title", Title),
             new SqlParameter("@Description", Description),
             new SqlParameter("@tagid", tagid)
            );
    }


    public static DataSet Get_Submenu_Id_wise_Title(string Menue_Id, string SubMenueId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Sub_Menue_Id_Title",
            new SqlParameter("@Menue_Id", Menue_Id),
            new SqlParameter("@Sub_Menue_Id", SubMenueId)
            );
        return ds;
    }

    public static DataSet Get_ProductID_Search_for_Menue(String SearchId, Int32 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_search_product_For_Menue",
            new SqlParameter("@sbid", SearchId),
           new SqlParameter("@CategoryID", CategoryID)
            );
        return ds;
    }

    public static DataSet Get_serch_Sub_Category_Name(string Bsize)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_serch_Select_Sub_Categary_Id",
            new SqlParameter("@SC_Name", Bsize)
            );
        return ds;
    }

    //Tulaaa












    public static DataSet Get_Home_Id_Wise_Detail(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Home_Id_Wise_Detail",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    

    public static string Insert_Add_tbl_Home_Detail(Int32 P_Id, Int32 CategoryID, Int32 SubCategoryID)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Home_Detail_Insert",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@CategoryID", CategoryID),
           new SqlParameter("@SubCategoryID", SubCategoryID)

       );
        return Convert.ToString(ret);
    }




    public static DataSet Get_View_Brand()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Category_Brands"

            );
        return ds;
    }

    public static DataSet Get_View_Brand_combo()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Category_Brands_combo"

            );
        return ds;
    }
    public static DataSet Get_View_Color()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Category_Color"

            );
        return ds;
    }

    public static DataSet Get_View_Color_Combo()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Category_Color_Combo"

            );
        return ds;
    }


  
    public static DataSet Get_sub_Menue_Id_For(String sumnenueid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[sp_sub_Menu_Id_Tag]",
               new SqlParameter("@submenuid", sumnenueid)
            );
        return ds;
    }

    


    public static string Insert_tbl_Offer(Int32 Product_Id, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, DateTime Postdate, Byte Published)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Product_Offer_Insert",
            new SqlParameter("@Product_Id", Product_Id),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
             new SqlParameter("@P_Price", P_Price),
            new SqlParameter("@Currency_Id", Currency_Id),
              new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),

             new SqlParameter("@Post_Date", Postdate),
            new SqlParameter("@P_Status", Published)

       );
        return Convert.ToString(ret);
    }

    public static void Update_tbl_Offer(string Offer_Id, Int32 Product_Id, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, DateTime Postdate, Byte Published)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Product_Offer_Update",
             new SqlParameter("@Offer_Id", Offer_Id),
            new SqlParameter("@Product_Id", Product_Id),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
             new SqlParameter("@P_Price", P_Price),
             new SqlParameter("@Currency_Id", Currency_Id),
             new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Post_Date", Postdate),
            new SqlParameter("@P_Status", Published)

       );
    }
    public static DataSet Get_Offer_Id_Wise(string Offer_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Offer_Id_Wise",
            new SqlParameter("@Offer_Id", Offer_Id)
            );
        return ds;
    }


    public static DataSet List_of_Offer()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Offer_Select"
            );
        return ds;
    }

  

  


    public static string Insert_tbl_Home_Page(String P_Name, String P_Description, String P_Summery, String P_Features, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
           String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Gift_id, Byte Brand_id, Byte Colors_id, Byte Sub_Product_id, String Remarks)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Home_Page_Insert",
               new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
              new SqlParameter("@P_Summery", P_Summery),
                new SqlParameter("@P_Features", P_Features),

             new SqlParameter("@P_Price", P_Price),
              new SqlParameter("@Currency_Id", Currency_Id),
              new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
            new SqlParameter("@Sale_Product", Sale_Product),
            new SqlParameter("@sale_enddate", sale_enddate),
            new SqlParameter("@Sale_price", Sale_price),
            new SqlParameter("@Product_Key", Product_Key),
             new SqlParameter("@change_Price", change_Price),
            new SqlParameter("@change_SalePrice", change_SalePrice),
            new SqlParameter("@Change_Curency", Change_Curency),
            new SqlParameter("@New_Product", New_Product),
            new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@Hit", Hit),
            new SqlParameter("@qty", qty),
            new SqlParameter("@Gift_id", Gift_id),
             new SqlParameter("@Brand_id", Brand_id),
            new SqlParameter("@Colors_id", Colors_id),
             new SqlParameter("@Sub_Product_id", Sub_Product_id),
            new SqlParameter("@Remarks", Remarks)
                 );


        return Convert.ToString(ret);
    }


    public static void Update_tbl_Home_Page(string P_Id, String P_Name, String P_Description, String P_Summery, String P_Features, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Gift_id, Byte Brand_id, Byte Colors_id, Byte Sub_Product_id, String Remarks)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Home_Page_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
                         new SqlParameter("@P_Summery", P_Summery),
                new SqlParameter("@P_Features", P_Features),
             new SqlParameter("@P_Price", P_Price),
              new SqlParameter("@Currency_Id", Currency_Id),
              new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
            new SqlParameter("@Sale_Product", Sale_Product),
            new SqlParameter("@sale_enddate", sale_enddate),
            new SqlParameter("@Sale_price", Sale_price),
            new SqlParameter("@Product_Key", Product_Key),
             new SqlParameter("@change_Price", change_Price),
            new SqlParameter("@change_SalePrice", change_SalePrice),
            new SqlParameter("@Change_Curency", Change_Curency),
            new SqlParameter("@New_Product", New_Product),
            new SqlParameter("@Hit", Hit),
                  new SqlParameter("@Post_Date", Post_Date),
            new SqlParameter("@qty", qty),
            new SqlParameter("@Gift_id", Gift_id),
             new SqlParameter("@Brand_id", Brand_id),
            new SqlParameter("@Colors_id", Colors_id),
                new SqlParameter("@Sub_Product_id", Sub_Product_id),
            new SqlParameter("@Remarks", Remarks)
       );

    }

    public static DataSet Get_Home_Page_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Home_Page_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }

    public static DataSet List_of_Home_Page()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Home_Page_Select"
            );
        return ds;
    }


    public static DataSet Get_data_Home_Page(string Rowid, Int32 TopId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_get_Data_Home_Page",
                new SqlParameter("@Rowid", Rowid),
                    new SqlParameter("@TopId", TopId)

            );
        return ds;
    }
    public static void Update_Home_Hit(string P_Id)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[Sp_Update_Home_Hit]",
            new SqlParameter("@P_Id", P_Id)

            );
    }

    public static DataSet Get_Search_oiio_Count(String searchString)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "count_Row_For_Search",
            new SqlParameter("@searchString", searchString)


            );
        return ds;
    }




    public static DataSet Get_Search_oiio_Combo(String searchString1)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "search_for_Search_combo",
            new SqlParameter("@searchString1", searchString1)


            );
        return ds;
    }

    public static DataSet Get_data_Bag_Cat()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_get_Cloth_Id_Home"

            );
        return ds;
    }



    public static DataSet Get_subCategory_catId_Wise(string catid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_LookUp_Sub_Category_Cat_Wise",
              new SqlParameter("@catid", catid)
              );
        return ds;
    }

    public static DataSet Get_Category_catId_Wise()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_LookUp_Category_Cat_Wise"

              );
        return ds;
    }

    public static string Insert_tbl_Brand(Int32 CategoryID, Int32 SubCategoryID, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, Boolean New_Product, Boolean Special_Product, string Occasional, Int32 Discount, String Special_Offer, String Remarks, Int32 Hit, DateTime Postdate, Byte Published, String Filename2, String Filename3, String Filename4, String Filename5, String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, Byte home_rowid, string Product_Key)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Brand_Insert",
            new SqlParameter("@CategoryID", CategoryID),
           new SqlParameter("@SubCategoryID", SubCategoryID),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
             new SqlParameter("@P_Price", P_Price),
              new SqlParameter("@Currency_Id", Currency_Id),
              new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@New_Product", New_Product),
            new SqlParameter("@Special_Product", Special_Product),
             new SqlParameter("@Occasional", Occasional),
            new SqlParameter("@Discount", Discount),
            new SqlParameter("@Special_Offer", Special_Offer),
             new SqlParameter("@Remarks", Remarks),
             new SqlParameter("@Post_Date", Postdate),
            new SqlParameter("@P_Status", Published),
            new SqlParameter("@Hit", Hit),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
            new SqlParameter("@Sale_Product", Sale_Product),
            new SqlParameter("@sale_enddate", sale_enddate),
            new SqlParameter("@Sale_price", Sale_price),
            new SqlParameter("@home_rowid", home_rowid),
            new SqlParameter("@Product_Key", Product_Key)
       );
        return Convert.ToString(ret);
    }


    public static string Insert_tbl_Slider(String P_Name, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5, String Filename6,
        String Cap1, String Cap2,String Cap3,String Cap4,String Cap5,String Cap6 , String Title1, String Title2, String Title3, String Title4, String Title5, String Title6)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Brand_Insert",
            new SqlParameter("@P_Name", P_Name),

             new SqlParameter("@Image_Name", Filename),
           new SqlParameter("@Image_Path", path),
             new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
            new SqlParameter("@Cap1", Cap1),
           new SqlParameter("@Cap2", Cap2),
           new SqlParameter("@Cap3", Cap3),
           new SqlParameter("@Cap4", Cap4),
           new SqlParameter("@Cap5", Cap5),
             new SqlParameter("@Cap6", Cap6),
           new SqlParameter("@Title1", Title1),
           new SqlParameter("@Title2", Title2),
           new SqlParameter("@Title3", Title3),
           new SqlParameter("@Title4", Title4),
           new SqlParameter("@Title5", Title5),
           new SqlParameter("@Title6", Title6)

       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_Slider(string Brand_Id, String P_Name, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5, String Filename6,
            String Cap1, String Cap2, String Cap3, String Cap4, String Cap5, String Cap6, String Title1, String Title2, String Title3, String Title4, String Title5, String Title6)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Brand_Update",
            new SqlParameter("@Brand_Id", Brand_Id),
           new SqlParameter("@P_Name", P_Name),
              new SqlParameter("@Image_Name", Filename),
           new SqlParameter("@Image_Path", path),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),
             new SqlParameter("@Cap1", Cap1),
           new SqlParameter("@Cap2", Cap2),
           new SqlParameter("@Cap3", Cap3),
           new SqlParameter("@Cap4", Cap4),
           new SqlParameter("@Cap5", Cap5),
           new SqlParameter("@Cap6", Cap6),
           new SqlParameter("@Title1", Title1),
           new SqlParameter("@Title2", Title2),
           new SqlParameter("@Title3", Title3),
           new SqlParameter("@Title4", Title4),
           new SqlParameter("@Title5", Title5),
           new SqlParameter("@Title6", Title6)
       );

    }
  
    public static DataSet Get_BrandId_Wise(string Brand_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Brand_Id_Wise",
            new SqlParameter("@Brand_Id", Brand_Id)
            );
        return ds;
    }

    public static DataSet List_of_Brand()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Brand_Select"
            );
        return ds;
    }

    public static string Insert_tbl_Brand_Detail(Int32 Brand_Id, Int32 CategoryID, Int32 SubCategoryID)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_tbl_Brand_Detail_Insert",
            new SqlParameter("@Brand_Id", Brand_Id),
            new SqlParameter("@CategoryID", CategoryID),
           new SqlParameter("@SubCategoryID", SubCategoryID)

       );
        return Convert.ToString(ret);
    }

    public static DataSet Get_Brand_Id_Wise_Detail(string Brand_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Brand_Id_Wise_Detail",
            new SqlParameter("@Brand_Id", Brand_Id)
            );
        return ds;
    }

    public static void Update_Brand_Hit(string Brand_Id)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_Brand_Hit",
            new SqlParameter("@Brand_Id", Brand_Id)

            );
    }
    public static void Update_Nightwear_Hit(string Nightwear_Id)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_Nightwea_Hit",
            new SqlParameter("@Nightwear_Id", Nightwear_Id)
            );
    }

    public static DataSet Get_Show_Id()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Top_5_ID"

            );
        return ds;
    }

    public static DataSet Get_top_Hit_data_For_Product(byte Productid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_Top_Hit_Product_wise",
            new SqlParameter("@Productid", Productid)


            );
        return ds;
    }

    public static DataSet Get_Recently_Hit_Product()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_Receently_Hit_Product"


            );
        return ds;
    }

    public static DataSet Get_data_Product_wise(byte Productid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_data_Product_wise",
            new SqlParameter("@Productid", Productid)


            );
        return ds;
    }

    public static DataSet Get_sub_name_Viewpage(Int32 pid, Int32 subid, Byte prdouct)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "product1_sub_name",
         new SqlParameter("@pid", pid),
            new SqlParameter("@subid", subid),
           new SqlParameter("@prdouct", prdouct)
              );
        return ds;
    }
    public static string Insert_tbl_Company_Info(String c_Name, String c_Description, string Filename, string path, DateTime Postdate, Byte Published, String url)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Company_Info_Insert",

            new SqlParameter("@c_Name", c_Name),
            new SqlParameter("@c_Description", c_Description),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),

             new SqlParameter("@Post_Date", Postdate),
            new SqlParameter("@P_Status", Published),
               new SqlParameter("@url", url)

       );
        return Convert.ToString(ret);
    }

    public static void Update_tbl_Company_Info(string P_Id, String c_Name, String c_Description, string Filename, string path, DateTime Postdate, Byte Published, String url)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_Company_Info_Update",
             new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@c_Name", c_Name),
            new SqlParameter("@c_Description", c_Description),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path),
            new SqlParameter("@Post_Date", Postdate),
            new SqlParameter("@P_Status", Published),
            new SqlParameter("@url", url)

       );
    }


    public static string Insert_lookup_Brand(String B_Name, String B_Description, string Filename, string path)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Brand_Insert",

            new SqlParameter("@B_Name", B_Name),
            new SqlParameter("@B_Description", B_Description),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path)


       );
        return Convert.ToString(ret);
    }

    public static void Update_lookup_Brand(string B_Id, String B_Name, String B_Description, string Filename, string path)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "lookup_Brand_Update",
             new SqlParameter("@B_Id", B_Id),
            new SqlParameter("@B_Name", B_Name),
            new SqlParameter("@B_Description", B_Description),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path)
        
       );
    }

    public static DataSet Get_Company_Info_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Company_Id_Wise",
            new SqlParameter("@P_Id", P_Id)
            );
        return ds;
    }


    public static DataSet Get_Lookup_Brand_Id_Wise(string P_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Lookup_Brand_Id_Wise",
            new SqlParameter("@B_Id", P_Id)
            );
        return ds;
    }

    public static DataSet List_of_Company_Info()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Company_Info_Select"
            );
        return ds;
    }

    public static DataSet List_of_Lookup_Brand()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Lookup_Brand_Select"
            );
        return ds;
    }

    public static DataSet Get_data_company_Info()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_Company_Info_Select_home"

            );
        return ds;
    }


    public static DataSet Get_data_Brand_All()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_get_lookup_Brand"

            );
        return ds;
    }


    public static string Insert_tbl_AddBag(String P_Name, Int32 P_Id, Byte Product_Id, string Mac_Name, DateTime Post_Date, Byte qty, decimal Rate, decimal Total)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Add_Bag_Insert",
            new SqlParameter("@P_Name", P_Name),
           new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Product_Id", Product_Id),
            new SqlParameter("@Mac_Name", Mac_Name),
            new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@qty", qty),
             new SqlParameter("@Rate", Rate),
            new SqlParameter("@Total", Total)


       );
        return Convert.ToString(ret);
    }


    public static DataSet Get_data_AddBag(string Sessionid, DateTime postdate)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_get_Data_Add_Bag",
                new SqlParameter("@Sessionid", Sessionid),
                    new SqlParameter("@Postdate", postdate)

            );
        return ds;
    }

    public static DataSet Get_Gift_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_gifttype_Select"

            );
        return ds;
    }


    public static DataSet Get_Brand_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Brand_Select"

            );
        return ds;
    }

    public static DataSet Get_Brand_Type1()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Brand_Select_1"

            );
        return ds;
    }

    public static DataSet Get_Colors_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_Colors_Select"

            );
        return ds;
    }

    public static DataSet Get_Rate(Int32 id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Rate",
             new SqlParameter("@id", id)

            );
        return ds;
    }

    public static DataSet Get_curency()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Lookup_curency_Select"

            );
        return ds;
    }


    public static String Check_Rollid(string ename, String roll)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "userRole_user_wise",
            new SqlParameter("@ename", ename),
            new SqlParameter("@rolname", roll)
            );
        return Convert.ToString(ret);
    }


    public static void Update_User_Profile(string IID, String First_Name, String Last_Name, String LoginName, DateTime dob, Byte title_id)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_User_Profile_Update",
            new SqlParameter("@IID", IID),
             new SqlParameter("@First_Name", First_Name),
           new SqlParameter("@Last_Name", Last_Name),
            new SqlParameter("@LoginName", LoginName),
            new SqlParameter("@dob", dob),
            new SqlParameter("@title_id", title_id)

       );

    }


    public static DataSet Get_Title()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Title_Select"

            );
        return ds;
    }

    public static String Check_Address(string Userid)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "user_Address",
            new SqlParameter("@Userid", Userid)

            );
        return Convert.ToString(ret);
    }


    public static DataSet Check_Address1(string Userid)
    {



        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "user_Address",
            new SqlParameter("@Userid", Userid)

            );
        return ds;
    }

    public static DataSet Get_Country()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Country_Select"

            );
        return ds;
    }

    public static DataSet Get_City(Int32 Cid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_City_Select_Countrywise",
            new SqlParameter("@Country_Id", Cid)
            );
        return ds;
    }

    public static DataSet Get_City()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_City_Select"

            );
        return ds;
    }
    public static DataSet Get_user_Id_Wise_Address(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise_Address",
            new SqlParameter("@UserID", IID)
            );
        return ds;
    }

    public static string Insert_User_Address(String UserID, String Phn_Number1, String Phn_Number2, Int32 Country_Id, Int32 City_Id, String U_Address, String Post_Code)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_User_Address_Insert",
               new SqlParameter("@UserID", UserID),
            new SqlParameter("@Phn_Number1", Phn_Number1),
             new SqlParameter("@Phn_Number2", Phn_Number2),
              new SqlParameter("@Country_Id", Country_Id),
            new SqlParameter("@City_Id", City_Id),
            new SqlParameter("@U_Address", U_Address),
            new SqlParameter("@Post_Code", Post_Code)
       );
        return Convert.ToString(ret);
    }

    public static void Update_User_Address(String UserID, String Phn_Number1, String Phn_Number2, Int32 Country_Id, Int32 City_Id, String U_Address, String Post_Code)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "User_Address_Update",
                   new SqlParameter("@UserID", UserID),
            new SqlParameter("@Phn_Number1", Phn_Number1),
             new SqlParameter("@Phn_Number2", Phn_Number2),
              new SqlParameter("@Country_Id", Country_Id),
            new SqlParameter("@City_Id", City_Id),
            new SqlParameter("@U_Address", U_Address),
            new SqlParameter("@Post_Code", Post_Code)
       );

    }

    public static void Update_User_Password(string IID, String Newpass)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_User_Password_Update",
            new SqlParameter("@IID", IID),
             new SqlParameter("@LoginPassword", Newpass)


       );

    }


    public static DataSet Check_Paemnt_Card(string Userid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "user_Payment_Card",
            new SqlParameter("@Userid", Userid)

            );
        return ds;
    }


    public static String Check_Paemnt_Card1(string Userid)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "user_Payment_Card",
            new SqlParameter("@Userid", Userid)

            );
        return Convert.ToString(ret);
    }


    public static DataSet Get_Card_Type()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Card_Type_Select"

            );
        return ds;
    }


    public static DataSet Get_user_Id_Wise_Payment_Card(string IID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise_Payement_Card",
            new SqlParameter("@UserID", IID)
            );
        return ds;
    }


    public static void Update_User_Payment(String UserID, Byte Card_Type, String Card_No, DateTime Start_Date, DateTime End_Date, String IssueNumber, String Name_On_Card)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "User_Payment_Card_Update",
                   new SqlParameter("@UserID", UserID),
            new SqlParameter("@Card_Type", Card_Type),
             new SqlParameter("@Card_No", Card_No),
              new SqlParameter("@Start_Date", Start_Date),
            new SqlParameter("@End_Date", End_Date),
            new SqlParameter("@IssueNumber", IssueNumber),
            new SqlParameter("@Name_On_Card", Name_On_Card)
       );

    }

    public static string Insert_User_Payment(String UserID, Byte Card_Type, String Card_No, DateTime Start_Date, DateTime End_Date, String IssueNumber, String Name_On_Card)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_User_Payment_Card_Insert",
              new SqlParameter("@UserID", UserID),
            new SqlParameter("@Card_Type", Card_Type),
             new SqlParameter("@Card_No", Card_No),
              new SqlParameter("@Start_Date", Start_Date),
            new SqlParameter("@End_Date", End_Date),
            new SqlParameter("@IssueNumber", IssueNumber),
            new SqlParameter("@Name_On_Card", Name_On_Card)
       );
        return Convert.ToString(ret);
    }

    public static string Insert_Promotional_Discount(String D_Code, Decimal D_Amount, DateTime S_Date, DateTime E_Date)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_prmotional_Discount_Insert",

            new SqlParameter("@D_Code", D_Code),
            new SqlParameter("@D_Amount", D_Amount),
            new SqlParameter("@S_Date", S_Date),
            new SqlParameter("@E_Date", E_Date)

       );
        return Convert.ToString(ret);
    }
    public static void Update_Promotional_Discount(string D_id, String D_Code, Decimal D_Amount, DateTime S_Date, DateTime E_Date)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_prmotional_Discount_Update",
             new SqlParameter("@D_id", D_id),
           new SqlParameter("@D_Code", D_Code),
            new SqlParameter("@D_Amount", D_Amount),
            new SqlParameter("@S_Date", S_Date),
            new SqlParameter("@E_Date", E_Date)

       );
    }

    public static DataSet Get_Promotional_Discount_Id_Wise(string D_id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_lookup_Promotional_Discount_Id_Wise",
            new SqlParameter("@D_id", D_id)
            );
        return ds;
    }

    public static DataSet List_Pro_Discount()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Pro_Discount_Select"
            );
        return ds;
    }

    public static DataSet Get_Pro_Dis_Amount(String DCode)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Pro_Dis_Amount",
             new SqlParameter("@D_Code", DCode)

            );
        return ds;
    }

    //28 nov 2015
    public static DataSet Check_User_data_Addbag(string LoginName, String LoginPassword)
    {

        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
            "Sp_chk_User_AddBag",
            new SqlParameter("@LoginName", LoginName),
             new SqlParameter("@LoginPassword", LoginPassword)
            );
        return ds;
    }

    public static DataSet Get_user_Id_Wise_Add_Bag(string UserID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise_Add_Bag",
            new SqlParameter("@UserID", UserID)
            );
        return ds;
    }


    public static DataSet Get_City_Id_Wise_Charge(string CityID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_City_Id_Wise_Charge",
            new SqlParameter("@C_id", CityID)
            );
        return ds;
    }


    public static string Insert_tbl_chk_Address(Int32 UserID, Int32 City_Id, string U_name, String U_Address, DateTime C_Date, Byte C_Status, String Session_Id, String contact_no, String email_address)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_chk_out_Address_Insert",
           new SqlParameter("@UserID", UserID),
           new SqlParameter("@City_Id", City_Id),
           new SqlParameter("@U_name", U_name),
           new SqlParameter("@U_Address", U_Address),
           new SqlParameter("@C_Date", C_Date),
           new SqlParameter("@C_Status", C_Status),
           new SqlParameter("@Session_Id", Session_Id),
           new SqlParameter("@contact_no", contact_no),
           new SqlParameter("@email_address", email_address)
             
       );
        return Convert.ToString(ret);
    }

    public static void Update_tbl_chk_Address(String A_ID, Int32 UserID, Int32 City_Id, string U_name, String U_Address, DateTime C_Date, Byte C_Status, String Session_Id, String contact_no, String email_address)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_chk_out_Address_Update",
            new SqlParameter("@A_ID", A_ID),
            new SqlParameter("@UserID", UserID),
           new SqlParameter("@City_Id", City_Id),
           new SqlParameter("@U_name", U_name),
            new SqlParameter("@U_Address", U_Address),
            new SqlParameter("@C_Date", C_Date),
            new SqlParameter("@C_Status", C_Status),
             new SqlParameter("@Session_Id", Session_Id),
             new SqlParameter("@contact_no", contact_no),
             new SqlParameter("@email_address", email_address)
       );

    }

    public static DataSet Check_chkout_Address(string Session_Id, DateTime C_Date)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_get_chk_out_Address",
            new SqlParameter("@Session_Id", Session_Id),
            new SqlParameter("@C_Date", C_Date)
            );
        return ds;
    }

    //30 nov

    public static string Insert_city(Int32 Country_Id,  String C_name, Decimal Charge)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_lookup_city_Insert",
           new SqlParameter("@Country_Id", Country_Id),
           new SqlParameter("@C_name", C_name),
           new SqlParameter("@Charge", Charge)

       );
        return Convert.ToString(ret);
    }

    public static DataSet Check_Process_Stock_Balance(string Session_Id, DateTime C_Date)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Stock_Balance",
            new SqlParameter("@Session_Id", Session_Id),
            new SqlParameter("@Post_Date", C_Date)
            );
        return ds;
    }

    public static DataSet Check_Final_Data(string Session_Id, DateTime C_Date)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Final_Data",
            new SqlParameter("@Session_Id", Session_Id),
            new SqlParameter("@Post_Date", C_Date)
            );
        return ds;
    }

    public static string Insert_tbl_Check_Final_Transaction(String C_Name, String C_Addres, String Mac_Name, DateTime Post_Date,string currency_Name, Decimal T_Total, Byte T_Status, Int32 trans_Id)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Check_Final_Transaction_Insert",
           new SqlParameter("@C_Name", C_Name),
           new SqlParameter("@C_Addres", C_Addres),
           new SqlParameter("@Mac_Name", Mac_Name),
           new SqlParameter("@Post_Date", Post_Date),
             new SqlParameter("@currency_Name", currency_Name),
           new SqlParameter("@T_Total", T_Total),
           new SqlParameter("@T_Status", T_Status),
            new SqlParameter("@trans_Id", trans_Id)
       );
        return Convert.ToString(ret);
    }


    public static DataSet clear_cookies(string Session_Id, DateTime C_Date)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "clear_cookies",
            new SqlParameter("@Session_Id", Session_Id),
            new SqlParameter("@Post_Date", C_Date)
            );
        return ds;
    }

    public static DataSet List_of_Transaction()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Get_Transaction"
            );
        return ds;
    }


    public static DataSet Get_subCategory_Price_Between()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_LookUp_Price_Between"
             
              );
        return ds;
    }


    public static DataSet Get_subCategory_Wise(string Subcat)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_LookUp_Sub_Category_Wise",
              new SqlParameter("@catid", Subcat)
              );
        return ds;
    }


    public static DataSet Get_subCategory_Price_Between_Id_wise(string Subcat)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_LookUp_Price_Between_Pid_wise",
              new SqlParameter("@P_Id", Subcat)
              );
        return ds;
    }

    public static string Insert_Add_Sub_Cat(string SubCat_Name, Byte Category, Byte Active, String Title, String P_Description, string Filename, string path, string Caption)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_SubCat_Insert",
            new SqlParameter("@SubCat_Name", SubCat_Name),
            new SqlParameter("@CategoryID", Category),
           new SqlParameter("@Active", Active),
             new SqlParameter("@Title", Title),
               new SqlParameter("@P_Description", P_Description),
              new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path)


       );
        return Convert.ToString(ret);
    }

    public static void Update_Sub_Cat(string SubCatID, string SubCat_Name, Byte Category, Byte Active, String Title, String P_Description, string Filename, string path, string Caption)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_SubCat_Update",
            new SqlParameter("@SubCatID", SubCatID),
            new SqlParameter("@SubCat_Name", SubCat_Name),
            new SqlParameter("@CategoryID", Category),
            new SqlParameter("@Active", Active),
           new SqlParameter("@Title", Title),
           new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Filename),
            new SqlParameter("@Image_Path", path)
  
            );
    }

   

    public static DataSet GetCategory_Wise_Subcat(Int16 CategoryID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Cat_Select",
            new SqlParameter("@CategoryID", CategoryID)
            );
        return ds;
    }

    public static DataSet Get_Sub_Cloth()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_Sub_Cloth_Select"
            
            );
        return ds;
    }



    public static DataSet Get_subProduct_Wise(string catid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
              CommandType.StoredProcedure,
              "Sp_LookUp_Sub_Category_subCatid_Wise",
              new SqlParameter("@subCatid", catid)
              );
        return ds;
    }



    public static DataSet GetCategory_Wise_Subcat()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_LookUp_Sub_Cat_All"
            
            );
        return ds;
    }
    // public static DataSet Get_subCategory_Price_Between()//lok
    //{
    //    DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
    //          CommandType.StoredProcedure,
    //          "Sp_LookUp_Price_Between"
             
    //          );
    //    return ds;
    //}


     public static DataSet GetsubCat_Wise_Subcategory(Int16 subCatid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_sub_Category_name_subcat_wise",
             new SqlParameter("@subCatid", subCatid)
             );
         return ds;
     }

     public static DataSet GetsubCat_Wise(string  subCatid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Sub_cat_Wise",
             new SqlParameter("@subCatid", subCatid)
             );
         return ds;
     }

     public static DataSet Get_New_offer()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_new_offer_all"

             );
         return ds;
     }

     public static DataSet Get_Home_Data()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_home_Data"

             );
         return ds;
     }

     public static DataSet Get_Email_Id_wise(string E_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Email_Id_Wise",
             new SqlParameter("@E_Id", E_Id)
             );
         return ds;
     }

     public static DataSet List_of_Mail()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Lookup_Mail_Select"
             );
         return ds;
     }

     //Mail/
     public static string Insert_Add_Mail(String E_Title, String E_Description, String E_From, String smptc, int Port, String E_Password)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Lookup_Mail_Insert",
             new SqlParameter("@E_Title", E_Title),
             new SqlParameter("@E_Description", E_Description),
              new SqlParameter("@E_From", E_From),
            new SqlParameter("@smptc", smptc),
            new SqlParameter("@Port", Port),
              new SqlParameter("@E_Password", E_Password)

        );
         return Convert.ToString(ret);
     }


     public static void Update_Mail(string E_Id, String E_Title, String E_Description, String E_From, String smptc, int Port, String E_Password)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Lookup_Email_Update",
             new SqlParameter("@E_Id", E_Id),
                new SqlParameter("@E_Title", E_Title),
             new SqlParameter("@E_Description", E_Description),
              new SqlParameter("@E_From", E_From),
            new SqlParameter("@smptc", smptc),
            new SqlParameter("@Port", Port),
              new SqlParameter("@E_Password", E_Password)
             );
     }


     public static DataSet Get_Data_Product_Wise( byte product)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Product_Product_Wise",
             new SqlParameter("@product", product)
             );
         return ds;
     }

    //
     //public DataTable sp_get_Search_Price_Between(Decimal firstprice, Decimal secondprice, Byte Product)
     //{

     //    ArrayList arrParam = new ArrayList();
     //    arrParam.Add(new SqlParameter("@firstprice", firstprice));
     //    arrParam.Add(new SqlParameter("@secondprice ", secondprice));
     //    arrParam.Add(new SqlParameter("@Product", Product));
     //    return this.ExecuteStoredProcedureDataTable("price_wise_product", arrParam);
     //}

     public static DataSet Get_Search_Price_Between(Decimal firstprice, Decimal secondprice, Byte Product)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "price_wise_product",
             new SqlParameter("@firstprice", firstprice),
             new SqlParameter("@secondprice", secondprice),
             new SqlParameter("@Product", Product)
             );
         return ds;
     }

     //public DataTable GetProductType_Cat_Wise_product(byte product, String Cat_Id)
     //{

     //    ArrayList arrParam = new ArrayList();
     //    arrParam.Add(new SqlParameter("@product", product));
     //    arrParam.Add(new SqlParameter("@Cat_Id ", Cat_Id));
     //    return this.ExecuteStoredProcedureDataTable("sp_Product_Cat_Wise", arrParam);
     //}

     public static DataSet GetProductType_Cat_Wise_product(byte product, String Cat_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Product_Cat_Wise",
             new SqlParameter("@product", product),
             new SqlParameter("@Cat_Id", Cat_Id)
             
             );
         return ds;
     }


     public static DataSet Get_SubProduct_Id_wise(string SubProduct_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_subProduct_Id_Wise",
             new SqlParameter("@SubProduct_Id", SubProduct_Id)
             );
         return ds;
     }


     public static DataSet Get_SubCategory_Id_wise(string SubProduct_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_subProduct_Id_Wise",
             new SqlParameter("@SubProduct_Id", SubProduct_Id)
             );
         return ds;
     }


     public static DataSet Get_Brand_Name(string Brand_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_lookupBrand_Id_Wise",
             new SqlParameter("@Brand_Id", Brand_Id)
             );
         return ds;
     }

     public static DataSet Get_Sub_Category_Name(string Brand_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_lookup_SubCategory_Id_Wise",
             new SqlParameter("@SubCategoryID", Brand_Id)
             );
         return ds;
     }


     public static DataSet Get_Load_Sub_Product()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,

               "sp_get_lookup_Sub_Product"

             );
         return ds;
     }

     public static DataSet Get_Load_Sub_Product_Category_Wise(String CategoryID)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_get_lookup_Sub_Product_Category_Wise",
             new SqlParameter("@CategoryID", CategoryID)
             );
         return ds;
     }


     public static DataSet Get_Load_SubAcc1()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_get_lookup_Sub_Product_acc1"

            );
         return ds;
     }

     public static DataSet Get_Load_SubAcc2()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,

              "sp_get_lookup_Sub_Product_acc2"

            );
         return ds;
     }

     public static DataSet Getsub_cloth_wise_cloth_all()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_sub_Cloth_wise_Cloth_all"
            
             );
         return ds;
     }


    

     public static DataSet Get_Category_Id(string SubCatId)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "LookUp_Category_Id",
             new SqlParameter("@SubCatId", SubCatId)
             );
         return ds;
     }

     public static DataSet Get_sub_Cloth_Type()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
               CommandType.StoredProcedure,
               "Sp_get_sub_Cloth_type"

               );
         return ds;
     }

     public static DataSet List_of_Items_Product_Wise( Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[sp_Items_Select_Product_Wise]",
             new SqlParameter("@Category_Id", Categoryid)

             );
         return ds;
     }


     public static DataSet List_of_Cloth_Product_Wise(Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[sp_Cloth_Select_Product_Wise]",
             new SqlParameter("@Category_Id", Categoryid)

             );
         return ds;
     }


     public static DataSet List_of_Accessories_Product_Wise(Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[sp_Accessories_Select_Product_Wise]",
             new SqlParameter("@Category_Id", Categoryid)

             );
         return ds;
     }


     public static DataSet List_of_Academy_Product_Wise(Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[sp_Academy_Select_Product_Wise]",
             new SqlParameter("@Category_Id", Categoryid)

             );
         return ds;
     }



     public static DataSet Get_Academy()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
               CommandType.StoredProcedure,
               "Sp_Get_Academy"

               );
         return ds;
     }


     public static DataSet Get_Academy_Cat_Id_Wise(byte catid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
               CommandType.StoredProcedure,
               "Sp_Get_Academy_Cat_Wise",
             new SqlParameter("@catid", catid)

               );
         return ds;
     }

     public static DataSet List_of_Product_Brand()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Get_Brand"
             );
         return ds;
     }


     public static DataSet Get_SubCategory_Name(string SubCatId)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "LookUp_Category_Id",
             new SqlParameter("@SubCatId", SubCatId)
             );
         return ds;
     }

     public static DataSet Get_Recipient_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Recipient_All"

             );
         return ds;
     }


     public static DataSet Get_Recipient()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Recipient"

             );
         return ds;
     }
     public static DataSet Get_Gift_Type_Id_wise(string typeid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Gift_Id_wise",
             new SqlParameter("@typeid", typeid)
             );
         return ds;
     }

     public static DataSet Get_Recipent_Id_wise(string A_id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Recipent_Id_wise",
             new SqlParameter("@A_id", A_id)
             );
         return ds;
     }

     public static DataSet Get_Occasion()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Occassion"

             );
         return ds;
     }

     public static string Insert_tbl_News(Byte Category_Id, String A_Title, String A_Description,  string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Int32 Hit, DateTime Post_Date, Boolean Editor_Choice)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_News_Feature_Insert",
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@A_Title", A_Title),
                new SqlParameter("@A_Description", A_Description),
            

                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Editor_Choice", Editor_Choice)
                 
                  );


         return Convert.ToString(ret);
     }

     public static void Update_tbl_News(string A_Id, Byte Category_Id, String A_Title, String A_Description, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Int32 Hit, DateTime Post_Date, Boolean Editor_Choice)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_News_Feature_Update",
               new SqlParameter("@A_Id", A_Id),
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@A_Title", A_Title),
                new SqlParameter("@A_Description", A_Description),
                new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Editor_Choice", Editor_Choice)
        );

     }

     public static DataSet Get_News_Id_Wise(string A_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_News_Id_Wise",
             new SqlParameter("@A_Id", A_Id)
             );
         return ds;
     }


     public static DataSet List_of_Tbl_News()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_News_Feature_Select"
             );
         return ds;
     }

     public static DataSet Get_News_Category()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_News_Category_Select"

             );
         return ds;
     }

     public static DataSet List_of_News_Category_Wise(Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_News_Select_Category_Wise",
             new SqlParameter("@Category_Id", Categoryid)

             );
         return ds;
     }

    //11 jan 
     public static DataSet List_of_top_Tbl_News()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_top_News_Feature_Select"
             );
         return ds;
     }

     public static DataSet Get_Data_Product_Category_Wise(byte product, Byte Category)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Product_Product_Category_Wise",
             new SqlParameter("@product", product),
              new SqlParameter("@Category", Category)
             );
         return ds;
     }

     public static DataSet List_of_Latest_Items()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_new_Item"
             );
         return ds;
     }

    //jan 12
     public static DataSet Get_News_Other(String Newsid, Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_News_Other",
             new SqlParameter("@News_Id", Newsid),
                new SqlParameter("@Category_Id", Categoryid)


             );
         return ds;
     }

     public static string Insert_tbl_Video(Byte Category_Id, String A_Title, String V_Description, string Filename,  String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Int32 Hit, DateTime Post_Date, Boolean Editor_Choice)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Video_Insert",
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@V_Title", A_Title),
                new SqlParameter("@V_Description", V_Description),
                 new SqlParameter("@V_Name1", Filename),
                 new SqlParameter("@V_Name2", Filename2),
                 new SqlParameter("@V_Name3", Filename3),
                 new SqlParameter("@V_Name4", Filename4),
                 new SqlParameter("@V_Name5", Filename5),
                 new SqlParameter("@V_Name6", Filename6),                 
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Editor_Choice", Editor_Choice)

                  );


         return Convert.ToString(ret);
     }

     public static void Update_tbl_Video(string A_Id,Byte Category_Id, String A_Title, String V_Description, string Filename,  String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Int32 Hit, DateTime Post_Date, Boolean Editor_Choice)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Video_Update",
               new SqlParameter("@V_Id", A_Id),
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@V_Title", A_Title),
                new SqlParameter("@V_Description", V_Description),
                 new SqlParameter("@V_Name1", Filename),
                 new SqlParameter("@V_Name2", Filename2),
                 new SqlParameter("@V_Name3", Filename3),
                 new SqlParameter("@V_Name4", Filename4),
                 new SqlParameter("@V_Name5", Filename5),
                 new SqlParameter("@V_Name6", Filename6),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Editor_Choice", Editor_Choice)
        );

     }


     public static DataSet List_of_Tbl_Video()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Video_Select"
             );
         return ds;
     }

     public static DataSet Get_Video_Id_Wise(string V_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_Video_Id_Wise",
             new SqlParameter("@V_Id", V_Id)
             );
         return ds;
     }

     public static DataSet Get_Top_Video()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_top_Video_Select"
             );
         return ds;
     }

     public static string Insert_tbl_gtg(Byte Category_Id, String A_Title, String A_Description, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Int32 Hit, DateTime Post_Date, Boolean Editor_Choice)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_gtg_Insert",
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@A_Title", A_Title),
                new SqlParameter("@A_Description", A_Description),


                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Editor_Choice", Editor_Choice)

                  );


         return Convert.ToString(ret);
     }

     public static void Update_tbl_gtg(string A_Id, Byte Category_Id, String A_Title, String A_Description, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
        String Filename6, Int32 Hit, DateTime Post_Date, Boolean Editor_Choice)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_gtg_Update",
               new SqlParameter("@A_Id", A_Id),
                new SqlParameter("@Category_Id", Category_Id),
                new SqlParameter("@A_Title", A_Title),
                new SqlParameter("@A_Description", A_Description),
                new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Editor_Choice", Editor_Choice)
        );

     }

     public static DataSet List_of_gtg()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_gtg_Select"
             );
         return ds;
     }

     public static DataSet Get_gtg_Id_Wise(string A_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_gtg_Id_Wise",
             new SqlParameter("@A_Id", A_Id)
             );
         return ds;
     }

     public static DataSet List_of_top_Tbl_News_editor_Choice()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_top_News_Editor_Choice"
             );
         return ds;
     }

     public static DataSet List_of_top_Tbl_gtg()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_top_gtg_Select"
             );
         return ds;
     }

     public static DataSet Get_gtg_Other(String Newsid )
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_gtg_Other",
             new SqlParameter("@News_Id", Newsid)
            


             );
         return ds;
     }

     public static DataSet List_of_top_glos()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_top_gloss_Select"
             );
         return ds;
     }


    //wedlock..14.01.2016

     public static DataSet Get_Silhouette_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Silhouette"

             );
         return ds;
     }


     public static DataSet Get_Length_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Length"

             );
         return ds;
     }

     public static DataSet Get_Size_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Size"

             );
         return ds;
     }


     public static DataSet Get_Feature_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Feature"

             );
         return ds;
     }

     public static DataSet Get_Fabric_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Fabric"

             );
         return ds;
     }
    
     public static DataSet Get_Season_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Season"

             );
         return ds;
     }

     public static DataSet Get_Collection_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Collection"

             );
         return ds;
     }


     public static DataSet Get_Neckline_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Neckline"

             );
         return ds;
     }


     public static DataSet Get_Year_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Year"

             );
         return ds;
     }

     public static DataSet GetCategory_Wise_Type(Int16 CategoryID)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Type_Select",
             new SqlParameter("@CategoryID", CategoryID)
             );
         return ds;
     }

     public static DataSet GetCategory_Wise_Sub_Accessories(Int16 CategoryID)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Sub_Accessories_Category_Wise",
             new SqlParameter("@Category_Id", CategoryID)
             );
         return ds;
     }

     public static DataSet Get_Silhouette()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Get_Silhouette"
         
             );
         return ds;
     }


     public static DataSet Get_Fabric()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Get_Fabric"

             );
         return ds;
     }

     public static DataSet Get_Features()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Get_Features"

             );
         return ds;
     }


     public static DataSet Get_Neckline()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Get_Neckline"

             );
         return ds;
     }

     public static DataSet Get_Top_Id_Category_wise(string Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Top_Date_from_Category_wise",
             new SqlParameter("@Category_Id", Categoryid)
             );
         return ds;
     }


     public static DataSet Get_Top_12data_Category_wise(string Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Top_12Date_from_Category_wise",
             new SqlParameter("@Category_Id", Categoryid)
             );
         return ds;
     }

     public static DataSet Get_Embellishments_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Embellishments"

             );
         return ds;
     }

     public static DataSet Get_Back_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Back"

             );
         return ds;
     }

     public static DataSet Get_Waist_All()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Waist"

             );
         return ds;
     }

     public static DataSet Get_Item_Id_Wise_All_Info(string P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Tbl_Item_Id_Wise_All_Date",
             new SqlParameter("@P_Id", P_Id)
             );
         return ds;
     }


     public static DataSet Get_Top_8data_Category_wise(string Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Top_8Date_from_Category_wise",
             new SqlParameter("@Category_Id", Categoryid)
             );
         return ds;
     }

     public static DataSet GetSubCat_Id_Wise(string SubCategoryID)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "LookUp_SubCat_Id_Wise",
             new SqlParameter("@SubCatID", SubCategoryID)
             );
         return ds;
     }


    //19 jan 2016---evebt Start  
     public static string Insert_tbl_Venue(Byte Country_Id, Byte City_Id, String V_Name, String V_Address, String Owner_Name, String V_Description,  decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price,  decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, DateTime E_Date, Byte A_User_Id, String Remarks)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_tbl_Venue_Insert",
                 new SqlParameter("@Country_Id", Country_Id),
                 new SqlParameter("@City_Id", City_Id),
                 new SqlParameter("@V_Name", V_Name),
                 new SqlParameter("@V_Address", V_Address),
                 new SqlParameter("@Owner_Name", Owner_Name),
                 new SqlParameter("@V_Description", V_Description),
                 new SqlParameter("@P_Price", P_Price),                                              
                 new SqlParameter("@Currency_Id", Currency_Id),
                 new SqlParameter("@Currency", Currency),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Sale_Product", Sale_Product),
                 new SqlParameter("@sale_enddate", sale_enddate),
                 new SqlParameter("@Sale_price", Sale_price),             
                 new SqlParameter("@change_Price", change_Price),
                 new SqlParameter("@change_SalePrice", change_SalePrice),
                 new SqlParameter("@Change_Curency", Change_Curency),
                 new SqlParameter("@New_Product", New_Product),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@E_Date", E_Date),               
                 new SqlParameter("@A_User_Id", A_User_Id),
                 new SqlParameter("@Remarks", Remarks)
                  );


         return Convert.ToString(ret);
     }



     public static void Update_tbl_Venue(string V_Id, Byte Country_Id, Byte City_Id, String V_Name, String V_Address, String Owner_Name, String V_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price,  decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, DateTime E_Date, Byte A_User_Id, String Remarks)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Venue_Update",
                 new SqlParameter("@V_Id", V_Id),
                 new SqlParameter("@Country_Id", Country_Id),
                 new SqlParameter("@City_Id", City_Id),
                 new SqlParameter("@V_Name", V_Name),
                 new SqlParameter("@V_Address", V_Address),
                 new SqlParameter("@Owner_Name", Owner_Name),
                 new SqlParameter("@V_Description", V_Description),
                 new SqlParameter("@P_Price", P_Price),
                 new SqlParameter("@Currency_Id", Currency_Id),
                 new SqlParameter("@Currency", Currency),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Sale_Product", Sale_Product),
                 new SqlParameter("@sale_enddate", sale_enddate),
                 new SqlParameter("@Sale_price", Sale_price),            
                 new SqlParameter("@change_Price", change_Price),
                 new SqlParameter("@change_SalePrice", change_SalePrice),
                 new SqlParameter("@Change_Curency", Change_Curency),
                 new SqlParameter("@New_Product", New_Product),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@E_Date", E_Date),

                 new SqlParameter("@A_User_Id", A_User_Id),
                 new SqlParameter("@Remarks", Remarks)
        );

     }


     public static DataSet Get_Venue_Id_Wise(string V_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Tbl_Venue_Id_Wise",
             new SqlParameter("@V_Id", V_Id)
             );
         return ds;
     }


     public static DataSet List_of_Venue()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_Venue_Select_All"
             );
         return ds;
     }


     public static string Insert_tbl_Venue_Features(Byte V_Id, String F_Name, String F_Description,  string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6,  DateTime Post_Date,  Byte A_User_Id)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_tbl_Venue_Features_Insert",
                 new SqlParameter("@V_Id", V_Id),
                 new SqlParameter("@F_Name", F_Name),
                 new SqlParameter("@F_Description", F_Description),                
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),                 
                 new SqlParameter("@Post_Date", Post_Date),                
                 new SqlParameter("@A_User_Id", A_User_Id)
               
                  );


         return Convert.ToString(ret);
     }


     public static void Update_tbl_Venue_Features(string F_Id, String F_Name, String F_Description, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, DateTime Post_Date, Byte A_User_Id)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Venue_Features_Update",
                 new SqlParameter("@F_Id", F_Id),              
                 new SqlParameter("@F_Name", F_Name),
                 new SqlParameter("@F_Description", F_Description),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@A_User_Id", A_User_Id)
        );

     }

     public static DataSet Get_Venue_Features_Id_Wise(string F_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Tbl_Venue_Features_Id_Wise",
             new SqlParameter("@F_Id", F_Id)
             );
         return ds;
     }



     public static DataSet List_of_Venue_Features_Venue_Id_wise(string V_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_Venue_Features_Venue_Id_Wise",
             new SqlParameter("@V_Id", V_Id)
             );
         return ds;
     }


    ///20 jan 2016
    ///
     public static string Insert_tbl_Venue_Packeges(Byte V_Id, Byte Category_Id, String F_Name, String F_Description, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
          String Filename6, DateTime Post_Date, Byte A_User_Id)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_tbl_Venue_Packages_Insert",
                 new SqlParameter("@V_Id", V_Id),
                  new SqlParameter("@Category_Id", Category_Id),
                 new SqlParameter("@P_Name", F_Name),
                 new SqlParameter("@P_Description", F_Description),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@A_User_Id", A_User_Id)

                  );


         return Convert.ToString(ret);
     }

     public static void Update_tbl_Venue_Packeges(string F_Id, Byte Category_Id, String F_Name, String F_Description, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, DateTime Post_Date, Byte A_User_Id)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Venue_Pakceges_Update",
                 new SqlParameter("@P_Id", F_Id),
                  new SqlParameter("@Category_Id", Category_Id),
                 new SqlParameter("@P_Name", F_Name),
                 new SqlParameter("@P_Description", F_Description),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@A_User_Id", A_User_Id)
        );

     }

     public static DataSet Get_Venue_Packeges_Id_Wise(string F_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Tbl_Venue_Packeges_Id_Wise",
             new SqlParameter("@P_Id", F_Id)
             );
         return ds;
     }

     public static DataSet List_of_Venue_Packege_Venue_Id_wise(string V_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_Venue_Packeges_Venue_Id_Wise",
             new SqlParameter("@V_Id", V_Id)
             );
         return ds;
     }


     public static string Insert_tbl_Packeges(Byte category_Id, String P_Name, String P_Description, decimal P_Price, decimal Reserve_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
          String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, decimal change_Price, decimal change_SalePrice, Decimal Change_Reserve_Price, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, Byte A_User_Id, String Remarks)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_tbl_Packeges_Insert",
                 new SqlParameter("@category_Id", category_Id),
                 new SqlParameter("@P_Name", P_Name),
                 new SqlParameter("@P_Description", P_Description),                
                 new SqlParameter("@P_Price", P_Price),
                 new SqlParameter("@Reserve_Price", Reserve_Price),
                 new SqlParameter("@Currency_Id", Currency_Id),
                 new SqlParameter("@Currency", Currency),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Sale_Product", Sale_Product),
                 new SqlParameter("@sale_enddate", sale_enddate),
                 new SqlParameter("@Sale_price", Sale_price),
                 new SqlParameter("@change_Price", change_Price),
                 new SqlParameter("@change_SalePrice", change_SalePrice),
                  new SqlParameter("@Change_Reserve_Price", Change_Reserve_Price),
                 new SqlParameter("@Change_Curency", Change_Curency),
                 new SqlParameter("@New_Product", New_Product),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Hit", Hit),                
                 new SqlParameter("@A_User_Id", A_User_Id),
                 new SqlParameter("@Remarks", Remarks)
                  );


         return Convert.ToString(ret);
     }

     public static void Update_tbl_Packeges(string P_Id, Byte category_Id, String P_Name, String P_Description, decimal P_Price, decimal Reserve_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
          String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, decimal change_Price, decimal change_SalePrice, Decimal Change_Reserve_Price, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, Byte A_User_Id, String Remarks)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Packeges_Update",
                 new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@category_Id", category_Id),
                 new SqlParameter("@P_Name", P_Name),
                 new SqlParameter("@P_Description", P_Description),
                 new SqlParameter("@P_Price", P_Price),
                 new SqlParameter("@Reserve_Price", Reserve_Price),
                 new SqlParameter("@Currency_Id", Currency_Id),
                 new SqlParameter("@Currency", Currency),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Sale_Product", Sale_Product),
                 new SqlParameter("@sale_enddate", sale_enddate),
                 new SqlParameter("@Sale_price", Sale_price),
                 new SqlParameter("@change_Price", change_Price),
                 new SqlParameter("@change_SalePrice", change_SalePrice),
                  new SqlParameter("@Change_Reserve_Price", Change_Reserve_Price),
                 new SqlParameter("@Change_Curency", Change_Curency),
                 new SqlParameter("@New_Product", New_Product),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@A_User_Id", A_User_Id),
                 new SqlParameter("@Remarks", Remarks)
        );

     }

     public static DataSet Get_Packeges_Id_Wise(string P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Tbl_packeges_Id_Wise",
             new SqlParameter("@P_Id", P_Id)
             );
         return ds;
     }

     public static DataSet List_of_Packeges()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Packeges_Select"
             );
         return ds;
     }


     public static DataSet Get_Packege_Category()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Packegae_Category_Select"

             );
         return ds;
     }

     public static DataSet List_of_Package_Categoryid_Wise(Byte Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[sp_PackageCategory_Id_Wise]",
             new SqlParameter("@Category_Id", Categoryid)

             );
         return ds;
     }


     public static string Insert_tbl_Events_Items(Byte Product_Id, Byte Sub_Product_Id, Byte P_Gallery_Id, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty,  Byte Brand_id, Byte Colors_id, Byte A_User_Id, String Remarks)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_tbl_Events_Items_Insert",
                 new SqlParameter("@Product_Id", Product_Id),
                 new SqlParameter("@Sub_Product_Id", Sub_Product_Id),
                 new SqlParameter("@P_Gallery_Id", P_Gallery_Id),        
              
                 new SqlParameter("@P_Name", P_Name),
                 new SqlParameter("@P_Description", P_Description),
                 new SqlParameter("@P_Price", P_Price),
                 new SqlParameter("@Currency_Id", Currency_Id),
                 new SqlParameter("@Currency", Currency),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Sale_Product", Sale_Product),
                 new SqlParameter("@sale_enddate", sale_enddate),
                 new SqlParameter("@Sale_price", Sale_price),
                 new SqlParameter("@Product_Key", Product_Key),
                 new SqlParameter("@change_Price", change_Price),
                 new SqlParameter("@change_SalePrice", change_SalePrice),
                 new SqlParameter("@Change_Curency", Change_Curency),
                 new SqlParameter("@New_Product", New_Product),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@qty", qty),                 
                 new SqlParameter("@Brand_id", Brand_id),
                 new SqlParameter("@Colors_id", Colors_id),
                 new SqlParameter("@A_User_Id", A_User_Id),
                 new SqlParameter("@Remarks", Remarks)
                  );


         return Convert.ToString(ret);
     }


     public static void Update_tbl_Event_Item(string P_Id, Byte Product_Id, Byte Sub_Product_Id, Byte P_Gallery_Id, String P_Name, String P_Description, decimal P_Price, Byte Currency_Id, String Currency, string Filename, string path, String Filename2, String Filename3, String Filename4, String Filename5,
         String Filename6, Boolean Sale_Product, DateTime sale_enddate, decimal Sale_price, string Product_Key, decimal change_Price, decimal change_SalePrice, String Change_Curency, Byte New_Product, Int32 Hit, DateTime Post_Date, byte qty, Byte Brand_id, Byte Colors_id, Byte A_User_Id, String Remarks)
     {

         SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "tbl_Event_Item_Update",

                new SqlParameter("@P_Id", P_Id),
                 new SqlParameter("@Product_Id", Product_Id),
                  new SqlParameter("@Sub_Product_Id", Sub_Product_Id),
                 new SqlParameter("@P_Gallery_Id", P_Gallery_Id),        
                 new SqlParameter("@P_Name", P_Name),
                 new SqlParameter("@P_Description", P_Description),
                 new SqlParameter("@P_Price", P_Price),
                 new SqlParameter("@Currency_Id", Currency_Id),
                 new SqlParameter("@Currency", Currency),
                 new SqlParameter("@Image_Name", Filename),
                 new SqlParameter("@Image_Path", path),
                 new SqlParameter("@Image_Path2", Filename2),
                 new SqlParameter("@Image_Path3", Filename3),
                 new SqlParameter("@Image_Path4", Filename4),
                 new SqlParameter("@Image_Path5", Filename5),
                 new SqlParameter("@Image_Path6", Filename6),
                 new SqlParameter("@Sale_Product", Sale_Product),
                 new SqlParameter("@sale_enddate", sale_enddate),
                 new SqlParameter("@Sale_price", Sale_price),
                 new SqlParameter("@Product_Key", Product_Key),
                 new SqlParameter("@change_Price", change_Price),
                 new SqlParameter("@change_SalePrice", change_SalePrice),
                 new SqlParameter("@Change_Curency", Change_Curency),
                 new SqlParameter("@New_Product", New_Product),
                 new SqlParameter("@Post_Date", Post_Date),
                 new SqlParameter("@Hit", Hit),
                 new SqlParameter("@qty", qty),
                 new SqlParameter("@Brand_id", Brand_id),
                 new SqlParameter("@Colors_id", Colors_id),
                 new SqlParameter("@A_User_Id", A_User_Id),
                 new SqlParameter("@Remarks", Remarks)
        );

     }


     public static DataSet Get_Event_Item_Id_Wise(string P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Tbl_Event_Item_Id_Wise",
             new SqlParameter("@P_Id", P_Id)
             );
         return ds;
     }

     public static DataSet Get_Events_Product()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Events_Product_Select"

             );
         return ds;
     }


     public static DataSet List_of_Event_Items()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Events_Items_Select"
             );
         return ds;
     }

     public static DataSet List_of_Event_Items_Product_Wise(Int32 Categoryid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[sp_Event_Items_Select_Product_Wise]",
             new SqlParameter("@Product_Id", Categoryid)

             );
         return ds;
     }


    //21 jan 2016

     public static DataSet Get_Event_Product_wise_Sub(Int16 CategoryID)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "SpLookup_Event_SubProduct_Select",
             new SqlParameter("@Product", CategoryID)
             );
         return ds;
     }

     public static DataSet Get_Photogallery_Type()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Lookup_Photography_Gallery_Select"

             );
         return ds;
     }

     public static string Insert_Add_tbl_Packege_Detail(Int32 Packege_Id, Int32 P_Id, Int32 Product_Id)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_tbl_Packege_Detai_Insert",
             new SqlParameter("@Packege_Id", Packege_Id),
             new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@Product_Id", Product_Id)

        );
         return Convert.ToString(ret);
     }


     public static DataSet Get_Packege_Wise_Detail(string P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Packege_Id_Wise_Detail",
             new SqlParameter("@Packege_Id", P_Id)
             );
         return ds;
     }

     public static DataSet Get_Packege_Wise_Detail(Int32 P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_Packege_Id_Wise_Detail",
           new SqlParameter("@Packege_Id", P_Id)
             );
         return ds;
     }

     public static DataSet Get_Top12_Venue()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Get_top12_Venue"

             );
         return ds;
     }



     public static DataSet Get_Packge_Category_Wise(Byte CategoryId)

     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Get_top12_Packege",
           new SqlParameter("@Category_Id", CategoryId)
             );
         return ds;
     }


     public static string Insert_Add_Event_Product(string P_Name, String P_Description, String Image_Name, string Image_Path)
     {
         object ret;
         ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Lookup_Event_Product_Insert",
             new SqlParameter("@P_Name", P_Name),
             new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
              new SqlParameter("@Image_Path", Image_Path)
               


        );
         return Convert.ToString(ret);
     }


     public static void Update_Event_Product(string P_Id, string P_Name, String P_Description, String Image_Name, string Image_Path)
    {
 
          SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Lookup_Event_Product_Update",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@P_Description", P_Description),
            new SqlParameter("@Image_Name", Image_Name),
            new SqlParameter("@Image_Path", Image_Path)
  
            );
    }

     public static DataSet Get_Event_Product_Id_Wise(string P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "LookUp_Event_Product_Id_Wise",
             new SqlParameter("@P_Id", P_Id)
             );
         return ds;
     }


     public static DataSet Get_Lookup_Event_Product()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_LookUp_Event_Product_list"
           
             );
         return ds;
     }

     public static DataSet Get_Event_Product_List()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Get_Event_Product_List"

             );
         return ds;
     }


     public static DataSet Get_Event_Product_List_Product_Wise(Int32 P_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_get_Event_Product_Item_Detail",
             new SqlParameter("@P_Id", P_Id)
             );
         return ds;
     }

     public static DataSet Get_get_Product_Packege_Id_Wise(String  Packege_Id, Byte Product_Id)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_get_Product_Packege_Id_Wise",
             new SqlParameter("@Packege_Id", Packege_Id),
                new SqlParameter("@Product_Id", Product_Id)


             );
         return ds;
     }


     public static DataSet Get_Top3_Venue()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Get_top3_Venue"

             );
         return ds;
     }

     public static DataSet Get_Top3_Packeges()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Get_top3_Packeges"

             );
         return ds;
     }

     public static DataSet List_of_Tbl_News_Home()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "sp_News_Feature_Select_Home"
             );
         return ds;
     }


     public static DataSet Get_News_Popular()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_News_Popular_wise"
                     );
         return ds;
     }

     public static DataSet Get_Collect_Point(Int32 Cid)
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "Sp_Collect_Point_Countrywise",
             new SqlParameter("@Country_Id", Cid)
             );
         return ds;
     }
     public static DataSet Get_Collect_Point()
     {
         DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
             CommandType.StoredProcedure,
             "[Sp_Collect_Point]"

             );
         return ds;
     }

          ///dynamic slider
    public static DataSet List_of_Slider_Image()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Slider_Select"
            );
        return ds;
    }


    public static void Update_tbl_Slider(string P_Id, String P_Name, String Image_Name, string Filename1, String Filename2, String Filename3, String Filename4, String Filename5, String Filename6, string Filename7, String Filename8, String Filename9, String Filename10, String Filename11, String Filename12,
        String Cap1, String Cap2, String Cap3, String Cap4, String Cap5, String Cap6, String Title1, String Title2, String Title3, String Title4, String Title5, String Title6)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "lookup_Slider_Update",
            new SqlParameter("@P_Id", P_Id),
          new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@Image_Name", Image_Name),
            new SqlParameter("@Image_Path", Filename1),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),

            new SqlParameter("@Image_Path7", Filename7),
            new SqlParameter("@Image_Path8", Filename8),
            new SqlParameter("@Image_Path9", Filename9),
            new SqlParameter("@Image_Path10", Filename10),
            new SqlParameter("@Image_Path11", Filename11),
            new SqlParameter("@Image_Path12", Filename12),



           new SqlParameter("@Cap1", Cap1),
           new SqlParameter("@Cap2", Cap2),
           new SqlParameter("@Cap3", Cap3),
           new SqlParameter("@Cap4", Cap4),
           new SqlParameter("@Cap5", Cap5),
           new SqlParameter("@Cap6", Cap6),
           new SqlParameter("@Cap7", Title1),
           new SqlParameter("@Cap8", Title2),
           new SqlParameter("@Cap9", Title3),
           new SqlParameter("@Cap10", Title4),
           new SqlParameter("@Cap11", Title5),
           new SqlParameter("@Cap12", Title6)

       );

    }

    public static DataSet Get_Slider_Id_Wise(string Brand_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Slider_Id_Wise",
            new SqlParameter("@P_Id", Brand_Id)
            );
        return ds;
    }


    public static string Insert_tbl_Slider(String P_Name, String Image_Name,string Filename1, String Filename2, String Filename3, String Filename4, String Filename5, String Filename6, string Filename7, String Filename8, String Filename9, String Filename10, String Filename11, String Filename12,
        String Cap1, String Cap2, String Cap3, String Cap4, String Cap5, String Cap6, String Title1, String Title2, String Title3, String Title4, String Title5, String Title6)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_lookup_Slider_Insert",
           
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@Image_Name", Image_Name),
            new SqlParameter("@Image_Path", Filename1),
            new SqlParameter("@Image_Path2", Filename2),
            new SqlParameter("@Image_Path3", Filename3),
            new SqlParameter("@Image_Path4", Filename4),
            new SqlParameter("@Image_Path5", Filename5),
            new SqlParameter("@Image_Path6", Filename6),

            new SqlParameter("@Image_Path7", Filename7),
            new SqlParameter("@Image_Path8", Filename8),
            new SqlParameter("@Image_Path9", Filename9),
            new SqlParameter("@Image_Path10", Filename10),
            new SqlParameter("@Image_Path11", Filename11),
            new SqlParameter("@Image_Path12", Filename12),



           new SqlParameter("@Cap1", Cap1),
           new SqlParameter("@Cap2", Cap2),
           new SqlParameter("@Cap3", Cap3),
           new SqlParameter("@Cap4", Cap4),
           new SqlParameter("@Cap5", Cap5),
           new SqlParameter("@Cap6", Cap6),
           new SqlParameter("@Cap7", Title1),
           new SqlParameter("@Cap8", Title2),
           new SqlParameter("@Cap9", Title3),
           new SqlParameter("@Cap10", Title4),
           new SqlParameter("@Cap11", Title5),
           new SqlParameter("@Cap12", Title6)

       );
        return Convert.ToString(ret);
    }

    //Dynamic Slider

    public static DataSet Get_Show_Id_P_Wise(Byte PId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Top_5_ID_P_Wise",
            new SqlParameter("@productId", PId)

            );
        return ds;
    }

    public static DataSet Get_Home_Page_Id_Wise_P_wise(string P_Id,Byte Productid)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_Home_Page_Id_p_Wise",
            new SqlParameter("@P_Id", P_Id),
            new SqlParameter("@product", Productid)
            );
        return ds;
    }
    //28 April

    public static DataSet Get_Bag_Other_Topdata()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Nappies_Other_Top_Data"


            );
        return ds;
    }

    public static DataSet List_of_Home_Page_Data_Category_Wise(Int32 PId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_all_Cat_wise_Homepage_Data",
            new SqlParameter("@catid", PId)
            );
        return ds;
    }

    public static DataSet Get_Iteam_Product_Wise(Byte Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
           CommandType.StoredProcedure,
           "Sp_Item_Product_Wise",
           new SqlParameter("@Product_Id", Product_Id)
           );
        return ds;
    }
    public static string OiiO_User_Insert(Int32 UserGroupID, String First_Name, String Last_Name, String LoginName, String LoginPassword, String Salt,
    Int32 CreatedBy, DateTime CreatedDate, DateTime ModifiedDate, DateTime dob, Byte title_id, Byte U_Gender)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_OiiO_User_Insert",
            new SqlParameter("@UserGroupID", UserGroupID),
           new SqlParameter("@First_Name", First_Name),
            new SqlParameter("@Last_Name", Last_Name),
            new SqlParameter("@LoginName", LoginName),
             new SqlParameter("@LoginPassword", LoginPassword),
              new SqlParameter("@Salt", Salt),
          
            new SqlParameter("@CreatedBy", CreatedBy),
            new SqlParameter("@CreatedDate", CreatedDate),
          
            new SqlParameter("@ModifiedDate", ModifiedDate),

              new SqlParameter("@U_Gender", U_Gender),
              new SqlParameter("@dob", dob),
              new SqlParameter("@title_id", title_id)
       );
        return Convert.ToString(ret);
    }

    public static string Insert_Sp_UserInfo_Save_Product(Int32 UserID, String UserName, String P_Name, Int32 Item_Id, Int32 Product_Id, DateTime Post_Date)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_UserInfo_Save_Product_Insert",
            new SqlParameter("@UserID", UserID),
           new SqlParameter("@UserName", UserName),
            new SqlParameter("@P_Name", P_Name),
            new SqlParameter("@Item_Id", Item_Id),
            new SqlParameter("@Product_Id", Product_Id),
             new SqlParameter("@Post_Date", Post_Date)


       );
        return Convert.ToString(ret);
    }


    public static DataSet Get_save_it_not(Int32 UserID, Int32 Item_Id, Int32 Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_chek_product_Save",
            new SqlParameter("@UserID", UserID),
             new SqlParameter("@Item_Id", Item_Id),
              new SqlParameter("@Product_Id", Product_Id)
            );
        return ds;
    }

    public static string Insert_tbl_User_Comments(Int32 P_Item_Id, Int32 UserId, Int32 Product_Id, String Contact_Person, String Email, String Phone, String Mobile, String C_description, Byte C_status, DateTime C_Date, Byte C_Rating, String U_Image, String Session_Id)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_tbl_user_Comment_Insert",
            new SqlParameter("@UserId", UserId),
               new SqlParameter("@P_Item_Id", P_Item_Id),
           new SqlParameter("@Product_Id", Product_Id),
            new SqlParameter("@Contact_Person", Contact_Person),
            new SqlParameter("@Email", Email),
            new SqlParameter("@Phone", Phone),
             new SqlParameter("@Mobile", Mobile),
             new SqlParameter("@C_description", C_description),
            new SqlParameter("@C_status", C_status),
            new SqlParameter("@C_Date", C_Date),
            new SqlParameter("@C_Rating", C_Rating),
            new SqlParameter("@U_Image", U_Image),
            new SqlParameter("@Session_Id", Session_Id)


       );
        return Convert.ToString(ret);
    }


    public static void Update_tbl_user_Comment(string Id, Int32 P_Item_Id, Int32 UserId, Int32 Product_Id, String Contact_Person, String Email, String Phone, String Mobile, String C_description, Byte C_status, DateTime C_Date, Byte C_Rating, String U_Image, String Session_Id)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "tbl_user_Comment_Update",
            new SqlParameter("@Id", Id),
            new SqlParameter("@UserId", UserId),
               new SqlParameter("@P_Item_Id", P_Item_Id),
           new SqlParameter("@Product_Id", Product_Id),
            new SqlParameter("@Contact_Person", Contact_Person),
            new SqlParameter("@Email", Email),
            new SqlParameter("@Phone", Phone),
             new SqlParameter("@Mobile", Mobile),
             new SqlParameter("@C_description", C_description),
            new SqlParameter("@C_status", C_status),
            new SqlParameter("@C_Date", C_Date),
            new SqlParameter("@C_Rating", C_Rating),
            new SqlParameter("@U_Image", U_Image),
            new SqlParameter("@Session_Id", Session_Id)
       );

    }


    public static DataSet Get_chek_Comment_User_Id_Wise(Int32 Userid, Int32 P_Item_Id, Int32 Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_chek_Comment_User_Id_Wise",
            new SqlParameter("@UserID", Userid),
              new SqlParameter("@P_Item_Id", P_Item_Id),
                new SqlParameter("@Product_Id", Product_Id)
            );
        return ds;
    }


    public static DataSet Get_chek_Comment_Session_Id_Wise(Int32 P_Item_Id, Int32 Product_Id, String Session_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_chek_Comment_Session_Id_Wise",

              new SqlParameter("@Item_Id", P_Item_Id),
                new SqlParameter("@Product_Id", Product_Id),
                  new SqlParameter("@Session_Id", Session_Id)
            );
        return ds;
    }


    public static DataSet Get_user_commentlist(string P_Item_id, Int32 Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_get_Data_usercommentlist",
                new SqlParameter("@P_Item_id", P_Item_id),
                    new SqlParameter("@Product_Id", Product_Id)

            );
        return ds;
    }
    public static DataSet Get_offer_Check(string P_Id, String Product_Id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "[sp_offer_Check]",
            new SqlParameter("@P_Id", P_Id),
               new SqlParameter("@Product_Id", Product_Id)
            );
        return ds;
    }


    public static void Update_user_Password(String LoginName, String LoginPassword)
    {

        SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_Update_User_Password",
            new SqlParameter("@LoginName", LoginName),
             new SqlParameter("@LoginPassword", LoginPassword)
            );
    }


    



    ///BY Abdus Salam
    ///
    public static DataSet UserProfile(long id)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_User_Id_Wise",
         new SqlParameter("@IID", id)
            );
        return ds;
    }
    public static DataSet IsUserAgreeToShowProfile(long uId, long dId)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_UserDomainAgreement",
            new SqlParameter("@UId", uId),
            new SqlParameter("@DId", dId)
            );
        return ds;
    }
    public static DataSet List_of_Domain()
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_select_Domain"
            );
        return ds;
    }

    public static DataSet MatchDomainSecret(string url, string secret)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "sp_MatchDomainSecret",
            new SqlParameter("@Url", url),
            new SqlParameter("@Secret", secret)
            );
        return ds;
    }
    public static string OiiO_Domain_Insert(long Id, string domain, string secretChar)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_OiiO_Domain_Insert",
            new SqlParameter("@Id", Id),
           new SqlParameter("@Name", domain),
            new SqlParameter("@SecretChar", secretChar),
            new SqlParameter("@RegDate", DateTime.UtcNow.Date)
       );
        return Convert.ToString(ret);
    }

    public static string OiiO_UDAgreement_Insert(long Id, long userId, long domainId)
    {
        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Sp_OiiO_UserDomainAgreement_Insert",
            new SqlParameter("@Id", Id),
           new SqlParameter("@UId", userId),
            new SqlParameter("@DId", domainId),
            new SqlParameter("@ADate", DateTime.UtcNow.Date)
       );
        return Convert.ToString(ret);
    }
    ////By Abdus Salam


}


