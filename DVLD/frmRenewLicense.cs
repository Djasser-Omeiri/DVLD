using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRenewLicense : Form
    {
        private clsUser _CurrentUser;
        private clsLicenses _license;
        private clsLicenses _newlicense;
        public frmRenewLicense(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser=CurrentUser;
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text))
            {
                errorProvider1.SetError(txtLicenseID, "License ID is required");
            }
            else
            {
                errorProvider1.SetError(txtLicenseID, "");
            }
        }

        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(txtLicenseID));
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            lblInputApplicationDate.Text = DateTime.Now.ToString();
            lblinputIssueDate.Text = DateTime.Now.ToString();
            lblinputAFees.Text = clsApplicationTypes.GetApplicationTypeByID(2).ApplicationFees.ToString();
            lblinputCreatedBy.Text = _CurrentUser.UserName;
            btnRenew.Enabled = false;
            linklblShowLicenseHistory.Enabled = false;
            linklblShowLicenseInfo.Enabled = false;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors()) return;

            _license = clsLicenses.GetLicenseById(Int32.Parse(txtLicenseID.Text));

            if (_license != null)
            {
                clsLicenseClasses licenseClass = clsLicenseClasses.GetLicenseClsByID(_license.LicenseClass);
                uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_license.ApplicationID));
                lblinputOldLicenseID.Text = _license.LicenseID.ToString();
                lblinputExpirationDate.Text =DateTime.Now.AddYears(licenseClass.DefaultValidityLength).ToString();
                linklblShowLicenseHistory.Enabled = true;
                lblInputlicenseFees.Text= licenseClass.ClassFees.ToString();
                lblInputTFees.Text= (Int32.Parse(lblinputAFees.Text) + licenseClass.ClassFees).ToString();
                btnRenew.Enabled = true;
            }
            else
            {
                MessageBox.Show($"There is no license with id={txtLicenseID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(_license.DriverID).PersonID).ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue this International Driving License?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; };
            _newlicense = clsLicenses.RenewLicense(_license, _CurrentUser, tbNotes.Text);
            if (_newlicense != null)
            {
                MessageBox.Show($"License Renewed Successfully With ID={_newlicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                linklblShowLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;
                gbFilter.Enabled = false;
                lblinputRLApplicationID.Text = _newlicense.ApplicationID.ToString();
                lblinputRLicenseID.Text = _newlicense.ApplicationID.ToString();
            }
        }

        private void linklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseInfo(_newlicense.LicenseID).ShowDialog();
        }
    }
}
