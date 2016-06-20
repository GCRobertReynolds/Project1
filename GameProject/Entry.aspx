<%-- File Name: Entry.aspx
Author Name: Robert Reynolds
Student Number: 200288068
Date Modified: June 8th, 2016
Website Name: http://200288068-project.azurewebsites.net/
Version: 0.0.1 - Initial Version
File Description: entry page --%>

<%@ Page Title="Entry" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="GameProject.Entry" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Game Details</h1>
                <h5>All Fields are Required!</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="GameIDTextBox">Game ID</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="GameIDTextBox" placeholder="Game ID" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameTitleTextBox">Game Title</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="GameTitleTextBox" placeholder="Game Title" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameTypeTextBox">Game Type</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="GameTypeTextBox" placeholder="Game Type" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameDateTextBox">Game Date</label>
                    <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" id="GameDateTextBox" placeholder="Game Date" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameTurnsTextBox">Game Turns</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="GameTurnsTextBox" placeholder="Game Turns" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameServerTextBox">Game Server</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="GameServerTextBox" placeholder="Game Server" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameSpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="GameSpectatorsTextBox" placeholder="Spectators" required="true"></asp:TextBox>
                </div>
                <div class="textright">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
