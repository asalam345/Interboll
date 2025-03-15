<%@ Page Title="" Language="C#" MasterPageFile="~/games/user.master" AutoEventWireup="true" CodeFile="user_play_game.aspx.cs" Inherits="games_user_play_game" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body_header" Runat="Server">
    <div class="body_box_header">
        <div class="body_text_left">
            <a href="user_view_gameinformation.aspx" class="btn btn-default"><i class="fa fa-chevron-circle-left"></i>&nbsp;Back</a>
            <asp:Label ID="lbGameName" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_body" Runat="Server">
    <div class="body_box">
        <div class="container-fluid">
            <div class="form-group">
                <div class="row">
                    <iframe id="playGame" runat="server" style="width: 100%; height: 800px;"></iframe>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

