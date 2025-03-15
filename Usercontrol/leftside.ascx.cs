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

public partial class Usercontrol_leftside : System.Web.UI.UserControl
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        loadSeg1();
        loadSeg2();
        //loadSegVideo1();
       // loadSegVideo2();
    }


    protected void loadSeg1()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_List_Seg1("1");

        rptseg1.DataSource = ds;
        rptseg1.DataBind();

       

        con.Close();
    }

    protected void loadSeg2()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_List_Seg1("2");

        rptSeg2.DataSource = ds;
        rptSeg2.DataBind();



        con.Close();
    }


    protected void loadSegVideo1()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds3 = ClPost.Get_List_Video1();


        rptVideo1.DataSource = ds3;
        rptVideo1.DataBind();
     
        con.Close();

    }

    protected void loadSegVideo2()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds3 = ClPost.Get_List_Video2();


        rptVideo2.DataSource = ds3;
        rptVideo2.DataBind();

        con.Close();



    }

}