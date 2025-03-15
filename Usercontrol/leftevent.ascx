<%@ Control Language="C#" AutoEventWireup="true" CodeFile="leftevent.ascx.cs" Inherits="Usercontrol_leftevent" %>

	   <div class="col-sm-3">
	                <div style="height:4px"></div>
	      <div class="boxsocial1">
    
		  		<div class="scrollboxhide1"></div>
	            <div class="scrolfirstbox">
				   	<div class="boxsmall">
					   <div class="headtitle">
					      <div class="row">  
						       <div class="col-sm-8">Upcoming Birthdays</div>
						       <div class="col-sm-4"><a href="#" class="textdecorationsta">See All</a></div>
					      </div>
							
					   </div>
                         
					   <div class="middlebox">
					         <div class="row gutter-10" style="margin-right:0px">

                                  <asp:Repeater ID="rptFrndCalendar" runat="server">
                                        <ItemTemplate>
										 <div class="col-sm-2" style="margin-bottom:8px">
                                                      
                                             <a href="<%#"frndpage.aspx?ID=" +blog.Encrypt(Eval("IID").ToString()) %>" target="_blank"> <asp:Image ID="Image1" runat="server" CssClass="upcomingphoto" style=""  ImageUrl='<%# Bind("Profile_Image", "../{0}") %>'/></a>
                                                                                                             
                                                  </div>
                                       
										</ItemTemplate>
                            </asp:Repeater>

							  
							 </div>
							 
					   </div>
					   
					</div>
					
					 	<div class="boxsmall">
					   <div class="headtitle">
					      <div class="row">  
						       <div class="col-sm-8">upcoming events Near you</div>
						       <div class="col-sm-4"><a href="#" class="textdecorationsta">See More</a></div>
					      </div>
							
					   </div>
					   <div class="middlebox">
                           <div class="row">
                              <asp:Repeater ID="rptReleted" runat="server">
                                        <ItemTemplate>
							 <div class="profileimg" style="padding-bottom:8px">
							
                                  <asp:Image ID="Image1" runat="server" CssClass="imgprofileevents"   ImageUrl='<%# Bind("P_Image", "../{0}") %>' align="left"/>
								  <p style="margin-left:10px; font-size:14px">
                                   <a href="<%#"eventdetails.aspx?ID=" +blog.Encrypt(Eval("P_Id").ToString()) %>" target="_blank"> <asp:Label ID="Label2" runat="server" Text='<%# Eval("P_Name") %>' Width=" "></asp:Label></a><br>
                                       </p>   <div style="clear:both"> </div>
							    </div>
                                            </ItemTemplate>
                               </asp:Repeater>
                               
						</div>
					   </div>
					   
					</div>

                     <div class="boxsmall">
					   <div class="headtitle">
					      <div class="row">  
						       <div class="col-sm-8">Upcoming Events</div>
						       <div class="col-sm-4"><a href="#" class="textdecorationsta">See All</a></div>
					      </div>
							
					   </div>
                         
					  <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							    বিজ্ঞান অলিম্পিয়াডে বাংলাদেশের ছয় পদক
                               ইন্দোনেশিয়ার বালিতে ১৩তম আন্তর্জাতিক জুনিয়র সায়েন্স অলিম্পিয়াডে তিনটি রুপা ও তিনটি ব্রোঞ্জ পদক পেয়েছে বাংলাদেশ দল।
			     	   </div>
							 
					   </div>

                      <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							   নোবেল শান্তি পুরস্কার ২০১৬ ও ১৯৭১
                              কলম্বিয়ার প্রেসিডেন্ট হুয়ান ম্যানুয়েল সান্তোসকে এবার ২০১৬ সালের নোবেল শান্তি পুরস্কারে ভূষিত করা হবে সে খবর তো সুইডিশ নোবেল একাডেমি অক্টোবর মাসেই ঘোষণা দিয়েছে। 
			     	        </div>
							 
					   </div>
                          <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							   বিপিএলের প্রাইজমানি কতো ছিলো জানেন?
                                   শুক্রবার (৯ ডিসেম্বর) বিপিএলের চতুর্থ আসরের ফাইনালে ড্যারেন স্যামির রাজশাহী কিংসকে ৫৬ রানে হারায় ঢাকা  ডায়নামাইটস। তবে এটি ঢাকার প্রথম শিরোপা জয় না। 
			     	        </div>
							 
					   </div>
                           <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							  আন্তর্জাতিক বাজারে আবারও দাম কমেছে স্বর্ণ ও রুপার
আন্তর্জাতিক বাজারে দাম কমেছে স্বর্ণ ও রুপার। আগের দিন পণ্য দুটির দাম কমলেও ডলারের বিনিময় হার বৃদ্ধি ও ইউরোপের কেন্দ্রীয় ব্যাংকের (ইসিবি) বন্ড ক্রয় কার্যক্রম সংকোচনের সিদ্ধান্ত ঘোষণার 
			     	        </div> 
					   </div>

                           <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							 বদলে গেলো বিপিএল ফাইনালের সময়সূচী
বাংলাদেশ প্রিমিয়ার লীগ (বিপিএল) টুয়েন্টি টুয়েন্টি ক্রিকেটের চতুর্থ আসরের ফাইনালে আগামীকাল মুখোমুখি হবে ঢাকা ডায়নামাইটস ও রাজশাহী কিংস।
			     	        </div> 
					   </div>

                           <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							ইন্দোনেশিয়ায় ভূমিকম্পে নিহত ৯৭
আচেহ প্রদেশের পিদি জায়া জেলার মিরুউদু শহরে ভূমিকম্পে রাস্তায় সৃষ্ট গভীর চিড়। গতকাল সেখানে ৬.৫ মাত্রার
			     	        </div> 
					   </div>

                       <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							“রোহিঙ্গাদের চিকিৎসা-খাদ্য দিয়ে সাহায্য করতে পারি, কিন্তু সীমান্ত খুলে দিতে পারি না”
মিয়ানমারের রাখাইন রাজ্যে রোহিঙ্গাদের উপর জাতিগত নিপীড়নের বিষয়ে প্রধানমন্ত্রী শেখ হাসিনা বলেছেন, 
			     	        </div> 
					   </div>
					   
                           <div class="middlebox" style="border-bottom:1px solid #d0d0d0; padding-bottom:5px">
					         <div class="row gutter-10" style="margin-right:0px">
							 বদলে গেলো বিপিএল ফাইনালের সময়সূচী
বাংলাদেশ প্রিমিয়ার লীগ (বিপিএল) টুয়েন্টি টুয়েন্টি ক্রিকেটের চতুর্থ আসরের ফাইনালে আগামীকাল মুখোমুখি হবে ঢাকা ডায়নামাইটস ও রাজশাহী কিংস।
			     	        </div> 
					   </div>

					</div>
				
					      
				</div>
		   </div>
	   </div>