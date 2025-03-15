<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Video.aspx.cs" Inherits="Video" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
                         <style type="text/css">
    .comentbtn
    { 
     cursor:pointer;
       
    }
    .cmtdetails
    { 
          display:none; visibility:hidden; 
        
    }
</style>
      <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        table
        {
            border: 1px solid #ccc;
            border-collapse: collapse;
        }
        table th, table td
        {
            padding: 5px;
        }
        table, table table td
        {
            border: 0px solid #ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div class="col-sm-5"> 
     <div class="boxsocialwrap">
		           <div class="scrollboxhide"></div>
		
				        <asp:Repeater ID="rptPost" runat="server" OnItemDataBound="RepeaterItemCreated" >
                            <ItemTemplate>   			
		
		
         <%--<div class="comment more"> <div><asp:Label CssClass="ShortDesc" Text='<%# Eval("P_Description").ToString().Substring(0,Math.Min(400,Eval("P_Description").ToString().Length)) %>' runat="server"></asp:Label></div></div>	--%>
         
         
         			
	 </div>
	 
						   
	        <div class="photouploadstatus">
	            <div class="topupload2">
                      <div class="row2">
                           <div class=" ">
								<div class="row2">
								     <%--<button href="#" class="textdecorationsta" title="Like" onServerClick="btnReplyClicked" runat="server" id="btnReply" CommandArgument='<%#Eval("P_Id")%>'><i class="glyphicon glyphicon-hand-right"></i>
                                         <asp:Label ID="lblLike111" runat="server" Text=""></asp:Label>--%>
                                        
                                            <asp:Label ID="lblmenueid" runat="server" Text='<%# Bind("MenuID") %>' Width="" Visible="false"></asp:Label>
                                               <div class="leftimag2">
                                                
                                                 <div id='h<%# Eval("MenuID") %>' class="commentsleft"  onclick='ToggleDisplay(<%# Eval("MenuID") %>);' >
       <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>' Width="" style=" background-color: #666;
    color: #ffffff;
    line-height: 27px;
    margin-bottom: 45px;
    padding: 5px 8px 8px;
    width: 270px;"></asp:Label>     </div>
               <div class="commentscount" style="margin-left:2px"><asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("Name") %>' Width=""  Visible="false"></asp:Label></div>
           
                                                   <div class="commentsleft" style="display:none">
                                                      <asp:Button ID="Button2" runat="server" Text="Comment"  CommandName="lokin" AutoPostBack="True" CommandArgument='<%#Eval("MenuID")%>' cssclass="postbtn2"/></div>
                                           <div style="clear:both"></div>    

                                        </div>

                                     
                                       
                                       

                                       <%--  <asp:Button runat="server" ID="Button1" OnCommand="Button1_Command" Text="Like" />--%>
                                 
								 </div>
								  
							
									<div style="clear:both"></div>
								</div>
                        </div>
					</div>
               
                 </div>       
                            <!--comments start-->
                           <div id='d<%# Eval("MenuID") %>' class="cmtdetails" style="margin-top:8px">
                          



                          
                     
                                                 
                                            

                                                <asp:Repeater ID="dlcomment" runat="server" >
                                                <ItemTemplate>
										
                                                    <div class="" class="cmtdetails" style="margin-top:8px; margin-bottom:8px; font-size:12px">
                                                   
                                                          <div style="float:left"> 
                                                       

                                                        <asp:Label ID="lblcommentname" runat="server" Text='<%# Bind("Name") %>' Width=""></asp:Label>
                                                                <asp:Label ID="lblpcomtid_Pid" runat="server" Text='<%# Bind("MenuID") %>' Width="" Visible="false"></asp:Label>
                                                                   <asp:Label ID="lblpcomtid" runat="server" Text='<%# Bind("MenuID") %>' Width="" Visible="false"></asp:Label>

                                                      
                                                              </div>
                                                <div style="clear:both"></div>
                                                
                                                    </div>

                                                  

                                                </ItemTemplate>
                                            </asp:Repeater>

                                          


                           </div>

                                        <div style="clear: both"></div>


                                    </div>



                                </ItemTemplate>

                            </asp:Repeater>
        </div>
          </div>


           <script type="text/javascript">
               function ToggleShowHide1() {
                   var thisLabel = $('.my_control2').eq(0);
                   // alert(thisLabel);
                   var control = document.getElementById(thisLabel);
                   if (control.style.display == "none") { control.style.display = "block"; }
                   else { control.style.display = "none"; }
                   return false;
               }


    </script>
          <script language="JavaScript" type="text/javascript">
              function ToggleDisplay(id) {
                  var elem = document.getElementById('d' + id);
                  if (elem) {
                      if (elem.style.display != 'block') {
                          elem.style.display = 'block';
                          elem.style.visibility = 'visible';
                      }
                      else {
                          elem.style.display = 'none';
                          elem.style.visibility = 'hidden';
                      }
                  }
              }
</script>
    </div>
    </form>
</body>
</html>
