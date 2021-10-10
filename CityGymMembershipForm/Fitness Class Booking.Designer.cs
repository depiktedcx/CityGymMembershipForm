namespace CityGymMembershipForm
{
    partial class Fitness_Class_Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fitness_Class_Booking));
            this.cityGymDatabaseDataSet = new CityGymMembershipForm.CityGymDatabaseDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelHaha = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonMemberSearch = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonResetMember = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelUnimplemented = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityGymDatabaseDataSet
            // 
            this.cityGymDatabaseDataSet.DataSetName = "CityGymDatabaseDataSet";
            this.cityGymDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.cityGymDatabaseDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.MemberMembershipTableAdapter = null;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToAddRows = false;
            this.bookingDataGridView.AllowUserToDeleteRows = false;
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Enabled = false;
            this.bookingDataGridView.Location = new System.Drawing.Point(12, 98);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingDataGridView.Size = new System.Drawing.Size(452, 235);
            this.bookingDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StartWeek";
            this.dataGridViewTextBoxColumn2.HeaderText = "StartWeek";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(74, 44);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(57, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 47);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(56, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "MemberID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(74, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(285, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(365, 69);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(99, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Confirm member";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Enabled = false;
            this.buttonBook.Location = new System.Drawing.Point(200, 366);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(84, 23);
            this.buttonBook.TabIndex = 8;
            this.buttonBook.Text = "Book class";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(12, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 44;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelHaha
            // 
            this.labelHaha.AutoSize = true;
            this.labelHaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaha.Location = new System.Drawing.Point(171, 10);
            this.labelHaha.Name = "labelHaha";
            this.labelHaha.Size = new System.Drawing.Size(147, 25);
            this.labelHaha.TabIndex = 0;
            this.labelHaha.Text = "Book a class";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 342);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 46;
            this.labelSearch.Text = "Search";
            // 
            // buttonMemberSearch
            // 
            this.buttonMemberSearch.Location = new System.Drawing.Point(137, 42);
            this.buttonMemberSearch.Name = "buttonMemberSearch";
            this.buttonMemberSearch.Size = new System.Drawing.Size(99, 23);
            this.buttonMemberSearch.TabIndex = 47;
            this.buttonMemberSearch.Text = "Search member";
            this.buttonMemberSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(306, 339);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(76, 23);
            this.buttonSearch.TabIndex = 48;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "Class",
            "Start week",
            "Date",
            "Time"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(59, 339);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(98, 21);
            this.comboBoxSearchType.TabIndex = 49;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(163, 339);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(132, 21);
            this.comboBoxSearch.TabIndex = 50;
            // 
            // buttonResetMember
            // 
            this.buttonResetMember.Location = new System.Drawing.Point(365, 42);
            this.buttonResetMember.Name = "buttonResetMember";
            this.buttonResetMember.Size = new System.Drawing.Size(99, 23);
            this.buttonResetMember.TabIndex = 51;
            this.buttonResetMember.Text = "Reset member";
            this.buttonResetMember.UseVisualStyleBackColor = true;
            this.buttonResetMember.Click += new System.EventHandler(this.buttonResetMember_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(388, 339);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(76, 23);
            this.buttonReset.TabIndex = 52;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelUnimplemented
            // 
            this.labelUnimplemented.AutoSize = true;
            this.labelUnimplemented.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnimplemented.Location = new System.Drawing.Point(22, 196);
            this.labelUnimplemented.Name = "labelUnimplemented";
            this.labelUnimplemented.Size = new System.Drawing.Size(433, 25);
            this.labelUnimplemented.TabIndex = 53;
            this.labelUnimplemented.Text = "This form has not been implemented yet";
            // 
            // Fitness_Class_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 397);
            this.Controls.Add(this.labelUnimplemented);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonResetMember);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonMemberSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.labelHaha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fitness_Class_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness Class Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fitness_Class_Booking_FormClosing);
            this.Load += new System.EventHandler(this.Fitness_Class_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CityGymDatabaseDataSet cityGymDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private CityGymDatabaseDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private CityGymDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelHaha;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonMemberSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonResetMember;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelUnimplemented;
    }
}