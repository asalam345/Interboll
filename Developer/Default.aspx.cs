using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Developer_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public bool SignIn { set; get; }

    protected void btnDomainReg_Click(object sender, EventArgs e)
    {
        DataSet ds = Articles.List_of_Domain();
        DataTable dt = ds.Tables[0];
        long id = 0;
        if (dt.Rows.Count > 0)
        {
            id = Convert.ToInt64(dt.Rows[0][0]);
        }
        if(!String.IsNullOrEmpty(TextBoxUrl.Text))
        {
            SomeClasses sc = new SomeClasses();
            string sChar = sc.GenerateCharecter();
            DateTime c = DateTime.UtcNow;
            sChar = c.Day.ToString() + c.Month + c.Year.ToString() + c.Hour.ToString() + c.Minute.ToString() + c.Second + c.Millisecond.ToString() + "_" + sChar;

            try
            {
                Articles.OiiO_Domain_Insert(id + 1, TextBoxUrl.Text, sChar);
                lblSecretKey.Text = sChar;
            }
            catch(Exception ex)
            {
                lblSecretKey.Text = ex.ToString();
            }

        }

    }
   

   

    //public ActionResult NotValid(string message)
    //{
    //    ViewBag.Message = message;
    //    return View();
    //}

    //public ActionResult SignIn()
    //{
    //    return View();
    //}

   
}