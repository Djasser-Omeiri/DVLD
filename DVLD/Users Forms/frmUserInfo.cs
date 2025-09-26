using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users_Forms
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }
        clsPerson _Person;
        clsUser _User;
        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "None": return "None";
                case "PersonID": return "p.PersonID";
                case "NationalNo": return "p.NationalNo";
                case "FirstName": return "p.FirstName";
                case "SecondName": return "p.SecondName";
                case "ThirdName": return "p.ThirdName";
                case "LastName": return "p.LastName";
                case "Nationality": return "c.CountryName";
                case "Gendor": return "p.Gendor";
                case "Phone": return "p.Phone";
                case "Email": return "p.Email";
                default: return null;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmPersonInfo(-1).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Person = clsPerson.FindPersonBy(GetColumnName(cbFilters.Text), tbFilter.Text);
            if (_Person == null)
            {
                MessageBox.Show($"No Person Found With {cbFilters.Text}={tbFilter.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucPersonInformation.LoadPerson(_Person);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            TabControluser.TabPages[1].Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsUser.IsPersonLinkedWithUser(_Person.PersonID))
            {
                MessageBox.Show("This Person is already linked with a User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_Person == null || _Person.PersonID == -1)
            {
                MessageBox.Show("Please select a valid Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TabControluser.TabPages[1].Enabled = true;
                TabControluser.SelectedTab = TabControluser.TabPages[1];

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (HasValidationErrors())
            {
                MessageBox.Show("Please fix validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_User == null)
                _User = new clsUser();
            _User.UserName = tbUsername.Text;
            _User.Password = tbPassword.Text;
            _User.IsActive = cbIsActive.Checked;
            _User.PersonID = _Person.PersonID;
            if (_User.Save())
            {
                MessageBox.Show("User Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error Saving User Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblinputUserID.Text = _User.UserID.ToString();
            Console.WriteLine(_User.UserID);
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Username cannot be empty");
            }
            else if (clsUser.IsUserExistsWithUsername(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Username already exists");
            }
            else
            {
                errorProvider1.SetError(tbUsername, "");
            }

        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Password cannot be empty");
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords do not match");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(tbUsername)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbPassword)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbConfirmPassword));
        }
    }
}
