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
        const int OFFSET = 100;
        const int BUTTON_OFFSET = 10;
        string active = "";
        public Help(string page)
        {
            active = page;
            InitializeComponent();
            showPage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pictureBoxMenu.Visible)
            {
                pictureBoxMenu.Visible = false;
                active = "signup";
            }else if (pictureBoxSignup.Visible)
            {
                pictureBoxSignup.Visible = false;
                active = "search";
            }
            else if (pictureBoxSearch.Visible)
            {
                pictureBoxSearch.Visible = false;
                active = "book";
            }
            else
            {
                pictureBoxBooking.Visible = false;
                active = "menu";
            }
            showPage();
        }

        private void showPage()
        {
            switch (active)
            {
                case "menu":
                    this.Width = pictureBoxMenu.Image.Width;
                    this.Height = pictureBoxMenu.Image.Height + OFFSET;
                    pictureBoxMenu.Width = pictureBoxMenu.Image.Width;
                    pictureBoxMenu.Height = pictureBoxMenu.Image.Height;
                    pictureBoxMenu.Location = new Point(0, 0);
                    pictureBoxMenu.Visible = true;
                    break;
                case "search":
                    this.Width = pictureBoxSearch.Image.Width;
                    this.Height = pictureBoxSearch.Image.Height + OFFSET;
                    pictureBoxSearch.Width = pictureBoxSearch.Image.Width;
                    pictureBoxSearch.Height = pictureBoxSearch.Image.Height;
                    pictureBoxSearch.Location = new Point(0, 0);
                    pictureBoxSearch.Visible = true;
                    break;
                case "book":
                    this.Width = pictureBoxBooking.Image.Width;
                    this.Height = pictureBoxBooking.Image.Height + OFFSET;
                    pictureBoxBooking.Width = pictureBoxBooking.Image.Width;
                    pictureBoxBooking.Height = pictureBoxBooking.Image.Height;
                    pictureBoxBooking.Location = new Point(0, 0);
                    pictureBoxBooking.Visible = true;
                    Console.WriteLine(active);
                    break;
                case "signup":
                    this.Width = pictureBoxSignup.Image.Width;
                    this.Height = pictureBoxSignup.Image.Height + OFFSET;
                    pictureBoxSignup.Width = pictureBoxSignup.Image.Width;
                    pictureBoxSignup.Height = pictureBoxSignup.Image.Height;
                    pictureBoxSignup.Location = new Point(0, 0);
                    pictureBoxSignup.Visible = true;
                    break;
            }
            buttonNext.Location = new Point(Width - (buttonNext.Width + 10), Height - (buttonNext.Height + OFFSET / 2));
            buttonPrev.Location = new Point(BUTTON_OFFSET, Height - (buttonPrev.Height + OFFSET / 2));
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (pictureBoxMenu.Visible)
            {
                pictureBoxMenu.Visible = false;
                active = "book";
            }
            else if (pictureBoxSignup.Visible)
            {
                pictureBoxSignup.Visible = false;
                active = "menu";
            }
            else if (pictureBoxSearch.Visible)
            {
                pictureBoxSearch.Visible = false;
                active = "signup";
            }
            else
            {
                pictureBoxBooking.Visible = false;
                active = "search";
            }
            showPage();
        }
    }
}
