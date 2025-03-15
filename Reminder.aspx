<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reminder.aspx.cs" Inherits="Reminder" %>
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
		          <%--<div class="search2">
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
		   
							
                    <div class="" id="exTab2">	
                       <div class="tab-content tabcontents">
	   		                <div style="" id="15e" class="tab-pane active">
                                      

                                     <div class="boxproe" style="margin-top:-2px">
                                      
				                               <div class="aboutwrap">
                                                   <div class="row">

				                                      <div class="col-sm-12 text-right">
								                                <ul class="nav nav-tabs tabcssfollowers">
                                                                      <li class="menumfollow active"><a data-toggle="tab" href="#20e" aria-expanded="true">Events </a>
					                                                 </li>
                                                                      <li class="menumfollow"><a data-toggle="tab" href="#30e" aria-expanded="true">Birth Day</a>
					                                                 </li>
                                                                   
					                                          </ul>
								                        </div>
                             
							                        <div style="clear:both"></div>
                                                   </div>
		                                        </div>
                                        
                                               <div class="" id="exTab2">	
                                                      <div class="tab-content tabcontents">
	   		                                                <div style="" id="20e" class="tab-pane active">
                                                                 
                                          <div class="">
                                       <div class="eventstitle">Event</div>
                                  	    <div class="row gutter-10">
                                             
							                        

                                              
                                                 <asp:Repeater ID="rptEvenpost" runat="server" Visible="" OnItemDataBound="RepeaterItemCreated">
                                        <ItemTemplate>
										   <div class="col-sm-4">
                                                    <div class="eventspopularbox">
                                                <asp:Image ID="Image1" runat="server" CssClass="imageeventspopular"   ImageUrl='<%# Bind("P_Image", "{0}") %>'/>

             
						                                     <div class=title_name" style="height:36px"><a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"> <asp:Label ID="Label2" runat="server" Text='<%# Eval("P_Name") %>' Width=" "></asp:Label></a></div>
                                                             Date: <%# string.Format("{0:dd MMM yyyy}", Eval("Event_Satrt_Date"))%> <br>
                                                           Loacation: <asp:Label ID="Label4" runat="server" Text='<%# Eval("P_Location") %>' Width=" "></asp:Label>·  <br>                                                              
                                                              <%--<div class="comment more"> <div><asp:Label ID="Label31" runat="server" Text='<%# Eval("P_Description") %>' Width=" "></asp:Label> </div></div>--%>
                                                     <div style="margin-bottom:10px; margin-top:15px">  
                                                 <a href="<%# "EditPostEvent.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank">
                                                   

                                                </a>
                                             
                                                    
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
                                      
                                         <div class="eventstitle"> Birth Day Event</div>
                                  	    <div class="row gutter-10">
                                             
							                  <%--       <div class="col-sm-4">
                                                          <a href="#"> <img class="imageeventspopular" src="img/music1.jpg"></a>
                                                           <h5><a href="#">Tech Meetup With Kawshar</a></h5>
                                                            <p class="fonteventtext">Sat Sep 24 · EMK Center<br>
                                                               Shafayatul is going<br>
                                                               <a href="#">Interested</a> ·   <a href="#">Going</a>          
                                                           </p>
							                         </div>--%>

                                                                <asp:Repeater ID="rptFrndCalendar" runat="server">
                                        <ItemTemplate>
										 <div class="col-sm-2" style="height:150px">
                                                      
                                             <a href="<%#"frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>" target="_blank"> <asp:Image ID="Image1" runat="server" CssClass="" style="margin-top:10px; width:100%; height:70px"  ImageUrl='<%# Bind("Profile_Image", "{0}") %>'/></a>
                                                                                                             
                                                                                
        
                                                          <div class="fonttext" style="padding:10px; border:2px solid #cc33cc; text-align:center"> <asp:Label ID="Label8" runat="server" Text='<%# Bind("dob_Month_Name") %>' Width=" " Visible=""></asp:Label> <br><asp:Label ID="Label9" runat="server" Text='<%# Bind("dob_Day") %>' Width=" " Visible=""></asp:Label></div>
                                                                
                                         
                                           
                                                  </div>
                                       
										</ItemTemplate>
                            </asp:Repeater>



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
									
                                                  <div style="margin-top:15px">    
                                            <div class="fonttext" style="padding:10px; border:1px solid #cc33cc; text-align:center"> <asp:Label ID="Label8" runat="server" Text='<%# Bind("MonthYear1") %>' Width=" " Visible=""></asp:Label>  

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
             </div>
     </div>
    
                              <!-- Create Events start -->
                 <!--model-edit-->

                            
    <!--model-end-->
                            <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
                             <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
      <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>

        <asp:HiddenField ID="hidArticleId" runat="server" />
    <asp:Label ID="lblfrndlist" runat="server" Text="" Visible="false"></asp:Label>

</asp:Content>

