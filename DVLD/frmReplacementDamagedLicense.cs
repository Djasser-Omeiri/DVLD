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
    public partial class frmReplacementDamagedLicense : Form
    {
        private clsUser _CurrentUser;
        private clsLicenses _license;
        private clsLicenses _newlicense;
        private eApplicationType _applicationType = eApplicationType.Damaged;
        public frmReplacementDamagedLicense(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
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

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to replace this Driving License?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            ;
            _newlicense = clsLicenses.ReplaceLicense(_license, _CurrentUser, (rbDamaged.Checked) ? eApplicationType.Damaged : eApplicationType.Lost);
            if (_newlicense != null)
            {
                MessageBox.Show($"License Replaced Successfully With ID={_newlicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                linklblShowNewLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
                gbFilter.Enabled = false;
                gbReplacement.Enabled = false;
                lblinputApplicationID.Text = _newlicense.ApplicationID.ToString();
                lblInputReplacedLicenseID.Text = _newlicense.LicenseID.ToString();
            }
            else
            {
                MessageBox.Show($"Error Occurred While Replacing License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReplacementDamagedLicense_Load(object sender, EventArgs e)
        {
            lblinputApplicationDate.Text = DateTime.Now.ToString();
            lblinputAppFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)_applicationType).ApplicationFees.ToString();
            lblinputCreatedBy.Text = _CurrentUser.UserName;
            btnIssue.Enabled = false;
            linklblShowLicenseHistory.Enabled = false;
            linklblShowNewLicenseInfo.Enabled = false;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors()) return;

            _license = clsLicenses.GetLicenseById(Int32.Parse(txtLicenseID.Text));

            if (!_license.IsActive)
            {
                MessageBox.Show($"This License is Not active,choose an active license", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_license != null)
            {
                clsLicenseClasses licenseClass = clsLicenseClasses.GetLicenseClsByID(_license.LicenseClass);
                uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_license.ApplicationID));
                lblinputOldLicenseID.Text = _license.LicenseID.ToString();
                linklblShowLicenseHistory.Enabled = true;
                btnIssue.Enabled = true;
            }
            else
            {
                MessageBox.Show($"There is no license with id={txtLicenseID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            _applicationType = eApplicationType.Damaged;

            lblinputAppFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)_applicationType).ApplicationFees.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            _applicationType = eApplicationType.Lost;
            lblinputAppFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)_applicationType).ApplicationFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(_license.DriverID).PersonID).ShowDialog();
        }

        private void linklblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseInfo(_newlicense.ApplicationID).ShowDialog();
        }
    }
}
