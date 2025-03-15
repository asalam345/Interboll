using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Mars.Utility;
using System.Text;


using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

public partial class admin_Manage_Video : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    String P_Id;
    Byte P_Sl;
    Byte[] Data;
  
    Byte[] Data1;
    String Filename;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        string x = Session["UserGroupID"].ToString();

        if (x == "90")
        {

            if (!IsPostBack)
            {
                BindGrid();
                ShowArticle1();
            }

        }
        else
        {

            Response.Redirect("~/Default.aspx");

        }

    }

    private void ShowArticle1()
    {

        P_Id = Request.QueryString["P_Id"];
        if (P_Id != null)
        {
            ShowAdata();

           // lit1.Text = "Edit Items";
           // lit2.Text = "Edit Items";

        }       //

        else
        {
            txtTitle.Text = "";

        }
    }
    private void ShowAdata()
    {
        DataSet ds = ClPost.Get_Video_Id_Wise(P_Id);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["Id"]);
            txtTitle.Text = Convert.ToString(row["P_Title"]);
            Data = Encoding.UTF8.GetBytes(Convert.ToString(row["Data"]));
            txtname.Text = Convert.ToString(row["Name"]);
            txtsl.Text = Convert.ToString(row["p_sl"]);
            //lbldata.Text 
             
        }
    }

    private void BindGrid()
    {
        con.Open();

        DataSet ds = ClPost.List_of_Video();
        gvDetails.DataSource = ds;
        gvDetails.DataBind();

        
        con.Close();
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
         P_Id = Request.QueryString["P_Id"];
         if (P_Id != null)
         {
             updatevideo();
         }
         else

         {

             SaveArticle();
         
         }
       
    }


    private void updatevideo()
    {
        if (FileUpload1.HasFile == true)
        {
            string imagename = FileUpload1.PostedFile.FileName;
            FileUpload1.SaveAs(Server.MapPath("../images/Video/" + imagename));
            Filename = ("images/Video/" + imagename);

            using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                Data = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);

                Data1 = Encoding.UTF8.GetBytes("12");// Data;

                string x = txtsl.Text;
                if (x == "")
                {
                    P_Sl = 90;
                }
                else
                {
                    P_Sl = Convert.ToByte(txtsl.Text);
                }
                ClPost.Update_tbl_Add_Video1(hidArticleId.Value, Filename, "", Data1, P_Sl, txtTitle.Text, 1);

            }

           

        }

        else
        {

            string x = txtsl.Text;
            if (x == "")
            {
                P_Sl = 90;
            }
            else
            {
                P_Sl = Convert.ToByte(txtsl.Text);
            }
            ClPost.Update_tbl_Add_Video2(hidArticleId.Value, txtname.Text, "",  P_Sl, txtTitle.Text, 1);
 
           
        }
          
        
      




      //  Response.Redirect(Request.Url.AbsoluteUri);
        Response.Redirect("Manage_Video.aspx");
    }


    private void SaveArticle()

    {
        if (FileUpload1.HasFile == false)
        {
            // No file uploaded!
            UploadDetails.Text = "Please first select a file to upload...";
        }

        else
        {

            string x = txtsl.Text;
            if (x == "")
            {
                P_Sl = 90;
            }
            else
            {
                P_Sl = Convert.ToByte(txtsl.Text);
            }
            string imagename = FileUpload1.PostedFile.FileName;
            FileUpload1.SaveAs(Server.MapPath("../images/Video/" + imagename));
            Filename = ("images/Video/" + imagename);
            using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);
                bytes = Encoding.UTF8.GetBytes("12");
                string strConnString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(strConnString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "insert into tblFiles(Name, ContentType, Data,p_sl,P_Title,p_Status) values (@Name, @ContentType, @Data,@p_sl,@P_Title,@p_Status)";
                        cmd.Parameters.AddWithValue("@Name",Filename);// Path.GetFileName(FileUpload1.PostedFile.FileName));
                        cmd.Parameters.AddWithValue("@ContentType", "video/mp4");
                        cmd.Parameters.AddWithValue("@Data", bytes);
                        cmd.Parameters.AddWithValue("@p_sl", P_Sl);
                        cmd.Parameters.AddWithValue("@P_Title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@p_Status", 1);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }

        Response.Redirect(Request.Url.AbsoluteUri);
    }

    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int Id = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["Id"].ToString());

        ClPost.Update_Video_Status(Id, 2);
        Response.Redirect("Manage_Video.aspx");

    }
    protected void gvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {


        gvDetails.PageIndex = e.NewPageIndex;
        gvDetails.DataBind();
     //   BindGridviewData();


    }

}