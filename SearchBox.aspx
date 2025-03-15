<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SearchBox.aspx.cs" Inherits="SearchBox" %>

<%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="col-sm-5">
        <div class="boxsocialwrap">
            <div class="scrollboxhide"></div>
            <div class="search">
                <div class="row">
                    <div class="col-sm-1 col-xs-2">
                        <a href="default.aspx">
                            <img src="img/interboll.png" class="oiiogo"></a>
                    </div>
                    <div class="col-sm-11 col-xs-10">

                        <uc1:leftevent ID="leftevent1" runat="server" />

                    </div>
                    <div style="clear: both"></div>
                </div>
            </div>


            <div class="boxsocial2">
                <div class="boxproe">
                    <div class="titleheadpast">
                        <img align="left" class="aboutimg" src="img/f2.png" style="margin-right: 10px">
                        <span style="font-size: 15px">Followers</span>
                    </div>
                    <!--step1 search box start-->
                    <div class="eventbox">
                        <asp:Repeater ID="rptFriend" runat="server" OnItemDataBound="RepeaterItemCreated">
                            <ItemTemplate>
                                <div class="row gutter-10" style="margin-bottom: 10px">
                                    <div class="col-sm-2 col-xs-2">
                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                            <asp:Image ID="Image2" runat="server" CssClass="imgpastsearch" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' /></a>
                                    </div>

                                    <div class="col-sm-8 col-xs-7">
                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=""></asp:Label>
                                            <asp:Label ID="lblfrnd1" runat="server" Text='<%# Bind("IID") %>' Width="" Font-Bold="true" Visible="false"></asp:Label>
                                        </a>
                                    </div>

                                    <div class="col-sm-2 col-xs-2">

                                        <asp:Button ID="btnReply" runat="server" Text="Add" OnClick="btnReplyClicked3" AutoPostBack="True" Visible="false" CommandArgument='<%#Eval("IID")%>' Class="confirmbtnf3" />
                                        <asp:Button ID="RequestSent" runat="server" Text="Request Sent" OnClick="btnReplyClicked4" AutoPostBack="True" Visible="false" CommandArgument='<%#Eval("IID")%>' Class="confirmbtnf3" />
                                        <asp:Button ID="Follower" runat="server" Text="Follower" OnClick="btnReplyClicked5" AutoPostBack="True" Visible="false" CommandArgument='<%#Eval("IID")%>' Class="confirmbtnf3" />
                                    </div>

                                </div>



                            </ItemTemplate>


                        </asp:Repeater>
                    </div>

                </div>

                <!--post From Start-->
                <div class="boxproe">
                    <div class="titleheadpast">
                        Posts from Followers
                    </div>


                    <div style="margin-top: 10px" class="">


                        <div style="clear: both"></div>
                        <div class="comment more">
                            <div><span id="ctl00_MainContent_rptPost_ctl03_Label3">hi interbollteam</span></div>
                        </div>


                    </div>
                    <asp:Repeater ID="rptPost" runat="server" OnItemDataBound="RepeaterItemCreated" OnItemCommand="itemRepeater_ItemCreated">
                        <ItemTemplate>
                            <div class="boxpro">
                                <div class="row">

                                    <div class="col-sm-9 col-xs-8">
                                        <%--   <a href="#"> <img border="0" align="left" class="imgprofilenotifi2" src="img/img3.png"></a>--%>
                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                            <asp:Image ID="Image2" runat="server" CssClass="imgprofilenotifi2" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' /></a>
                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label>,
							      <span style="font-size: 11px"><%# string.Format("{0:dd MMM yyyy}", Eval("P_Date"))%></span>

                                        </a>
                                    </div>

                                    <div class="col-sm-3 col-xs-3 text-right">
                                        <div class="" id="MUser" runat="server">
                                        </div>
                                    </div>
                                </div>

                                <div class="" style="margin-top: 10px">
                                    <%--	<a href="#"><img border="0" align="left" src="img/naturalimg.jpg" class="imresponsive"></a>--%>
                                    <asp:Image ID="Image1" runat="server" Height="" Width="100%" CssClass="imresponsive" Visible="false" ImageUrl='<%# Bind("Post_Image", "~/images/Items/{0}") %>' />

                                    <div style="clear: both"></div>
                                    <div class="dolessmore">
                                        <div>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("P_Description") %>'></asp:Label></div>
                                    </div>


                                </div>




                                <!--comments end-->

                                <div style="clear: both"></div>
                            </div>



                        </ItemTemplate>

                    </asp:Repeater>

                    <div class="comentsbox" id="ctl00_MainContent_rptPost_ctl03_divlok">


                        <div title="Coments" class="col-sm-12"></div>
                    </div>
                    <!--comments end-->

                    <div style="clear: both"></div>
                </div>

                <!--post From end-->
            </div>
        </div>
    </div>
    <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>

    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
    <asp:HiddenField ID="hidArticleId" runat="server" />
</asp:Content>

