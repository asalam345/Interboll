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

public partial class games_Default : System.Web.UI.Page
{
    GameDbContext gameDbContext = new GameDbContext();
    DataContext dataContext = new DataContext();
    static string getPlatform;

    protected void Page_Load(object sender, EventArgs e)
    {
        getPlatform = Request.QueryString["platform"] != null ? Request.QueryString["platform"].ToString() : "Interboll";
        LoadHomeGame(getPlatform);
        LoadTopChartGame(getPlatform);
        LoadCasualGame(getPlatform, "Casual");
        LoadBattleGame(getPlatform, "Battle");
        LoadCasinoGame(getPlatform, "Casino");
    }

    protected void LoadCasinoGame(string platform, string category)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            arrayList.Add(new SqlParameter("@g_category", category));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Category", arrayList);
            rpGamesCasino.DataSource = dt;
            rpGamesCasino.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void LoadBattleGame(string platform, string category)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            arrayList.Add(new SqlParameter("@g_category", category));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Category", arrayList);
            rpGamesBattle.DataSource = dt;
            rpGamesBattle.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void LoadCasualGame(string platform, string category)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            arrayList.Add(new SqlParameter("@g_category", category));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Category", arrayList);
            rpGamesCasual.DataSource = dt;
            rpGamesCasual.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void LoadTopChartGame(string platform)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_AllByPlatform", arrayList);
            rpGamesTopChart.DataSource = dt;
            rpGamesTopChart.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void LoadHomeGame(string platform)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", platform));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_AllByPlatform", arrayList);
            rpGamesHome.DataSource = dt;
            rpGamesHome.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void rpGamesCasino_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            HiddenField hfGamePlatform = e.Item.FindControl("hfGamePlatform") as HiddenField;
            string getPlatform = hfGamePlatform.Value.ToString();
            HiddenField hfGameType = e.Item.FindControl("hfGameType") as HiddenField;
            string getType = hfGameType.Value.ToString();
            Repeater subRepeater = e.Item.FindControl("rpGamesTypeInner") as Repeater;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", getPlatform));
            arrayList.Add(new SqlParameter("@g_type", getType));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadHomePageGame", arrayList);
            subRepeater.DataSource = dt;
            subRepeater.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected void rpGamesBattle_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            HiddenField hfGamePlatform = e.Item.FindControl("hfGamePlatform") as HiddenField;
            string getPlatform = hfGamePlatform.Value.ToString();
            HiddenField hfGameType = e.Item.FindControl("hfGameType") as HiddenField;
            string getType = hfGameType.Value.ToString();
            Repeater subRepeater = e.Item.FindControl("rpGamesTypeInner") as Repeater;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", getPlatform));
            arrayList.Add(new SqlParameter("@g_type", getType));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadHomePageGame", arrayList);
            subRepeater.DataSource = dt;
            subRepeater.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected void rpGamesCasual_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            HiddenField hfGamePlatform = e.Item.FindControl("hfGamePlatform") as HiddenField;
            string getPlatform = hfGamePlatform.Value.ToString();
            HiddenField hfGameType = e.Item.FindControl("hfGameType") as HiddenField;
            string getType = hfGameType.Value.ToString();
            Repeater subRepeater = e.Item.FindControl("rpGamesTypeInner") as Repeater;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", getPlatform));
            arrayList.Add(new SqlParameter("@g_type", getType));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadHomePageGame", arrayList);
            subRepeater.DataSource = dt;
            subRepeater.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected void rpGamesTopChart_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            HiddenField hfGamePlatform = e.Item.FindControl("hfGamePlatform") as HiddenField;
            string getPlatform = hfGamePlatform.Value.ToString();
            HiddenField hfGameType = e.Item.FindControl("hfGameType") as HiddenField;
            string getType = hfGameType.Value.ToString();
            Repeater subRepeater = e.Item.FindControl("rpGamesTypeInner") as Repeater;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", getPlatform));
            arrayList.Add(new SqlParameter("@g_type", getType));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadGameTopChart", arrayList);
            subRepeater.DataSource = dt;
            subRepeater.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected void rpGamesHome_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            HiddenField hfGamePlatform = e.Item.FindControl("hfGamePlatform") as HiddenField;
            string getPlatform = hfGamePlatform.Value.ToString();
            HiddenField hfGameType = e.Item.FindControl("hfGameType") as HiddenField;
            string getType = hfGameType.Value.ToString();
            Repeater subRepeater = e.Item.FindControl("rpGamesTypeInner") as Repeater;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", getPlatform));
            arrayList.Add(new SqlParameter("@g_type", getType));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spLoadHomePageGame", arrayList);
            subRepeater.DataSource = dt;
            subRepeater.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}