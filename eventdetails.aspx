<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="eventdetails.aspx.cs" Inherits="eventdetails" %>
            <%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
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
                               <uc1:leftevent ID="leftevent1" runat="server"/>


		                </div>
		                  <div style="clear:both"></div>
                    </div>
	              </div>

                  <div class="boxsocial2">
		                 <div class="boxproe">
                                 <div class="eventdetailsban" style="background-color:#222">
                                     <img src="<%=lblimage.Text%>" class="" style="width:100%; height:150px">
                                 </div>
                                <div class="calenderevents">
                                    <div class="leftcalender">
                                       
                                            <asp:Label ID="lblmonth" runat="server" Text=""></asp:Label><br>
                                    <asp:Label ID="lblDay" runat="server" Text=""></asp:Label>

                                    </div>
                                    <div class="titlenamecal" style=""> <asp:Label ID="lblEventName" runat="server" Text=""></asp:Label> </div>
                                    <div style="clear:both"></div>
                                </div>
                           
                                  <div class="aboutwrap" style="padding-left:10px; margin-top:28px">
                                      <div class="row">
                                       <%--   <div class="col-sm-5">Hosted by  </div>--%>
                                          <div class="col-sm-12">
                                               <div class="col-sm-4  col-xs-4">
                                                   <%--<select style="width:82px; background-color:#333366; color:#ffffff" class="postbtn" id="ctl00_MainContent_ddlPostType" name="ctl00$MainContent$ddlPostType">--%>
	                                                   <button type="submit" runat="server" id="btnLogin" class="postbtn"  onServerClick="btnLogin_Click">
					                                
                                                           <asp:Label ID="lblIntersted" runat="server" Text="Interested"></asp:Label>
					                           </button>

<%--                                                    </select>--%>
                                               </div>
                                               <div class="col-sm-4  col-xs-3">
                                                  <button type="submit" runat="server" id="Button1" class="postbtn"  onServerClick="btnLogin1_Click">
					                             <asp:Label ID="LblGoing" runat="server" Text="Going"></asp:Label>
					                           </button>
                                               </div>
                                               <div class="col-sm-4  col-xs-5">
                                                   <button class="postbtn">Invite Friends</button>
                                               </div>
                                          </div>
                                      <div style="clear:both"></div>
                                      </div>
                                  </div>
                             <div style="clear:both"></div>
                         </div>

                         <!--Date events-start-->
                          <div class="boxproe">
                              <div class="col-sm-5">
                                <p><span class="glyphicon glyphicon-time"></span> <asp:Label ID="lblDate" runat="server" Text=""></asp:Label>     <asp:Label ID="lblTime" runat="server" Text=""></asp:Label></p>
                                <p><span class="glyphicon glyphicon-map-marker"></span> <asp:Label ID="lblLocation1" runat="server" Text=""></asp:Label></p>
                               </div>
                                <div class="col-sm-7">
                                    <div class="row">
                              <div class="guestSwrap" style="background-color:#f1f1f1; padding:5px">
                                         <p>GUESTS </p>
                                        <div style="">
                                            <div class="col-sm-4 col-xs-4">
                                                <a href="#" style="font-size:14px; color:#333333"><asp:Label ID="lblinterestedCount" runat="server" Text=""></asp:Label>
                                                <br>
                                                Interested
                                                    </a>
                                              </div>

                                             <div class="col-sm-4 col-xs-4">
                                                <a href="#" style="font-size:14px; color:#333333"><asp:Label ID="lblgoingCount" runat="server" Text=""></asp:Label>
                                                <br>
                                                Going
                                                    </a>
                                              </div>
                                             <div class="col-sm-4 col-xs-4">
                                                <a href="#" style="font-size:14px; color:#333333">
                                                <br>
                                                Invited
                                                    </a>
                                              </div>
                                        </div>
                                  <div style="clear:both"></div>
                                  </div>
                              </div>
                                    </div>
                              <div style="clear:both"></div>
                          </div>
                         <!--Date events-start-->

                        <!--About description start-->
                          <div class="boxproe">
                             <div class="aboutwrap">
                               <div class="row">

				              <div class="col-sm-12 text-right">
								        <ul class="nav nav-tabs tabcssfollowers">
                                              <li class="menumfollow active"><a data-toggle="tab" href="#about" aria-expanded="true">About</a>
					                         </li>
                                              <li class="menumfollow"><a data-toggle="tab" href="#descevent" aria-expanded="true">Description</a>
					                         </li>
                                            
					                  </ul>
								</div>
                             
							<div style="clear:both"></div>
                           </div>
		                </div>
                          
                      <div class="" id="exTab2">	
                       <div class="tab-content tabcontents">
	   		                <div style="" id="about" class="tab-pane active">
                                   <div class="">
                                       <strong>Event Name:</strong>  <asp:Label ID="lblEventName1" runat="server" Text=""></asp:Label><br>
                                        <strong> Date:</strong><asp:Label ID="lblDate1" runat="server" Text=""></asp:Label><br>
                                        <strong>Location:</strong> <asp:Label ID="lblLocation" runat="server" Text=""></asp:Label><br>
                                   </div>
                                   <br />
                               
                                  
                             </div>

                            <div style="" id="descevent" class="tab-pane">
                                   <div class="">
                                        <strong>Event Name:</strong>  <asp:Label ID="lblEventName2" runat="server" Text=""></asp:Label><br>
                                        <strong> Date:</strong><asp:Label ID="lblDate2" runat="server" Text=""></asp:Label><br>
                                            <strong>Location:</strong> <asp:Label ID="lblLocation2" runat="server" Text=""></asp:Label><br>
                                   </div>
                                   <p style="margin-top:8px">
                                     <a href="#">  <img border="0" src="<%=lblimage.Text%>"  class="" style="width:150px; height:130px; margin-right:10px" align="left"></a>
                                <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
                                       </p>
                             </div>
                           <div style="clear:both"> </div>

                        </div>

                       </div>

                     </div>
                       <!--About description end-->
                              <asp:Label ID="lblimage" runat="server" Text="" Visible="false"></asp:Label>

                    </div>
                       <div class="" style="display:none">

                                                <asp:DropDownList ID="ddlDate" runat="server" class="input_select13" style="margin-right:10px">
                                                    <asp:ListItem Value="-1">[Select DD]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                       <div class="" style="display:none">

                                                <asp:DropDownList ID="DdlMonth" runat="server"  class="input_select13" style="margin-right:10px">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
            </div>
           <!--event-detail page end-->
        </div>
  
</asp:Content>

