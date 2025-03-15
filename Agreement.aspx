<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Agreement.aspx.cs" Inherits="Agreement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
     
    <form id="form1" runat="server">
   <div>
        <p>If you click on agree button <asp:Label ID="lblUrl" runat="server" Text="Label"></asp:Label> get your email, first name, image from interboll.com</p>
       <asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </div>
    </form>
</body>
</html>
