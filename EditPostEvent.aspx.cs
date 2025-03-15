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

public partial class EditPostEvent : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    Byte Date;
    Byte Month;
    Byte Year;
    Byte P_Type;
    String P_Image;
    Byte Duration;
    Int32 PostId;
    String dy;// = datevalue.Day.ToString();
    String mn;// = datevalue.Month.ToString();
    String yy;// = datevalue.Year.ToString();
   
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
                PostId = Convert.ToInt32(blog.Decrypt(Request.QueryString["ID"]).ToString());
                // Int32 PostId1 = Convert.ToInt32(StringCipher.Decrypt(Request.QueryString["ID1"]).ToString());

                Session["PostId"] = PostId.ToString();
            }
            else
            {
                // Response.Redirect("~/Mortgages.aspx", false);
            }


            loadpost();

            load_Month();
            load_Date();
            load_Year();
            load_Event_Type();
            
        }



    }



    private void load_Month()
    {

        DataSet ds = ClPost.Load_Month();
        DdlMonth.DataSource = ds;
        DdlMonth.DataTextField = "A_Name";
        DdlMonth.DataValueField = "A_id";
        //  DdlMonth.SelectedIndex = Month - 1;
        DdlMonth.SelectedValue = Convert.ToString(mn.ToString());
        DdlMonth.DataBind();

    }
    private void load_Date()
    {

        DataSet ds = ClPost.Load_Date();
        ddlDate.DataSource = ds;
        ddlDate.DataTextField = "A_Name";
        ddlDate.DataValueField = "A_id";
        //ddlDate.SelectedIndex = Date - 1;
        ddlDate.SelectedValue = Convert.ToString(dy.ToString());
        ddlDate.DataBind();

    }
    private void load_Year()
    {

        DataSet ds = ClPost.Load_Year();
        ddlYear.DataSource = ds;
        ddlYear.DataTextField = "A_Name";
        ddlYear.DataValueField = "A_id";
        ddlYear.SelectedValue = Convert.ToString(yy.ToString());

        //  ddlYear.Text = yy;

        ddlYear.DataBind();

    }

    private void load_Event_Type()
    {

        DataSet ds = ClPost.Load_Event_Type();
        ddlEventType.DataSource = ds;
        ddlEventType.DataTextField = "T_Name";
        ddlEventType.DataValueField = "T_id";
        ddlEventType.SelectedIndex = P_Type - 1;
        ddlEventType.DataBind();

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (txtdes.Value == "")
        {

            return;
        }
        else
        {

            savedate();
            Response.Redirect("refresh.aspx", true);
         

        }

    }
    private void savedate()
    {

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

        string userid = Session["userid"].ToString();// = userid;
        String User_Name = Session["User_Name"].ToString();// = ProviderUserName;


        string dd = Convert.ToString(ddlDate.SelectedItem.Value);
        string mm = Convert.ToString(DdlMonth.SelectedItem.Value);
        string yyy = Convert.ToString(ddlYear.SelectedItem.Value);

        //end Date of Birth
        DateTime eventStartDate = Convert.ToDateTime(yyy + '-' + mm + '-' + dd);


        string x = txtDuration.Text;
        if (x == "")
        {
            Duration = 1;
        }
        else
        {
            Duration = Convert.ToByte(txtDuration.Text);
        }





        string tagid = "";// Lblsname.Text;

        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        Byte EventType = Convert.ToByte(ddlEventType.SelectedItem.Value);
        Byte F_Status = 1;// Convert.ToByte(ddlFstatus.SelectedItem.Value);
        //  string checkin = ddlCity.SelectedItem.Text;
        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Event_Post(hidArticleId.Value, txtEventName.Value, txtLocation.Value, txtTime.Value, txtdes.Value, EventType,
                Convert.ToInt32(userid), 1, Post_Date, P_Image, 1, 1, "", eventStartDate, Duration, tagid);
        }
        else
        {
            if (txtdes.Value == "")
            {

                return;
            }
            else
            {
                string articleId = ClPost.Insert_Add_tbl_Event_Post(txtEventName.Value, txtLocation.Value, txtTime.Value, txtdes.Value, EventType,
                    Convert.ToInt32(userid), 1, Post_Date, P_Image, 1, 1, "", eventStartDate, Duration, tagid);

                txtEventName.Value = "";
                txtLocation.Value = "";
                txtTime.Value = "";
                txtdes.InnerText = "";

                file_upload.Attributes.Clear();
                Response.Redirect("refresh.aspx", true);
            }
        }






    }

    private void loadpost()
    {

        if (Session["User_Name"] == null)
        {

            Response.Redirect("Home.aspx", true);

        }


        DataSet ds = ClPost.Get_Post_Post_Event_Id_Wise(PostId);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);
            txtdes.Value = Convert.ToString(row["P_Description"]);
            txtEventName.Value = Convert.ToString(row["P_Name"]);
            txtLocation.Value = Convert.ToString(row["P_Location"]);
            txtTime.Value = Convert.ToString(row["P_Time"]);
            P_Type = Convert.ToByte(row["P_Type"]);
            Label1.Text = Convert.ToString(row["P_Image"]);
            Image1.ImageUrl = Label1.Text;


            String sDate = Convert.ToString(ds.Tables[0].Rows[0]["Event_Satrt_Date"]); ;// DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            
            dy = datevalue.Day.ToString();
            mn = datevalue.Month.ToString();
            yy = datevalue.Year.ToString();
            load_Month();
            load_Date();
            load_Year();
            

        }

        load_Event_Type();



    }

}