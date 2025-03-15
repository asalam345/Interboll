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

public partial class games_user_view_gameinformation : System.Web.UI.Page
{
    GameDbContext gameDbContext = new GameDbContext();
    static string getUserEmail;
    static int setEvent = 0, setTotalPage = 0, getTotalPage = 0, displayPerPage = 20;

    protected void Page_Load(object sender, EventArgs e)
    {
        string SelectedPage = Request.QueryString["page"];
        if (SelectedPage == null)
        {
            SelectedPage = "0";
        }
        if (!IsPostBack)
        {
            BindData(Convert.ToInt32(SelectedPage));
        }
    }

    protected void btSearch_Click(object sender, EventArgs e)
    {
        setEvent = 1;
        BindData(0);
    }

    protected void BindData(int SelectedPage)
    {
        DataTable dt = new DataTable();
        if (setEvent == 1)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@SearchText", txSearch.Text));
            dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Search", arrayList);
        }
        else
        {
            dt = gameDbContext.GetAllData_StoredProcedure("spGames_View_All");
        }
        
        PagedDataSource pageDataSource = new PagedDataSource();
        pageDataSource.DataSource = dt.DefaultView;
        pageDataSource.AllowPaging = true;
        pageDataSource.PageSize = displayPerPage;
       
        if (SelectedPage > (pageDataSource.PageCount - 1))
        {
            SelectedPage = pageDataSource.PageCount - 1;
        }
       
        if (SelectedPage < 0)
        {
            SelectedPage = 0;
        }
        
        pageDataSource.CurrentPageIndex = SelectedPage;

        rpView.DataSource = pageDataSource;
        rpView.DataBind();

        getTotalPage = Convert.ToInt32(pageDataSource.PageCount - 1);
        lbPassing.Text = "Current page " + SelectedPage + " out of " + getTotalPage;
        lbShowTotalMessage.Text = "Total " + dt.Rows.Count.ToString() + " data found";

        if (pageDataSource.IsLastPage)
        {
            btNext.Enabled = false;
            btLast.Enabled = false;
        }
        else
        {
            btNext.Enabled = true;
            btLast.Enabled = true;
        }

        if (pageDataSource.IsFirstPage)
        {
            btPrevious.Enabled = false;
            btFirst.Enabled = false;
        }
        else
        {
            btPrevious.Enabled = true;
            btFirst.Enabled = true;
        }

        if (pageDataSource.IsLastPage)
        {
            btNext.Text = "<i class='btn btn-default btn-sm fa fa-forward'></i>";
            btLast.Text = "<i class='btn btn-default btn-sm fa fa-step-forward'></i>";
        }
        else
        {
            btNext.Text = @"<a href=""?page=" + (SelectedPage + 1).ToString() + @"""><i class='btn btn-default btn-sm fa fa-forward'></i></a>";
            btLast.Text = @"<a href=""?page=" + Convert.ToInt32(pageDataSource.PageCount - 1) + @"""><i class='btn btn-default btn-sm fa fa-step-forward'></i></a>";
        }

