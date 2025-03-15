﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>
  

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

 <script src="http://code.jquery.com/jquery-latest.js"></script>
<script src="js/linkScrapper.min.js"></script>
<script type="text/javascript">

    //Input variables
    var scrapper_total_width = 400;
    var scrapper_image_width = 100;
    var scrapper_image_height = 100;

    //Output variables - should be global
    var scrapperLinkURL; //contains a URL if present in the scrapperText
    var scrapperLinkTitle; //contains the title of the URL webpage
    var scrapperLinkDescription; //contains a short desription of the URL
    var scrapperLinkImageURL; //contains a URL of the image selected
    var scrapperText; //contains the text entered in the textarea

    function displayScrapperData() {
        //Post button has been clicked
        //All output variables available here with values.

        //your code goes here to display these values...
        $('#displayArea').prepend('<hr/><br/><div style="margin:0px auto; text-align:center;"><img src="' + scrapperLinkImageURL + '"/></div>' + '<br/><b>Text: </b>' + scrapperText + '<br/><b>URL: </b>' + scrapperLinkURL + '<br/><b>Title: </b>' + scrapperLinkTitle + '<br/><b>Description: </b>' + scrapperLinkDescription + '<br/><b>Image Source: </b>' + scrapperLinkImageURL + '<br/><br/>');
    }

	</script>
<style>
body { font-family: Calibri; font-size: 14px; text-align: center; }
#container { text-align: left; width: 800px; height: 100%; margin: 0px auto; padding: 10px; border: 1px solid #e2e2e2; }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div  style="height:250px"></div>
     <div class="col-sm-5"> 
     <div class="boxsocialwrap">
		         
		
	  			
		
		
         <%--<div class="comment more"> <div><asp:Label CssClass="ShortDesc" Text='<%# Eval("P_Description").ToString().Substring(0,Math.Min(400,Eval("P_Description").ToString().Length)) %>' runat="server"></asp:Label></div></div>	--%>
         
         
 
	 
						   
	        <div class="photouploadstatus">
	            <div class="topupload2">
                      <div class="row2">
                     <h1>Link Scrapper TextBox - Jquery Plugin</h1>
<div id="container"> Enter some text with a URL <br/>
<br/>
<div id="linkScrapper"></div>
<div id="displayArea">
<hr/>
</div>
<br/>
</div>

                          </div>
                    </div>
                </div>
    
         </div>
         </div>
</asp:Content>

