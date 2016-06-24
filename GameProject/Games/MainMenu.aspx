<%@ Page Title="GameMenu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="GameProject.MainMenu" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Main Menu</h1>
                <div class="well">
                    <h3><i class="fa fa-leanpub fa-lg"></i> Students</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="Students.aspx"><i class="fa fa-th-list"></i> Student List</a>
                        <a class="list-group-item" href="StudentDetails.aspx"><i class="fa fa-plus-circle"></i> Add Student</a>
                    </div>
                </div>
                <div class="well">
                    <h3><i class="fa fa-book fa-lg"></i> Courses</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="/Games/Courses.aspx"><i class="fa fa-th-list"></i> Course List</a>
                        <a class="list-group-item" href="/Games/CourseDetails.aspx"><i class="fa fa-plus-circle"></i> Add Courses</a>
                    </div>
                </div>
                <div class="well">
                    <h3><i class="fa fa-puzzle-piece fa-lg"></i> Departments</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="/Games/Departments.aspx"><i class="fa fa-th-list"></i> Department List</a>
                        <a class="list-group-item" href="/Games/DepartmentDetails.aspx"><i class="fa fa-plus-circle"></i> Add Department</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>