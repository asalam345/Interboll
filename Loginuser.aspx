<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Loginuser.aspx.cs" Inherits="Loginuser" %>

<title>Login/Sign-In</title>
    
   <head   id="Head1" runat="server">
    <link rel="stylesheet" href="css_sgin/normalize_sign.css">

    <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>

        <link rel="stylesheet" href="css_sgin/style_sign.css">

    
      <script type="text/javascript">
          $(document).ready(function () {
              if (window.location.search == "?about=SignUp") {
                  $("#signup").addClass("current");
                  $(".lgm-1").addClass("show");
                  $("#signid").removeClass("current");
                  $(".lgm-2").removeClass("show");
              }
          });
      </script>
          </head>

          <body>
                <form id="form1" runat="server" style="min-height:650px"> 
            <div class="logmod">
			<div style="margin:0 auto; text-align:center; min-height:80px; margin-top:10px">
			   <a href="Default.aspx"><img src="logo.png" border="0px"></a>
			</div>
			
            <div style="margin:0 auto; text-align:center; min-height:20px; margin-top:10px; color:White; padding-bottom:40px">
			         <asp:Label ID="labelMessage" runat="server"></asp:Label>
                     <asp:Literal runat="server" ID="FailureText" />
			</div>
          <div class="logmod__wrapper" style="height:580px; margin-bottom:50px">
            <span class="logmod__close">Close</span>
            <div class="logmod__container">
              <ul class="logmod__tabs">
                  <li data-tabtar="lgm-2" id="signid"><a href="#">Sign In</a></li>
                  <li data-tabtar="lgm-1" id="signup"><a href="#">Sign Up</a></li>
              </ul>
              <div class="logmod__tab-wrapper">
              <div class="logmod__tab lgm-1">
                <div class="logmod__heading">
                  <span class="logmod__heading-subtitle">Enter your personal details <strong>to create an acount</strong></span>
                </div>
                <div class="logmod__form">
                  <div accept-charset="utf-8" action="#" class="simform">
                   
                   
					   
					 <div class="sminputs">
                      <div class="input full">
                        <label class="string optional" for="user-name">Email Address*</label>
                     <%--   <input class="string optional" maxlength="255" id="user-email" placeholder="example@gmail.com" type="email" size="50" />--%>
                    
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="string optional" placeholder="example@gmail.com"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rbfEmail" runat="server" ControlToValidate="txtEmail"
                                        ForeColor="Red" ToolTip="Please enter your email" ErrorMessage="Please enter your email." Display="Dynamic" ValidationGroup="gen">
                                    </asp:RequiredFieldValidator>

                                    <asp:Label ID="lblEmail" runat="server">
                                        <asp:RegularExpressionValidator ID="rxvEmail" runat="server"
                                            ErrorMessage="Please enter valid email." ControlToValidate="txtEmail" Display="Dynamic"
                                            ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
                                            ForeColor="Red" ValidationGroup="gen">
                                        </asp:RegularExpressionValidator>
                                    </asp:Label>
                      </div>
                    </div>
					
                    </div>

					 <div class="sminputs">
                      <div class="input string optional">
                        <label class="string optional" for="user-pw">First Name</label>
                      <%--  <input class="string optional" maxlength="255" id="user-pw" placeholder="First Name" type="text" size="50" />--%>
                       <asp:TextBox ID="txtFirstName" runat="server" CssClass="string optional"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rbfFirstName" runat="server" ControlToValidate="txtFirstName" ForeColor="Red"
                                        ErrorMessage="PLease enter your first name."
                                        Display="Dynamic" ValidationGroup="gen"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblFirstName" runat="server"></asp:Label>
						<label class="string optional" for="user-pw-repeat">Last Name</label>
                      <%--  <input class="string optional" maxlength="255" id="user-pw-repeat" placeholder="Last Name" type="text" size="50" />--%>
                      <asp:TextBox ID="txtLastname" runat="server" CssClass="string optional"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rbfLastName" runat="server" ControlToValidate="txtLastname" ForeColor="Red"
                                        ToolTip="PLease enter your last name." ErrorMessage="PLease enter your last name.." Display="Dynamic" ValidationGroup="gen"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblLastName" runat="server"></asp:Label>
                      </div>
                      <div class="input string optional">
                          <label class="string optional" for="user-pw">Password *</label>
                       <%-- <input class="string optional" maxlength="255" id="user-pw" placeholder="Password" type="password" size="50" />--%>
              
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rbfPassword" runat="server" ControlToValidate="txtPassword"
                                        ErrorMessage="Please enter your password" ForeColor="Red" ToolTip="Please enter your password" Display="Dynamic"
                                        ValidationGroup="gen"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblPass" runat="server"></asp:Label>
								 
					   <label class="string optional" for="user-pw">Confirm Password*</label>
                       <%-- <input class="string optional" maxlength="255" id="user-pw" placeholder="Password" type="password" size="50" />--%>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="string optional"></asp:TextBox>

                                    <asp:RequiredFieldValidator ID="rbfConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword"
                                        ForeColor="Red" ErrorMessage="Please enter your confirm password" ToolTip="Please enter your confirm password"
                                        Display="Dynamic" ValidationGroup="gen"></asp:RequiredFieldValidator>


                                    <asp:Label ID="lblConPass" runat="server">
                                        <asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Password do not match!"
                                            ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword"
                                            Display="Dynamic" ForeColor="Red" ValidationGroup="gen"></asp:CompareValidator>
                                    </asp:Label>
                      </div>
                    </div>
					
				
					
					 <div class="sminputs">
                      <div class="input full">
                        <label class="string optional" for="user-name">Phone Number</label>
                       <%-- <input class="string optional" maxlength="255" id="user-email" placeholder="Phone Number" type="email" size="50" />--%>
                      
                                    <asp:TextBox ID="txtContactNo" runat="server" CssClass="form-control"></asp:TextBox>

                                    <asp:Label ID="lblMoile" runat="server"></asp:Label>
                      </div>
                    </div>
					
                    <div class="simform__actions">
                      <%--<input class="sumbit" name="commit" type="sumbit" value="Create Account" />--%>
                       <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="cancel2" OnClick="btnCancel_Click" />

                        <asp:Button ID="btn_CreateAccount" runat="server" class="sumbit1" Text="Create An Account"
                            OnClick="btn_CreateAccount_Click" ValidationGroup="gen"></asp:Button>

                      <span class="simform__actions-sidetext">By creating an account you agree to our <a class="special" href="#" target="_blank" role="link">Terms & Privacy</a></span>
                    </div>
                  </div>
                </div>
              
              </div>
              <div class="logmod__tab lgm-2">
                <div class="logmod__heading">
                  <span class="logmod__heading-subtitle">Enter your email and password <strong>to sign in</strong></span>
                </div>
                <div class="logmod__form">
                  <div accept-charset="utf-8" action="#" class="simform">
                    <div class="sminputs">
                      <div class="input full">
                       
                        <label class="string optional" for="user-name">Email*</label>
                  <%--      <input class="string optional" maxlength="255" id="user-email" placeholder="Email" type="email" size="50" />--%>
                  	 <asp:TextBox ID="UserName" runat="server" class="string optional" ValidationGroup="enter" placeholder="Username" name="loginname" type="text" autofocus="autofocus" />
                      </div>
                    </div>
                    <div class="sminputs">
                      <div class="input full">
                        <label class="string optional" for="user-pw">Password *</label>
                        <%--<input class="string optional" maxlength="255" id="user-pw" placeholder="Password" type="password" size="50" />--%>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="*" />
                                          
                          <asp:TextBox ID="Password" runat="server" TextMode="Password" class="string optional" ValidationGroup="enter" placeholder="Password" name="password"  type="password" value=""  AutoComplete="off" />
                                                <span class="hide-password">Show</span>
                      </div>
                    </div>
                      <asp:Literal runat="server" ID="Litgrp" Visible="false"/>
                    <div class="simform__actions">
                     <%-- <input class="sumbit" name="commit" type="sumbit" value="Log In" />--%>
                        <asp:Button ID="btnlogin" runat="server" OnClick="LogIn" Text="Log in" ValidationGroup="enter"  CssClass="sumbit" />
                      <span class="simform__actions-sidetext"><a class="special" role="link" href="#">Forgot your password?<br>Click here</a></span>
                    </div>
                  
                </div>
			    </div>
                  </div>
              </div>
         
         </div>
  </div>
  

            <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

        <script src="signjs/signin.js"></script>

    
    </form>
    
  </body>
</html>