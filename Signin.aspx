<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signin.aspx.cs" Inherits="Signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="col-sm-12">
                <div class="boxsocialwrap2">
                    <asp:Panel ID="panel" runat="server" DefaultButton="btnLogin">
                        <div class="row" style="margin-top: 1px">
                            <div class="col-sm-12">
                                <%--input type="text" class="input_text_ipacity" name="key" placeholder="Email"  name="Email" style="margin-bottom:7px" runat="server" id="Emailid">--%>
                                <asp:TextBox ID="UserName" runat="server" CssClass="input_text_ipacity" ValidationGroup="enter" placeholder="Username" name="loginname" type="text" autofocus="autofocus" />

                            </div>

                        </div>

                        <div class="row" style="margin-top: 8px">
                            <div class="col-sm-12">
                                <%-- <input type="text" class="input_text_ipacity" name="key" placeholder="Password"  name="Password" style="margin-bottom:7px" r>--%>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" class="input_text_ipacity" ValidationGroup="enter" placeholder="Password" name="password" type="password" value="" AutoComplete="off" />
                              <%--  <div style="">
                                    <input type="checkbox" name="logged" value="Keep me"><span style="color: #ffffff"> Keep me logged in</span>
                                </div>--%>
                                <div style=""><a style="color: #ffffff; margin-left: 18px" href="#">Forgotten your password?</a></div>
                                <asp:Label ID="labelMessage" runat="server"></asp:Label>
                                <asp:Literal runat="server" ID="FailureText" />
                            </div>

                        </div>
                        <img style="border: 0px; width: 100%; height: 79px; margin-top: 4px;" src="img/imglog.png"/>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <asp:LinkButton ID="btnLogin" class="btn-primary btnopacity" OnClick="btnLogin_Click" runat="server" Text="Log In"></asp:LinkButton>
                                                       
                            </div>
                        </div>
                    </asp:Panel>

                </div>
            </div>
    </div>
    </form>
</body>
</html>
