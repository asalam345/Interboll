<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="Add_Items.aspx.cs" Inherits="admin_Add_Items" %>

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

 <script src="../1-simple-calendar/tcal.js" type="text/javascript"></script>
    <link href="../1-simple-calendar/tcal.css" rel="stylesheet" type="text/css" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">             
   <asp:Literal ID="lit2" runat="server"></asp:Literal> </h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-7">
            <div class="panel panel-default">
                <div class="panel-heading">  
                    <asp:Literal ID="lit1" runat="server"></asp:Literal>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="form-horizontal" role="form">

                                
     


                                  <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                     Type </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlType" runat="server"    Width="220px">
                                        <asp:ListItem Value="-1">[Select Type]</asp:ListItem>
                                    </asp:DropDownList>
                                    </div>
                                </div>
                             
                                       <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                    Segments</label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="log_Combo" runat="server" class="form-control">
                                            <asp:ListItem Value="0">select</asp:ListItem>
                                            <asp:ListItem Value="1">Part1</asp:ListItem>
                                            <asp:ListItem Value="2">Part2</asp:ListItem>
                                            <asp:ListItem Value="3">Part3</asp:ListItem>
                                            <asp:ListItem Value="4">Part4</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>


                                            <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Title</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtTitle" runat="server" class="form-control"></asp:TextBox>
                                     
                                    </div>
                                </div> 
     
                                      
                                  <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                       Company Name</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtCname" runat="server" class="form-control"></asp:TextBox>
                                     
                                    </div>
                                </div> 

                                 <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                       URL</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtUrl" runat="server" class="form-control"></asp:TextBox>
                                     
                                    </div>
                                </div> 

                                     <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        sl</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtsl" runat="server" class="form-control" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                    </div>
                                </div>
                           
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Description</label>
                                    <div class="col-sm-9">                                       
                                        <textarea id="txtContents" name="txtTopic" rows="9" cols="34" class="form-control tinymce"
                                            runat="server"></textarea>
                                    </div>
                                </div>
                             
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Image Upload 1</label>
                                    <div class="col-sm-9">
                                        <asp:Image ID="Image2" Width="100px" Height="100px" BorderColor="Blue" runat="server" />
                                        <asp:Label ID="Label1" runat="server" Visible="false" Text=""></asp:Label>
                                        <asp:TextBox ID="txtCaptionimg1" runat="server" class="form-control" Visible="false"></asp:TextBox>
                                        <asp:FileUpload ID="fileUpload1" runat="server" Style="margin-top: 5px;" />
                                    </div>
                                </div>

                                     <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Photo Status</label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="dlphotostat1" runat="server" class="form-control">
                                            <asp:ListItem Value="0">Yes</asp:ListItem>
                                            <asp:ListItem Value="1">No</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                         
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Remarks</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="TxtRemarks" runat="server" class="form-control"></asp:TextBox>
                                          <asp:Label ID="lblhit" runat="server" Visible="false" Text=""></asp:Label>
                                    </div>
                                </div> 
     


                                <div class="form-group">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" class="btn btn-primary" />
                                        <asp:Label ID="Label4" runat="server" Width="95%" Text="" Visible="false"></asp:Label>
                                        <asp:HiddenField ID="hidArticleId" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>