<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Notes.aspx.cs" Inherits="Notes" %>
            <%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
              <style>
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
    width:200px!important;
    margin-top:1px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
       
 <div class="col-sm-5">
		<div class="boxsocialwrap">
		<div class="scrollboxhide"></div>
 	     <div class="search">
            <div class="row">
		        <div class="col-sm-1 col-xs-2">
		            <a href="default.aspx">  <img src="img/interboll.png" class="oiiogo"></a>
		        </div>
		        <div class="col-sm-11 col-xs-10">
                       <uc1:leftevent ID="leftevent1" runat="server"/>
		         <%-- <div class="search2">
                                <div method="post" action="">
                                    <input type="text" class="input_search" id="txtSearch" name="key" placeholder="Search Interboll" autocomplete="off" role="textbox" aria-autocomplete="list" aria-haspopup="true"  runat="server">
                            
                                    <div id="btnSearch" class="btn_search">
                                        <div class="searchbtn2">
                                            <img class="searchimg" src="img/search_btn.png">
                                        </div>
                                    </div>
                                </div>
                                <div style="clear:both"></div>
                    </div>--%>
		        </div>
		<div style="clear:both"></div>
            </div>
	 </div>
             <div class="boxsocial2">
		            <div class="boxproe">
				       <div class="aboutwrap">
                           <div class="col-sm-12">
                               <div class=""style="float:left; color:#ffffff; margin-top:3px" ><span class="glyphicon glyphicon-book"></span> Note</div>
				                 <div class="" style="float:right">
								        <ul class="nav nav-tabs tabcssfollowers">
                                              <li class="menumfollow"><a data-target="#addnote" data-toggle="modal" href="#">+ Add Note</a>
					                         </li>
                                           
					                  </ul>
								</div>
                             
							<div style="clear:both"></div>
                           </div>
                           	<div style="clear:both"></div>
		                </div>
                     </div>
							
      
                                       <div class="boxproe2">
                                  <%--            <div class="col-sm-12">
									                 <div class=""> Title:</div>
                                                     <div class=""> Details:</div>
                                              </div>--%>


                                              
                                    <asp:Repeater ID="dlnotes" runat="server"  Visible="true" >
                                        <ItemTemplate>
                                               <div class="photouploadwrapbb2" style="border-bottom:1px solid #d0d0d0; padding-bottom:10px; margin-bottom:10px">
                                                     <div class="row gutter-10">
                       <div class="col-sm-4"><asp:Image ID="Image2" style="width:100%; height:120px" runat="server" ImageUrl='<%# Bind("P_Image",  "~/{0}") %>'/>  </div>
                         <div class="col-sm-8">  <asp:Label ID="Label2" runat="server" Text='<%# Eval("P_Name") %>' Width=" "></asp:Label> 
                             <p> <asp:Label ID="Label3" runat="server" Text='<%# Eval("P_Description") %>' Width=" "></asp:Label>  </p> <br>
							                 <div style="margin-bottom:10px; margin-top:-15px; text-align:center"> 
                                                  <asp:Button ID="Button2" runat="server" Text="Delete Note" OnClick="btnDeleteClicked1" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn" Style="width:85px; float:left"/></div>
                                           </div>           
							                  
                                                 <div style="clear:both">  </div>  
                                                                                               
							                </div>
                                           
                                            </div>
                                  
										</ItemTemplate>
                            </asp:Repeater>
                                           <div style="clear:both"></div>
                                       </div>
                            




		    	 <div style="clear:both"></div>
						
				  
             </div>
       </div> 
     </div>

    
                                       <!-- Create Events start -->
                                              <div class="modal fade" id="addnote" role="dialog">
                                                <div class="modal-dialog createaddnotepopup">
    
                                                  <!-- Modal content-->
                                                  <div class="modal-content modelcontentpop">
                                                    <div class="modal-header">
                                                        <div class="row">

                                                        <div class="col-sm-12 text-right"> 

                                                               <button type="button" class="close" data-dismiss="modal">&times;</button>

                                                        </div>
                                                   <%--   <h4 class="modal-title">Create Events</h4>--%>
                                                        <div style="clear:both"></div>
                                                     </div>
                                                    </div>


                                                    <div class="modal-body2">
                                                       <div style="background-color:#d0d0d0; padding:28px 10px 10px 10px; text-align:center; min-height:80px;"> 
                                                           <label class="file-upload" style="width:100%; color:#000000">
    <span><strong><i class="fa fa-upload" aria-hidden="true"></i>
 Photo Uoload</strong></span>
    <asp:FileUpload ID="file_upload" runat="server" onchange="previewFile()" >
    </asp:FileUpload>
</label>
                                                           </div>
                                                           
                                                          <div class="" style="padding:15px">
                                                               
                                                                <textarea style="border:1px solid #d0d0d0; width:100%; height:28px; padding:4px; margin-bottom:10px" placeholder="Title..." id="txtTitle" runat="server"></textarea> 
                                                              <div class="">   <img border="0" src="<%=lok2.Text%>" class="imgpro"> <asp:Label ID="lblName" runat="server" Text=""></asp:Label>  <asp:Label ID="lblDate" runat="server" Text=""></asp:Label></div>
                                                               <div class="" style="">
                                                               
                                                                <textarea style="border:1px solid #d0d0d0; width:100%; height:70px; padding:10px; margin-top:10px" placeholder="Write Something...." id="txtdes" runat="server"></textarea> 
                                                             
                                                          </div>

                                                               <div class="modal-footer">
                                                                      <button type="submit" runat="server" id="btnLogin" class="btn btn-default savebtn"  onServerClick="btnLogin_Click">
					                              Post
					                           </button>
                                                               </div>
                                                             <asp:Label ID="lok2" runat="server" Text="" Visible="false"></asp:Label>
                                                     </div>
                                                  </div>
      
                                                </div>
                                              </div>
                                                  </div>
    
                              <!-- Create Events start -->
                                     <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
    
</asp:Content>
                                      
