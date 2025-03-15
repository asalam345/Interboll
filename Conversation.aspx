<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="Conversation.aspx.cs" Inherits="Conversation" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>CONVERSATION</title>
    <meta charset="utf-8" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <meta name="description" content="interboll, chat" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="img/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/normalize.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />
    <link href="css/jquery-ui.css" rel="stylesheet" />
    <link href="css/chat-main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="topChatHeader">
            <div class="topChatHeaderTextLeft pull-left"><img src="img/interboll.png" alt="logo" height="50" width="50" /> INTERBOLL</div>
            <div class="topChatHeaderTextRight pull-right"><asp:LinkButton ID="lbUserLogin" runat="server"></asp:LinkButton> <asp:LinkButton ID="lbUserRegister" runat="server"></asp:LinkButton></div>
        </div>
        <div class="container-fluid">
	        <div class="row">
                <div class="col-md-12">

                    <div class="col-md-3"> </div>

                    <div class="col-md-6"> </div>

                    <div class="col-md-3">
                        <div class="chatHeaderRight">
                            <div class="dropdown">
                                <a class="dropdown-toggle pull-left" data-toggle="dropdown" style="cursor:pointer;">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <asp:Timer runat="server" ID="Timer2" Interval="5000" Enabled="true" OnTick="Timer2_Tick"></asp:Timer>
                                            <span class="fa fa-comment-o chatIcon"> Chat (<asp:Label ID="lbOnlineUserShow" runat="server" Text=""></asp:Label>)</span>
                                        </ContentTemplate>
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                                        </Triggers>
                                    </asp:UpdatePanel>
                                </a>
                                <ul class="dropdown-menu chatlistdropdown">
                                    <asp:Repeater ID="rpOnlineUsers" runat="server" OnItemDataBound="rpOnlineUsers_ItemDataBound">
                                        <ItemTemplate>
                                            <li style="padding-top: 10px;">
                                                <div class="profileimgnotifi">
                                                    <div class="col-md-2">
                                                        <img src='<%# Eval("Profile_Image") %>' class="chatimg pull-left" />
                                                    </div>
                                                    <div class="col-md-7">
                                                        <div class="chatexmargin">
                                                            <asp:HiddenField ID="hfFirstName" runat="server" Value='<%# Eval("First_Name") %>' />
                                                            <asp:HiddenField ID="hfLastName" runat="server" Value='<%# Eval("Last_Name") %>' />
                                                            <asp:HiddenField ID="fhIsOnline" runat="server" Value='<%# Eval("isOnline") %>' />
                                                            <asp:HiddenField ID="fhIsBusy" runat="server" Value='<%# Eval("isBusy") %>' />
                                                            <asp:LinkButton ID="btFriendList" runat="server" OnClick="btFriendList_Click" CommandArgument='<%# Eval("u_friendId") %>'><%# Eval("First_Name") %>&nbsp;<%# Eval("Last_Name") %></asp:LinkButton>
                                                        </div>
                                                    </div>
                                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                        <ContentTemplate>
                                                            <div class="col-md-1">
                                                                <i id="faIsOnline" runat="server" class=""></i>
                                                            </div>
                                                            <div class="col-md-1">
                                                                <i id="faIsBusy" runat="server" class=""></i>
                                                            </div>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                    <div style="clear: both;"></div>
                                                </div>
                                            </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-12" style="position:fixed; height:70px; bottom:445px;"> 
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Timer runat="server" ID="Timer3" Interval="5000" Enabled="true" OnTick="Timer3_Tick"></asp:Timer>
                            <asp:Repeater ID="rpChatRequest" runat="server">
                                <ItemTemplate>
                                    <div class="col-md-3" style="float: right;" id="chatDivRequestPlaceHolder" runat="server" visible="true">
                                        <div class="alert blink_me alert-warning alert-dismissable" id="chatDivRequest" runat="server" visible="true" style="height: 60px; position: relative;">
                                            <img src='<%# Eval("Profile_Image") %>' class="pull-left" style="width: 30px; height: 30px; border-radius: 50%; padding-right: 5px;" />
                                            <span class="pull-left"><%# Eval("First_Name") %> <%# Eval("Last_Name") %> at <%# Eval("modifiedDate","{0:hh:mmtt}") %></span>
                                            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                            <span class="fa fa-commenting-o pull-right" style="font-size: 20px;"></span>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer3" EventName="Tick" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>

                <div class="col-md-12" style="position:fixed; bottom:3px;">                    
                    <asp:Repeater ID="rpChatBoxOpen" runat="server" OnItemDataBound="rpChatBoxOpen_ItemDataBound">
                        <ItemTemplate>
                            <asp:HiddenField ID="hfChatFriendId" runat="server" Value='<%# Eval("u_friendId") %>' />
                            <div class="col-md-3" style="float: right;">
                                <div class="popup-box chat-popup" style="position: static; height: 355px; background: #fff;">
                                    <div class="popup-head">
                                        <div class="popup-head-left">
                                            <asp:LinkButton ID="btRefress" CssClass="btRefress" runat="server" OnClick="btRefress_Click" style="background-color: transparent; border: none;text-decoration:none;padding-right:5px;"><i class="fa fa-refresh"></i> </asp:LinkButton>
                                            <a href="#" target="_blank"><%# Eval("First_Name") %> <%# Eval("Last_Name") %></a>
                                        </div>
                                        <asp:LinkButton ID="btChatBoxClose" runat="server" OnClick="btChatBoxClose_Click" Style="float: right; background-color: transparent; border: none; font-size: 16px; text-decoration: none;" onMouseOver="this.style.color='red'" onMouseOut="this.style.color='teal'">&times;</asp:LinkButton>
                                        <div style="clear: both"></div>
                                    </div>
                                    <asp:Panel ID="chatPanel" runat="server" DefaultButton="btChatSend">
                                        <asp:UpdatePanel ID="upChat" runat="server">
                                            <ContentTemplate>
                                                <asp:Timer runat="server" ID="Timer1" Interval="5000" Enabled="true" OnTick="Timer1_Tick"></asp:Timer>
                                                <div class="popup-messages">
                                                    <asp:Repeater ID="rpChatMessageShow" runat="server" OnItemDataBound="rpChatMessageShow_ItemDataBound">
                                                        <ItemTemplate>
                                                            <div class="col-md-12" style="padding: 5px;">
                                                                <div id="messagePhotoDiv" runat="server" class="col-md-3" style="margin-left: -14px;">
                                                                    <asp:HiddenField ID="hfFromPhoto" runat="server" Value='<%# Eval("u_fromPhoto") %>' />
                                                                    <asp:HiddenField ID="hfToPhoto" runat="server" Value='<%# Eval("u_toPhoto") %>' />
                                                                    <asp:Image ID="messagePhoto" runat="server" Style="width: 30px; height: 30px; border-radius: 50%;" />
                                                                    <span id="textSpan" runat="server" style="font-size: 9px;"><%# Eval("createdDate","{0:hh:mmtt}") %></span>
                                                                </div>
                                                                <div class="col-md-10" style="margin-left: -20px;">
                                                                    <asp:HiddenField ID="hfUserIdFrom" runat="server" Value='<%# Eval("u_idFrom") %>' />
                                                                    <div id="messageText" runat="server"><%# Eval("m_textMessage") %></div>
                                                                </div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </div>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick"/>
                                            </Triggers>
                                        </asp:UpdatePanel>
                                        <div class="popup-textbox has-feedback">
                                            <asp:LinkButton ID="btChatSend" CssClass="btChatSend" runat="server" OnClick="btChatSend_Click"><i class="fa fa-arrow-right" style="position:absolute;text-decoration:none;top:6px;right:6px;font-size: 20px;"></i></asp:LinkButton>
                                            <asp:TextBox ID="txChatMessage" data-dataKey='<%# Eval("u_friendId") %>' CssClass="form-control txChatMessage" runat="server" placeholder="Type a message here" Style="border-radius: 0px; border: none; font-size: 16px;"></asp:TextBox>
                                            <div class="dropdown">
                                                <a id="btEmoji" class="dropdown-toggle" data-toggle="dropdown" style="cursor: pointer;">&#x1F60A;</a>
                                                <ul class="dropdown-menu emoji-list">
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F600;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F610;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F620;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F630;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F60E;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F601;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F611;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F621;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F631;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F60A;</li>
                                                </ul>
                                            </div>
                                            <div class="dropdown">
                                                <a id="btEmoji1" class="dropdown-toggle" data-toggle="dropdown" style="cursor: pointer;">&#x1F33B;</a>
                                                <ul class="dropdown-menu emoji-list1">
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F332;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F333;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F334;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F335;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F337;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F338;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F339;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F33A;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F33B;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F33C;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F33D;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F33E;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F33F;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F340;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F341;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F342;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F343;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F344;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F345;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x26EA;</li>
                                                </ul>
                                            </div>
                                            <div class="dropdown">
                                                <a id="btEmoji2" class="dropdown-toggle" data-toggle="dropdown" style="cursor: pointer;">&#x1F496;</a>
                                                <ul class="dropdown-menu emoji-list2">
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F493;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F494;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F495;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F496;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F497;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F498;</li>
                                                    <li accesskey="<%# Eval("u_friendId") %>">&#x1F499;</li>
                                                </ul>
                                                <a id="btEmoji3" class="btEmoji3" style="cursor: pointer;" accesskey="<%# Eval("u_friendId") %>">&#x1F44D;</a>
                                            </div>
                                           
                                        </div>
                                    </asp:Panel>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <script src="js/jquery-1.11.3.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery-ui.js"></script>
        <script src="js/twemoji.min.js"></script>

        <script type="text/javascript">
            $(function () {
                $(".dialog").dialog();
            });

            //$(function () {
            //    $(".btRefress").click();
            //});

            //$(document).on(function () {
            //    setInterval(function () {
            //        $(".btRefress").click();
            //    }, 5000);
            //});

            $(document).on("click", ".emoji-list li", function () {
                var getIconText = $(this).text();
                var getAccessKey = $(this).attr('accesskey');
                $("input[type=text][data-datakey=" + getAccessKey + "]").val(" " + getIconText + " ");
                $("input[type=text][data-datakey=" + getAccessKey + "]").focus();
            });

            $(document).on("click", ".emoji-list1 li", function () {
                var getIconText = $(this).text();
                var getAccessKey = $(this).attr('accesskey');
                $("input[type=text][data-datakey=" + getAccessKey + "]").val(" " + getIconText + " ");
                $("input[type=text][data-datakey=" + getAccessKey + "]").focus();
            });

            $(document).on("click", ".emoji-list2 li", function () {
                var getIconText = $(this).text();
                var getAccessKey = $(this).attr('accesskey');
                $("input[type=text][data-datakey=" + getAccessKey + "]").val(" " + getIconText + " ");
                $("input[type=text][data-datakey=" + getAccessKey + "]").focus();
            });

            $(document).on("click", ".btEmoji3", function () {
                var getIconText = $(this).text();
                var getAccessKey = $(this).attr('accesskey');
                $("input[type=text][data-datakey=" + getAccessKey + "]").val(" " + getIconText + " ");
                $("input[type=text][data-datakey=" + getAccessKey + "]").focus();
            });

        </script>
    </form>
</body>
</html>
