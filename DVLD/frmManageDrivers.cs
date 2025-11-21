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
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        private void _Refresh()
        {
            cbFilters.SelectedIndex = 0;
            dgvDrivers.DataSource = clsDrivers.GetAllDriversWithPersonInfo();
            lblCount.Text = dgvDrivers.Rows.Count.ToString();
        }
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilters.SelectedIndex == 0) ? false : true;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string column = cbFilters.SelectedItem?.ToString();
            

            if (column == "None")
            {
                dgvDrivers.DataSource = clsDrivers.GetAllDriversWithPersonInfo();
            }
            else
            {
                string value = tbFilter.Text.Trim();
                dgvDrivers.DataSource = clsDrivers.GetAllDriversWithPersonInfo(column,value);
            }
            lblCount.Text = (dgvDrivers.Rows.Count).ToString();
        }
    }
}
