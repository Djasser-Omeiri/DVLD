namespace DVLD
{
    partial class frmReplacementDamagedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementDamagedLicense));
            this.label3 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.bntSearch = new System.Windows.Forms.Button();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uclicenseInfoDetails = new DVLD.User_Control.LicenseInfoDetails();
            this.gbReplacement = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.lblInputReplacedLicenseID = new System.Windows.Forms.Label();
            this.lblinputOldLicenseID = new System.Windows.Forms.Label();
            this.lblinputCreatedBy = new System.Windows.Forms.Label();
            this.lblinputAppFees = new System.Windows.Forms.Label();
            this.lblinputApplicationDate = new System.Windows.Forms.Label();
            this.lblinputApplicationID = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linklblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linklblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            this.gbReplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 38);
            this.label3.TabIndex = 189;
            this.label3.Text = "Replacement For Damaged License";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.bntSearch);
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(16, 96);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilter.Size = new System.Drawing.Size(641, 93);
            this.gbFilter.TabIndex = 188;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // bntSearch
            // 
            this.bntSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSearch.Image = ((System.Drawing.Image)(resources.GetObject("bntSearch.Image")));
            this.bntSearch.Location = new System.Drawing.Point(552, 15);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(74, 68);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(171, 38);
            this.txtLicenseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(361, 22);
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
            // uclicenseInfoDetails
            // 
            this.uclicenseInfoDetails.Location = new System.Drawing.Point(16, 196);
            this.uclicenseInfoDetails.Name = "uclicenseInfoDetails";
            this.uclicenseInfoDetails.Size = new System.Drawing.Size(939, 372);
            this.uclicenseInfoDetails.TabIndex = 187;
            // 
            // gbReplacement
            // 
            this.gbReplacement.Controls.Add(this.rbLostLicense);
            this.gbReplacement.Controls.Add(this.rbDamaged);
            this.gbReplacement.Location = new System.Drawing.Point(664, 96);
            this.gbReplacement.Name = "gbReplacement";
            this.gbReplacement.Size = new System.Drawing.Size(291, 93);
            this.gbReplacement.TabIndex = 190;
            this.gbReplacement.TabStop = false;
            this.gbReplacement.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(23, 55);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(103, 20);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Checked = true;
            this.rbDamaged.Location = new System.Drawing.Point(23, 28);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(139, 20);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // lblInputReplacedLicenseID
            // 
            this.lblInputReplacedLicenseID.AutoSize = true;
            this.lblInputReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputReplacedLicenseID.Location = new System.Drawing.Point(755, 609);
            this.lblInputReplacedLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputReplacedLicenseID.Name = "lblInputReplacedLicenseID";
            this.lblInputReplacedLicenseID.Size = new System.Drawing.Size(42, 16);
            this.lblInputReplacedLicenseID.TabIndex = 214;
            this.lblInputReplacedLicenseID.Text = "?????";
            // 
            // lblinputOldLicenseID
            // 
            this.lblinputOldLicenseID.AutoSize = true;
            this.lblinputOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputOldLicenseID.Location = new System.Drawing.Point(755, 646);
            this.lblinputOldLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinputOldLicenseID.Name = "lblinputOldLicenseID";
            this.lblinputOldLicenseID.Size = new System.Drawing.Size(42, 16);
            this.lblinputOldLicenseID.TabIndex = 213;
            this.lblinputOldLicenseID.Text = "?????";
            // 
            // lblinputCreatedBy
            // 
            this.lblinputCreatedBy.AutoSize = true;
            this.lblinputCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputCreatedBy.Location = new System.Drawing.Point(755, 682);
            this.lblinputCreatedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinputCreatedBy.Name = "lblinputCreatedBy";
            this.lblinputCreatedBy.Size = new System.Drawing.Size(42, 16);
            this.lblinputCreatedBy.TabIndex = 211;
            this.lblinputCreatedBy.Text = "?????";
            // 
            // lblinputAppFees
            // 
            this.lblinputAppFees.AutoSize = true;
            this.lblinputAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputAppFees.Location = new System.Drawing.Point(268, 682);
            this.lblinputAppFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinputAppFees.Name = "lblinputAppFees";
            this.lblinputAppFees.Size = new System.Drawing.Size(42, 16);
            this.lblinputAppFees.TabIndex = 209;
            this.lblinputAppFees.Text = "?????";
            // 
            // lblinputApplicationDate
            // 
            this.lblinputApplicationDate.AutoSize = true;
            this.lblinputApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputApplicationDate.Location = new System.Drawing.Point(268, 646);
            this.lblinputApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinputApplicationDate.Name = "lblinputApplicationDate";
            this.lblinputApplicationDate.Size = new System.Drawing.Size(42, 16);
            this.lblinputApplicationDate.TabIndex = 208;
            this.lblinputApplicationDate.Text = "?????";
            // 
            // lblinputApplicationID
            // 
            this.lblinputApplicationID.AutoSize = true;
            this.lblinputApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputApplicationID.Location = new System.Drawing.Point(268, 609);
            this.lblinputApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinputApplicationID.Name = "lblinputApplicationID";
            this.lblinputApplicationID.Size = new System.Drawing.Size(42, 16);
            this.lblinputApplicationID.TabIndex = 207;
            this.lblinputApplicationID.Text = "?????";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(711, 677);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 206;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(224, 677);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 205;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(711, 641);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 203;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(711, 604);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 202;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 641);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 201;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 604);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 199;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 680);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 198;
            this.label8.Text = "Created By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 644);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 196;
            this.label6.Text = "Old License ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 607);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 195;
            this.label5.Text = "Replaced License ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 680);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 194;
            this.label4.Text = "Application Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 644);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 192;
            this.label9.Text = "Application Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 607);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 191;
            this.label10.Text = "L.R.Application ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 575);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(939, 146);
            this.groupBox2.TabIndex = 215;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info for License Replacement";
            // 
            // linklblShowNewLicenseInfo
            // 
            this.linklblShowNewLicenseInfo.AutoSize = true;
            this.linklblShowNewLicenseInfo.Enabled = false;
            this.linklblShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblShowNewLicenseInfo.Location = new System.Drawing.Point(222, 742);
            this.linklblShowNewLicenseInfo.Name = "linklblShowNewLicenseInfo";
            this.linklblShowNewLicenseInfo.Size = new System.Drawing.Size(163, 18);
            this.linklblShowNewLicenseInfo.TabIndex = 219;
            this.linklblShowNewLicenseInfo.TabStop = true;
            this.linklblShowNewLicenseInfo.Text = "Show New License Info";
            this.linklblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblShowNewLicenseInfo_LinkClicked);
            // 
            // linklblShowLicenseHistory
            // 
            this.linklblShowLicenseHistory.AutoSize = true;
            this.linklblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblShowLicenseHistory.Location = new System.Drawing.Point(40, 742);
            this.linklblShowLicenseHistory.Name = "linklblShowLicenseHistory";
            this.linklblShowLicenseHistory.Size = new System.Drawing.Size(152, 18);
            this.linklblShowLicenseHistory.TabIndex = 218;
            this.linklblShowLicenseHistory.TabStop = true;
            this.linklblShowLicenseHistory.Text = "Show License History";
            this.linklblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblShowLicenseHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(598, 728);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 47);
            this.btnClose.TabIndex = 217;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(735, 728);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(220, 47);
            this.btnIssue.TabIndex = 216;
            this.btnIssue.Text = "Issue Replacement";
            this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmReplacementDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 790);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linklblShowNewLicenseInfo);
            this.Controls.Add(this.linklblShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblInputReplacedLicenseID);
            this.Controls.Add(this.lblinputOldLicenseID);
            this.Controls.Add(this.lblinputCreatedBy);
            this.Controls.Add(this.lblinputAppFees);
            this.Controls.Add(this.lblinputApplicationDate);
            this.Controls.Add(this.lblinputApplicationID);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbReplacement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.uclicenseInfoDetails);
            this.Name = "frmReplacementDamagedLicense";
            this.Text = "frmReplacementDamagedLicense";
            this.Load += new System.EventHandler(this.frmReplacementDamagedLicense_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbReplacement.ResumeLayout(false);
            this.gbReplacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private User_Control.LicenseInfoDetails uclicenseInfoDetails;
        private System.Windows.Forms.GroupBox gbReplacement;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.Label lblInputReplacedLicenseID;
        private System.Windows.Forms.Label lblinputOldLicenseID;
        private System.Windows.Forms.Label lblinputCreatedBy;
        private System.Windows.Forms.Label lblinputAppFees;
        private System.Windows.Forms.Label lblinputApplicationDate;
        private System.Windows.Forms.Label lblinputApplicationID;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linklblShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel linklblShowLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}