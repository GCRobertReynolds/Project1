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
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover" ID="GamesGridView" 
                    AutoGenerateColumns="false" DataKeyNames="GameID" OnRowDeleting="GamesGridView_RowDeleting" >

                    <Columns>
                        <%--<asp:BoundField DataField="GameID" HeaderText="Game ID" Visible="true" />--%>
                        <asp:BoundField DataField="GameTitle" HeaderText="Game Title" Visible="true" />
                        <asp:BoundField DataField="GameType" HeaderText="Game Type" Visible="true" />
                        <asp:BoundField DataField="GameDate" HeaderText="Date" Visible="true" 
                            DataFormatString="{0:MMM dd, yyyy}" />
                        <asp:BoundField DataField="GameTurns" HeaderText="Turns" Visible="true" />
                        <asp:BoundField DataField="GameServer" HeaderText="Game Server" Visible="true" />
                        <asp:BoundField DataField="GameSpectators" HeaderText="Spectators" Visible="true" />
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete" ShowDeleteButton="true" ButtonType="Link"
                            ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>

                </asp:GridView>

            </div>
        </div>
    </div>


</asp:Content>
