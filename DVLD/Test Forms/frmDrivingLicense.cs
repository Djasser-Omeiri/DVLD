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
    public partial class frmDrivingLicense : Form
    {

        private int _LDLAID;
        private clsDrivers _Driver;
        private clsApplications _Applications;
        private clsLicenses _License;
        private clsLocalDrivingLicenseApplications _LDLA;
        private clsLicenseClasses _LicenseClasse;
        private clsApplicationDetails _AppDetails;
        public frmDrivingLicense(int LDLAID)
        {
            InitializeComponent();
            _LDLAID = LDLAID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _LDLA = clsLocalDrivingLicenseApplications.GetLDLAByID(_LDLAID);
            _LicenseClasse = clsLicenseClasses.GetLicenseClsByID(_LDLA.LicenseClassID);
            _Driver = new clsDrivers();
            _Driver.PersonID = _LDLA.ApplicationInfo.ApplicantPersonID;
            _Driver.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Driver.CreatedDate = DateTime.Now;
            if (!_Driver.Save()) { MessageBox.Show("Error creating driver record."); return; }
            _License = new clsLicenses();
            _License.ApplicationID = _LDLA.ApplicationInfo.ApplicationID;
            _License.DriverID = _Driver.DriverID;
            _License.LicenseClass = _LDLA.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = DateTime.Now.AddYears(_LicenseClasse.DefaultValidityLength);
            _License.Notes = tbNotes.Text;
            _License.PaidFees = _LicenseClasse.ClassFees;
            _License.IsActive = true;
            _License.IssueReason = 1; // New License
            _License.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (!_License.Save()) { MessageBox.Show("Error creating license record."); clsDrivers.DeleteDriver(_Driver.DriverID); return; }
            _Applications = _LDLA.ApplicationInfo;
            _Applications.ApplicationStatus = 3;
            if (!_Applications.Save()) { MessageBox.Show("Error updating application status."); clsLicenses.DeleteLicense(_License.LicenseID); clsDrivers.DeleteDriver(_Driver.DriverID); return; }
            MessageBox.Show("Driving License issued successfully.", "NEW DRIVING LICENSE", MessageBoxButtons.OK);
        }

        private void frmDrivingLicense_Load(object sender, EventArgs e)
        {
            _AppDetails = clsApplicationDetails.GetAllAppInfosByID(_LDLAID);
            ucApplicationDetails.LoadPerson(_AppDetails);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
