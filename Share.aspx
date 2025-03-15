<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Share.aspx.cs" Inherits="Share" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div id="htmlpage" runat="server"></div>
        <asp:Button ID="btnShare" runat="server" Text="Share" OnClick="btnShare_Click" /><asp:Button ID="btnCancel" OnClick="btnCancel_Click" runat="server" Text="Cancel" />
    </form>
</body>
</html>
