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

public partial class games_user_gameinformation : System.Web.UI.Page
{
    GameDbContext gameDbContext = new GameDbContext();
    DataContext dataContext = new DataContext();
    static string getUserId, getId, getName, Filepath1, Filepath2, getImageFromDBA, getVideoFromDBA;

    protected void Page_Load(object sender, EventArgs e)
    {
        getId = Request.QueryString["action"] != null ? Request.QueryString["action"] : null;
        getUserId = Session["userid"] != null ? Session["userid"].ToString() : null;

        if (!IsPostBack)
        {
            LoadPlatForm();
            LoadCategory();
            LoadType();
            LoadPriceType();
            LoadCurrency();
            LoadGameStatus();
        }

        if (getId != null)
        {
            lbBodyHeader.Text = "Update Game Information";
            btSave.Visible = false;
            btUpdate.Visible = true;

            if (!IsPostBack)
            {
                EditData();
            }
        }
        else
        {
            lbBodyHeader.Text = "New Game Information";
            btSave.Visible = true;
            btUpdate.Visible = false;
        }
    }

    protected void LoadPlatForm()
    {
        List<string> list = dataContext.GetPlatForm();
        ddPlatform.DataSource = list;
        ddPlatform.DataBind();
    }

    protected void LoadCategory()
    {
        List<Category> list1 = dataContext.GetGameCategory();
        ddCategory.DataSource = list1;
        ddCategory.DataTextField = "catName";
        ddCategory.DataValueField = "catId";
        ddCategory.DataBind();
    }

    protected void LoadType()
    {
        if (ddCategory.SelectedItem != null)
        {
            List<Type> list2 = dataContext.GetGameType();
            ddType.DataSource = list2.Where(n => n.catId == Convert.ToInt32(ddCategory.SelectedItem.Value)).ToList();
            ddType.DataTextField = "typeName";
            ddType.DataValueField = "typeId";
            ddType.DataBind();
        }
    }

    protected void LoadPriceType()
    {
        List<string> list3 = dataContext.GetPriceType();
        ddPriceType.DataSource = list3;
        ddPriceType.DataBind();
    }

    protected void LoadCurrency()
    {
        List<string> list4 = dataContext.GetDefaultCurrency();
        ddCurrency.DataSource = list4;
        ddCurrency.DataBind();
    }

    protected void LoadGameStatus()
    {
        List<Status> list5 = dataContext.GetGameStatus();
        ddGameStatus.DataSource = list5;
        ddGameStatus.DataTextField = "s_name";
        ddGameStatus.DataValueField = "s_id";
        ddGameStatus.DataBind();
    }

