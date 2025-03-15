<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucRightside.ascx.cs" Inherits="Usercontrol_ucRightside" %>
<div class="col-sm-4">
    <div style="height: 5px"></div>
    <div class="profilcoverpage">
        <div class="view view-first">
            <img src="<%=lok1.Text%>" style="width: 100%; height: 138px" />
            <a data-target="#updatecoverphotom" data-toggle="modal" href="#">
                <div class="mask">

                    <div style="font-size: 16px; text-align: left; color: #ffffff; padding: 15px">
                        <i class="glyphicon glyphicon-camera"></i> Change Cover Photo

                    </div>


                    <%--             <a href="#" class="info">Read More</a>--%>
                </div>
            </a>
        </div>

        <div class="col-sm-8">
            <div class="updateinformation2">
            </div>
        </div>

        <div class="col-sm-4 text-right">


            <div class="profiletopimg">
                <div class="profilenametext">
                    <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                </div>
                <div class="view view-first">
                    <img border="0" src="<%=lok2.Text%>" class="imgpro">
                    <%-- <img src="images/9.jpg" />--%>
                    <a data-target="#updatephoto" data-toggle="modal" href="#">
                        <div class="mask">
                            <div style="color: #ffffff; font-size: 12px; padding-top: 27px; width: 80px;">
                                <i class="glyphicon glyphicon-camera"></i> Update Profile Picture
                            </div>

                        </div>
                    </a>
                </div>
            </div>




        </div>

        <div style="clear: both"></div>
    </div>
    <!--social message notification start-->

    <div style="clear: both"></div>
    <div class="message_notificationwrap">
        <div class="">
            <div class="iconwrapmobile">
                <div class="dropdown">

                    <div class="dropdown-toggle" type="button" data-toggle="dropdown">
                        <img border="0" src="img/n.png" class="iconn" title="Notifications">
                        <span style="color: #ffffff; font-size: 11px">
                            <asp:Label ID="lblCountNtification" runat="server" Text=""></asp:Label></span>
                        <div style="clear: both"></div>
                    </div>

                    <ul class="dropdown-menu notificationdropdown">
                        <div class="notiwrap">
                            <div class="col-sm-6 col-xs-6">Notifications</div>
                            <%--  <div class="col-sm-6 col-xs-6" style="text-align: right"><a href="#">Setting</a></div>--%>
                            <div style="clear: both"></div>
                        </div>

                        <asp:Repeater ID="dlNotification" runat="server">
                            <ItemTemplate>
                                <li>
                                    <a style="text-decoration: none; padding: 0px" href="Post_View.aspx?ID=+<%#Eval("Post_Id") %>+&Product=+<%#Eval("Product") %>+ &TB_iframe=true&height=600&width=800">
                                        <div class="profileimgnotifib2">

                                            <div class="row">
                                                <div class="col-sm-1 col-xs-2">
                                                    <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriend" />

                                                </div>



                                                <div class="col-sm-8 col-xs-9">

                                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label>
                                                    <a href="<%# "Post_View.aspx?ID=" +blog.Encrypt(Eval("Post_Id").ToString()) %>">
                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("p_Content") %>' Width=" "></asp:Label></a><br>
                                                    <span style="font-size: 12px"><%# string.Format("{0:MMMM d, yyyy}", Eval("Post_Date"))%></span> at <span style="font-size: 11px"><%# Eval("StartTime")%></span>    <%# Eval("StartTime")%></span> 
                                                </div>

                                                <div class="col-sm-1 col-xs-2" style="display: none">
                                                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# Bind("Image_Name",  "~/images/Items/{0}") %>' class="imgprofriend" />

                                                </div>
                                                <div style="clear: both"></div>

                                            </div>
                                            <div style="clear: both"></div>

                                        </div>
                                    </a>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>

            </div>
            <div class="iconwrapmobile">
                <div class="dropdown">
                    <div class="dropdown-toggle" type="button" data-toggle="dropdown">
                        <img border="0" src="img/m.png" class="iconn" title="Message">
                    </div>
                    <ul class="dropdown-menu messagedropdown">
                        <div class="notiwrap">
                            <div class="col-sm-8">
                                <a href="#" style="text-decoration: none">Recent(0)</a>
                                <a href="#" style="text-decoration: none">Message requests (3)</a>
                            </div>

                            <div style="clear: both"></div>
                        </div>
                        <li>
                            <a style="text-decoration: none; padding: 0px" href="#">
                                <div class="profileimgnotifi">

                                    <div class="row">
                                        <div class="col-sm-1 col-xs-2">
                                            <img border="0" align="left" src="img/img3.png" class="imgprofilenotifi">
                                        </div>
                                        <div class="col-sm-10  col-xs-10">
                                            <div class="righttext">
                                                Bangladesh is a small country.<br>
                                            
                                            </div>
                                            <div style="clear: both"></div>
                                        </div>
                                    </div>
                                    <div style="clear: both"></div>

                                </div>
                            </a>
                        </li>
                    </ul>
                </div>

            </div>
            <%--Foloower Requesr Lok--%>
            <div class="iconwrapmobile">
                <div class="dropdown">
                    <div class="dropdown-toggle" type="button" data-toggle="dropdown">
                        <img border="0" src="img/f.png" class="iconn" title="Followers Request">
                    </div>
                    <ul class="dropdown-menu friendrequestdropdown">
                        <div class="notiwrap">
                            <div class="col-sm-6">
                                Followers requests
                            </div>

                            <div style="clear: both"></div>
                        </div>
                        <li>

                            <asp:Repeater ID="rptFollowersDL" runat="server">
                                <ItemTemplate>
                                    <a style="text-decoration: none; padding: 0px" href="#">
                                        <div class="profileimgnotifibb">
                                            <div class="row">
                                                <div class="col-sm-1 col-xs-1">
                                                    <%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                    <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofilenotifi" />
                                                    </a>
                                                </div>
                                                <div class="col-sm-5 col-xs-5">
                                                    <div style="font-size: 11px;">
                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                        <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
                                                    </div>
                                                    <div style="clear: both"></div>
                                                </div>
                                                <div class="col-sm-5 col-xs-5">

                                                    <asp:Button ID="btnReply" runat="server" Text="Confirm" OnClick="btnReplyClickedConfirm" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' class="confirmbtnfn2 " />
                                                    </asp:LinkButton>
                                         
                                                    
											          <asp:Button ID="Button8" runat="server" Text="Delete" OnClick="btnReplyClickedDelete" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' class="confirmbtnfn2 " Style />
                                                    </asp:LinkButton>

                                                </div>
                                                <div style="clear: both"></div>
                                            </div>
                                        </div>

                                    </a>

                                </ItemTemplate>
                            </asp:Repeater>
                        </li>

                    </ul>
                </div>

            </div>


            <div class="iconwrapmobile">

                <%--Ali For Chat System ---------------------------------------------------Start--%>

                <img src="img/chat.png" class="iconn" title="Chat">

                <%--Ali For Chat System ---------------------------------------------------End--%>
            </div>
            <div class="iconwrapmobile">
                <div class="dropdown">
                    <div class="dropdown-toggle" type="button" data-toggle="dropdown">
                        <img border="0" src="img/signout.png" class="iconn" title="Account Information">
                    </div>
                    <ul class="dropdown-menu myaccountdropdown">
                        <li>
                            <a style="text-decoration: none; padding: 0px" href="index2.html" target="_blank">
                                <div class="profileimgnotifi">
                                    <div class="col-sm-1 col-xs-2">
                                        <img align="left" src="img/interboll.png" class="settingicon">
                                    </div>
                                    <div class="col-sm-9 col-xs-12">
                                        <div class="">Advertising on Interboll</div>
                                    </div>

                                    <div style="clear: both"></div>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a href="setting.aspx" style="text-decoration: none; padding: 0px">
                                <div class="profileimgnotifi">
                                    <div class="col-sm-1 col-xs-2">
                                        <img align="left" src="img/setting.png" class="settingicon">
                                    </div>
                                    <div class="col-sm-9 col-xs-9">
                                        <div class="">Settings</div>
                                    </div>

                                    <div style="clear: both"></div>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a style="text-decoration: none; padding: 0px" href="help.aspx">
                                <div class="profileimgnotifi">
                                    <div class="col-sm-1 col-xs-2">
                                        <img border="0" align="left" src="img/help.png" class="settingicon">
                                    </div>
                                    <div class="col-sm-9 col-xs-9">
                                        <div class="">Help</div>
                                    </div>

                                    <div style="clear: both"></div>
                                </div>
                            </a>
                        </li>



                        <li>
                            <a style="text-decoration: none; padding: 0px" href="privacy.aspx">
                                <div class="profileimgnotifi">
                                    <div class="col-sm-1 col-xs-2">
                                        <img border="0" align="left" src="img/privacy.png" class="settingicon">
                                    </div>
                                    <div class="col-sm-9 col-xs-9">
                                        <div class="">Privacy & Policy</div>
                                    </div>

                                    <div style="clear: both"></div>
                                </div>
                            </a>
                        </li>

                        <li>
                            <a style="text-decoration: none; padding: 0px" href="#">
                                <div class="profileimgnotifi">
                                    <div class="col-sm-1 col-xs-2">
                                        <a href="signout.aspx">
                                            <img style="border: 0px" src="img/signout2.png" class="settingicon" title="Logout" /></a>
                                    </div>
                                    <div class="col-sm-5 col-xs-5">
                                        <a href="signout.aspx" style="color: #000">Log Out</a>
                                    </div>

                                    <div style="clear: both"></div>
                                </div>
                            </a>
                        </li>


                    </ul>
                </div>
            </div>
        </div>
        <div style="clear: both"></div>
    </div>
    <!--social message notification end-->

    <div class="boxsocial3">
        <div class="scrollboxhide3"></div>
        <div class="scrollboxhide3r"></div>
        <!--tab start-->
        <div class="tabcontentswrap">
            <div id="exTab2" class="">
                <ul class="nav nav-tabs tabcss">
                    <li class="menumin"><a href="eventdefault.aspx">Event</a>
                    </li>
                    <li class="menumin ">
                        <a href="outlinedefault.aspx">Outline</a>
                    </li>
                    <li class="menumin"><a aria-expanded="true" href="#4m" data-toggle="tab">Photos</a>
                    </li>
                    <li class="menumin active "><a aria-expanded="false" href="#3m" data-toggle="tab">Followers</a>
                    </li>
                    <li class="menumin"><a aria-expanded="false" href="#1m" data-toggle="tab">Education</a>
                    </li>
                    <li class="menumin"><a href="../games/Default.aspx" target="_blank">Games</a>
                    </li>
                    <li class="menumin"><a href="index_entertainment.html" target="_blank">
                        <div style="display: none">
                            <asp:Label ID="lblAdprofile" runat="server" Text=""></asp:Label>
                        </div>
                        Entertainment
                    </a>
                    </li>
                    <li class="menumin"><a aria-expanded="false" data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">More</a>
                        <ul class="dropdown-menu moredropdown">

                            <asp:Repeater ID="rptMore" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a href="<%# "More.aspx?ID="  +blog.Encrypt(Eval("T_Id").ToString()) %>" style="text-decoration: none; padding: 0px">
                                            <asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("T_Name") %>' Width=""></asp:Label>

                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>

                            <li>
                                <a href="Notes.aspx" style="text-decoration: none; padding: 0px">Notes
                                </a>
                            </li>
                            <li>
                                <a href="Reminder.aspx" style="text-decoration: none; padding: 0px">Reminders
                                </a>
                            </li>

                        </ul>
                    </li>

                </ul>
                </li>
                                </ul>
                                <div class="tab-content tabcontents">

                                    <div class="tab-pane active" id="3m">

                                        <div class="boxpro2">
                                            <div class="aboutwrap">
                                                <div class="row">
                                                    <div class="col-sm-12 text-right">
                                                        <ul class="nav nav-tabs tabcssfollowers">
                                                            <li class="menumfollow active"><a aria-expanded="false" href="#11b" data-toggle="tab">Followers</a>
                                                            </li>
                                                            <li class="menumfollow"><a aria-expanded="false" href="#12b" data-toggle="tab">Followers Requests</a>
                                                            </li>
                                                            <li class="menumfollow ">
                                                                <a aria-expanded="false" href="#13b" data-toggle="tab">Find Followers</a>
                                                            </li>
                                                            <li class="menumfollow"><a aria-expanded="false" href="#14b" data-toggle="tab">Following</a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>

                                            <div id="exTab2" class="">


                                                <div class="tab-content tabcontents">
                                                    <div class="tab-pane active" id="11b" style="">
                                                        <div class="row gutter-10">


                                                            <div class="row">
                                                                <asp:Repeater ID="rptFollowers" runat="server">
                                                                    <ItemTemplate>
                                                                        <div class="col-sm-6">

                                                                            <div class="allfriends">
                                                                                <div class="row">
                                                                                    <div class="col-sm-2 col-xs-2">
                                                                                        <%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                            <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriend" />
                                                                                        </a>
                                                                                    </div>
                                                                                    <div class="col-sm-7">
                                                                                        <div style="font-size: 11px;">
                                                                                            <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                                                            <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
                                                                                        </div>

                                                                                    </div>
                                                                                    <div class="col-sm-2">

                                                                                        <div style="margin-left: -8px" class="fontsizetext">Followers</div>

                                                                                    </div>

                                                                                </div>

                                                                            </div>
                                                                            <div style="clear: both"></div>
                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>
                                                                <div style="clear: both"></div>
                                                            </div>



                                                            <div style="clear: both"></div>
                                                        </div>
                                                    </div>



                                                    <div class="tab-pane" id="12b" style="">
                                                        <div class="row gutter-10">

                                                            <asp:Repeater ID="rptRequest" runat="server">
                                                                <ItemTemplate>
                                                                    <div class="col-sm-6">

                                                                        <div class="allfriends">
                                                                            <div class="row">
                                                                                <div class="col-sm-2 col-xs-2">
                                                                                    <%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                                                    <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/images/Items/{0}") %>' class="imgprofriend" />
                                                                                    </a>
                                                                                </div>
                                                                                <div class="col-sm-7">
                                                                                    <div style="font-size: 11px;">
                                                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                                                        <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
                                                                                    </div>

                                                                                </div>
                                                                                <div class="col-sm-3">

                                                                                    <span class="fontsizetext">request sent</span>

                                                                                </div>

                                                                            </div>

                                                                        </div>
                                                                        <div style="clear: both"></div>
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:Repeater>




                                                            <div style="clear: both"></div>
                                                        </div>
                                                    </div>

                                                    <div class="tab-pane" id="13b" style="">

                                                        <div class="row gutter-10">
                                                            <asp:Repeater ID="rptSearchFrnd" runat="server">
                                                                <ItemTemplate>
                                                                    <div class="col-sm-6">

                                                                        <div class="allfriends">
                                                                            <div class="row">
                                                                                <div class="col-sm-2 col-xs-2">
                                                                                    <%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                                                    <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/images/Items/{0}") %>' class="imgprofriend" />
                                                                                    </a>
                                                                                </div>
                                                                                <div class="col-sm-7  col-xs-7">
                                                                                    <div style="font-size: 11px;">
                                                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                                                        <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
                                                                                    </div>
                                                                                    <div style="clear: both"></div>
                                                                                </div>
                                                                                <div class="col-sm-2  col-xs-2">
                                                                                    <%--  <button class="confirmbtnf2">Followers</button>--%>
                                                                                    <asp:Button ID="btnReply" runat="server" Text="Add" OnClick="btnReplyClicked" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' CssClass="confirmbtnf2" />
                                                                                    </asp:LinkButton>
                                         
                                                                                </div>
                                                                                <div style="clear: both"></div>
                                                                            </div>
                                                                            <div style="clear: both"></div>
                                                                        </div>



                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </div>
                                                    </div>


                                                    <div class="tab-pane" id="14b" style="">


                                                        <asp:Repeater ID="rptFollowing" runat="server">
                                                            <ItemTemplate>
                                                                <div class="col-sm-6">

                                                                    <div class="allfriends">
                                                                        <div class="row">
                                                                            <div class="col-sm-2 col-xs-2">
                                                                                <%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                    <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriend" />
                                                                                </a>
                                                                            </div>
                                                                            <div class="col-sm-7  col-xs-7">
                                                                                <div style="font-size: 11px;">
                                                                                    <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                                                    <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
                                                                                </div>
                                                                                <div style="clear: both"></div>
                                                                            </div>
                                                                            <div class="col-sm-2  col-xs-2">
                                                                                <%--  <button class="confirmbtnf2">Followers</button>--%>
                                                                                <asp:Button ID="btnReply" runat="server" Text="Add" OnClick="btnReplyClicked1" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' CssClass="confirmbtnf2" />
                                                                                </asp:LinkButton>
                                         
                                                                            </div>
                                                                            <div style="clear: both"></div>
                                                                        </div>
                                                                    </div>



                                                                </div>
                                                            </ItemTemplate>
                                                        </asp:Repeater>


                                                    </div>
                                                </div>


                                            </div>



                                            <div style="clear: both"></div>

                                        </div>

                                    </div>



                                    <div class="tab-pane" id="4m">
                                        <!--post-box1 start-->
                                        <div class="boxpro2">
                                            <div class="aboutwrap">
                                                <div class="row">
                                                    <div class="col-sm-3 col-xs-3" style="display: none">
                                                        <div class="col-sm-1">
                                                            <img border="0" align="left" src="img/f.png" class="aboutimg">
                                                        </div>
                                                        <div class="col-sm-6 col-xs-1">
                                                            <span style="font-size: 15px; color: #ffffff">Photos</span>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-12 col-xs-12 text-right">
                                                        <ul class="nav nav-tabs tabalbumwrap">
                                                            <li class="tabalbum"><a href="Createphoto1.aspx" aria-expanded="true">Create Album</a>
                                                            </li>
                                                            <li class="tabalbum active"><a data-toggle="tab" href="#yourphotom2" aria-expanded="false">Your Photo</a>
                                                            </li>
                                                            <li class="tabalbum">
                                                                <a data-toggle="tab" href="#albumm2" aria-expanded="false">Albums</a>
                                                            </li>

                                                        </ul>
                                                    </div>
                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>

                                            <!--your photo-start-->
                                            <div class="" id="exTab2">
                                                <div class="tab-content tabcontents">
                                                    <div style="" id="yourphotom2" class="tab-pane active">
                                                        <div class="friendsall" style="margin-top: 10px">
                                                            <div class="row gutter-10">
                                                                <asp:Repeater ID="dlPostimage1" runat="server">
                                                                    <ItemTemplate>
                                                                        <div class="col-sm-4 col-xs-4">


                                                                            <asp:Image ID="Image3" runat="server" class="impphotosite" ImageUrl='<%# Bind("Image_Name",  "~/images/Items/{0}") %>' />




                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>

                                                                <div style="clear: both"></div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div style="" id="albumm2" class="tab-pane">
                                                        <div class="boxproe2">
                                                            <div class="row gutter-10">
                                                                <asp:Repeater ID="dlalbum2" runat="server" Visible="true">
                                                                    <ItemTemplate>
                                                                        <div class="col-sm-3 col-xs-4">
                                                                            <a href="showalbumpic.aspx" target="_blank">
                                                                                <div class="photouploasmallthumble">
                                                                                    <a href="<%# "ShowAlbumPic.aspx?ID=" +blog.Encrypt(Eval("Album_Id").ToString()) %>">
                                                                                        <asp:Image ID="Image2" class="impphotosite" runat="server" ImageUrl='<%# Bind("Album_Image",  "~/images/Albums/{0}") %>' /></a>
                                                                                    <br />
                                                                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Album_Name") %>' Width=" "></asp:Label>

                                                                                </div>
                                                                            </a>
                                                                            <div class="leftimag2">
                                                                                <%--  <asp:Button ID="Button4" runat="server" Text="Add Photo" OnClick="btnShareClicked" AutoPostBack="True" CommandArgument='<%#Eval("Album_Id")%>' cssclass="postbtn"/>--%>
                                                                            </div>
                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>
                                                            </div>
                                                        </div>
                                                    </div>

                                                </div>
                                            </div>

                                            <!--your photo-end-->


                                            <div style="clear: both"></div>
                                        </div>
                                        <!--photo-box1 end-->


                                    </div>

                                    <div class="tab-pane" id="5m">
                                        <!--news-feed-srart-->
                                        <div class="boxpro2">

                                            <%--   Add Profile Sumon--%>

                                            <div style="clear: both"></div>
                                        </div>
                                        <!--news-feed-end-->
                                    </div>
                                </div>
            </div>
        </div>
        <!--tab end-->

        <div style="clear: both"></div>
    </div>
