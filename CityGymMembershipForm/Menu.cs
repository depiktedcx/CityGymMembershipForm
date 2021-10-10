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
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            new Help("menu").Show();
        }
    }
}
