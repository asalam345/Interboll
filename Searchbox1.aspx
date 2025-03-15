<%@ Page Title="" Language="C#" MasterPageFile="~/Sitefrnd.master" AutoEventWireup="true" CodeFile="Searchbox1.aspx.cs" Inherits="Searchbox1" %>
 
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
		  <div class="search2">
                        <div method="post" action="">
                            <input type="text" class="input_search" id="txtSearch"  runat="server" name="key" placeholder="Search Interboll" autocomplete="off" role="textbox" aria-autocomplete="list" aria-haspopup="true"  runat="server">
                            
                            <div id="btnSearch" class="btn_search">
                                <div class="">
                                     <button onserverclick="SearchButton_Click" runat="server" type="submit" class="searchbtn2">
                                           <img border="0" class="searchimg" src="img/search_btn.png">
                                  </button>
                                </div>
                            </div>
                 </div>
                        <div style="clear:both"></div>
		</div>
		<div style="clear:both"></div>
            </div>
	 </div>
   </div>


   <div class="boxsocial2">
		   <div class="boxproe">
               <div class="titleheadpast">
						<img align="left" class="aboutimg" src="img/f2.png" style="margin-right:10px">  <span style="font-size:15px">Followers</span>
               </div>
               <!--step1 search box start-->
               <div class="eventbox">
                  <%--    <div class="row gutter-10">
                             <div class="col-sm-2">
                                   <a href="#"> <img class="imgpastsearch" src="img/past1.jpg"></a>
                             </div>
                             <div class="col-sm-8">
                                     <a href="#"> Saiful Islam</a><br>
                                  OiiO International Ltd. <br>
                                   Ahsanullah University of Science and Technology, Dhaka
                         </div>
                          <div class="col-sm-2">
                              <button class="confirmbtnfsearch">Add Follower</button>
                          </div>
                    </div>--%>
                      <asp:Repeater ID="rptFriend" runat="server" OnItemDataBound="RepeaterItemCreated" >
                                 <ItemTemplate>  
	     <div class="row gutter-10">
                             <div class="col-sm-2">
                       <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>"> <asp:Image ID="Image2" runat="server"  CssClass="imgpastsearch" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>'/></a>
                            </div>

             <div class="col-sm-8">
                                      <asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width="" Font-Bold="true"></asp:Label>
                  <asp:Label ID="lblfrnd1" runat="server" Text='<%# Bind("IID") %>' Width="" Font-Bold="true" Visible="false"></asp:Label>
                  
                            </div>
                         
                        <div class="col-sm-2">

                             <asp:Button ID="btnReply" runat="server" Text="Add" OnClick="btnReplyClicked3" AutoPostBack="True"  Visible="false" CommandArgument='<%#Eval("IID")%>' CssClass="confirmbtnf2" />
                            <asp:Button ID="RequestSent" runat="server" Text="RequestSent" OnClick="btnReplyClicked4" AutoPostBack="True"  Visible="false" CommandArgument='<%#Eval("IID")%>' CssClass="confirmbtnf2" />
                             <asp:Button ID="Follower" runat="server" Text="Folloer" OnClick="btnReplyClicked5" AutoPostBack="True"  Visible="false" CommandArgument='<%#Eval("IID")%>' CssClass="confirmbtnf2" />
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
<%--			 <div class="row">
                      <div class="col-sm-9">
						   <a href="#">
                               <img class="imgprofilenotifi2" src="img/p3.jpg">
                              </a>
                                   <a href="#"><span>rhaman</span><br>
							           <span style="font-size:11px">     31 Aug 2016</span>
                                             <br>
                                 </a><a title="Liked" class="textdecorationsta" href="#"><i class="glyphicon glyphicon-hand-right"></i>  <span>1</span> </a>
                                  <a title="Share" class="textdecorationsta" href="#"><i class=" glyphicon glyphicon-share"></i>  <span>1</span></a>
                            
							   </div>
							  
							   <div class="col-sm-3 text-right">
							     <div class="" id="ctl00_MainContent_rptPost_ctl03_MUser">
				    <div class="dropdown">
					  <div aria-expanded="true" class="dropdown-toggle" type="button" data-toggle="dropdown">
					    <i class="glyphicon glyphicon-menu-down"></i>
					 </div>
					  <ul class="dropdown-menu postinfo">
					     <li>
						   <a style="" href="#">
								 Save Post
							  </a>
					    </li>
						 <li>
						   <a style="" href="#">
								Edit Post
							  </a>
					    </li>
						 <li>
						   <a style="" href="#">
								Change Date
							  </a>
					    </li>
						
						 <li>
						   <a style="" href="#">
								Hide From Outline
							  </a>
					    </li>
                           <li>
						   <a style="" href="#">
								Delete
							  </a>
					     </li>
						
					  </ul>
                   </div>
				
				</div>
			</div>
		</div>--%>
	
	 <div style="margin-top:10px" class="">
			
               <div style="clear:both"></div>
         
				<div style="clear:both"></div>
                  <div class="comment more"> <div><span id="ctl00_MainContent_rptPost_ctl03_Label3">hi interbollteam</span></div></div>	
         
         			
	 </div>
	                    <asp:Repeater ID="rptPost" runat="server" OnItemDataBound="RepeaterItemCreated" OnItemCommand="itemRepeater_ItemCreated">
                            <ItemTemplate>
                        <div class="boxpro">
					          <div class="row">
                             
						       <div class="col-sm-9">
							  <%--   <a href="#"> <img border="0" align="left" class="imgprofilenotifi2" src="img/img3.png"></a>--%>
                                  <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>"> <asp:Image ID="Image2" runat="server"  CssClass="imgprofilenotifi2" ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>'/></a>
                                   <a href="<%# "frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>"><asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label><br>
							      <span style="font-size:11px">     <%# string.Format("{0:dd MMM yyyy}", Eval("P_Date"))%></span>
                                 
							   </a>
							   </div>
							  
							   <div class="col-sm-3 text-right">
							     <div class="" id="MUser" runat="server">
				    <div class="dropdown">
					  <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">
					    <i class="glyphicon glyphicon-menu-down"></i>
					 </div>
					  <ul class="dropdown-menu postinfo">
					     <li>
						   <a href="#" style="">
								 Save Post
							  </a>
					    </li>
						 <li>
						   <a href="#" style="">
								Edit Post
							  </a>
					    </li>
						 <li>
						   <a href="#" style="">
								Change Date
							  </a>
					    </li>
						
						 <li>
						   <a href="#" style="">
								Hide From Outline
							  </a>
					    </li>
                           <li>
						   <a href="#" style="">
								Delete
							  </a>
					     </li>
						
					  </ul>
                   </div>
				
				</div>
			</div>
		</div>
						   
	 <div class="" style="margin-top:10px">
			<%--	<a href="#"><img border="0" align="left" src="img/naturalimg.jpg" class="imresponsive"></a>--%>
          <asp:Image ID="Image1" runat="server"  height=""  Width="100%" CssClass="imresponsive"  Visible="false"  ImageUrl='<%# Bind("Post_Image", "~/images/Items/{0}") %>'/>
          
             

                     
                 

            
               <div style="clear:both"></div>
         
				<div style="clear:both"></div>
                  <div class="comment more"> <div><asp:Label ID="Label3" runat="server" Text='<%# Bind("P_Description") %>'></asp:Label></div></div>	
         
         			
	 </div>
	 
						   
	             
                         
                            <!--comments end-->

                            <div style="clear:both"></div>
					  </div>

                            	

					         </ItemTemplate>

                        </asp:Repeater>
						   
	    <%--    <div class="photouploadstatus">
	            <div class="topupload2">
                      <div class="row">
                           <div class=" ">
								<div class="row gutter-10">
								     

                                       
                                    <div class="col-sm-6">
                                      <div class="col-sm-3"> <input type="submit" autopostback="True" class="postbtn" id="ctl00_MainContent_rptPost_ctl03_btnReply" value="Liked" name="ctl00$MainContent$rptPost$ctl03$btnReply"></div>
						
                                  
								       
                                         <div title="Comments" class="col-sm-5">
                                            <div class="commentsleft">  <input type="submit" autopostback="True" class="postbtn2" id="ctl00_MainContent_rptPost_ctl03_Button2" value="Comment" name="ctl00$MainContent$rptPost$ctl03$Button2"></div>
                                              <div class="commentscount"><span id="ctl00_MainContent_rptPost_ctl03_lblcommentname">2</span></div></div>
									     <div class="col-sm-4"> <input type="submit" autopostback="True" class="postbtn" id="ctl00_MainContent_rptPost_ctl03_Button4" value="Shared" name="ctl00$MainContent$rptPost$ctl03$Button4"></div>
                                    	
                                        </div>
                                      <div class="col-sm-6">
                                            
                                          <div class="col-sm-3"> <button title="Save" class="postbtn2">Save </button></div>
                                         <div class="col-sm-3"> <button title="Hide" class="postbtn2">Hide</button></div>
                                           <div class="col-sm-3"> </div>
                                           <div class="col-sm-3">    </div>
                                        </div>
								 </div>
								  
							
									<div style="clear:both"></div>
								</div>
                        </div>
					</div>
               
                 </div> --%>      
                            <!--comments start-->
                             
                            <div class="comentsbox" id="ctl00_MainContent_rptPost_ctl03_divlok">
                             
                                     
                                  <div title="Coments" class="col-sm-12"></div>
                            </div>
                            <!--comments end-->

                            <div style="clear:both"></div>
              </div>

       <!--post From end-->
    </div>
     </div>
     </div>
     <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
      <asp:HiddenField ID="hidArticleId" runat="server" />
</asp:Content>

