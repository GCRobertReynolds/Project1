﻿/**
 * File Name: Jumbrotron.ascx.cs
 * Author Name: Robert Reynolds
 * Student Number: 200288068
 * Date Modified: June 19th, 2016
 * Website Name: http://200288068-project.azurewebsites.net/
 * Version: 0.0.2 - Updated SetActivePage Method
 * File Description: Code behind file for navbar user control
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace GameProject
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        /**
         * Method that runs on page load
         * 
         * @method Page_Load
         * @return {void}
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Check if a user is logged in
                if(HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    //Show the Game content area
                    GamesPlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;

                    if(HttpContext.Current.User.Identity.GetUserName() == "admin")
                    {
                        UserPlaceHolder.Visible = true;
                    }
                }
                else
                {
                    //Only show Login and Register
                    GamesPlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                    UserPlaceHolder.Visible = false;
                }
                SetActivePage();
            }
        }

        /**
         * This method adds a CSS class of "active" to list items related to
         * navigation links of each page
         * 
         * @method SetActivePage
         * @return {void}
         */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Register":
                    register.Attributes.Add("class", "active");
                    break;
                case "Login":
                    login.Attributes.Add("class", "active");
                    break;
                case "Entry":
                    entry.Attributes.Add("class", "active");
                    break;
                case "Tracking":
                    tracking.Attributes.Add("class", "active");
                    break;
                case "Statistics":
                    statistics.Attributes.Add("class", "active");
                    break;
                case "Calendar":
                    calendar.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
                case "GameMenu":
                    menu.Attributes.Add("class", "active");
                    break;
                case "Users":
                    users.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}