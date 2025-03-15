<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="eventdefault.aspx.cs" Inherits="eventdefault" %>
   <%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <script language="Javascript" type="">
       <!--
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
            return false;

        return true;
    }
    //-->
    </script>
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
		        <div class="col-sm-11  col-xs-10">
                     <uc1:leftevent ID="leftevent1" runat="server"/>
		        </div>
		<div style="clear:both"></div>
            </div>
	 </div>
             <div class="boxsocial2">
		            <div class="boxproe">
				       <div class="aboutwrap">
                           <div class="row">

				              <div class="col-sm-12 text-right">
								        <ul class="nav nav-tabs tabcssfollowers">
                                              <li class="menumfollow active"><a data-toggle="tab" href="#15e" aria-expanded="true">Upcoming</a>
					                         </li>
                                              <li class="menumfollow" style="display:none"><a data-toggle="tab" href="#16e" aria-expanded="true">Invites</a>
					                         </li>
                                             <li class="menumfollow ">
					                         <a data-toggle="tab" href="#17e" aria-expanded="true">Hosting</a>
					                         </li>
					                           <li class="menumfollow"><a data-toggle="tab" href="#18e" aria-expanded="true">Calendar</a>
					                        </li>
                                             
					                       <!--  <li class="menumfollow"><a data-toggle="tab" href="#19e" aria-expanded="true">Subscribed</a>
					                        </li>   -->
                                             <li class="menumfollow"><a data-toggle="tab" href="#20p" aria-expanded="true">Past</a>
					                        </li>
                                       
                                              <li class="menumfollow"> <a data-target="#createevent" data-toggle="modal" href="#">+ Create</a>
					                        </li>
					                  </ul>
								</div>
                             
							<div style="clear:both"></div>
                           </div>
		                </div>
                     </div>
							
                    <div class="" id="exTab2">	
                       <div class="tab-content tabcontents">
	   		                <div style="" id="15e" class="tab-pane active">
                                       <div class="boxproe2">
                                  	    <div class="row gutter-10">
                                              <%--<div class="col-sm-12">
							                        <div style="text-align:center"> <img  class="imageevents" src="img/music.jpg"></div>
									                 <div class="fonttext"> No events coming up. Why not host your own?</div>
                                              </div>--%>
                                              
                                                                        <asp:Repeater ID="rptUpcamming" runat="server" Visible="" >
                                        <ItemTemplate>
										  
                                                    <div class="col-sm-12">
							                        <div style="text-align:center"> <a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"><asp:Image ID="Image1" runat="server" CssClass="imageevents"   ImageUrl='<%# Bind("P_Image", "{0}") %>'/></a></div>
									                 <div class="fonttext"><asp:Label ID="Label3" runat="server" Text='<%# Eval("P_Name") %>' Width=" "></asp:Label></div>
                                                               <div class="fonttext">Loacation: <asp:Label ID="Label5" runat="server" Text='<%# Eval("P_Location") %>' Width=" "></asp:Label></div>
                                                        </div>                                              

                                                                  
										</ItemTemplate>
                            </asp:Repeater>
                                       </div>
                                   </div>

                                     <div class="boxproe">
                                      
				                               <div class="aboutwrap">
                                                   <div class="row">

				                                      <div class="col-sm-12 text-right">
								                                <ul class="nav nav-tabs tabcssfollowers">
                                                                      <li class="menumfollow active"><a data-toggle="tab" href="#20e" aria-expanded="true">Events Popular Network</a>
					                                                 </li>
                                                                      <li class="menumfollow"><a data-toggle="tab" href="#30e" aria-expanded="true">Related Events History</a>
					                                                 </li>
                                                                     <li class="menumfollow ">
					                                                 <a data-toggle="tab" href="#35e" aria-expanded="true">Popular Events Nearby</a>

					                                          </ul>
								                        </div>
                             
							                        <div style="clear:both"></div>
                                                   </div>
		                                        </div>
                                        
                                               <div class="" id="exTab2">	
                                                      <div class="tab-content tabcontents">
	   		                                                <div style="" id="20e" class="tab-pane active">
                                                                 
                                          <div class="">
                                       <div class="eventstitle">Events Popular Network</div>
                                  	    <div class="row gutter-10">
                                             
							                        

                                              
                                                 <asp:Repeater ID="rptEvenpost" runat="server" Visible="" OnItemDataBound="RepeaterItemCreated">
                                        <ItemTemplate>
										   <div class="col-sm-4">
                                                    <div class="eventspopularbox">
                                                <asp:Image ID="Image1" runat="server" CssClass="imageeventspopular"   ImageUrl='<%# Bind("P_Image", "{0}") %>'/>

             
						                                     <div class=title_name" style=""><a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"> <asp:Label ID="Label2" runat="server" Text='<%# Eval("P_Name") %>' Width=" "></asp:Label></a></div>
                                                             Date: <%# string.Format("{0:dd MMM yyyy}", Eval("Event_Satrt_Date"))%> <br>
                                                           Loacation: <asp:Label ID="Label4" runat="server" Text='<%# Eval("P_Location") %>' Width=" "></asp:Label>·  <br>                                                              
                                                              <%--<div class="comment more"> <div><asp:Label ID="Label31" runat="server" Text='<%# Eval("P_Description") %>' Width=" "></asp:Label> </div></div>--%>
                                                     <div style="margin-bottom:10px; margin-top:15px">  
                                                 <a href="<%# "EditPostEvent.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank">
                                                    <div class="" style="float:left"><asp:Label ID="Button1" runat="server" Text="Edit" Width=" "  CssClass="postbtn" Style="padding:4px" Visible="false"></asp:Label></div>

                                                </a>
                                               <div class="" style="float:right;"> 
                                                      <asp:Button ID="deleteButton" runat="server" Text="Delete"  OnClick="btnReplyDelete" Visible="false" AutoPostBack="True" CommandArgument='<%#Eval("P_Id")%>' CssClass="postbtn" OnClientClick="return confirm('Are you sure you want to delete this Information?');" />

                                               </div>
                                                         <div style="clear:both"></div>
                                               </div>
                                                      <asp:Label ID="lblpostid" runat="server" Text='<%# Bind("P_Id") %>' Width=" " Visible="false"></asp:Label>
        
                                                      <asp:Label ID="lblUserid" runat="server" Text='<%# Bind("A_User_Id") %>' Width=" " Visible="false"></asp:Label>
                                                                
                                            </div>
                                           
                                           </div>

										</ItemTemplate>
                            </asp:Repeater>



                                                   
                                              </div>
                                       </div>
                                   </div>

                                   <div style="" id="30e" class="tab-pane">
                                                    <div class="">
                                      
                                         <div class="eventstitle"> Related To Your Events History </div>
                                  	    <div class="row gutter-10">
                                             
							                  <%--       <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>--%>

                                                                <asp:Repeater ID="rptReleted" runat="server">
                                        <ItemTemplate>
										    <div class="col-sm-4">
                                                     <div class="eventspopularbox">   
                                                 <a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"> <asp:Image ID="Image1" runat="server" CssClass="imageeventspopular"   ImageUrl='<%# Bind("P_Image", "{0}") %>'/></a>
                                                                                                                   <h5><a href="#"><asp:Label ID="Label7" runat="server" Text='<%# Bind("P_Name") %>' Width=" " Visible=""></asp:Label></a></h5>
                                                            <p class="fonteventtext">  <%# string.Format("{0:dd MMM yyyy}", Eval("Event_Satrt_Date"))%>  <asp:Label ID="Label6" runat="server" Text='<%# Bind("P_Location") %>' Width=" " Visible=""></asp:Label> <br>
                                                                       
                                                           </p>
                                                                                
        
                                                     
                                                                
                                                    </div>
                                           
                                                  </div>
                                       
										</ItemTemplate>
                            </asp:Repeater>




                                              </div>
                                     
                                         <div style="clear:both"></div>
                                   </div>
                                  </div>

                                  <div style="" id="35e" class="tab-pane">
                                       
                                      
                                          <div class="">
                                         <div class="eventstitle"> Popular Events </div>
                                  	    <div class="row gutter-10">
                                                       <asp:Repeater ID="rptPopular" runat="server">
                                        <ItemTemplate>
										    <div class="col-sm-4">
                                                 <div class="eventspopularbox">   
                                             <a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"> <asp:Image ID="Image1" runat="server" CssClass="imageeventspopular"   ImageUrl='<%# Bind("P_Image", "{0}") %>'/></a>
                                                                                                                   <h5><a href="#"><asp:Label ID="Label7" runat="server" Text='<%# Bind("P_Name") %>' Width=" " Visible=""></asp:Label></a></h5>
                                                            <p class="fonteventtext">  <%# string.Format("{0:dd MMM yyyy}", Eval("Event_Satrt_Date"))%>  <asp:Label ID="Label6" runat="server" Text='<%# Bind("P_Location") %>' Width=" " Visible=""></asp:Label> <br>
                                                                       
                                                           </p>
                                                                                
                                                     </div>
                                                  </div>
                                       
										</ItemTemplate>
                            </asp:Repeater>

