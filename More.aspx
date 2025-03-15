<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="More.aspx.cs" Inherits="More" %>
         <%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
 <asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <div class="col-sm-5">
		<div class="boxsocialwrap">
		<div class="scrollboxhide"></div>
		<div class="search">
		<div class="row">
		<div class="col-sm-1 col-xs-2">
		<a href="Default.aspx"><img border="0" src="img/interboll.png" class="oiiogo"></a>
		</div>
		<div class="col-sm-11 col-xs-10">
		   <uc1:leftevent ID="leftevent1" runat="server"/>
		</div>
		<div style="clear:both"></div>
	 </div>
	 </div>
	 
		  <div class="boxsocial2">
		            <div class="boxpro">
                          <div class="aboutwraptitle"><i class="fa fa-futbol-o" aria-hidden="true"></i>


                               
 <asp:Label ID="lblCategoryName" runat="server" Text="Cat Name"></asp:Label>
</div>
				     
      <!--music step slider start-->
                                  <div class="boxproetabevent2">
                                    <div class="eventstitle">Like <asp:Label ID="lblCatname" runat="server" Text=" Like Cat Name"></asp:Label></div>
                                      <div id="myCarousel" class="carousel slide">
                 
                                      <%--  <ol class="carousel-indicators">
                                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                                            <li data-target="#myCarousel" data-slide-to="1"></li>
                                            <li data-target="#myCarousel" data-slide-to="2"></li>
                                        </ol>--%>
                 
                                <!-- Carousel items -->
                                <div class="carousel-inner">
                    
                                <div class="item active">
                	                   <div class="row gutter-10">
                                             
											<%--      <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md5.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>--%>

                                             <asp:Repeater ID="dlMore" runat="server"  OnItemDataBound="dlMore_ItemDataBound" >
                                        <ItemTemplate>
										<div class="col-sm-3 col-xs-6">
<a> <asp:Image ID="Image2" runat="server"  CssClass="imageeventsbooks" ImageUrl='<%# Bind("Image_Name",  "{0}") %>'/></a>
                                    <asp:Button ID="btnReply" runat="server" Text="Like" OnClick="btnReplyClicked" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn"/>
                                        
                                                            <p class="fonteventtext"><asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("P_Name") %>' Width="" ></asp:Label><br>
                                                                     
                                                           </p>
                                            <asp:Label ID="lblpostid" runat="server" Text='<%# Bind("P_Id") %>' Width=" " Visible="false"></asp:Label>

                                            </div>

										</ItemTemplate>
                            </asp:Repeater>


                                                
													 
                                                
													 
                                                 
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->
                 
                                <div class="item">
                	                <div class="row gutter-10">
                                             
											     <asp:Repeater ID="dlMore1" runat="server"   >
                                        <ItemTemplate>
										<div class="col-sm-3 col-xs-6">
<a> <asp:Image ID="Image2" runat="server"  CssClass="imageeventsbooks" ImageUrl='<%# Bind("Image_Name",  "{0}") %>'/></a>
                                    <asp:Button ID="btnReply" runat="server" Text="Like" OnClick="btnReplyClicked1" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn"/>
                                        
                                                            <p class="fonteventtext"><asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("P_Name") %>' Width="" ></asp:Label><br>
                                                                     
                                                           </p>

                                            </div>

										</ItemTemplate>
                            </asp:Repeater>
                                                 
													 
                                                 
											
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->
                 
                 
                                </div><!--/carousel-inner-->
                 
                                <a class="left carousel-control" href="#myCarousel" data-slide="prev">‹</a>
                                <a class="right carousel-control" href="#myCarousel" data-slide="next">›</a>
                                </div><!--/myCarousel-->
                 
                        </div><!--/well-->   
                  <!--music step slider end-->
                     </div>

						  <div class="boxproemusic">
                           <div class="aboutwraptitle">

				              <div class="text-right">
								        <ul class="nav nav-tabs tabmusicwrap">
                                              <li class="menumfollow active"><a data-toggle="tab" href="#15e" aria-expanded="true">All</a>
					                         </li>
                                            <li class="menumfollow"><a data-toggle="tab" href="#16e" aria-expanded="false">Individual</a>
					                         </li>
                                          <%--  <li class="menumfollow"><a data-toggle="tab" href="#17e" aria-expanded="false">Pop</a>
					                        </li>--%>
                                        
                                             
					                  </ul>
								</div>
                             
							<div style="clear:both"></div>
                           </div>
		           
                    <div class="" id="exTab2">	
                       <div class="tab-content tabcontents">
	   		                <div style="" id="15e" class="tab-pane active">
                                   <!--music step slider start-->
                                  <div class="boxproetabevent">
                            <%--        <div class="eventstitle">Listen Later</div>--%>
                    
                         
                	                   <div class="row gutter-10">
                                             
											    <%--  <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/sp1.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>--%>

                                           
											     <asp:Repeater ID="rptlikedAll" runat="server"   >
                                        <ItemTemplate>
										<div class="col-sm-3 col-xs-6">
<a> <asp:Image ID="Image2" runat="server"  CssClass="imageeventsbooks" ImageUrl='<%# Bind("Image_Name",  "{0}") %>'/></a>
                                    <asp:Button ID="btnReply" runat="server" Text="Unlike" OnClick="btnReplyClicked2" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn"/>
                                        
                                                            <p class="fonteventtext"><asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("P_Name") %>' Width="" ></asp:Label><br>
                                                                     
                                                           </p>

                                            </div>

										</ItemTemplate>
                            </asp:Repeater>



													
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->

                             </div>

                            <div id="16e" class="tab-pane">
                                      <div class="boxproe2">
                                  	 <div class="">
                                       <div class="eventstitle">
                                           <asp:Label ID="lblctname1" runat="server" Text="Label"></asp:Label> </div>
                                  	    <div class="row gutter-10">
                                             
							                       
											     <asp:Repeater ID="rptlikedIndivisual" runat="server"   >
                                        <ItemTemplate>
										<div class="col-sm-3 col-xs-6">
<a> <asp:Image ID="Image2" runat="server"  CssClass="imageeventsbooks" ImageUrl='<%# Bind("Image_Name",  "{0}") %>'/></a>
                                    <asp:Button ID="btnReply" runat="server" Text="Unlike" OnClick="btnReplyClicked3" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' cssclass="postbtn"/>
                                        
                                                            <p class="fonteventtext"><asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("P_Name") %>' Width="" ></asp:Label><br>
                                                                     
                                                           </p>

                                            </div>

										</ItemTemplate>
                            </asp:Repeater>

                                                 
													
												

                                              </div>
                                       </div>
                                   </div>
                            </div>



                         </div>


                   </div>

                    </div>	

		    	 <div style="clear:both"></div>
						
				  
             </div>
			</div>
	   </div>
     <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
      <asp:HiddenField ID="hidArticleId" runat="server" />
      <asp:Label ID="Lblsname" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>

