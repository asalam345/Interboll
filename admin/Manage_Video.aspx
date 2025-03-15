<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="Manage_Video.aspx.cs" Inherits="admin_Manage_Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
<script language="Javascript" type="">
       <!--
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
            return false;

        return true;
    }
    //-->
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:Label ID="UploadDetails" runat="server" Text=""></asp:Label>

                             <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Title</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtTitle" runat="server" class="form-control"></asp:TextBox>
                                                <asp:TextBox ID="txtname" runat="server" Visible="false" class="form-control"></asp:TextBox>
                                          
                                    </div>
                                </div> 

                                  <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        serial</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtsl" runat="server" class="form-control" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                    </div>
                                </div>
    <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Image Upload 1</label>
                                    <div class="col-sm-9">

            <asp:FileUpload ID="FileUpload1" runat="server" />

                                        </div>
        </div>

          <div class="form-group">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                                        <asp:Label ID="lbldata" runat="server" Width="95%" Text="" Visible="false"></asp:Label>
                                        <asp:HiddenField ID="hidArticleId" runat="server" />
                                    </div>
                                </div>
<hr />


      <asp:GridView ID="gvDetails" CssClass="Gridview" runat="server" 
      width="100%"     AutoGenerateColumns="False" DataKeyNames="Id" 
        onrowdeleting="gvDetails_RowDeleting" AllowPaging="true" PageSize="30" 
                    OnPageIndexChanging="gvDetails_PageIndexChanging">
<HeaderStyle BackColor="#df5015" />
              <Columns>
                  <asp:TemplateField HeaderText="Cloth_Id" Visible="False">
                   <ItemTemplate>
                    <%#Eval("Id")%>
                   </ItemTemplate>
                  </asp:TemplateField>              
                  
                  <asp:TemplateField HeaderText="Item Name" >
                  <ItemTemplate>
                   <%#Eval("P_Title")%>
                  </ItemTemplate>
                  </asp:TemplateField>
                          
                      <asp:TemplateField HeaderText="SL" >
                  <ItemTemplate>
                   <%#Eval("p_sl")%>
                  </ItemTemplate>
                  </asp:TemplateField>
                         <asp:TemplateField HeaderText="Active Status" >
                  <ItemTemplate>
                   <%#Eval("p_Status")%>
                  </ItemTemplate>
                  </asp:TemplateField>

                   <asp:TemplateField HeaderText="Product " >
                  <ItemTemplate>
           <%-- <a class="player" style="height:130px; width:200px; display: block; margin:10px" href='<%# Eval("Id", "../FileCS.ashx?Id={0}") %>'>--%>
                     <video width="200px" height="124px" controls>
            <source src="../<%# Eval("Name")%>" type="video/mp4" />
        </video>
                  </ItemTemplate>
                  </asp:TemplateField>
                  


             
                         
                  
   <asp:TemplateField HeaderText="Edit Info" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="centerAlign">
									<ItemTemplate>
									 <a id="lnkDistribute" class="btn btn-primary" href="Manage_Video.aspx?P_Id=+<%#Eval("Id") %>+ &TB_iframe=true&height=600&width=800">
											Edit</a>
									</ItemTemplate>
								</asp:TemplateField>

             
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
                  <script src="FlowPlayer/flowplayer-3.2.12.min.js"></script>

<script type="text/javascript">
    flowplayer("a.player", "FlowPlayer/flowplayer-3.2.16.swf", {
        plugins: {
            pseudo: { url: "FlowPlayer/flowplayer.pseudostreaming-3.2.12.swf" }
        },
        clip: { provider: 'pseudo', autoPlay: false },
    });
</script>
</asp:Content>

