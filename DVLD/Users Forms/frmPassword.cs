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

namespace DVLD.Users_Forms
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }
        private void _loadfrm()
        {
                clsPerson Person = clsPerson.FindPersonByID(clsGlobal.CurrentUser.PersonID);
                ucPersonDetails.LoadPerson(Person);
                lblInputUserID.Text = clsGlobal.CurrentUser.UserID.ToString();
                lblInputUserName.Text = clsGlobal.CurrentUser.UserName;
                lblInputIsActive.Text = (clsGlobal.CurrentUser.IsActive) ? "Yes" : "No";
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "This cannot be empty");
            }
            else if (tbPassword.Text != clsGlobal.CurrentUser.Password)
            {
                errorProvider1.SetError(tbPassword, "Password is wrong");
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
                errorProvider1.SetError(tbNewPassword, "This cannot be empty");
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                errorProvider1.SetError(tbConfirmPassword, "This cannot be empty");
            }
            else if (tbConfirmPassword.Text != tbNewPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "The password is not matching");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(tbNewPassword)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbPassword)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbConfirmPassword));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors())
            {
                MessageBox.Show("Please fix validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsGlobal.CurrentUser.Password = tbNewPassword.Text;
            if (clsGlobal.CurrentUser.UpdateUserPassword())
            {
                MessageBox.Show("User Password Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error Saving User Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            _loadfrm();
        }
    }
}
