using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DAL;
using BLL;

public partial class EditPost1 : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    Byte Likeid1;
    Byte V_Status;

    String ImagePostid;
    String PostImage;
    String P_Image;
    Int32 PostId;
    string Fast;
    Byte F_Status;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }

            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                PostId = Convert.ToInt32(StringCipher.Decrypt(Request.QueryString["ID"]).ToString());
                // Int32 PostId1 = Convert.ToInt32(StringCipher.Decrypt(Request.QueryString["ID1"]).ToString());

                Session["PostId"] = PostId.ToString();
            }
            else
            {
                // Response.Redirect("~/Mortgages.aspx", false);
            }


            loadpost();


        }



    }



    private void loadpost()
    {

        if (Session["User_Name"] == null)
        {

            Response.Redirect("Home.aspx", true);

        }


        DataSet ds = ClPost.Get_Post_Post_Id_Wise(PostId);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);
            post.InnerHtml = Convert.ToString(row["P_Description"]);
            V_Status = Convert.ToByte(ds.Tables[0].Rows[0]["V_Status"]);
            F_Status = Convert.ToByte(ds.Tables[0].Rows[0]["V_Status"]);

        }

        load_Post_Type1();
        load_F_Type1();


    }
    private void load_Post_Type1()
    {

        DataSet ds = ClPost.List_of_Post_Type();
        ddlPostType.DataSource = ds;
        ddlPostType.DataTextField = "T_name";
        ddlPostType.DataValueField = "T_id";
        ddlPostType.SelectedIndex = V_Status - 1;
        ddlPostType.DataBind();

    }

    private void load_F_Type1()
    {

        DataSet ds = ClPost.List_of_U_Status();
        ddlFstatus.DataSource = ds;
        ddlFstatus.DataTextField = "A_name";
        ddlFstatus.DataValueField = "A_id";
        ddlFstatus.SelectedIndex = F_Status - 1;
        ddlFstatus.DataBind();

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (post.Value == "")
        {

            return;
        }
        else
        {

            savedate();

            Response.Redirect("Default.aspx");
        }


    }
    private void savedate()
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        string userid = Session["userid"].ToString();// = userid;
        String User_Name = Session["User_Name"].ToString();// = ProviderUserName;







        if (string.IsNullOrEmpty(userid))
        {
            DataSet ds = ClPost.Get_User_Data_User_Name_Wise(User_Name);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                userid = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);

            }
        }





        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        Byte PostType = Convert.ToByte(ddlPostType.SelectedItem.Value);
        Byte F_Status = Convert.ToByte(ddlFstatus.SelectedItem.Value);
        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Post(hidArticleId.Value, "", post.InnerText, 1, 1, Convert.ToInt32(userid), PostType, Post_Date, "", 1, F_Status,"","");
        }
        else
        {
            string articleId = ClPost.Insert_Add_tbl_Post("", post.InnerText, 1, 1, Convert.ToInt32(userid), PostType, Post_Date, "", 1, F_Status,"","");


        }


        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {
            ImagePostid = hidArticleId.Value;
        }

        else
        {
            DataSet ds = ClPost.Get_Max_P_Id_User_Wise(Convert.ToInt32(userid));

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                ImagePostid = Convert.ToString(row["P_Id"]);


            }

        }



        if (file_upload.HasFile)
        {
            foreach (HttpPostedFile postedFile in file_upload.PostedFiles)
            {
                string fileName = System.DateTime.Now.ToString("_ddMMyyhhmmss") + Path.GetFileName(postedFile.FileName);
                file_upload.SaveAs(Server.MapPath("~/images/Items/" + fileName));// + Path.GetFileName(file.FileName));
                string articleId = ClPost.Insert_Post_Pic(Convert.ToInt32(ImagePostid), Convert.ToInt32(userid), fileName, fileName);
            }
        }

        post.Value = "";

    }
}