<%@ Page Title="" Language="C#" MasterPageFile="~/games/game.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="games_Default" %>
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
        <div class="aboutwrap">
            <div class="row">
                <div class="col-sm-12 text-right">
                    <ul class="nav nav-tabs tabcssfollowers">
                        <li class="menumfollow active">
                            <a aria-expanded="true" href="#15e" data-toggle="tab">Home</a>
                        </li>
                        <li class="menumfollow">
                            <a aria-expanded="false" href="#16e" data-toggle="tab">Top Charts</a>
                        </li>

                        <li class="menumfollow">
                            <a aria-expanded="false" href="#17e" data-toggle="tab">Casual Games</a>
                        </li>

                        <li class="menumfollow">
                            <a aria-expanded="false" href="#18e" data-toggle="tab">Battle Game</a>
                        </li>
                        <li class="menumfollow">
                            <a aria-expanded="false" href="#19e" data-toggle="tab">Casino</a>
                        </li>
                        <%--<li class="menumfollow">
                            <a aria-expanded="false" href="#20e" data-toggle="tab">Activity
                            </a>
                        </li>--%>
                    </ul>
                </div>
                <div style="clear: both"></div>
            </div>
        </div>
    </div>
    <div id="exTab2">
        <div class="tab-content tabcontents">
            <div class="tab-pane active" id="15e" style="margin-bottom: 28px;">
               <asp:Repeater ID="rpGamesHome" runat="server" OnItemDataBound="rpGamesHome_ItemDataBound">
                    <ItemTemplate>
                        <asp:HiddenField ID="hfGamePlatform" runat="server" Value='<%# Eval("g_platform") %>'/>
                        <asp:HiddenField ID="hfGameType" runat="server" Value='<%# Eval("g_type") %>'/>
                        <div class="boxproegames">
                            <div class="gamestitle"><%# Eval("g_platform") %> :: <%# Eval("g_type") %> Games · <a href="#">See More</a></div>
                            <div class="carouseller">
                                <a href="javascript:void(0)" class="carousel-button-left">‹</a>
                                <div class="carousel-wrapper">
                                    <div class="carousel-items">
                                        <asp:Repeater ID="rpGamesTypeInner" runat="server">
                                            <ItemTemplate>
                                                <div class="span3 carousel-block">
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
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                                <a href="javascript:void(0)" class="carousel-button-right">›</a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="tab-pane" id="16e">
                 <asp:Repeater ID="rpGamesTopChart" runat="server" OnItemDataBound="rpGamesTopChart_ItemDataBound">
                    <ItemTemplate>
                        <asp:HiddenField ID="hfGamePlatform" runat="server" Value='<%# Eval("g_platform") %>'/>
                        <asp:HiddenField ID="hfGameType" runat="server" Value='<%# Eval("g_type") %>'/>
                        <div class="boxproegames">
                            <div class="gamestitle"><%# Eval("g_platform") %> :: <%# Eval("g_type") %> Games · <a href="#">See More</a></div>
                            <div class="carouseller">
                                <a href="javascript:void(0)" class="carousel-button-left">‹</a>
                                <div class="carousel-wrapper">
                                    <div class="carousel-items">
                                        <asp:Repeater ID="rpGamesTypeInner" runat="server">
                                            <ItemTemplate>
                                                <div class="span3 carousel-block">
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
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                                <a href="javascript:void(0)" class="carousel-button-right">›</a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="tab-pane" id="17e" style="">
                <asp:Repeater ID="rpGamesCasual" runat="server" OnItemDataBound="rpGamesCasual_ItemDataBound">
                    <ItemTemplate>
                        <asp:HiddenField ID="hfGamePlatform" runat="server" Value='<%# Eval("g_platform") %>'/>
                        <asp:HiddenField ID="hfGameType" runat="server" Value='<%# Eval("g_type") %>'/>
                        <div class="boxproegames">
                            <div class="gamestitle"><%# Eval("g_platform") %> :: <%# Eval("g_type") %> Games · <a href="#">See More</a></div>
                            <div class="carouseller">
                                <a href="javascript:void(0)" class="carousel-button-left">‹</a>
                                <div class="carousel-wrapper">
                                    <div class="carousel-items">
                                        <asp:Repeater ID="rpGamesTypeInner" runat="server">
                                            <ItemTemplate>
                                                <div class="span3 carousel-block">
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
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                                <a href="javascript:void(0)" class="carousel-button-right">›</a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="tab-pane" id="18e" style="">
                <asp:Repeater ID="rpGamesBattle" runat="server" OnItemDataBound="rpGamesBattle_ItemDataBound">
                    <ItemTemplate>
                        <asp:HiddenField ID="hfGamePlatform" runat="server" Value='<%# Eval("g_platform") %>'/>
                        <asp:HiddenField ID="hfGameType" runat="server" Value='<%# Eval("g_type") %>'/>
                        <div class="boxproegames">
                            <div class="gamestitle"><%# Eval("g_platform") %> :: <%# Eval("g_type") %> Games · <a href="#">See More</a></div>
                            <div class="carouseller">
                                <a href="javascript:void(0)" class="carousel-button-left">‹</a>
                                <div class="carousel-wrapper">
                                    <div class="carousel-items">
                                        <asp:Repeater ID="rpGamesTypeInner" runat="server">
                                            <ItemTemplate>
                                                <div class="span3 carousel-block">
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
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                                <a href="javascript:void(0)" class="carousel-button-right">›</a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="tab-pane" id="19e">
                <asp:Repeater ID="rpGamesCasino" runat="server" OnItemDataBound="rpGamesCasino_ItemDataBound">
                    <ItemTemplate>
                        <asp:HiddenField ID="hfGamePlatform" runat="server" Value='<%# Eval("g_platform") %>'/>
                        <asp:HiddenField ID="hfGameType" runat="server" Value='<%# Eval("g_type") %>'/>
                        <div class="boxproegames">
                            <div class="gamestitle"><%# Eval("g_platform") %> :: <%# Eval("g_type") %> Games · <a href="#">See More</a></div>
                            <div class="carouseller">
                                <a href="javascript:void(0)" class="carousel-button-left">‹</a>
                                <div class="carousel-wrapper">
                                    <div class="carousel-items">
                                        <asp:Repeater ID="rpGamesTypeInner" runat="server">
                                            <ItemTemplate>
                                                <div class="span3 carousel-block">
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
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                                <a href="javascript:void(0)" class="carousel-button-right">›</a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <%-- <div class="tab-pane" id="20e" style="">
                <div class="boxproe2">
                    <div class="row gutter-10">
                        <div class="col-sm-12">
                            <div style="text-align: center">
                                <img class="imageevents" src="img/subscribe.jpg">
                            </div>
                            <div class="fonttext">Activity</div>
                        </div>
                    </div>
                </div>
            </div>--%>
        </div>
    </div>
</asp:Content>

