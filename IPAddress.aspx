<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="IPAddress.aspx.cs" Inherits="IPAddress" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ip Address Location</title>

    <script language="javascript">
        function checkClientTimeZone() {
            // Set the client time zone
            var dt = new Date();
            SetCookieCrumb("ClientDateTime", dt.toString());

            var tz = -dt.getTimezoneOffset();
            SetCookieCrumb("ClientTimeZone", tz.toString());

            // Expire in one year
            dt.setYear(dt.getYear() + 1);
            SetCookieCrumb("expires", dt.toUTCString());
        }

        // Attach to the document onload event
        checkClientTimeZone();
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    </div>
    </form>
</body>
</html>