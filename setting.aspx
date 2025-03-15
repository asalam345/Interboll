<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="setting.aspx.cs" Inherits="setting" %>
         <%@ Register Src="Usercontrol/search.ascx" TagName="leftevent" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <script>
        function toggleChevron(e) {
            $(e.target)
                .prev('.panel-heading')
                .find("i.indicator")
                .toggleClass('glyphicon-chevron-down glyphicon-chevron-up');
        }
        $('#accordion').on('hidden.bs.collapse', toggleChevron);
        $('#accordion').on('shown.bs.collapse', toggleChevron);
    </script>


    <style type="text/css">
         .panel-default {
  border:0px!important;
}
        .panel-heading {
  border-bottom: 1px solid transparent;
  border-radius: 0 !important;
  font-size: 14px;
  padding: 1px 10px 3px!important;
}
        .panel-heading {
  border-bottom: 1px solid transparent;
  border-radius: 0 !important;
  padding: 4px 11px;
    font-size:14px;
}
 .panel-default > .panel-heading {
  background-color: #fff;
  border-color: #ddd;
  border-radius: 0;
  color: #333;
    font-size:14px;
}
 .panel-body {
  background-color: #f2f2f2;
  padding: 11px;
  font-size:14px;
}
 .panel-title {
  color: inherit;
  font-size: 14px;
  margin-bottom: 0;
  margin-top: 0;
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
		<a href="Default.aspx"><img src="img/interboll.png" class="oiiogo"></a>
		</div>
		<div class="col-sm-11 col-xs-10">
		   <uc1:leftevent ID="leftevent1" runat="server"/>
		</div>
		<div style="clear:both"></div>
	 </div>
	 </div>


           <div class="boxsocial2">
               <!--tab start-->
               <div class="boxproe">
				       <div class="aboutwrap">
                           <div class="row">

				              <div class="col-sm-12 text-right">
								        <ul class="nav nav-tabs tabcssfollowers">
                                              <li class="menumfollow active"><a aria-expanded="false" href="#setting1" data-toggle="tab">About</a>
					                         </li>
                                            <!--  <li class="menumfollow"><a aria-expanded="false" href="#setting2" data-toggle="tab">Privacy & Policy</a>
					                         </li>-->
                                           
					                           <li class="menumfollow"><a aria-expanded="false" href="#setting3" data-toggle="tab">Security </a>
					                        </li>
                                             
					                         <li class="menumfollow"><a aria-expanded="false" href="#setting4" data-toggle="tab">Blocking</a>
					                        </li>
                                              <li class="menumfollow"><a aria-expanded="false" href="#setting5" data-toggle="tab">Language</a>
					                        </li>
                                         <%-- <li class="menumfollow active"><a aria-expanded="true" href="#setting1" data-toggle="tab">Classic</a>
					                        </li>--%>
                                        <!--<li class="menumfollow"><a aria-expanded="false" href="#20e" data-toggle="tab">Text</a>
					                        </li>-->
                                             
					                  </ul>
								</div>
                             
							<div style="clear:both"></div>
                           </div>
		                </div>
                     </div>
                <!--tab end-->

                  <!--setting tab end-->
                  <div id="exTab2" class="">	
                       <div class="tab-content tabcontentsb">
	   		                <div class="tab-pane active" id="setting1">
                                    <!--General drop down setting wrap box start-->
		                              <div class="tab-content tabcontentsb">
                                    <div class="tab-panebbb" id="about_1bb" style="">
                                        <!--About start-->
                                        <div class="boxpro">
                                            <div class="aboutwraptitle">
                                                <div class="col-sm-1">
                                                    <a href="#">
                                                        <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
                                                </div>
                                                <div class="col-sm-7"><span style="font-size: 15px">About</span></div>
                                                <div style="clear: both"></div>
                                            </div>

                                            <div class="row" style="margin-top: 10px">
                                                <div class="col-sm-4">
                                                    <!-- required for floating -->
                                                    <!-- Nav tabs -->
                                                    <%--      <h5> Overview</h5>--%>
                                                    <ul class="nav nav-tabs tabs-left sideways">
                                                        <li class="active"><a href="#Profileb2" data-toggle="tab">Profile</a></li>

                                                        <li><a href="#workexperience" data-toggle="tab">Work Experience</a></li>
                                                        <li><a href="#Qualification" data-toggle="tab">Qualification</a></li>
                                                        <li><a href="#Livingplace" data-toggle="tab">Living Place</a></li>
                                                        <li><a href="#contactinfo" data-toggle="tab">Contact Info</a></li>
                                                        <li><a href="#relationships" data-toggle="tab">Relationships</a></li>
                                                        <li><a href="#aboutdetails" data-toggle="tab">About Your Details</a></li>
                                                        <li><a href="#Lifeeventb" data-toggle="tab">Personalisation</a></li>
                                                    </ul>



                                                </div>

                                                <div class="col-sm-8" style="border-left: 1px solid #d0d0d0">

                                                    <!-- Tab panes -->
                                                    <div class="tab-content">
                                                        <div class="tab-pane active" id="Profileb2">
                                                            <div class="row2">
                                                                <div class="rightaddress">
                                                                    <div class="col-sm-2">
                                                                        <a href="#">
                                                                            <img border="0" align="left" class="imgprofilenotifidefault2" src="img/img3.png"></a>
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        Name:
                                                                        <div>
                                                                            <asp:Label ID="lblProfileName1" runat="server" Text=""></asp:Label>
                                                                        </div>
                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>

                                                                <div class="rightaddress">
                                                                    <div class="col-sm-2">
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        Gender:
                                                                        <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>

                                                                <div class="rightaddress">
                                                                    <div class="col-sm-2">
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        Date of Birth:
                                                                        <asp:Label ID="lblDob" runat="server" Text=""></asp:Label>
                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>

                                                                <div class="rightaddress">
                                                                    <div class="col-sm-2">
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        About :
                                                                        <asp:Label ID="lblMyself" runat="server" Text=""></asp:Label>
                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>


                                                                <!--add work space start-->
                                                                <div class="addinfo"><a href="#" data-toggle="modal" data-target="#addprofile">Add Profile<asp:Label ID="lblAddProfile" runat="server" Text=""></asp:Label></a></div>
                                                                <!--add work space start-->

                                                            </div>
                                                        </div>

                                                        <div class="tab-pane tab_pane_about" id="workexperience">
                                                            <div class="row2">
                                                                <div class="rightaddress">

                                                                    <div class="col-sm-12">
                                                                        Occupation : 
										  <div>
                                              <asp:Label ID="lblOcupation" runat="server" Text=""></asp:Label>
                                                                        </div>
                                                                        <br />

                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>


                                                                <div class="rightaddress">

                                                                    <div class="col-sm-12">
                                                                        Present Working Status:
                                                                        <asp:Label ID="lblPresentWorkstatus" runat="server" Text=""></asp:Label>

                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>


                                                                <div class="rightaddress">

                                                                    <div class="col-sm-12">
                                                                        Past Working Status: 
                                                                        <asp:Label ID="lblPastExperiance" runat="server" Text=""></asp:Label>

                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>



                                                                <!--add work space start-->
                                                                <div class="addinfo"><a href="#" data-toggle="modal" data-target="#workexperience2">Edit Work Experience</a></div>
                                                                <!--add work space start-->




                                                            </div>
                                                        </div>

                                                        <div class="tab-pane tab_pane_about" id="Qualification">
                                                            <div class="rightaddress">
                                                                University :
										       <div>
                                                   <asp:Label ID="lblUniversity" runat="server" Text=""></asp:Label>
                                                                </div>

                                                                <div style="clear: both"></div>

                                                            </div>

                                                            <div class="rightaddress">
                                                                College :
                                                                <asp:Label ID="lblCollege" runat="server" Text=""></asp:Label>
                                                            </div>

                                                            <div class="rightaddress">
                                                                School :     
                                                                <asp:Label ID="lblSchool" runat="server" Text=""></asp:Label>
                                                            </div>

                                                            <div class="rightaddress">
                                                                About Qualification :     
                                                                <asp:Label ID="lblQualification" runat="server" Text=""></asp:Label>
                                                            </div>


                                                            <div class="addinfo"><a href="#" data-toggle="modal" data-target="#Qualifificationpopup">Add Qualification</a></div>
                                                        </div>


                                                        <div class="tab-pane tab_pane_about" id="Livingplace">
                                                            <div class="rightaddress">

                                                                <div style="display: none"></div>

                                                                <div style="clear: both"></div>
                                                            </div>

                                                            <div class="rightaddress">
                                                                Present Address : 
                                                                <asp:Label ID="lblpresentAddress" runat="server" Text=""></asp:Label>

                                                                <div style="clear: both"></div>
                                                            </div>

                                                            <div class="rightaddress">
                                                                Permanet  Address :    
                                                                <asp:Label ID="lblParmanentAddress" runat="server" Text=""></asp:Label>

                                                                <div style="clear: both"></div>
                                                            </div>

                                                            <div class="rightaddress">
                                                                Country :    
                                                                <asp:Label ID="lblCountry" runat="server" Text=""></asp:Label>

                                                                <div style="clear: both"></div>
                                                            </div>
                                                            <!--add work space start-->
                                                            <div class="addinfo"><a href="#" data-toggle="modal" data-target="#Livingplacepopup">Add Living Place</a></div>
                                                            <!--add work space start-->


                                                        </div>


                                                        <div class="tab-pane tab_pane_about" id="contactinfo">
                                                            <div class="rightaddress">
                                                                <div style="display: none">
                                                                    <asp:Label ID="lblRelesonship" runat="server" Text=""></asp:Label>
                                                                </div>
                                                                E-mail Address :<asp:Label ID="lbllogin" runat="server" Text=""></asp:Label>
                                                                <div style="clear: both"></div>
                                                            </div>

                                                            <div class="rightaddress">
                                                                <div style="display: none">
                                                                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                                                                </div>
                                                                Contact Number:<asp:Label ID="lblContactNo" runat="server" Text=""></asp:Label>
                                                                <div style="clear: both"></div>
                                                            </div>
                                                            <div class="rightaddress">
                                                                <div style="display: none">
                                                                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                                                                </div>
                                                                Website Link:
                                                                <asp:Label ID="lblWebsite" runat="server" Text=""></asp:Label>
                                                                <div style="clear: both"></div>
                                                            </div>

                                                            <div class="addinfo"><a href="#" data-toggle="modal" data-target="#contactinfopopup">Add Contact Info</a></div>
                                                            <!--add work space start-->

                                                        </div>



                                                        <!--Relationship-->
                                                        <div class="tab-pane tab_pane_about" id="relationships">
                                                            <div class="row2">
                                                                <div class="rightaddress">
                                                                    <div class="col-sm-2">
                                                                        <a href="#">
                                                                            <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        RelationShip Status :   
                                                                        <asp:Label ID="lblRelation" runat="server" Text=""></asp:Label>

                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>

                                                                <div class="rightaddress">
                                                                    <div class="col-sm-2">
                                                                        <a href="#">
                                                                            <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
                                                                    </div>
                                                                    <div class="col-sm-10">
                                                                        Family Number:        
                                                                        <asp:Label ID="lblFamily" runat="server" Text=""></asp:Label>

                                                                    </div>
                                                                    <div style="clear: both"></div>
                                                                </div>

                                                                <!--add work space start-->
                                                                <div class="addinfo"><a href="#" data-toggle="modal" data-target="#relationshipspopup">Add Relationship</a></div>
                                                                <!--add work space start-->




                                                            </div>
                                                        </div>
                                                        <!--Relation ship end-->

                                                        <!--about your details start-->
                                                        <div class="tab-pane tab_pane_about" id="aboutdetails">
                                                            <div class="row2">
                                                                <div class="rightaddress">
                                                                    Favorite Sports : <asp:Label ID="lblSports" runat="server" Text=""></asp:Label>
										
										   <div style="clear: both"></div>
                                                                </div>
                                                                <div class="rightaddress">
                                                                    Favorite Hobby : <asp:Label ID="lblHobby" runat="server" Text=""></asp:Label>
										
										   <div style="clear: both"></div>
                                                                </div>
                                                                <div class="rightaddress">
                                                                    Favorite Food : <asp:Label ID="lblFabfood" runat="server" Text=""></asp:Label>
										
										   <div style="clear: both"></div>
                                                                </div>
                                                                <div class="rightaddress">
                                                                    Political View : <asp:Label ID="lblPoliticalView" runat="server" Text=""></asp:Label>
                                                                   
										
										   <div style="clear: both"></div>
                                                                </div>

                                                                <!--add work space start-->
                                                                <div class="addinfo"><a href="#" data-toggle="modal" data-target="#aboutdetailspopup">Add Your details Information</a></div>
                                                                <!--add work space start-->




                                                            </div>
                                                        </div>

                                                        <!--about your details end-->

                                                        <!--item1 start2-->
                                                        <div class="tab-pane tab_pane_about" id="Lifeeventb">
                                                            <div class="row2">
                                                                <%--  <div class="rightaddress">
									       <div class="col-sm-2"> 
										   <a href="#"> <img border="0" align="left" class="aboutimg" src="img/img3.png"></a>
										   </div>
										   <div class="col-sm-10">
										   Item information3
										 
										   </div>
										   <div style="clear:both"></div>
									  </div>--%>
                                                                <div class="rightaddress">
                                                                    System Icons:
                                                                </div>
                                                                <div class="rightaddress">
                                                                    Thems:
                                                                </div>
                                                                <div class="rightaddress">
                                                                    Wallpaper:
                                                                </div>
                                                                <div class="rightaddress">
                                                                    Clock:
                                                                </div>
                                                                <!--add work space start-->
                                                                <div class="addinfo"><a href="#" data-toggle="modal" data-target="#lifeeventpopup">Add Personalisation</a></div>
                                                                <!--add work space start-->

                                                            </div>
                                                        </div>
                                                        <!--item1 end-->


                                                    </div>

                                                </div>
                                                <div style="clear: both"></div>
                                            </div>


                                        </div>

                                        <!--about end-->

                                        <div style="clear: both"></div>

                                    </div>
                                  </div>

                                   <!--General drop down setting wrap boxend-->
                               </div>


                            <div class="tab-pane" id="setting2" style="">
                                   <!--Privacy drop down setting wrap box start-->
		                                    <div class="boxpro">
                      <div class="aboutwraptitle">
                               <i class="fa fa-film" aria-hidden="true"></i>  Privacy Settings and Tools
                       </div>

                  <!--Privacy drop down setting start-->
                 <div class="panel-group" id="accordion">
<%--  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
          Collapsible Group Item #1 
        </a><i class="indicator glyphicon glyphicon-chevron-down  pull-right"></i>
      </h4>
    </div>
    <div id="collapseOne" class="panel-collapse collapse in">
      <div class="panel-body">
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      </div>
    </div>
  </div>--%>
  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsepTwo" style="cursor:pointer" >
        Who can see my stuff?
    
           <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapsepTwo" class="panel-collapse collapse">
      <div class="panel-body">
         <div class="col-sm-4">Who?</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">
                     Who can see your future posts?
                     <p style="margin-top:10px">
                         You can manage the privacy of things you share by using the audience selector right where you post. This control remembers your selection so future posts will be shared with the same audience unless you change it.
                     </p>
                 </div>
               </div>

               <div class="row" style="margin-top:10px">
                  <div class="col-sm-12"><input name="Name"  class="input_text" type="text" style="height:50px"></div>
               </div>
              <br>
                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsepTwo" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>
        <div style="clear:both"></div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsepThree" style="cursor:pointer">
     
      Who can contact me?

             <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapsepThree" class="panel-collapse collapse">
         <div class="panel-body">
         <div class="col-sm-4"> Who can contact me?</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  Who can send you friend requests?<br>

                      <input type="radio" name="radio" value="radio">Everyone
                     </div>
               </div>


                 <p style="margin-top:10px">Note: Your username should include your authentic name. </p>
                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsepThree" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsepfour" style="cursor:pointer">
       Who can look me up?
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapsepfour" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Contact</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsepfour" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>

    </div>


  </div>



</div>

<!--Privacy drop down setting end-->


</div>
                                <!--privacy drop down setting wrap boxend-->

    </div>

                  <div class="tab-pane" id="setting3" style="">
                                 <!--Security drop down setting wrap box start-->
		                                    <div class="boxpro">
                      <div class="aboutwraptitle">
                               <i class="fa fa-film" aria-hidden="true"></i>  Security Settings
                       </div>

                  <!--Privacy drop down setting start-->
                 <div class="panel-group" id="accordion">
<%--  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
          Collapsible Group Item #1 
        </a><i class="indicator glyphicon glyphicon-chevron-down  pull-right"></i>
      </h4>
    </div>
    <div id="collapseOne" class="panel-collapse collapse in">
      <div class="panel-body">
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      </div>
    </div>
  </div>--%>
  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesTwo" style="cursor:pointer" >
      
      Login Password
    
           <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapsesTwo" class="panel-collapse collapse">
      <div class="panel-body">
         <div class="col-sm-4">  Login Password</div>
          <div class="col-sm-8">
           

                <div class="col-sm-12">
                                           <div class="col-sm-12">  
                                               <div class="row">                                             
                                              <div class="col-sm-5">Old Password:</div>     
                                                <div class="col-sm-7"> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"  placeholder="Old Password"></asp:TextBox>
                                                 </div>
                                                </div>
                                                <div class="row" style="margin-top:10px;"> 
                                                    <div class="col-sm-5">                                                               
                                                  New Password    
                                                        </div>  
                                                      <div class="col-sm-7"> <asp:TextBox ID="txtnewpass" runat="server" TextMode="Password"  placeholder="New Password"></asp:TextBox> </div>
                                                </div>
                                               <div class="message" style="color:#ff0000"> <asp:Label ID="lblMessege" runat="server" Text="" Visible="false"></asp:Label>  </div>
                                                </div>
                                            </div>

    



                                          <div class="row" style="margin-top: 10px">
                                                    <div class="col-sm-12">
                                                            <asp:LinkButton ID="btnLogin" class="btn btn-default savebtn" OnClick="btnLogin_Click" runat="server" Text="Save" Style="float:right"></asp:LinkButton>
                                                                                      <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesTwo" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                                                    </div>
                                           </div>
            
          </div>
      </div>
        <div style="clear:both"></div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesThree" style="cursor:pointer">
     
     Login Approvals

             <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapsesThree" class="panel-collapse collapse">
         <div class="panel-body">
         <div class="col-sm-4"> Login Approvals</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  Who can send you friend requests?<br>

                      <input type="radio" name="radio" value="radio">Everyone
                     </div>
               </div>


                 <p style="margin-top:10px">Note: Your username should include your authentic name. </p>
                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesThree" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesfour" style="cursor:pointer">
      Code Generator
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapsesfour" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Apps Password</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesfour" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>

    </div>

  </div>


   <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesfive" style="cursor:pointer">
         Public Key
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapsesfive" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Apps Password</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesfive" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>

    </div>

  </div>


   <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsessix" style="cursor:pointer">
        Your Trusted Contacts
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapsessix" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Apps Password</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsessix" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
            
          </div>
      </div>

    </div>

  </div>

                     
   <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesseven" style="cursor:pointer">
     Recognized Devices
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapsesseven" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Recognized Devices</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsesseven" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
            
          </div>
      </div>

    </div>

  </div>



</div>

<!--Privacy drop down setting end-->


</div>
      <!--Security drop down setting wrap boxend-->
                    </div>

                             <div class="tab-pane" id="setting4" style="">
                                     <!--Privacy drop down setting wrap box start-->
		                                    <div class="boxpro">
                      <div class="aboutwraptitle">
                               <i class="fa fa-film" aria-hidden="true"></i>  Blocking
                       </div>

                  <!--Blocking drop down setting start-->
                 <div class="panel-group" id="accordion">

  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsebTwo" style="cursor:pointer" >
      
        Who can see my stuff?
    
           <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapsebTwo" class="panel-collapse collapse">
          <div class="panel-body">
                             <div class="row gutter-10">
             <asp:Repeater ID="rptPost" runat="server" OnItemDataBound="RepeaterItemCreated" OnItemCommand="itemRepeater_ItemCreated">
                            <ItemTemplate>
                                <div class="col-sm-3 col-xs-4" style="margin-bottom:10px; text-align:center">
                                        <asp:Image ID="Image1" runat="server"  Width="100%" height="100px" CssClass="imresponsive" ImageUrl='<%# Bind("Profile_Image", "~/{0}") %>' />
                                <br />
                                      <div class="name truncate" style="font-size:12px; margin-top:7px"> <asp:Label ID="Label3" runat="server" Text='<%# Eval("First_Name") %>' Width=" "></asp:Label></div>
                           
                                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("bStatus") %>' Width=" " Visible="false"></asp:Label>
                                        <asp:Label ID="lblfId" runat="server" Text='<%# Eval("IID") %>' Width=" " Visible="false"></asp:Label>
                                      <asp:Button ID="Button2" runat="server" Text="Change"  CommandName="lokin" AutoPostBack="True" CommandArgument='<%#Eval("IID")%>' cssclass="postbtn2"/>
                               </div>

                                </ItemTemplate>
                                               
                           </asp:Repeater>

                          </div>
                                  <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsebTwo" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
         </div>

    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsebThree" style="cursor:pointer">
     
      Who can contact me?

             <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapsebThree" class="panel-collapse collapse">
         <div class="panel-body">
         <div class="col-sm-4"> Who can contact me?</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  Who can send you friend requests?<br>

                      <input type="radio" name="radio" value="radio">Everyone
                     </div>
               </div>
                 <p style="margin-top:10px">Note: Your username should include your authentic name. </p>
                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsebThree" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
          </div>
      </div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsebfour" style="cursor:pointer">
       Who can look me up?
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapsebfour" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Contact</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsebfour" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>

    </div>


  </div>



</div>

                 <!--Blocking drop down setting end-->


</div>
   <!--Blocking drop down setting wrap boxend-->
          </div>

                      <div class="tab-pane" id="setting5" style="">
                                 <div class="boxpro">
                      <div class="aboutwraptitle">
                               <i class="fa fa-film" aria-hidden="true"></i>  Language Setting
                       </div>
                                    <!--Blocking drop down setting start-->
                 <div class="panel-group" id="accordion">
<%--  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
          Collapsible Group Item #1 
        </a><i class="indicator glyphicon glyphicon-chevron-down  pull-right"></i>
      </h4>
    </div>
    <div id="collapseOne" class="panel-collapse collapse in">
      <div class="panel-body">
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      </div>
    </div>
  </div>--%>
  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapselTwo" style="cursor:pointer" >
      
      What language do you want to use Interboll in?
    
           <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapselTwo" class="panel-collapse collapse">
      <div class="panel-body">
         <div class="col-sm-4">Who?</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">
                   Show Interboll in this language.
                     <p style="margin-top:10px">
                         You can manage the privacy of things you share by using the audience selector right where you post. This control remembers your selection so future posts will be shared with the same audience unless you change it.
                     </p>
                 </div>
               </div>

               <div class="row" style="margin-top:10px">
                  <div class="col-sm-12"><input name="Name"  class="input_text" type="text" style="height:50px"></div>
               </div>
              <br>
                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapselTwo" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
             
             
            
          </div>
      </div>
        <div style="clear:both"></div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapselThree" style="cursor:pointer">
     
    News Feed Translation Preferences

             <a style="float:right"> <span>Edit</span>    </a>
      </h4>
    </div>
    <div id="collapselThree" class="panel-collapse collapse">
         <div class="panel-body">
         <div class="col-sm-4"> Who can contact me?</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  Who can send you friend requests?<br>

                      <input type="radio" name="radio" value="radio">Everyone
                     </div>
               </div>
                 <p style="margin-top:10px">Note: Your username should include your authentic name. </p>
                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapselThree" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
          </div>
      </div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapselfour" style="cursor:pointer">
      Multilingual Posts
      <a style="float:right"><span>Edit</span> </a>  
      </h4>
    </div>

    <div id="collapselfour" class="panel-collapse collapse">
    
           <div class="panel-body">
         <div class="col-sm-4">Contact</div>
          <div class="col-sm-8">
              <div class="row">
                 <div class="col-sm-12">  
                     Who can look you up using the email address you provided?<br>
                   <p>This applies to people who can't already see your email address.</p>
                      <input type="radio" name="radio" value="radio"> Every one
                   </div>
               </div>
                 <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapselfour" style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                 <a style="float:right"><button type="button" class="btn btn-default savebtn" data-dismiss="modal">Save Change</button></a>
             
            
          </div>
      </div>

    </div>


  </div>



</div>
                          </div>
 <!--Blocking drop down setting end-->
       </div>

       </div>
   </div>
                 <!--setting tab start-->

             

        <div style="clear:both"></div>

 </div>

</div>
</div>
    <!--model-start-->
            <!-- Modal -->
        <div class="modal fade" id="addprofile" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Add Profile</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Name
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" placeholder="" name="key" class="input_text" id="profileName" runat="server">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Gender
                                </div>
                                <div class="col-sm-8">
                                    <asp:DropDownList ID="ddlgender" runat="server" class="input_selectedit">
                                        <asp:ListItem Value="1"> Men</asp:ListItem>
                                        <asp:ListItem Value="2"> Women</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                            </div>

                        </div>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Date Of Birth
                                </div>
                                <div class="col-sm-8">
                                    <div class="row gutter-10">
                                        <div class="col-sm-4">
                                            <asp:DropDownList ID="ddlDate" runat="server" class="input_select13">
                                                <asp:ListItem Value="-1">[Select DD]</asp:ListItem>
                                            </asp:DropDownList>

                                        </div>
                                        <div class="col-sm-4">
                                            <asp:DropDownList ID="DdlMonth" runat="server" class="input_select13">
                                                <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-sm-4">

                                            <asp:DropDownList ID="ddlYear" runat="server" class="input_select13">
                                                <asp:ListItem Value="-1">[Select YYYY]</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    About Yourself
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing About Yourself...." id="txtP_Intro" runat="server" ></textarea>
                                </div>

                            </div>

                        </div>


                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button11" onserverclick="btnLoginProfile1_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!--add profile end-->

        <!-- Add occupation -->
        <div class="modal fade" id="workexperience2" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Add Work Experience</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Occupation
                                </div>
                                <div class="col-sm-8">
                                    <asp:DropDownList ID="ddlocupation" runat="server" class="input_selectedit">
                                        <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                        </div>



                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Present Working Status
                                </div>
                                <div class="col-sm-8">
                                    <%--<input type="text" class="input_text" name="key" placeholder=""  name="Email">--%>
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtPresentWorkingStatus" runat="server"></textarea>
                                </div>

                            </div>

                        </div>


                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Past Working Status
                                </div>
                                <div class="col-sm-8">
                                    <%--<input type="text" class="input_text" name="key" placeholder=""  name="Email">--%>
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtPastexperiance" runat="server"></textarea>
                                </div>

                            </div>

                        </div>


                    </div>

                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button1" onserverclick="btnLoginProfile2_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <!--occupation-->
        <!-- Qualifification start -->
        <div class="modal fade" id="Qualifificationpopup" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Qualification</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    University Name
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtUniversity" runat="server">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    College Name
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtCollegename" runat="server">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    School Name
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtSchoolname" runat="server">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    About Qualification
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtQualification" runat="server"></textarea>
                                </div>

                            </div>

                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button2" onserverclick="btnLoginProfile3_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!-- Qualifification end -->

        <!-- living start -->
        <div class="modal fade" id="Livingplacepopup" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Living Place</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Country
                                </div>
                                <div class="col-sm-8">
                                    <asp:DropDownList ID="ddlCountry" runat="server" class="input_selectedit">
                                        <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Present Address
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtpresentAddress" runat="server">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Permanent Address
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtparmanentAddress" runat="server">
                                </div>

                            </div>

                        </div>


                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button3" onserverclick="btnLoginProfile4_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!-- livibg end -->
        <!--Contact info start-->
        <div class="modal fade" id="contactinfopopup" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Contact Information</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px" style="display: none">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    E-mail Address
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtEmail" runat="server">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Contact Number
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtContactno" runat="server">
                                </div>

                            </div>

                        </div>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Website Link
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" id="txtWebsite" runat="server">
                                </div>

                            </div>

                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button4" onserverclick="btnLoginProfile5_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!--Contact info end-->

        <!--Relationship info start-->
        <div class="modal fade" id="relationshipspopup" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Relationship Information</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Relationship Status
                                </div>
                                <div class="col-sm-8">
                                    <asp:DropDownList ID="DDlMerial" runat="server" class="input_selectedit">
                                        <asp:ListItem Value="-1">[Select Status]</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Family Members
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing ..." id="txtFamily" runat="server"></textarea>
                                </div>

                            </div>

                        </div>

                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button5" onserverclick="btnLoginProfile6_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!--Relationship info end-->

        <!--About details info start-->
        <div class="modal fade" id="aboutdetailspopup" role="dialog">
            <div class="modal-dialog modal_editpopupabout">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">About details Your Information</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Favorite Sports
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtSports" runat="server"></textarea>
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Favorite Hobby
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtHobby" runat="server"></textarea>
                                </div>

                            </div>

                        </div>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Favorite Food
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtFavfoods" runat="server"></textarea>
                                </div>

                            </div>

                        </div>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Political View
                                </div>
                                <div class="col-sm-8">
                                    <textarea class="textareatyping" placeholder="Typing ...." id="txtPoliticalView" runat="server"></textarea>
                                </div>

                            </div>

                        </div>

                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button6" onserverclick="btnLoginProfile7_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!--About details info end-->



        <!--Lifeevents info start-->
        <div class="modal fade" id="lifeeventpopup" role="dialog">
            <div class="modal-dialog modal_editpopup">

                <!-- Modal content-->
                <div class="modal-content modelcontentpop">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">About Life event</h4>
                    </div>
                    <div class="modal-body2">
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    System Icons
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="" name="Email">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Themes
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="">
                                </div>

                            </div>

                        </div>

                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Wall Paper
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="">
                                </div>

                            </div>

                        </div>
                        <div class="row" style="margin-top: 10px">
                            <div class="col-sm-12">
                                <div class="col-sm-4">
                                    Clock
                                </div>
                                <div class="col-sm-8">
                                    <input type="text" class="input_text" name="key" placeholder="">
                                </div>

                            </div>

                        </div>


                    </div>
                    <div class="modal-footer">
                        <button type="submit" runat="server" id="Button7" onserverclick="btnLoginProfile8_Click" class="btn btn-default savebtn">Save</button>
                        <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
        <!--Life events info end-->
    <!--model-end-->
     <asp:Literal ID="lblFirstname" runat="server" Visible="false"></asp:Literal>
        <asp:Label ID="lok1" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="lok2" runat="server" Text="" Visible="false"></asp:Label>
       <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
       <asp:Label ID="Label2" runat="server" Text="" Visible="false"></asp:Label>

        <asp:HiddenField ID="hidArticleId" runat="server" />
</asp:Content>

