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

public partial class games_game_search : System.Web.UI.Page
{
    GameDbContext gameDbContext = new GameDbContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@SearchText", Session["SearchText"].ToString()));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_Search", arrayList);
            rpGamesSearch.DataSource = dt;
            rpGamesSearch.DataBind();

            lbShowSearchText.Text = "You are searching by : " + Session["SearchText"].ToString() + " | About " + dt.Rows.Count.ToString() + " result found";
        }
        catch (Exception)
        {
            throw;
        }
    }
}