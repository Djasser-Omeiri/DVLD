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
    public partial class ApplicationDetails : UserControl
    {
        public ApplicationDetails()
        {
            InitializeComponent();
        }
        private int _PersonID = -1;
        public void LoadPerson(clsApplicationDetails applicationDetails)
        {
            if (applicationDetails == null)
                return;
           lblDLAIDinput.Text = applicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblinputClass.Text = applicationDetails.ClassName;
            lblinputTests.Text = $"{applicationDetails.PassedTestCount}/3";
            lblinputID.Text = applicationDetails.ApplicationID.ToString();
            lblinputDate.Text = applicationDetails.ApplicationDate.ToString("yyyy-MM-dd");
            lblinputStatus.Text = applicationDetails.Status;
            lblinputStatusDate.Text = applicationDetails.LastStatusDate.ToString("yyyy-MM-dd");
            lblinputFees.Text = applicationDetails.PaidFees.ToString();
            lblinputCreatedBy.Text = applicationDetails.UserName;
            lblinputType.Text = applicationDetails.ApplicationTypeTitle;
            lblinputApplicant.Text = applicationDetails.FullName;
            _PersonID = applicationDetails.ApplicantPersonID;
        }

        private void linklblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPersonDetails(clsPerson.FindPersonByID(_PersonID)).ShowDialog();
        }
    }
}
