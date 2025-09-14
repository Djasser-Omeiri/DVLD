namespace DVLD
{
    partial class frmManagePeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.MenuStrip;
            this.dgvPeople.Location = new System.Drawing.Point(11, 327);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.Size = new System.Drawing.Size(1284, 350);
            this.dgvPeople.TabIndex = 3;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuShowDetails,
            this.toolStripSeparator1,
            this.MenuAddNewPerson,
            this.MenuEdit,
            this.MenuDelete,
            this.toolStripSeparator2,
            this.MenuSendEmail,
            this.MenuPhoneCall});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(192, 184);
            // 
            // MenuShowDetails
            // 
            this.MenuShowDetails.Image = global::DVLD.Properties.Resources.profil_de_lutilisateur;
            this.MenuShowDetails.Name = "MenuShowDetails";
            this.MenuShowDetails.Size = new System.Drawing.Size(191, 28);
            this.MenuShowDetails.Text = "Show Details";
            this.MenuShowDetails.Click += new System.EventHandler(this.MenuShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // MenuAddNewPerson
            // 
            this.MenuAddNewPerson.Image = global::DVLD.Properties.Resources.Add_Person_40;
            this.MenuAddNewPerson.Name = "MenuAddNewPerson";
            this.MenuAddNewPerson.Size = new System.Drawing.Size(191, 28);
            this.MenuAddNewPerson.Text = "Add New Person";
            this.MenuAddNewPerson.Click += new System.EventHandler(this.MenuAddNewPerson_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.Image = global::DVLD.Properties.Resources.edit_32;
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(191, 28);
            this.MenuEdit.Text = "Edit";
            this.MenuEdit.Click += new System.EventHandler(this.MenuEdit_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Image = global::DVLD.Properties.Resources.Delete_32;
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(191, 28);
            this.MenuDelete.Text = "Delete";
            this.MenuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // MenuSendEmail
            // 
            this.MenuSendEmail.Image = global::DVLD.Properties.Resources.send_email_32;
            this.MenuSendEmail.Name = "MenuSendEmail";
            this.MenuSendEmail.Size = new System.Drawing.Size(191, 28);
            this.MenuSendEmail.Text = "Send Email";
            this.MenuSendEmail.Click += new System.EventHandler(this.MenuSendEmail_Click);
            // 
            // MenuPhoneCall
            // 
            this.MenuPhoneCall.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPhoneCall.Image = global::DVLD.Properties.Resources.call_32;
            this.MenuPhoneCall.Name = "MenuPhoneCall";
            this.MenuPhoneCall.Size = new System.Drawing.Size(191, 28);
            this.MenuPhoneCall.Text = "Phone Call";
            this.MenuPhoneCall.Click += new System.EventHandler(this.MenuPhoneCall_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(12, 691);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(95, 25);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "Records: ";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(102, 691);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 25);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "???";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(12, 285);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(93, 25);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter By :";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbFilters.Location = new System.Drawing.Point(111, 285);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(160, 24);
            this.cbFilters.TabIndex = 7;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(287, 286);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(160, 22);
            this.tbFilter.TabIndex = 8;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1148, 247);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(147, 74);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(573, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 734);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmManagePeople";
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuSendEmail;
        private System.Windows.Forms.ToolStripMenuItem MenuPhoneCall;
    }
}