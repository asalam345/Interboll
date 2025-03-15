<%@ Control Language="C#" AutoEventWireup="true" CodeFile="leftside.ascx.cs" Inherits="Usercontrol_leftside" %>
<div class="col-sm-3">
    <div style="height: 4px"></div>
    <div class="boxsocial1">

        <div class="scrollboxhide1"></div>
        <div class="scrolfirstbox">


            <div class="boxsmall">
                <div class="headtitle">
                    <div class="row">

                        <div class="col-sm-12"><a class="textdecorationsta" href="#">Comming Soon New Year 2017 </a></div>
                    </div>

                </div>
                <div class="middlebox">
                    <img src="../img/newyear.gif" style="width: 100%; height: 169px" />
                </div>
                <asp:Repeater ID="rptVideo1" Visible="true" runat="server">
                    <ItemTemplate>
                        <div class="middlebox" style="display: none">

                            <%--<video width="100%" height="170" controls>
            <source src="../<%# Eval("Name")%>" type="video/mp4" />
        </video>
                            --%>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>

        <div class="boxsmall">
            <div class="headtitle">
                <div class="row">
                    <div class="col-sm-6  col-xs-6"><a href="#" class="textdecorationsta">Suggested</a></div>
                    <div class="col-sm-6  col-xs-6"><a href="#" class="textdecorationsta">See More</a></div>
                </div>

            </div>

            <div class="middlebox" style="">
                <div class="row gutter-10">

                    <asp:Repeater ID="rptseg1" runat="server" Visible="true">
                        <ItemTemplate>
                            <div class="col-sm-6 col-xs-3">

                                <a href="<%#Eval("P_Url") %>" target="_blank">
                                    <asp:Image ID="Image2" CssClass="photopl" runat="server" ImageUrl='<%# Bind("Image_Name",  "~/{0}") %>' /></a>


                            </div>

                        </ItemTemplate>
                    </asp:Repeater>
                </div>

                <a href="#" class="textdecorationsta" title="Like"><i class="glyphicon glyphicon-hand-right"></i>Like
                </a>
            </div>

        </div>

        <div class="boxsmall">
            <div class="headtitle">
                <div class="row">
                    <div class="col-sm-8  col-xs-6">Information</div>
                    <div class="col-sm-4  col-xs-6"><a href="#" class="textdecorationsta">See All</a></div>
                </div>

            </div>

            <asp:Repeater ID="rptSeg2" runat="server" Visible="true">
                <ItemTemplate>
                    <div class="middlebox" style="padding-top: 10px; border-bottom: 1px solid #d0d0d0; padding-bottom: 10px">
                        <div class="row gutter-10" style="margin-right: 0px; line-height: 17px">

                            <a href="<%#Eval("P_Url") %>" target="_blank">
                                <%-- <img border="0" src="img/v3.jpg"  align="left" style="width:80px; height:60px; margin-right:8px; margin-top:5px; margin-bottom:0px;"> --%>
                                <asp:Image ID="Image2" align="left" Style="width: 80px; height: 60px; margin-right: 8px; margin-top: 5px; margin-bottom: 0px;" runat="server" ImageUrl='<%# Bind("Image_Name",  "~/{0}") %>' />
                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("P_Description") %>' Width=" "></asp:Label></a>


                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>



        </div>


        <div class="boxsmall">
            <div class="headtitle">
                <div class="row">
                    <div class="col-sm-6  col-xs-6"><a class="textdecorationsta" href="#">See More</a></div>
                </div>

            </div>

            <div class="middlebox">
                <div class="row gutter-10">
                      <div class="col-sm-6 col-xs-6" style="margin-bottom:8px">
                          <img src="../img/hcard1.jpg" style="width: 100%; height:150px"/>
                      <%--     <img src="../img/newyear.jpg" style="width: 100%; height:220px" />--%>
                      </div>
                       <div class="col-sm-6 col-xs-6" style="margin-bottom:8px">
                          <img src="../img/hcard2.jpg" style="width: 100%; height:150px"/>
                      <%--     <img src="../img/newyear.jpg" style="width: 100%; height:220px" />--%>
                      </div>
                     <div class="col-sm-6 col-xs-6" style="margin-bottom:8px">
                          <img src="../img/bus.jpg" style="width: 100%; height:150px"/>
                      <%--     <img src="../img/newyear.jpg" style="width: 100%; height:220px" />--%>
                      </div>
                       <div class="col-sm-6 col-xs-6" style="margin-bottom:8px">
                          <img src="../img/g.gif" style="width: 100%; height:150px"/>
                      <%--     <img src="../img/newyear.jpg" style="width: 100%; height:220px" />--%>
                      </div>
                    <asp:Repeater ID="rptVideo2" Visible="true" runat="server">
                        <ItemTemplate>
                           <%-- <div class="col-sm-6 col-xs-6">

                                <video width="100%" height="150px" controls>
                                    <source src="../<%# Eval("Name")%>" type="video/mp4" />
                                </video>
                            </div>--%>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <p>Book · 75,345 likes</p>
                <a title="Like" class="textdecorationsta" href="#"><i class="glyphicon glyphicon-hand-right"></i>Like
                </a>
            </div>

        </div>


    </div>
</div>
</div>
