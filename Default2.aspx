<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" ValidateRequest="false" Inherits="Default2" %>

<%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<%@ Register Src="Usercontrol/leftside.ascx" TagName="left" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    
               <%--  <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>        --%>        
      <script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
    <style type="text/css">
        .comentbtn {
            cursor: pointer;
        }

        .cmtdetails {
            display: none;
            visibility: hidden;
        }
    </style>

    <style type="text/css">
        .file-upload {
            display: inline-block;
            overflow: hidden;
            text-align: center;
            vertical-align: middle;
            font-family: Arial;
            border: 1px solid #124d77;
            background: #007dc1;
            color: #fff;
            border-radius: 6px;
            -moz-border-radius: 6px;
            cursor: pointer;
            text-shadow: #000 1px 1px 2px;
            -webkit-border-radius: 6px;
        }

            .file-upload:hover {
                background: -webkit-gradient(linear, left top, left bottom, color-stop(0.05, #0061a7), color-stop(1, #007dc1));
                background: -moz-linear-gradient(top, #0061a7 5%, #007dc1 100%);
                background: -webkit-linear-gradient(top, #0061a7 5%, #007dc1 100%);
                background: -o-linear-gradient(top, #0061a7 5%, #007dc1 100%);
                background: -ms-linear-gradient(top, #0061a7 5%, #007dc1 100%);
                background: linear-gradient(to bottom, #0061a7 5%, #007dc1 100%);
                filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#0061a7', endColorstr='#007dc1',GradientType=0);
                background-color: #0061a7;
            }

        /* The button size */
        .file-upload {
            height: 25px;
        }

            .file-upload, .file-upload span {
                width: 90px;
            }

        .file-upload {
            display: inline-block;
            overflow: inherit !important;
            text-align: center;
            vertical-align: middle;
            font-family: Arial;
            border: 0px solid #124d77 !important;
            background: None !important;
            color: #fff;
            /* border-radius: 6px; */
            -moz-border-radius: 0px;
            cursor: pointer;
            /* text-shadow: #000 1px 1px 2px; */
            /* -webkit-border-radius: 6px; */
            padding-top: 0px !important;
            padding-bottom: 0px;
            padding: 0px !importantx;
            padding: 0px !important;
            margin-top: 0px;
            height: 20px;
        }

            .file-upload input {
                top: 0;
                left: 0;
                margin: 0;
                font-size: 13px;
                font-weight: bold;
                /* Loses tab index in webkit if width is set to 0 */
                opacity: 0;
                filter: alpha(opacity=0);
            }

            .file-upload strong {
                font: normal 14px Tahoma,sans-serif;
                text-align: center;
                vertical-align: middle;
            }

            .file-upload span {
                top: 0;
                left: 0;
                display: inline-block;
                /* Adjust button text vertical alignment */
                padding-top: 0px;
            }

            .file-upload, .file-upload span {
                width: 42px !important;
            }
    </style>



    <script type="text/javascript">
        $(document).ready(function () { $('#<%=Avatar.ClientID %>').hide(); });
        function previewFile() {
            //css("display","block");

            var preview = document.querySelector('#<%=Avatar.ClientID %>');
              $('#<%=Avatar.ClientID %>').show();
              var file = document.querySelector('#<%=file_upload.ClientID %>').files[0];
              var reader = new FileReader();

              reader.onloadend = function () {
                  preview.src = reader.result;
              }

              if (file) {
                  reader.readAsDataURL(file);
              } else {
                  preview.src = "";
              }
          }
    </script>



    <script src="admin/js/tinymce/tinymce.min.js"></script>
    <link href="admin/tinymce/skins/lightgray/skin2.min.css" rel="stylesheet" />

    <script type="text/javascript" src="/js/tinymce/tinymce.min.js"></script>



    <script type="text/javascript">
        tinymce.init({
            //plugins: "placeholder",
            selector: "textarea",
            //height:20,
            plugins: [
                "advlist autolink lists link image charmap print preview anchor",
                "searchreplace visualblocks fullscreen",
                "insertdatetime media table contextmenu paste"
            ],
            toolbar: "false",
            menubar: "false"
        });
    </script>


    <style type="text/css">
        .mce-toolbar-grp {
            display: none !important;
        }
        /*.mce-panel {
  background-color: #f0f0f0;
  border: 0 solid rgba(0, 0, 0, 0.2);
    display: none;
}*/
        .mce-flow-layout {
            display: none !important;
            white-space: normal;
        }
    </style>
    <%-- <div class="col-sm-12" title="Coments"><asp:Button ID="Button3" runat="server" Text="Add Comment"  OnClick="btnReplyClicked2"  CommandName="lokinPost" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="commentsbtn" Visible="" OnClientClick="SavePersonRecord(); return false"/>/></div>--%>
  
     




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

                <div class="boxpro">

                    <div class="photouploadstatus">

                        <div style="clear: both"></div>
                    </div>

                    <div style="margin-top: 10px" class="row">
                        <%--  <div class="col-sm-1">
							     <img  align="left" src="img/img3.png" class="imgprofilenotifi2">
							  </div>--%>

                        <div class="col-sm-12">
                            <div style="padding: 4px 6px 0px 7px; background-color: #d0d0d0; margin-top: -9px; width: 101%; height: 115px;">
                                <textarea name="limitedtextarea" style="width: 100%; min-height: 65px; border: 0px" placeholder="What's in your imagination?" id="post" runat="server"></textarea>
                            </div>



                            <div>

                                <asp:Image ID="Avatar" runat="server" Height="100px" Width="125px" Style="border: 0px" />

                            </div>
                            <%--<asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
                                  <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />--%>
                        </div>

                    </div>
                    <!--check in-box start-->
                    <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
                    <div class="checkbox">




                        <asp:TextBox ID="my_control" runat="server" Visible="true" Style="display: none; width: 100%; padding-left: 10px"></asp:TextBox>
                        <%-- <asp:TextBox ID="my_control"  runat="server" Visible="true"></asp:TextBox>--%>
                    </div>
                    <!--check box-->
                    <div class="photouploadstatus" style="margin-top: 10px">
                        <div class="topupload">

                            <%--update anel--%>
                            <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                                <ContentTemplate>
                                    <div class="leftimag">
                                        <div class="dropdown">
                                            <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">
                                                <button class="btn-primary postbtn" title="Tag People"><i class="glyphicon glyphicon-user" title="Tag People"></i></button>
                                            </div>
                                            <ul class="dropdown-menu postinfotagpeople">
                                                <li>
                                                    <div class="profileimgnotifi">


                                                        <div style="clear: both"></div>

                                                    </div>
                                                </li>

                                                <li>
                                                    <div class="profileimgnotifi">

                                                        <div class="row">
                                                            <%-- <div class="col-sm-1">
                                                                               <input type="checkbox" name="Checkbox" value="Checkbox">
                                                                            </div>

                                                                            <div class="col-sm-1">
                                                                                 <img border="0" align="left" src="img/img3.png" class="imgprotagpeople">
                                                                            </div>
                                                                            <div class="col-sm-9">
                                                                                <div class="righttext">
                                                                                 Rahim
                                                                                </div>
                                                                                <div style="clear: both"></div>
                                                                            </div>--%>
                                                            <asp:DataList ID="dlfrndlist" runat="server" DataKeyField="IID"
                                                                RepeatColumns="1" OnSelectedIndexChanged="DataListBrand_SelectedIndexChanged1">
                                                                <ItemTemplate>

                                                                    <div class="col-sm-1">
                                                                        <asp:CheckBox ID="chkbox" runat="server" Text="" AutoPostBack="true"
                                                                            OnCheckedChanged="CheckBoxListTest_SelectedIndexChanged" />
                                                                        </checkbox>  
                                                                    </div>

                                                                    <div class="col-sm-1">
                                                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprotagpeople" />
                                                                        <asp:Label ID="Label3" runat="server" Visible="false" Text='<%# Eval("IID")%>' />
                                                                        <asp:Label ID="Label4" runat="server" Visible="false" Text='<%# Eval("IID")%>' />

                                                                    </div>
                                                                    <div class="col-sm-9">
                                                                        <div class="righttext">
                                                                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label>
                                                                        </div>
                                                                        <div style="clear: both"></div>
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:DataList>



                                                        </div>
                                                        <div style="clear: both"></div>

                                                    </div>
                                                </li>

                                            </ul>
                                        </div>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <div class="leftimag">
                                <%--   <button class="btn-primary postbtn" title="Camera"></button>--%>

                                <label class="file-upload">
                                    <span><strong><i class="glyphicon glyphicon-camera" title="Camera/Video"></i></strong></span>
                                    <asp:FileUpload ID="file_upload" runat="server" onchange="previewFile()"></asp:FileUpload>
                                </label>


                            </div>

                            <!--check in-->
                            <div class="leftimag" style="margin-top: 3px" title="Check in">
                                <%--    <i class="glyphicon glyphicon-map-marker" style="color:#ffffff"></i>--%>
                                <asp:LinkButton ID="lb_link_button" runat="server" OnClientClick="return ToggleShowHide()" class="glyphicon glyphicon-map-marker" Style="color: #ffffff" />
                            </div>
                            <!--check end-->

                            <div class="leftimag">
                                <div class="dropdown">
                                    <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">
                                        <button class="btn-primary postbtn" title="Status"><i class="glyphicon glyphicon-pencil" title="Status"></i></button>
                                    </div>
                                    <ul class="dropdown-menu postinfotagpeople">
                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">

                                                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Group1" />

                                                    </div>

                                                    <div class="col-sm-8">
                                                        celebrating
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Group1" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        feelings
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>

                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Group1" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        Listening
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>

                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Group1" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        Meeting
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>

                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Group1" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        Traveling
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>


                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="Group1" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        Watching
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>

                                    </ul>
                                </div>


                            </div>

                            <div class="leftimag">
                                <div class="dropdown">
                                    <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">
                                        <button class="btn-primary postbtn" title="Follower/Only Me">
                                            <i class="glyphicon glyphicon-eye-open" aria-hidden="true"></i>
                                        </button>
                                    </div>
                                    <ul class="dropdown-menu postinfotagpeople">
                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton7" runat="server" GroupName="Group2" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        Follower
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="row">
                                                <div class="profileimgnotifi">
                                                    <div class="col-sm-1">
                                                        <asp:RadioButton ID="RadioButton8" runat="server" GroupName="Group2" />
                                                    </div>

                                                    <div class="col-sm-8">
                                                        Only Me
                                                    </div>

                                                    <div style="clear: both"></div>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </div>


                            </div>
                            <div class="leftimag">
                                <button type="submit" runat="server" id="btnLogin" class="btn-primary postbtn" onserverclick="btnLogin_Click">
                                    Post
                                </button>
                            </div>

                            <%--<div class="col-sm-6">
                                      <a href="" class="textdecorationsta2" title="Status"> <i class="glyphicon glyphicon-pencil"></i> </a>
								      <a title="Tag people in Your Post" class="textdecorationsta2" href="#"><i class="glyphicon glyphicon-user"></i>  </a>
									  <a title="Check in" class="textdecorationsta2" href="#"> <i class="glyphicon glyphicon-map-marker"> </i>  </a>
                                       <a title="Life Events" class="textdecorationsta2" href="#"> <i class="glyphicon glyphicon-king"> </i> </a>
                      
                                       <a class="textdecorationsta2" href="#" title="add photo and Video to your post" data-target="#addphotovideo2" data-toggle="modal"><i class="glyphicon glyphicon glyphicon-open"></i> </a>
                                     <a title="Camera" class="textdecorationsta2" href="#"> <i class="glyphicon glyphicon-camera"> </i> </a>
								 </div>--%>

                            <div style="text-align: right" class="">
                                <%--	<button class="confirmbtnp">Public <span class="glyphicon glyphicon-triangle-bottom"></span></button>
									<button class="confirmbtnp">Post</button>--%>
                            </div>
                            <div style="clear: both"></div>
                        </div>
                    </div>
                </div>

                <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>

                        <div class="scrollbox">
                            <!--post-box1 start-->
                            <asp:Repeater ID="rptPost" runat="server" OnItemDataBound="RepeaterItemCreated1" OnItemCommand="itemRepeater_ItemCreated">
                                <ItemTemplate>



                                    <div class="boxpro">
                                        <div class="row">

                                            <div class="col-sm-9 col-xs-8">
                                                <%--   <a href="#"> <img border="0" align="left" class="imgprofilenotifi2" src="img/img3.png"></a>--%>
                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("A_User_Id").ToString()) %>">
                                                    <asp:Image ID="Image2" runat="server" CssClass="imgprofilenotifi2" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' /></a>
                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("A_User_Id").ToString()) %>">
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label>
                                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("F_Image") %>' Width=" "></asp:Label>
                                                    ,

							      <span style="font-size: 11px"><%# string.Format("{0:dd MMM yyyy}", Eval("P_Date"))%></span>
                                                    <br />


                                                    <div class="IdLabel"style="color:#ffffff" accesskey='<%# Eval("P_Id") %>' ><%# Eval("P_Id") %></div>
                                                    <asp:Label ID="lblpostid"  CssClass=""  runat="server" Text='<%# Bind("P_Id") %>' Width=" " Visible="false"></asp:Label>
                                                    <asp:Label ID="lblP_Image" runat="server" Text='<%# Bind("P_Image") %>' Width=" " Visible="false"></asp:Label>
                                                    <asp:Label ID="lblUserid" runat="server" Text='<%# Bind("A_User_Id") %>' Width=" " Visible="false"></asp:Label>

                                                </a>
                                            </div>

                                            <div class="col-sm-3 col-xs-4 text-right">
                                                <div class="lefttag">
                                                    <a href="#" data-toggle="dropdown" type="button" class="dropdown-toggle" title="Liked"><i class="glyphicon glyphicon-hand-right"></i>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Like1") %>' Width=" "></asp:Label>
                                                    </a>
                                                    <ul class="dropdown-menu tagpeoplenumlike">
                                                        <%--  <li>
                                                          <div class="row">
                                                         <div class="col-sm-1"><img id="" class="imgprofilenotifi2" src="images/Items/_27101611231614702393_10154390021751141_7886131919874772818_n.jpg" style="border-width:0px;"></div>
						                                  <div class="col-sm-8">
                                                          <a href="#" style="">
								                            Rahim Ahmed
							                              </a>
                                                         </div>
                                                        </div>
					                                </li>--%>
                                                        <asp:Repeater ID="rptLikeUser" runat="server">
                                                            <ItemTemplate>

                                                                <div class="profileimgnotifi2">
                                                                    <div class="row">
                                                                        <div class="col-sm-1">

                                                                            <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriend" />
                                                                            </a>
                                                                        </div>
                                                                        <div class="col-sm-10">
                                                                            <div style="font-size: 11px;">
                                                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                                            </div>

                                                                        </div>
                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>



                                                            </ItemTemplate>
                                                        </asp:Repeater>

                                                    </ul>
                                                </div>
                                                <div class="lefttag">
                                                    <a href="#" data-toggle="dropdown" type="button" class="dropdown-toggle" title="Share"><i class=" glyphicon glyphicon-share"></i>
                                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("share1") %>' Width=" "></asp:Label></a>
                                                    <ul class="dropdown-menu postinfodrop">
                                                        <%--  <li>
                                                          <div class="row">
                                                         <div class="col-sm-1"><img id="" class="imgprofilenotifi2" src="images/Items/_27101611231614702393_10154390021751141_7886131919874772818_n.jpg" style="border-width:0px;"></div>
						                                  <div class="col-sm-8">
                                                          <a href="#" style="">
								                            Rahim Ahmed
							                              </a>
                                                         </div>
                                                        </div>
					                                </li>--%>
                                                        <asp:Repeater ID="rptShareUser" runat="server">
                                                            <ItemTemplate>
                                                                <div class="profileimgnotifi">
                                                                    <div class="row">
                                                                        <div class="col-sm-1">

                                                                            <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriend" />
                                                                            </a>
                                                                        </div>
                                                                        <div class="col-sm-10">
                                                                            <div style="font-size: 11px;">
                                                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label></a><br>
                                                                            </div>

                                                                        </div>
                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>

                                                            </ItemTemplate>
                                                        </asp:Repeater>

                                                    </ul>
                                                </div>

                                                <div class="dropdown lefttag">
                                                    <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">
                                                        <i class="fa fa-tag" aria-hidden="true" tilte="Tag People"></i>
                                                    </div>
                                                    <ul class="dropdown-menu tagpeoplenum">
                                                        <asp:Repeater ID="rpttagpeople" runat="server" Visible="false">
                                                            <ItemTemplate>
                                                                <li>
                                                                    <div class="col-sm-1">
                                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                            <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriend" />
                                                                        </a>
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("Tagid").ToString()) %>">
                                                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Tagname") %>' Width=" "></asp:Label></a>
                                                                    </div>
                                                                </li>

                                                            </ItemTemplate>
                                                        </asp:Repeater>

                                                    </ul>
                                                </div>




                                            </div>
                                        </div>

                                        <div class="" style="margin-top: 10px;">
                                            <%--	<a href="#"><img border="0" align="left" src="img/naturalimg.jpg" class="imresponsive"></a>--%>
                                            <div id="video" runat="server" style="background-color: #000000">

                                                <video width="100%" height="250px" controls>
           
                      <source src="images/Items/<%# Eval("Post_Image")%>" type="video/mp4" />
                 </video>

                                            </div>
                                            <div style="text-align: center">
                                                <asp:Image ID="Image1" runat="server" Height="" Width="100%" CssClass="imresponsive" Visible="false" ImageUrl='<%# Bind("Post_Image", "~/images/Items/{0}") %>' /></div>




                                            <div style="clear: both"></div>


                                            <div class="dolessmore">
                                                <p>
                                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("P_Description") %>'></asp:Label></p>
                                                <div style="clear: both"></div>
                                            </div>
                                            <%--<div class="comment more"> <div><asp:Label CssClass="ShortDesc" Text='<%# Eval("P_Description").ToString().Substring(0,Math.Min(400,Eval("P_Description").ToString().Length)) %>' runat="server"></asp:Label></div></div>	--%>
                                        </div>


                                        <div class="photouploadstatus">
                                            <div class="topupload2">
                                                <div class="row2">
                                                    <div class=" ">
                                                        <div class="row2">
                                                            <%--<button href="#" class="textdecorationsta" title="Like" onServerClick="btnReplyClicked" runat="server" id="btnReply" CommandArgument='<%#Eval("P_Id")%>'><i class="glyphicon glyphicon-hand-right"></i>
                                         <asp:Label ID="lblLike111" runat="server" Text=""></asp:Label>--%>
                                                            <div class="leftimag2">
                                                                <asp:Button ID="btnReply" runat="server" Text="Like" OnClick="btnReplyClicked" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn" />
                                                            </div>

                                                            <div class="leftimag2">

                                                                <div id='h<%# Eval("P_Id") %>' class="commentsleft"
                                                                    onclick='ToggleDisplay(<%# Eval("P_Id") %>);' style="color: #fff; cursor: pointer">
                                                                    Comment    
                                                                </div>
                                                                <div class="commentscount" style="margin-left: 2px">
                                                                    <asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("Comment1") %>' Width=""></asp:Label></div>

                                                                <div class="commentsleft" style="display: none">
                                                                    <asp:Button ID="Button2" runat="server" Text="Comment" CommandName="lokin" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn2" />
                                                                </div>
                                                                <div style="clear: both"></div>

                                                            </div>

                                                            <div class="leftimag2">
                                                                <asp:Button ID="Button4" runat="server" Text="Share" OnClick="btnShareClicked" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn" />
                                                            </div>
                                                            <div class="leftimag2">
                                                                <button class="postbtn2" title="Save">Save </button>
                                                            </div>
                                                            <div class="leftimag2">
                                                                <button class="postbtn2" title="Hide">Hide</button></div>
                                                            <div class="leftimag2">
                                                                <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="btnReplyClicked1" Visible="false" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn" /></div>
                                                            <div class="leftimag2">
                                                                <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="btnReplyDelete" Visible="false" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn" OnClientClick="return confirm('Are you sure you want to delete this Information?');" /></div>


                                                            <%--  <asp:Button runat="server" ID="Button1" OnCommand="Button1_Command" Text="Like" />--%>
                                                        </div>


                                                        <div style="clear: both"></div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>


                                        <div id='d<%# Eval("p_Id") %>' class="cmtdetails">

                                            <asp:Repeater ID="dlcomment" runat="server">
                                                <ItemTemplate>
										
                                                    <div class="" class="cmtdetails" style="margin-top:8px; margin-bottom:8px; font-size:12px">
                                                       <div style="float:left; margin-right:10px">  <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                            <asp:Image ID="Image2" runat="server" CssClass="imgprofilenotifi2" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' /></a>
                                                       </div>
                                                          <div style="float:left"> 
                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label></a> <br>
                                                        <span style="font-size: 11px"><%# string.Format("{0:dd MMM yyyy}", Eval("P_Date"))%></span>
                                                        <br />

                                                        <asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("P_Comment") %>' Width=""></asp:Label>

                                                        </asp:LinkButton>
                                                              </div>
                                                <div style="clear:both"></div>
                                                
                                                    </div>



                                                </ItemTemplate>
                                            </asp:Repeater>

                                            <asp:TextBox ID="cmtPost" runat="server" CssClass="textareacomments" placeholder="Write Comments"></asp:TextBox>



                                            <%-- <div class="col-sm-12" title="Coments"><asp:Button ID="Button3" runat="server" Text="Add Comment"  OnClick="btnReplyClicked2"  CommandName="lokinPost" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="commentsbtn" Visible="" OnClientClick="SavePersonRecord(); return false"/>/></div>--%>
                                            <div class="col-sm-12" title="Coments">
                                                <button  accesskey='<%# Eval("P_Id")%>' class="abc" style="    background: #333366 none repeat scroll 0 0; border: 0 none; color: #fff; float: right; font-size: 13px; margin-top: -26px; padding: 2px 4px; position: absolute; right: 0; width: 90px;" >Add Comment</button>
                                                <%--  <asp:Button ID="btnSubmit" Text="Submit" runat="server" />--%>
                                                <asp:Button ID="Button3" runat="server" Text="Add Comment" CommandName="lokinPost" AutoPostBack="True" data-TourID='<%#Eval("P_Id")%>' CommandArgument='<%#Eval("P_Id")%>' CssClass="commentsbtn" Visible="false" OnClientClick="SavePersonRecord(); return false" /></div>


                                        </div>

                                        <div style="clear: both"></div>


                                    </div>



                                </ItemTemplate>

                            </asp:Repeater>
                            <!--post-box1 end-->

                            <div style="clear: both"></div>

                            <!--post-box1 start-->


                            <!--post-box1 end-->
                            <!--post-box1 start-->


                            <!--post-box1 end-->
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>  
                <asp:Label ID="lbllokUser" runat="server" Text="" Visible=""></asp:Label>
                <div style="clear: both"></div>
                <div class="heightscroll"></div>
            </div>

        </div>
    </div>

    <!--mobile-left-start-->
    <div class="mobileversion">
        <uc1:leftevent ID="leftevent2" runat="server" Visible="false" />
        <uc1:left ID="left2" runat="server" Visible="true" />
    </div>
    <!--mobile-left-end-->


    <!--add photo image upload-start-->
    <!-- Modal -->
    <div class="modal fade" id="addphotovideo2" role="dialog">
        <div class="modal-dialog modal_login">

            <!-- Modal content-->
            <div class="modal-content modelcontentpop">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Add Video/Photo</h4>
                </div>
                <div class="modal-body">

                    <textarea style="width: 100%; min-height: 65px; border: 0px" placeholder="Typing message...." id="Textarea1" runat="server"></textarea>
                    <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" Style="/*width: 54%; */ font-size: 12px; border: 0px solid #d0d0d0; margin-bottom: 10px" />
                    <%--<asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
                                  <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />--%>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default savebtn">Save</button>
                    <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>
    <!--add photo image upload-start-->


    <!-- coments popup -->
    <div class="modal fade" id="commentsbox" role="dialog">
        <div class="modal-dialog modal_login">

            <!-- Modal content-->
            <div class="modal-content modelcontentpop">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>

                </div>
                <div class="modal-body">

                    <textarea style="width: 100%; min-height: 65px; border: 0px" placeholder="Typing message...."></textarea>


                </div>
                <div class="modal-footer">
                    <asp:FileUpload ID="FileUpload2" runat="server" AllowMultiple="true" Style="/*width: 54%; */ font-size: 12px; border: 0px solid #d0d0d0; margin-bottom: 10px" />
                    <button type="button" class="btn btn-default savebtn">Sent</button>
                    <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>
    <!--coments popup-->

    <!-- messageboxpop start-->
    <div class="modal" id="messageboxpop" role="dialog">
    </div>
    <!--messageboxpop end-->


    <!-- edit popup start -->
    <div class="modal fade" id="editbox" role="dialog">
        <div class="modal-dialog modal_login">

            <!-- Modal content-->
            <div class="modal-content modelcontentpop">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>

                </div>
                <div class="modal-body">
           

                </div>

            </div>

        </div>
    </div>
    <!--Edit popup-->



    
    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
    <asp:HiddenField ID="hidArticleId" runat="server" />
    <asp:Label ID="Lblsname" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="Label7" runat="server" Text="" Visible="false"></asp:Label>
     <asp:Label ID="Label8" runat="server" Text="" Visible="false"></asp:Label>


          
    <script type="text/javascript">
        var myvalue;
    
        $(document).ready(function () {
            $('[id*=cmtPost]').on('change', function () {
                var id = $(this).attr('id');
                
                var value = $('#' + id).val();
                myvalue = value;
              
            });
        });
    </script>

        

   


    <link href="css/jquery-ui.css" rel="stylesheet" />
    <script type="text/javascript">
        $(function () {
            $("[id$=my_control]").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "Service.asmx/GetAutoCompleteData",
                        data: "{ 'getPrefixData': '" + request.term + "'}",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    label: item
                                }
                            }))
                        },
                        error: function (response) {
                            //alert(response.responseText);
                        },
                        failure: function (response) {
                            //alert(response.responseText);
                        }
                    });
                },
                minLength: 1
            });
        });
    </script>

    <script type="text/javascript">
        function ToggleShowHide() {
            var control = document.getElementById("<%= my_control.ClientID %>");
                 if (control.style.display == "none") { control.style.display = "block"; }
                 else { control.style.display = "none"; }
                 return false;
             }
    </script>

