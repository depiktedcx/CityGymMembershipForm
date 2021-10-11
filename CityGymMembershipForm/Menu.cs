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
    public partial class Menu : Form
    {
        Help helpInstance;
        public Menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Open Signup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJoin_Click(object sender, EventArgs e)
        {
            new Signup(this).Show();
            if(helpInstance != null)
            {
                helpInstance.Close();
            }
            this.Hide();
        }
        /// <summary>
        /// Open to see members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonView_Click(object sender, EventArgs e)
        {
            new Search_Members(this).Show();
            if (helpInstance != null)
            {
                helpInstance.Close();
            }
            this.Hide();
        }
        /// <summary>
        /// Open class booking form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBook_Click(object sender, EventArgs e)
        {
            new Fitness_Class_Booking(this).Show();
            if (helpInstance != null)
            {
                helpInstance.Close();
            }
            this.Hide();
        }
        /// <summary>
        /// Show help page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //check if an instance of help already exists or if the instance exists, is it active
            if (helpInstance == null || !helpInstance.getActive())
            {
                //if it exists but isn't active
                if(helpInstance != null)
                {
                    //dereference the inactive form and force garbage collection
                    helpInstance = null;
                    GC.Collect();
                }
                //create a new instance with this form as its start
                helpInstance = new Help("menu");
                helpInstance.Show();
            }
            //Check if the form is minimized
            if(helpInstance.WindowState == FormWindowState.Minimized)
            {
                //Bring it back up
                helpInstance.WindowState = FormWindowState.Normal;
            }
            //Set focus to form
            helpInstance.Focus();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            helpInstance = null;
            GC.Collect();
        }
    }
}
