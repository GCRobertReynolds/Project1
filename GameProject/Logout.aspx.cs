﻿using System;
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
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Store session info and authentication methods in the auth object
            var auth = HttpContext.Current.GetOwinContext().Authentication;

            //Sign out
            auth.SignOut();

            //Redirect to the Default page
            Response.Redirect("~/Login.aspx");

        }
    }
}