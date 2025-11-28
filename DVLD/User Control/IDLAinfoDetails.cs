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
    public partial class IDLAinfoDetails : UserControl
    {
        public IDLAinfoDetails()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(clsInternationalLicenseDetails IDLDetails)
        {
            if (IDLDetails == null)
                return;
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
        }
    }
}
