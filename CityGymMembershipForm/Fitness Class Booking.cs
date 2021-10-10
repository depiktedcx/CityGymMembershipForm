﻿using System;
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

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityGymDatabaseDataSet);

        }

        private void Fitness_Class_Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityGymDatabaseDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.cityGymDatabaseDataSet.Booking);

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //lockout user from changing the ID after confirming their identity
            textBoxID.Enabled = false;
        }
    }
}
