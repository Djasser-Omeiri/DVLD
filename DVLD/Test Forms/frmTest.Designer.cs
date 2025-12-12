namespace DVLD
{
    partial class frmTest
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinputRecords = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.ucApplicationDetails = new DVLD.ApplicationDetails();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 246);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 38);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Vision Test Appointments";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 695);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(857, 150);
            this.dgvAppointments.TabIndex = 78;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Appointments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 867);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "# Records: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinputRecords
            // 
            this.lblinputRecords.AutoSize = true;
            this.lblinputRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputRecords.Location = new System.Drawing.Point(116, 868);
            this.lblinputRecords.Name = "lblinputRecords";
            this.lblinputRecords.Size = new System.Drawing.Size(18, 20);
            this.lblinputRecords.TabIndex = 82;
            this.lblinputRecords.Text = "0";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Image = global::DVLD.Properties.Resources.AddAppointment_321;
            this.btnAddAppointment.Location = new System.Drawing.Point(792, 636);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(76, 53);
            this.btnAddAppointment.TabIndex = 79;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPictureBox.Image = global::DVLD.Properties.Resources.Vision_512;
            this.MainPictureBox.Location = new System.Drawing.Point(308, 23);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(264, 220);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 76;
            this.MainPictureBox.TabStop = false;
            // 
            // ucApplicationDetails
            // 
            this.ucApplicationDetails.Location = new System.Drawing.Point(12, 295);
            this.ucApplicationDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucApplicationDetails.Name = "ucApplicationDetails";
            this.ucApplicationDetails.Size = new System.Drawing.Size(857, 335);
            this.ucApplicationDetails.TabIndex = 77;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 914);
            this.Controls.Add(this.lblinputRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.ucApplicationDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "frmTest";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.frmVisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Label lblTitle;
        private ApplicationDetails ucApplicationDetails;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblinputRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}