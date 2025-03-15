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

using System.Collections;

public partial class outlinedefault : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection(WebsiteConfig.ConnectionString);
    Byte Likeid1;
    Byte V_Status;
    static string getId, getPropertyTypeId, fullAddress;
    String ImagePostid;
    String PostImage;
    String P_Image;
    Byte F_Status;
    string category;
    Int32 CategoryProductId;
    Int32 CategoryBrand;
    string SessionValue = "";
    string x1;
    string x2;
    Int32 countryid = 1;
    protected void Page_Load(object sender, EventArgs e)
    {



        if (!Page.IsPostBack)
        {

            if (Session["User_Name"] == null)
            {


                Response.Redirect("Home.aspx", true);
                // Response.Redirect("Default.aspx");
            }

            string userid = Session["userid"].ToString();// = userid;
            lbllokUser.Text = userid;
            //  string s = (Session["User_Name"].ToString());

            loadPost();


        }

        //txtSearch.Text = false;

    }





    private void load_City()
    {

        DataSet ds = ClPost.List_ofCity();
        //ddlCity.DataSource = ds;
        //ddlCity.DataTextField = "Name";
        //ddlCity.DataValueField = "IID";
        //ddlCity.SelectedIndex = -1;
        //ddlCity.DataBind();

    }














    private void loadPost()
    {

        SqlConnection.ClearAllPools();
        con.Open();


        if (Session["CountryName"] == "")
        {

            lblContry.Text = "";
            Session["CountryName"] = "";
        }


        //lblContry.Text = Session["CountryName"].ToString();
        if (!string.IsNullOrEmpty(Session["CountryName"].ToString()))
        {

            lblContry.Text = Session["CountryName"].ToString();
        }
        else
        {
            lblContry.Text = "";

        }

        if (lblContry.Text == "Bangladesh")
        {
            countryid = 1;

        }

        else if (lblContry.Text == "United Kingdom")
        {

            countryid = 2;
        }

        else if (lblContry.Text == "India")
        {

            countryid = 3;
        }

        else if (lblContry.Text == "Sri Lanka")
        {

            countryid = 4;
        }

        else if (lblContry.Text == "Pakistan")
        {

            countryid = 5;
        }
        else if (lblContry.Text == "Maldives")
        {

            countryid = 6;
        }
        else if (lblContry.Text == "Bhutan")
        {

            countryid = 7;
        }
        else if (lblContry.Text == "Nepal")
        {

            countryid = 8;
        }


        else if (lblContry.Text == "China")
        {

            countryid = 9;
        }

        else if (lblContry.Text == "Japan")
        {

            countryid = 10;
        }

            //Pakistan
        //    Nepal      Maldives Bhutan  China

        else
        {
            countryid = 0;
        }

        string userid = Session["userid"].ToString();

        DataSet ds = ClPost.Get_user_Id_Wise_Post(userid, countryid);

        rptPost.DataSource = ds;
        rptPost.DataBind();
        con.Close();

    }










    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Label lblUserpost = (Label)e.Item.FindControl("lblpostid");
            Label lblP_Image = (Label)e.Item.FindControl("lblP_Image");
            Repeater childRepeater = (Repeater)e.Item.FindControl("rpttagpeople");

            ///
            Label lblUserId = (Label)e.Item.FindControl("lblUserId");




            //


            if (string.IsNullOrEmpty(lblP_Image.Text))
            {
                childRepeater.Visible = false;

            }
            else
            {

                childRepeater.Visible = true;
                DataSet ds2 = ClPost.List_of_Post_Wise_Tag(lblP_Image.Text);
                childRepeater.DataSource = ds2;
                childRepeater.DataBind();
            }


            Repeater rptLikeUser = (Repeater)e.Item.FindControl("rptLikeUser");

            Repeater rptShareUser = (Repeater)e.Item.FindControl("rptShareUser");








            DataSet ds = ClPost.List_of_Post_Id_Wise_Like(Convert.ToInt32(lblUserpost.Text), 2);

            rptLikeUser.DataSource = ds;
            rptLikeUser.DataBind();

            ds = ClPost.List_of_Post_Id_Wise_Like(Convert.ToInt32(lblUserpost.Text), 3);

            rptShareUser.DataSource = ds;
            rptShareUser.DataBind();



            //

            string userid = Session["userid"].ToString();
            ds = ClPost.Get_Check_Like(Convert.ToInt32(lblUserpost.Text), userid);

            Button lblLike111 = (Button)e.Item.FindControl("btnReply");
            Label lblgoogle = (Label)e.Item.FindControl("lblGooglee");
            //  Label lblgoogle = ri.FindControl("lblGooglee") as Label;
            Button share = (Button)e.Item.FindControl("Button4");

            // HtmlGenericControl map_canvas=ri.FindControl("map_canvas") as   HtmlGenericControl








            if (ds.Tables[0].Rows.Count > 0)
            {
                lblLike111.Text = "Liked";

            }
            else
            {

                lblLike111.Text = "Like";
            }

            DataSet ds1 = ClPost.Get_Check_Share_Post(Convert.ToInt32(lblUserpost.Text), userid);

            if (ds1.Tables[0].Rows.Count > 0)
            {
                share.Text = "Shared";

            }
            else
            {

                share.Text = "Share";
            }




            ds = ClPost.Get_Check_UserPost(Convert.ToInt32(lblUserpost.Text), userid);

            HtmlGenericControl EDited = (HtmlGenericControl)e.Item.FindControl("divEdited");

            Button deleteButton = (Button)e.Item.FindControl("deleteButton");


            if (ds.Tables[0].Rows.Count > 0)
            {

                EDited.Visible = true;
                deleteButton.Visible = true;

            }
            else
            {

                EDited.Visible = false;
                deleteButton.Visible = false;
                //  LinkButton1.Visible = false;
            }



            HtmlGenericControl divdav = (HtmlGenericControl)e.Item.FindControl("video");
            HtmlGenericControl divchek = (HtmlGenericControl)e.Item.FindControl("divchek");
            HtmlGenericControl embebded_Video = (HtmlGenericControl)e.Item.FindControl("embebded_Video");


            Label lblEVideo = (Label)e.Item.FindControl("lblEVideo");

            Label lblcheking = (Label)e.Item.FindControl("lblcheking");


            if (string.IsNullOrEmpty(lblcheking.Text))
            {
                divchek.Visible = false;


            }
            else
            {

                divchek.Visible = true;
            }
            
            if (string.IsNullOrEmpty(lblEVideo.Text))
            {
                embebded_Video.Visible = false;


            }
            else
            {
                embebded_Video.Visible = true;

            }


            divdav.Visible = false;
            string filepath;


            Image Image1 = (Image)e.Item.FindControl("Image1");


            string ext;
            ds = ClPost.Get_P_Id_User_Image(Convert.ToInt32(lblUserpost.Text));
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                PostImage = Convert.ToString(row["Image_Name"]);

                ext = Path.GetExtension(PostImage);

                if (ext == ".mp4")
                {
                    divdav.Visible = true;
                    //return;
                }

                else
                {
                    if ((PostImage == "") || (PostImage == null))
                    {

                        Image1.Visible = false; ;
                        Image1.Dispose();// = true;
                    }

                    else
                    {

                        Image1.Visible = true; ;
                    }
                    divdav.Visible = false;

                }
            }
            //

            Repeater dlPostImage = (Repeater)e.Item.FindControl("dlcomment");
            dlPostImage.Visible = true;
            ds1 = ClPost.List_of_Post_Wise_Comment(Convert.ToInt32(lblUserpost.Text));
            dlPostImage.DataSource = ds1;
            dlPostImage.DataBind();

        }





    }

    protected void btnReplyClicked1(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {

            Response.Redirect("Home.aspx", true);

        }
        int PostId = int.Parse((sender as Button).CommandArgument);




        Response.Redirect("Edit_Content.aspx?ID=" + StringCipher.Encrypt(PostId.ToString()), false);



    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        //if (e.CommandName == "Delete" && e.CommandArgument.ToString() != "")
        //{
        //    //              DoDelete then rebind


        //    SqlCommand SqlCmd = new SqlCommand("delete tbl_Employer_Detail where P_Detail_Id=@ID", con);
        //    SqlCmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = e.CommandArgument;

        //    SqlCmd.ExecuteNonQuery();

        //}
        //loadProject();

        //  LinkButton LinkButton1 = ri.FindControl("Button1") as LinkButton;
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














    protected void DataListBrand_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //  CheckBox chked_item = (CheckBox)DataListBrand.FindControl("CheckBoxListTest");
    }





    //for comment
    protected void dlcomment_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        string userid = Session["userid"].ToString();
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            //Button deleteButton1 = (Button)e.Item.FindControl("deleteButtoncomment");
            Label lblpcomtid = (Label)e.Item.FindControl("lblpcomtid");
            HtmlGenericControl divcomment = (HtmlGenericControl)e.Item.FindControl("deleteButtoncomment12");
            divcomment.Visible = false;
            DataSet ds = ClPost.Get_Check_UserPost_Comment_Check(Convert.ToInt32(lblpcomtid.Text), Convert.ToInt32(userid));
            if (ds.Tables[0].Rows.Count > 0)
            {


                // deleteButton1.Visible = true;
                divcomment.Visible = true;
            }
            else
            {


                // deleteButton1.Visible = false;
                divcomment.Visible = false;
            }


        }
    }


    protected void btnCommentDelete(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int PostId = int.Parse((sender as Button).CommandArgument);
        string userid = Session["userid"].ToString();


        ClPost.Delete_Post_Comment(PostId, Convert.ToInt32(userid));

        loadPost();



    }

}


