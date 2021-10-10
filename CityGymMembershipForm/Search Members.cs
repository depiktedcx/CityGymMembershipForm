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
    public partial class Search_Members : Form
    {
        //Menu instance
        Menu menuInstance;
        Help helpInstance;
        public Search_Members(Menu m)
        {
            InitializeComponent();
            //set starting index
            comboBoxSearch.SelectedIndex = 0;
            comboBoxMembership.SelectedIndex = 0;
            //by default hid the membership filter box
            comboBoxMembership.Visible = false;
            //hold the menu instance
            menuInstance = m;
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityGymDatabaseDataSet);

        }

        private void Search_Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityGymDatabaseDataSet.MemberMembership' table. You can move, or remove it, as needed.
            this.memberMembershipTableAdapter.Fill(this.cityGymDatabaseDataSet.MemberMembership);
            // TODO: This line of code loads data into the 'cityGymDatabaseDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.cityGymDatabaseDataSet.Member);

        }
        /// <summary>
        /// Reset datagrid view and search filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearch.SelectedIndex = 0;
            comboBoxMembership.SelectedIndex = 0;
            memberDataGridView.DataSource = cityGymDatabaseDataSet.Member;
        }
        /// <summary>
        /// Filter members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if searching by membership or others
                if (textBoxSearch.Visible)
                {
                    DataView dataView = new DataView(cityGymDatabaseDataSet.Member);
                    //check the search type
                    switch (comboBoxSearch.Text)
                    {
                        case "Any":
                            //try parse the text as an int
                            if (int.TryParse(textBoxSearch.Text, out int parse))
                            {
                                //include memberid in search if it can be parsed as int
                                dataView.RowFilter = $"[MemberID] = {parse} OR [Firstname] LIKE '*{textBoxSearch.Text}*' OR [Lastname] LIKE '*{textBoxSearch.Text}*'" +
                                    $" OR [Address] LIKE '*{textBoxSearch.Text}*' OR [Mobile] LIKE '*{textBoxSearch.Text}*'";
                            }
                            else
                            {
                                //exclude memberid from search if parse fails
                                dataView.RowFilter = $"[Firstname] LIKE '*{textBoxSearch.Text}*' OR [Lastname] LIKE '*{textBoxSearch.Text}*'" +
                                    $" OR [Address] LIKE '*{textBoxSearch.Text}*' OR [Mobile] LIKE '*{textBoxSearch.Text}*'";
                            }
                            break;
                        case "MemberID":
                            //filter by memberid
                            dataView.RowFilter = $"[MemberID] = {int.Parse(textBoxSearch.Text)}";
                            break;
                        default:
                            //filter everything else
                            dataView.RowFilter = $"{comboBoxSearch.Text} LIKE '*{textBoxSearch.Text}*'";
                            break;
                    }
                    //show data on datagrid
                    memberDataGridView.DataSource = dataView;
                }
                else
                {
                    DataView dataView = new DataView(cityGymDatabaseDataSet.MemberMembership);
                    List<int> members = new List<int>();
                    //ensure it is not filtering for any membership type
                    if (comboBoxMembership.SelectedIndex != 0)
                    {
                        //filter by the membership type
                        dataView.RowFilter = $"[MembershipID] = {comboBoxMembership.SelectedIndex}";
                        //get all memberid from the rows associated with the membership type
                        foreach (DataRowView r in dataView)
                        {
                            members.Add(Int32.Parse(r[1].ToString()));
                        }
                        dataView = new DataView(cityGymDatabaseDataSet.Member);
                        string expression = "";
                        //create filter for members associated with membership type
                        for (int i = 0; i < members.Count; i++)
                        {
                            expression += $"[MemberID] = {members[i]}";
                            if (i + 1 != members.Count)
                            {
                                expression += " OR ";
                            }
                        }
                        //filter and display results
                        dataView.RowFilter = expression;
                        memberDataGridView.DataSource = dataView;
                    }
                    else
                    {
                        //show all results
                        memberDataGridView.DataSource = cityGymDatabaseDataSet.Member;
                    }
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show($"Error occurred, search could not be completed\n{ex.Message}");
            }
        }
        /// <summary>
        /// Show menu again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Members_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuInstance.Show();
            helpInstance = null;
            GC.Collect();
        }
        /// <summary>
        /// Trigger search when enter button is hit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                buttonSearch_Click(sender, null);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Change visibility of combobox and textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check whether 'membership' is selected and display as required
            if (comboBoxSearch.Text.Equals("Membership"))
            {
                textBoxSearch.Visible = false;
                comboBoxMembership.Visible = true;
            }
            else
            {
                comboBoxMembership.Visible = false;
                textBoxSearch.Visible = true;
            }
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
                helpInstance = new Help("search");
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
