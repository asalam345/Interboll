<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucRightsidefrnd.ascx.cs" Inherits="Usercontrol_ucRightsidefrnd" %>
      <div class="col-sm-4">
          <div style="height:5px"></div>
	    	<div class="profilcoverpage"> 
               <div class="view view-first">
                    <img src="<%=lok1.Text%>" style="width:436px; height:138px"/>
                       <a data-target="#updatecoverphoto" data-toggle="modal" href="#">
                            <div class="mask">
                   
                           <div style="font-size:16px; text-align:left; color:#ffffff; padding:15px">
                              

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
			              <div class="profilenametext"> <asp:Label ID="lblName" runat="server" Text=""></asp:Label></div>
                            <div class="view view-first">
                                 <img border="0" src="<%=lok2.Text%>" class="imgpro">
                               <%-- <img src="images/9.jpg" />--%>
                              <a data-target="#updatephoto" data-toggle="modal" href="#">
                                   <div class="mask">
                                    <div style="color: #ffffff; font-size: 12px; padding-top: 27px; width: 80px;">
                                       <i class="glyphicon glyphicon-camera"> </i> </div>
                                   <%-- <p>A wonderful serenity has taken possession of my entire soul, like these sweet mornings of spring which I enjoy with my whole heart.</p>
                                    <a href="#" class="info">Read More</a>--%>
                                </div>
                                 </a>
                          </div>
			       </div>
         
		
		

		   </div>
		 
		
		</div>
		<!--social message notification start-->

		<div class="message_notificationwrap">
		    <div class="">
			 <div class="iconwrapmobile">
				    <div class="dropdown" style="display:none">
					  <div class="dropdown-toggle" type="button" data-toggle="dropdown">
					    <img border="0" src="img/myaccount.png" class="iconn" title="Account Information">
					 </div>
					  <ul class="dropdown-menu myaccountdropdownmb">
						
					  <li>
						   <a style="text-decoration:none; padding:0px" href="#">
								  <div class="profileimgnotifi">
									  <div class="col-sm-1"><img border="0" align="left" src="img/logo1.png" class="imgprofilenotifi2">
									  </div>
									 <div class="col-sm-5">
										  <div class="">Account: Basic</div>
									  </div>
									  <div class="col-sm-4">
										  <div class="logintext"> Upgrade</div>
									  </div>
								 <div style="clear:both"></div>
								</div>
							  </a>
					    </li>
					      
					   <li>
						   <a style="text-decoration:none; padding:0px" href="#">
								  <div class="profileimgnotifi">
									  <div class="col-sm-1"><img border="0" align="left" src="img/logo1.png" class="imgprofilenotifi2">
									  </div>
									 <div class="col-sm-5">
										  <div class="">Job Posting</div>
									  </div>
									  <div class="col-sm-4">
										  <div class="logintext"> Upgrade</div>
									  </div>
								 <div style="clear:both"></div>
								</div>
							  </a>
					    </li>
						
						   <li>
						   <a style="text-decoration:none; padding:0px" href="#">
								  <div class="profileimgnotifi">
									  <div class="col-sm-1"><img border="0" align="left" src="img/logo1.png" class="imgprofilenotifi2">
									  </div>
									 <div class="col-sm-5">
										  <div class=""> Privacy & Settings  </div>
									  </div>
									  <div class="col-sm-4">
										  <div class="logintext"> Manage</div>
									  </div>
								 <div style="clear:both"></div>
								</div>
							  </a>
					    </li>
						
						  <li>
						   <a style="text-decoration:none; padding:0px" href="#">
								  <div class="profileimgnotifi">
									  <div class="col-sm-1"><img border="0" align="left" src="img/logo1.png" class="imgprofilenotifi2">
									  </div>
									 <div class="col-sm-5">
										  <div class=""> Privacy & Settings  </div>
									  </div>
									  <div class="col-sm-4">
										  <div class="logintext"> Manage</div>
									  </div>
								 <div style="clear:both"></div>
								</div>
							  </a>
					    </li>
						
						  <li>
						   <a style="text-decoration:none; padding:0px" href="#">
								  <div class="profileimgnotifi">
									  <div class="col-sm-1"><img border="0" align="left" src="img/logo1.png" class="imgprofilenotifi2">
									  </div>
									 <div class="col-sm-5">
										  <div class=""> Help Center </div>
									  </div>
									  <div class="col-sm-4">
										  <div class="logintext"> Get Help</div>
									  </div>
								 <div style="clear:both"></div>
								</div>
							  </a>
					    </li>
						
						  <li>
						   <a style="text-decoration:none; padding:0px" href="#">
								  <div class="profileimgnotifi">
									  <div class="col-sm-1"><img border="0" align="left" src="img/logo1.png" class="imgprofilenotifi2">
									  </div>
									 <div class="col-sm-5">
										  <div class=""> Language</div>
									  </div>
									  <div class="col-sm-4">
										  <div class="logintext">Change</div>
									  </div>
								 <div style="clear:both"></div>
								</div>
							  </a>
					    </li>
					  </ul>
                   </div>
				
				</div>
			<%--	
				 <div class="col-sm-2">
				
				
				</div>--%>
                <div class="iconwrapmobile">
                     <a href="signout.aspx"><img border="0" src="img/signout.png" class="iconn" title="Logout" /></a>
                </div>
			</div>
			<div style="clear:both"></div>
		</div>
		<!--social message notification end-->
		
		    <div class="boxsocial3">
				<div class="scrollboxhide3"></div>
                <div class="scrollboxhide3r"></div>
			<!--tab start-->
			    <div class="tabcontentswrap">
				<div id="exTab2" class="">	
				  <ul class="nav nav-tabs tabcss">
                  <li class="menumin"><a  href="eventdefault.aspx" >Event</a>
					</li>
                     <li class="menumin ">
					 <a aria-expanded="false" href="#2fb" data-toggle="tab">Outline</a>
					</li>
					  <li class="menumin active"><a aria-expanded="false" href="#3fb" data-toggle="tab">Followers</a>
					</li>

					<li class="menumin"><a aria-expanded="true" href="#4fb" data-toggle="tab">Photos</a>
					</li>
                      <li class="menumin "><a href="education.aspx">Education</a>
					</li>
                    <li class="menumin"><a  href="../games/Default.aspx" target="_blank">Games</a>
                                    </li>
                      <li class="menumin"><a href="index_entertainment.html" target="_blank">
                                        <div style="display: none">
                                            <asp:Label ID="lblAdprofile" runat="server" Text=""></asp:Label>
                                        </div>
                                        Entertainment
                                    </a>
                                    </li>
					<li class="menumin"><a aria-expanded="false" data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">More</a>

                      
					<%--  <div data-toggle="dropdown" type="button" class="dropdown-toggle" aria-expanded="true">
					    <img border="0" title="Chat" class="iconn" src="img/chat.png">
					 </div>--%>
					  <ul class="dropdown-menu moredropdown">
					    
							 <li>
                                                <a href="More.aspx?ID=CfX1IBf+ZgwPGhata8canA==" style="text-decoration: none; padding: 0px">Movie
                                                </a>
                                            </li>

                                            <li>
                                                <a href="More.aspx?ID=JtvMsudX0LwKFv4Xfrh2Pg==" style="text-decoration: none; padding: 0px">Music
                                                </a>
                                            </li>

                                            <li>
                                                <a href="More.aspx?ID=x+ksp//h1H2QtmTBZoA0RA==" style="text-decoration: none; padding: 0px">Sports
                                                </a>
                                            </li>

                                            <li>
                                                <a href="More.aspx?ID=5stSg+tgr0YgyBYNyB6IRg==" style="text-decoration: none; padding: 0px">Books
                                                </a>
                                            </li>
                                            <li>
                                                <a href="Likes.aspx" style="text-decoration: none; padding: 0px">Likes
                                                </a>
                                            </li>
                                          
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
       <div class="tab-content tabcontents">
	   		 <div class="tab-pane" id="1fb" style="display:none">
               	  <!--About start-->
                   <div class="boxpro">
					       <div class="aboutwrap">
						       <div class="col-sm-1">
							     <a href="#"> <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
							   </div>
							   <div class="col-sm-7"> <span style="font-size:15px">About</span></div>
							<div style="clear:both"></div>
		                    </div>

						 <div class="row" style="margin-top:10px">
						        <div class="col-sm-4">
                                     <!-- required for floating -->
                                          <!-- Nav tabs -->
                                 <%--      <h5> Overview</h5>--%>
                                          <ul class="nav nav-tabs tabs-left sideways">
                                            <li class="active"><a href="#Profilefb" data-toggle="tab">Profile</a></li>

                                            <li><a href="#workexperiencefb" data-toggle="tab">Work Experience</a></li>
                                            <li><a href="#Qualificationfb" data-toggle="tab">Qualification</a></li>
                                            <li><a href="#Livingplacefb" data-toggle="tab">Living Place</a></li>
                                            <li><a href="#contactinfofb" data-toggle="tab">Contact Info</a></li>
                                            <li><a href="#relationshipsfb" data-toggle="tab">Relationships</a></li>
                                            <li><a href="#aboutdetailsfb" data-toggle="tab">About Your Details</a></li>
                                             <li><a href="#Lifeeventfb" data-toggle="tab">Personalisation</a></li>
                                          </ul>

								 
								   
								</div>
								
							    <div class="col-sm-8" style="border-left:1px solid #d0d0d0">

                                       <!-- Tab panes -->
                                  <div class="tab-content">
                                    <div class="tab-pane active" id="Profilefb">
                                     <div class="row">
									  <div class="rightaddress">
									      <div class="col-sm-2"> 
										   <a href="#"> <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
										   </div>
										   <div class="col-sm-10">
										   
										        Name: <div><asp:Label ID="lblProfileName1" runat="server" Text="" ></asp:Label></div>
										   </div>
										   <div style="clear:both"></div>
									  </div>

                                       <div class="rightaddress">
									      <div class="col-sm-2"> 

										   </div>
										   <div class="col-sm-10">
										   
										        Gender: <asp:Label ID="lblGender" runat="server" Text="" ></asp:Label>
										   </div>
										   <div style="clear:both"></div>
									  </div>

                                        <div class="rightaddress">
									      <div class="col-sm-2"> 

										   </div>
										   <div class="col-sm-10">
										   
										        Date of Birth: <asp:Label ID="lblDob" runat="server" Text="" ></asp:Label>
										   </div>
										   <div style="clear:both"></div>
									  </div>
									  
                                            <div class="rightaddress">
									      <div class="col-sm-2"> 

										   </div>
										   <div class="col-sm-10">
										   
										     About : <asp:Label ID="lblMyself" runat="server" Text="" ></asp:Label>
										   </div>
										   <div style="clear:both"></div>
									  </div>


									  

									  </div>
                                  </div>

                                 <div class="tab-pane" id="workexperiencefb">
                                    <div class="row2">
									  <div class="rightaddress">
									     
										   <div class="col-sm-12">
										Occupation : 
										  <div ><asp:Label ID="lblOcupation" runat="server" Text="" ></asp:Label></div>
                                               <br />
                                               
										   </div>
										   <div style="clear:both"></div>
									  </div>
									  

									    <div class="rightaddress">
									   
										   <div class="col-sm-12">
										   
										  Present Working Status: <asp:Label ID="lblPresentWorkstatus" runat="server" Text="" ></asp:Label>
										
										   </div>
										   <div style="clear:both"></div>
									  </div>

                                        
									    <div class="rightaddress">
									   
										   <div class="col-sm-12">
										   
										  Past Working Status:  <asp:Label ID="lblPastExperiance" runat="server" Text="" ></asp:Label>
										
										   </div>
										   <div style="clear:both"></div>
									  </div>
									  	   
									  	   

                                    


									  </div>
                                    </div>

                                      <div class="tab-pane" id="Qualificationfb">
                                          <div class="rightaddress">
										       University :
										       <div> <asp:Label ID="lblUniversity" runat="server" Text=""></asp:Label></div>
										 
										   <div style="clear:both"></div>
                                          
								    	  </div>

                                           <div class="rightaddress">
                                               College : <asp:Label ID="lblCollege" runat="server" Text=""></asp:Label>
                                           </div>

                                             <div class="rightaddress">
                                               School :      <asp:Label ID="lblSchool" runat="server" Text=""></asp:Label>
                                           </div>

                                             <div class="rightaddress">
                                               About Qualification :      <asp:Label ID="lblQualification" runat="server" Text=""></asp:Label>
                                           </div>


                                        
                                     </div>


                                       <div class="tab-pane" id="Livingplacefb">
                                            <div class="rightaddress">

                                              <div style="display:none"> </div>

										      <div style="clear:both"></div>
									       </div>

                                             <div class="rightaddress">
									         Present Address :  <asp:Label ID="lblpresentAddress" runat="server" Text=""></asp:Label>

										      <div style="clear:both"></div>
									       </div>

                                              <div class="rightaddress">
									            Permanet  Address :     <asp:Label ID="lblParmanentAddress" runat="server" Text=""></asp:Label>

										      <div style="clear:both"></div>
									       </div>

                                             <div class="rightaddress">
									            Country :     <asp:Label ID="lblCountry" runat="server" Text=""></asp:Label>

										      <div style="clear:both"></div>
									       </div>
                                            

                                       </div>


                                       <div class="tab-pane" id="contactinfofb">
                                            <div class="rightaddress">
										      <div style="display:none">
										        <asp:Label ID="lblRelesonship" runat="server" Text=""></asp:Label>
                                            </div>
                                                E-mail Address :<asp:Label ID="lbllogin" runat="server" Text=""></asp:Label>
										   <div style="clear:both"></div>
									     </div>

                                            <div class="rightaddress">
										      <div style="display:none">
										        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                                            </div>
                                               Contact Number:<asp:Label ID="lblContactNo" runat="server" Text=""></asp:Label>
										   <div style="clear:both"></div>
									     </div>
                                              <div class="rightaddress">
										      <div style="display:none">
										        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                                            </div>
                                              Website Link: <asp:Label ID="lblWebsite" runat="server" Text=""></asp:Label>
										   <div style="clear:both"></div>
									     </div>
                                      
                                        
                                       <!--add work space start-->

                                       </div>



                                   <!--Relationship-->
                                  <div class="tab-pane" id="relationshipsfb">
                                    <div class="row2">
									  <div class="rightaddress">
									       <div class="col-sm-2"> 
										   <a href="#"> <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
										   </div>
										   <div class="col-sm-10">
										  RelationShip Status :    <asp:Label ID="lblRelation" runat="server" Text=""></asp:Label>
										 
										   </div>
										   <div style="clear:both"></div>
									  </div>

                                        <div class="rightaddress">
									       <div class="col-sm-2"> 
										   <a href="#"> <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
										   </div>
										   <div class="col-sm-10">
										 Family Number:         <asp:Label ID="lblFamily" runat="server" Text=""></asp:Label>
										 
										   </div>
										   <div style="clear:both"></div>
									  </div>

									 

                                    


									  </div>
                                    </div>
                                      <!--Relation ship end-->

                                   <!--about your details start-->
                                  <div class="tab-pane" id="aboutdetailsfb">
                                    <div class="row2">
									  <div class="rightaddress">
									     Favorite Sports : Football
										
										   <div style="clear:both"></div>
									  </div>
                                        <div class="rightaddress">
									     Favorite Hobby : Playing
										
										   <div style="clear:both"></div>
									  </div>
                                        <div class="rightaddress">
									     Favorite Food : Chicken
										
										   <div style="clear:both"></div>
									  </div>
                                          <div class="rightaddress">
									      Political View : no
										
										   <div style="clear:both"></div>
									  </div>
									  </div>
                                    </div>
                                     
                                   <!--about your details end-->

                                            <!--item1 start2-->
                                  <div class="tab-pane" id="Lifeeventfb">
                                    <div class="row2">
									  <div class="rightaddress">
									      System Icons:
										   <div style="clear:both"></div>
									  </div>

                                      <div class="rightaddress">
									     Thems:
										   <div style="clear:both"></div>
									  </div>

                                       <div class="rightaddress">
									     Wallpaper:
										   <div style="clear:both"></div>
									  </div>

                                      <div class="rightaddress">
									     Clock:
										   <div style="clear:both"></div>
									  </div>
									 

									  </div>
                                    </div>
                                      <!--item1 end-->


                                   </div>

								</div>
								<div style="clear:both"></div>	  
						 </div>
	 

			</div>
					  
			 <!--about end-->
			 
			   <!--photo-box1 start-->
                   <div class="boxpro">
				       <div class="aboutwrap">
                           <div class="row">
					      <div class="col-sm-3">
						       <div class="col-sm-1">
							     <a href="#"> <img border="0" align="left" src="img/f2.png" class="aboutimg"></a>
							   </div>
							   <div class="col-sm-6"> 
							  <span style="font-size:15px">Followers</span></div>
							</div>
							   <%-- <div class="col-sm-9 text-right">
								       <button class="confirmbtnp">Followers Requests</button>
									   <button class="confirmbtnp">Find Followers</button>
                                       <button class="confirmbtnp">Edit</button>
								</div>--%>
							<div style="clear:both"></div>
		                    </div>
                        </div>
							
							<div class="friendsall">
				                  									        <div class="row">
										         <asp:Repeater ID="rptFriends" runat="server">
                                        <ItemTemplate>
											<div class="col-sm-6">
                                   
							                <div class="allfriends">
									        <div class="row">
										          <div class="col-sm-2"><%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                        <asp:Image ID="Image3" runat="server"   ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>'  class="imgprofriend"/>                                                
										          </div>
										          <div class="col-sm-7"> 
											         <div style="font-size:11px;"><asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label><br>
											           <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
											
											        </div>
										         
										          </div>
										          <div class="col-sm-2">
											       
                                                         <div  style="margin-left:-8px" class="fontsizetext">Followers</div>
                                         
										          </div>
									      
									         </div>

							               </div>
                                          <div style="clear:both"></div>
							            </div>
										</ItemTemplate>
                            </asp:Repeater>
									         <div style="clear:both"></div>
									         </div>
							

							
							</div>
							
							   
							<div style="clear:both"></div>
				   </div>
			 <!--post-box1 end-->
			 
			 
			 	   <!--post-box1 start-->
                   <div class="boxpro">
				       <div class="aboutwrap">
                           <div class="row">
					      <div class="col-sm-3">
						       <div class="col-sm-1">
							     <a href="#"> <img border="0" align="left" src="img/f2.png" class="aboutimg"></a>
							   </div>
							   <div class="col-sm-6"> 
							   <span style="font-size:15px">Photos</span></div>
							</div>
							 <div class="col-sm-9 text-right">
								       <ul class="nav nav-tabs tabalbumwrap">
                                                           <%-- <li class="tabalbum"><a href="Createphoto.aspx" aria-expanded="true">Create Album</a>
                                                            </li>--%>

                                                            <li class="tabalbum active"><a data-toggle="tab" href="#yourphoto2fb" aria-expanded="false">Your Photo</a>
                                                            </li>
                                                            <li class="tabalbum">
                                                                <a data-toggle="tab" href="#album2fb" aria-expanded="false">

                                                                    Albums

                                                                </a>
                                                            </li>

                                                </ul>
						     </div>

							<div style="clear:both"></div>
		                    </div>
							</div>

                                  <div class="" id="exTab2">
                                                <div class="tab-content tabcontents">
                                                    <div style="" id="yourphoto2fb" class="tab-pane active">
                                                        <div class="friendsall" style="margin-top: 10px">
                                                            	<div class="row gutter-10">
                                              <asp:Repeater ID="dlPostImage" runat="server"  >
                                        <ItemTemplate>
											  <div class="col-sm-4">
                                   
							                  
                                                <asp:Image ID="Image3" runat="server"  class="img-responsive" ImageUrl='<%# Bind("Image_Name",  "~/images/Items/{0}") %>'  style="margin-bottom: 10px; height:120px; width:100% "/>                                                
                                                
                                     
                                         
                                                
							                </div>
										</ItemTemplate>
                            </asp:Repeater>
									 
								
									<div style="clear:both"></div>
							</div>
                           </div>
                       </div>

                             <div style="" id="album2fb" class="tab-pane">
                                         <div class="friendsall" style="margin-top: 10px">
                                             album
                                          </div>
                                   </div>
                                    </div>
                                </div>


							<div class="friendsall" style="margin-top:10px">

						
							</div>
							<div style="clear:both"></div>
				   </div>
			 <!--photo-box1 end-->
			 
			 <div style="clear:both"></div>
			 
		    </div>
			
			<!--tab2 start-->
    	     <div class="tab-pane" id="2fb">
		  <!--post-box1 start-->
                       <asp:Repeater ID="rptPost" runat="server" >
                            <ItemTemplate>
                   <div class="boxpro">
					       <div class="row">
                             
						       <div class="col-sm-9">
							     <a href="#"> <img border="0" align="left" class="imgprofilenotifi2" src="img/img3.png"></a>
                                   <a href="#"><asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label><br>
							      <span style="font-size:11px">     <%# string.Format("{0:dd MMM yyyy}", Eval("P_Date"))%></span>
                                             <br />
                                 <a href="#" class="textdecorationsta" title="Liked"><i class="glyphicon glyphicon-hand-right"></i>  <asp:Label ID="Label1" runat="server" Text='<%# Eval("Like1") %>' Width=" "></asp:Label> </a>

                                  <asp:Label ID="lblpostid" runat="server" Text='<%# Bind("P_Id") %>' Width=" " Visible="false"></asp:Label>
                                        <asp:Label ID="lblUserid" runat="server" Text='<%# Bind("A_User_Id") %>' Width=" " Visible="false"></asp:Label>
							   </a>
							   </div>
							  
							   <div class="col-sm-3 text-right">
							     <div class="" id="MUser" runat="server">
		
				
				</div>
			</div>
		</div>
						   
	 <div class="" style="margin-top:10px">
			<%--	<a href="#"><img border="0" align="left" src="img/naturalimg.jpg" class="imresponsive"></a>--%>
          <asp:Image ID="Image1" runat="server"  height=""  Width="100%" CssClass="imresponsive"  Visible=""  ImageUrl='<%# Bind("Post_Image", "~//images/Items/{0}") %>'/>
          
             

                     
                 

            
               <div style="clear:both"></div>
         
				<div style="clear:both"></div>
                 <div style="margin-top:10px; margin-bottom:10px"><asp:Label ID="Label3" runat="server" Text='<%# Bind("P_Description") %>' Width=" "></asp:Label></div>				
	 </div>
	 
						   
	    

                            <div style="clear:both"></div>
					  </div>

                            	

					         </ItemTemplate>

                        </asp:Repeater>
			 <!--post-box1 end-->
			 
					<div style="clear:both">  </div>
            </div>
			

			<div class="tab-pane active" id="3fb">

			 <div class="boxpro2">
				       <div class="aboutwrap">
                           <div class="row">
						     <%--  <div class="col-sm-1">
							     <a href="#"> <img border="0" align="left" class="aboutimg" src="img/f2.png"></a>
							   </div>--%>
							
				              <div class="col-sm-12 text-right">
								        <ul class="nav nav-tabs tabcssfollowers">
                                              <li class="menumfollow active"><a aria-expanded="false" href="#11fb" data-toggle="tab">Followers</a>
					                         </li>
                                              <li class="menumfollow"><a aria-expanded="false" href="#12fb" data-toggle="tab">Followers Requests</a>
					                         </li>
                                             <li class="menumfollow ">
					                         <a aria-expanded="false" href="#13fb" data-toggle="tab">Find Followers</a>
					                         </li>
					                           <li class="menumfollow"><a aria-expanded="false" href="#14fb" data-toggle="tab">Following</a>
					                        </li>
					                  </ul>
								</div>
							<div style="clear:both"></div>
                           </div>
		                </div>
							
                    <div id="exTab2" class="">	
				 

                       <div class="tab-content tabcontents">
	   		                <div class="tab-pane active" id="11fb" style="">
                                  	<div class="row gutter-10">

							      
									        <div class="row">
										         <asp:Repeater ID="rptFollowers" runat="server">
                                        <ItemTemplate>
											<div class="col-sm-6">
                                   
							                <div class="allfriends">
									        <div class="row">
										          <div class="col-sm-2 col-xs-2"><%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                        <asp:Image ID="Image3" runat="server"   ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>'  class="imgprofriend"/>                                                
										          </div>
										          <div class="col-sm-7"> 
											         <div style="font-size:11px;"><asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label><br>
											           <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
											
											        </div>
										         
										          </div>
										          <div class="col-sm-2">
											       
                                                         <div  style="margin-left:-8px" class="fontsizetext">Followers</div>
                                         
										          </div>
									      
									         </div>

							               </div>
                                          <div style="clear:both"></div>
							            </div>
										</ItemTemplate>
                            </asp:Repeater>
									         <div style="clear:both"></div>
									         </div>
							           
							     

                                          <div style="clear:both"></div>
                                 </div>
                             </div>



                            <div class="tab-pane" id="12fb" style="">
                                  	<div class="row gutter-10"> 
									    
										      <asp:Repeater ID="rptRequest" runat="server">
                                        <ItemTemplate>
											<div class="col-sm-6">
                                   
							                <div class="allfriends">
									        <div class="row">
										          <div class="col-sm-2  col-xs-2"><%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                        <asp:Image ID="Image3" runat="server"   ImageUrl='<%# Bind("Profile_Image",  "~/images/Items/{0}") %>'  class="imgprofriend"/>                                                
										          </div>
										          <div class="col-sm-7"> 
											         <div style="font-size:11px;"><asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label><br>
											           <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
											
											        </div>
										         
										          </div>
										          <div class="col-sm-3">
											       
                                                      <span class="fontsizetext"> request sent</span>
                                         
										          </div>
									      
									         </div>

							               </div>
                                          <div style="clear:both"></div>
							            </div>
										</ItemTemplate>
                            </asp:Repeater>
									       
							           
							     
                                        
                                          <div style="clear:both"></div>
                                 </div>
                            </div>

                            <div class="tab-pane" id="13fb" style="">

                                <div class="row gutter-10">
                                  <asp:Repeater ID="rptSearchFrnd" runat="server">
                                        <ItemTemplate>
											<div class="col-sm-6">
                                   
							                <div class="allfriends">
									        <div class="row">
										          <div class="col-sm-2  col-xs-2"><%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                        <asp:Image ID="Image3" runat="server"   ImageUrl='<%# Bind("Profile_Image",  "~/images/Items/{0}") %>'  class="imgprofriend"/>                                                
										          </div>
										          <div class="col-sm-7"> 
											         <div style="font-size:11px;"><asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label><br>
											           <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
											
											        </div>
										          <div style="clear:both"></div>
										          </div>
										          <div class="col-sm-2">
											       <%--  <button class="confirmbtnf2">Followers</button>--%>
											          <asp:Button ID="btnReply" runat="server" Text="Add" OnClick="btnReplyClicked" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' CssClass="confirmbtnf2" />
                                                </asp:LinkButton>
                                         
										          </div>
									         <div style="clear:both"></div>
									         </div>
                                                <div style="clear:both"></div>
							               </div>
                                              
                                             
                                                
							                </div>
										</ItemTemplate>
                            </asp:Repeater>
                               </div>
                            </div>


                             <div class="tab-pane" id="14" style="">


                                           <asp:Repeater ID="rptFollowing" runat="server">
                                        <ItemTemplate>
											<div class="col-sm-6">
                                   
							                <div class="allfriends">
									        <div class="row">
										          <div class="col-sm-2  col-xs-2"><%--<img border="0" align="left" src="img/img1.png" class="imgprofriend">--%>
                                                        <asp:Image ID="Image3" runat="server"   ImageUrl='<%# Bind("Profile_Image",  "~/{0}") %>'  class="imgprofriend"/>                                                
										          </div>
										          <div class="col-sm-7"> 
											         <div style="font-size:11px;"><asp:Label ID="Label3" runat="server" Text='<%# Bind("First_Name") %>' Width=" "></asp:Label><br>
											           <%--<span class="font-size:11px;">3 mutual Followers</span>--%>
											
											        </div>
										          <div style="clear:both"></div>
										          </div>
										          <div class="col-sm-2">
											       <%--  <button class="confirmbtnf2">Followers</button>--%>
											          <asp:Button ID="btnReply" runat="server" Text="Add" OnClick="btnReplyClicked1" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' />
                                                </asp:LinkButton>
                                         
										          </div>
									         <div style="clear:both"></div>
									         </div>
							               </div>
                                              
                                             
                                                
							                </div>
										</ItemTemplate>
                            </asp:Repeater>


                             </div>
                         </div>


                   </div>



		    	 <div style="clear:both"></div>
						
				   </div>

			</div>



			<div class="tab-pane" id="4fb">
					   <!--post-box1 start-->
                   <div class="boxpro2">
				       <div class="aboutwrap">
                           <div class="row">
					      <div class="col-sm-3" style="display:none">
						       <div class="col-sm-1">
							     <a href="#"> <img border="0" align="left" src="img/f2.png" class="aboutimg"></a>
							   </div>
							   <div class="col-sm-6"> 
							   <a href="#" class="textdecorationsta"><span style="font-size:15px">Photos</span></a></div>
							</div>
							    <div class="col-sm-9 text-right">
								       <button class="confirmbtnp">Create Album</button>
									   <button class="confirmbtnp">Your Photo</button>
                                       <button class="confirmbtnp">Albums</button>
								</div>
							<div style="clear:both"></div>
                          </div>
		             </div>
							
							<div class="friendsall" style="margin-top:10px">
							<div class="row gutter-10">
                                             <asp:Repeater ID="dlPostimage1" runat="server"  >
                                        <ItemTemplate>
											  <div class="col-sm-4 col-xs-4">
                                   
							                  
                                                <asp:Image ID="Image3" runat="server"  class="img-responsive" ImageUrl='<%# Bind("Image_Name",  "~/images/Items/{0}") %>'  style="margin-bottom: 10px; height:120px; width:100% "/>                                                
                                                
                                     
                                         
                                                
							                </div>
										</ItemTemplate>
                            </asp:Repeater>
									 
									<div style="clear:both"></div>
							</div>
							</div>
							<div style="clear:both"></div>
				   </div>
			 <!--photo-box1 end-->


			</div>

		  <div class="tab-pane" id="5fb">
		  <!--news-feed-srart-->
				<div class="boxpro2">
					   
						  <%--   Add Profile Sumon--%>

                    <div style="clear:both"></div>
					  </div>
					    <!--news-feed-end-->
						
						
		  </div>



			<div class="tab-pane" id="6fb">
			 	  <!--news-feed-srart-->
				<div class="boxpro2">
					       <div class="row">
						       <div class="col-sm-2">
							     <a href="#"> <img border="0" align="left" src="img/n3.jpg" class="imgprofilenotifi"></a>
							   </div>
							   <div class="col-sm-7"><a href="#">bdnews.com<br>
							      <span style="font-size:11px">August 20 at 2.03pm</span>
							   </a></div>
							   <div class="col-sm-3 text-right">
							     <div class="">
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
								Hide From Timeline
							  </a>
					    </li>
						 <li>
						   <a style="" href="#">
								Trun Of Transitions
							  </a>
					    </li>
						
					  </ul>
                   </div>
				
				</div>
			</div>
		</div>
						   
	 <div style="margin-top:10px" class="">
				<img border="0" align="left" class="imresponsive" src="img/n3.jpg">			  
	 </div>
	 
						   
	<div class="photouploadstatus">
	        <div class="topupload2">
                   <div class="row">
                           <div class="col-sm-12">
								<div class="row gutter-10">
								     
                                       
                                      <div class="col-sm-2"> <input type="submit" autopostback="True" class="postbtn" id="ctl00_MainContent_rptPost_ctl00_btnReply" value="Like" name="ctl00$MainContent$rptPost$ctl00$btnReply"></div>
						
                                  
								       <div title="Coments" class="col-sm-2"><a href="#" data-toggle="modal" data-target="#commentsbox"> <button class="postbtn2"> Coments </button></a></div>
									   <div class="col-sm-2"> <button title="Share" class="postbtn2">    Share </button></div>
                                       <div class="col-sm-2"> <input type="submit" autopostback="True" class="postbtn" id="ctl00_MainContent_rptPost_ctl00_Button1" value="Edit" name="ctl00$MainContent$rptPost$ctl00$Button1"></div>
								 </div>
								 
							
									<div style="clear:both"></div>
								</div>
                       </div>
						   </div>
						   </div>
					  </div>
					    <!--news-feed-end-->

			</div>

			<div class="tab-pane" id="7fb">
				  Tab 4 Description 
			</div>

		  <div class="tab-pane" id="8fb">
				Tab 5
		  </div>

        </div>
	</div>
</div>
			<!--tab end-->
		 
			   <div style="clear:both"></div>
				</div>
			</div>
          <asp:Literal ID="lblFirstname" runat="server" visible="false"></asp:Literal>
         <asp:Label ID="lok1" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="lok2" runat="server" Text="" Visible="false"></asp:Label>

              <asp:HiddenField ID="hidArticleId" runat="server" />