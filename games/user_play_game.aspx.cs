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

public partial class games_user_play_game : System.Web.UI.Page
{
    GameDbContext gameDbContext = new GameDbContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        string getId = Request.QueryString["id"];
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Id", arrayList);
            if (dt.Rows.Count > 0)
            {
                playGame.Attributes["src"] = dt.Rows[0]["g_url_or_pageName"].ToString();
                lbGameName.Text = dt.Rows[0]["g_name"].ToString();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}