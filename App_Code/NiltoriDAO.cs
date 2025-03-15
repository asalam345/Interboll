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
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;

/// <summary>
/// Summary description for NiltoriDAO
/// </summary>

    public class NiltoriDAO : DAL.BaseClass
{
        //public NiltoriDAO()
        //    : base(ConfigurationManager.AppSettings["cnStr"])
        public NiltoriDAO()
            : base(WebsiteConfig.ConnectionString)
	{
        //new SqlConnection(WebsiteConfig.ConnectionString),
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetProductType(Int16 subCategory)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@SubCategoryID", subCategory));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Display", arrParam);
    }
    public DataTable Get_Event_Id(Int16 Event_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Holiday_Event_Id", Event_Id));
        return this.ExecuteStoredProcedureDataTable("sp_Holiday_Event_Id_Display", arrParam);
    }

    public DataTable Get_Sports_Event_Id(Int16 Event_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Sports_Title_Id", Event_Id));
        return this.ExecuteStoredProcedureDataTable("sp_sports_Event_Id_Display", arrParam);
    }

    public DataTable GetProductType_Lingere()
    {

        ArrayList arrParam = new ArrayList();
       // arrParam.Add(new SqlParameter("@SubCategoryID", subCategory));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Lingere", arrParam);
    }



    public DataTable GetProductType_Product_Wise_product(byte product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Product_Wise", arrParam);
    }



    public DataTable GetProductType_Product_Sub_product_wise(byte product, Byte Sub_Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Sub_Product ", Sub_Product));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Sub_Product_Wise", arrParam);
    }



    public DataTable GetProductType_Sub_product_wise(Byte Sub_Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Sub_Product ", Sub_Product));
        return this.ExecuteStoredProcedureDataTable("sp_Data_Sub_Product_Wise", arrParam);
    }




    public DataTable GetProductType_Gift_Wise()
    {

        ArrayList arrParam = new ArrayList();
        //arrParam.Add(new SqlParameter("@product", product));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Gift_Wise", arrParam);
    }

    public DataTable GetProductType_Cat_Wise_product(byte product, String Cat_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Cat_Id ", Cat_Id));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Cat_Wise", arrParam);
    }
    public DataTable GetProductType_Product_Wise_product_For_Sale()
    {

        ArrayList arrParam = new ArrayList();
      //  arrParam.Add(new SqlParameter("@product", product));
        return this.ExecuteStoredProcedureDataTable("Sp_get_sale_for_Home_Page", arrParam);
    }


    public DataTable GetProductType_Wise_Sale_Product_Wise(string productid)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", productid));
        return this.ExecuteStoredProcedureDataTable("Sp_get_sale_for_Product_Page", arrParam);
    }

    public DataTable GetProductType_new_Product(string productid)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", productid));
        return this.ExecuteStoredProcedureDataTable("Sp_get_new_Product", arrParam);
    }


    public DataTable GetProductType_new_Product_All()
    {

        ArrayList arrParam = new ArrayList();
        //arrParam.Add(new SqlParameter("@product", productid));
        return this.ExecuteStoredProcedureDataTable("Sp_get_new_Product_All", arrParam);
    }


    public DataTable Get_Category_Brand(Int16 subCategory)
    {

        ArrayList arrParam = new ArrayList();
         arrParam.Add(new SqlParameter("@SubCategoryID", subCategory));
   
        return this.ExecuteStoredProcedureDataTable("Sp_LookUp_Sub_Category_Brands", arrParam);
    }
    public DataTable Get_Category_Brand()
    {

        ArrayList arrParam = new ArrayList();
        //arrParam.Add(new SqlParameter("@SubCategoryID", subCategory));

        return this.ExecuteStoredProcedureDataTable("Sp_LookUp_Sub_Category_Brands", arrParam);
    }
    public DataTable Get_Category_Product()
    {

        ArrayList arrParam = new ArrayList();

        return this.ExecuteStoredProcedureDataTable("Sp_LookUp_Sub_Category_Product", arrParam);
    }

    public DataTable Get_Category_Brasize()
    {

        ArrayList arrParam = new ArrayList();

        return this.ExecuteStoredProcedureDataTable("Sp_LookUp_Sub_Category_Bra_Size", arrParam);
    }
        
  


    public static string Update_ProductTable(String hidArticleId, String ProductID, String SubCategoryID, String Description, String Price, String Currency, String Image_NameAndPath, Boolean New_Product, Boolean Special_Product, Boolean Featured_Product, String Occasional, String Discount)
    {

        object ret;
        ret = SqlHelper.ExecuteScalar(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Product_Update",
            // new SqlParameter("@MemberId", MemberId),
            new SqlParameter("@hidArticleId", hidArticleId),
             new SqlParameter("@SubCategoryID", SubCategoryID),
            new SqlParameter("@Description", Description),
            new SqlParameter("@Price", Price),
            new SqlParameter("@Currency", Currency),
            new SqlParameter("@Image_NameAndPath", Image_NameAndPath),
            new SqlParameter("@New_Product", New_Product),
            new SqlParameter("@Special_Product", Special_Product),

            new SqlParameter("@Featured_Product", Featured_Product),
            new SqlParameter("@Occasional", Occasional),
            new SqlParameter("@Discount", Discount)
           

       );
        return Convert.ToString(ret);
    }
    public static DataSet Get_ProductID(String ProductID)
    {
        DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
            CommandType.StoredProcedure,
            "Product_Select_Product_Tb",
            new SqlParameter("@Id", ProductID)
            );
        return ds;
    }

    public DataTable sp_get_Search_Top(Int32 topid)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Toop_Id", topid));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top", arrParam);
    }

    public DataTable sp_get_Search_Top_Product_Wise(Int32 topid, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Toop_Id", topid));
        arrParam.Add(new SqlParameter("@Product", Product));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_product_Wise", arrParam);
    }

    public DataTable sp_get_Search_Top_Product_Wise_for_Sale(Int32 topid)
    {
        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Toop_Id", topid));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_product_Wise_For_Sale", arrParam);
    }

    public DataTable sp_get_Search_Top_Product_Wise_For_Bra(String B_size_Name,  Byte topid)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@B_size_Name", B_size_Name));
        arrParam.Add(new SqlParameter("@Toop_Id", topid));
     
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_product_Wise_For_Bra", arrParam);
    }

    public DataTable sp_get_Search_Top_Product_Wise_For_Menu(String Tag_Name, Byte topid, Byte product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Tag_Name", Tag_Name));
        arrParam.Add(new SqlParameter("@Toop_Id", topid));
        arrParam.Add(new SqlParameter("@product", product));

        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_product_Wise_For_Menu", arrParam);
    }

    //sp_get_Search_Top_product_Wise_For_Menu










    public DataTable sp_get_Search_Top_Night(Int32 topid)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Toop_Id", topid));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_Night", arrParam);
    }

    public DataTable sp_get_Search_Asc(Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc", arrParam);
    }

    public DataTable sp_get_Search_Asc_Product_Wise(Int32 Asc, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        arrParam.Add(new SqlParameter("@Product", Product));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_product_Wise", arrParam);
    }

    public DataTable sp_get_Search_Asc_Product_gift_Wise(Int32 Asc, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        arrParam.Add(new SqlParameter("@Product", Product));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_product_Gift_Wise", arrParam);
    }

    public DataTable sp_get_Search_Price_Between(Decimal firstprice, Decimal secondprice, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@firstprice", firstprice));
        arrParam.Add(new SqlParameter("@secondprice ", secondprice));
        arrParam.Add(new SqlParameter("@Product", Product));
        return this.ExecuteStoredProcedureDataTable("price_wise_product", arrParam);
    }

    public DataTable sp_get_Search_Price_Between_Gift_wise(Decimal firstprice, Decimal secondprice, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@firstprice", firstprice));
        arrParam.Add(new SqlParameter("@secondprice ", secondprice));
        arrParam.Add(new SqlParameter("@Product", Product));
        return this.ExecuteStoredProcedureDataTable("price_wise_product_gift", arrParam);
    }
    public DataTable sp_get_Search_Asc_Product_Wise_For_Sale(Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));

        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_product_Wise_For_Sale", arrParam);
    }

