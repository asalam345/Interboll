﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Post_View_Edit.aspx.cs" Inherits="Post_View_Edit" %>
<%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <div class="col-sm-5">
		<div class="boxsocialwrap">
		<div class="scrollboxhide"></div>
		<div class="search">
            <div class="row">
		<div class="col-sm-1">
		    <a href="default.aspx">  <img border="0" src="img/interboll.png" class="oiiogo"></a>
		</div>
		<div class="col-sm-11">
		<div class="search2" style="display:none">
                        <div method="post" action="">
                            <input type="text" class="input_search" id="txtSearch" name="key" placeholder="Search Interboll" autocomplete="off" role="textbox" aria-autocomplete="list" aria-haspopup="true"  runat="server">
                            
                            <div id="btnSearch" class="btn_search">
                                <div class="searchbtn2">
                                    <img border="0" class="searchimg" src="img/search_btn.png">
                                </div>
                            </div>
                        </div>
                        <div style="clear:both"></div>
            </div>
              <uc1:leftevent ID="leftevent1" runat="server"/>  
		</div>
		<div style="clear:both"></div>
            </div>
	 </div>
                  
		   <div class="boxsocial2">
		   
		   <div class="boxpro" >
					       <div class="photouploadstatus">

                               <div style="clear:both"></div>
						   </div>
						   
						   <div style="margin-top:10px" class="row">
						      <div class="col-sm-1">
							     <img border="0" align="left" src="img/img3.png" class="imgprofilenotifi2">
							  </div>
							  
							   <div class="col-sm-11">
							      <textarea style="width:100%; min-height:65px; border:0px" placeholder="What's in your imagination?" id="post" runat="server"></textarea>
                                    <div>
                                  
                                        
                                        
                                         <asp:FileUpload ID="file_upload" runat="server" AllowMultiple="true" style="/*width:54%;*/ font-size:12px; border: 0px solid #d0d0d0; margin-bottom:10px"/></div>
                                   <%--<asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
                                  <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />--%>
							  </div>
							  
						   </div>
						   
						     <div class="photouploadstatus">
						        <div class="topupload">
								<%--<div class="col-sm-6">
                                      <a href="" class="textdecorationsta2" title="Status"> <i class="glyphicon glyphicon-pencil"></i> </a>
								      <a title="Tag people in Your Post" class="textdecorationsta2" href="#"><i class="glyphicon glyphicon-user"></i>  </a>
									  <a title="Check in" class="textdecorationsta2" href="#"> <i class="glyphicon glyphicon-map-marker"> </i>  </a>
                                       <a title="Life Events" class="textdecorationsta2" href="#"> <i class="glyphicon glyphicon-king"> </i> </a>
                      
                                       <a class="textdecorationsta2" href="#" title="add photo and Video to your post" data-target="#addphotovideo2" data-toggle="modal"><i class="glyphicon glyphicon glyphicon-open"></i> </a>
                                     <a title="Camera" class="textdecorationsta2" href="#"> <i class="glyphicon glyphicon-camera"> </i> </a>
								 </div>--%>
							
								 	<div style="text-align:right" class="col-sm-12">
								<%--	<button class="confirmbtnp">Public <span class="glyphicon glyphicon-triangle-bottom"></span></button>
									<button class="confirmbtnp">Post</button>--%>
                                           <div class="col-sm-3">
                               <button type="submit" runat="server" id="btnLogin" class="btn-primary postbtn" onServerClick="btnLogin_Click">
					Post
					 </button>
                                   </div>
                                  <div class="col-sm-3">
                                       <asp:DropDownList ID="ddlPostType" runat="server"  class="postbtn" style="width:95px; background-color:#333366; color:#ffffff">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                             </div>
                                      <div class="col-sm-3">
                                       <asp:DropDownList ID="ddlFstatus" runat="server"  class="postbtn" style="width:95px; background-color:#333366; color:#ffffff">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                   </div>
                                        
									</div>
									<div style="clear:both"></div>
								</div>
						   </div>
					  </div>
					  
               

				<div style="clear:both"></div>
				<div class="heightscroll"></div>
			</div>

			</div>
	   </div>


       
                        
                                  <!--coments popup-->


           <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
      <asp:HiddenField ID="hidArticleId" runat="server" />
</asp:Content>