<%--    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>--%>
    <script src="js/jqueryajax.min.js"></script>

    <%--    //$(document).ready(function () {  lok
        //    $('[id*=Repeater1_lblSubject]').on('change', function () {
        //        var id = $(this).attr('id');
        //        var value = $('#' + id).val();
        //        alert(id + '_' + value);
        //    });
        //});--%>
    <script type="text/javascript">
        function ToggleShowHide1() {
            var thisLabel = $('.my_control2').eq(0);
            alert(thisLabel);
            var control = document.getElementById(thisLabel);
            if (control.style.display == "none") { control.style.display = "block"; }
            else { control.style.display = "none"; }
            return false;
        }


    </script>

    <script language="JavaScript" type="text/javascript">
        function ToggleDisplay(id) {
            var elem = document.getElementById('d' + id);
            if (elem) {
                if (elem.style.display != 'block') {
                    elem.style.display = 'block';
                    elem.style.visibility = 'visible';
                }
                else {
                    elem.style.display = 'none';
                    elem.style.visibility = 'hidden';
                }
            }
        }
    </script>

    <script type="text/javascript">
        $(function () {
            //$(document).on("click", ".abc", function () {
            $("[id*=btnSubmit]").click(function () {
               <%-- <asp:Label ID="lblpostid"  CssClass="IdLabel" AccessKey='<%# Bind("P_Id") %>' runat="server" Text='<%# Bind("P_Id") %>' Width=" " Visible=""></asp:Label> --%>
               // var id = $('.IdLabel').attr('accesskey');
                var name = myvalue;//id;
                alert(name);
                var myvalue1 =12, //myvalue;//$.trim($("[id*=txtAge]").val());
                alert(myvalue1);
                $.ajax({
                    type: "POST",
                    url: "ServiceCS.asmx/GetDetails",
                    data: "{ name: '" + name + "', myvalue1: " + myvalue1 + "}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (r) {
                        alert(r.d);
                       
                    },
                    error: function (r) {
                        alert(r.responseText);
                    },
                    failure: function (r) {
                        alert(r.responseText);
                    }
                });
                return false;
            });
        });
