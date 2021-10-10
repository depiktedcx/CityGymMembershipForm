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
        Help helpInstance;
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
            helpInstance = null;
            GC.Collect();
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
            //TODO: disable editing of memberID textbox
            //TODO: disable member search button
            //TODO: disable confirm button
            //TODO: enable reset member button
            //TODO: enable datagrid to allow class selection
            //TODO: enable book class button
        }

        private void buttonResetMember_Click(object sender, EventArgs e)
        {
            //TODO: enable editing of memberID textbox
            //TODO: enable member search button
            //TODO: enable confirm button
            //TODO: disable reset member button
            //TODO: disable datagrid to allow class selection
            //TODO: disable book class button
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
                if (helpInstance != null)
                {
                    //dereference the inactive form and force garbage collection
                    helpInstance = null;
                    GC.Collect();
                }
                //create a new instance with this form as its start
                helpInstance = new Help("book");
                helpInstance.Show();
            }
            if (helpInstance.WindowState == FormWindowState.Minimized)
            {
                helpInstance.WindowState = FormWindowState.Normal;
            }
            helpInstance.Focus();
        }
    }
}