//sp_get_Search_Top_product_Wise_For_Bra_asc

    public DataTable sp_get_Search_Asc_Product_Wise_For_Bra(String B_size_Name, Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@B_size_Name", B_size_Name));
        arrParam.Add(new SqlParameter("@Asc", Asc));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_product_Wise_For_Bra_asc", arrParam);
    }


    public DataTable sp_get_Search_Asc_Product_Wise_For_menue(String Tag_Name, Int32 Asc, byte product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Tag_Name", Tag_Name));
        arrParam.Add(new SqlParameter("@Asc", Asc));
        arrParam.Add(new SqlParameter("@product", product));

        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_product_Wise_For_Menu", arrParam);
    }

    public DataTable sp_get_Search_Brand(Byte  product,Int32 Subproduct)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Subproduct", Subproduct));
        return this.ExecuteStoredProcedureDataTable("sp_Serch_Sub_Cat_Wise", arrParam);
    }

    public DataTable sp_get_Search_Brand_Gift_Wise(Byte product, Int32 Subproduct)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Subproduct", Subproduct));
        return this.ExecuteStoredProcedureDataTable("sp_Serch_Sub_Cat_gift_Wise", arrParam);
    }

    public DataTable sp_get_Search_Brand_For_Sale(Int32 Subproduct)
    {

        ArrayList arrParam = new ArrayList();        
        arrParam.Add(new SqlParameter("@Subproduct", Subproduct));
        return this.ExecuteStoredProcedureDataTable("sp_Serch_Sub_Cat_Wise_for_Sale", arrParam);
    }



    public DataTable sp_get_Search_Brand_For_Bra(String B_size_Name, Int32 SuCat)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@B_size_Name", B_size_Name));
        arrParam.Add(new SqlParameter("@SuCat", SuCat));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Top_product_Wise_Brand_For_Bra", arrParam);
    }

        //sp_get_Search_product_Wise_Brand_For_Menu

    public DataTable sp_get_Search_Brand_menu_Wise(String Tag_Name, Int32 SuCat, Byte product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Tag_Name", Tag_Name));
        arrParam.Add(new SqlParameter("@SuCat", SuCat));
        arrParam.Add(new SqlParameter("@product", product));

        return this.ExecuteStoredProcedureDataTable("sp_get_Search_product_Wise_Brand_For_Menu", arrParam);
    }



    public DataTable sp_get_Search_Asc_Cloth(Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_cloth", arrParam);
    }


    public DataTable sp_get_Search_Asc_Panties(Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_panties", arrParam);
    }
    public DataTable sp_get_Search_Asc_Swim(Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_Swim", arrParam);
    }

    public DataTable sp_get_Search_Asc_Hos(Int32 Asc)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        return this.ExecuteStoredProcedureDataTable("sp_get_Search_Asc_Hos", arrParam);
    }

    public DataTable sp_get_Search_Asc_Sports(Int32 Asc, Int32 Sports_Title_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        arrParam.Add(new SqlParameter("@Sports_Title_Id", Sports_Title_Id));

        
        return this.ExecuteStoredProcedureDataTable("sp_get_Sports_Search_Asc_Sports", arrParam);
    }
    public DataTable sp_get_Search_Asc_Holiday(Int32 Asc, Int32 Holiday_Event_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@asc", Asc));
        arrParam.Add(new SqlParameter("@Holiday_Event_Id", Holiday_Event_Id));
        return this.ExecuteStoredProcedureDataTable("sp_get_Sports_Search_Asc_Holliday", arrParam);
    }

  

    public DataTable sp_get_Search_All(String SearchId,Int32 CategoryID)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@sbid", SearchId));
        arrParam.Add(new SqlParameter("@CategoryID", SearchId));
        return this.ExecuteStoredProcedureDataTable("sp_search_product", arrParam);
    }


   

   


   

    public DataTable Get_serch_Submenuwise_product(string tagname, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@sbid", tagname));
        arrParam.Add(new SqlParameter("@product", Product));
        return this.ExecuteStoredProcedureDataTable("sp_serch_product_Submenu_wise", arrParam);
    }



    public DataTable Get_serch_Submenuwise_product_newitem(string tagname, Byte Product)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@sbid", tagname));
        arrParam.Add(new SqlParameter("@product", Product));
        return this.ExecuteStoredProcedureDataTable("sp_serch_product_Submenu_wise_new_product", arrParam);
    }
    public DataTable Get_Search_Site(String searchString)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@searchString", searchString));

        return this.ExecuteStoredProcedureDataTable("sp_search_oiio_site", arrParam);
    }


