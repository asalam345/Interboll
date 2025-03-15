<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Profile.ascx.cs" Inherits="Usercontrol_Profile" %>


<div class="">
 
       <div class="boxpro2">
           <div class="titleinfo">Change  Profile Information</div>
                <div style="margin-top:8px" class="row">
                            <div class="col-sm-4">
                                Profile   Name
                           </div>
                     <div class="col-sm-8">
				          <input type="text" placeholder="" name="key" class="input_text" id="profileName" runat="server">
                     </div>

		         </div>

                    <div style="margin-top:8px" class="row">
                            <div class="col-sm-4">
                                Profile  Image
                           </div>
                     <div class="col-sm-8">
                         <div class="row">
                             <div class="col-sm-3">
				                 <asp:Image ID="profileImage" Width="60px" Height="50px" BorderColor="Blue" runat="server" />                                 
                                      <asp:Label ID="Label1" runat="server" Visible="false" Text=""></asp:Label>
                             </div>
                            <div class="col-sm-9">
                                 <asp:FileUpload ID="fileUpload1" runat="server" Style="" />
                              </div>
                           </div>
                     </div>

		         </div>


                    <div style="margin-top:8px" class="row">
                            <div class="col-sm-4">
                                Profile Image Status
                           </div>
                     <div class="col-sm-8">
				                 <asp:DropDownList ID="dlphotostat1" runat="server" class="input_text">
                                            <asp:ListItem Value="0">Yes</asp:ListItem>
                                            <asp:ListItem Value="1">No</asp:ListItem>
                                        </asp:DropDownList>
                     </div>

		         </div>


               <div style="margin-top:8px" class="row">
                            <div class="col-sm-4">
                                Cover Image
                           </div>
                     <div class="col-sm-8">
                         <div class="row">
                         <div class="col-sm-3">
				                 <asp:Image ID="CoverImage" Width="60px" Height="60px" BorderColor="Blue" runat="server" />                                 
                                        <asp:Label ID="Label2" runat="server" Visible="false" Text=""></asp:Label>
                        </div>
                         <div class="col-sm-3">
                                 <asp:FileUpload ID="fileUpload2" runat="server" Style="margin-top: 5px;" />
                         </div>
                     </div>
                   </div>
		         </div>


                    <div style="margin-top:8px" class="row">
                            <div class="col-sm-4">
                                Cover Image Status
                           </div>
                     <div class="col-sm-8">
				                 <asp:DropDownList ID="dlphotostat2" runat="server" class="input_text">
                                            <asp:ListItem Value="0">Yes</asp:ListItem>
                                            <asp:ListItem Value="1">No</asp:ListItem>
                                        </asp:DropDownList>
                     </div>

		         </div>


                 <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                              Gender
                           </div>
                     <div class="col-sm-8">
				                 <asp:DropDownList ID="ddlgender" runat="server" class="input_text2">
                                        <asp:ListItem Value="1"> Men</asp:ListItem>
                                        <asp:ListItem Value="2"> Women</asp:ListItem>
                                    </asp:DropDownList>
			   </div>
                     </div>

		  

            
                     <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                              DOB
                           </div>
                     <div class="col-sm-8">
				                    <div class="row">
                                     <div class="col-md-4">
                                         <asp:DropDownList ID="ddlDate" runat="server" class="input_select1">
                                                    <asp:ListItem Value="-1">[Select DD]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="col-md-4">

                                                <asp:DropDownList ID="DdlMonth" runat="server"  class="input_select1">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="col-md-4">

                                                <asp:DropDownList ID="ddlYear" runat="server"  class="input_select1">
                                                    <asp:ListItem Value="-1">[Select YYYY]</asp:ListItem>
                                                </asp:DropDownList>

                                           </div>
                                 </div>
                     </div>

		         </div>


                  <div style="margin-top:10px" class="row">
                            <div class="col-sm-0">
                              
                           </div>
                     <div class="col-sm-12">
				                
                           <button type="submit" runat="server" id="btnLogin" class="btn-primary" onServerClick="btnLogin_Click" style="background: #ff006e none repeat scroll 0 0;
    border: 0 none;
    color: #000000;
    font-size: 16px;
    font-weight:bold;
    padding: 0 4px;
    width: 100%;">
					Change Profile Information
					 </button>
                                   </div>
                     </div>

		  



           <div class="titlework">Personal Informatiom</div>
           <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                                  About Yourself
                           </div>
                     <div class="col-sm-8">
				            <textarea class="textareaboxsize" placeholder="Typing Personal Info...." id="txtP_Intro" runat="server"></textarea>
                     </div>

		 </div>

        <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                             Marital Status
                           </div>
                     <div class="col-sm-8">
				        
                                 <asp:DropDownList ID="DDlMerial" runat="server"  class="input_select1">
                                                    <asp:ListItem Value="-1">[Select Status]</asp:ListItem>
                                                </asp:DropDownList>

                     </div>
                                    
		 </div>

   

               <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                             About Family
                           </div>
                     <div class="col-sm-8">
				             <textarea class="textareaboxsize" placeholder="Typing ..." id="txtFamily" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>

    

                 <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                             Country
                           </div>
                     <div class="col-sm-8">
				         <asp:DropDownList ID="ddlCountry" runat="server"  class="input_text">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>
                     </div>
		      </div>

                   <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                             Present Address
                           </div>
                     <div class="col-sm-8">
				              <textarea class="textareaboxsize" placeholder="Typing ...." id="txtPresentAddress" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>

                        <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                             Parmenent  Address
                           </div>
                     <div class="col-sm-8">
				<textarea class="textareaboxsize" placeholder="Typing ...." id="txtParmanent" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>

             <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                       Occupation
                           </div>
                     <div class="col-sm-8">
				         <asp:DropDownList ID="ddlocupation" runat="server"  class="">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>
                     </div>
		 </div>


        <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                           Present Working Status
                           </div>
                     <div class="col-sm-8">
				         <textarea class="textareaboxsize" placeholder="Typing ...." id="txtPresentWorkingStatus" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>


            <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                           Past Working Status
                           </div>
                     <div class="col-sm-8">
				          <textarea class="textareaboxsize" placeholder="Typing ...." id="txtPastworkingstatus" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>


                    <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                          Qualification
                           </div>
                     <div class="col-sm-8">
				             <textarea class="textareaboxsize" placeholder="Typing ...." id="txtQualification" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>


                       <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                  Politicals View
                           </div>
                     <div class="col-sm-8">
				               <textarea class="textareaboxsize" placeholder="Typing ...." id="txtPoliticalView" runat="server"></textarea>
                     </div>
		 </div>

           
                <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
          Religious
                           </div>
                     <div class="col-sm-8">
				         <asp:DropDownList ID="ddlReligious" runat="server"  class="">
                                                    <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                </asp:DropDownList>
                     </div>
		 </div>
           
               <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                          Fav. Sports
                           </div>
                     <div class="col-sm-8">
				    <textarea class="textareaboxsize" placeholder="Typing ...." id="txtSports" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>


                         <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                          Fav. Hobby
                           </div>
                     <div class="col-sm-8">
				            <textarea class="textareaboxsize" placeholder="Typing ...." id="txtHobby" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>



                                          <div style="margin-top:10px" class="row">
                            <div class="col-sm-4">
                          Fav. Foods
                           </div>
                     <div class="col-sm-8">
				           <textarea class="textareaboxsize" placeholder="Typing ...." id="txtFavfoods" runat="server"></textarea>
                                 

                     </div>
                                    
		 </div>

           <div class="modal-footer">

                   <button type="submit" runat="server" id="Button11"  onServerClick="btnLogin1_Click" class="btn btn-default savebtn" >Save</button>
                   <button class="btn btn-default savebtn" type="button">Cancel</button>
                <asp:HiddenField ID="hidArticleId" runat="server" />
           </div>
       </div>


</div> 