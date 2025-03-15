<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="Manage_More.aspx.cs" Inherits="admin_Manage_More" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div class=" center_content">

<div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">
               Manage  Item</h1>
        </div>
    </div>
<div class="col-lg-12">
            <a href="Add_More.aspx" class="btn btn-info">Add New </a>
            </div>
            <div style="height: 30px;"></div>
  
                                <div style="height: 30px;"></div>
 
         <div class="row">
                        <div class="col-lg-12">
                            <div class="form-horizontal" role="form">

                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                      Product </label>
                                    <div class="col-sm-5">
                                  <asp:DropDownList ID="ddlSports" runat="server"    Width="220px" 
                                            onselectedindexchanged="ddlSports_SelectedIndexChanged" AutoPostBack="true">
                                        <asp:ListItem Value="-1">[Select Type]</asp:ListItem>
                                    </asp:DropDownList>
                                    </div>
                                </div>
                                </div>
                                </div>
                                </div>                
    
    <div class="row">
        <div class="col-lg-12">
          
    <asp:GridView ID="gvDetails" CssClass="Gridview" runat="server" 
      width="100%"     AutoGenerateColumns="False" DataKeyNames="P_Id" 
        onrowdeleting="gvDetails_RowDeleting" AllowPaging="true" PageSize="30" 
                    OnPageIndexChanging="gvDetails_PageIndexChanging">
<HeaderStyle BackColor="#df5015" />
              <Columns>
                  <asp:TemplateField HeaderText="Cloth_Id" Visible="False">
                   <ItemTemplate>
                    <%#Eval("P_Id")%>
                   </ItemTemplate>
                  </asp:TemplateField>              
                  
                  <asp:TemplateField HeaderText="Item Name" >
                  <ItemTemplate>
                   <%#Eval("P_Name")%>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                   <asp:TemplateField HeaderText="Product " >
                  <ItemTemplate>
                   <%#Eval("T_name")%>
                  </ItemTemplate>
                  </asp:TemplateField>
                  


                    
                           <asp:TemplateField HeaderText="Image" >               
                   <ItemTemplate>            
                                      <asp:Image ID="imgEmp" runat="server" Width="40px" Height="20px" ImageUrl='<%# Bind("Image_Name", "~/{0}") %>' style="padding-left:0px"/>              
                                     
            </ItemTemplate>
            </asp:TemplateField>        
                  
   <asp:TemplateField HeaderText="Edit Info" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="centerAlign">
									<ItemTemplate>
									 <a id="lnkDistribute" class="btn btn-primary" href="Add_More.aspx?P_Id=+<%#Eval("P_Id") %>+ &TB_iframe=true&height=600&width=800">
											Edit</a>
									</ItemTemplate>
								</asp:TemplateField>

                             <%--    <asp:TemplateField HeaderText="" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="centerAlign">
									<ItemTemplate>
									 <a id="lnkDistribute" class="btn btn-primary" href="Add_D_Camera_Detail.aspx?P_Id=+<%#Eval("P_Id") %>+ &TB_iframe=true&height=600&width=800">
											Add Category</a>
									</ItemTemplate>
								</asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="centerAlign">
                        <ItemTemplate>
                            <asp:Button ID="deleteButton" CssClass="btn btn-warning" runat="server" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this Information?');" />
                        </ItemTemplate>
                    </asp:TemplateField>
              </Columns>
              <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
              <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <EditRowStyle BackColor="#999999" />
              <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
          </asp:GridView>
        
         </div>
         </div>
         </div>
         
</asp:Content>