//Product+Subproduct+Brand
    public DataTable GetProductType_Product_Sub_product_Brand_wise(byte product, Byte Sub_Product, Byte Brand)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Sub_Product", Sub_Product));
        arrParam.Add(new SqlParameter("@Brand", Brand));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Sub_Product_Brand_Wise", arrParam);
    }

    //Brand Data
    public DataTable GetProduc_Brand_wise(Byte Brand)
    {

        ArrayList arrParam = new ArrayList(); 
        arrParam.Add(new SqlParameter("@Brand", Brand));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Brand_Wise", arrParam);
    }


  
        
    //public static DataSet Get_New_Arrival_Home()
    //{
    //    DataSet ds = SqlHelper.ExecuteDataset(new SqlConnection(WebsiteConfig.ConnectionString),
    //        CommandType.StoredProcedure,
    //        "Sptbl_Langerie_Select_For_Home"

    //        );
    //    return ds;
    //}


    //public DataTable sp_get_Search_Top_sports(Int32 topid)
    //{

    //    ArrayList arrParam = new ArrayList();
    //    arrParam.Add(new SqlParameter("@Toop_Id", topid));
    //    return this.ExecuteStoredProcedureDataTable("[sp_get_Search_Top_Holiday]", arrParam);
    //}

        //category + Subcat+ Subcategory ..wise data

  


    //Product + category  ..wise data---Category Wise..data

    public DataTable Getdata_Product_Category(byte product, Byte Category)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Category", Category));
        return this.ExecuteStoredProcedureDataTable("sp_Item_Product_Category_Wise", arrParam);

    }


    //Product + category  ..wise data -subcloth+Football/Rugby

    public DataTable Getdata_Product_Category_Subcloth(byte product, Byte Category, Byte subcloth)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Category", Category));
        arrParam.Add(new SqlParameter("@subcloth", subcloth));
        return this.ExecuteStoredProcedureDataTable("sp_Item_Product_Category_sub_Cloth_Wise", arrParam);

    }

