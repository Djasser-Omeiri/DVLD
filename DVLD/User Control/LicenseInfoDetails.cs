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
    public partial class LicenseInfoDetails : UserControl
    {
        private clsPerson _Person;
        public LicenseInfoDetails()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(clsLicenseDetails licenseDetails)
        {
            if (licenseDetails == null)
                return;
            _Person=clsPerson.FindPersonByID(clsDrivers.GetDriverByID(licenseDetails.DriverID).PersonID);
            lblInputClass.Text = licenseDetails.ClassName;
            lblinputName.Text = licenseDetails.FullName;
            lblInputLicenseID.Text = licenseDetails.LicenseID.ToString();
            lblinputNationalNo.Text = licenseDetails.NationalityCountryID.ToString();
            lblinputGendor.Text = (licenseDetails.Gendor==false) ? "Male" : "Female";
            lblInputIssueDate.Text = licenseDetails.IssueDate.ToShortDateString();
            lblInputIssueReason.Text = (licenseDetails.IssueReason==1) ? "New License" :
                                       (licenseDetails.IssueReason==2) ? "Renewal" :
                                       (licenseDetails.IssueReason==3) ? "Replacement for Damaged" : 
                                       (licenseDetails.IssueReason==4) ? "Replacement for Lost":"" ;
            lblInputNotes.Text = (string.IsNullOrEmpty(licenseDetails.Notes)? "No Notes": licenseDetails.Notes);
            lblInputIsActive.Text=(licenseDetails.IsActive==true)? "Yes":"No";
            lblinputDateOfBirth.Text = licenseDetails.DateOfBirth.ToShortDateString();
            lblinputDriverID.Text = licenseDetails.DriverID.ToString();
            lblInputExpirationDate.Text = licenseDetails.ExpirationDate.ToShortDateString();
            lblInputIsDetained.Text = (licenseDetails.IsDetained==true)? "Yes":"No";
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
