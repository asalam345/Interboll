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

public partial class ShowAlbumPic : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);

    Int32  Albumid;
    Int32 Albumid1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            Albumid = Convert.ToInt32(blog.Decrypt(Request.QueryString["ID"]).ToString());

            // Session["FrnId"] = FrnId.ToString();
        }
        
            BindItemsAlbum_Image();
    }



    protected void BindItemsAlbum_Image()
    {
       // Int32 Albumid1;
        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
             Albumid = Convert.ToInt32(blog.Decrypt(Request.QueryString["ID"]).ToString());

            // Session["FrnId"] = FrnId.ToString();
        }

        SqlConnection.ClearAllPools();
        con.Open();

       // Int32 Albumid = Convert.ToInt32(Session["Album_Id"].ToString());
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
}