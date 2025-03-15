<%@ Page Title="" Language="C#" MasterPageFile="~/Sitefrnd.master" AutoEventWireup="true" CodeFile="frndpage.aspx.cs" Inherits="frndpage" %>

<%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<%@ Register Src="Usercontrol/leftside.ascx" TagName="left" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">

    <%--  <script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>--%>

    <style type="text/css">
        .comentbtn {
            cursor: pointer;
        }

        .cmtdetails {
            display: none;
            visibility: hidden;
        }
    </style>

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

                <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>

                        <div class="scrollbox">
                            <!--post-box1 start-->
                            <asp:Label ID="lblContry" runat="server" Text="lok" Visible="false"></asp:Label>

                            <asp:Repeater ID="rptPost" runat="server" OnItemDataBound="RepeaterItemCreated" OnItemCommand="itemRepeater_ItemCreated">
                                <ItemTemplate>



                                    <div class="boxpro">
                                        <div class="row">

                                            <div class="col-sm-9 col-xs-8">
                                                <%--   <a href="#"> <img border="0" align="left" class="imgprofilenotifi2" src="img/img3.png"></a>--%>

                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("A_User_Id").ToString()) %>">
                                                    <asp:Image ID="Image2" runat="server" CssClass="imgprofilenotifidefault2" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' /></a>
                                                <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("A_User_Id").ToString()) %>">
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label>
                                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("F_Image") %>' Width=" "></asp:Label>
                                                </a>,
                                   <br>
                                                <span style="font-size: 12px"><%# string.Format("{0:dddd, MMMM d, yyyy}", Eval("P_Date"))%></span> at <span style="font-size: 11px"><%# Eval("StartTime")%></span>
                                                <br />

                                                <div class="locationname" id="divchek" runat="server"><i class="glyphicon glyphicon-map-marker"></i><span>
                                                    <asp:Label ID="lblcheking" runat="server" Text='<%# Bind("checking") %>' Width=" " Visible=""></asp:Label>
                                                </span></div>

                                                <asp:Label ID="lblpostid" runat="server" Text='<%# Bind("P_Id") %>' Width=" " Visible="false"></asp:Label>
                                                <asp:Label ID="lblP_Image" runat="server" Text='<%# Bind("P_Image") %>' Width=" " Visible="false"></asp:Label>
                                                <asp:Label ID="lblUserid" runat="server" Text='<%# Bind("A_User_Id") %>' Width=" " Visible="false"></asp:Label>
                                                         <asp:Label ID="lblEVideo" runat="server" Text='<%# Bind("E_Video") %>' Width=" " Visible="false"></asp:Label>

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
                                                                        <div class="col-sm-1 col-xs-2">

                                                                            <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriendicon2" />
                                                                            </a>
                                                                        </div>
                                                                        <div class="col-sm-10 col-xs-9">
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
                                                                        <div class="col-sm-1 col-xs-2">

                                                                            <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                                <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriendicon2" />
                                                                            </a>
                                                                        </div>
                                                                        <div class="col-sm-10 col-xs-9">
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
                                                    <a data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true" style="cursor: pointer">
                                                        <i class="fa fa-tag" aria-hidden="true" title="Tag People"></i>
                                                    </a>
                                                    <ul class="dropdown-menu tagpeoplenum">
                                                        <asp:Repeater ID="rpttagpeople" runat="server" Visible="false">
                                                            <ItemTemplate>
                                                                <li>
                                                                    <div class="col-sm-1 col-xs-2">
                                                                        <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                            <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprofriendicon2" />
                                                                        </a>
                                                                    </div>
                                                                    <div class="col-sm-10 col-xs-9">
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
                                                                                                                       <div id="embebded_Video" runat="server" style="text-align:center">
                                                                   <object width="100%" height="385"><param name="movie" value='<%#DataBinder.Eval(Container.DataItem, "E_Video") %>'></param>
    <param name="allowFullScreen" value="true"></param>
    <param name="allowscriptaccess" value="always"></param>
    <embed src='<%#DataBinder.Eval(Container.DataItem, "E_Video") %>' type="application/x-shockwave-flash" allowscriptaccess="always" allowfullscreen="true" width="480" height="385">
    </embed>         </object> </div>

                                            <div class="dolessmore" style="margin-top: 8px">
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
                                                                <asp:Button ID="btnReply" runat="server" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn likeclass" />
                                                            </div>

                                                            <div class="leftimag2">

                                                                <div id='h<%# Eval("P_Id") %>' class="commentsleft" onclick='ToggleDisplay(<%# Eval("P_Id") %>);' style="color: #fff; cursor: pointer">
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
                                                                <%--   <asp:Button ID="Button4" runat="server" Text="Share" OnClick="btnShareClicked" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn"/>--%>
                                                                <asp:Button ID="Button4" runat="server" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn shareclass" />
                                                            </div>
                                                            <div class="leftimag2">
                                                                <button class="postbtn2" title="Save">Save </button>
                                                            </div>
                                                            <div class="leftimag2">
                                                                <button class="postbtn2" title="Hide">Hide</button></div>
                                                            <div class="leftimag2">
                                                                <div id="divEdited" runat="server">
                                                                    <a href="<%# "Edit_Content.aspx?ID=" +StringCipher.Encrypt(Eval("P_Id").ToString()) %>">
                                                                        <asp:Label ID="Button1" runat="server" Text="Edit" CssClass="postbtn"></asp:Label>
                                                                    </a>
                                                                </div>
                                                            </div>
                                                            <div class="leftimag2">
                                                                <asp:Button ID="deleteButton" runat="server" Text="Delete" Visible="false" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn" OnClientClick="return confirm('Are you sure you want to delete this Information?');" /></div>


                                                            <%--  <asp:Button runat="server" ID="Button1" OnCommand="Button1_Command" Text="Like" />--%>
                                                        </div>


                                                        <div style="clear: both"></div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                        <!--comments start-->
                                        <div id='d<%# Eval("p_Id") %>' class="cmtdetails" style="margin-top: 8px">
                                            <asp:TextBox ID="cmtPost" runat="server" CssClass="textareacomments" placeholder="Write Comments"></asp:TextBox>



                                            <%-- <div class="col-sm-12" title="Coments"><asp:Button ID="Button3" runat="server" Text="Add Comment"  OnClick="btnReplyClicked2"  CommandName="lokinPost" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="commentsbtn" Visible="" OnClientClick="SavePersonRecord(); return false"/>/></div>--%>
                                            <div class="col-sm-12" title="Coments">
                                                <button accesskey='<%# Eval("P_Id")%>' class="abc" style="background: #333366 none repeat scroll 0 0; border: 0 none; color: #fff; float: right; font-size: 12px; margin-top: -26px; padding: 2px 4px; position: absolute; right: 0; width: 100px;">Add Comment</button>
                                                <%--  <asp:Button ID="btnSubmit" Text="Submit" runat="server" />--%>
                                                <asp:Button ID="Button3" runat="server" Text="Add Comment" CommandName="lokinPost" AutoPostBack="True" data-TourID='<%#Eval("P_Id")%>' CommandArgument='<%#Eval("P_Id")%>' CssClass="commentsbtn" Visible="false" OnClientClick="SavePersonRecord(); return false" />
                                            </div>

                                            <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                                                <ContentTemplate>

                                                    <asp:Repeater ID="dlcomment" runat="server" OnItemDataBound="dlcomment_ItemDataBound">
                                                        <ItemTemplate>

                                                            <div class="" class="cmtdetails" style="margin-top: 8px; margin-bottom: 8px; font-size: 12px">
                                                                <div style="float: left; margin-right: 10px">
                                                                    <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                        <asp:Image ID="Image2" runat="server" CssClass="imgprofilenotifi2" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' /></a>
                                                                </div>
                                                                <div style="float: left">
                                                                    <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>">
                                                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label></a>
                                                                    <br>
                                                                    <span style="font-size: 11px"><%# string.Format("{0:dd MMM yyyy}", Eval("P_Date"))%></span>
                                                                    <br />

                                                                    <asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("P_Comment") %>' Width=""></asp:Label>
                                                                    <asp:Label ID="lblpcomtid_Pid" runat="server" Text='<%# Bind("P_Id") %>' Width="" Visible="false"></asp:Label>
                                                                    <asp:Label ID="lblpcomtid" runat="server" Text='<%# Bind("P_Id") %>' Width="" Visible="false"></asp:Label>


                                                                    <div class="leftimag2" style="float: right">
                                                                        <asp:Button ID="deleteButtoncomment" runat="server" Text="Delete" OnClick="btnCommentDelete" Visible="false" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="glyphicon glyphicon-hand-right" OnClientClick="return confirm('Are you sure you want to delete this Information?');" Style="background-color: #ffffff!important; color: #000; border: 0px" />
                                                                        <div id="deleteButtoncomment12" runat="server">
                                                                            <button id="deleteButtoncomment2" style="background-color: #ffffff!important; color: #000; border: 0px!important" onserverclick="btnCommentDelete" autopostback="True" commandargument='<%#Eval("P_Id")%>'><i class="glyphicon glyphicon-trash"></i></button>
                                                                        </div>
                                                                    </div>

                                                                </div>
                                                                <div style="clear: both"></div>

                                                            </div>



                                                        </ItemTemplate>
                                                    </asp:Repeater>

                                                </ContentTemplate>
                                            </asp:UpdatePanel>


                                        </div>

                                        <div style="clear: both"></div>


                                    </div>



                                </ItemTemplate>

                            </asp:Repeater>
                            <!--post-box1 end-->
                            <asp:Label ID="lbllokUser" runat="server" Text="" Visible=""></asp:Label>

                            <div style="clear: both"></div>

                            <!--post-box1 start-->


                            <!--post-box1 end-->
                            <!--post-box1 start-->


                            <!--post-box1 end-->
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
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
                    Sumon paul

                </div>

            </div>

        </div>
    </div>
    <!--Edit popup-->



    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
    <asp:HiddenField ID="hidArticleId" runat="server" />
    <asp:Label ID="Lblsname" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lblCity" runat="server" Text="" Visible=""></asp:Label>
    <asp:Label ID="lblTimezone" runat="server" Text="" Visible=""></asp:Label>
    <asp:Label ID="lblIp" runat="server" Text="" Visible=""></asp:Label>


    <script src="js/jqueryajax.min.js"></script>
