using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class Notes : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
     String P_Image;
    protected void Page_Load(object sender, EventArgs e)
     {
         if (!Page.IsPostBack)
         {
             BindItemsLis();
             lblDate.Text = DateTime.Today.ToShortDateString();
             ShowAdata();
         }
    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {

            savedate();

    }

    private void savedate()
    {
        //LOK daya

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        if (file_upload.HasFile)
        {
            string imagename = file_upload.PostedFile.FileName;
            //  string fileExtension = System.IO.Path.GetExtension(imagename);
            // string fname = System.IO.Path.GetFileName(imagename);
            string lok1 = System.DateTime.Now.ToString("_ddMMyyhhmmss") + imagename;
            file_upload.SaveAs(Server.MapPath("images/Event/" + lok1));

            P_Image = ("images/Event/" + lok1);
            //
        }
        else
        {
            P_Image = Label1.Text;

        }

        
       string userid = Session["userid"].ToString();

        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());

        string articleId = ClPost.Insert_Add_tbl_Post_Notes(txtTitle.Value, txtdes.Value, Convert.ToInt32(userid), Post_Date, P_Image, 1);

        Response.Redirect("Refresh3.aspx", true);

              
            }


    protected void BindItemsLis()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Note_List(userid);

        dlnotes.DataSource = ds;
        dlnotes.DataBind();

        con.Close();
    }


    protected void btnDeleteClicked1(object sender, EventArgs e)
    {
        //Like Code

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);
        ClPost.Get_Delete_Notes(PostId);
        BindItemsLis();


    }

    private void ShowAdata()
    {



        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Id_Wise(userid);

        if (ds.Tables[0].Rows.Count > 0)
        {

            DataRow row = ds.Tables[0].Rows[0];
            lblName.Text = Convert.ToString(ds.Tables[0].Rows[0]["First_Name"]);
          
            lok2.Text = Convert.ToString(ds.Tables[0].Rows[0]["Profile_Image"]);
          



            //String sDate = Convert.ToString(ds.Tables[0].Rows[0]["dob"]); ;// DateTime.Now.ToString();


        }
    }


        }








