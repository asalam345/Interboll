s<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditPostEvent.aspx.cs" Inherits="EditPostEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <link rel="stylesheet" href="css/normalize.css">
        <link href="css/album.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/main.css">
    <link rel="stylesheet" href="css/responsive.css">
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>
    <link href="css/hoverphotocss/style_common.css" rel="stylesheet" />
    <link href="css/hoverphotocss/style3.css" rel="stylesheet" />
    <link href="css/hoverphotocss/style1.css" rel="stylesheet" />
</head>
<body style="border:10px solid #ea3328;">
    <form id="form1" runat="server">
     <div class="createbackgroundcolor">
        <div class="boxcreatalbumphotosho">            
                  <div class="boxcreatalbumphotoshow" id="" style="width:47%">	
                          <div class="tab-content tabcontents">
	   		                           <div style="" id="30c" class="tab-pane active">
                                                      <div class="boxeventtab">
                                                       <div class="titlealbum" style="text-align:center">Create Private Event</div>
                                                                              <div class="row" style="margin-top:10px">
                                                                                 
			                                                 <div class="col-sm-12">
                                                                <div class="col-sm-4">
                                                                  Event Photo
                                                                </div>
                                                              <div class="col-sm-8">
                                                                  <div class="row">
                                                                      <asp:Image ID="Image1" runat="server"  Height="120px" Width="200px"/>
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
                                                                   <a href="eventdefault.aspx">    <button type="button" class="btn btn-default savebtn" data-dismiss="modal">Cancel</button></a>
                                                           </div>
                                                               <div style="clear:both"></div>
                                                  <div style="clear:both"></div>


                                                   </div>
                                               </div>
                                                                            


                                                    
                                                    </div>
                                                       </div>
			</div>
            <asp:Label ID="lbllokUser" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="lbllokPost" runat="server" Text="" Visible="false"></asp:Label>
      <asp:HiddenField ID="hidArticleId" runat="server" />
              <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
    </div
    </div>
    </form>
</body>
</html>
