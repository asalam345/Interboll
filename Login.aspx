<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
   
<br />
    
<div><p style="padding-left:45px;"><b><span style="font-size: 18pt; line-height: 115%; font-family: 'Arial','sans-serif';">Login Page For Admin<hr/></span></b></p></div>
   <br />

    <fieldset class="well the-fieldset">
        <%--<legend class="the-legend">Login</legend>--%>
   

    <asp:Login ID="LoginAdmin" DestinationPageUrl="productinsert2.aspx" runat="server" DisplayRememberMe="false"
BackColor="aliceblue" BorderColor="Black" BorderStyle="double"  OnLoggedIn="LoginAdmin_LoggedIn">
<LoginButtonStyle BackColor="darkblue" ForeColor="White" />
<TextBoxStyle BackColor="LightCyan" ForeColor="Black" Font-Bold="true" />
<TitleTextStyle Font-Italic="true" Font-Bold="true" Font-Names="Verdana" />
</asp:Login>
 </fieldset>
<br />
</asp:Content>

