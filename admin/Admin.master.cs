﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Admin : System.Web.UI.MasterPage
{
    protected string domainRoot;
    protected void Page_Load(object sender, EventArgs e)
    {
        domainRoot = ResolveUrl("~/");
    }
}