</div>


<!--model addwork info start-->



<!--browse update profile image-->
<div class="modal fade" id="updatephotom" role="dialog">
    <div class="modal-dialog modal_editpopup">

        <!-- Modal content-->
        <div class="modal-content modelcontentpop">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Upload Profile Picture</h4>
            </div>
            <div class="modal-body2">
                <div style="">
                    <div class="col-sm-4">
                        <div style="font-size: 18px"></div>

                    </div>
                    <div class="col-sm-4">

                        <asp:FileUpload ID="fileUploadProfileImage" runat="server" Style="margin-top: 5px;" />
                    </div>
                    <div class="col-sm-4">
                        <div style="font-size: 18px"></div>

                    </div>

                    <div style="clear: both"></div>
                </div>
                <hr />

                <div class="photothumble">
                    <div class="col-sm-12">
                        <div class="row">
                            <div class="col-sm-4">
                            </div>
                            <div class="col-sm-4">
                                <asp:Image ID="profileImage" Width="100px" Height="100px" BorderColor="Blue" runat="server" />
                                <asp:Label ID="Label1" runat="server" Visible="false" Text=""></asp:Label>
                            </div>

                            <div class="col-sm-4">
                            </div>
                        </div>
                    </div>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default savebtn" onserverclick="btnProfileImage_Click" runat="server">Save</button>
                <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
            </div>
        </div>

    </div>
