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
    public partial class Fitness_Class_Booking : Form
    {
        Menu menuInstance;
        public Fitness_Class_Booking(Menu m)
        {
            InitializeComponent();
            menuInstance = m;
        }
        /// <summary>
        /// Show menu again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fitness_Class_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuInstance.Show();
        }
    }
}
