﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Usercontrol_search : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SearchButton_Click(object sender, EventArgs e)
    {
       

        string Emailid = txtSearch.Value;

        if (Emailid == "")
        {

            return;
        }
        else
        {
            Response.Redirect("SearchBox.aspx?search" + Emailid + "&search=" + Emailid);
        }
    }
}