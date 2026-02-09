using BusinessAccessLayer;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Control
{
    public partial class IDLAinfoDetails : UserControl
    {
        private clsPerson _Person;
        public IDLAinfoDetails()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(clsInternationalLicenseDetails IDLDetails)
        {
            if (IDLDetails == null)
                return;
            _Person = clsPerson.FindPersonByID(clsDrivers.GetDriverByID(IDLDetails.DriverID).PersonID);
            lblInputName.Text = IDLDetails.FullName;
            lblinputIntLicense.Text = IDLDetails.InternationalLicenseID.ToString();
            lblInputLicenseID.Text = IDLDetails.IssuedUsingLocalLicenseID.ToString();
            lblinputNationalNo.Text = IDLDetails.NationalityCountryID.ToString();
            lblinputGendor.Text = (IDLDetails.Gendor == false) ? "Male" : "Female";
            lblInputIssueDate.Text = IDLDetails.IssueDate.ToShortDateString();
            lblinputApplicationID.Text = IDLDetails.ApplicationID.ToString();
            lblInputIsActive.Text = (IDLDetails.IsActive == true) ? "Yes" : "No";
            lblinputDateOfBirth.Text = IDLDetails.DateOfBirth.ToShortDateString();
            lblinputDriverID.Text = IDLDetails.DriverID.ToString();
            lblInputExpirationDate.Text = IDLDetails.ExpirationDate.ToShortDateString();
            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (!_Person.Gendor)
                PicturePerson.Image = Resources.Male_512;
            else
                PicturePerson.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    PicturePerson.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
