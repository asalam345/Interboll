using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Configuration;
using System.Drawing;
using System.Collections;
using System.Web.UI.HtmlControls;

public partial class games_game_details : System.Web.UI.Page
{
    GameDbContext gameDbContext = new GameDbContext();
    static string getId, getSessionId, type;
    protected void Page_Load(object sender, EventArgs e)
    {
        getId = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : null;
        getSessionId = Session["userid"] != null ? Session["userid"].ToString() : HttpContext.Current.Session.SessionID;

        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            gameDbContext.UpdateData_StoredProcedure("spGames_Update_Viewed", arrayList);
        }
        catch (Exception)
        {
            throw;
        }
       
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Id", arrayList);
            if (dt.Rows.Count > 0)
            {
                playGame.Attributes["src"] = dt.Rows[0]["g_url_or_pageName"].ToString();
                type = dt.Rows[0]["g_type"].ToString();
                string img = dt.Rows[0]["g_image"] != "" ? dt.Rows[0]["g_image"].ToString() : null;
                if (img != null)
                {
                    imgShow.Attributes["data-src"] = img;
                }
                string video = dt.Rows[0]["g_video"] != "" ? dt.Rows[0]["g_video"].ToString() : null;
                if(video != null)
                {
                    videoShowA.Attributes["src"] = video;
                }
                lbGameName.Text = dt.Rows[0]["g_name"].ToString();
                int view = Convert.ToInt32(dt.Rows[0]["g_hit"].ToString());
                int rating = Convert.ToInt32(dt.Rows[0]["rating"].ToString());
                int like = Convert.ToInt32(dt.Rows[0]["liked"].ToString());
                int comments = Convert.ToInt32(dt.Rows[0]["getCount"].ToString());
                Rating1.CurrentRating = rating;
                lblRatingStatus.Text = "<i class='fa fa-eye'></i> " + view + " | <i class='fa fa-star'></i> " + rating + " | <i class='fa fa-hand-o-right'></i> " + like + " | <i class='fa fa-comment-o'></i> " + comments;
            }
        }
        catch (Exception)
        {
            throw;
        }

        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_type", type));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Hot", arrayList);
            rpGameDetailsHot.DataSource = dt;
            rpGameDetailsHot.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void Rating1_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
    {
        try
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(new SqlParameter("@g_id", getId));
            arrayList1.Add(new SqlParameter("@u_id", getSessionId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spRating_Check_Insert", arrayList1);
            if (dt.Rows.Count == 0)
            {
                ArrayList arrayList = new ArrayList();
                arrayList.Add(new SqlParameter("@g_id", getId));
                arrayList.Add(new SqlParameter("@u_id", getSessionId));
                arrayList.Add(new SqlParameter("@rating", e.Value));
                gameDbContext.SaveData_StoredProcedure("spRating_Insert", arrayList);
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            else
            {
                Response.Write("<script>alert('You have already done this rating.');</script>");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void lbtLike_Click(object sender, EventArgs e)
    {
        try
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(new SqlParameter("@g_id", getId));
            arrayList1.Add(new SqlParameter("@u_id", getSessionId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLiked_Check_Insert", arrayList1);
            if (dt.Rows.Count == 0)
            {
                ArrayList arrayList = new ArrayList();
                arrayList.Add(new SqlParameter("@g_id", getId));
                arrayList.Add(new SqlParameter("@u_id", getSessionId));
                arrayList.Add(new SqlParameter("@liked", 1));
                gameDbContext.SaveData_StoredProcedure("spLiked_Insert", arrayList);
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            else
            {
                Response.Write("<script>alert('You have already liked this.');</script>");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void btSave_Click(object sender, EventArgs e)
    {
        try
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(new SqlParameter("@g_id", getId));
            arrayList1.Add(new SqlParameter("@u_id", getSessionId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_Comments_Check_Insert", arrayList1);
            if (dt.Rows.Count == 0)
            {
                ArrayList arrayList = new ArrayList();
                arrayList.Add(new SqlParameter("@g_id", getId));
                arrayList.Add(new SqlParameter("@u_id", getSessionId));
                arrayList.Add(new SqlParameter("@g_comments", txComments.Text));
                gameDbContext.SaveData_StoredProcedure("spGames_Comments_Insert", arrayList);
                txComments.Text = "";
                Response.Write("<script>alert('Thank you for comment');</script>");
            }
            else
            {
                Response.Write("<script>alert('You have already comment this.');</script>");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}