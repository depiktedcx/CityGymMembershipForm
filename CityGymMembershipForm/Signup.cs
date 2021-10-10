using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGymMembershipForm
{
    public partial class Signup : Form
    {
        //easier access to values
        string membershipType = "";
        double membershipCost = 0;
        string duration = "";
        double extrasCost = 0;
        string frequency = "";
        double discount = 0;
        double totalCost = 0;
        double regularPayments = 0;
        List<string> extras = new List<string>();
        //menu instance
        Menu menuInstance;
        Help helpInstance;
        public Signup(Menu m)
        {
            InitializeComponent();
            //set up the form
            reset(null, null);
            menuInstance = m;
        }
        /// <summary>
        /// Calculate the cost of the membership
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculate()
        {
            //reset extras cost and selections to avoid doubling
            extrasCost = 0;
            extras.Clear();
            //check whether the box is checked and assign the cost of the extra
            extrasCost += (checkBox247.Checked) ? 1 : 0;
            if (checkBox247.Checked) { extras.Add("24/7 Access"); }
            extrasCost += (checkBoxTrainer.Checked) ? 20 : 0;
            if (checkBoxTrainer.Checked) { extras.Add("Personal Trainer"); }
            extrasCost += (checkBoxDiet.Checked) ? 20 : 0;
            if (checkBoxDiet.Checked) { extras.Add("Diet Consultation"); }
            extrasCost += (checkBoxVideos.Checked) ? 2 : 0;
            if (checkBoxVideos.Checked) { extras.Add("Online Video Access"); }
            //check the frequency of payment
            frequency = comboBoxFrequency.Text;
            //set cost of membership
            membershipType = comboBoxType.Text;
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    membershipCost = 10;
                    break;
                case 1:
                    membershipCost = 15;
                    break;
                case 2:
                    membershipCost = 20;
                    break;
                default:
                    MessageBox.Show("You shouldn't be here");
                    break;
            }
            //display the cost of membership in details
            textBoxMembership.Text = $"{membershipCost:C}";
            //add the discounts from the selected duration
            duration = comboBoxDuration.Text;
            switch (comboBoxDuration.SelectedIndex)
            {
                case 0:
                    discount = 0;
                    break;
                case 1:
                    discount = 2;
                    break;
                case 2:
                    discount = 5;
                    break;
                default:
                    MessageBox.Show("You shouldn't be here");
                    break;
            }
            //calculate the 1% discount of direct debit and add to discount
            discount += (checkBoxDirect.Checked) ? membershipCost * 0.01 : 0;
            //calculate the total cost
            totalCost = membershipCost + extrasCost - discount;
            //display the cost of the selected extras in details
            textBoxExtras.Text = $"{extrasCost:C}";
            //display the total cost of the membership and extras
            textBoxNet.Text = $"{totalCost * 4 * double.Parse(duration.Split(' ')[0]):C}";
            //display amount of discounts garnered
            textBoxDiscount.Text = $"{discount:C}";
            //display amount to pay per week/month
            regularPayments = (frequency.Equals("Monthly")) ? totalCost * 4 : totalCost;
            textBoxRegularPayments.Text = $"{regularPayments:C}";
        }
        private void calculate(object sender, EventArgs e)
        {
            calculate();
        }
        /// <summary>
        /// Reset the membership form to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset(object sender, EventArgs e)
        {
            //clear all text boxes
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxAddress.Clear();
            textBoxMobile.Clear();
            //reset to first value of dropbox
            comboBoxType.SelectedIndex = 0;
            comboBoxDuration.SelectedIndex = 0;
            comboBoxFrequency.SelectedIndex = 0;
            //uncheck checkboxes
            checkBox247.Checked = false;
            checkBoxDiet.Checked = false;
            checkBoxTrainer.Checked = false;
            checkBoxVideos.Checked = false;
            checkBoxDirect.Checked = false;
            //recalculate the costs
            calculate();
        }
        /// <summary>
        /// Prevent entry of non-numeric values in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numbersOnly(object sender, KeyPressEventArgs e)
        {
            //cast sender as textbox
            TextBox t = (TextBox)sender;
            //check if key is not backspace or one of the numbers. allows backspacing
            if ((!(e.KeyChar == (char)Keys.Back) && !(char.IsDigit(e.KeyChar))) )
            {
                //show tool tip for 1000ms
                toolTip1.Show("Only numbers are allowed in this textbox", t, 0, t.Height, 1000);
                e.Handled = true;
            }
            else if(t.Text.Length == 11)
            {
                //show tool tip for 1000ms
                toolTip1.Show("You can only have 11 characters in this textbox", t, 0, t.Height, 1000);
            }
        }
        /// <summary>
        /// Bring up confirmation screen and submit if OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //check if any detail textsboxes are empty
            if (textBoxFirstName.Text.Length <= 0 || textBoxLastName.Text.Length <= 0 || textBoxMobile.Text.Length <= 0 || textBoxAddress.Text.Length <= 0)
            {
                MessageBox.Show("You have not completed all fields", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //call calculate to update payment details if user has not clicked calculate
                calculate();
                //name, mobile, address of member. path of file where member data is stored. id of member
                string name = $"{textBoxFirstName.Text} {textBoxLastName.Text}";
                string mobile = textBoxMobile.Text;
                string address = textBoxAddress.Text;
                //what will be written to the text file
                string appendment = $@"Name: {name}
Mobile number: {mobile}
Address: {address}
Membership type: {membershipType}
Membership duration: {duration}
Frequency of payments: {frequency}";
                //add selected extras to text
                foreach (string s in extras)
                {
                    appendment = $@"{appendment}
Extra: {s}";
                }
                //add financial information
                appendment = $@"{appendment}
Membership cost: {membershipCost:C}
Extras cost: {extrasCost:C}
Discount received: {discount:C}
Total cost: {totalCost * 4 * double.Parse(duration.Split(' ')[0]):C}
Regular payments: {regularPayments:C}
";
                //display information given to form to user
                DialogResult result = MessageBox.Show($@"You are about to submit the following information:
{appendment}", "Confirm details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //check if button pressed was "ok"
                if (result == DialogResult.OK)
                {
                    //try write to database
                    try
                    {
                        //new member row
                        CityGymDatabaseDataSet.MemberRow memberRow = cityGymDatabaseDataSet.Member.NewMemberRow();
                        memberRow.Firstname = textBoxFirstName.Text;
                        memberRow.Lastname = textBoxLastName.Text;
                        memberRow.Address = address;
                        memberRow.Mobile = mobile;
                        memberRow.DirectDebit = checkBoxDirect.Checked;
                        memberRow.PaymentFrequency = comboBoxFrequency.Text;
                        memberRow.MembershipExpiry = DateTime.Today.AddMonths(Int32.Parse(comboBoxDuration.Text.Split(' ')[0]));
                        memberRow._24HourAccess = checkBox247.Checked;
                        memberRow.DietConsultation = checkBoxDiet.Checked;
                        memberRow.PersonalTrainer = checkBoxTrainer.Checked;
                        memberRow.OnlineVideoAccess = checkBoxVideos.Checked;
                        //add to database
                        cityGymDatabaseDataSet.Member.Rows.Add(memberRow);
                        this.tableAdapterManager.UpdateAll(cityGymDatabaseDataSet);
                        DataRow last = cityGymDatabaseDataSet.Member.Rows[cityGymDatabaseDataSet.Member.Rows.Count - 1];
                        MessageBox.Show($"Member assigned MemberID {last[0]}");
                        //new membermembership row
                        CityGymDatabaseDataSet.MemberMembershipRow memberMembershipRow = cityGymDatabaseDataSet.MemberMembership.NewMemberMembershipRow();
                        memberMembershipRow.MemberID = Int32.Parse(last[0].ToString());
                        memberMembershipRow.MembershipID = comboBoxType.SelectedIndex + 1;
                        //add to database
                        cityGymDatabaseDataSet.MemberMembership.Rows.Add(memberMembershipRow);
                        this.tableAdapterManager.UpdateAll(cityGymDatabaseDataSet);
                        //reset form
                        reset(sender, null);
                    }
                    catch (Exception ex)
                    {
                        //display error if error occurs
                        MessageBox.Show($"An error occurred when attempting to write to file:\n{ex.Message}");
                    }
                }
            }
        }
        /// <summary>
        /// Prevent entry of numeric and special character entry, excludes hyphens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alphaOnly(object sender, KeyPressEventArgs e)
        {
            //prevents entry of anything not a letter or hyphen. allows backspacing
            if ((!(e.KeyChar == '-') && !char.IsLetter(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                //cast sender object as textbox
                TextBox t = (TextBox)sender;
                //show tool tip for 1000ms
                toolTip1.Show("Only letters and hyphens are allowed in this textbox", t, 0, t.Height, 1000);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Show menu again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuInstance.Show();
            helpInstance = null;
            GC.Collect();
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
                helpInstance = new Help("signup");
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
