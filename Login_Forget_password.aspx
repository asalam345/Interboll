<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login_Forget_password.aspx.cs" Inherits="Login_Forget_password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

		<div class="center">

<!--content-start-->
 <div id="content" class="">
        <!--container-start-->             
<div class="container">
   <div class="row">
						<div class="col-md-6 col-md-offset-3">
          
       
                    <h3 style="text-align:center;background-color:Blue;">Forget Password</h3>
                       <div class="form-group">
    <label class="control-label" for="email">Email:</label>

         <asp:TextBox ID="Txtemail" CssClass="form-control"  runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic"
                                        ValidationGroup="save" ErrorMessage="Enter a valid email address please" ControlToValidate="Txtemail">*</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="save"
                                        Display="Dynamic" runat="server" ErrorMessage="Email address is not valid." ControlToValidate="Txtemail"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

   
  </div>

  <div class="form-group">

      <asp:Label ID="labelMessage" runat="server"></asp:Label>
            
                       <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" class="btn btn-primary btn-block" style="margin:15px 0;" />
                 <asp:Label ID="lblpass" runat="server"  Width="95%" Text ="" align="Left" Visible="false"></asp:Label>
                   <asp:Label ID="lblfrom" runat="server"  Width="95%" Text ="" align="Left" Visible="false"></asp:Label>
                     <asp:Label ID="lblsmptc" runat="server"  Width="95%" Text ="" align="Left" Visible="false"></asp:Label>
                       <asp:Label ID="lblfrompassword" runat="server"  Width="95%" Text ="" align="Left" Visible="false"></asp:Label>
                         <asp:Label ID="lbldes" runat="server"  Width="95%" Text ="" align="Left" Visible="false"></asp:Label>

  </div>

                    </div> 
 </div>
</div>
</div>
</div>

</asp:Content>

