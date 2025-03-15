<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="help.aspx.cs" Inherits="hepl" %>

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
		<div class="col-sm-1">
		<a href="Default.aspx"><img border="0" src="img/interboll.png" class="oiiogo"></a>
		</div>
		<div class="col-sm-11">
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
                  <!--General drop down setting wrap box start-->
		                                    <div class="boxpro">
                      <div class="aboutwraptitle">
                               <i class="fa fa-film" aria-hidden="true"></i> Help
                       </div>

                  <!--General drop down setting start-->
                        <div class="panel-group" id="accordion">

  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" style="cursor:pointer" >
      
      
          <asp:Label ID="lblpost1Title" runat="server" Text=""></asp:Label>
    
         
      </h4>
    </div>
    <div id="collapseTwo" class="panel-collapse collapse">
      <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>    <asp:Label ID="lblPost1detail" runat="server" Text=""></asp:Label></p>
               </div>

          </div>
      </div>
        <div style="clear:both"></div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" style="cursor:pointer">
     
        <asp:Label ID="lblpost2Title" runat="server" Text=""></asp:Label>

           
      </h4>
    </div>
    <div id="collapseThree" class="panel-collapse collapse">
        <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p><asp:Label ID="lblPost2detail" runat="server" Text=""></asp:Label></p>
               </div>

          </div>
      </div>
    </div>
  </div>


  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblPost3Sort" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lblPost3Detail" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div>
             
                              <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq4" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla4" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div> 
                            
                             <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq5" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla5" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div>  
                            
                            <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq6" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla6" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div> 
                   
                            
                            
                                      <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq7" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla7" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div> 
                            
                            
                                             <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq8" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla8" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div>
                            
                            
                            
                             <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq9" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla9" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div> 
                            
                             <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title" class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapsefour" style="cursor:pointer">
      
      <asp:Label ID="lblq10" runat="server" Text=""></asp:Label>
      </h4>
    </div>

    <div id="collapsefour" class="panel-collapse collapse">
    
       <div class="panel-body">
         
          <div class="col-sm-12">
              <div class="row">
                 <p>   <asp:Label ID="lbla10" runat="server" Text=""></asp:Label>
               </div>

          </div>
      </div>

    </div>


  </div> 
                            
 



<!--General drop down setting end-->


</div>
                                   <!--General drop down setting wrap boxend-->
              </div>

        </div>
        </div>
         </div>
</asp:Content>