    protected void ddCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadType();
    }

    protected void btSave_Click(object sender, EventArgs e)
    {
        try
        {
            SaveImageA(true);
            SaveVideoA(true);
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_platform", ddPlatform.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_category", ddCategory.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_type", ddType.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_name", txTitle.Text));
            arrayList.Add(new SqlParameter("@g_image", Filepath1));
            arrayList.Add(new SqlParameter("@g_video", Filepath2));
            arrayList.Add(new SqlParameter("@g_url_or_pageName", txURLorPageName.Text));
            arrayList.Add(new SqlParameter("@g_details", txDetails.Text));
            arrayList.Add(new SqlParameter("@g_priceType", ddPriceType.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_price", txPrice.Text));
            arrayList.Add(new SqlParameter("@g_priceCurrency", ddCurrency.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_poweredBy", txPoweredBy.Text));
            arrayList.Add(new SqlParameter("@userType", "Admin"));
            arrayList.Add(new SqlParameter("@userId", getUserId));
            arrayList.Add(new SqlParameter("@isComming", ddGameStatus.SelectedItem.Value));
            gameDbContext.SaveData_StoredProcedure("spGames_Insert", arrayList);
            
            divAlertSavedSuccessMessage.Visible = true;

            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=user_view_gameinformation.aspx";
            this.Page.Controls.Add(meta);
        }
        catch (Exception ex)
        {
            divAlertErrorMessage.Visible = true;
            lbErrorMessage.Text = ex.Message;
        }
    }

    protected void EditData()
    {
        try
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            DataTable dt = gameDbContext.GetSelectedData_StoredProcedure("spGames_View_Id", arrayList);
            if (dt.Rows.Count > 0)
            {
                ddPlatform.SelectedIndex = ddPlatform.Items.IndexOf(ddPlatform.Items.FindByText(dt.Rows[0]["g_platform"].ToString()));
                ddCategory.SelectedIndex = ddCategory.Items.IndexOf(ddCategory.Items.FindByText(dt.Rows[0]["g_category"].ToString()));
                LoadType();
                ddType.SelectedIndex = ddType.Items.IndexOf(ddType.Items.FindByText(dt.Rows[0]["g_type"].ToString()));
                txTitle.Text = dt.Rows[0]["g_name"].ToString();
                txURLorPageName.Text = dt.Rows[0]["g_url_or_pageName"].ToString();
                txDetails.Text = dt.Rows[0]["g_details"].ToString();
                ddPriceType.SelectedIndex = ddPriceType.Items.IndexOf(ddPriceType.Items.FindByText(dt.Rows[0]["g_priceType"].ToString()));
                ddCurrency.SelectedIndex = ddCurrency.Items.IndexOf(ddCurrency.Items.FindByText(dt.Rows[0]["g_priceCurrency"].ToString()));
                txPrice.Text = dt.Rows[0]["g_price"].ToString();
                txPoweredBy.Text = dt.Rows[0]["g_poweredBy"].ToString();
                ddGameStatus.SelectedIndex = ddGameStatus.Items.IndexOf(ddGameStatus.Items.FindByValue(dt.Rows[0]["isComming"].ToString()));
                imgShowA.ImageUrl = dt.Rows[0]["g_image"].ToString();
                getImageFromDBA = dt.Rows[0]["g_image"].ToString();
                videoShowA.Attributes["src"] = dt.Rows[0]["g_video"].ToString();
                getVideoFromDBA = dt.Rows[0]["g_video"].ToString();
            }
        }
        catch (Exception ex)
        {
            divAlertErrorMessage.Visible = true;
            lbErrorMessage.Text = ex.Message;
        }
    }

    protected void btUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            SaveImageA(false);
            SaveVideoA(false);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new SqlParameter("@g_id", getId));
            arrayList.Add(new SqlParameter("@g_platform", ddPlatform.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_category", ddCategory.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_type", ddType.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_name", txTitle.Text));
            arrayList.Add(new SqlParameter("@g_image", Filepath1));
            arrayList.Add(new SqlParameter("@g_video", Filepath2));
            arrayList.Add(new SqlParameter("@g_url_or_pageName", txURLorPageName.Text));
            arrayList.Add(new SqlParameter("@g_details", txDetails.Text));
            arrayList.Add(new SqlParameter("@g_priceType", ddPriceType.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_price", txPrice.Text));
            arrayList.Add(new SqlParameter("@g_priceCurrency", ddCurrency.SelectedItem.Text));
            arrayList.Add(new SqlParameter("@g_poweredBy", txPoweredBy.Text));
            arrayList.Add(new SqlParameter("@isComming", ddGameStatus.SelectedItem.Value));
            gameDbContext.UpdateData_StoredProcedure("spGames_Update", arrayList);

            divAlertUpdateSuccessMessage.Visible = true;

            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=user_view_gameinformation.aspx";
            this.Page.Controls.Add(meta);
        }
        catch (Exception ex)
        {
            divAlertErrorMessage.Visible = true;
            lbErrorMessage.Text = ex.Message;
        }
    }

    protected void SaveImageA(bool isSave)
    {
        string setServer_ImagePath = "Images/Game";
        string setBlank_ImagePath = "";

        if (FileUpload1.HasFile && FileUpload1.PostedFile != null)
        {
            string getImagePath = gameDbContext.Upload_ImagePath_A(FileUpload1.PostedFile, setServer_ImagePath);
            string getSubString = getImagePath.Substring(0, 5);
            if (getSubString != "Sorry")
            {
                Filepath1 = getImagePath;
                imgShowA.ImageUrl = getImagePath;
                lbPhotoMessageA.Text = "Done! Image Path - " + getImagePath;
                lbPhotoMessageA.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                if (isSave == true)
                {
                    Filepath1 = setBlank_ImagePath;
                }
                else
                {
                    Filepath1 = getImageFromDBA;
                }
                lbPhotoMessageA.Text = getImagePath;
                lbPhotoMessageA.ForeColor = System.Drawing.Color.Red;
            }
        }
        else
        {
            if (isSave == true)
            {
                Filepath1 = setBlank_ImagePath;
                lbPhotoMessageA.Text = "Done! With blank image";
            }
            else
            {
                Filepath1 = getImageFromDBA;
                lbPhotoMessageA.Text = "Done! With previous image";
            }
            lbPhotoMessageA.ForeColor = System.Drawing.Color.Green;
        }
    }

    protected void SaveVideoA(bool isSave)
    {
        string setServer_VideoPath = "Videos/Game";
        string setBlank_VideoPath = "";

        if (FileUpload2.HasFile && FileUpload2.PostedFile != null)
        {
            string getVideoPath = gameDbContext.Upload_Video_A(FileUpload2.PostedFile, setServer_VideoPath);
            string getSubString = getVideoPath.Substring(0, 5);
            if (getSubString != "Sorry")
            {
                Filepath2 = getVideoPath;
                videoShowA.Attributes["src"] = getVideoPath;
                lbVideoMessageA.Text = "Done! Video Path - " + getVideoPath;
                lbVideoMessageA.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                if (isSave == true)
                {
                    Filepath2 = setBlank_VideoPath;
                }
                else
                {
                    Filepath2 = getVideoFromDBA;
                }
                lbVideoMessageA.Text = getVideoPath;
                lbVideoMessageA.ForeColor = System.Drawing.Color.Red;
            }
        }
        else
        {
            if (isSave == true)
            {
                Filepath2 = setBlank_VideoPath;
                lbVideoMessageA.Text = "Done! With blank video";
            }
            else
            {
                Filepath2 = getVideoFromDBA;
                lbVideoMessageA.Text = "Done! With previous video";
            }
            lbVideoMessageA.ForeColor = System.Drawing.Color.Green;
        }
    }
}