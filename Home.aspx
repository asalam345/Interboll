<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8"/>
    <meta http-equiv="x-ua-compatible" content="ie=edge"/>

    <title>Interboll</title>
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico" />
    <meta name="description" content=""/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="apple-touch-icon" href="apple-touch-icon.png"/>
    <!-- Place favicon.ico in the root directory -->
    <link rel="stylesheet" href="css/normalize.css"/>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="css/font-awesome.min.css"/>
    <link rel="stylesheet" href="css/animate.css"/>
    <link rel="stylesheet" href="css/main.css"/>

    <link href="css/responsive.css" rel="stylesheet" />
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>
    <script src="js/jssor.slider.min.js"></script>

    <link href="css/textanimation.css" rel="stylesheet" />
    <style>
        select option {
            background: rgba(0,0,0,0.3);
            color: #fff;
            text-shadow: 0 1px 0 rgba(0,0,0,0.4);
        }
    </style>
    <!--sliderdemo-drones start2-->
    <!-- use jssor.slider.debug.js instead for debug -->
   
    <script>

        jssor_02_slider_init = function () {

            var jssor_02_SlideshowTransitions = [
              { $Duration: 1200, $Opacity: 2 }
            ];

            var jssor_02_options = {
                $AutoPlay: true,
                $SlideshowOptions: {
                    $Class: $JssorSlideshowRunner$,
                    $Transitions: jssor_02_SlideshowTransitions,
                    $TransitionsOrder: 1
                },
                $ArrowNavigatorOptions: {
                    $Class: $JssorArrowNavigator$
                },
                $BulletNavigatorOptions: {
                    $Class: $JssorBulletNavigator$
                }
            };

            var jssor_02_slider = new $JssorSlider$("jssor_02", jssor_02_options);

            //responsive code begin
            //you can remove responsive code if you don't want the slider scales while window resizing
            function ScaleSlider() {
                var refSize = jssor_02_slider.$Elmt.parentNode.clientWidth;
                if (refSize) {
                    refSize = Math.min(refSize, 1360);
                    jssor_02_slider.$ScaleWidth(refSize);
                }
                else {
                    window.setTimeout(ScaleSlider, 30);
                }
            }
            ScaleSlider();
            $Jssor$.$AddEvent(window, "load", ScaleSlider);
            $Jssor$.$AddEvent(window, "resize", ScaleSlider);
            $Jssor$.$AddEvent(window, "orientationchange", ScaleSlider);
            //responsive code end
        };
    </script>

    <style>
        /* jssor slider bullet navigator skin 05 css */
        /*
        .jssorb05 div           (normal)
        .jssorb05 div:hover     (normal mouseover)
        .jssorb05 .av           (active)
        .jssorb05 .av:hover     (active mouseover)
        .jssorb05 .dn           (mousedown)
        */
        .jssorb05 {
            position: absolute;
        }

            .jssorb05 div, .jssorb05 div:hover, .jssorb05 .av {
                position: absolute;
                /* size of bullet elment */
                width: 16px;
                height: 16px;
                background: url('img/b05.png') no-repeat;
                overflow: hidden;
                cursor: pointer;
            }

            .jssorb05 div {
                background-position: -7px -7px;
            }

                .jssorb05 div:hover, .jssorb05 .av:hover {
                    background-position: -37px -7px;
                }

            .jssorb05 .av {
                background-position: -67px -7px;
            }

            .jssorb05 .dn, .jssorb05 .dn:hover {
                background-position: -97px -7px;
            }

        /* jssor slider arrow navigator skin 12 css */
        /*
        .jssora12l                  (normal)
        .jssora12r                  (normal)
        .jssora12l:hover            (normal mouseover)
        .jssora12r:hover            (normal mouseover)
        .jssora12l.jssora12ldn      (mousedown)
        .jssora12r.jssora12rdn      (mousedown)
        */
        .jssora12l, .jssora12r {
            display: block;
            position: absolute;
            /* size of arrow element */
            width: 30px;
            height: 46px;
            cursor: pointer;
            background: url('img/a12.png') no-repeat;
            overflow: hidden;
        }

        .jssora12l {
            background-position: -16px -37px;
        }

        .jssora12r {
            background-position: -75px -37px;
        }

        .jssora12l:hover {
            background-position: -136px -37px;
        }

        .jssora12r:hover {
            background-position: -195px -37px;
        }

        .jssora12l.jssora12ldn {
            background-position: -256px -37px;
        }

        .jssora12r.jssora12rdn {
            background-position: -315px -37px;
        }
    </style>
    <!--slider-demo-drones end2-->

