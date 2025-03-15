<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowAlbumPic.aspx.cs" Inherits="ShowAlbumPic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interboll</title>
  <link href="css/main.css" rel="stylesheet" />
  <link href="css/album.css" rel="stylesheet" />
  <link href="css/bootstrap.min.css" rel="stylesheet" /> 
        <link rel="stylesheet" href="css/font-awesome.min.css">
       <style>
           #divImage
{
    display: none;
    z-index: 1000;
    position: fixed;
    top: 0;
    left: 0;
    background-color: White;
    height: 550px;
    width: 600px;
    padding: 3px;
    border: solid 1px black;
    z-index: 555;
}
      </style>
     
</head>
<body style="border:10px solid #ea3328;">
    <form id="form1" runat="server">
    <div class="createbackgroundcolor">
        <div class="boxcreatalbumphotoshow">
             <div class="titlealbum" style="text-align:center">Album Photo Show</div>
            <div class="descriptionalbum" style="margin-bottom:14px">
                <strong>Album Name :</strong> <asp:Label ID="lblAlbums" runat="server" Text="Label"></asp:Label> <br>
                <%--<strong>  Date:</strong>19.09.2016<br>
                <strong>  Place:</strong>Dhaka<br>--%>
            </div>
              <div class="row gutter-10">
            <%--    <div class="col-sm-2">
                    <a data-target="#albumphoto" data-toggle="modal" href="#"> <div class="photouploasmallthumble">
                          <img style="border-width:0px;width:100%; height:120px" src="images/Albums/Auto.png" id="dlalbum_ctl00_Image2">      <br>
                              <span id="dlalbum_ctl00_Label2">Dhaka</span>
	                    </div>     
                    </a>                
               </div>--%>
                                 <asp:Repeater ID="dl_Image" runat="server">
                                <ItemTemplate>
                                 <div class="col-sm-2">
                       
                             <div class="photouploasmallthumble2">
                                        <%--<asp:Image runat="server" ID="img_banner"  ImageUrl='<%# Eval("Image_Path",  "~/images/Albums/{0}") %>' alt="Image" Style="height:180px; width:100%; margin-bottom:15px" />--%>
                                   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("Image_Path",  "~/images/Albums/{0}")%>'
                 Style="    height: 120px;
    width: 100%;
    border-width: 0px;
    cursor: pointer; margin-bottom:10px" OnClientClick="return LoadDiv(this.src);" />
                                           
                                             </div> 
                                
                                      </div>
                                  
                                </ItemTemplate>
                            </asp:Repeater>
                 

                         <div id="divBackground" class="modal" >

<div id="divImage" style="z-index:999;">
   
    <div class=""style="text-align:right; cursor:pointer" onclick="HideDiv()"><span class="glyphicon glyphicon-remove"></span></div>
<table style="height: 100%; width: 100%">
    <tr>
        <td valign="middle" align="center">
            <img id="imgLoader" alt="" src="images/loader.gif" />
            <img id="imgFull" alt="" src="" style="display: none; height: 500px; width: 590px" />
        </td>
    </tr>
    <tr>
     
    </tr>
</table>
</div>
          </div>
           </div>
    
        </div>
  </div>
    </form>

                  <!--Album Photo-->
                                              <div class="modal fade" id="albumphoto" role="dialog">
                                                <div class="modal-dialog modal_photoalbum">
    
                                                  <!-- Modal content-->
                                                  <div class="modal-content modelcontentpop">
                                                 <%--   <div class="modal-header2">
                                                      <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                     
                                                    </div>--%>
                                                    <div class="modal-body">
                                                          

                                                          <img style="border-width:0px;width:100%; height:420px" src="images/Albums/Auto.png" id="dlalbum_ctl00_Image2"> 

                                                    </div>
                                                     
                                                  </div>
      
                                                </div>
                                              </div>
                                  <!--Album Photo-->


        <%--<script src="js/vendor/jquery-1.11.3.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
  
        <script src="js/plugins.js"></script>
        <script src="js/main.js"></script>--%>
    <script type="text/javascript">
        function LoadDiv(url) {
            var img = new Image();
            var bcgDiv = document.getElementById("divBackground");
            var imgDiv = document.getElementById("divImage");
            var imgFull = document.getElementById("imgFull");
            var imgLoader = document.getElementById("imgLoader");
            imgLoader.style.display = "block";
            img.onload = function () {
                imgFull.src = img.src;
                imgFull.style.display = "block";
                imgLoader.style.display = "none";
            };
            img.src = url;
            var width = document.body.clientWidth;
            if (document.body.clientHeight > document.body.scrollHeight) {
                bcgDiv.style.height = document.body.clientHeight + "px";
            }
            else {
                bcgDiv.style.height = document.body.scrollHeight + "px";
            }
            imgDiv.style.left = (width - 650) / 2 + "px";
            imgDiv.style.top = "20px";
            bcgDiv.style.width = "100%";

            bcgDiv.style.display = "block";
            imgDiv.style.display = "block";
            return false;
        }
        function HideDiv() {
            var bcgDiv = document.getElementById("divBackground");
            var imgDiv = document.getElementById("divImage");
            var imgFull = document.getElementById("imgFull");
            if (bcgDiv != null) {
                bcgDiv.style.display = "none";
                imgDiv.style.display = "none";
                imgFull.style.display = "none";
            }
        }
         </script>
</body>
</html>
