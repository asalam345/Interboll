using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class Searchbox1 : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    Byte Likeid1;
    Byte V_Status;

    String ImagePostid;
    String PostImage;
    String P_Image;
    Int32 FrnId;
    string search1;
    Byte fltype;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
             Session["User_Name"] = "abulink@yahoo.com";
            Session["userid"] = "5";
            
            Session["First_Name"] = "Mahfuz Latif";
            
            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }




            shodata();


        }
    }




    private void shodata()
    {

        search1 = Request.QueryString["search"];
        if (search1 != null)
        {
            search();

        }       //

        else
        {

            //  ResetForNewArticle();

        }
    }

    private void search()
    {
        search1 = Request.QueryString["search"];
        txtSearch.Value = search1;
        special(search1);
        special2(search1);

    }

    private void special(String search)
    {

        SqlConnection.ClearAllPools();
        con.Open();

        DataSet ds = ClPost.List_of_Search1(search);

        rptFriend.DataSource = ds;
        rptFriend.DataBind();
        con.Close();

    }


    private void special2(String search)
    {

        SqlConnection.ClearAllPools();
        con.Open();

        DataSet ds = ClPost.List_of_Search2(search);

        rptPost.DataSource = ds;
        rptPost.DataBind();
        con.Close();

    }



    private void loadPost()
    {

        SqlConnection.ClearAllPools();
        con.Open();
        String FrnId1 = (blog.Decrypt(Request.QueryString["ID"]).ToString());
        string userid = FrnId1;// Session["FrnId"].ToString();// Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post_Friends(userid,1);

        rptPost.DataSource = ds;
        rptPost.DataBind();
        con.Close();

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
        DataSet ds = ClPost.Get_Check_Like(PostId, userid);
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




            ClPost.Updade_tbl_Like(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
            loadPost();
            return;
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_Like(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            loadPost();
            return;
        }


        //foreach (RepeaterItem item in rptPost.Items)
        //{
        //  //  TextBox tb = item.FindControl(PostId) as TextBox;



        //}




    }



    protected void btnReplyClicked1(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int PostId = int.Parse((sender as Button).CommandArgument);



        DataSet ds = ClPost.Get_Post_Post_Id_Wise(PostId);

        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            hidArticleId.Value = Convert.ToString(row["P_Id"]);

            V_Status = Convert.ToByte(ds.Tables[0].Rows[0]["V_Status"]);

        }





    }




    protected void btnReplyClicked2(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int PostId = int.Parse((sender as Button).CommandArgument);

        Session["PostId"] = PostId.ToString();
        // loadPostWiseComment();


        //DataSet ds = ClPost.Get_Post_Post_Id_Wise(PostId);

        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    DataRow row = ds.Tables[0].Rows[0];
        //    hidArticleId.Value = Convert.ToString(row["P_Id"]);
        //    post.InnerHtml = Convert.ToString(row["P_Description"]);
        //    V_Status = Convert.ToByte(ds.Tables[0].Rows[0]["V_Status"]);

        //}

        //load_Post_Type1();



    }
    protected void itemRepeater_ItemCreated(object source, RepeaterCommandEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            TextBox cmtPost1 = (TextBox)e.Item.FindControl("cmtPost");
            Button Button3 = (Button)e.Item.FindControl("Button3");

            cmtPost1.Visible = true;
            Button3.Visible = true;

            if (e.CommandName == "lokin") // check command is cmd_delete
            {
                // get you required value
                int CustomerID = Convert.ToInt32(e.CommandArgument);

                //  Repeater rptAttValue = (Repeater)e.Item.FindControl("divlok");





                Repeater dlPostImage = (Repeater)e.Item.FindControl("dlcomment");
                dlPostImage.Visible = true;
                DataSet ds1 = ClPost.List_of_Post_Wise_Comment(CustomerID);
                dlPostImage.DataSource = ds1;
                dlPostImage.DataBind();


                //Write some code for what you need 

            }
            else
            {
                Repeater dlPostImage = (Repeater)e.Item.FindControl("dlcomment");
                dlPostImage.Visible = false;
                // Repeater rptAttValue = (Repeater)e.Item.FindControl("divlok");


            }


            if (e.CommandName == "lokinPost") // check command is cmd_delete
            {
                // get you required value


                DateTime Postdate = DateTime.Now;
                int CustomerID = Convert.ToInt32(e.CommandArgument);
                string userid = Session["userid"].ToString();

                TextBox cmtPost = (TextBox)e.Item.FindControl("cmtPost");

                string articleId1 = ClPost.Insert_tbl_Post_Comment(CustomerID, Convert.ToInt32(userid), cmtPost.Text, Postdate, "", 1);

                cmtPost.Text = "";

            }




        }
    }

   

   

    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
        foreach (RepeaterItem ri in rptFriend.Items)
        {
            Label lblfrnd1 = ri.FindControl("lblfrnd1") as Label;




            string userid = Session["userid"].ToString();



      
            Button btnFriend = ri.FindControl("btnReply") as Button;
            Button RequestSent = ri.FindControl("RequestSent") as Button;
            Button Follower = ri.FindControl("Follower") as Button;
            DataSet ds3 = ClPost.Get_Check_search_Frnd(Convert.ToInt32(userid), Convert.ToInt32(lblfrnd1.Text));

            if (ds3.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds3.Tables[0].Rows[0];


                fltype = Convert.ToByte(ds3.Tables[0].Rows[0]["u_friendStatus"]);

                if (Convert.ToByte(fltype) == 0)
                {

                    RequestSent.Visible = true;
                }

                else if (Convert.ToByte(fltype) == 1)
                {

                    Follower.Visible = true;
                }


            }
            else
            {

                //btnFriend.Text = "Add ";
                btnFriend.Visible = true;

                //  LinkButton1.Visible = false;
            }

           
            //Image Image1 = ri.FindControl("Image1") as Image;
            //ds = ClPost.Get_P_Id_User_Image(Convert.ToInt32(lbllokPost.Text));
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    DataRow row = ds.Tables[0].Rows[0];
            //    PostImage = Convert.ToString(row["Image_Name"]);



            //    //dlPostImage.DataSource = ds;
            //    //dlPostImage.DataBind();



            //    if ((PostImage == "") || (PostImage == null))
            //    {

            //        Image1.Visible = false; ;
            //        Image1.Dispose();// = true;
            //    }
            //    else
            //    {

            //        Image1.Visible = true; ;
            //    }


        }



    }

    protected void SearchButton_Click(object sender, EventArgs e)
    {
        //string searchURL = String.Format(SearchBox.Attributes["rel"], Request.Url.AbsolutePath, HttpUtility.UrlEncodeUnicode(SearchBox.Text));
        //Response.Redirect(searchURL, true);

        string Emailid = txtSearch.Value;

        special(Emailid);
        special2(Emailid);
    }
    protected void btnReplyClicked3(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int frindId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DateTime Postdate = DateTime.Now;

        DataSet ds = ClPost.Get_Check_Data_Folowers(Convert.ToInt32(userid), frindId, 0);

        if (ds.Tables[0].Rows.Count > 0)
        {

            return;

        }

        else
        {

            string articleId1 = ClPost.Insert_p_tbl_tbUser_Friends(Convert.ToInt32(userid), frindId, 0, false, Postdate, Postdate);


        }

        string Emailid = txtSearch.Value;

        special(Emailid);
        special2(Emailid);


    }
    protected void btnReplyClicked4(object sender, EventArgs e)
    {

        return;



    }

    protected void btnReplyClicked5(object sender, EventArgs e)
    {


        return;


    }

}



