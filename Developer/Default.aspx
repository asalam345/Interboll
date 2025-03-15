<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Developer_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <fieldset style="width:auto;float:left;">
        <legend>Domain</legend>
         <p>
             <asp:Label ID="lblSecretKey" runat="server" Text="Label"></asp:Label>
         </p>
         <p>
         <asp:TextBox ID="TextBoxUrl" placeholder="Your Domain Name" style="width: 500px" runat="server"></asp:TextBox>
        </p>
        <p style="float:right; right:300px">
            <asp:Button ID="btnDomainReg" runat="server" Text="OK" OnClick="btnDomainReg_Click" style="width:100px;"/>
        </p>
         
    </fieldset>
        
    </div>
    </form>
</body>
</html>
