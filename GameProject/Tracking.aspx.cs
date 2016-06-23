using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Using statements that are required to connect to Entity Framework Database
using GameProject.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace GameProject
{
    public partial class Tracking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If loading the page for the first time then populate GameGridView
            if(!IsPostBack)
            {
                Session["SortColumn"] = "GameType"; //Default sort column
                Session["SortDirection"] = "ASC";

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
                string SortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();
                //Query the Games Table using Entity Framework and LINQ
                var Games = (from allGames in db.GameInfoes
                             select allGames);

                //Bind the result to the GridView
                GamesGridView.DataSource = Games.AsQueryable().OrderBy(SortString).ToList();
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

        /**
         * 
         * <summary>
         * This event handler sets the page size 
         * </summary>
         * 
         * @method PageSizeDropDownList_SelectedIndexChanged
         * @param {object} sender
         * @param {EventArgs} e
         * @returns {void}
         * 
         */
        protected void PageSizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the new page size
            GamesGridView.PageSize = Convert.ToInt32(PageSizeDropDownList.SelectedValue);

            //Refresh the GridView
            this.GetGames();
        }

        /**
         * 
         * <summary>
         *  
         * </summary>
         * 
         * @method GamesGridView_Sorting
         * @param {object} sender
         * @param {GridViewSortEventArgs} e
         * @returns {void}
         * 
         */
        protected void GamesGridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            //Get the column to sort by
            Session["SortColumn"] = e.SortExpression;

            //Refresh the GridView
            this.GetGames();

            //Toggle the direction
            Session["SortDirection"] = Session["SortDirection"].ToString() == "ASC" ? "DESC" : "ASC";
        }

        /**
        * 
        * <summary>
        *  
        * </summary>
        * 
        * @method GamesGridView_RowDataBound
        * @param {object} sender
        * @param {GridViewRowEventArgs} e
        * @returns {void}
        * 
        */
        protected void GamesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(IsPostBack)
            {
                if(e.Row.RowType == DataControlRowType.Header) //If header row has been clicked
                {
                    LinkButton linkbutton = new LinkButton();

                    for (int index = 0; index < GamesGridView.Columns.Count -1; index++)
                    {
                        if (GamesGridView.Columns[index].SortExpression == Session["SortColumn"].ToString())
                        {
                            if(Session["SortDirection"].ToString() == "ASC")
                            {
                                linkbutton.Text = " <i class='fa fa-caret-up fa-lg'></i>";
                            }
                            else
                            {
                                linkbutton.Text = " <i class='fa fa-caret-down fa-lg'></i>";
                            }

                            e.Row.Cells[index].Controls.Add(linkbutton);
                        }
                    }
                }
            }
        }
    }
}