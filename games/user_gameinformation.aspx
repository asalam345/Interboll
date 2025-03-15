<%@ Page Title="" Language="C#" MasterPageFile="~/games/user.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="user_gameinformation.aspx.cs" Inherits="games_user_gameinformation" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type='text/javascript'>

        function ShowImagePreviewA(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=imgShowA.ClientID%>').prop('src', e.target.result)
                };
                reader.readAsDataURL(input.files[0]);
            }
        }

        function ShowVideoPreviewA(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=videoShowA.ClientID%>').prop('src', e.target.result)
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body_header" Runat="Server">
    <div class="body_box_header">
        <div class="body_text_left">
            <a href="user_view_gameinformation.aspx" class="btn btn-default"><i class="fa fa-chevron-circle-left"></i>&nbsp;Back</a>
            <asp:Label ID="lbBodyHeader" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div id="body_box_alert">
        <div class="alert alert-success alert-dismissable" id="divAlertUpdateSuccessMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-check fa_margin_right"></i>Successful!</strong> 
            Data updated successfully.
        </div>
        <div class="alert alert-success alert-dismissable" id="divAlertSavedSuccessMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-check fa_margin_right"></i>Successful!</strong> 
            Data saved successfully.
        </div>
        <div class="alert alert-success alert-dismissable" id="divAlertDisplaySuccessMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-check fa_margin_right"></i>Successful!</strong> 
            Data displayed successfully.
        </div>
        <div class="alert alert-danger alert-dismissable" id="divAlertErrorMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-close fa_margin_right"></i>Error!</strong> 
            Please Fix The Error. <asp:Label ID="lbErrorMessage" runat="server" Text=""></asp:Label>
        </div>
        <div class="alert alert-warning alert-dismissable" id="divAlertWaringMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-warning fa_margin_right"></i>Warning!</strong> 
            Duplicate data found.
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_body" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
     <div class="body_box">
        <div class="container-fluid">
            <div class="form-group">
                <div class="row body_box_padding_top">
                    <div class="col-sm-6">
                        <span>Game Platform &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="ddPlatform" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="ddPlatform" runat="server" class="form-control"></asp:DropDownList>
                    </div>
                     <div class="col-sm-6">
                        <span>Game Category &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="ddCategory" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:UpdatePanel ID="upCategory" runat="server">
                            <ContentTemplate>
                                 <asp:DropDownList ID="ddCategory" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddCategory_SelectedIndexChanged"></asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-6">
                        <span>Game Type &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="ddType" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:UpdatePanel ID="upType" runat="server">
                            <ContentTemplate>
                                 <asp:DropDownList ID="ddType" runat="server" class="form-control"></asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="col-sm-6">
                        <span>Game Title &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="txTitle" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txTitle" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-6">
                        <span>Game URL or Page Name &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="txURLorPageName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txURLorPageName" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-sm-6">
                        <span>Game Status &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="ddGameStatus" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="ddGameStatus" runat="server" class="form-control"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-6">
                        <span>Game Price Type &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="ddPriceType" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="ddPriceType" runat="server" class="form-control"></asp:DropDownList>
                    </div>
                     <div class="col-sm-6">
                        <span>Game Price Currency &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="ddCurrency" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="ddCurrency" runat="server" class="form-control"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-6">
                        <span>Game Price &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="txPrice" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txPrice" class="form-control" runat="server" Text="0"></asp:TextBox>
                    </div>
                    <div class="col-sm-6">
                        <span>Game Powered By &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="txPoweredBy" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txPoweredBy" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-12">
                        <span>Game Details &nbsp;</span>
                        <asp:RequiredFieldValidator ValidationGroup="gen" runat="server" ControlToValidate="txDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <CKEditor:CKEditorControl ID="txDetails" class="form-control" BasePath="../USERPANEL/ckeditor/" runat="server"></CKEditor:CKEditorControl>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-6">
                        <span>Game Image &nbsp;</span>
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" onchange="ShowImagePreviewA(this);" style="padding:0px !important;"/>
                                <asp:Image ID="imgShowA" ImageUrl="../USERPANEL/img/upload/blank_image.jpg" runat="server" style="height:200px; width:100%;border:1px solid #bbb;"/>
                                <asp:Label ID="lbPhotoMessageA" runat="server" Text=""></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="col-sm-6">
                        <span>Game Video &nbsp;</span>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:FileUpload ID="FileUpload2" CssClass="form-control" runat="server" onchange="ShowVideoPreviewA(this);" style="padding:0px !important"/>
                                <video id="videoShowA" runat="server" poster="#" controls="controls" style="height:200px; width:100%; border:1px solid #bbb;"></video>
                                <asp:Label ID="lbVideoMessageA" runat="server" Text=""></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <hr class="invisible" /> 
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-12">
                       <asp:LinkButton runat="server" ID="btSave" ValidationGroup="gen" OnClick="btSave_Click" class="btn btn-success">Save &nbsp;<i class='fa fa-floppy-o'></i></asp:LinkButton>
                       <asp:LinkButton runat="server" ID="btUpdate" ValidationGroup="gen" OnClick="btUpdate_Click" class="btn btn-success">Update &nbsp;<i class='fa fa-floppy-o'></i></asp:LinkButton>
                       <a href="user_view_gameinformation.aspx" class="btn btn-danger">Cancel &nbsp;<i class="fa fa-times-circle"></i></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

