<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Edit_Content.aspx.cs" ValidateRequest="false" Inherits="Edit_Content" %>
            <%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

         
    <%--    <script src="admin/js/tinymce/tinymce.min.js"></script>--%>
<%--       <link href="admin/tinymce/skins/lightgray/skin2.min.css" rel="stylesheet" />

<script type="text/javascript" src="/js/tinymce/tinymce.min.js"></script>--%>
 

  <%--  
    <script type="text/javascript">
        tinymce.init({

            selector: "textarea",
            height:60,
            plugins: [
                "advlist autolink lists link image charmap print preview anchor",
                "searchreplace visualblocks fullscreen",
                "insertdatetime media table contextmenu paste"
            ],
            toolbar: "false",
            menubar: "false"
        });
    </script>--%>



   <style type="text/css">
       .mce-toolbar-grp {
            display:none!important;
        }
        /*.mce-panel {
  background-color: #f0f0f0;
  border: 0 solid rgba(0, 0, 0, 0.2);
    display: none;
}*/
 .mce-flow-layout {
  display: none!important;
  white-space: normal;
}

          .ui-widget-content {
    border: 1px solid #aaaaaa;
    background: #ffffff url(images/ui-bg_flat_75_ffffff_40x100.png) 50% 50% repeat-x;
    color: #222222;
    font-size: 13px!important;
    font-family: serif;
    height: 350px!important;
    overflow-x: hidden;
     overflow-y: auto;
}
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
    overflow:inherit!important;
    text-align: center;
    vertical-align: middle;
    font-family: Arial;
     border: 0px solid #124d77!important; 
     background: None!important; 
    color: #fff;
    /* border-radius: 6px; */
    -moz-border-radius: 0px;
    cursor: pointer;
    /* text-shadow: #000 1px 1px 2px; */
    /* -webkit-border-radius: 6px; */
    padding-top: 0px!important;
    padding-bottom: 0px;
    padding: 0px!importantx;
    padding: 0px!important;
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
    width: 42px!important;
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <div class="col-sm-5">
        <!--event-detail page start-->
       		<div class="boxsocialwrap">
		           <div class="scrollboxhide"></div>
                           <div class="search">
                    <div class="row">
		                <div class="col-sm-1 col-xs-2">
		                    <a href="default.aspx">  <img src="img/interboll.png" class="oiiogo"></a>
		                </div>
		                <div class="col-sm-11 col-xs-10">
		              
                               <uc1:leftevent ID="leftevent1" runat="server"/>


		                </div>
		                  <div style="clear:both"></div>
                    </div>
	              </div>
					       
					<div class="boxpro" style="min-height:604px">  
						   <div style="margin-top:10px" class="row">
						     
							  
							   <div class="col-sm-12">
							     <div style="padding: 4px 6px 0px 7px;
    background-color: #d0d0d0;
    margin-top: -9px;
    width:98%;
    height: 115px; margin-bottom:10px"> <textarea style="width:100%; min-height:65px; border:0px" placeholder="What's in your imagination?" id="post" runat="server"  ></textarea>
                                     </div>
                                    <div>


                                        <asp:Image ID="Image1" runat="server" Visible="false"  Height="100px"  Width="125px" />

                                            <div id="divdav" runat="server">
                <video  width="100%" height="250px" controls >
           
                      <source src="src="<%=lblimage.Text%>" type="video/mp4" />
              </video>             </div>


                                         </div>
                                   
							  </div>
							  
						   </div>
						   
                          <!--check in-box start-->
                          <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
						    <div class="checkbox" id="my_control2" style="display:none" runat="server">
                                <div class="leftmap">
                                    <i class="glyphicon glyphicon-map-marker"></i>
                                </div>
                              <div class="inputmapse">  <asp:TextBox ID="my_control"  runat="server" Visible="true" style="width:100%; padding-left:5px; height:24px" placeholder="Location Search..."></asp:TextBox>
                               <%-- <asp:TextBox ID="my_control" runat="server" Visible="true"></asp:TextBox>--%>
                                  </div>
                              <div style="clear:both"></div>
						    </div>
                         <!--check box-->


						     <div class="photouploadstatus">
						        <div class="topupload" style="width:98%">
						
							
								 	<div style="text-align:right">
								                 <div class="leftimag2">
                                        <%--   <button class="btn-primary postbtn" title="Camera"></button>--%>

                                         <label class="file-upload">
    <span><strong><i class="glyphicon glyphicon-camera" title="Camera/Video"></i>  </strong></span>
    <asp:FileUpload ID="file_upload" runat="server" onchange="previewFile()" >
    </asp:FileUpload>
</label>

                                     </div>
                                           <!--check in-->
                                     <div class="leftimag" style=" margin-top:3px" title="Pop in">
                                     <%--    <i class="glyphicon glyphicon-map-marker" style="color:#ffffff"></i>--%>
                                          <asp:LinkButton ID="lb_link_button" runat="server" OnClientClick="return ToggleShowHide()" class="glyphicon glyphicon-map-marker" Style="color:#ffffff"/>
                                      </div>
                                    <!--check end-->

                                           <div class="leftimag2">
                               <button type="submit" runat="server" id="btnLogin" class="btn-primary postbtn" onServerClick="btnLogin_Click">
				                    	Post
					 </button>
                                   </div>
                                  <div class="leftimag2">
                                       <asp:DropDownList ID="ddlPostType" runat="server"  class="postbtn" style="width:95px; background-color:#333366; color:#ffffff">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                             </div>
                                      <div class="leftimag2">
                                       <asp:DropDownList ID="ddlFstatus" runat="server"  class="postbtn" style="width:95px; background-color:#333366; color:#ffffff">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                   </div>
                                          
                                       

									</div>
									<div style="clear:both"></div>
								</div>
						   </div>
                        <div style="clear:both"></div>
                       </div>

					  </div>
					  
               

				<div style="clear:both"></div>
				<div class="heightscroll"></div>
			</div>
            <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
     <asp:Label ID="lblimage" runat="server" Text="" Visible="false"></asp:Label>
     <asp:Label ID="lbltagid" runat="server" Text="" Visible="false"></asp:Label>
      <asp:HiddenField ID="hidArticleId" runat="server" />
      <asp:Label ID="lblvideo" runat="server" Text="" Visible=""></asp:Label>

<%--<link href="css/jquery-ui.css" rel="stylesheet" />--%>
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
            var control = document.getElementById("<%= my_control2.ClientID %>");
                 if (control.style.display == "none") { control.style.display = "block"; }
                 else { control.style.display = "none"; }
                 return false;
             }
</script>
</asp:Content>

