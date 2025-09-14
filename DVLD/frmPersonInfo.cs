using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmPersonInfo : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person;
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }

        }

        private void _loadfrm()
        {

            _fillcountryincb();
            cbCountry.SelectedIndex = 3;
            dtpDate.MaxDate = DateTime.Today.AddYears(-18);
            dtpDate.MinDate = new DateTime(1900, 1, 1);
            if (_Mode == enMode.AddNew)
            {
                lbltitle.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }
            _Person = clsPerson.FindPersonByID(_PersonID);
            lbltitle.Text = "Update Person";
            lblPersonID.Text = _Person.PersonID.ToString();
            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNo;
            rbMale.Checked = _Person.Gendor;
            rbFemale.Checked = !_Person.Gendor;
            tbEmail.Text = _Person.Email;
            tbPhone.Text = _Person.Phone;
            tbAddress.Text = _Person.Address;
            dtpDate.Value = _Person.DateOfBirth;
            cbCountry.SelectedIndex = _Person.NationalityCountryID;
            if (_Person.ImagePath != "")
            {
                PicturePerson.Image = Image.FromFile(_Person.ImagePath);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _fillcountryincb()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            cbCountry.Items.Add("");
            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountry.Items.Add(row["CountryName"]);

            }
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            _loadfrm();
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsNationalExists(tbNationalNo.Text) && tbNationalNo.Text != _Person.NationalNo)
            {
                errorProvider1.SetError(tbNationalNo, "This National No is already exists");
            }
            else if (string.IsNullOrEmpty(tbNationalNo.Text))
            {
                errorProvider1.SetError(tbNationalNo, "This field is required");
            }
            else errorProvider1.SetError(tbNationalNo, "");

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            PicturePerson.Image = Properties.Resources.Female_512;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            PicturePerson.Image = Properties.Resources.Male_512;
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text))
                errorProvider1.SetError(tbFirstName, "This Field is required");
            else errorProvider1.SetError(tbFirstName, "");
        }

        private void tbPhone_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text))
                errorProvider1.SetError(tbPhone, "This Field is required");
            else if (!IsValidPhone(tbPhone.Text))
                errorProvider1.SetError(tbPhone, "Invalid phone number.");

            else
                errorProvider1.SetError(tbPhone, "");
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddress.Text))
                errorProvider1.SetError(tbAddress, "This Field is required");
            else errorProvider1.SetError(tbAddress, "");
        }

        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                PicturePerson.Image.Dispose();
                PicturePerson.Image = null;

                try
                {
                    File.Delete(_Person.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting image: " + ex.Message);
                }
            }
            PicturePerson.Image = rbMale.Checked
                ? Properties.Resources.Male_512
                : Properties.Resources.Female_512;

            _Person.ImagePath = null;
            PicturePerson.Tag = 0;
            UpdateRemovebtnVisibility();
        }

        private void lblImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string imagesFolder = @"C:\PersonsImages\";

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(ofd.FileName);
                string destPath = Path.Combine(imagesFolder, newFileName);

                File.Copy(ofd.FileName, destPath);

                PicturePerson.Image = Image.FromFile(destPath);

                _Person.ImagePath = destPath;
                PicturePerson.Tag = 1;
                UpdateRemovebtnVisibility();

            }


        }

        private void UpdateRemovebtnVisibility()
        {
            if (PicturePerson.Tag.Equals(0))
                lblRemove.Visible = false;
            else lblRemove.Visible = true;
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                errorProvider1.SetError(tbEmail, "Invalid email format.");
            }
            else
            {
                errorProvider1.SetError(tbEmail, "");
            }
        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSecondName.Text))
                errorProvider1.SetError(tbSecondName, "This Field is required");
            else errorProvider1.SetError(tbSecondName, "");
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text))
                errorProvider1.SetError(tbLastName, "This Field is required");
            else errorProvider1.SetError(tbLastName, "");
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(tbLastName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbNationalNo)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbFirstName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbSecondName)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbEmail)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbAddress)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbPhone));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (HasValidationErrors())
            {
                MessageBox.Show("Please Fix the errors before saving.", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Person.FirstName = tbFirstName.Text;
            _Person.SecondName = tbSecondName.Text;
            _Person.ThirdName = tbThirdName.Text;
            _Person.LastName = tbLastName.Text;
            _Person.NationalNo = tbNationalNo.Text;
            _Person.Gendor = rbMale.Checked;
            _Person.Email = tbEmail.Text;
            _Person.Address = tbAddress.Text;
            _Person.DateOfBirth = dtpDate.Value;
            _Person.Phone = tbPhone.Text;
            _Person.NationalityCountryID = cbCountry.SelectedIndex;
            if (PicturePerson.Tag.Equals(0)) _Person.ImagePath = null;
            else _Person.ImagePath = PicturePerson.ImageLocation;
            if (_Person.Save())
                MessageBox.Show("Data Saved Successfully.");
            else { MessageBox.Show("Data is not Saved Successfully.");
                this.Close();
            }
            _Mode = enMode.Update;
            lbltitle.Text = "Update Person";
            lblPersonID.Text = _Person.PersonID.ToString();
        }
        private bool IsValidPhone(string phone)
        {
            string pattern = @"^\+?\d{8,15}$";
            return Regex.IsMatch(phone, pattern);
        }

    }
}
