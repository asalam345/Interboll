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
using System.Web.UI.HtmlControls;

public partial class Default2 : System.Web.UI.Page
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


            BindItemsListFrndlist();
            //txtSearch.Visible = false;
            //txtSearch.Visible = false;

             
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





    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (post.Value == "")
        {

            return;
        }
        else
        {

            savedate();
            Response.Redirect("refresh2.aspx", true);
        }


    }



    private void savedate()
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        string userid = Session["userid"].ToString();// = userid;
        String User_Name = Session["User_Name"].ToString();// = ProviderUserName;







        if (string.IsNullOrEmpty(userid))
        {
            DataSet ds = ClPost.Get_User_Data_User_Name_Wise(User_Name);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                userid = Convert.ToString(ds.Tables[0].Rows[0]["IID"]);

            }
        }



        string tagid = Lblsname.Text;

        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        Byte PostType = 1;// Convert.ToByte(ddlPostType.SelectedItem.Value);
        Byte F_Status = 1;// Convert.ToByte(ddlFstatus.SelectedItem.Value);

        if (RadioButton1.Checked)
        {
            F_Status = 1;
        }

        else if (RadioButton2.Checked)
        {
            F_Status = 2;
        }
        else if (RadioButton3.Checked)
        {
            F_Status = 3;
        }
        else if (RadioButton4.Checked)
        {
            F_Status = 5;
        }
        else if (RadioButton5.Checked)
        {
            F_Status = 6;
        }
        else if (RadioButton6.Checked)
        {
            F_Status = 7;
        }


        if (RadioButton7.Checked)
        {
            PostType = 1;
        }
        else if (RadioButton8.Checked)
        {
            PostType = 2;
        }
        // my_control is TextBox
        // my_control.text = "";
        //Label1
        //  string checkin = ddlCity.SelectedItem.Text;
        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {

            ClPost.Update_tbl_Post(hidArticleId.Value, "", post.InnerText, 1, 1, Convert.ToInt32(userid), PostType, Post_Date, Lblsname.Text, 1, F_Status, my_control.Text,"");
        }
        else
        {
            string articleId = ClPost.Insert_Add_tbl_Post("", post.InnerText, 1, 1, Convert.ToInt32(userid), PostType, Post_Date, Lblsname.Text, 1, F_Status, my_control.Text,"");


        }


        if (!string.IsNullOrEmpty(hidArticleId.Value))
        {
            ImagePostid = hidArticleId.Value;
        }

        else
        {
            DataSet ds = ClPost.Get_Max_P_Id_User_Wise(Convert.ToInt32(userid));

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                ImagePostid = Convert.ToString(row["P_Id"]);


            }

        }

        if (!string.IsNullOrEmpty(Lblsname.Text))
        {
            tagadd(ImagePostid);

        }



        if (file_upload.HasFile)
        {
            foreach (HttpPostedFile postedFile in file_upload.PostedFiles)
            {
                string fileName = System.DateTime.Now.ToString("_ddMMyyhhmmss") + Path.GetFileName(postedFile.FileName);
                file_upload.SaveAs(Server.MapPath("~/images/Items/" + fileName));// + Path.GetFileName(file.FileName));
                string articleId = ClPost.Insert_Post_Pic(Convert.ToInt32(ImagePostid), Convert.ToInt32(userid), fileName, fileName);
            }
        }

        post.Value = "";
        loadPost();
    }



    private void tagadd(string ImagePostid1)
    {
        DateTime Post_Date = Convert.ToDateTime(DateTime.Today.ToShortDateString());
        string userid = Session["userid"].ToString();
        string s = Lblsname.Text;
        string[] values = s.Split(',');
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = values[i].Trim();

            string articleId1 = ClPost.Insert_Add_tbl_Tag(Convert.ToInt32(ImagePostid1), Convert.ToInt32(values[i].ToString()), Convert.ToInt32(userid), Post_Date, 1, 1);

        }

    }

    private void loadPost()
    {

        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.List_of_Post(userid,1);

        rptPost.DataSource = ds;
        rptPost.DataBind();
        con.Close();

    }





    protected void btnReplyClicked(object sender, EventArgs e)
    {
        //after fire Like Code
        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Check_Like_clik(PostId, userid);
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





    }
    protected void RepeaterItemCreated(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Label lblUserpost = (Label)e.Item.FindControl("lblpostid");
            Label lblP_Image = (Label)e.Item.FindControl("lblP_Image");
            Repeater childRepeater = (Repeater)e.Item.FindControl("rpttagpeople");

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


        }



        foreach (RepeaterItem ri in rptPost.Items)
        {
            Label lblUserpost = ri.FindControl("lblpostid") as Label;
            Label lblUserId = ri.FindControl("lblUserid") as Label;
            Label lblP_Image = ri.FindControl("lblP_Image") as Label;


            if (lblUserpost != null)
            {
                lbllokPost.Text = lblUserpost.Text;
                lbllokUser.Text = lblUserId.Text;

            }





            string userid = Session["userid"].ToString();
            DataSet ds = ClPost.Get_Check_Like(Convert.ToInt32(lbllokPost.Text), userid);
            Button lblLike111 = ri.FindControl("btnReply") as Button;
            Label lblgoogle = ri.FindControl("lblGooglee") as Label;

            // HtmlGenericControl map_canvas=ri.FindControl("map_canvas") as   HtmlGenericControl
            Button share = ri.FindControl("Button4") as Button;




            if (ds.Tables[0].Rows.Count > 0)
            {
                lblLike111.Text = "Liked";

            }
            else
            {

                lblLike111.Text = "Like";
            }

            DataSet ds1 = ClPost.Get_Check_Share_Post(Convert.ToInt32(lbllokPost.Text), userid);

            if (ds1.Tables[0].Rows.Count > 0)
            {
                share.Text = "Shared";

            }
            else
            {

                share.Text = "Share";
            }




            ds = ClPost.Get_Check_UserPost(Convert.ToInt32(lbllokPost.Text), userid);
            Button btnedit = ri.FindControl("Button1") as Button;
            Button deleteButton = ri.FindControl("deleteButton") as Button;

            if (ds.Tables[0].Rows.Count > 0)
            {

                btnedit.Visible = true;
                deleteButton.Visible = true;

            }
            else
            {

                btnedit.Visible = false;
                deleteButton.Visible = false;
                //  LinkButton1.Visible = false;
            }

            HtmlGenericControl divdav = ri.FindControl("video") as HtmlGenericControl;
            divdav.Visible = false;
            string filepath;
            Image Image1 = ri.FindControl("Image1") as Image;

            string ext;
            ds = ClPost.Get_P_Id_User_Image(Convert.ToInt32(lbllokPost.Text));
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








        }

    }



    protected void RepeaterItemCreated1(object sender, RepeaterItemEventArgs e)
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

            Button btnedit = (Button)e.Item.FindControl("Button1");

            Button deleteButton = (Button)e.Item.FindControl("deleteButton");


            if (ds.Tables[0].Rows.Count > 0)
            {

                btnedit.Visible = true;
                deleteButton.Visible = true;

            }
            else
            {

                btnedit.Visible = false;
                deleteButton.Visible = false;
                //  LinkButton1.Visible = false;
            }



            HtmlGenericControl divdav = (HtmlGenericControl)e.Item.FindControl("video");


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

        //DataSet ds = ClPost.Get_Post_Post_Id_Wise(PostId);

        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    DataRow row = ds.Tables[0].Rows[0];
        //    hidArticleId.Value = Convert.ToString(row["P_Id"]);
        //    post.Value = Convert.ToString(row["P_Description"]);
        // //   V_Status = Convert.ToByte(ds.Tables[0].Rows[0]["V_Status"]);
        //   // F_Status = Convert.ToByte(ds.Tables[0].Rows[0]["F_Status"]);

        //}


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

    protected void btnReplyDelete(object sender, EventArgs e)
    {

        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }


        int PostId = int.Parse((sender as Button).CommandArgument);
        string userid = Session["userid"].ToString();


        ClPost.Update_Post_Status(PostId, Convert.ToInt32(userid), 2);

        loadPost();



    }



    protected void btnShareClicked(object sender, EventArgs e)
    {
        //Like Code
        if (Session["User_Name"] == null)
        {


            Response.Redirect("Home.aspx", true);
            // Response.Redirect("Default.aspx");
        }

        int PostId = int.Parse((sender as Button).CommandArgument);

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_Check_Share(PostId, userid);
        DateTime Postdate = DateTime.Now;
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow row = ds.Tables[0].Rows[0];
            Byte Likeid = Convert.ToByte(row["Share_Type"]);

            if (Likeid == 0)
            {
                Likeid1 = 1;

            }

            else if (Likeid == 1)
            {
                Likeid1 = 0;

            }




            ClPost.Updade_tbl_Share(PostId, Convert.ToInt32(userid), Postdate, Likeid1);
            loadPost();
            return;
        }

        else
        {


            string articleId1 = ClPost.Insert_Add_tbl_Share(PostId, Convert.ToInt32(userid), Postdate, 1, 1);
            loadPost();
            return;
        }


        //foreach (RepeaterItem item in rptPost.Items)
        //{
        //  //  TextBox tb = item.FindControl(PostId) as TextBox;



        //}




    }



    protected void BindItemsListFrndlist()
    {


        SqlConnection.ClearAllPools();
        con.Open();

        string userid = Session["userid"].ToString();
        DataSet ds = ClPost.Get_user_Id_Wise_Frndlist(userid);

        dlfrndlist.DataSource = ds;
        dlfrndlist.DataBind();

        con.Close();
    }




    protected void DataListBrand_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //  CheckBox chked_item = (CheckBox)DataListBrand.FindControl("CheckBoxListTest");
    }

    protected void CheckBoxListTest_SelectedIndexChanged(object sender, EventArgs e)
    {
        // GetCheckedBox_Brand();
        //  Label ID = DataListBrand.Items[i].FindControl("Label3") as Label;
        GetCheckedBox_Datalist(dlfrndlist, 1);
        Label7.Text = "";
    }

    protected void GetCheckedBox_Datalist(DataList dname, Byte did)
    {

        Int32 Category = 0;
        // string SessionValue = "";
        string daysrequested = "";

        int count = dname.Items.Count;
        for (int i = 0; i < count; i++)
        {
            CheckBox chk = dname.Items[i].FindControl("chkbox") as CheckBox;
            if (chk.Checked)
            {

                Label ID = dname.Items[i].FindControl("Label3") as Label;
                Label catID = dname.Items[i].FindControl("Label4") as Label;

                String id1 = ID.Text;
                category = catID.Text;



                if (id1 != null)
                {
                    Category = Convert.ToInt32(ID.Text);

                    if (SessionValue == "")
                        SessionValue = Category.ToString();
                    else
                        SessionValue = SessionValue + "," + Category.ToString();

                    //subcatename = suname;



                }


                Lblsname.Text = SessionValue;

                //Session["daysre"] = daysrequested;
                /// Lblsname.Text = Session["subcatename"] + "," + subcatename;



                // +"," + x2;

                //  Session["genderList"] = subcatename;



            }




        }




    }

}