<%--                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>--%>
                                                   
                                               


                                              </div>
                                
                                         <div style="clear:both"></div>
                                   </div>
                                  </div>
                               </div>
                             </div>

                                         <div style="clear:both"></div>
                           </div>



                             </div>

                            <div style="" id="16e" class="tab-pane">
                                  	  <div class="boxproe2">
                                  	    <div class="row gutter-10">
                                              <div class="col-sm-12">
							                        <div style="text-align:center"> <img class="imageevents" src="img/invite.jpg"></div>
									                 <div class="fonttext"> You're all caught up.</div>
                                              </div>
                                       </div>
                                   </div>

                                     <div class="boxproe">
                                      
				                               <div class="aboutwrap">
                                                   <div class="row">

				                                      <div class="col-sm-12 text-right">
								                                <ul class="nav nav-tabs tabcssfollowers">
                                                                      <li class="menumfollow active"><a data-toggle="tab" href="#20invite" aria-expanded="true">Events Popular Network</a>
					                                                 </li>
                                                                      <li class="menumfollow"><a data-toggle="tab" href="#30invite" aria-expanded="true">Related Events History</a>
					                                                 </li>
                                                                     <li class="menumfollow ">
					                                                 <a data-toggle="tab" href="#35invite" aria-expanded="true">Popular Events Nearby</a>
                                                                         </li>

					                                          </ul>
								                        </div>
                             
							                        <div style="clear:both"></div>
                                                   </div>
		                                        </div>
                                        
                                               <div class="" id="exTab2">	
                                                      <div class="tab-content tabcontents">
	   		                                                <div style="" id="20invite" class="tab-pane active">
                                                                 
                                          <div class="">
                                       <div class="eventstitle">Events Popular Network</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                              </div>
                                       </div>
                                   </div>

                                   <div style="" id="30invite" class="tab-pane">
                                                    <div class="">
                                      
                                         <div class="eventstitle"> Related To Your Events History</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                              </div>
                                     
                                         <div style="clear:both"></div>
                                   </div>
                                  </div>

                                  <div style="" id="35invite" class="tab-pane">
                                       
                                      
                                          <div class="">
                                         <div class="eventstitle"> Popular Events Nearby</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp4.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp5.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp6.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                              </div>
                                
                                         <div style="clear:both"></div>
                                   </div>
                                  </div>
                               </div>
                             </div>

                                         <div style="clear:both"></div>
                           </div>


                            </div>

                            <div style="" id="17e" class="tab-pane">
                                  <div class="boxproe2">
                                  	    <div class="row gutter-10">
                                              <div class="col-sm-12">
							                        <div style="text-align:center"> <img class="imageevents" src="img/host.jpg"></div>
									                 <div class="fonttext"> Have friends over or plan a night out.
                                                          <a data-target="#createevent" data-toggle="modal" href="#">Create Events</a>
									                 </div>
                                              </div>
                                       </div>
                                   </div>

                                     <div class="boxproe">
                                      
				                               <div class="aboutwrap">
                                                   <div class="row">

				                                      <div class="col-sm-12 text-right">
								                                <ul class="nav nav-tabs tabcssfollowers">
                                                                      <li class="menumfollow active"><a data-toggle="tab" href="#20host" aria-expanded="true">Events Popular Network</a>
					                                                 </li>
                                                                      <li class="menumfollow"><a data-toggle="tab" href="#30host" aria-expanded="true">Related Events History</a>
					                                                 </li>
                                                                     <li class="menumfollow ">
					                                                 <a data-toggle="tab" href="#35host" aria-expanded="true">Popular Events Nearby</a>
                                                                         </li>

					                                          </ul>
								                        </div>
                             
							                        <div style="clear:both"></div>
                                                   </div>
		                                        </div>
                                        
                                               <div class="" id="exTab2">	
                                                      <div class="tab-content tabcontents">
	   		                                                <div style="" id="20host" class="tab-pane active">
                                                                 
                                          <div class="">
                                       <div class="eventstitle">Events Popular Network</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                              </div>
                                       </div>
                                   </div>

                                   <div style="" id="30host" class="tab-pane">
                                                    <div class="">
                                      
                                         <div class="eventstitle"> Related To Your Events History</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                              </div>
                                     
                                         <div style="clear:both"></div>
                                   </div>
                                  </div>

                                  <div style="" id="35host" class="tab-pane">
                                       
                                      
                                          <div class="">
                                         <div class="eventstitle"> Popular Events Nearby</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp2.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp3.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp4.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                                     <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp5.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>
                                                    <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/pp6.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>

                                              </div>
                                
                                         <div style="clear:both"></div>
                                   </div>
                                  </div>
                               </div>
                             </div>

                                         <div style="clear:both"></div>
                           </div>
                          
                            </div>

                             <div style="" id="18e" class="tab-pane">

                               <%--   Calender hobe--%>
                                   <div class="boxproe2">
                                              <div class="">
                                                  <div class="row gutter-10">
							                 <%--       <div class="col-sm-2" style="height:150px">
                                                         <img src="img/p1.jpg" style="width:100%; height:70px" style="margin-top:10px">
                                                         <div class="fonttext" style="padding:10px; border:2px solid #cc33cc; text-align:center"> January <br>12</div>
							                        </div>--%>
                                                                        <asp:Repeater ID="rptCalendar" runat="server" OnItemDataBound="rptFrndCalendar_ItemDataBound">
                                        <ItemTemplate>
									
                                                  <div style="margin-top:0px">    
                                            <div class="fonttext" style="padding:10px; border:1px solid #cc33cc; text-align:center; background-color:#d0d0d0"> <asp:Label ID="Label8" runat="server" Text='<%# Bind("MonthYear1") %>' Width=" " Visible=""></asp:Label>  

                                            </div>
                                                <div style="clear:both"></div>
                                                    <asp:Label ID="lblMonthYear" runat="server" Text='<%# Bind("MonthYear") %>' Width=" "  Visible="false"></asp:Label>                                                          
                                                         <div class="row gutter-10">
                                               <asp:Repeater ID="rptdaydate" runat="server" OnItemDataBound="rptdaydate_ItemDataBound">
                                                <ItemTemplate>
                                             
                                                       
                                                 <div class="col-sm-2" style="min-height:50px">
                                                                 <asp:Label ID="lbldate" runat="server" Text='<%# Bind("date") %>' Width=" "  Visible="false"></asp:Label>   
        
                                                          <div class="fonttext" style="padding:10px; min-height:73px; border:1px solid #4080ff; text-align:center"> 
                                                                <div style="float:left"> <asp:Label ID="Label8" runat="server" Text='<%# Bind("WeekDayName") %>' Width=" " Visible=""></asp:Label> </div>
                                                                <div style="float:right"><asp:Label ID="Label9" runat="server" Text='<%# Bind("Day") %>' Width=" " Visible=""></asp:Label>  </div>
                                                              <div style="clear:both"> </div>
                                                                          
                                 <asp:Repeater ID="rptFrndList" runat="server" OnItemDataBound="rptFrndList_ItemDataBound">
                                        <ItemTemplate>
										 <div style="float:left; margin-right:2px">
                                                  <asp:Label ID="lblProfileName" runat="server" Text='<%# Bind("First_Name") %>' Width=" "  Visible="false"></asp:Label>   
                                             
                                             <a href="<%#"frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>" target="_blank"> <asp:Image ID="Image1" runat="server" CssClass="" style="margin-top:10px; width:13px; height:13px"  ImageUrl='<%# Bind("Profile_Image", "{0}") %>'/></a>
                                           
                                                  </div>
                                       
										</ItemTemplate>
                            </asp:Repeater>

                                                          </div>

                                                      </div>



                                                </ItemTemplate>
                                            </asp:Repeater>
                                                                  </div>
                                                      <div style="clear:both"></div>
                                                   </div>

                                       
										</ItemTemplate>
                            </asp:Repeater>

                            </div>
                               <div style="clear:both"> </div>
                                       </div>
                                   </div>
                       
                            </div>
                             <div style="" id="19e" class="tab-pane">
                                 <div class="boxproe2">
                                  	    <div class="row gutter-10">
                                              <div class="col-sm-12">
							                        <div style="text-align:center"> <img src="img/subscribe.jpg" class="imageevents"></div>
									                 <div class="fonttext"> Have friends over or plan a night out.
                                                       
									                 </div>
                                              </div>
                                       </div>
                                   </div>
                             
                            </div>

                            <div style="" id="20p" class="tab-pane">
                                <!--step start1-->
                             <div class="boxproetabevent">
                                  	    
                                            <div class="titleheadpast">
						                            
							                            <span style="font-size:15px">Past Events </span>
                                                  
						                          	<div style="clear:both"></div>
                                                </div>
                                                 

                                 
                                                 <asp:Repeater ID="rptPastevent" runat="server">
                                        <ItemTemplate>
										  <div class="eventbox">
                                                           <div class="row gutter-10">
                                                            <div class="col-sm-3">
                                                   
                                             <a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"> <asp:Image ID="Image1" runat="server" CssClass="imgpast"   ImageUrl='<%# Bind("P_Image", "{0}") %>'/></a>
                                                           </div>
             
						                                     <div class="col-sm-9">
                                                                     <%# string.Format("{0:dd MMM yyyy}", Eval("Event_Satrt_Date"))%> <br>
                                                                   <a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"">   <asp:Label ID="Label6" runat="server" Text='<%# Bind("P_Name") %>' Width=" " Visible=""></asp:Label></a> <br>
                                                                
                                                            </div> 
                                           
                                                  </div>
                                                    </div>
										</ItemTemplate>
                            </asp:Repeater>
                                    <div style="clear:both"></div>
                                   </div>
                  
                                  <!--step end2-->

                            </div>


                          
                         </div>


                   </div>



		    	 <div style="clear:both"></div>
						
				  
             </div>
       </div> 
     </div>

    
                                       <!-- Create Events start -->
                                              <div class="modal fade" id="createevent" role="dialog">
                                                <div class="modal-dialog createeventpopup">
    
                                                  <!-- Modal content-->
                                                  <div class="modal-content modelcontentpop">
                                                    <div class="modal-header">
                                                        <div class="row">
                                                        <div class="col-sm-11">
                                                            <ul class="nav nav-tabs menucreateevent">
                                                                      <li class="menumfollow active"><a aria-expanded="true" href="#30c" data-toggle="tab">Create Private Event</a>
					                                                 </li>
                                                                      <li class="menumfollow"><a aria-expanded="true" href="#31c" data-toggle="tab">Create Public Event</a>
					                                                 </li>
                                                            </ul>
                                                        </div>


                                                        <div class="col-sm-1"> 

                                                               <button type="button" class="close" data-dismiss="modal">&times;</button>

                                                        </div>
                                                   <%--   <h4 class="modal-title">Create Events</h4>--%>
                                                        <div style="clear:both"></div>
                                                     </div>
                                                    </div>


                                                    <div class="modal-body2">

                                                                <div class="" id="exTab2">	
                                                                      <div class="tab-content tabcontents">
	   		                                                                  <div style="" id="30c" class="tab-pane active">
                                                                                     <div class="boxeventtab">
                                                                                      <div class="col-sm-12 eventstitle">Create Private Event</div>
                                                                              <div class="row" style="margin-top:10px">
                                                                                 
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                  Event Photo
                                                                </div>
                                                              <div class="col-sm-8">
                                                                  <div class="row">
				                                             <%--      <div class="col-sm-6">  <a href="#"> <i class="glyphicon glyphicon-camera"> </i> Choose a Theme</a> </div>--%>
                                                                     <div class="col-sm-6"> <asp:FileUpload ID="file_upload" runat="server" AllowMultiple="true" style="/*width:54%;*/ font-size:12px; border: 0px solid #d0d0d0; margin-bottom:10px"/></div>
                                                                   </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                Event Name 
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Add short clear Name" id="txtEventName" runat="server">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                                                          <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                Event Type 
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <asp:DropDownList ID="ddlEventType" runat="server"  class="input_text">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>


                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Location
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Include a place or address"   id="txtLocation" runat="server">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                   Date 
                                                                </div>
                                                              <div class="col-sm-8">
                                                                     <div class="">

                                                <asp:DropDownList ID="ddlDate" runat="server" class="input_select13" style="margin-right:10px">
                                                    <asp:ListItem Value="-1">[Select DD]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="">

                                                <asp:DropDownList ID="DdlMonth" runat="server"  class="input_select13" style="margin-right:10px">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="">

                                                <asp:DropDownList ID="ddlYear" runat="server"  class="input_select13">
                                                    <asp:ListItem Value="-1">[Select YYYY]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                              



                                                            <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Time
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Include a place or address"   id="txtTime" runat="server">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                            <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Duration
                                                                </div>
                                                              <div class="col-sm-8">
				                                                  <asp:TextBox ID="txtDuration" runat="server" class="input_text" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>



                                                          <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Description
                                                                </div>
                                                              <div class="col-sm-8">
				                                                     <textarea class="textareatyping" placeholder="Tell people more about the event" id="txtdes" runat="server"></textarea>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="checkbox" name="checkbox" value="checkbox">  Guests can invite friends
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>
                                                            <div class="modal-footer">
                                                                      <button type="submit" runat="server" id="btnLogin" class="btn btn-default savebtn"  onServerClick="btnLogin_Click">
					                              Post
					                           </button>
                                                                       <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button>
                                                           </div>
                                                               <div style="clear:both"></div>
                                                  <div style="clear:both"></div>


                                                   </div>
                                               </div>
                                                                            

                                                       <div style="" id="31c" class="tab-pane">
                                                                 <div class="boxeventtab" style="overflow-x:hidden; overflow-y:scroll;  height:290px">
                                                                                      <div class="col-sm-12 eventstitle">Create Public Event</div>
                                                                              <div class="row" style="margin-top:10px">
                                                                                 
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                  Event Photo
                                                                </div>
                                                              <div class="col-sm-8">
                                                                     <div style="background-color:#00ffff; height:125px; width:100%; color:#000000; text-align:center; padding-top:57px" class="photoupload">
                                                                        <a href="#"> <i class="glyphicon glyphicon-camera"> </i> Photo Upload</a>
                                                                     </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                Event Name
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Add short clear Name" id="inputboxbd">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Location
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Include a place or address"   id="inputboxbd">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Start 
                                                                </div>
                                                              <div class="col-sm-8">
                                                                    <div class="row gutter-10">
				                                                      <div class="col-sm-6">  <input type="text" class="input_text" name="key" placeholder="Date"></div>
                                                                      <div class="col-sm-6"><input type="text" class="input_text" name="key" placeholder="Time"></div>
                                                                    </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                      <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 End 
                                                                </div>
                                                              <div class="col-sm-8">
                                                                    <div class="row gutter-10">
				                                                      <div class="col-sm-6">  <input type="text" class="input_text" name="key" placeholder="Date"></div>
                                                                      <div class="col-sm-6"><input type="text" class="input_text" name="key" placeholder="Time"></div>
                                                                    </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                          <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Description
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <textarea class="textareatyping" placeholder="Tell people more about the event" id="asdgasd" runat="server"></textarea>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>
                                                            <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                Keyword
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Include a place or address"   id="inputboxbd">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>
                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="checkbox" name="checkbox" value="checkbox"> All posts must be approved by an admin
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>
                                           
                                                  
                                                  <div class="modal-footer">
                                                         <button type="submit" id="btncreate"  class="btn btn-default savebtn" >Create Public Event</button>
                                                      
                                                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button>
                                                    </div>
                                                               <div style="clear:both"></div>
                                                       </div>
 

                                                    </div>

                                                    
                                                    </div>
                                                       </div>
                                                         </div>
                                                  </div>
      
                                                </div>
                                              </div>
                              <!-- Create Events start -->
                 <!--model-edit-->
    <div id="editevent" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">×</button>
                        
                    </div>
                    <div class="modal-body">

                                        <div class="boxeventtab">
                                                                                      <div class="col-sm-12 eventstitle">Create Private Event</div>
                                                                              <div class="row" style="margin-top:10px">
                                                                                 
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                  Event Photo
                                                                </div>
                                                              <div class="col-sm-8">
                                                                  <div class="row">
                                                                      <asp:Image ID="Image1" runat="server"  Height="120px" Width="200px"/>
				                                             <%--      <div class="col-sm-6">  <a href="#"> <i class="glyphicon glyphicon-camera"> </i> Choose a Theme</a> </div>--%>
                                                                     <div class="col-sm-6"> <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" style="/*width:54%;*/ font-size:12px; border: 0px solid #d0d0d0; margin-bottom:10px"/></div>
                                                                   </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                Event Name 
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Add short clear Name" id="Text1" runat="server">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                                                          <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                Event Type 
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <asp:DropDownList ID="DropDownList1" runat="server"  class="input_text">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>


                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Location
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Include a place or address"   id="Text2" runat="server">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                   Date 
                                                                </div>
                                                              <div class="col-sm-8">
                                                                     <div class="">

                                                <asp:DropDownList ID="DropDownList2" runat="server" class="input_select13" style="margin-right:10px">
                                                    <asp:ListItem Value="-1">[Select DD]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="">

                                                <asp:DropDownList ID="DropDownList3" runat="server"  class="input_select13" style="margin-right:10px">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="">

                                                <asp:DropDownList ID="DropDownList4" runat="server"  class="input_select13">
                                                    <asp:ListItem Value="-1">[Select YYYY]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                              



                                                            <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Time
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="text" class="input_text" name="key" placeholder="Include a place or address"   id="Text3" runat="server">
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                            <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Duration
                                                                </div>
                                                              <div class="col-sm-8">
				                                                  <asp:TextBox ID="TextBox1" runat="server" class="input_text" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>



                                                          <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                 Description
                                                                </div>
                                                              <div class="col-sm-8">
				                                                     <textarea class="textareatyping" placeholder="Tell people more about the event" id="Textarea1" runat="server"></textarea>
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>

                                                         <div class="row" style="margin-top:10px">
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                
                                                                </div>
                                                              <div class="col-sm-8">
				                                                       <input type="checkbox" name="checkbox" value="checkbox">  Guests can invite friends
                                                               </div>
                                    
			                                                  </div>
				
	                                     	             </div>
                                                            <div class="modal-footer">
                                                                      <button type="submit" runat="server" id="Button2" class="btn btn-default savebtn"  onServerClick="btnLogin_Click">
					                              Post
					                           </button>
                                                                   <a href="eventdefault.aspx">    <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                                                           </div>
                                                               <div style="clear:both"></div>
                                                  <div style="clear:both"></div>


                                                   </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
    <!--model-end-->
                            <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
                             <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
      <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>

        <asp:HiddenField ID="hidArticleId" runat="server" />
    <asp:Label ID="lblfrndlist" runat="server" Text="" Visible="false"></asp:Label>

</asp:Content>