//Category+Brand
    public DataTable Get_category_Brand_wise( Byte Category, Byte Brand)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Category", Category));
        arrParam.Add(new SqlParameter("@Brand", Brand));
        return this.ExecuteStoredProcedureDataTable("sp_Category_Brand_Wise", arrParam);
    }


        //hee+

    public DataTable GetProductType_Recipent_wise(Byte product_Id, String Category_Id, Byte P_Type_Id, Byte Recipient)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product_Id", product_Id));
        arrParam.Add(new SqlParameter("@Category_Id", Category_Id));
        arrParam.Add(new SqlParameter("@Type_ID", P_Type_Id));
        arrParam.Add(new SqlParameter("@Recipient", Recipient));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Type_Recipient_Wise", arrParam);
    }


    //Product+Category+Occation Wise

    public DataTable GetProduct_Category_Occasion_wise(Byte product_Id, Byte Category_ID, Byte Occasion)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product_Id", product_Id));
        arrParam.Add(new SqlParameter("@Category_ID", Category_ID));
        arrParam.Add(new SqlParameter("@Occasion", Occasion));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Occasion_Wise", arrParam);
    }



    //Occasion wise
  




    public DataTable GetProductType_wise_Gift(Byte product_Id, Byte P_Type_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product_Id", product_Id));
        arrParam.Add(new SqlParameter("@Type_ID", P_Type_Id));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Type_Wise_Gift", arrParam);
    }


    //Product+Occation Wise

    public DataTable GetProduct_Occasion_wise(Byte product_Id, Byte Occasion)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product_Id", product_Id));
        arrParam.Add(new SqlParameter("@Occasion_Id", Occasion));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Occasion_Wise_Gift", arrParam);
    }

    /// 

    public DataTable Get_Occasion_Recipent_wise(Byte Occasion,  Byte Recipient)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@Occasion", Occasion));
        arrParam.Add(new SqlParameter("@Recipient", Recipient));   
    
        return this.ExecuteStoredProcedureDataTable("sp_Occasion_Recipient_Wise", arrParam);
    }

        //  for  Wedlock
    public DataTable Getdata_Product_Category_Wise_Price(Decimal firstprice,Decimal secondprice, byte product, Byte Category)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@firstprice", firstprice));
        arrParam.Add(new SqlParameter("@secondprice", secondprice));
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Category", Category));
        return this.ExecuteStoredProcedureDataTable("price_wise_product", arrParam);

    }

    public DataTable GetProductType_Product_Category_silhouette(byte silhouette_Id, byte product, Byte Category, Byte Parameter)
    {

        ArrayList arrParam = new ArrayList();
 
        arrParam.Add(new SqlParameter("@silhouette_Id", silhouette_Id));
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Category", Category));
        arrParam.Add(new SqlParameter("@para", Parameter));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Category_silhouette_Wise", arrParam);
    }

        //18 jan....product_category+Subcat+...
    public DataTable Get_SubCat_Wise_Product_Category_wise(Byte product, Byte Category, Byte Sub_Category_Id)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Category ", Category));
        arrParam.Add(new SqlParameter("@Sub_Category_Id", Sub_Category_Id));
        return this.ExecuteStoredProcedureDataTable("Subcat_wise_product", arrParam);
    }


    public DataTable Getdata_Product_Sub_Category_Wise_Price(Decimal firstprice, Decimal secondprice, byte product, Byte Category)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@firstprice", firstprice));
        arrParam.Add(new SqlParameter("@secondprice", secondprice));
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Sub_Category_Id ", Category));
        return this.ExecuteStoredProcedureDataTable("price_wise_SubCategory_product", arrParam);

    }


    public DataTable GetProductType_Product_sub_Category_silhouette(byte silhouette_Id, byte product, Byte Sub_Category_Id, Byte Parameter)
    {

        ArrayList arrParam = new ArrayList();

        arrParam.Add(new SqlParameter("@silhouette_Id", silhouette_Id));
        arrParam.Add(new SqlParameter("@product", product));
        arrParam.Add(new SqlParameter("@Sub_Category_Id", Sub_Category_Id));
        arrParam.Add(new SqlParameter("@para", Parameter));
        return this.ExecuteStoredProcedureDataTable("sp_Product_Sub_Category_silhouette_Wise", arrParam);
    }

    public DataTable Get_user_Saved_Product(Int32 UserID)
    {

        ArrayList arrParam = new ArrayList();
        arrParam.Add(new SqlParameter("@UserID", UserID));

        return this.ExecuteStoredProcedureDataTable("sp_Product_user_choice", arrParam);
    }

}
