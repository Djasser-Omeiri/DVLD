namespace DVLD
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LicensetabControl = new System.Windows.Forms.TabControl();
            this.LocaltabPage = new System.Windows.Forms.TabPage();
            this.lblLocalHistory = new System.Windows.Forms.Label();
            this.lblLocalCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationaltabPage = new System.Windows.Forms.TabPage();
            this.lblInternationalhistory = new System.Windows.Forms.Label();
            this.lblIntCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInt = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ucPersonInformation = new DVLD.PersonDetails();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.LicensetabControl.SuspendLayout();
            this.LocaltabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.InternationaltabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInt)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Controls.Add(this.cbFilters);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilter);
            this.gbFilter.Location = new System.Drawing.Point(210, 91);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilter.Size = new System.Drawing.Size(946, 100);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::DVLD.Properties.Resources.AddPerson_32;
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
            this.cbFilters.Size = new System.Drawing.Size(200, 24);
            this.cbFilters.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::DVLD.Properties.Resources.SearchPerson;
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
            this.tbFilter.Size = new System.Drawing.Size(200, 22);
            this.tbFilter.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LicensetabControl);
            this.groupBox1.Location = new System.Drawing.Point(18, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 383);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // LicensetabControl
            // 
            this.LicensetabControl.Controls.Add(this.LocaltabPage);
            this.LicensetabControl.Controls.Add(this.InternationaltabPage);
            this.LicensetabControl.Location = new System.Drawing.Point(13, 34);
            this.LicensetabControl.Name = "LicensetabControl";
            this.LicensetabControl.SelectedIndex = 0;
            this.LicensetabControl.Size = new System.Drawing.Size(1106, 339);
            this.LicensetabControl.TabIndex = 0;
            this.LicensetabControl.SelectedIndexChanged += new System.EventHandler(this.LicensetabControl_SelectedIndexChanged);
            // 
            // LocaltabPage
            // 
            this.LocaltabPage.Controls.Add(this.lblLocalHistory);
            this.LocaltabPage.Controls.Add(this.lblLocalCount);
            this.LocaltabPage.Controls.Add(this.label6);
            this.LocaltabPage.Controls.Add(this.dgvLocal);
            this.LocaltabPage.Location = new System.Drawing.Point(4, 25);
            this.LocaltabPage.Name = "LocaltabPage";
            this.LocaltabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LocaltabPage.Size = new System.Drawing.Size(1098, 310);
            this.LocaltabPage.TabIndex = 0;
            this.LocaltabPage.Text = "Local";
            this.LocaltabPage.UseVisualStyleBackColor = true;
            // 
            // lblLocalHistory
            // 
            this.lblLocalHistory.AutoSize = true;
            this.lblLocalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalHistory.Location = new System.Drawing.Point(8, 10);
            this.lblLocalHistory.Name = "lblLocalHistory";
            this.lblLocalHistory.Size = new System.Drawing.Size(210, 20);
            this.lblLocalHistory.TabIndex = 16;
            this.lblLocalHistory.Text = "Local Licenses History:";
            // 
            // lblLocalCount
            // 
            this.lblLocalCount.AutoSize = true;
            this.lblLocalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalCount.Location = new System.Drawing.Point(97, 275);
            this.lblLocalCount.Name = "lblLocalCount";
            this.lblLocalCount.Size = new System.Drawing.Size(45, 25);
            this.lblLocalCount.TabIndex = 15;
            this.lblLocalCount.Text = "???";
            this.lblLocalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Records: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AllowUserToResizeColumns = false;
            this.dgvLocal.AllowUserToResizeRows = false;
            this.dgvLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocal.Location = new System.Drawing.Point(6, 37);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.RowHeadersWidth = 51;
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.Size = new System.Drawing.Size(1086, 230);
            this.dgvLocal.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 30);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // InternationaltabPage
            // 
            this.InternationaltabPage.Controls.Add(this.lblInternationalhistory);
            this.InternationaltabPage.Controls.Add(this.lblIntCount);
            this.InternationaltabPage.Controls.Add(this.label2);
            this.InternationaltabPage.Controls.Add(this.dgvInt);
            this.InternationaltabPage.Location = new System.Drawing.Point(4, 25);
            this.InternationaltabPage.Name = "InternationaltabPage";
            this.InternationaltabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InternationaltabPage.Size = new System.Drawing.Size(1098, 310);
            this.InternationaltabPage.TabIndex = 1;
            this.InternationaltabPage.Text = "International";
            this.InternationaltabPage.UseVisualStyleBackColor = true;
            // 
            // lblInternationalhistory
            // 
            this.lblInternationalhistory.AutoSize = true;
            this.lblInternationalhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalhistory.Location = new System.Drawing.Point(8, 10);
            this.lblInternationalhistory.Name = "lblInternationalhistory";
            this.lblInternationalhistory.Size = new System.Drawing.Size(268, 20);
            this.lblInternationalhistory.TabIndex = 12;
            this.lblInternationalhistory.Text = "International Licenses History:";
            // 
            // lblIntCount
            // 
            this.lblIntCount.AutoSize = true;
            this.lblIntCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntCount.Location = new System.Drawing.Point(97, 275);
            this.lblIntCount.Name = "lblIntCount";
            this.lblIntCount.Size = new System.Drawing.Size(45, 25);
            this.lblIntCount.TabIndex = 11;
            this.lblIntCount.Text = "???";
            this.lblIntCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Records: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInt
            // 
            this.dgvInt.AllowUserToAddRows = false;
            this.dgvInt.AllowUserToResizeColumns = false;
            this.dgvInt.AllowUserToResizeRows = false;
            this.dgvInt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInt.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInt.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInt.Location = new System.Drawing.Point(6, 37);
            this.dgvInt.Name = "dgvInt";
            this.dgvInt.ReadOnly = true;
            this.dgvInt.RowHeadersWidth = 51;
            this.dgvInt.RowTemplate.Height = 24;
            this.dgvInt.Size = new System.Drawing.Size(1086, 230);
            this.dgvInt.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1008, 884);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 49);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 38);
            this.label3.TabIndex = 74;
            this.label3.Text = "License History";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucPersonInformation
            // 
            this.ucPersonInformation.Location = new System.Drawing.Point(207, 198);
            this.ucPersonInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucPersonInformation.Name = "ucPersonInformation";
            this.ucPersonInformation.Size = new System.Drawing.Size(949, 362);
            this.ucPersonInformation.TabIndex = 2;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 944);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ucPersonInformation);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.LicensetabControl.ResumeLayout(false);
            this.LocaltabPage.ResumeLayout(false);
            this.LocaltabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.InternationaltabPage.ResumeLayout(false);
            this.InternationaltabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilter;
        private PersonDetails ucPersonInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl LicensetabControl;
        private System.Windows.Forms.TabPage LocaltabPage;
        private System.Windows.Forms.TabPage InternationaltabPage;
        private System.Windows.Forms.Label lblInternationalhistory;
        private System.Windows.Forms.Label lblIntCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInt;
        private System.Windows.Forms.Label lblLocalHistory;
        private System.Windows.Forms.Label lblLocalCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}