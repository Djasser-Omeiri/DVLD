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
    public partial class frmIDLA : Form
    {
        private clsUser _CurrentUser;
        private clsInternationalLicenses _InternationalLicenses;
        private clsLicenses _license;
        public frmIDLA(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors()) return;

            _license = clsLicenses.GetLicenseById(Int32.Parse(txtLicenseID.Text));

            if (_license != null)
            {
                uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_license.ApplicationID));
                lblinputLocalLicenseID.Text = txtLicenseID.Text;
                linklblShowLicenseHistory.Enabled = true;
                if (clsInternationalLicenses.IsInternationalLicenseExists(_license.LicenseID))
                {
                    MessageBox.Show("Person Already have an active international license", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnIssue.Enabled = true;
            }
            else
            {
                MessageBox.Show($"There is no license with id={txtLicenseID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmIDLA_Load(object sender, EventArgs e)
        {

            lblinputApplicationDate.Text = DateTime.Now.ToString();
            lblinputIssueDate.Text = DateTime.Now.ToString();
            lblinputExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            lblInputFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)eApplicationType.NewInternational).ApplicationFees.ToString();
            lblinputCreatedBy.Text = _CurrentUser.UserName;
            btnIssue.Enabled = false;
            linklblShowLicenseHistory.Enabled = false;
            linklblShowLicenseInfo.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue this International Driving License?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }

            _InternationalLicenses = clsInternationalLicenses.CreateNewIDLA(_license, _CurrentUser);
            if (_InternationalLicenses != null)
            {
                MessageBox.Show($"International Driving License Issued Successfully With ID={_InternationalLicenses.InternationalLicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                linklblShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
                gbFilter.Enabled = false;
                lblInputinternationalLicenseID.Text = _InternationalLicenses.InternationalLicenseID.ToString();
                lblinputApplicationID.Text = _InternationalLicenses.Application.ApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Error Issuing International Driving License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linklblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmIntLicenseInfo(clsInternationalLicenseDetails.GetInternationalLicenseDetailsByID(_InternationalLicenses.InternationalLicenseID)).ShowDialog();
        }

        private void linklblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(_license.DriverID).PersonID).ShowDialog();
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
    }
}
