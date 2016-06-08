/**
 * File Name: Jumbrotron.ascx.cs
 * Author Name: Robert Reynolds
 * Student Number: 200288068
 * Date Modified: June 8th, 2016
 * Website Name: http://200288068-project.azurewebsites.net/
 * Version: 0.0.1 - Initial Version
 * File Description: Code behind file for jumbrotron user control
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameProject.User_Controls
{

    public partial class Jumbotron : System.Web.UI.UserControl
    {
        /**
         * Method that runs on page load
         * 
         * @method Page_Load
         * @return {void}
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //Change the text of jumbotron control on page load
            //JumbotronH1.InnerText = "Welcome!";
        }
    }
}