﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Music.aspx.cs" Inherits="Music" %>

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
		  <div class="search2">
                        <form action="" method="post">
                            <input type="text" aria-haspopup="true" aria-autocomplete="list" role="textbox" autocomplete="off" placeholder="Search" name="key" id="txtSearch" class="input_search">
                            
                            <div class="btn_search" id="btnSearch">
                                <div class="searchbtn2">
                                    <img border="0" src="img/search_btn.png" class="searchimg">
                                </div>
                            </div>
                        </form>
                        <div style="clear:both"></div>
            </div>
		</div>
		<div style="clear:both"></div>
	 </div>
	 </div>
	 
		  <div class="boxsocial2">
		            <div class="boxpro">
                          <div class="aboutwraptitle"><i class="fa fa-music" aria-hidden="true"></i>
 Music</div>
				     
      <!--music step slider start-->
                                  <div class="boxproetabevent2">
                                    <div class="eventstitle">Like Music</div>
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
                                             
											      <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md5.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>

                                                   <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md6.jpg"></a>
                                                           <h5><a href="#">Arafat Mohsin </a></h5>
                                                            <p class="fonteventtext">Boka Chad<br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md7.jpg"></a>
                                                           <h5><a href="#">Pritom feat</a></h5>
                                                            <p class="fonteventtext">Akash Bhora Josna <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md8.jpg"></a>
                                                           <h5><a href="#">Shapla Salique </a></h5>
                                                            <p class="fonteventtext">Achen Kothay <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->
                 
                                <div class="item">
                	                <div class="row gutter-10">
                                             
											      <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md5.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>

                                                   <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md6.jpg"></a>
                                                           <h5><a href="#">Arafat Mohsin </a></h5>
                                                            <p class="fonteventtext">Boka Chad<br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md7.jpg"></a>
                                                           <h5><a href="#">Pritom feat</a></h5>
                                                            <p class="fonteventtext">Akash Bhora Josna <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md8.jpg"></a>
                                                           <h5><a href="#">Shapla Salique </a></h5>
                                                            <p class="fonteventtext">Achen Kothay <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    
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
                                Teams
				              <div class="text-right" style="display:none">
								        <ul class="nav nav-tabs tabmusicwrap">
                                              <li class="menumfollow active"><a data-toggle="tab" href="#15e" aria-expanded="true">Teams</a>
					                         </li>
                                              <%--<li class="menumfollow"><a data-toggle="tab" href="#16e" aria-expanded="false">Athletes</a>
					                         </li>--%>
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
                                  <%--  <div class="eventstitle">Listen Later</div>--%>
                    
                         
                	                   <div class="row gutter-10">
                                             
											      <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md5.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>

                                                   <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md6.jpg"></a>
                                                           <h5><a href="#">Arafat Mohsin </a></h5>
                                                            <p class="fonteventtext">Boka Chad<br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md7.jpg"></a>
                                                           <h5><a href="#">Pritom feat</a></h5>
                                                            <p class="fonteventtext">Akash Bhora Josna <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md8.jpg"></a>
                                                           <h5><a href="#">Shapla Salique </a></h5>
                                                            <p class="fonteventtext">Achen Kothay <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->

                             </div>

                            <div style="display:none" id="16e" class="tab-pane">
                                   <!--music step slider start-->
                                  <div class="boxproetabevent">
                                 <%--   <div class="eventstitle">Listen Later</div>--%>
                                      <div id="myCarouse1" class="carousel slide">
                 
                                      <%--  <ol class="carousel-indicators">
                                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                                            <li data-target="#myCarousel" data-slide-to="1"></li>
                                            <li data-target="#myCarousel" data-slide-to="2"></li>
                                        </ol>--%>
                 
                                <!-- Carousel items -->
                                <div class="carousel-inner">
                    
                                <div class="item active">
                	                   <div class="row gutter-10">
                                             
											      <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md5.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>

                                                   <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md6.jpg"></a>
                                                           <h5><a href="#">Arafat Mohsin </a></h5>
                                                            <p class="fonteventtext">Boka Chad<br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md7.jpg"></a>
                                                           <h5><a href="#">Pritom feat</a></h5>
                                                            <p class="fonteventtext">Akash Bhora Josna <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md8.jpg"></a>
                                                           <h5><a href="#">Shapla Salique </a></h5>
                                                            <p class="fonteventtext">Achen Kothay <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->
                 
                                <div class="item">
                	                <div class="row gutter-10">
                                             
											      <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md5.jpg"></a>
                                                           <h5><a href="#">Saved The Best</a></h5>
                                                            <p class="fonteventtext">Miles <br>
                                                                     
                                                           </p>
							                         </div>

                                                   <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md6.jpg"></a>
                                                           <h5><a href="#">Arafat Mohsin </a></h5>
                                                            <p class="fonteventtext">Boka Chad<br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md7.jpg"></a>
                                                           <h5><a href="#">Pritom feat</a></h5>
                                                            <p class="fonteventtext">Akash Bhora Josna <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md8.jpg"></a>
                                                           <h5><a href="#">Shapla Salique </a></h5>
                                                            <p class="fonteventtext">Achen Kothay <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    
                                              </div><!--/row-fluid-->
                                </div><!--/item-->
                 
                 
                                </div><!--/carousel-inner-->
                 
                                <a class="left carousel-control" href="#myCarousel" data-slide="prev">‹</a>
                                <a class="right carousel-control" href="#myCarousel" data-slide="next">›</a>
                                </div><!--/myCarousel-->
                 
                        </div><!--/well-->   
                  <!--music step slider end-->
                            </div>


                            <div style="" id="17e" class="tab-pane" style="display:none">
                                  <div class="boxproe2">
                                  	 <div class="">
                                       <div class="eventstitle">Pop Music</div>
                                  	    <div class="row gutter-10">
                                             
							                         <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/ma1.jpg"></a>
                                                           <h5><a href="#">Boka Chad</a></h5>
                                                            <p class="fonteventtext">Arafat Mohsin  <br>
                                                                     
                                                           </p>
							                         </div>

                                                   <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md1.jpg"></a>
                                                           <h5><a href="#">Minar(2016)  </a></h5>
                                                            <p class="fonteventtext">Masud Rana<br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md3.jpg"></a>
                                                           <h5><a href="#">Shei Meyta(2016) </a></h5>
                                                            <p class="fonteventtext">Tahsan  <br>
                                                                     
                                                           </p>
							                         </div>
													 
                                                    <div class="col-sm-3 col-xs-6">
                                                          <a href="#"> <img class="imageeventsbooks" src="img/md4.jpg"></a>
                                                           <h5><a href="#">Local Bus</a></h5>
                                                            <p class="fonteventtext">Pritom feat<br>
                                                                     
                                                           </p>
							                         </div>

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
</asp:Content>

