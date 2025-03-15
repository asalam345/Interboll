using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Text;
using System.IO;
using System.Xml.Linq;

public partial class IPAddress : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Path.GetFileName(Request.Url.AbsolutePath);
       // GetTimeZoneOffset(path);
    }

    public static int GetTimeZoneOffset(HttpRequest Request)
    {
        // Default to the server time zone
        TimeZone tz = TimeZone.CurrentTimeZone;
        TimeSpan ts = tz.GetUtcOffset(DateTime.Now);
        int result = (int)ts.TotalMinutes;
        // Then check for client time zone (minutes) in a cookie
        HttpCookie cookie = Request.Cookies["ClientTimeZone"];
        if (cookie != null)
        {
            int clientTimeZone;
            if (Int32.TryParse(cookie.Value, out clientTimeZone))
                result = clientTimeZone;
        }
        return result;
    }
}
