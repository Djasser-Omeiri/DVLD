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
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else _Mode = enMode.Update;

        }
        clsPerson _Person;
        clsUser _User;
        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "PersonID": return "p.PersonID";
                case "NationalNo": return "p.NationalNo";
                default: return null;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm=new frmPersonInfo(-1);
            frm.DataBack += AddPerson_DataBack;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPerson_DataBack(object sender, clsPerson person)
        {
            cbFilters.SelectedItem = "PersonID";
            _Person = person;
            tbFilter.Text =_Person.PersonID.ToString();
            ucPersonInformation.LoadPerson(_Person);
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
        private void _loadfrm()
        {
            if (_Mode == enMode.AddNew)
            {
                cbFilters.SelectedIndex = 0;
                TabControluser.TabPages[1].Enabled = false;
                lbltitle.Text = "Add New User";
                _User = new clsUser();
                return;
            }
            _User = clsUser.GetUserByID(_UserID);
            _Person = clsPerson.FindPersonByID(_User.PersonID);
            lbltitle.Text = "Update User";
            ucPersonInformation.LoadPerson(_Person);
            TabControluser.TabPages[1].Enabled = true;
            gbFilter.Enabled = false;
            lblinputUserID.Text = _User.UserID.ToString();
            tbUsername.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;

        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            _loadfrm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
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
            else
            {
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
