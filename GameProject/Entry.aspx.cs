using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Using statements that are required to connect to Entity Framework Database
using GameProject.Models;
using System.Web.ModelBinding;

namespace GameProject
{
    public partial class Entry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /**
         * 
         * <summary>
         * This method redirects the user back if the cancel button is clicked
         * </summary>
         * 
         * @method CancelButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         * returns {void}
         * 
         */
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //Redirect back to Tracking page
            Response.Redirect("~/Tracking.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}