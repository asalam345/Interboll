<%@ Page Title="" Language="C#" MasterPageFile="~/games/user.master" AutoEventWireup="true" CodeFile="user_view_gameinformation.aspx.cs" Inherits="games_user_view_gameinformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function isNumberKey(event) {
            var charCode = (event.which) ? event.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            else
                return true;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body_header" Runat="Server">
    <div class="body_box_header">
        <div class="body_text_left">
            <i class="fa fa-navicon fa_margin_right"></i>Games Information
        </div>
    </div>
    <div id="body_box_alert">
        <div class="alert alert-success alert-dismissable" id="divAlertUpdateSuccessMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-check fa_margin_right"></i>Successful!</strong>
            Data updated successfully.
        </div>
        <div class="alert alert-success alert-dismissable" id="divAlertDeleteSuccessMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-check fa_margin_right"></i>Successful!</strong>
            Data Lock/Unlock successfully.
        </div>
        <div class="alert alert-success alert-dismissable" id="divAlertDisplaySuccessMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-check fa_margin_right"></i>Successful!</strong>
            Data displayed successfully.
        </div>
        <div class="alert alert-danger alert-dismissable" id="divAlertErrorMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-close fa_margin_right"></i>Error!</strong>
            Please Fix The Error.
            <asp:Label ID="lbErrorMessage" runat="server" Text=""></asp:Label>
        </div>
        <div class="alert alert-warning alert-dismissable" id="divAlertWaringMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-warning fa_margin_right"></i>Warning!</strong>
            Duplicate data found.
        </div>
        <div class="alert alert-warning alert-dismissable" id="divAlertWaringNotMatchedMessage" runat="server" visible="false">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
            <strong><i class="fa fa-warning fa_margin_right"></i>Warning!</strong>
            Password not matched, please try again.
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_body" Runat="Server">
    <div class="body_box">
        <div class="container-fluid">
            <div class="form-group">
                <div class="row body_box_padding_top">
                    <div class="col-sm-12">
                        <div class="pull-left">
                            <asp:Panel ID="GoPage" runat="server" DefaultButton="btGoPage">
                                <asp:TextBox ID="txGoPage" class="form-control input-sm" MaxLength="16" Style="width: 185px; display: inline-block;" placeholder="Search by page number" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                <asp:LinkButton ID="btGoPage" runat="server" OnClick="btGoPage_Click" CssClass="icon_search" Style="position: absolute; top: 2px; left: 180px;"><i class="fa fa-search"></i></asp:LinkButton>
                            </asp:Panel>
                        </div>
                        <div class="pull-left" style="margin-left: 8px">
                            <asp:HyperLink ID="hlNewGame" data-toggle="tooltip" data-placement="bottom" title="New Game" runat="server" NavigateUrl="user_gameinformation.aspx"><i class="btn btn-default btn-sm fa fa-plus-square" style="color:blue;"> New Game</i></asp:HyperLink>
                        </div>
                        <div class="pull-right">
                            <div class="has-feedback">
                                <asp:Panel ID="Search" runat="server" DefaultButton="btSearch">
                                    <asp:TextBox ID="txSearch" class="form-control input-sm" Style="width: 225px;" placeholder="Search by name or subject" runat="server"></asp:TextBox>
                                    <asp:LinkButton ID="btSearch" runat="server" OnClick="btSearch_Click" Style="position: absolute; top: 1px; right: 5px;"><i class="fa fa-search"></i></asp:LinkButton>
                                </asp:Panel>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-sm-12">
                        <div class="table-responsive">
                            <table class="table table-hover table-striped">
                                <thead>
                                    <tr style="background:#b0b0b0;border:none;color:#fff;">
                                        <th>Lock</th>
                                        <th>Edit</th>
                                        <th>Game Name</th>
                                        <th>Play</th>
                                        <th>Platform</th>
                                        <th>Category</th>
                                        <th>Type</th>
                                        <th>Status</th>
                                        <th>Photo</th>
                                        <th>Video</th>
                                        <th>Created Date</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rpView" runat="server" OnItemDataBound="rpView_ItemDataBound">
                                        <ItemTemplate>
                                            <tr>
                                                <td style="width:4%;"><asp:LinkButton ID="btDelete" data-toggle="tooltip" data-placement="bottom" title='<%# Eval("isRemoved").ToString() == "False" ? "Lock" : "Unlock" %>' runat="server" OnClick="btDelete_Click" OnClientClick="javascript: return confirm('Are you sure to lock/unlock this data?');"><%# Eval("isRemoved").ToString() == "False" ? "<i class='fa fa-unlock-alt' style='font-size:24px; color:blue;'></i>" : "<i class='fa fa-lock' style='font-size:24px; color:red;'></i>" %></asp:LinkButton></td>
                                                <td style="width:5%;"><asp:HyperLink ID="hlEdit" data-toggle="tooltip" data-placement="bottom" title="Edit" runat="server" NavigateUrl='<%# String.Format("user_gameinformation.aspx?action={0}", Eval("g_id"))%>'><i class="fa fa-edit" style="font-size:24px;"></i></asp:HyperLink></td>
                                                <td style="width:24%;"><%# Eval("g_name") %></td>
                                                <td style="width:5%;"><asp:HyperLink ID="hlPlay" data-toggle="tooltip" data-placement="bottom" title="Play" runat="server" NavigateUrl='<%# String.Format("user_play_game.aspx?id={0}", Eval("g_id"))%>' target="_blank"><i class="fa fa-play-circle-o" style="font-size:24px;"></i></asp:HyperLink></td>
                                                <td style="width:10%;"><%# Eval("g_platform") %></td>
                                                <td style="width:10%;"><%# Eval("g_category") %></td>
                                                <td style="width:10%;"><%# Eval("g_type") %></td>
                                                <td style="width:10%;"><%# Eval("isComming").ToString() == "0" ? "<strong style='color:blue;'>Present</strong>" : "<strong style='color:red;'>Comming</strong>" %></td>
                                                <td style="width:5%;"><%# Eval("g_image").ToString() != string.Empty ? "<i class='fa fa-check' style='font-size:18px; color:blue;'></i>" : "<i class='fa fa-close' style='font-size:18px; color:red;'></i>" %></td>
                                                <td style="width:5%;"><%# Eval("g_video").ToString() != string.Empty ? "<i class='fa fa-check' style='font-size:18px; color:blue;'></i>" : "<i class='fa fa-close' style='font-size:18px; color:red;'></i>" %></td>
                                                <td style="width:12%;"><asp:Label ID="lbCreateDate" runat="server"></asp:Label></td>
                                                <asp:HiddenField ID="hfGetId" runat="server" Value='<%# Eval("g_id") %>' />
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                            <hr />
                            <div class="pull-left">
                                <asp:HyperLink ID="hlRefresh" data-toggle="tooltip" data-placement="bottom" title="Refresh" runat="server" NavigateUrl="user_view_gameinformation.aspx"><i class="btn btn-default btn-sm fa fa-refresh"></i></asp:HyperLink>
                                <asp:LinkButton ID="btFirst" data-toggle="tooltip" data-placement="bottom" title="First Page" runat="server"></asp:LinkButton>
                                <asp:LinkButton ID="btPrevious" data-toggle="tooltip" data-placement="bottom" title="Previous Page" runat="server"></asp:LinkButton>
                                <asp:LinkButton ID="btNext" data-toggle="tooltip" data-placement="bottom" title="Next Page" runat="server"></asp:LinkButton>
                                <asp:LinkButton ID="btLast" data-toggle="tooltip" data-placement="bottom" title="Last Page" runat="server"></asp:LinkButton>
                                <asp:Label ID="lbShowTotalMessage" class="btn btn-default btn-sm" data-toggle="tooltip" data-placement="bottom" title="Show Total Data Count" runat="server"></asp:Label>
                                <asp:Label ID="lbPassing" class="btn btn-default btn-sm" data-toggle="tooltip" data-placement="bottom" title="Show Page Number" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

