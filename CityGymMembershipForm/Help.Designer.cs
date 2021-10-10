namespace CityGymMembershipForm
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.pictureBoxSignup = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxBooking = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSignup
            // 
            this.pictureBoxSignup.Enabled = false;
            this.pictureBoxSignup.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSignup.Image")));
            this.pictureBoxSignup.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSignup.Name = "pictureBoxSignup";
            this.pictureBoxSignup.Size = new System.Drawing.Size(113, 100);
            this.pictureBoxSignup.TabIndex = 0;
            this.pictureBoxSignup.TabStop = false;
            this.pictureBoxSignup.Visible = false;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Enabled = false;
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(119, 0);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(113, 100);
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Visible = false;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Enabled = false;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(0, 106);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(113, 100);
            this.pictureBoxSearch.TabIndex = 2;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Visible = false;
            // 
            // pictureBoxBooking
            // 
            this.pictureBoxBooking.Enabled = false;
            this.pictureBoxBooking.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBooking.Image")));
            this.pictureBoxBooking.Location = new System.Drawing.Point(119, 106);
            this.pictureBoxBooking.Name = "pictureBoxBooking";
            this.pictureBoxBooking.Size = new System.Drawing.Size(113, 100);
            this.pictureBoxBooking.TabIndex = 3;
            this.pictureBoxBooking.TabStop = false;
            this.pictureBoxBooking.Visible = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(0, 0);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(232, 44);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(0, 56);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(232, 44);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 208);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.pictureBoxBooking);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.pictureBoxSignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Help_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSignup;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxBooking;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
    }
}