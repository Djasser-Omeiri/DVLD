using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace DVLD
{
    public partial class frmManageIDLA : Form
    {
        public frmManageIDLA()
        {
            InitializeComponent();
        }
        private void _refresh()
        {
            cbFilters.SelectedIndex = 0;
            dgvIDLA.DataSource = clsInternationalLicenses.GetAllIDLA();
            lblCount.Text = dgvIDLA.Rows.Count.ToString();
        }
        private string getColumnName(string column)
        {
            switch (column)
            {
                case "None": return "None";
                case "Int.License ID": return "InternationalLicenseID";
                case "ApplicationID": return "ApplicationID";
                case "DriverID": return "DriverID";
                case "L.License ID": return "IssuedUsingLocalLicenseID";
                default: return null;
            }
        }

        private void frmManageIDLA_Load(object sender, EventArgs e)
        {
            _refresh();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible=(cbFilters.SelectedIndex == 0)?false:true;
            tbFilter.Text="";
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string column= getColumnName(cbFilters.SelectedItem.ToString());
            string value = tbFilter.Text;
            if (column=="None")
            {
                dgvIDLA.DataSource=clsInternationalLicenses.GetAllIDLA();
            }
            else
            {
                dgvIDLA.DataSource=clsInternationalLicenses.GetAllIDLA(column,value);
            }
            lblCount.Text=dgvIDLA.Rows.Count.ToString();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmIntLicenseInfo(clsInternationalLicenseDetails.GetInternationalLicenseDetailsByID(Convert.ToInt32(dgvIDLA.CurrentRow.Cells["Int.License ID"].Value))).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLicenseHistory(clsDrivers.GetDriverByID(Convert.ToInt32(dgvIDLA.CurrentRow.Cells["DriverID"].Value)).PersonID).ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPersonDetails(clsPerson.FindPersonByID(clsDrivers.GetDriverByID(Convert.ToInt32(dgvIDLA.CurrentRow.Cells["DriverID"].Value)).PersonID)).ShowDialog();
        }
    }
}
