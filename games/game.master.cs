using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Net;
using System.Configuration;

public partial class games_game : System.Web.UI.MasterPage
{
    GameDbContext gameDbContext = new GameDbContext();
    DataContext dataContext = new DataContext();
    static string getPlatform;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        getPlatform = Request.QueryString["platform"] != null ? Request.QueryString["platform"].ToString() : "Interboll";
        LoadHotGame(getPlatform);
        LoadBestPlayerGame(getPlatform);
        LoadCommingSoonGame(getPlatform);
    }

    protected void LoadHotGame(string platform)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Hot_Default", arrayList);
            rpGameDetailsHot.DataSource = dt;
            rpGameDetailsHot.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void LoadBestPlayerGame(string platform)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadGame_BestGamePlayer", arrayList);
            rpGamesBestPlayer.DataSource = dt;
            rpGamesBestPlayer.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void LoadCommingSoonGame(string platform)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadGame_CommingSoon", arrayList);
            rpGamesCommingSoon.DataSource = dt;
            rpGamesCommingSoon.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btSearchText_Click(object sender, EventArgs e)
    {
        Session["SearchText"] = txSearchGame.Text.Trim();
        Response.Redirect("game_search.aspx", true);
    }
}
