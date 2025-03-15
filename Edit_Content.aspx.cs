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
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
public partial class Edit_Content : System.Web.UI.Page
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
    String Tvalue;
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
            F_Status = Convert.ToByte(ds.Tables[0].Rows[0]["F_Status"]);
            lbltagid.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Image"]);
            my_control.Text = Convert.ToString(ds.Tables[0].Rows[0]["checking"]);
        }


        //HtmlGenericControl divdav = ri.FindControl("video") as HtmlGenericControl;
        divdav.Visible = false;

        ds = ClPost.Get_P_Id_User_Image(Convert.ToInt32(PostId));
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            PostImage = Convert.ToString(row["Image_Name"]);
            lblimage.Text = "images/Items/" + PostImage;
            Image1.ImageUrl = "images/Items/" + PostImage;
         string    ext = Path.GetExtension(PostImage);

            if (ext == ".mp4")
            {
                divdav.Visible = true;
                //return;
            }

            else
            {
                if ((PostImage == "") || (PostImage == null))
                {

                    Image1.Visible = false; ;
                    Image1.Dispose();// = true;
                }

                else
                {

                    Image1.Visible = true; ;
                }
                divdav.Visible = false;

            }
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

        if (post.Value == ""  &&   my_control.Text=="")
         
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
        string pDes = post.InnerText;
        GetYouTubeID(pDes);
        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Post(hidArticleId.Value, "", post.InnerText, 1, 1, Convert.ToInt32(userid), PostType, Post_Date, lbltagid.Text, 1, F_Status, my_control.Text, lblvideo.Text);
        }
        else
        {
         //   string articleId = ClPost.Insert_Add_tbl_Post("", post.InnerText, 1, 1, Convert.ToInt32(userid), PostType, Post_Date, "", 1, F_Status);


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
        Response.Redirect("~/Default.aspx");

    }

    private string GetYouTubeID(string youTubeUrl)
    {
        //RegEx to Find YouTube ID
        ScrubHtml(youTubeUrl);

        //Match regexMatch = Regex.Match(Tvalue, "^[^v]+v=(.{11}).*",
        //                   RegexOptions.IgnoreCase);
        Match regexMatch = Regex.Match(Tvalue, "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+",
                         RegexOptions.IgnoreCase);
        if (regexMatch.Success)
        {
            lblvideo.Text = "http://www.youtube.com/v/" + regexMatch.Groups[1].Value +
                   "&hl=en&fs=1";
            //  lblvideo.Text = "https://www.youtube.com/embed/" + regexMatch.Groups[1].Value;

            //
        }
        return youTubeUrl;
    }

    public string ScrubHtml(string value)
    {
        var step1 = Regex.Replace(value, @"<[^>]+>|&nbsp;", "").Trim();
        var step2 = Regex.Replace(step1, @"\s{2,}", " ");

        Tvalue = step2;
        return step2;
    }
}