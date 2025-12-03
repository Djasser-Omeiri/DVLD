using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID;
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private clsPerson _Person;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Person = clsPerson.FindPersonBy(cbFilters.Text, tbFilter.Text);
            if (_Person == null)
            {
                MessageBox.Show($"No Person Found With {cbFilters.Text}={tbFilter.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucPersonInformation.LoadPerson(_Person);
        }
        private void _load()
        {
            if (_PersonID != -1)
            {
                _Person = clsPerson.FindPersonByID(_PersonID);
                tbFilter.Text = _PersonID.ToString();
                cbFilters.SelectedItem = "PersonID";
                gbFilter.Enabled = false;
                ucPersonInformation.LoadPerson(_Person);
                dgvLocal.DataSource = clsLicenses.GetAllLicensesForHistory(_PersonID);
                lblLocalCount.Text = dgvLocal.Rows.Count.ToString();
            }

        }

        private void LicensetabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LicensetabControl.SelectedIndex)
            {
                case 0:
                    dgvLocal.DataSource = clsLicenses.GetAllLicensesForHistory(_PersonID);
                    lblLocalCount.Text = dgvLocal.Rows.Count.ToString();
                    break;
                case 1:
                    dgvInt.DataSource = clsInternationalLicenses.GetAllIDLAsForHistory(_PersonID);
                    lblIntCount.Text = dgvInt.Rows.Count.ToString();
                    break;
            }
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            _load();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LicensetabControl.SelectedIndex == 0)
            {
                new frmLicenseInfo(Convert.ToInt32(dgvLocal.CurrentRow.Cells["App.ID"].Value)).ShowDialog();
            }
            else
            {
                new frmIntLicenseInfo(clsInternationalLicenseDetails.GetInternationalLicenseDetailsByID(Convert.ToInt32(dgvInt.CurrentRow.Cells["Int.License ID"].Value))).ShowDialog();
            }
        }
    }
}
