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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelHaha = new System.Windows.Forms.Label();
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
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(17, 104);
            this.bookingDataGridView.Name = "bookingDataGridView";
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
            this.textBoxID.Location = new System.Drawing.Point(76, 76);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(57, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(14, 79);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(56, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "MemberID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(180, 76);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(370, 74);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(99, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Confirm member";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(207, 345);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(84, 23);
            this.buttonBook.TabIndex = 8;
            this.buttonBook.Text = "Book class";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(17, 13);
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
            this.labelHaha.Location = new System.Drawing.Point(164, 36);
            this.labelHaha.Name = "labelHaha";
            this.labelHaha.Size = new System.Drawing.Size(147, 25);
            this.labelHaha.TabIndex = 0;
            this.labelHaha.Text = "Book a class";
            // 
            // Fitness_Class_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 380);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.labelHaha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelHaha;
    }
}