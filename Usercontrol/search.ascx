<%@ Control Language="C#" AutoEventWireup="true" CodeFile="search.ascx.cs" Inherits="Usercontrol_search" %>

  <asp:Panel ID="panel" runat="server" DefaultButton="btnLogin">
        <div class="search2">
                        <div method="post" action="">
                            <input type="text" class="input_search" id="txtSearch"  runat="server" name="key" placeholder="Search Interboll" autocomplete="off" role="textbox" aria-autocomplete="list" aria-haspopup="true"  runat="server">
                            
                            <div id="btnSearch" class="btn_search">
                                <div class="">
                           <%--          <button onserverclick="SearchButton_Click" runat="server" type="submit" class="searchbtn2" iD="btnSearchSuiteGroup">
                                           <img border="0" class="searchimg" src="img/search_btn.png">
                                  </button>--%>

                                       <asp:LinkButton ID="btnLogin" class="searchbtn3" OnClick="SearchButton_Click" runat="server" ><img border="0" src="img/search_btn.png" class="searchimg3" ></asp:LinkButton>
                                </div>
                            </div>
                 </div>
                        <div style="clear:both"></div>
        </div>
         
           </asp:Panel>
<style>
    .autoimg{
        width:40px;
        height:40px;
        margin-right:8px;
    }
    .ui-widget-content {
    border: 1px solid #aaaaaa;
    background: #ffffff url(images/ui-bg_flat_75_ffffff_40x100.png) 50% 50% repeat-x;
    color: #222222;
    height: 350px!important;
    overflow-x: hidden!important;
    overflow-y: auto!important;
    font-size:13px!important;
    font-family:serif!important;
}
</style>
    <script type="text/javascript">
        
        $(document).ready(function(){
        function updatedata(event, ui)
        {
            $(this).val(ui.item.Name);
            return false;
        }
            $("[id$=txtSearch]").autocomplete({
                minLength: 1,
                focus:updatedata,
                select:updatedata,
                source: function (request, response) {
                    $.ajax({
                        url: "Service.asmx/GetAutoCompleteData",
                        data: "{ 'getPrefixData': '" + request.term + "'}",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {

                            response(data.d);
                            //response($.map(data.d, function (item) {
                            //    return {
                            //        label: '<span><img src="' + item.Picture + '" class="autoimg"/> </span><span>' + item.Name + '</span>',
                            //    }
                            
                            //}))
                        }//,
                        //error: function (response) {
                        //    //alert(response.responseText);
                        //},
                        //failure: function (response) {
                        //    //alert(response.responseText);
                        //}
                    });
                }                
               
            }).autocomplete('instance')._renderItem = function (ul, item) {
                return $('<li>').append('<img class="autoimg" src="' + item.Picture + '"/>').append('<a>' + item.Name + '</a>').appendTo(ul);
            }
        });
  </script> 