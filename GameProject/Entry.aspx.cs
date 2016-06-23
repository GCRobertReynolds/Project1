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
            if((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetGame();
            }
        }

        protected void GetGame()
        {
            //Populate the form with existing data from the database
            //int GameID = Convert.ToInt32(Request.QueryString["GameID"]):
            string GameTitle = Request.QueryString["GameTitle"];

            //Connect to the Entity Framework Database
            using (DefaultConnection db = new DefaultConnection())
            {
                //Populate a game object instance with the GameID from the URL Param
                GameInfo updatedGame = (from GameInfo in db.GameInfoes
                                        where GameInfo.GameTitle == GameTitle
                                        select GameInfo).FirstOrDefault();

                //Map the game properties to the form controls
                if(updatedGame != null)
                {
                    GameTitleTextBox.Text = updatedGame.GameTitle;
                    GameTypeTextBox.Text = updatedGame.GameType;
                    GameDateTextBox.Text = updatedGame.GameDate.ToString("yyyy-MM-dd");
                    GameTurnsTextBox.Text = Convert.ToString(updatedGame.GameTurns);
                    GameServerTextBox.Text = updatedGame.GameServer;
                    GameSpectatorsTextBox.Text = Convert.ToString(updatedGame.GameSpectators);
                }
            }
        }
        /**
         * 
         * <summary>
         * This method redirects the user back to the tracking page if the cancel button is clicked
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

        /**
         * 
         * <summary>
         * 
         * </summary>
         * 
         */
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            //Use Entity Framework to connect to the server
            using (DefaultConnection db = new DefaultConnection())
            {
                //Use the Game model to create a new game object
                //and save a new record
                GameInfo newGame = new GameInfo();

                //int GameID = 0;
                //if(Request.QueryString.Count > 0) //our URL has an ID in it
                //{
                    //Get the ID from the URL 
                    //GameID = Convert.ToInt32(Request.QueryString["GameID"]);

                    //Get the current game from the Entity Framework Database
                    //newGame = (from GameInfo in db.GameInfoes
                               //where GameInfo.GameID == GameID
                               //select GameInfo).FirstOrDefault();
                //}

                //Add data to the new game record
                //newGame.GameID = Convert.ToInt32(GameIDTextBox.Text);
                newGame.GameTitle = GameTitleTextBox.Text;
                newGame.GameType = GameTypeTextBox.Text;
                newGame.GameDate = Convert.ToDateTime(GameDateTextBox.Text);
                newGame.GameTurns = Convert.ToInt32(GameTurnsTextBox.Text);
                newGame.GameServer = GameServerTextBox.Text;
                newGame.GameSpectators = Convert.ToInt32(GameSpectatorsTextBox.Text);

                //Use LINQ/ADO.NET to insert new game into the database

                //if(GameID == 0)
                //{
                //    db.GameInfoes.Add(newGame);
                //}

                //Save our changes
                db.SaveChanges();

                //Redirect back to the updated game page
                Response.Redirect("~/Tracking.aspx");
            }
        }
    }
}