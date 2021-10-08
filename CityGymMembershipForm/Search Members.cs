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
        public Search_Members(Menu m)
        {
            InitializeComponent();
            comboBoxSearch.SelectedIndex = 0;
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
            memberDataGridView.DataSource = cityGymDatabaseDataSet.Member;
        }
        /// <summary>
        /// Filter members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(cityGymDatabaseDataSet.Member);
            try
            {
                switch (comboBoxSearch.Text)
                {
                    case "Any":
                        if (int.TryParse(textBoxSearch.Text, out int parse))
                        {
                            dataView.RowFilter = $"[MemberID] = {parse} OR [Firstname] LIKE '*{textBoxSearch.Text}*' OR [Lastname] LIKE '*{textBoxSearch.Text}*'" +
                                $" OR [Address] LIKE '*{textBoxSearch.Text}*' OR [Mobile] LIKE '*{textBoxSearch.Text}*'";
                        }
                        else
                        {
                            dataView.RowFilter = $"[Firstname] LIKE '*{textBoxSearch.Text}*' OR [Lastname] LIKE '*{textBoxSearch.Text}*'" +
                                $" OR [Address] LIKE '*{textBoxSearch.Text}*' OR [Mobile] LIKE '*{textBoxSearch.Text}*'";
                        }
                        break;
                    case "MemberID":
                        dataView.RowFilter = $"[MemberID] = {int.Parse(textBoxSearch.Text)}";
                        break;
                    default:
                        dataView.RowFilter = $"{comboBoxSearch.Text} LIKE '*{textBoxSearch.Text}*'";
                        break;
                }
                memberDataGridView.DataSource = dataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