</script>

     <script type="text/javascript">
         //cmtPost rptPost
         var buttonid;
         var divCount;
         $(document).on("click", ".abc", function () {
             var id = $(this).attr('accesskey');
             buttonid = $(this).parent().parent().attr('id');
             //var conveniancecount = $("div[class*='col-sm-12']").length;
             //divCount = $("#"+buttonid+" .col-sm-12").length;
             
             //alert(buttonid);
             var name1 = $.trim($('#<%=lbllokUser.ClientID %>').text());
           
            var myvalue1 = myvalue;

          

            var Messege = "";

            //$('[id*=cmtPost]')


          //  alert("Before Start");
            $.ajax({
                type: "POST",
                url: "ServiceCS.asmx/GetDetails",
                //data: "{ name: '" + myvalue1 + "', myvalue1: " + id + "}",
                data: "{ name: '" + myvalue1 + "', myvalue1: " + id + ", name1: " + name1 + "}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    //$("#"+buttonid).find('div.col-sm-12:not(:last)').hide();
                    CommentShow(id);
                    $('[id*=cmtPost]').each(function () {
                        $(this).val('');
                    })
                    //$('[id*=cmtPost]').parent().add(myvalue1)
                   // alert("Success1")
                },
                error: function (r) {
                    //var conveniancecount = $("div[class*='col-sm-12']").length;
                    alert(r.responseText);
                    // alert("wrong 1");
                },
                failure: function (r) {
                    //  alert(r.responseText);
                   // alert("wrong 3");
                }
            });
            return false;
         });

         function CommentShow(id)
         {
             //alert(id);
             $.ajax({
                 type: "POST",
                 url: "ServiceCS.asmx/CommentRefresh",
                 data: "{ id: " + id + "}",
                 //data: "{ name: '" + myvalue1 + "', myvalue1: " + id + ", name1: " + name1 + "}",
                 contentType: "application/json; charset=utf-8",
                 dataType: "json",
                 //success: OnSuccess,
                 success: function (r) {
                     var v = r.d;
                     //alert(buttonid);
                     //alert(divCount - 1);

                     //alert(v.length);
                     //$('#'+buttonid).append('<div class="col-sm-12">'+ +'</div>')
                     //$('#'+buttonid).closest('.cmtdetails').hide();
                     
                     $(v).each(function () {
                         //alert(this.Picture + "" + this.Date + "" + this.Commenter);
                         $('#'+buttonid).prepend('<div class="" style="margin-top:8px; margin-bottom:8px; font-size:12px""> <a href="#">'+
                             ' <div style="float:left; margin-right:10px"> <img class="imgprofilenotificoment" src="'+this.Picture+'" style="border-width:0px;"></a></div>'+
                             '<div style="float:left;"><a href="#"><span id="#">'+this.Commenter+'</span></a><br>'+
                             '<span style="font-size: 11px">'+this.Date+'</span><br>'
                             + this.Comment +'</div><div style="clear:both"></div></div>');
                         return false;
                         //var dateFormat = $.datepicker.formatDate('dd MMM yyyy', new Date(this.Date));
                         //alert(dateFormat);
                     });

                   
                    
                     //alert(r[0].Id +''+ r[0].Comment +''+ r[0].Date);
                 },
                 error: function (r) {
                     alert(r.responseText);
                     // alert("wrong 1");
                 },
                 failure: function (r) {
                     //  alert(r.responseText);
                     // alert("wrong 3");
                 }
             });
             return false;
       
         }

</script>
</asp:Content>



