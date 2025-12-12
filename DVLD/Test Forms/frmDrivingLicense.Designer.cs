namespace DVLD
{
    partial class frmDrivingLicense
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.ucApplicationDetails = new DVLD.ApplicationDetails();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD.Properties.Resources.New_Driving_License_321;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(735, 524);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 49);
            this.btnSave.TabIndex = 158;
            this.btnSave.Text = "Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(588, 524);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 49);
            this.btnClose.TabIndex = 157;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(119, 380);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(757, 139);
            this.tbNotes.TabIndex = 156;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox9.Location = new System.Drawing.Point(89, 380);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 155;
            this.pictureBox9.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNotes.Location = new System.Drawing.Point(19, 380);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(64, 20);
            this.lblNotes.TabIndex = 154;
            this.lblNotes.Text = "Notes:";
            // 
            // ucApplicationDetails
            // 
            this.ucApplicationDetails.Location = new System.Drawing.Point(19, 23);
            this.ucApplicationDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucApplicationDetails.Name = "ucApplicationDetails";
            this.ucApplicationDetails.Size = new System.Drawing.Size(857, 335);
            this.ucApplicationDetails.TabIndex = 0;
            // 
            // frmDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 585);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.ucApplicationDetails);
            this.Name = "frmDrivingLicense";
            this.Text = "Driving License";
            this.Load += new System.EventHandler(this.frmDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationDetails ucApplicationDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblNotes;
    }
}