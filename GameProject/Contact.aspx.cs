/**
 * File Name: Contact.aspx.cs
 * Author Name: Robert Reynolds
 * Student Number: 200288068
 * Date Modified: June 8th, 2016
 * Website Name: http://200288068-project.azurewebsites.net/
 * Version: 0.0.1 - Initial Version
 * File Description: Code behind file for contact.aspx
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameProject
{
    public partial class Contact : System.Web.UI.Page
    {
        /**
         * Method that runs on page load
         * 
         * @method Page_Load
         * @return {void}
         */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /**
         * Method that runs email processing code when send button is clicked
         * @method SendButton_Click
         * @return {void}
         */
        protected void SendButton_Click(object sender, EventArgs e)
        {
            //Replace this code with email processing code
            Response.Redirect("Default.aspx");
        }
    }
}