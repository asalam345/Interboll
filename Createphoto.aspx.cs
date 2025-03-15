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

public partial class Createphoto : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    string SessionValue = "";
    string x1;
    string x2;
    String category;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindItemsListFrndlist();
            load_Post_Type();
            BindItemsListAlbum();
        }
    }
    private void load_Post_Type()
    {

        DataSet ds = ClPost.List_of_Post_Type();
        ddlPostType.DataSource = ds;
        ddlPostType.DataTextField = "T_name";
        ddlPostType.DataValueField = "T_id";
        ddlPostType.SelectedIndex = -1;
        ddlPostType.DataBind();

    }

    protected void BindItemsListFrndlist()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Frndlist(userid);

        dlfrndlist.DataSource = ds;
        dlfrndlist.DataBind();

        con.Close();
    }
    protected void DataListBrand_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //  CheckBox chked_item = (CheckBox)DataListBrand.FindControl("CheckBoxListTest");
    }

    protected void CheckBoxListTest_SelectedIndexChanged(object sender, EventArgs e)
    {
        // GetCheckedBox_Brand();
        //  Label ID = DataListBrand.Items[i].FindControl("Label3") as Label;
        GetCheckedBox_Datalist(dlfrndlist, 1);

    }

    protected void GetCheckedBox_Datalist(DataList dname, Byte did)
    {

        Int32 Category = 0;
        // string SessionValue = "";
        string daysrequested = "";

        int count = dname.Items.Count;
        for (int i = 0; i < count; i++)
        {
            CheckBox chk = dname.Items[i].FindControl("chkbox") as CheckBox;
            if (chk.Checked)
            {

                Label ID = dname.Items[i].FindControl("Label3") as Label;
                Label catID = dname.Items[i].FindControl("Label4") as Label;

                String id1 = ID.Text;
                category = catID.Text;



                if (id1 != null)
                {
                    Category = Convert.ToInt32(ID.Text);

                    if (SessionValue == "")
                        SessionValue = Category.ToString();
                    else
                        SessionValue = SessionValue + "," + Category.ToString();

                    //subcatename = suname;



                }


                Lblsname.Text = SessionValue;

               



            }




        }




    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
       
        savedate();

        BindItemsListAlbum();
        

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



        string tagid = Lblsname.Text;

        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        Byte PostType = Convert.ToByte(ddlPostType.SelectedItem.Value);
        Int32 A_userid = Convert.ToInt32(userid);
        //  string checkin = ddlCity.SelectedItem.Text;
        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Photo_Album(hidArticleId.Value,A_userid, txtTitle.Value, txtdesc.Value, txtplace.Value, "", tagid, PostType, 1);
        }
        else
        {
            string articleId = ClPost.Insert_Add_tbl_Photo_Album(A_userid, txtTitle.Value,txtdesc.Value,txtplace.Value,"",tagid,PostType,1,Post_Date);


        }

             
    }

    protected void BindItemsListAlbum()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Album_List(userid);

        dlalbum.DataSource = ds;
        dlalbum.DataBind();

        con.Close();
    }


    protected void btnShareClicked(object sender, EventArgs e)
    {
        //Like Code
        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);
        loadpic.Visible = true;
        Session["Album_Id"] = PostId.ToString();
        BindItemsAlbum_Image();

    }

    protected void btnImagepost_Click(object sender, EventArgs e)
    {

      ////  savedate();
        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        string userid = Session["userid"].ToString();
        Int32 Albumid = Convert.ToInt32(Session["Album_Id"].ToString());

      //  if (file_upload.HasFile)
      //  {
      //      foreach (HttpPostedFile postedFile in file_upload.PostedFiles)
      //      {

      //          if (postedFile != null)
      //          {
      //              string fileName = System.DateTime.Now.ToString("_ddMMyyhhmmss") + Path.GetFileName(postedFile.FileName);
      //              file_upload.SaveAs(Server.MapPath("~/images/Albums/" + fileName));// + Path.GetFileName(file.FileName));

                    

      //              string articleId = ClPost.Insert_Album_Pic(Albumid, Convert.ToInt32(userid), fileName, fileName, Post_Date);
      //          }
                
                
      //      }
      //  }


        if (file_upload.HasFile)     // CHECK IF ANY FILE HAS BEEN SELECTED.
        {
            int iUploadedCnt = 0;
            int iFailedCnt = 0;
            HttpFileCollection hfc = Request.Files;
            lblFileList.Text = "Select <b>" + hfc.Count + "</b> file(s)";

            if (hfc.Count <= 10)    // 10 FILES RESTRICTION.
            {
                for (int i = 0; i <= hfc.Count - 1; i++)
                {
                    HttpPostedFile hpf = hfc[i];
                    if (hpf.ContentLength > 0)
                    {
                        if (!File.Exists(Server.MapPath("~/images/Albums/") + 
                            Path.GetFileName(hpf.FileName)))
                        {
                            DirectoryInfo objDir =
                                new DirectoryInfo(Server.MapPath("~/images/Albums/"));

                            string sFileName = Path.GetFileName(hpf.FileName);
                            string sFileExt = Path.GetExtension(hpf.FileName);

                            // CHECK FOR DUPLICATE FILES.
                            FileInfo[] objFI = 
                                objDir.GetFiles(sFileName.Replace(sFileExt, "") + ".*");

                            if (objFI.Length > 0)
                            {
                                // CHECK IF FILE WITH THE SAME NAME EXISTS 
                                  //  (IGNORING THE EXTENTIONS).
                                foreach (FileInfo file in objFI)
                                {
                                    string sFileName1 = objFI[0].Name;
                                    string sFileExt1 = Path.GetExtension(objFI[0].Name);

                                    if (sFileName1.Replace(sFileExt1, "") == 
                                            sFileName.Replace(sFileExt, ""))
                                    {
                                        iFailedCnt += 1;        // NOT ALLOWING DUPLICATE.
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                // SAVE THE FILE IN A FOLDER.
                                hpf.SaveAs(Server.MapPath("~/images/Albums/") + 
                                    Path.GetFileName(hpf.FileName));
                                string fileName =  Path.GetFileName(hpf.FileName);
                                iUploadedCnt += 1;
                                string articleId = ClPost.Insert_Album_Pic(Albumid, Convert.ToInt32(userid), fileName, fileName, Post_Date);
                            }
                        }
                    }
                }
                lblUploadStatus.Text = "<b>" + iUploadedCnt + "</b> file(s) Uploaded.";
                lblFailedStatus.Text = "<b>" + iFailedCnt + 
                    "</b> duplicate file(s) could not be uploaded.";
            }
            else lblUploadStatus.Text = "Max. 10 files allowed.";
        }
        else lblUploadStatus.Text = "No files selected.";

        BindItemsAlbum_Image();

    }

    protected void BindItemsAlbum_Image()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        Int32 Albumid = Convert.ToInt32(Session["Album_Id"].ToString());
        DataSet ds = ClPost.Get_Album_Wise_Image(Albumid);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblAlbums.Text = Convert.ToString(ds.Tables[0].Rows[0]["Album_Name"]);
            


        }

        dl_Image.DataSource = ds;
        dl_Image.DataBind();
        
        con.Close();
    }
    protected void btnDeleteClicked(object sender, EventArgs e)
    {
        //Like Code
        con.Open();
        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);
        SqlCommand cmd = new SqlCommand("delete from tbl_Album_Image where Image_Id=" + PostId, con);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        BindItemsAlbum_Image();

    }
}