<%--    <link href="css/jquery-ui.css" rel="stylesheet" />--%>


    <script type="text/javascript">
        var myvalue;

        $(document).ready(function () {
            //   alert('');
            $('[id*=cmtPost]').on('change', function () {
                var id = $(this).attr('id');
                //  alert(id);
                var value = $('#' + id).val();
                myvalue = value;
                //    alert(myvalue);

                //  alert("Shaka")
            });
        });

    </script>

    <script type="text/javascript">
        function ToggleShowHide1() {
            var thisLabel = $('.my_control2').eq(0);
            // alert(thisLabel);
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

        function PostData(myvalue1, id, name1) {
            if (myvalue1 != null && myvalue1 != "") {
                $.ajax({
                    type: "POST",
                    url: "ServiceCS.asmx/GetDetails",
                    //data: "{ name: '" + myvalue1 + "', myvalue1: " + id + "}",
                    data: "{ name: '" + myvalue1 + "', myvalue1: " + id + ", name1: " + name1 + "}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (r) {
                        //$("#"+buttonid).find('div.col-sm-12:not(:last)').hide();
                        var cc = $("#h" + id).next().children().text();
                        $("#h" + id).next().children().text(parseInt(cc, 10) + 1);
                        CommentShow(id);
                        $('[id*=cmtPost]').each(function () {
                            $(this).val('');
                        })
                        //$('[id*=cmtPost]').parent().add(myvalue1)
                        // alert("Success1")
                    },
                    error: function (r) {
                        //var conveniancecount = $("div[class*='col-sm-12']").length;
                        //   alert(r.responseText);
                        // alert("wrong 1");
                    },
                    failure: function (r) {
                        //  alert(r.responseText);
                        // alert("wrong 3");
                    }
                });
            }
        }

        $(document).ready(function () {
            $("input.textareacomments").keydown(function (event) {
                if (event.keyCode == 13) {
                    // do something here
                    event.preventDefault();
                    //PostData();
                    buttonid = $(this).parent().attr('id');

                    var name1 = $.trim($('#<%=lbllokUser.ClientID %>').text());

                     var myvalue1 = $(this).val();

                     id = $(this).next().children().attr('accesskey');
                     //alert(id + " " + myvalue1 + " " + name1);
                     PostData(myvalue1, id, name1);
                     return false;
                 }
             });
         });
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
             PostData(myvalue1, id, name1);
             return false;
         });

         $(document).on("click", "button", function () {
             var id = $(this).attr('commandargument');
             var thisId = $(this).parent().parent().parent().parent();
             //alert($(this).parents().eq(5).prev().children('.commentscount').html);
             //var cnumber = $(this).parent().parent().parent().parent().parent().parent().prev().children().children().children().children().children().next().children().children().text();
             //alert($(this).parent().parent().parent().parent().parent().parent().prev().children().children().children().children().children().next().children().children().text());
             var thisis = $(this).parents().eq(5).prev().children().children().children().children().children().next().children().children().attr('id');
             // var cnumber = $(this).parents().eq(5).prev() + (":nth-child(4)").next() + (":nth-child(1)").text();
             //var cnumber = $(this).parents().eq(5).prev().children().eq(5).next().children().eq(2).text().abc();
             //alert(cnumber);
             var name1 = $.trim($('#<%=lbllokUser.ClientID %>').text());
             $.ajax({
                 type: "POST",
                 url: "ServiceCS.asmx/DeleteComment",
                 //data: "{ name: '" + myvalue1 + "', myvalue1: " + id + "}",
                 data: "{ PostId: " + id + ", userid:'" + name1 + "'}",
                 //data: { PostId: id },
                 contentType: "application/json; charset=utf-8",
                 dataType: "json",
                 success: function (r) {
                     //var cc = $(thisis).children().children().children().children().children().next().children().children().text();
                     //cc = parseInt(cc) - 1;
                     // alert(thisis);

                     //var cc = $(cnumber).text();
                     // $(thisis).children().children().children().children().children().next().children().children().text(parseInt(cc) +1);
                     //result = r.d;
                     var cc = $("#" + thisis).text();
                     $("#" + thisis).text(parseInt(cc, 10) - 1);
                     //$(thisId).parent().parent().parent().parent().remove();
                     $(thisId).remove();

                 },
                 error: function (r) {
                     //var conveniancecount = $("div[class*='col-sm-12']").length;

                     //    alert(r.responseText);
                     // alert("wrong 1");
                 },
                 failure: function (r) {
                     //  alert(r.responseText);
                     // alert("wrong 3");
                 }
             });

             return false;
         });


         function CommentShow(id) {
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
                         $('#' + buttonid + " div:eq(0)").after('<div class="" style="margin-top:8px; margin-bottom:8px; font-size:12px""> <a href="#">' +
                             ' <div style="float:left; margin-right:10px"> <img class="imgprofilenotificoment" src="' + this.Picture + '" style="border-width:0px;"></a></div>' +
                             '<div style="float:left;"><a href="#"><span id="#">' + this.Commenter + '</span></a><br>' +
                             '<span style="font-size: 11px">' + this.Date + '</span><br>'
                             + this.Comment + '</div><div style="clear:both"></div></div>');
                         return false;
                         //var dateFormat = $.datepicker.formatDate('dd MMM yyyy', new Date(this.Date));
                         //alert(dateFormat);
                     });



                     //alert(r[0].Id +''+ r[0].Comment +''+ r[0].Date);
                 },
                 error: function (r) {
                     //  alert(r.responseText);
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


    <%--like work--%>
    <%--<asp:Button ID="btnReply" runat="server" Text="Like" OnClientClick="SavePersonRecord(); return false" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn"/>--%>

    <script type="text/javascript">



        $(document).on("click", ".likeclass", function () {
            var id = $(this).parents().eq(5).next().attr('id');
            var thisid = $(this).attr('id');
            //var pIds = id.split("d");
            //alert(pIds[1]);
            var pid = id.substr(1, id.length - 1);
            //alert(one);
            //var name = $(this).attr('name');
            //alert(name);
            //var value = $('#' + id).val();
            //alert(value);
            var name1 = $.trim($('#<%=lbllokUser.ClientID %>').text());
        $.ajax({
            type: "POST",
            url: "ServiceCS.asmx/Like",
            data: "{ PostId: " + pid + ", userid:'" + name1 + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                //  alert(r.d);
                $('#' + thisid).val(r.d);
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
    </script>


    <script type="text/javascript">



        $(document).on("click", ".shareclass", function () {
            var id = $(this).parents().eq(5).next().attr('id');
            var thisid = $(this).attr('id');
            //var pIds = id.split("d");
            //alert(pIds[1]);
            var pid = id.substr(1, id.length - 1);
            //alert(one);
            //var name = $(this).attr('name');
            //alert(name);
            //var value = $('#' + id).val();
            //alert(value);
            var name1 = $.trim($('#<%=lbllokUser.ClientID %>').text());
            $.ajax({
                type: "POST",
                url: "ServiceCS.asmx/share",
                data: "{ PostId: " + pid + ", userid:'" + name1 + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    //  alert(r.d);
                    $('#' + thisid).val(r.d);
                },
                error: function (r) {
                    //var conveniancecount = $("div[class*='col-sm-12']").length;

                    // alert(r.responseText);
                    // alert("wrong 1");
                },
                failure: function (r) {
                    //  alert(r.responseText);
                    // alert("wrong 3");
                }
            });

            return false;
        });
    </script>



</asp:Content>



