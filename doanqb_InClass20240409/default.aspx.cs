using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanqb_InClass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This should only run once when the page is initially loaded in the browser
            if (!Page.IsPostBack)
            {
                lbFruits.Items.Add("Strawberry");

            }
        }
        // I need an event that will run when the user,
        // in their browser, selects a fruit from the list box
        // "event=driven" programming
        // Our event is the user selected an item from the list box
        protected void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This code runs when the user select a new item from the lbFruits List Box
            //Copy the currently selected item from the list box into our label
            lblChosenFruit.Text = lbFruits.SelectedValue;
        }
    }
}