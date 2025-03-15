using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class privacy : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        load_Post_1();
        load_Post_2();
        load_Post_3();

        load_Post_4();
        load_Post_5();
        load_Post_6();

        load_Post_7();
        load_Post_8();
        load_Post_9();

        load_Post_10();
    }


    private void load_Post_1()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("1");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblpost1Title.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lblPost1detail.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }



    private void load_Post_2()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("2");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblpost2Title.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lblPost2detail.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }


    private void load_Post_3()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("3");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblPost3Sort.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lblPost3Detail.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }
    private void load_Post_4()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("4");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq4.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla4.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }

    private void load_Post_5()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("5");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq5.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla5.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }

    private void load_Post_6()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("6");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq6.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla6.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }

    private void load_Post_7()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("7");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq7.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla7.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }

    private void load_Post_8()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("8");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq8.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla8.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);

        }

        con.Close();
    }

    private void load_Post_9()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("9");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq9.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla9.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);


        }

        con.Close();
    }

    private void load_Post_10()
    {
        con.Open();
        DataSet ds = ClPost.Get_Item_Id_Wise_Privacy("10");

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];

            lblq10.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Name"]);
            lbla10.Text = Convert.ToString(ds.Tables[0].Rows[0]["P_Description"]);


        }

        con.Close();
    }
}