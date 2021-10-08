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

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            new Signup(this).Show();
            this.Hide();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            new Search_Members(this).Show();
            this.Hide();
        }
    }
}
