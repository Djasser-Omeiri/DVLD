namespace DVLD
{
    partial class frmRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicense));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblinputRLApplicationID = new System.Windows.Forms.Label();
            this.lblInputApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblIntLicense = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblinputExpirationDate = new System.Windows.Forms.Label();
            this.lblinputRLicenseID = new System.Windows.Forms.Label();
            this.lblinputOldLicenseID = new System.Windows.Forms.Label();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.lblinputCreatedBy = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblInputTFees = new System.Windows.Forms.Label();
            this.lblInputlicenseFees = new System.Windows.Forms.Label();
            this.lblinputAFees = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblinputIssueDate = new System.Windows.Forms.Label();
            this.lblDriverID = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linklblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uclicenseInfoDetails = new DVLD.User_Control.LicenseInfoDetails();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.bntSearch);
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(17, 101);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilter.Size = new System.Drawing.Size(549, 93);
            this.gbFilter.TabIndex = 7;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(171, 38);
            this.txtLicenseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(272, 22);
            this.txtLicenseID.TabIndex = 2;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            this.txtLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LicenseID:";
            // 
            // bntSearch
            // 
            this.bntSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSearch.Image = ((System.Drawing.Image)(resources.GetObject("bntSearch.Image")));
            this.bntSearch.Location = new System.Drawing.Point(463, 15);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(74, 68);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNotes);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.lblinputRLApplicationID);
            this.groupBox1.Controls.Add(this.lblInputApplicationDate);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lblIntLicense);
            this.groupBox1.Controls.Add(this.lblLicenseID);
            this.groupBox1.Controls.Add(this.lblinputExpirationDate);
            this.groupBox1.Controls.Add(this.lblinputRLicenseID);
            this.groupBox1.Controls.Add(this.lblinputOldLicenseID);
            this.groupBox1.Controls.Add(this.lblNationalID);
            this.groupBox1.Controls.Add(this.lblinputCreatedBy);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblInputTFees);
            this.groupBox1.Controls.Add(this.lblInputlicenseFees);
            this.groupBox1.Controls.Add(this.lblinputAFees);
            this.groupBox1.Controls.Add(this.lblGendor);
            this.groupBox1.Controls.Add(this.lblinputIssueDate);
            this.groupBox1.Controls.Add(this.lblDriverID);
            this.groupBox1.Controls.Add(this.lblApplicationID);
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(17, 579);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 307);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New License Info";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(225, 226);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(509, 63);
            this.tbNotes.TabIndex = 189;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Renew_Driving_License_321;
            this.pictureBox2.Location = new System.Drawing.Point(644, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 172;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pictureBox7.Location = new System.Drawing.Point(644, 69);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 173;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Image = global::DVLD.Properties.Resources.calendrier;
            this.pictureBox8.Location = new System.Drawing.Point(644, 109);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 174;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = global::DVLD.Properties.Resources.Man_32;
            this.pictureBox6.Location = new System.Drawing.Point(644, 149);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 171;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox11.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox11.Location = new System.Drawing.Point(644, 189);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 169;
            this.pictureBox11.TabStop = false;
            // 
            // lblinputRLApplicationID
            // 
            this.lblinputRLApplicationID.AutoSize = true;
            this.lblinputRLApplicationID.Location = new System.Drawing.Point(222, 34);
            this.lblinputRLApplicationID.Name = "lblinputRLApplicationID";
            this.lblinputRLApplicationID.Size = new System.Drawing.Size(42, 16);
            this.lblinputRLApplicationID.TabIndex = 188;
            this.lblinputRLApplicationID.Text = "?????";
            // 
            // lblInputApplicationDate
            // 
            this.lblInputApplicationDate.AutoSize = true;
            this.lblInputApplicationDate.Location = new System.Drawing.Point(222, 74);
            this.lblInputApplicationDate.Name = "lblInputApplicationDate";
            this.lblInputApplicationDate.Size = new System.Drawing.Size(42, 16);
            this.lblInputApplicationDate.TabIndex = 187;
            this.lblInputApplicationDate.Text = "?????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(174, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 185;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = global::DVLD.Properties.Resources.calendrier;
            this.pictureBox5.Location = new System.Drawing.Point(174, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 186;
            this.pictureBox5.TabStop = false;
            // 
            // lblIntLicense
            // 
            this.lblIntLicense.AutoSize = true;
            this.lblIntLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntLicense.Location = new System.Drawing.Point(6, 32);
            this.lblIntLicense.Name = "lblIntLicense";
            this.lblIntLicense.Size = new System.Drawing.Size(167, 20);
            this.lblIntLicense.TabIndex = 183;
            this.lblIntLicense.Text = "R.L.Application ID:";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(6, 72);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(154, 20);
            this.lblLicenseID.TabIndex = 184;
            this.lblLicenseID.Text = "Application Date:";
            // 
            // lblinputExpirationDate
            // 
            this.lblinputExpirationDate.AutoSize = true;
            this.lblinputExpirationDate.Location = new System.Drawing.Point(692, 114);
            this.lblinputExpirationDate.Name = "lblinputExpirationDate";
            this.lblinputExpirationDate.Size = new System.Drawing.Size(42, 16);
            this.lblinputExpirationDate.TabIndex = 182;
            this.lblinputExpirationDate.Text = "?????";
            // 
            // lblinputRLicenseID
            // 
            this.lblinputRLicenseID.AutoSize = true;
            this.lblinputRLicenseID.Location = new System.Drawing.Point(692, 34);
            this.lblinputRLicenseID.Name = "lblinputRLicenseID";
            this.lblinputRLicenseID.Size = new System.Drawing.Size(42, 16);
            this.lblinputRLicenseID.TabIndex = 181;
            this.lblinputRLicenseID.Text = "?????";
            // 
            // lblinputOldLicenseID
            // 
            this.lblinputOldLicenseID.AutoSize = true;
            this.lblinputOldLicenseID.Location = new System.Drawing.Point(692, 74);
            this.lblinputOldLicenseID.Name = "lblinputOldLicenseID";
            this.lblinputOldLicenseID.Size = new System.Drawing.Size(42, 16);
            this.lblinputOldLicenseID.TabIndex = 180;
            this.lblinputOldLicenseID.Text = "?????";
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNationalID.Location = new System.Drawing.Point(6, 112);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(106, 20);
            this.lblNationalID.TabIndex = 159;
            this.lblNationalID.Text = "Issue Date:";
            // 
            // lblinputCreatedBy
            // 
            this.lblinputCreatedBy.AutoSize = true;
            this.lblinputCreatedBy.Location = new System.Drawing.Point(692, 154);
            this.lblinputCreatedBy.Name = "lblinputCreatedBy";
            this.lblinputCreatedBy.Size = new System.Drawing.Size(42, 16);
            this.lblinputCreatedBy.TabIndex = 179;
            this.lblinputCreatedBy.Text = "?????";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(454, 192);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(104, 20);
            this.lblExpirationDate.TabIndex = 160;
            this.lblExpirationDate.Text = "Total Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 161;
            this.label2.Text = "Notes:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(6, 192);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(128, 20);
            this.lblIssueDate.TabIndex = 161;
            this.lblIssueDate.Text = "License Fees:";
            // 
            // lblInputTFees
            // 
            this.lblInputTFees.AutoSize = true;
            this.lblInputTFees.Location = new System.Drawing.Point(692, 194);
            this.lblInputTFees.Name = "lblInputTFees";
            this.lblInputTFees.Size = new System.Drawing.Size(42, 16);
            this.lblInputTFees.TabIndex = 177;
            this.lblInputTFees.Text = "?????";
            // 
            // lblInputlicenseFees
            // 
            this.lblInputlicenseFees.AutoSize = true;
            this.lblInputlicenseFees.Location = new System.Drawing.Point(222, 194);
            this.lblInputlicenseFees.Name = "lblInputlicenseFees";
            this.lblInputlicenseFees.Size = new System.Drawing.Size(42, 16);
            this.lblInputlicenseFees.TabIndex = 178;
            this.lblInputlicenseFees.Text = "?????";
            // 
            // lblinputAFees
            // 
            this.lblinputAFees.AutoSize = true;
            this.lblinputAFees.Location = new System.Drawing.Point(222, 154);
            this.lblinputAFees.Name = "lblinputAFees";
            this.lblinputAFees.Size = new System.Drawing.Size(42, 16);
            this.lblinputAFees.TabIndex = 176;
            this.lblinputAFees.Text = "?????";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.Location = new System.Drawing.Point(6, 152);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(155, 20);
            this.lblGendor.TabIndex = 162;
            this.lblGendor.Text = "Application Fees:";
            // 
            // lblinputIssueDate
            // 
            this.lblinputIssueDate.AutoSize = true;
            this.lblinputIssueDate.Location = new System.Drawing.Point(222, 114);
            this.lblinputIssueDate.Name = "lblinputIssueDate";
            this.lblinputIssueDate.Size = new System.Drawing.Size(42, 16);
            this.lblinputIssueDate.TabIndex = 175;
            this.lblinputIssueDate.Text = "?????";
            // 
            // lblDriverID
            // 
            this.lblDriverID.AutoSize = true;
            this.lblDriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverID.Location = new System.Drawing.Point(454, 152);
            this.lblDriverID.Name = "lblDriverID";
            this.lblDriverID.Size = new System.Drawing.Size(109, 20);
            this.lblDriverID.TabIndex = 163;
            this.lblDriverID.Text = "Created By:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(454, 32);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(188, 20);
            this.lblApplicationID.TabIndex = 165;
            this.lblApplicationID.Text = "Renewed License ID:";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(454, 72);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(141, 20);
            this.lblIsActive.TabIndex = 164;
            this.lblIsActive.Text = "Old License ID:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(454, 112);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(145, 20);
            this.lblDateOfBirth.TabIndex = 166;
            this.lblDateOfBirth.Text = "Expiration Date:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox9.Location = new System.Drawing.Point(174, 226);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 168;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox10.Image = global::DVLD.Properties.Resources.calendrier;
            this.pictureBox10.Location = new System.Drawing.Point(174, 109);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 26);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 167;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(174, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 168;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(174, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 170;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(687, 892);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 47);
            this.btnClose.TabIndex = 185;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(824, 892);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(131, 47);
            this.btnRenew.TabIndex = 184;
            this.btnRenew.Text = "Renew";
            this.btnRenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 38);
            this.label3.TabIndex = 186;
            this.label3.Text = "Renew License Application ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklblShowLicenseInfo
            // 
            this.linklblShowLicenseInfo.AutoSize = true;
            this.linklblShowLicenseInfo.Enabled = false;
            this.linklblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblShowLicenseInfo.Location = new System.Drawing.Point(206, 906);
            this.linklblShowLicenseInfo.Name = "linklblShowLicenseInfo";
            this.linklblShowLicenseInfo.Size = new System.Drawing.Size(160, 18);
            this.linklblShowLicenseInfo.TabIndex = 188;
            this.linklblShowLicenseInfo.TabStop = true;
            this.linklblShowLicenseInfo.Text = "Show new License Info";
            this.linklblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblShowLicenseInfo_LinkClicked);
            // 
            // linklblShowLicenseHistory
            // 
            this.linklblShowLicenseHistory.AutoSize = true;
            this.linklblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblShowLicenseHistory.Location = new System.Drawing.Point(24, 906);
            this.linklblShowLicenseHistory.Name = "linklblShowLicenseHistory";
            this.linklblShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.linklblShowLicenseHistory.TabIndex = 187;
            this.linklblShowLicenseHistory.TabStop = true;
            this.linklblShowLicenseHistory.Text = "Show License History";
            this.linklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblShowLicenseHistory_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uclicenseInfoDetails
            // 
            this.uclicenseInfoDetails.Location = new System.Drawing.Point(16, 201);
            this.uclicenseInfoDetails.Name = "uclicenseInfoDetails";
            this.uclicenseInfoDetails.Size = new System.Drawing.Size(939, 372);
            this.uclicenseInfoDetails.TabIndex = 6;
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 948);
            this.Controls.Add(this.linklblShowLicenseInfo);
            this.Controls.Add(this.linklblShowLicenseHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.uclicenseInfoDetails);
            this.Name = "frmRenewLicense";
            this.Text = "frmRenewLicense";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private User_Control.LicenseInfoDetails uclicenseInfoDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblinputRLApplicationID;
        private System.Windows.Forms.Label lblInputApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblIntLicense;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblinputExpirationDate;
        private System.Windows.Forms.Label lblinputRLicenseID;
        private System.Windows.Forms.Label lblinputOldLicenseID;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.Label lblinputCreatedBy;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblInputTFees;
        private System.Windows.Forms.Label lblInputlicenseFees;
        private System.Windows.Forms.Label lblinputAFees;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label lblinputIssueDate;
        private System.Windows.Forms.Label lblDriverID;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel linklblShowLicenseHistory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}