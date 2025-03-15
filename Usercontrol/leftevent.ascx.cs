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
using System.IO;
using System.Data.SqlClient;
using System.Collections;

public partial class Usercontrol_leftevent : System.Web.UI.UserControl
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        loadPost_Past_Releted();
        loadPost_frnd_B_Dayd();
    }


    private void loadPost_Past_Releted()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Event_Releted_Left_Side(userid);

        rptReleted.DataSource = ds;
        rptReleted.DataBind();
        con.Close();

    }


    private void loadPost_frnd_B_Dayd()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Frnd_Calendar_Left_side(userid);

        rptFrndCalendar.DataSource = ds;
        rptFrndCalendar.DataBind();
        con.Close();

    }
}