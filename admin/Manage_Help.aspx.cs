using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;
public partial class admin_Manage_Help : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        string x = Session["UserGroupID"].ToString();

        if (x == "90")
        {

            if (!Page.IsPostBack)
            {
                BindGridviewData();
               
                //  this.Page.Form.Enctype = "multipart/form-data";
            }
        }
        else
        {

            Response.Redirect("~/Default.aspx");

        }
    }

    private void BindGridviewData()
    {



        con.Open();

        DataSet ds = ClPost.List_of_Help_Items();
        gvDetails.DataSource = ds;
        gvDetails.DataBind();
        con.Close();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

        BindGridviewData();
    }


    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int Id = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["P_Id"].ToString());

        con.Open();
        SqlCommand cmd = new SqlCommand("delete from tbl_Add_Item_Help where P_Id=" + Id, con);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        BindGridviewData();


    }
    protected void gvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {


        gvDetails.PageIndex = e.NewPageIndex;
        gvDetails.DataBind();
        BindGridviewData();


    }

    protected void ddlSports_SelectedIndexChanged(object sender, EventArgs e)
    {
      //  BindGridviewData1();
    }

   

    
}