using BusinessAccessLayer;
using DVLD.ApplicationTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.TestTypes
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _refreshTestTypesList()
        {
            dgvTestTypes.DataSource = clsTestTypes.GetAllTestTypes();
            lblCount.Text = (dgvTestTypes.Rows.Count).ToString();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUpdateTestType(clsTestTypes.GetTestTypeByID((int)dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value)).ShowDialog();
            _refreshTestTypesList();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _refreshTestTypesList();
        }
    }
}
