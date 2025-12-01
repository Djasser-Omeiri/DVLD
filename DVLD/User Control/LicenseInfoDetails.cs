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

namespace DVLD.User_Control
{
    public partial class LicenseInfoDetails : UserControl
    {
        public LicenseInfoDetails()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(clsLicenseDetails licenseDetails)
        {
            if (licenseDetails == null)
                return;
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
        }
    }
}
