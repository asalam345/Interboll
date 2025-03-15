<%@ Page Title="" Language="C#" MasterPageFile="~/games/game.master" AutoEventWireup="true" CodeFile="game_search.aspx.cs" Inherits="games_game_search" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ratingStar {
            font-size: 0pt;
            width: 20px;
            height: 20px;
            cursor: text;
            display: block;
            background-repeat: no-repeat;
        }

        .filledStar {
            background-image: url(../USERPANEL/img/rating/starFill.png);
        }

        .emptyStar {
            background-image: url(../USERPANEL/img/rating/starEmpty.png);
        }

        .savedStar {
            background-image: url(../USERPANEL/img/rating/starSave.png);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="boxproe">
        <div class="row">
            <div class="col-sm-12" style="padding-left: 20px;">
                <asp:Label ID="lbShowSearchText" runat="server"></asp:Label>
            </div>
            <div style="clear: both"></div>
        </div>
    </div>
    <div class="boxproegames" style="margin-top: 4px;">
        <div class="imagewrap">
            <div class="row gutter-10">
                <asp:Repeater ID="rpGamesSearch" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-3">
                            <div style="background-color: #e5e5e5; font-size: 30px; text-align: center;">
                                <a href='game_details.aspx?id=<%# Eval("g_id") %>&setpid=<%: Guid.NewGuid() %>' target="_blank">
                                    <img data-src='<%# Eval("g_image") %>' class="lazy-image imageeventsbooks" /></a>
                                <h5><a href='game_details.aspx?id=<%# Eval("g_id") %>&setpid=<%: Guid.NewGuid() %>' target="_blank"><%# Eval("g_name") %></a></h5>
                                <div class="fonteventtext" style="margin: 0 auto; text-align: center; width: 103px;">
                                    <cc1:Rating ID="Rating1"
                                        runat="server"
                                        ReadOnly="true"
                                        StarCssClass="ratingStar"
                                        WaitingStarCssClass="savedStar"
                                        FilledStarCssClass="filledStar"
                                        EmptyStarCssClass="emptyStar"
                                        CurrentRating='<%# Eval("rating") %>'
                                        MaxRating="5">
                                    </cc1:Rating>
                                </div>
                                <div style="clear: both"></div>
                                <p class="fonteventtext" style="margin-top: 8px"><%# Eval("g_category") %> Games</p>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div style="clear: both"></div>
    </div>
</asp:Content>

