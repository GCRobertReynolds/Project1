<%@ Page Title="GameMenu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="GameProject.MainMenu" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Main Menu</h1>
                <div class="well">
                    <h3><i class="fa fa-arrows-alt fa-lg"></i> Tracking</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="Tracking.aspx"><i class="fa fa-th-list"></i> Game List</a>
                        <a class="list-group-item" href="Entry.aspx"><i class="fa fa-plus-circle"></i> Add Game</a>
                    </div>
                </div>
                <div class="well">
                    <h3><i class="fa fa-bar-chart fa-lg"></i> Statistics</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="/Games/Statistics.aspx"><i class="fa fa-th-list"></i> Statistics Page</a> 
                    </div>
                </div>
                <div class="well">
                    <h3><i class="fa fa-calendar fa-lg"></i> Calendar</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="/Games/Calendar.aspx"><i class="fa fa-th-list"></i> Calendar Page</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>