</div>
<!--End browse update profile image-->

<!--Start cover photo start-->
<div class="modal fade" id="updatecoverphotom" role="dialog">
    <div class="modal-dialog modal_editpopupm">


        <div class="modal-content modelcontentpop">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Upload Cover Photo </h4>
            </div>
            <div class="modal-body2">
                <div style="">
                    <div class="col-sm-4">
                        <%--   <div style="font-size:18px"> Take photo</div>--%>
                    </div>
                    <div class="col-sm-4">
                        <%--  <div style="font-size:18px"></div>--%>
                        <asp:FileUpload ID="fileUploadCoverimage" runat="server" Style="margin-top: 5px;" />
                    </div>

                    <div class="col-sm-4">
                        <%-- <div style="font-size:18px"> Edit Thumbnail</div>--%>
                    </div>
                    <div style="clear: both"></div>
                </div>
                <hr />

                <div class="photothumble">
                    <div class="col-sm-12">
                        <div class="row">
                            <div class="col-sm-4">
                                <%-- <img border="0" align="left" src="img/img3.png" class="photoupimg">--%>
                            </div>
                            <div class="col-sm-4">
                                <asp:Image ID="CoverImage" Width="100px" Height="100px" BorderColor="Blue" runat="server" />
                                <asp:Label ID="Label2" runat="server" Visible="false" Text=""></asp:Label>
                            </div>

                            <div class="col-sm-4">
                                <%--  <img border="0" align="left" src="img/img3.png" class="photoupimg">--%>
                            </div>
                        </div>
                    </div>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default savebtn" onserverclick="btnCoverImage_Click" runat="server">Save</button>
                <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
            </div>
        </div>

    </div>
</div>
<asp:Literal ID="lblFirstname" runat="server" Visible="false"></asp:Literal>
<asp:Label ID="lok1" runat="server" Text="" Visible="false"></asp:Label>
<asp:Label ID="lok2" runat="server" Text="" Visible="false"></asp:Label>
<asp:HiddenField ID="hidArticleId" runat="server" />
