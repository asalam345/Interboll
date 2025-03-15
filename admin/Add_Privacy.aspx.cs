using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Globalization;

public partial class admin_Add_Privacy : System.Web.UI.Page
{
    string filename;
    string filename1;
    String path;

    String P_Id;
    Byte Category_Id;
    String P_Name;
    String P_Description;
    String Image_Name;
    String C_Name;
    String P_Url;
    Byte P_Status;
    Byte P_Sl;
    Byte Segment;
    DateTime Post_Date;
    protected void Page_Load(object sender, EventArgs e)
    {
        string x = Session["UserGroupID"].ToString();

        if (x == "90")
        {
            if (!Page.IsPostBack)
            {



                ShowArticle1();
                //sale.Visible = false;
            }

        }
        else
        {
            Response.Redirect("~/Default.aspx");

        }
    }


    private void ResetForNewArticle()
    {
        hidArticleId.Value = "";
        txtTitle.Text = "";
        post.InnerHtml = "";



    }

    private string MakeAlias(string text)
    {
        if (text.Trim() == "")
            text = txtTitle.Text;

        return BaseUtility.FormatTextToUrl(text);
    }

    private void SaveArticle()
    {
        #region photo
        byte Photo_Status = Convert.ToByte(dlphotostat1.SelectedItem.Value);

        if (Photo_Status == 0)
        {

            if (fileUpload1.HasFile)
            {

                string imagename = fileUpload1.PostedFile.FileName;
                //  string fileExtension = System.IO.Path.GetExtension(imagename);
                // string fname = System.IO.Path.GetFileName(imagename);

                string lok1 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;

                fileUpload1.SaveAs(Server.MapPath("../images/Add/" + lok1));
                filename = imagename;
                path = ("images/Add/" + lok1);
                //

            }
            else
            {
                filename = lblImageurl.Text;
                path = filename;
            }
        }

        else
        {

            filename = "";
            path = "";


        }

        Category_Id = 0;// Convert.ToByte(ddlType.SelectedItem.Value);
        P_Name = txtTitle.Text;
        P_Description = post.InnerText;// txtContents.InnerText;
        Image_Name = path;
        C_Name = txtCname.Text;
        P_Url = txtUrl.Text;
        P_Status = 1;




        #endregion



        Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());



        string caption = txtCaptionimg1.Text;

        P_Name = txtTitle.Text;


        string x = txtsl.Text;
        if (x == "")
        {
            P_Sl = 90;
        }
        else
        {
            P_Sl = Convert.ToByte(txtsl.Text);
        }

        Segment = 0;// Convert.ToByte(log_Combo.SelectedItem.Value);


        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Add_Privacy(hidArticleId.Value, Category_Id, P_Name, P_Description, Image_Name, C_Name, P_Url, P_Status, P_Sl, Post_Date, Segment);
        }
        else
        {
            // add as a new article
            string articleId = ClPost.Insert_tbl_Add_Item_Privacy(Category_Id, P_Name, P_Description, Image_Name, C_Name, P_Url, P_Status, P_Sl, Post_Date, Segment);


        }
    }

    private decimal ToDecimal(string Value)
    {
        if (Value.Length == 0)
            return 0;
        else
            return Decimal.Parse(Value.Replace(" ", ""), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        SaveArticle();

        Response.Redirect("Manage_Privacy.aspx");
    }



    private void ShowArticle1()
    {

        P_Id = Request.QueryString["P_Id"];
        if (P_Id != null)
        {
            ShowAdata();

            lit1.Text = "Edit Items";
            lit2.Text = "Edit Items";

        }       //

        else
        {

            ResetForNewArticle();
            lit1.Text = "Add Items";
            lit2.Text = "Add Items";
        }
    }

    private void ShowAdata()
    {
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy(P_Id);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);
            txtTitle.Text = Convert.ToString(row["P_Name"]);
            post.InnerHtml = Convert.ToString(row["P_Description"]);
            txtCname.Text = Convert.ToString(row["C_Name"]);
            txtUrl.Text = Convert.ToString(row["P_Url"]);
            P_Status = Convert.ToByte(row["P_Status"]);


            string Image = Convert.ToString(ds.Tables[0].Rows[0]["Image_Name"]);

            txtsl.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Sl"]);
            Category_Id = Convert.ToByte(row["Category_Id"]);
            Segment = Convert.ToByte(row["Segment"]);


            //

            lblImageurl.Text = Image;
            //

            Image2.ImageUrl = "../" + Image;


        }
    }






    //
}



