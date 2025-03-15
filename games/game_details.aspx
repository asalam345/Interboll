<%@ Page Language="C#" AutoEventWireup="true" CodeFile="game_details.aspx.cs" EnableEventValidation="false" Inherits="games_game_details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interboll</title>
    <meta charset="utf-8" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <meta name="description" content="interboll, chat, games" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="css_sub/normalize.css" />
    <link rel="stylesheet" href="css_sub/bootstrap.min.css" />
    <link rel="stylesheet" href="css_sub/font-awesome.min.css" />
    <link rel="stylesheet" href="css_sub/animate.css" />
    <link rel="stylesheet" href="css_sub/main.css" />
    <link rel="stylesheet" href="css_sub/responsive.css" />
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico" />
    <link rel="stylesheet" href="css_sub/carouseller.css" />
    <script src="js/vendor/jquery-1.11.3.min.js"></script>
    <script src="js/jquery.lazy.image.js"></script>
    <script>
        $(function () {
            $('.lazy-image').lazy({
                placeholder: "data:image/gif;base64,R0lGODlhEALAPQAPzl5uLr9Nrl8e7..."
            });
        });

        $(function () {
            $('.lazy-image-larg').lazy({
                placeholder: "data:image/gif;base64,R0lGODlhEALAPQAPzl5uLr9Nrl8e7..."
            });
        });
	</script>
    <style>
         img.lazy-image {
            width: 24px ; 
            height: 24px ;
            display: inline-block;
            background-image: url('../USERPANEL/img/loading/21.gif');
            background-repeat: no-repeat;
            background-position: 50% 50%;
        }

         img.lazy-image-larg {
            width: 100% ; 
            height: 160px ;
            display: inline-block;
            background-image: url('../USERPANEL/img/loading/21.gif');
            background-repeat: no-repeat;
            background-position: 50% 50%;
        }
    </style>
    <script src="js/Carousel_slider/carouseller.min.js"></script>
    <script src="js/Carousel_slider/jquery.easing.1.3.js"></script>
    <style type="text/css">
        .ratingStar {
            font-size: 0pt;
            width: 25px;
            height:20px;
            cursor:pointer;
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
</head>
<body style="padding: 10px; background-color: #ea3328;">
    <form id="form1" runat="server">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
        <div class="bottomborderindex"></div>
        <div class="backgroundbgcolor">
            <div class="row gutter-10">
                <div class="col-sm-9">
                    <div class="boxsocialwrap" style="padding: 4px 38px 4px 4px;">
                        <div class="scrollboxhide"></div>
                        <iframe id="playGame" runat="server" style="width: 100%; height: 608px;border:none;"></iframe>
                    </div>
                </div>
                <div class="col-sm-3">
                    <div style="height: 4px"></div>
                    <div class="profilcoverpage">
                        <img id="imgShow" runat="server" data-src="img/Ac3.jpg" class="lazy-image-larg musicbanner" style="height: 160px; text-align: center; color: #ffffff; padding: 8px; background-color: rgba(14, 14, 14, 0.8)" />
                    </div>
                    <div class="boxsocial3">
                        <video id="videoShowA" runat="server" controls="controls" class="musicbanner" style="height: 160px; margin-top:4px; text-align: center; color: #ffffff; padding: 8px; background-repeat: no-repeat; background-color: rgba(14, 14, 14, 0.8)"></video>
                        <div style="text-align: center; color: #000000; padding-bottom: 3px;font-size:18px">
                            <asp:Label ID="lbGameName" runat="server"></asp:Label>
                        </div>
                        <div class="scrollboxhide3"></div>
                        <div class="scrollboxhide3r"></div>
                        <div class="tabcontentswrap" style="background-color: #ffffff; padding: 10px">
                            <div style="background-color: #f1f1f1; padding: 3px">
                                <div style="width: 130px; float: left">
                                    <cc1:Rating ID="Rating1" runat="server" StarCssClass="ratingStar" WaitingStarCssClass="savedStar"
                                        FilledStarCssClass="filledStar" EmptyStarCssClass="emptyStar" AutoPostBack="true"
                                        CurrentRating="1" MaxRating="5" OnChanged="Rating1_Changed">
                                    </cc1:Rating>
                                </div>
                                <div style="width:84px; float:left;text-align:center">
                                    <asp:LinkButton ID="lbtLike" OnClick="lbtLike_Click" runat="server" Style="color:#333366;"><i class="fa fa-hand-o-right"></i> Like</asp:LinkButton>
                                </div>

                                <div style="width: 84px; float: left; color: #333366">
                                    <a href="#" style="color: #333366; text-decoration: none" data-toggle="modal" data-target="#myModalgame"><i class="fa fa-comment-o"></i> Comment</a>
                                </div>
                                <div style="clear: both"></div>
                            </div>
                            <div style="margin-top: 10px; text-align: center">
                                <asp:Label ID="lblRatingStatus" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="tab-content tabcontents">
                            <div class="tab-pane active" id="1" style="">
                                <div class="boxpro">
                                    <div class="gamestitleright">
                                        Hot Games · <a href="#">See More</a>
                                    </div>
                                    <div class="aboutwrap2">
                                        <div class="boxsmall2">
                                            <div class="middlebox">
                                                <div class="row">
                                                    <asp:Repeater ID="rpGameDetailsHot" runat="server">
                                                        <ItemTemplate>
                                                            <div class="gamesprof">
                                                                <div class="row">
                                                                    <div class="col-sm-1">
                                                                        <img data-src='<%# Eval("g_image") %>' class="lazy-image imgprofilgames">
                                                                    </div>
                                                                    <div class="col-sm-8">
                                                                        <p style="margin-left: 10px; font-size: 14px"><a href='game_details.aspx?id=<%# Eval("g_id") %>&setpid=<%: Guid.NewGuid() %>'><%# Eval("g_name") %></a></p>
                                                                    </div>
                                                                    <div class="col-sm-1"><%# Eval("g_type") %></div>
                                                                </div>
                                                                <div style="clear: both"></div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div style="clear: both"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Modal -->
        <div id="myModalgame" class="modal fade" role="dialog" data-backdrop="static" data-keyboard="false">
            <div class="modal-dialog">
                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Comment For This Game</h4>
                    </div>
                    <div class="modal-body">
                        <p><asp:TextBox ID="txComments" CssClass="form-control" runat="server" TextMode="MultiLine" Height="200px" style="resize:none;"></asp:TextBox></p>
                        <p><asp:Button ID="btSave" CssClass="btn btn-danger" OnClick="btSave_Click" runat="server" Text="Send" /> <asp:Label ID="lbShowMessage" runat="server"></asp:Label></p>
                    </div>
                 
                </div>
            </div>
        </div>
        <!--model box end chat-->
        <!--<script src="js/vendor/jquery-1.11.3.min.js"></script>-->
        <script src="js/bootstrap.min.js"></script>
        <script src="js/plugins.js"></script>
        <script src="js/main.js"></script>

        <!--thumble slider start-->
        <script type="text/javascript">
            $(function () {
                $('#second').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second2').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second3').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second4').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second5').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second6').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second7').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second8').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second9').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second10').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second11').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second12').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second13').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second14').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second15').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second16').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second17').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second18').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second19').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second20').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>

        <script type="text/javascript">
            $(function () {
                $('#second21').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <script type="text/javascript">
            $(function () {
                $('#second22').carouseller({
                    scrollSpeed: 800,
                    /*autoScrollDelay: 1000,*/
                    easing: 'linear'
                });
            });
        </script>
        <!--thumble slider end-->
    </form>
</body>
</html>
