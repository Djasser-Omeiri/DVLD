namespace DVLD
{
    partial class frmLocalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalLicenseInfo));
            this.lbltitle = new System.Windows.Forms.Label();
            this.TabControluser = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.ucPersonInformation = new DVLD.PersonDetails();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.lblinputcreator = new System.Windows.Forms.Label();
            this.lblinputFees = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lblinputApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblinputIDApplication = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControluser.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Red;
            this.lbltitle.Location = new System.Drawing.Point(358, 36);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(608, 38);
            this.lbltitle.TabIndex = 72;
            this.lbltitle.Text = "New Local Driving License Application";
            // 
            // TabControluser
            // 
            this.TabControluser.Controls.Add(this.tpPersonalInfo);
            this.TabControluser.Controls.Add(this.tpLoginInfo);
            this.TabControluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControluser.Location = new System.Drawing.Point(11, 107);
            this.TabControluser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControluser.Name = "TabControluser";
            this.TabControluser.SelectedIndex = 0;
            this.TabControluser.Size = new System.Drawing.Size(1303, 592);
            this.TabControluser.TabIndex = 69;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.gbFilter);
            this.tpPersonalInfo.Controls.Add(this.ucPersonInformation);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1295, 559);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(1137, 487);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 49);
            this.btnNext.TabIndex = 65;
            this.btnNext.Text = "   Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.cbFilters);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilter);
            this.gbFilter.Location = new System.Drawing.Point(20, 14);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Size = new System.Drawing.Size(1263, 100);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(605, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 39);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(17, 43);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(84, 22);
            this.lblFilter.TabIndex = 18;
            this.lblFilter.Text = "Find By:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFilters.Location = new System.Drawing.Point(117, 39);
            this.cbFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(200, 28);
            this.cbFilters.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(549, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 39);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(333, 41);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(200, 27);
            this.tbFilter.TabIndex = 20;
            // 
            // ucPersonInformation
            // 
            this.ucPersonInformation.Location = new System.Drawing.Point(20, 121);
            this.ucPersonInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucPersonInformation.Name = "ucPersonInformation";
            this.ucPersonInformation.Size = new System.Drawing.Size(1263, 362);
            this.ucPersonInformation.TabIndex = 0;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.lblinputcreator);
            this.tpLoginInfo.Controls.Add(this.lblinputFees);
            this.tpLoginInfo.Controls.Add(this.cbLicenseClasses);
            this.tpLoginInfo.Controls.Add(this.lblinputApplicationDate);
            this.tpLoginInfo.Controls.Add(this.pictureBox1);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.lblinputIDApplication);
            this.tpLoginInfo.Controls.Add(this.pictureBox9);
            this.tpLoginInfo.Controls.Add(this.pictureBox4);
            this.tpLoginInfo.Controls.Add(this.pictureBox3);
            this.tpLoginInfo.Controls.Add(this.pictureBox10);
            this.tpLoginInfo.Controls.Add(this.lblPassword);
            this.tpLoginInfo.Controls.Add(this.lblConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.lblUsername);
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tpLoginInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpLoginInfo.Size = new System.Drawing.Size(1295, 559);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Application Info";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblinputcreator
            // 
            this.lblinputcreator.AutoSize = true;
            this.lblinputcreator.Location = new System.Drawing.Point(313, 251);
            this.lblinputcreator.Name = "lblinputcreator";
            this.lblinputcreator.Size = new System.Drawing.Size(36, 20);
            this.lblinputcreator.TabIndex = 99;
            this.lblinputcreator.Text = "???";
            // 
            // lblinputFees
            // 
            this.lblinputFees.AutoSize = true;
            this.lblinputFees.Location = new System.Drawing.Point(313, 212);
            this.lblinputFees.Name = "lblinputFees";
            this.lblinputFees.Size = new System.Drawing.Size(36, 20);
            this.lblinputFees.TabIndex = 98;
            this.lblinputFees.Text = "???";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(308, 165);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(280, 28);
            this.cbLicenseClasses.TabIndex = 97;
            this.cbLicenseClasses.Validating += new System.ComponentModel.CancelEventHandler(this.cbLicenseClasses_Validating);
            // 
            // lblinputApplicationDate
            // 
            this.lblinputApplicationDate.AutoSize = true;
            this.lblinputApplicationDate.Location = new System.Drawing.Point(313, 122);
            this.lblinputApplicationDate.Name = "lblinputApplicationDate";
            this.lblinputApplicationDate.Size = new System.Drawing.Size(54, 20);
            this.lblinputApplicationDate.TabIndex = 96;
            this.lblinputApplicationDate.Text = "?????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 94;
            this.label2.Text = "ApplicationDate :";
            // 
            // lblinputIDApplication
            // 
            this.lblinputIDApplication.AutoSize = true;
            this.lblinputIDApplication.Location = new System.Drawing.Point(313, 80);
            this.lblinputIDApplication.Name = "lblinputIDApplication";
            this.lblinputIDApplication.Size = new System.Drawing.Size(36, 20);
            this.lblinputIDApplication.TabIndex = 89;
            this.lblinputIDApplication.Text = "???";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(270, 74);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 88;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(270, 206);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::DVLD.Properties.Resources.employee_man_alt;
            this.pictureBox3.Location = new System.Drawing.Point(270, 245);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(270, 163);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.TabIndex = 85;
            this.pictureBox10.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(72, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(171, 22);
            this.lblPassword.TabIndex = 84;
            this.lblPassword.Text = "Application Fees :";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(72, 250);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(122, 22);
            this.lblConfirmPassword.TabIndex = 83;
            this.lblConfirmPassword.Text = "Created By :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsername.Location = new System.Drawing.Point(72, 168);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(147, 22);
            this.lblUsername.TabIndex = 82;
            this.lblUsername.Text = "License Class :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(72, 79);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(177, 22);
            this.lblUserID.TabIndex = 81;
            this.lblUserID.Text = "D.L.ApplicationID :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1018, 704);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 49);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1166, 704);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 49);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLocalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 788);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TabControluser);
            this.Name = "frmLocalLicenseInfo";
            this.Text = " Local License Info";
            this.Load += new System.EventHandler(this.frmLocalLicenseInfo_Load);
            this.TabControluser.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl TabControluser;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilter;
        private PersonDetails ucPersonInformation;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Label lblinputIDApplication;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblinputApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lblinputFees;
        private System.Windows.Forms.Label lblinputcreator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}