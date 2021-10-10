
namespace CityGymMembershipForm
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCustomerDetails = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this.labelMembershipDetails = new System.Windows.Forms.Label();
            this.labelPaymentDetails = new System.Windows.Forms.Label();
            this.labelExtras = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.checkBox247 = new System.Windows.Forms.CheckBox();
            this.checkBoxTrainer = new System.Windows.Forms.CheckBox();
            this.checkBoxDiet = new System.Windows.Forms.CheckBox();
            this.checkBoxVideos = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.checkBoxDirect = new System.Windows.Forms.CheckBox();
            this.textBoxNet = new System.Windows.Forms.TextBox();
            this.textBoxExtras = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxMembership = new System.Windows.Forms.TextBox();
            this.labelNet = new System.Windows.Forms.Label();
            this.labelExtraCharges = new System.Windows.Forms.Label();
            this.labelTotalDiscount = new System.Windows.Forms.Label();
            this.labelMembershipCost = new System.Windows.Forms.Label();
            this.textBoxRegularPayments = new System.Windows.Forms.TextBox();
            this.labelRegularPayments = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.cityGymDatabaseDataSet = new CityGymMembershipForm.CityGymDatabaseDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.TableAdapterManager();
            this.memberMembershipTableAdapter = new CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.MemberMembershipTableAdapter();
            this.memberMembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberMembershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(194, 86);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(253, 33);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Membership Form";
            // 
            // labelCustomerDetails
            // 
            this.labelCustomerDetails.AutoSize = true;
            this.labelCustomerDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerDetails.Location = new System.Drawing.Point(249, 128);
            this.labelCustomerDetails.Name = "labelCustomerDetails";
            this.labelCustomerDetails.Size = new System.Drawing.Size(140, 19);
            this.labelCustomerDetails.TabIndex = 2;
            this.labelCustomerDetails.Text = "Customer Details";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(23, 160);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(78, 17);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(327, 160);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(77, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last name";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(327, 189);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(49, 17);
            this.labelMobile.TabIndex = 9;
            this.labelMobile.Text = "Mobile";
            this.toolTip1.SetToolTip(this.labelMobile, "Numbers only.\r\nExample: 0123456789\r\n\r\n");
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(23, 189);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 17);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            this.toolTip1.SetToolTip(this.labelAddress, "Format:\r\n123 Example Street\r\nSuburb/Town, Postcode\r\n");
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.Location = new System.Drawing.Point(317, 309);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(161, 17);
            this.labelFrequency.TabIndex = 21;
            this.labelFrequency.Text = "Frequency of payments";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(107, 160);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(177, 20);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphaOnly);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(410, 157);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 20);
            this.textBoxLastName.TabIndex = 6;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphaOnly);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(107, 189);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(177, 57);
            this.textBoxAddress.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxAddress, "Format:\r\n123 Example Street\r\nSuburb/Town, Postcode");
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(410, 189);
            this.textBoxMobile.MaxLength = 11;
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(177, 20);
            this.textBoxMobile.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxMobile, "Numbers only.\r\nExample: 0123456789\r\n");
            this.textBoxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnly);
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.comboBoxFrequency.Location = new System.Drawing.Point(483, 309);
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(104, 21);
            this.comboBoxFrequency.TabIndex = 22;
            this.toolTip1.SetToolTip(this.comboBoxFrequency, "Select how often will they be paying");
            // 
            // labelMembershipDetails
            // 
            this.labelMembershipDetails.AutoSize = true;
            this.labelMembershipDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembershipDetails.Location = new System.Drawing.Point(72, 270);
            this.labelMembershipDetails.Name = "labelMembershipDetails";
            this.labelMembershipDetails.Size = new System.Drawing.Size(159, 19);
            this.labelMembershipDetails.TabIndex = 11;
            this.labelMembershipDetails.Text = "Membership Details";
            // 
            // labelPaymentDetails
            // 
            this.labelPaymentDetails.AutoSize = true;
            this.labelPaymentDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDetails.Location = new System.Drawing.Point(401, 270);
            this.labelPaymentDetails.Name = "labelPaymentDetails";
            this.labelPaymentDetails.Size = new System.Drawing.Size(140, 19);
            this.labelPaymentDetails.TabIndex = 20;
            this.labelPaymentDetails.Text = "Payment Options";
            // 
            // labelExtras
            // 
            this.labelExtras.AutoSize = true;
            this.labelExtras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtras.Location = new System.Drawing.Point(120, 379);
            this.labelExtras.Name = "labelExtras";
            this.labelExtras.Size = new System.Drawing.Size(58, 19);
            this.labelExtras.TabIndex = 9;
            this.labelExtras.Text = "Extras";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(23, 309);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(141, 17);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type of membership";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(23, 342);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(63, 17);
            this.labelDuration.TabIndex = 14;
            this.labelDuration.Text = "Duration";
            this.toolTip1.SetToolTip(this.labelDuration, "* Sign up for a 12-month contract to receive a\r\n$2 per week discount on any membe" +
        "rship type.\r\n\r\n** Sign up for 24-month contract to receive a\r\n$5 per week discou" +
        "nt on any membership type.\r\n");
            // 
            // checkBox247
            // 
            this.checkBox247.AutoSize = true;
            this.checkBox247.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox247.Location = new System.Drawing.Point(26, 410);
            this.checkBox247.Name = "checkBox247";
            this.checkBox247.Size = new System.Drawing.Size(202, 22);
            this.checkBox247.TabIndex = 16;
            this.checkBox247.Text = "24/7 Access ($1 per week)";
            this.checkBox247.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrainer
            // 
            this.checkBoxTrainer.AutoSize = true;
            this.checkBoxTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTrainer.Location = new System.Drawing.Point(26, 454);
            this.checkBoxTrainer.Name = "checkBoxTrainer";
            this.checkBoxTrainer.Size = new System.Drawing.Size(238, 22);
            this.checkBoxTrainer.TabIndex = 17;
            this.checkBoxTrainer.Text = "Personal Trainer ($20 per week)";
            this.checkBoxTrainer.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiet
            // 
            this.checkBoxDiet.AutoSize = true;
            this.checkBoxDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiet.Location = new System.Drawing.Point(26, 501);
            this.checkBoxDiet.Name = "checkBoxDiet";
            this.checkBoxDiet.Size = new System.Drawing.Size(242, 22);
            this.checkBoxDiet.TabIndex = 18;
            this.checkBoxDiet.Text = "Diet Consultation ($20 per week)";
            this.checkBoxDiet.UseVisualStyleBackColor = true;
            // 
            // checkBoxVideos
            // 
            this.checkBoxVideos.AutoSize = true;
            this.checkBoxVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVideos.Location = new System.Drawing.Point(26, 547);
            this.checkBoxVideos.Name = "checkBoxVideos";
            this.checkBoxVideos.Size = new System.Drawing.Size(317, 22);
            this.checkBoxVideos.TabIndex = 19;
            this.checkBoxVideos.Text = "Access Online Fitness Videos ($2 per week)";
            this.checkBoxVideos.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Basic ($10 pw)",
            "Regular ($15 pw)",
            "Premium ($20 pw)"});
            this.comboBoxType.Location = new System.Drawing.Point(171, 309);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(113, 21);
            this.comboBoxType.TabIndex = 13;
            this.toolTip1.SetToolTip(this.comboBoxType, "Select level of membership");
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "3 Months",
            "12 Months*",
            "24 Months**"});
            this.comboBoxDuration.Location = new System.Drawing.Point(171, 342);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(113, 21);
            this.comboBoxDuration.TabIndex = 15;
            this.toolTip1.SetToolTip(this.comboBoxDuration, resources.GetString("comboBoxDuration.ToolTip"));
            // 
            // checkBoxDirect
            // 
            this.checkBoxDirect.AutoSize = true;
            this.checkBoxDirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDirect.Location = new System.Drawing.Point(410, 342);
            this.checkBoxDirect.Name = "checkBoxDirect";
            this.checkBoxDirect.Size = new System.Drawing.Size(122, 22);
            this.checkBoxDirect.TabIndex = 23;
            this.checkBoxDirect.Text = "Direct Debit***";
            this.toolTip1.SetToolTip(this.checkBoxDirect, "*** For Direct Debits, there is a 1% discount on the base membership cost.");
            this.checkBoxDirect.UseVisualStyleBackColor = true;
            // 
            // textBoxNet
            // 
            this.textBoxNet.Enabled = false;
            this.textBoxNet.Location = new System.Drawing.Point(480, 496);
            this.textBoxNet.Name = "textBoxNet";
            this.textBoxNet.ReadOnly = true;
            this.textBoxNet.Size = new System.Drawing.Size(107, 20);
            this.textBoxNet.TabIndex = 30;
            this.toolTip1.SetToolTip(this.textBoxNet, "Total cost of membership\r\nover contracted period\r\n");
            // 
            // textBoxExtras
            // 
            this.textBoxExtras.Enabled = false;
            this.textBoxExtras.Location = new System.Drawing.Point(480, 442);
            this.textBoxExtras.Name = "textBoxExtras";
            this.textBoxExtras.ReadOnly = true;
            this.textBoxExtras.Size = new System.Drawing.Size(107, 20);
            this.textBoxExtras.TabIndex = 28;
            this.toolTip1.SetToolTip(this.textBoxExtras, "Cost of selected extras per week");
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Enabled = false;
            this.textBoxDiscount.Location = new System.Drawing.Point(480, 470);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(107, 20);
            this.textBoxDiscount.TabIndex = 32;
            this.toolTip1.SetToolTip(this.textBoxDiscount, "Discounts received through promotions per week");
            // 
            // textBoxMembership
            // 
            this.textBoxMembership.Enabled = false;
            this.textBoxMembership.Location = new System.Drawing.Point(480, 416);
            this.textBoxMembership.Name = "textBoxMembership";
            this.textBoxMembership.ReadOnly = true;
            this.textBoxMembership.Size = new System.Drawing.Size(107, 20);
            this.textBoxMembership.TabIndex = 26;
            this.toolTip1.SetToolTip(this.textBoxMembership, "Cost of membership per week");
            // 
            // labelNet
            // 
            this.labelNet.AutoSize = true;
            this.labelNet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNet.Location = new System.Drawing.Point(327, 496);
            this.labelNet.Name = "labelNet";
            this.labelNet.Size = new System.Drawing.Size(62, 17);
            this.labelNet.TabIndex = 29;
            this.labelNet.Text = "Net cost";
            this.toolTip1.SetToolTip(this.labelNet, "Total cost of membership\r\nover contracted period");
            // 
            // labelExtraCharges
            // 
            this.labelExtraCharges.AutoSize = true;
            this.labelExtraCharges.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraCharges.Location = new System.Drawing.Point(327, 441);
            this.labelExtraCharges.Name = "labelExtraCharges";
            this.labelExtraCharges.Size = new System.Drawing.Size(99, 17);
            this.labelExtraCharges.TabIndex = 27;
            this.labelExtraCharges.Text = "Extra charges";
            this.toolTip1.SetToolTip(this.labelExtraCharges, "Cost of selected extras per week");
            // 
            // labelTotalDiscount
            // 
            this.labelTotalDiscount.AutoSize = true;
            this.labelTotalDiscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDiscount.Location = new System.Drawing.Point(326, 470);
            this.labelTotalDiscount.Name = "labelTotalDiscount";
            this.labelTotalDiscount.Size = new System.Drawing.Size(100, 17);
            this.labelTotalDiscount.TabIndex = 31;
            this.labelTotalDiscount.Text = "Total Discount";
            this.toolTip1.SetToolTip(this.labelTotalDiscount, "Discounts received through promotions per week");
            // 
            // labelMembershipCost
            // 
            this.labelMembershipCost.AutoSize = true;
            this.labelMembershipCost.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembershipCost.Location = new System.Drawing.Point(327, 416);
            this.labelMembershipCost.Name = "labelMembershipCost";
            this.labelMembershipCost.Size = new System.Drawing.Size(120, 17);
            this.labelMembershipCost.TabIndex = 25;
            this.labelMembershipCost.Text = "Membership cost";
            this.toolTip1.SetToolTip(this.labelMembershipCost, "Cost of membership per week\r\n");
            // 
            // textBoxRegularPayments
            // 
            this.textBoxRegularPayments.Enabled = false;
            this.textBoxRegularPayments.Location = new System.Drawing.Point(480, 522);
            this.textBoxRegularPayments.Name = "textBoxRegularPayments";
            this.textBoxRegularPayments.ReadOnly = true;
            this.textBoxRegularPayments.Size = new System.Drawing.Size(107, 20);
            this.textBoxRegularPayments.TabIndex = 34;
            this.toolTip1.SetToolTip(this.textBoxRegularPayments, "Payment to be made per week/month");
            // 
            // labelRegularPayments
            // 
            this.labelRegularPayments.AutoSize = true;
            this.labelRegularPayments.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegularPayments.Location = new System.Drawing.Point(327, 522);
            this.labelRegularPayments.Name = "labelRegularPayments";
            this.labelRegularPayments.Size = new System.Drawing.Size(129, 17);
            this.labelRegularPayments.TabIndex = 33;
            this.labelRegularPayments.Text = "Regular Payments";
            this.toolTip1.SetToolTip(this.labelRegularPayments, "Payment to be made per week/month");
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(76, 592);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Clears \"Customer Details\" textboxes and resets all selections");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.reset);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(463, 592);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 37;
            this.buttonSubmit.Text = "Register";
            this.toolTip1.SetToolTip(this.buttonSubmit, "Submit your details to the \"Member\" table in database");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelLine1
            // 
            this.labelLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine1.Location = new System.Drawing.Point(4, 258);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(610, 2);
            this.labelLine1.TabIndex = 38;
            // 
            // labelLine2
            // 
            this.labelLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine2.Location = new System.Drawing.Point(309, 293);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(2, 250);
            this.labelLine2.TabIndex = 41;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(406, 379);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(132, 19);
            this.labelDetails.TabIndex = 24;
            this.labelDetails.Text = "Payment Details";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(268, 592);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 36;
            this.buttonCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.buttonCalculate, "Calculate the cost of the membership. The results are displayed under \"Payment De" +
        "tails\"");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.calculate);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::CityGymMembershipForm.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(225, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(190, 70);
            this.pictureBoxLogo.TabIndex = 42;
            this.pictureBoxLogo.TabStop = false;
            // 
            // cityGymDatabaseDataSet
            // 
            this.cityGymDatabaseDataSet.DataSetName = "CityGymDatabaseDataSet";
            this.cityGymDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.cityGymDatabaseDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.MemberMembershipTableAdapter = this.memberMembershipTableAdapter;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.UpdateOrder = CityGymMembershipForm.CityGymDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberMembershipTableAdapter
            // 
            this.memberMembershipTableAdapter.ClearBeforeFill = true;
            // 
            // memberMembershipBindingSource
            // 
            this.memberMembershipBindingSource.DataMember = "MemberMembership";
            this.memberMembershipBindingSource.DataSource = this.cityGymDatabaseDataSet;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(26, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 43;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 638);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxRegularPayments);
            this.Controls.Add(this.labelRegularPayments);
            this.Controls.Add(this.textBoxNet);
            this.Controls.Add(this.textBoxExtras);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxMembership);
            this.Controls.Add(this.labelNet);
            this.Controls.Add(this.labelExtraCharges);
            this.Controls.Add(this.labelTotalDiscount);
            this.Controls.Add(this.labelMembershipCost);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.checkBoxDirect);
            this.Controls.Add(this.comboBoxFrequency);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.checkBoxVideos);
            this.Controls.Add(this.checkBoxDiet);
            this.Controls.Add(this.checkBoxTrainer);
            this.Controls.Add(this.checkBox247);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelExtras);
            this.Controls.Add(this.labelPaymentDetails);
            this.Controls.Add(this.labelMembershipDetails);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelCustomerDetails);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(633, 677);
            this.MinimumSize = new System.Drawing.Size(633, 677);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberMembershipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCustomerDetails;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.ComboBox comboBoxFrequency;
        private System.Windows.Forms.Label labelMembershipDetails;
        private System.Windows.Forms.Label labelPaymentDetails;
        private System.Windows.Forms.Label labelExtras;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.CheckBox checkBox247;
        private System.Windows.Forms.CheckBox checkBoxTrainer;
        private System.Windows.Forms.CheckBox checkBoxDiet;
        private System.Windows.Forms.CheckBox checkBoxVideos;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.CheckBox checkBoxDirect;
        private System.Windows.Forms.TextBox textBoxNet;
        private System.Windows.Forms.TextBox textBoxExtras;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxMembership;
        private System.Windows.Forms.Label labelNet;
        private System.Windows.Forms.Label labelExtraCharges;
        private System.Windows.Forms.Label labelTotalDiscount;
        private System.Windows.Forms.Label labelMembershipCost;
        private System.Windows.Forms.TextBox textBoxRegularPayments;
        private System.Windows.Forms.Label labelRegularPayments;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ToolTip toolTip1;
        private CityGymDatabaseDataSet cityGymDatabaseDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CityGymDatabaseDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private CityGymDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CityGymDatabaseDataSetTableAdapters.MemberMembershipTableAdapter memberMembershipTableAdapter;
        private System.Windows.Forms.BindingSource memberMembershipBindingSource;
        private System.Windows.Forms.Button buttonHelp;
    }
}

