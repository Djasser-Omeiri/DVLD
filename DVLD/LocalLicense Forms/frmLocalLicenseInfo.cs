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
    public partial class frmLocalLicenseInfo : Form
    {
        public frmLocalLicenseInfo(clsUser user)
        {
            InitializeComponent();
            _User = user;
        }
        private clsPerson _Person;
        private clsUser _User;
        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        private void frmLocalLicenseInfo_Load(object sender, EventArgs e)
        {
            _loadfrm();
        }
        private void _filllicenseclassesincb()
        {
            DataTable dtLicenseClasses = clsLicenseClasses.GetAllLicenseClasses();
            cbLicenseClasses.Items.Add("");
            foreach (DataRow row in dtLicenseClasses.Rows)
            {

                cbLicenseClasses.Items.Add(row["ClassName"]);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(-1);
            frm.DataBack += AddPerson_DataBack;
            frm.ShowDialog();
        }

        private void AddPerson_DataBack(object sender, clsPerson person)
        {
            cbFilters.SelectedItem = "PersonID";
            _Person = person;
            tbFilter.Text = _Person.PersonID.ToString();
            ucPersonInformation.LoadPerson(_Person);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "PersonID": return "p.PersonID";
                case "NationalNo": return "p.NationalNo";
                default: return null;
            }
        }
        private void _loadfrm()
        {
            cbFilters.SelectedIndex = 0;
            TabControluser.TabPages[1].Enabled = false;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Person == null || _Person.PersonID == -1)
            {
                MessageBox.Show("Please select a valid Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TabControluser.TabPages[1].Enabled = true;
            TabControluser.SelectedTab = TabControluser.TabPages[1];
            lblinputApplicationDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            _filllicenseclassesincb();
            cbLicenseClasses.SelectedIndex = 0;
            lblinputcreator.Text = _User.UserName;
            lblinputFees.Text = clsApplicationTypes.GetApplicationTypeByID(1).ApplicationFees.ToString();
            _LocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrEmpty(errorProvider1.GetError(cbLicenseClasses));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (HasValidationErrors())
            {
                MessageBox.Show("Please Fix the errors before saving.",
                    "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsLocalDrivingLicenseApplications.IsPersonLinkedWithSameClass(_Person.PersonID, cbLicenseClasses.SelectedIndex))
            {
                MessageBox.Show("Choose another License Class,the selected Person already have an active application with the selected class ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsLicenses.isPersonHaveLicenseWithSameClass(_Person.PersonID, cbLicenseClasses.SelectedIndex))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, choose different driving class", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LocalDrivingLicenseApplications.ApplicationInfo.ApplicantPersonID = _Person.PersonID;
            _LocalDrivingLicenseApplications.ApplicationInfo.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplications.ApplicationInfo.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplications.ApplicationInfo.ApplicationStatus = 1;
            _LocalDrivingLicenseApplications.ApplicationInfo.LastStatutDate = DateTime.Now;
            _LocalDrivingLicenseApplications.ApplicationInfo.PaidFees = Convert.ToDecimal(lblinputFees.Text);
            _LocalDrivingLicenseApplications.ApplicationInfo.CreatedByUserID = _User.UserID;
            _LocalDrivingLicenseApplications.LicenseClassID = cbLicenseClasses.SelectedIndex;
            if (_LocalDrivingLicenseApplications.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Data is not Saved Successfully.");
            }
            lblinputIDApplication.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
        }

        private void cbLicenseClasses_Validating(object sender, CancelEventArgs e)
        {
            if (cbLicenseClasses.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbLicenseClasses, "Select a valid class");
            }
            else
            {
                errorProvider1.SetError(cbLicenseClasses, "");
            }
        }
    }
}
