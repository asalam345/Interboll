<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 
<div class="registration_aection">
			<div class="container">
			        <div style="margin-top: 160px;"></div>
				<div class="col-md-4 col-md-offset-4">
					<h3 class="text-center">Log in here</h3>
					<div class="panel panel-default" style="">
						<div class="panel-heading"><span>Sign in to continue</span></div>
						<div class="panel-body">
							<div class="form-group">
							 <asp:TextBox ID="UserName" runat="server" class="form-control" ValidationGroup="enter" placeholder="Username" name="loginname" type="text" autofocus="autofocus" />
					
							</div>
					 <p class="text-danger">
                                <asp:Literal runat="server" ID="FailureText" />
                            </p>
							<div class="form-group ">
								
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="*" />
                                          
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" class="form-control" ValidationGroup="enter" placeholder="Password" name="password"  type="password" value=""  AutoComplete="off" />
							</div>														
						 <div class="checkbox">
                                            <label>
                                                <asp:CheckBox runat="server" ID="RememberMe" />
                                                <asp:Label ID="Label1" runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                                            </label>
                                        </div>
							
						
						</div>
                         <asp:Button ID="btnlogin" runat="server" OnClick="LogIn" Text="Log in" ValidationGroup="enter"  CssClass="btn btn-lg btn-primary btn-block" />
						   <div class="panel-footer">                                        
                                       
                                         <asp:Literal runat="server" ID="Litgrp" Visible="false"/>
                                         <a href=Login_Forget_password.aspx> Forget Password</a>
                                    </div>
                                </div>

    </div>
    </div>
    </div>
</asp:Content>

