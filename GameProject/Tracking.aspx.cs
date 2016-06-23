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
    public partial class Tracking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If loading the page for the first time then populate GameGridView
            if(!IsPostBack)
            {
                //Get the game data
                this.GetGames();
            }
        }

        /**
         * 
         * <summary>
         * This method gets the game data from the database
         * </summary>
         * 
         * @method GetGames
         * @returns {void}
         * 
         */
        protected void GetGames()
        {
            //Connect to Entity Framework
            using (DefaultConnection db = new DefaultConnection())
            {
                //Query the Games Table using Entity Framework and LINQ
                var Games = (from allGames in db.GameInfoes
                             select allGames);

                //Bind the result to the GridView
                GamesGridView.DataSource = Games.ToList();
                GamesGridView.DataBind(); //Creates 1-way Data Binding
            }
        }

        /**
         * 
         * <summary>
         * This event handler deletes a game from the database using Entity Framework
         * </summary>
         * 
         * @method GamesGridView_RowDeleting
         * @param {object} sender
         * @param {GridViewDeleteEventArgs} e
         * @returns {void}
         * 
         */
        protected void GamesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Store which row was clicked
            int selectedRow = e.RowIndex;

            //Get the selected GameID using the Grid's DataKey collection
            //int GameID = Convert.ToInt32(GamesGridView.DataKeys[selectedRow].Values["GameID"]);
            string GameTitle = Convert.ToString(GamesGridView.DataKeys[selectedRow].Values["GameTitle"]);

            //Use the Entity Framework to find the selected game in the database and remove it
            using (DefaultConnection db = new DefaultConnection())
            {
                //Create object of game class and store the query string inside of it
                GameInfo deletedGame = (from GameInfo in db.GameInfoes
                                        where GameInfo.GameTitle == GameTitle
                                        select GameInfo).FirstOrDefault();

                //Remove the selected game from the database
                db.GameInfoes.Remove(deletedGame);

                //Save changes to the database
                db.SaveChanges();

                //Refresh the GridView
                this.GetGames();
            }
        }

        /**
         * 
         * <summary>
         * This event handler allows pagination to occur for the game Tracking page
         * </summary>
         * 
         * @method GamesGridView_PageIndexChanging
         * @param {object} sender
         * @param {GridViewPageEventArgs} e
         * @returns {void}
         * 
         */
        protected void GamesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //Set the new page number
            GamesGridView.PageIndex = e.NewPageIndex;

            //Refresh the GridView
            this.GetGames();
        }
    }
}