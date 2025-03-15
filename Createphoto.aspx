<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Createphoto.aspx.cs" Inherits="Createphoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interboll</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />

</head>
<body class="borderphotowrap">
    <form id="form1" runat="server">

        <div class="createbackgroundcolor">

            <!--titile start-->
            <div class="titlealbum">
                <div class="col-sm-3">
                    Create Album
                </div>
                <div class="col-sm-4"></div>
                <div class="col-sm-4">
                    <button class="creatphotoalbumbtn">+ Add More Photos</button>
                    <button class="creatphotoalbumbtn">+ Order by Date Taken</button>
                </div>

                <div class="col-sm-1"><a href="Default.aspx"><span style="font-size: 15px; color: #ffffff">X</span></a></div>
                <div style="clear: both"></div>
            </div>
            <!--titile end-->
            <div class="boxcreatewrap">

                <div class="row gutter-10">

                    <div class="col-sm-3" style="padding-right: 0px">
                        <div class="boxcreatalbum">
                            <div style="margin-top: 10px">
                                <input type="text" class="input_textalbum" placeholder="Untitled Album" id="txtTitle" runat="server" />
                            </div>
                            <div style="margin-top: 10px">
                                <input type="text" class="input_textalbum" placeholder="Say Something About this Album" id="txtdesc" runat="server" />
                            </div>
                            <div style="margin-top: 10px">
                                <input type="text" class="input_textalbum" placeholder="Where Were This Taken?" id="txtplace" runat="server" />
                            </div>
                            <div style="clear: both"></div>
                            <div class="Tagalbum">
                                <div class="">
                                    <div class="dropdown">
                                        <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true" style="cursor: pointer">
                                            Tagged In This Album
                                        </div>
                                        <ul class="dropdown-menu postinfotagpeople" style="border-bottom: 0px solid #d0d0d0!important">

                                            <li>
                                                <div class="profileimgnotifi">

                                                    <div class="row">

                                                        <asp:DataList ID="dlfrndlist" runat="server" DataKeyField="IID"
                                                            RepeatColumns="1" OnSelectedIndexChanged="DataListBrand_SelectedIndexChanged1">
                                                            <ItemTemplate>

                                                                <div class="col-sm-1 col-xs-1">
                                                                    <asp:CheckBox ID="chkbox" runat="server" Text="" AutoPostBack="true"
                                                                        OnCheckedChanged="CheckBoxListTest_SelectedIndexChanged" />
                                                                    </checkbox>  
                                                                </div>

                                                                <div class="col-sm-1 col-xs-1">
                                                                    <asp:Image ID="Image3" runat="server" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>' class="imgprotagpeople" />
                                                                    <asp:Label ID="Label3" runat="server" Visible="false" Text='<%# Eval("IID")%>' />
                                                                    <asp:Label ID="Label4" runat="server" Visible="false" Text='<%# Eval("IID")%>' />

                                                                </div>
                                                                <div class="col-sm-9 col-xs-8">
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
                            </div>



                            <div class="Tagalbum">

                                <span style="font-size: 12px">
                                    <%--   <button class="creatpickbumbtn">Use date from photos</button>--%>
                                    <button type="submit" runat="server" id="btnLogin" class="creatpickbumbtn" onserverclick="btnLogin_Click">
                                        Save
                                    </button>
                                    <asp:DropDownList ID="ddlPostType" runat="server" class="postbtn" Style="width: 82px; background-color: #333366; color: #ffffff">
                                        <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                    </asp:DropDownList>
                                </span>
                            </div>


                            <div style="clear: both"></div>
                        </div>
                    </div>

                    <div class="col-sm-9">
                        <div class="boxalbumscrollname">
                            <div class="row gutter-10">
                                <asp:Repeater ID="dlalbum" runat="server" Visible="true">
                                    <ItemTemplate>
                                        <div class="col-sm-3">
                                            <div class="photouploadwrap">
                                                <asp:Image ID="Image2" Style="width: 100%; height: 250px" runat="server" ImageUrl='<%# Bind("Album_Image",  "~/images/Albums/{0}") %>' />
                                                <br />
                                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Album_Name") %>' Width=" "></asp:Label>




                                            </div>

                                            <div class="">
                                                <asp:Button ID="Button4" runat="server" Text="Add Photo" OnClick="btnShareClicked" AutoPostBack="True" CommandArgument='<%#Eval("Album_Id")%>' CssClass="postbtn" />
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <%--  --%>
                            </div>


                            <div style="clear: both"></div>
                            <div style="margin-top: 10px; background-color: #f2f2f2" id="loadpic" runat="server" visible="false">

                                <div class="col-sm-10">
                                    <asp:FileUpload ID="file_upload" runat="server" AllowMultiple="true" Style="/*width: 54%; */ font-size: 12px; border: 0px solid #d0d0d0; margin-bottom: 10px" />
                                    <br />

                                    <p>
                                        <asp:Label ID="lblFileList" runat="server"></asp:Label></p>
                                    <p>
                                        <asp:Label ID="lblUploadStatus" runat="server"></asp:Label></p>
                                    <p>
                                        <asp:Label ID="lblFailedStatus" runat="server"></asp:Label></p>
                                </div>
                                <div class="col-sm-2">
                                    <button type="submit" runat="server" id="Button1" class="btn-primary postbtn" onserverclick="btnImagepost_Click">
                                        Post
                                    </button>

                                </div>
                                <div style="clear: both"></div>

                                <div style="margin-top: 10px">
                                    <div class="col-sm-12 postbtn" style="padding: 3px 3px 3px 10px; margin-bottom: 10px">
                                        Album Name:
                                        <asp:Label ID="lblAlbums" runat="server" Text=""></asp:Label>

                                    </div>
                                    <div class="row gutter-10">
                                        <asp:Repeater ID="dl_Image" runat="server">
                                            <ItemTemplate>

                                                <div class="col-md-3">
                                                    <asp:Image runat="server" ID="img_banner" ImageUrl='<%# Eval("Image_Path",  "~/images/Albums/{0}") %>' alt="Image" Style="height: 180px; width: 100%; margin-bottom: 15px" /></a>
                                             <div style="margin-bottom: 10px; margin-top: -15px; text-align: center">
                                                 <asp:Button ID="Button4" runat="server" Text="Delete Photo" OnClick="btnDeleteClicked" AutoPostBack="True" CommandArgument='<%#Eval("Image_Id")%>' CssClass="postbtn" /></div>
                                                </div>


                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <div style="clear: both"></div>
                                    </div>
                                </div>
                            </div>

                            <div style="clear: both"></div>
                            <div style="height: 20px; width: 100%"></div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <asp:Label ID="Lblsname" runat="server" Text="" Visible="false"></asp:Label>
        <asp:HiddenField ID="hidArticleId" runat="server" />

    </form>

   <%-- <script src="js/vendor/jquery-1.11.3.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/twemoji.min.js"></script>
    <script src="js/plugins.js"></script>
    <script src="js/main.js"></script>--%>

</body>
</html>
