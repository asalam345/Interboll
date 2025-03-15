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

public partial class More : System.Web.UI.Page
{
    byte Likeid1;
    Byte CategoryId;
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadPost();
            loadPost1();
            loaallLike();
            loaallLikeIndividual();
            ShowAdata();

        }


    }


    private void ShowAdata()
    {
        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());


        }

        DataSet ds = ClPost.Get_LookuP_More_Id_Wise(Convert.ToString(CategoryId));

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
          
            lblCategoryName.Text = Convert.ToString(row["T_Name"]);
            lblCatname.Text = Convert.ToString(row["T_Name"]);
            lblctname1.Text = Convert.ToString(row["T_Name"]);

        }

    }
    protected void btnReplyClicked(object sender, EventArgs e)
    {

       
       

            //Like Code
            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }

            int PostId = int.Parse((sender as Button).CommandArgument);

            string userid = Session["userid"].ToString();
            DataSet ds = ClPost.Get_Check_More_Like(PostId, userid);
            DateTime Postdate = DateTime.Now;
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                Byte Likeid = Convert.ToByte(row["Like_Type"]);

                if (Likeid == 0)
                {
                    Likeid1 = 1;

                }

                else if (Likeid == 1)
                {
                    Likeid1 = 0;

                }




                ClPost.Updade_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
                CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
                Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
                return;
            }

            else
            {


                string articleId1 = ClPost.Insert_Add_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
                CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
                Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
                return;
            }


  


    }

    protected void btnReplyClicked1(object sender, EventArgs e)
    {
        //Like Code
    
            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
            int PostId = int.Parse((sender as Button).CommandArgument);

            string userid = Session["userid"].ToString();
            DataSet ds = ClPost.Get_Check_More_Like(PostId, userid);
            DateTime Postdate = DateTime.Now;
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                Byte Likeid = Convert.ToByte(row["Like_Type"]);

                if (Likeid == 0)
                {
                    Likeid1 = 1;

                }

                else if (Likeid == 1)
                {
                    Likeid1 = 0;

                }




                ClPost.Updade_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);

                Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
                return;
            }

            else
            {


                string articleId1 = ClPost.Insert_Add_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);


                Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
                return;
            }





    }

    private void loadPost()
    {

        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());


        }

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_More_List(userid, CategoryId,1);

        dlMore.DataSource = ds;
        dlMore.DataBind();
        con.Close();

    }

    private void loadPost1()
    {

        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());


        }

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_More_List1(userid, CategoryId,1);

        dlMore1.DataSource = ds;
        dlMore1.DataBind();
        con.Close();

    }
    protected void dlMore_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }

    private void loaallLike()
    {

        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());


        }

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_More_List1(userid, CategoryId,0);

        rptlikedAll.DataSource = ds;
        rptlikedAll.DataBind();
        con.Close();

    }

    private void loaallLikeIndividual()
    {

        if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());


        }

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_More_List_SegmentWise(userid, CategoryId, 0,1);

        rptlikedIndivisual.DataSource = ds;
        rptlikedIndivisual.DataBind();
        con.Close();

    }



    protected void btnReplyClicked2(object sender, EventArgs e)
    {
        //Like Code

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Check_More_Like(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);

            if (Likeid == 0)
            {
                Likeid1 = 1;

            }

            else if (Likeid == 1)
            {
                Likeid1 = 0;

            }




            ClPost.Updade_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
            Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
            return;
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
            Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
            return;
        }





    }


    protected void btnReplyClicked3(object sender, EventArgs e)
    {
        //Like Code

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Check_More_Like(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Like_Type"]);

            if (Likeid == 0)
            {
                Likeid1 = 1;

            }

            else if (Likeid == 1)
            {
                Likeid1 = 0;

            }




            ClPost.Updade_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
            Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
            return;
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_More_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            CategoryId = Convert.ToByte(blog.Decrypt(Request.QueryString["ID"]).ToString());
            Response.Redirect("More.aspx?ID=" + blog.Encrypt(CategoryId.ToString()));
            return;
        }





    }
   
}