        if (pageDataSource.IsFirstPage)
        {
            btPrevious.Text = "<i class='btn btn-default btn-sm fa fa-backward'></i>";
            btFirst.Text = "<i class='btn btn-default btn-sm fa fa-step-backward'></i>";
        }
        else
        {
            btPrevious.Text = @"<a href=""?page=" + (SelectedPage - 1).ToString() + @"""><i class='btn btn-default btn-sm fa fa-backward'></i></a>";
            btFirst.Text = @"<a href=""?page=" + 0 + @"""><i class='btn btn-default btn-sm fa fa-step-backward'></i></a>";
        }
    }

    protected string ShowTimeAgo(DateTime dt)
    {
        if (dt > DateTime.Now) return "Set time";

        TimeSpan span = DateTime.Now - dt;

        if (span.Days > 365)
        {
            int years = (span.Days / 365);
            if (span.Days % 365 != 0) years += 1;
            return String.Format("{0} {1} ago", years, years == 1 ? "year" : "years");
        }

        if (span.Days > 30)
        {
            int months = (span.Days / 30);
            if (span.Days % 31 != 0) months += 1;
            return String.Format("{0} {1} ago", months, months == 1 ? "month" : "months");
        }

        if (span.Days > 0) return String.Format("{0} {1} ago", span.Days, span.Days == 1 ? "day" : "days");

        if (span.Hours > 0) return String.Format("{0} {1} ago", span.Hours, span.Hours == 1 ? "hour" : "hours");

        if (span.Minutes > 0) return String.Format("{0} {1} ago", span.Minutes, span.Minutes == 1 ? "minute" : "minutes");

        if (span.Seconds > 5) return String.Format("{0} seconds ago", span.Seconds);

        if (span.Seconds <= 5) return "Just now";

        return string.Empty;
    }

    protected void rpView_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField hfGetId = e.Item.FindControl("hfGetId") as HiddenField;
        Int32 getId = Convert.ToInt32(hfGetId.Value);
        Label lbCreateDate = e.Item.FindControl("lbCreateDate") as Label;
       
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Id", arrayList);
            if (dt.Rows.Count > 0)
            {
                lbCreateDate.Text = ShowTimeAgo(Convert.ToDateTime(dt.Rows[0]["createdDate"]));
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btDelete_Click(object sender, EventArgs e)
    {
        LinkButton lbtn = (LinkButton)sender;
        RepeaterItem item = (RepeaterItem)lbtn.NamingContainer;
        HiddenField hfGetId = item.FindControl("hfGetId") as HiddenField;
        Int32 getId = Convert.ToInt32(hfGetId.Value);

        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_IsLock_Id", arrayList);
            if (dt.Rows.Count > 0)
            {
                ArrayList arrayList1 = new ArrayList();
                arrayList1.Add(new SqlParameter("@g_id", getId));
                arrayList1.Add(new SqlParameter("@isRemoved", false));
                gameDbContext.UpdateData_StoredProcedure("spGames_Lock_Unlock_Id", arrayList1);
            }
            else
            {
                ArrayList arrayList2 = new ArrayList();
                arrayList2.Add(new SqlParameter("@g_id", getId));
                arrayList2.Add(new SqlParameter("@isRemoved", true));
                gameDbContext.UpdateData_StoredProcedure("spGames_Lock_Unlock_Id", arrayList2);
            }
            
            divAlertDeleteSuccessMessage.Visible = true;

            string OriginalUrl = HttpContext.Current.Request.RawUrl;
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=" + OriginalUrl;
            this.Page.Controls.Add(meta);
        }
        catch (Exception ex)
        {
            lbErrorMessage.Text = ex.Message;
            divAlertErrorMessage.Visible = true;
        }
    }

    protected void btGoPage_Click(object sender, EventArgs e)
    {
        if (txGoPage.Text != string.Empty)
        {
            int pageCount = Convert.ToInt32(txGoPage.Text);
            
            if (pageCount > getTotalPage)
            {
                setTotalPage = 0;
            }
            else
            {
                setTotalPage = pageCount;
            }

            if (Request.QueryString["page"] != null)
            {
                string currentOldUrl = HttpContext.Current.Request.Url.PathAndQuery;
                string currentOldUrlValue = Request.QueryString["page"];
                string currentNewUrl = currentOldUrl.Replace("page=" + currentOldUrlValue, "page=" + setTotalPage.ToString());
                Response.Redirect(currentNewUrl);
            }
            else
            {
                var nameValues = System.Web.HttpUtility.ParseQueryString(Request.QueryString.ToString());
                nameValues.Set("page", setTotalPage.ToString());
                string currentOldUrl = HttpContext.Current.Request.Url.PathAndQuery;
                Response.Redirect(currentOldUrl + "?" + nameValues);
            }
        }
    }
}