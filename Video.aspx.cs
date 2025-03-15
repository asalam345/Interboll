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

public partial class Video : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {



        if (!Page.IsPostBack)
        {



            loadPost();


        }

        //txtSearch.Text = false;

    }



















    private void loadPost()
    {

        SqlConnection.ClearAllPools();
        con.Open();



        

        DataSet ds = UserProfile.SelecMenue();

        rptPost.DataSource = ds;
        rptPost.DataBind();
        con.Close();

    }










    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {


            Label lblmenueid = (Label)e.Item.FindControl("lblmenueid");

            Repeater dlPostImage = (Repeater)e.Item.FindControl("dlcomment");
            dlPostImage.Visible = true;
            DataSet ds1 = UserProfile.Get_Load_Menue(Convert.ToByte(lblmenueid.Text));
            dlPostImage.DataSource = ds1;
            dlPostImage.DataBind();

        }





    }
























    //for comment





}

