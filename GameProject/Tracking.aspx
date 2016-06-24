<%-- File Name: Tracking.aspx
Author Name: Robert Reynolds
Student Number: 200288068
Date Modified: June 8th, 2016
Website Name: http://200288068-project.azurewebsites.net/
Version: 0.0.1 - Initial Version
File Description: tracking page --%>

<%@ Page Title="Tracking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tracking.aspx.cs" Inherits="GameProject.Tracking" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">

                <h1>Games List</h1>
                <a href="Entry.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus"></i> Add Game</a>

                <div>
                    <label for="PageSizeDropDownList">Records Per Page: </label>
                    <asp:DropDownList ID="PageSizeDropDownList" runat="server" AutoPostBack="true" 
                        CssClass="btn btn-default btn-sm dropdown-toggle" OnSelectedIndexChanged="PageSizeDropDownList_SelectedIndexChanged">
                        <asp:ListItem Text="3" Value="3"/>
                        <asp:ListItem Text="5" Value="5"/>
                        <asp:ListItem Text="10" Value="10"/>
                        <asp:ListItem Text="All" Value="10000"/>
                    </asp:DropDownList>
                </div>
                
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover" ID="GamesGridView" 
                    AutoGenerateColumns="false" DataKeyNames="GameTitle" OnRowDeleting="GamesGridView_RowDeleting" AllowPaging="true" 
                    PageSize="3" OnPageIndexChanging="GamesGridView_PageIndexChanging" AllowSorting="true" OnSorting="GamesGridView_Sorting"
                    OnRowDataBound="GamesGridView_RowDataBound" >

                    <Columns>
                        <%--<asp:BoundField DataField="GameID" HeaderText="Game ID" Visible="true" />--%> 
                        <asp:BoundField DataField="GameTitle" HeaderText="Game Title" Visible="true" SortExpression="GameTitle"/>
                        <asp:BoundField DataField="GameType" HeaderText="Game Type" Visible="true" SortExpression="GameType"/>
                        <asp:BoundField DataField="GameDate" HeaderText="Date" Visible="true" 
                            DataFormatString="{0:MMM dd, yyyy}" SortExpression="GameDate"/>
                        <asp:BoundField DataField="GameTurns" HeaderText="Turns" Visible="true" SortExpression="GameTurns"/>
                        <asp:BoundField DataField="GameServer" HeaderText="Game Server" Visible="true" SortExpression="GameServer"/>
                        <asp:BoundField DataField="GameSpectators" HeaderText="Spectators" Visible="true" SortExpression="GameSpectators"/>
                        <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit" 
                            NavigateUrl="~/Statistics.aspx" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server" DataNavigateUrlFields="GameTitle" DataNavigateUrlFormatString="Entry.aspx?GameTitle={0}" />
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete" ShowDeleteButton="true" ButtonType="Link"
                            ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>

                </asp:GridView>

            </div>
        </div>
    </div>


</asp:Content>
