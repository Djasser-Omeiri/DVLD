namespace DVLD
{
    partial class frmApplicationDetails
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
            this.ucapplicationDetails = new DVLD.ApplicationDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucapplicationDetails
            // 
            this.ucapplicationDetails.Location = new System.Drawing.Point(9, 52);
            this.ucapplicationDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucapplicationDetails.Name = "ucapplicationDetails";
            this.ucapplicationDetails.Size = new System.Drawing.Size(857, 335);
            this.ucapplicationDetails.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(735, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 49);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "  Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Red;
            this.lbltitle.Location = new System.Drawing.Point(297, 14);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(281, 36);
            this.lbltitle.TabIndex = 66;
            this.lbltitle.Text = "Application Details";
            // 
            // frmApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucapplicationDetails);
            this.Name = "frmApplicationDetails";
            this.Text = "Application Details";
            this.Load += new System.EventHandler(this.frmApplicationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationDetails ucapplicationDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbltitle;
    }
}