<%-- File Name: Navbar.ascx
Author Name: Robert Reynolds
Student Number: 200288068
Date Modified: June 8th, 2016
Website Name: http://200288068-project.azurewebsites.net/
Version: 0.0.1 - Initial Version
File Description: navbar user control --%>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="GameProject.Navbar" %>
<nav class="navbar navbar-inverse" role="navigation">
    <div class="container-fluid">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Default.aspx"><i class="fa fa-trophy fa-lg"></i> Sports Scores</a>            
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">           
            <ul class="nav navbar-nav navbar-right">
                <li id="home" runat="server"><a href="Default.aspx"><i class="fa fa-home fa-lg"></i> Home</a></li>
                <li id="register" runat="server"><a href="Register.aspx"><i class="fa fa-user-plus fa-lg"></i> Register</a></li>
                <li id="login" runat="server"><a href="Login.aspx"><i class="fa fa-sign-in fa-lg"></i> Login</a></li>
                <li id="entry" runat="server"><a href="Entry.aspx"><i class="fa fa-edit fa-lg"></i> Entry</a></li>
                <li id="tracking" runat="server"><a href="Tracking.aspx"><i class="fa fa-arrows-alt fa-lg"></i> Tracking</a></li>
                <li id="statistics" runat="server"><a href="Statistics.aspx"><i class="fa fa-bar-chart fa-lg"></i> Statistics</a></li>
                <li id="calendar" runat="server"><a href="Calendar.aspx"><i class="fa fa-calendar fa-lg"></i> Calendar</a></li>
                <li id="contact" runat="server"><a href="Contact.aspx"><i class="fa fa-phone fa-lg"></i> Contact Us</a></li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>