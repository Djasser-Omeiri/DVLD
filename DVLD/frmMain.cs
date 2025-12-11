using BusinessAccessLayer;
using DVLD.ApplicationTypes;
using DVLD.LocalLicense_Forms;
using DVLD.TestTypes;
using DVLD.Users_Forms;
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
    public partial class frmMain : Form
    {
        private clsUser _Currentuser;
        private bool _isLogout = false;

        public frmMain(clsUser user)
        {
            InitializeComponent();
            _Currentuser = user;
        }



        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePeople().ShowDialog();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUser().ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isLogout = true;
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserDetails(_Currentuser).ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogout)
                Application.Exit();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPassword(_Currentuser).ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageApplicationTypes().ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageTestTypes().ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLocalLicenseInfo(_Currentuser).ShowDialog();
        }

        private void localDdrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageLDLA(_Currentuser).ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageDrivers().ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageIDLA().ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmIDLA(_Currentuser).ShowDialog();
        }

        private void renewDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRenewLicense(_Currentuser).ShowDialog();
        }

        private void replacementOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReplacementDamagedLicense(_Currentuser).ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDetainLicense(_Currentuser).ShowDialog();
        }
    }
}
