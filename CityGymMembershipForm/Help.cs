using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGymMembershipForm
{
    public partial class Help : Form
    {
        //Offset the form window
        const int OFFSET = 100;
        //Natural windows offset
        const int WINDOWS_OFFSET = 14;
        //Offset the buttons
        const int BUTTON_OFFSET = 10;
        //Current page
        string activePage = "";
        //Active state
        bool active;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">Page to start the help window on</param>
        public Help(string page)
        {
            InitializeComponent();
            //Move window to top left
            this.Location = new Point(0, 0);
            //Sets active state to true and sets active page to page which was parsed
            //Calls to show the correct page
            active = true;
            activePage = page;
            showPage();
        }
        /// <summary>
        /// Set the active page to the next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //Check which page is currently being displayed
            //Set that page to be invisible
            //Set active page to next page
            if (pictureBoxMenu.Visible)
            {
                pictureBoxMenu.Visible = false;
                activePage = "signup";
            }else if (pictureBoxSignup.Visible)
            {
                pictureBoxSignup.Visible = false;
                activePage = "search";
            }
            else if (pictureBoxSearch.Visible)
            {
                pictureBoxSearch.Visible = false;
                activePage = "book";
            }
            else
            {
                pictureBoxBooking.Visible = false;
                activePage = "menu";
            }
            //Show the next page
            showPage();
        }
        /// <summary>
        /// Show the active page
        /// </summary>
        private void showPage()
        {
            //Check which page is active
            //All cases are the same but just with their respective controls
            switch (activePage)
            {
                case "menu":
                    //Set the form width and height to the same as the image and the relevant offsets
                    this.Width = pictureBoxMenu.Image.Width + WINDOWS_OFFSET;
                    this.Height = pictureBoxMenu.Image.Height + OFFSET;
                    //Set the picturebox width and height to the same as the image
                    pictureBoxMenu.Width = pictureBoxMenu.Image.Width;
                    pictureBoxMenu.Height = pictureBoxMenu.Image.Height;
                    //Set the picturebox to top left corner
                    pictureBoxMenu.Location = new Point(0, 0);
                    //Show picturebox
                    pictureBoxMenu.Visible = true;
                    //break out of case
                    break;
                case "search":
                    this.Width = pictureBoxSearch.Image.Width + WINDOWS_OFFSET;
                    this.Height = pictureBoxSearch.Image.Height + OFFSET;
                    pictureBoxSearch.Width = pictureBoxSearch.Image.Width;
                    pictureBoxSearch.Height = pictureBoxSearch.Image.Height;
                    pictureBoxSearch.Location = new Point(0, 0);
                    pictureBoxSearch.Visible = true;
                    break;
                case "book":
                    this.Width = pictureBoxBooking.Image.Width + WINDOWS_OFFSET;
                    this.Height = pictureBoxBooking.Image.Height + OFFSET;
                    pictureBoxBooking.Width = pictureBoxBooking.Image.Width;
                    pictureBoxBooking.Height = pictureBoxBooking.Image.Height;
                    pictureBoxBooking.Location = new Point(0, 0);
                    pictureBoxBooking.Visible = true;
                    break;
                case "signup":
                    this.Width = pictureBoxSignup.Image.Width + WINDOWS_OFFSET;
                    this.Height = pictureBoxSignup.Image.Height + OFFSET;
                    pictureBoxSignup.Width = pictureBoxSignup.Image.Width;
                    pictureBoxSignup.Height = pictureBoxSignup.Image.Height;
                    pictureBoxSignup.Location = new Point(0, 0);
                    pictureBoxSignup.Visible = true;
                    break;
                default:
                    //Display an error if referenced page doesn't exist
                    MessageBox.Show($"An error has ocurred within the page switch. No page correlated to \"{activePage}\"");
                    break;
            }
            //Move the buttons to their respective corners
            buttonNext.Location = new Point(Width - (buttonNext.Width + 10 + WINDOWS_OFFSET), Height - (buttonNext.Height + OFFSET / 2));
            buttonPrev.Location = new Point(BUTTON_OFFSET, Height - (buttonPrev.Height + OFFSET / 2));
        }
        /// <summary>
        /// Set the active page to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //Check which page is currently visiable
            //Set that page to be invisible
            //Set active page to be previous page
            if (pictureBoxMenu.Visible)
            {
                pictureBoxMenu.Visible = false;
                activePage = "book";
            }
            else if (pictureBoxSignup.Visible)
            {
                pictureBoxSignup.Visible = false;
                activePage = "menu";
            }
            else if (pictureBoxSearch.Visible)
            {
                pictureBoxSearch.Visible = false;
                activePage = "signup";
            }
            else
            {
                pictureBoxBooking.Visible = false;
                activePage = "search";
            }
            //Show the previous page
            showPage();
        }
        /// <summary>
        /// Set the active to false when the form has been closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            active = false;
        }
        /// <summary>
        /// Returns page active state
        /// </summary>
        /// <returns>Returns whether or not the page is active</returns>
        public bool getActive()
        {
            return active;
        }
    }
}
