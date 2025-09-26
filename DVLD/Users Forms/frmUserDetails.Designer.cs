namespace DVLD
{
    partial class frmUserDetails
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
            this.ucPersonDetails = new DVLD.PersonDetails();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInputUserID = new System.Windows.Forms.Label();
            this.lblInputIsActive = new System.Windows.Forms.Label();
            this.lblInputUserName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPersonDetails
            // 
            this.ucPersonDetails.Location = new System.Drawing.Point(12, 32);
            this.ucPersonDetails.Name = "ucPersonDetails";
            this.ucPersonDetails.Size = new System.Drawing.Size(950, 295);
            this.ucPersonDetails.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(148, 48);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(80, 20);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "UserID :";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(645, 48);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(88, 20);
            this.lblIsActive.TabIndex = 2;
            this.lblIsActive.Text = "IsActive :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(364, 48);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInputUserID);
            this.groupBox1.Controls.Add(this.lblInputIsActive);
            this.groupBox1.Controls.Add(this.lblInputUserName);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // lblInputUserID
            // 
            this.lblInputUserID.AutoSize = true;
            this.lblInputUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputUserID.Location = new System.Drawing.Point(232, 48);
            this.lblInputUserID.Name = "lblInputUserID";
            this.lblInputUserID.Size = new System.Drawing.Size(49, 20);
            this.lblInputUserID.TabIndex = 6;
            this.lblInputUserID.Text = "????";
            // 
            // lblInputIsActive
            // 
            this.lblInputIsActive.AutoSize = true;
            this.lblInputIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputIsActive.Location = new System.Drawing.Point(739, 48);
            this.lblInputIsActive.Name = "lblInputIsActive";
            this.lblInputIsActive.Size = new System.Drawing.Size(39, 20);
            this.lblInputIsActive.TabIndex = 5;
            this.lblInputIsActive.Text = "???";
            // 
            // lblInputUserName
            // 
            this.lblInputUserName.AutoSize = true;
            this.lblInputUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputUserName.Location = new System.Drawing.Point(477, 48);
            this.lblInputUserName.Name = "lblInputUserName";
            this.lblInputUserName.Size = new System.Drawing.Size(69, 20);
            this.lblInputUserName.TabIndex = 4;
            this.lblInputUserName.Text = "??????";
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucPersonDetails);
            this.Name = "frmUserDetails";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails ucPersonDetails;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInputUserID;
        private System.Windows.Forms.Label lblInputIsActive;
        private System.Windows.Forms.Label lblInputUserName;
    }
}