</head>
<body style="background-color: #ea3328; padding: 10px">
    <form id="form1" runat="server">
        <div class="bottomborderindex">Genesis in Bangladesh</div>
        <div class="boxcontentsindex">
            <div id="jssor_02" style="position: relative; margin: 0 auto; top: 0px; left: 0px; width: 1350px; height: 680px; overflow: hidden; visibility: hidden; display: none">
                <!-- Loading Screen -->
                <div data-u="loading" style="position: absolute; top: 0px; left: 0px;">
                    <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
                    <div style="position: absolute; display: block; background: url('img/loading.gif') no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
                </div>
                <a href="#" data-toggle="modal" data-target="#myModal">
                    <div data-u="slides" style="cursor: pointer; position: relative; top: 0px; left: 0px; width: 1350px; height: 680px; overflow: hidden;">
                        <div data-p="112.50" style="display: none;">
                            <div class="vidbg-box2" style="width: 100%; height: 680px;" data-vidbg-bg="mp4: media/natural.mp4, webm: media/natural.webm, poster: media/fallback.png" data-vidbg-options="loop: true, muted: true, overlay: false"></div>
                        </div>
                        <%--     <div data-p="112.50" style="display: none;">
                 <div class="vidbg-box" style="width: 100%; height: 700px;" data-vidbg-bg="mp4: media/Sharwoods.mp4, webm: media/Sharwoods.webm, poster: media/fallback.jpg" data-vidbg-options="loop: true, muted: true, overlay: false"></div>
            </div>--%>
                    </div>
                </a>
                <!-- Bullet Navigator -->
                <div data-u="navigator" class="jssorb05" style="bottom: 16px; right: 16px;" data-autocenter="1">
                    <!-- bullet navigator item prototype -->
                    <div data-u="prototype" style="width: 16px; height: 16px;"></div>
                </div>
                <!-- Arrow Navigator -->
                <span data-u="arrowleft" class="jssora12l" style="top: 0px; left: 0px; width: 30px; height: 46px;" data-autocenter="2"></span>
                <span data-u="arrowright" class="jssora12r" style="top: 0px; right: 0px; width: 30px; height: 46px;" data-autocenter="2"></span>

                <!--banner-start-->

            </div>
            <script>
                jssor_02_slider_init();
            </script>

            <!--video start-->
            <a href="#" data-toggle="modal" data-target="#myModal">
                <div class="desktop_video">
                    <div class="vidbg-box2" data-vidbg-bg="mp4: media/natural.mp4, webm: media/natural.webm, poster: media/feedback.png" data-vidbg-options="loop:true, muted:true, overlay: true"></div>
                </div>

                <div class="mobile_video2"><img border="0" src="media/video_file/small.gif" class="vidbg-box2"></div>

            </a>
            <!--video end-->
            <div class="" style="display: none">
                <video style="height: 755px" class="vidbg-b" autoplay loop>
                    <source src="media/natural.mp4" type="video/mp4">
                    <source src="media/natural.webm" type="video/webm">
                </video>

            </div>

            <div class="textboxwrap">
                <img border="0" src="img/Interboll_logo.png" class="birdimglogo" data-toggle="modal" data-target="#myModal" style="display: none">

                <div class="title_interboll" data-toggle="modal" data-target="#myModal">
                    <a href="#" style="color: #333366">Interb
                        <img border="0" src="img/Interboll_logo.png" class="birdimglogosmall">ll</a>
                </div>

                <div class="connection_text">
                    <a href="#" style="color: #333366" data-toggle="modal" data-target="#myModal">
                        <div class="slides">
                            <ul>
                                <!-- slides -->
                                <li style="color: #000000; text-shadow: 0 2px #fff; padding-left: 11.5%">Create  Your Interplanetary Connection
                                           <!-- <div>Promo text #1</div>-->
                                </li>
                                <li style="color: #333366; text-shadow: 0 2px #fff;">Encompass Your Friends, Families and Communities
                                            <!--  <div>Promo text #2</div>-->
                                </li>
                                <li style="color: #000000; text-shadow: 0 2px #fff; padding-left: 11.5%">Create Your Interplanetary Connection
                                           <!-- <div>Promo text #1</div>-->
                                </li>
                                <li style="color: #333366; text-shadow: 0 2px #fff;">Encompass Your Friends, Families and Communities
                                            <!--  <div>Promo text #2</div>-->
                                </li>

                            </ul>
                        </div>
                    </a>
                    <%--  <a href="#"  data-toggle="modal" data-target="#myModal"> Encompass Your interplanetary Connection</a>--%>
                </div>

                <a href="http://www.oiiointernational.com/" target="_blank" class="textshadow">
                    <div class="logoindexwrap">
                        An
                        <img border="0" src="img/logoindex.png" class="logoindex">
                        <br>
                        <div style="font-size: 11px; margin-left: -7px;">Company</div>
                    </div>
                </a>

            </div>


            <!--modal view popup start-->
            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog modal_login">

                    <!-- Modal content-->
                    <div class="modal-content2 modelcontentpop">
                        <div class="modal-header2" style="padding: 0px 15px 0px 15px; display: none">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <div style="clear: both"></div>
                        </div>
                        <div class="bodypopuplogin">
                            <div class="middle_contents2">
                                <div class="row  gutter-10">
                                    <div class="col-sm-6">
                                        <div class="boxemailleft">


                                            <div class="row" style="margin-top: 0px; display: none">
                                                <div class="col-sm-12" style="">
                                                    <div style="">
                                                        <span style="font-size: 16px">Create Account.</span>
                                                        <span style="color: #ffffff">It's free.</span>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class="row" style="margin-top: 1px">
                                                <div class="col-sm-12">
                                                    <%--  <input type="text" class="input_text_ipacity" name="key" placeholder="Name"  name="Name">--%>
                                                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="input_text_ipacity" placeholder="Name"></asp:TextBox>

                                                </div>

                                            </div>

                                            <div class="row" style="margin-top: 10px">
                                                <div class="col-sm-12">
                                                    <%-- <input type="text" class="input_text_ipacity" name="key" placeholder="Email"  name="Email">--%>
                                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input_text_ipacity" placeholder="example@gmail.com"></asp:TextBox>

                                                </div>

                                            </div>

                                            <div class="row" style="margin-top: 10px">
                                                <div class="col-sm-12">
                                                    <%--   <input type="text" class="input_text_ipacity" name="key" placeholder="Password"  name="Password">--%>
                                                    <%--     <label class="string optional" for="user-pw">Password *</label>--%>
                                                    <%-- <input class="string optional" maxlength="255" id="user-pw" placeholder="Password" type="password" size="50" />--%>

                                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="input_text_ipacity" placeholder="Password"></asp:TextBox>


                                                </div>

                                            </div>

                                            <div class="row" style="margin-top: 10px; display: none">
                                                <div class="col-sm-12">
                                                    <%--          <label class="string optional" for="user-pw">Retype Password *</label>--%>
                                                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="input_text_ipacity" placeholder="Retype Password"></asp:TextBox>




                                                </div>

                                            </div>

                                            <div class="row" style="margin-top: 9px">
                                                <div class="col-sm-12">
                                                    <div class="boxinput">
                                                        <div class="col-sm-3">
                                                            <p>Birthday</p>
                                                        </div>
                                                        <div class="col-sm-9">
                                                            <div class="row">
                                                                <div class="col-md-4 col-xs-4">

                                                                    <asp:DropDownList ID="ddlDate" runat="server" class="input_select_opacity">
                                                                        <asp:ListItem Value="-1">[Select DD]</asp:ListItem>
                                                                    </asp:DropDownList>

                                                                </div>
                                                                <div class="col-md-4 col-xs-4">

                                                                    <asp:DropDownList ID="DdlMonth" runat="server" class="input_select_opacity">
                                                                        <asp:ListItem Value="-1">[Select MMM]</asp:ListItem>
                                                                    </asp:DropDownList>

                                                                </div>
                                                                <div class="col-md-4 col-xs-4">

                                                                    <asp:DropDownList ID="ddlYear" runat="server" class="input_select_opacity" >
                                                                        <asp:ListItem Value="-1">[Select YYYY]</asp:ListItem>
                                                                    </asp:DropDownList>

                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div style="clear: both"></div>
                                                    </div>


                                                </div>
                                            </div>


                                            <div class="row " style="margin-top: 3px">
                                                <div class="col-sm-12">
                                                    <div class="boxinput">
                                                        <div class="">
                                                            <div class="col-sm-3">
                                                                <p>Gender</p>
                                                            </div>
                                                            <div class="col-sm-9">
                                                                <asp:DropDownList ID="ddlgender" runat="server" class="input_text_ipacity2">
                                                                    <asp:ListItem Value="1"> Men</asp:ListItem>
                                                                    <asp:ListItem Value="2"> Women</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                        <div style="clear: both"></div>
                                                    </div>
                                                </div>
                                            </div>

                                            <%--     <div class="row" style="margin-top:3px">
					 <div class="col-sm-12">
					 <button class="btn-primary" id="Button1" style="background: #ffffff none repeat scroll 0 0;
    border: 0 none;
    color: #000000;
    font-size: 16px;
    padding: 0 4px;
    width: 100%; " onserverclick="btn_CreateAccount_Click">
					 Create Account
					 </button>
					 </div>
			 </div>--%>
                                            <div class="row2" style="margin-top: 0px">
                                                <div style="">
                                                    <div style="float: left">
                                                        <input type="checkbox" name="logged" value="Keep me"></div>
                                                    <div style="color: #ffffff; float: left; margin-left: 5px">Apply Terms & Conditions</div>

                                                </div>
                                                <div style="clear: both"></div>
                                            </div>
                                            <div class="row" style="margin-top: 3px">
                                                <div class="col-sm-12">
                                                    <button type="submit" runat="server" id="Button1" class="btn-primary btnopacity" onserverclick="btnLogin1_Click">
                                                        Create Account
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-sm-6">
                                        <div class="boxsocialwrap2">
                                            <asp:Panel ID="panel" runat="server" DefaultButton="btnLogin">
                                                <div class="row" style="margin-top: 1px">
                                                    <div class="col-sm-12">
                                                        <%--input type="text" class="input_text_ipacity" name="key" placeholder="Email"  name="Email" style="margin-bottom:7px" runat="server" id="Emailid">--%>
                                                        <asp:TextBox ID="UserName" runat="server" CssClass="input_text_ipacity" ValidationGroup="enter" placeholder="Username" name="loginname" type="text" autofocus="autofocus" />

                                                    </div>

                                                </div>

                                                <div class="row" style="margin-top: 8px">
                                                    <div class="col-sm-12">
                                                        <%-- <input type="text" class="input_text_ipacity" name="key" placeholder="Password"  name="Password" style="margin-bottom:7px" r>--%>
                                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" class="input_text_ipacity" ValidationGroup="enter" placeholder="Password" name="password" type="password" value="" AutoComplete="off" />
                                                        <div style="">
                                                            <input type="checkbox" name="logged" value="Keep me"><span style="color: #ffffff"> Keep me logged in</span>
                                                        </div>
                                                        <div style=""><a style="color: #ffffff; margin-left: 18px" href="#">Forgotten your password?</a></div>
                                                        <asp:Label ID="labelMessage" runat="server"></asp:Label>
                                                        <asp:Literal runat="server" ID="FailureText" />
                                                    </div>

                                                </div>
                                                <img style="border: 0px; width: 100%; height: 79px; margin-top: 4px;" src="img/imglog.png">
                                                <div class="row" style="margin-top: 10px">
                                                    <div class="col-sm-12">
                                                        <asp:LinkButton ID="btnLogin" class="btn-primary btnopacity" OnClick="btnLogin_Click" runat="server" Text="Log In"></asp:LinkButton>
                                                       
                                                    </div>
                                                </div>
                                            </asp:Panel>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer" style="display: none">
                            <button type="button" class="btn btn-default" data-dismiss="modal" style="border-radius: 0px">Close</button>
                        </div>
                    </div>

                </div>
            </div>
            <!--modal view popup end-->

            <div class="bodybackground">
                <div class="swiperslider" style="margin-top: 10px; display: none">
                    <div class="vidbg-box2" style="width: 100%; height: 700px;" data-vidbg-bg="mp4: media/mp4_video.mp4, webm: media/webm_video.webm, poster: media/fallback.jpg" data-vidbg-options="loop: true, muted: true, overlay: false">
                    </div>
                </div>

            </div>
        </div>

		<script src="js/vendor/jquery-1.11.3.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/plugins.js"></script>
        <script src="js/main.js"></script>
        <asp:Literal runat="server" ID="Litgrp" Visible="false" />
        <asp:Literal runat="server" ID="litGroup" Visible="false" />
        <asp:Literal runat="server" ID="litFirstname" Visible="false" />
        <script src="js/vidbg.js"></script>

        <script type="text/javascript">

            //function getCookie(cname) {
            //    var name = cname + "=";
            //    var decodedCookie = decodeURIComponent(document.cookie);
            //    var ca = decodedCookie.split(';');
            //    for (var i = 0; i < ca.length; i++) {
            //        var c = ca[i];
            //        while (c.charAt(0) == ' ') {
            //            c = c.substring(1);
            //        }
            //        if (c.indexOf(name) == 0) {
            //            return c.substring(name.length, c.length);
            //        }
            //    }
            //    return "";
            //}
            //$(document).ready(function () {
            //    alert(getCookie("pagename"));
            //    alert(getCookie("userid"));
            //    // alert();
            //});




            function openModal() {
                $('#myModal').modal('show');
            }
       


         $.getJSON('https://freegeoip.net/json/')
         .done(function (location) {
             //$('#country').html(location.country_name);
             //$('#country_code').html(location.country_code);
             //$('#region').html(location.region_name);
             //$('#region_code').html(location.region_code);
             //$('#city').html(location.city);
             //$('#latitude').html(location.latitude);
             //$('#longitude').html(location.longitude);
             //$('#timezone').html(location.time_zone);
            
            <%-- $('#' + '<%=lblContry.ClientID %>').text(location.country_name);
             $('#' + '<%=lblCity.ClientID %>').text(location.city);
             $('#' + '<%=lblTimezone.ClientID %>').text(location.time_zone);
             $('#' + '<%=lblIp.ClientID %>').text(location.ip);
             $('#' + '<%=lblTime.ClientID %>').text(showTheTime(location.time_zone));--%>
             $.ajax({
                 url: "Home.aspx/ClientInfo",
                 method: "POST",
                 data: '{cname: "' + location.country_name + '", tZone: "' + location.time_zone + '",ip: "' + location.ip + '"}',
                 //data:{name:"'"+ location.country_name +"'"},
                 //context: document.body
                 contentType: "application/json; charset=utf-8",
                 dataType: "json", // dataType is json format
                 success: OnSuccess,
                 error: OnErrorCall
             });
         });


        
   
        function OnSuccess(response) {
            console.log(response.d)
        }
        function OnErrorCall(response) { console.log(error); }
       
         </script>
        
    </form>
</body>
</html>
