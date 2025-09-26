using BusinessAccessLayer;
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
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
        }
        private void _refreshUsersList()
        {
            cbFilters.SelectedIndex = 0;
            dgvPeople.DataSource = clsUser.GetAllUsers();
            lblCount.Text = (dgvPeople.Rows.Count).ToString();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _refreshUsersList();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                cbIsActive.Visible = false;
            }
            else if (cbFilters.Text == "IsActive")
            {
                tbFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                tbFilter.Visible = true;
                cbIsActive.Visible = false;
            }
        }
        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "None": return "None";
                case "UserID": return "u.UserID";
                case "PersonID": return "p.PersonID";
                case "FullName": return "(p.FirstName+' '+p.SecondName+' '+p.ThirdName+' '+p.LastName)";
                case "UserName": return "u.UserName";
                case "IsActive": return "u.IsActive";
                default: return null;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string column = GetColumnName(cbFilters.SelectedItem?.ToString());
            string value = tbFilter.Text.Trim();

            if (column == "None")
            {
                dgvPeople.DataSource = clsUser.GetAllUsers();
            }
            else
            {
                dgvPeople.DataSource = clsUser.GetAllUsers(column, value);
            }
            lblCount.Text = (dgvPeople.Rows.Count).ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string column = GetColumnName("IsActive");
            string value = (cbIsActive.Text == "Yes") ? "1" : "0";
            switch (cbIsActive.Text)
            {
                case "All":
                    dgvPeople.DataSource = clsUser.GetAllUsers();
                    break;
                case "Yes":
                    dgvPeople.DataSource = clsUser.GetAllUsers(column, value);
                    break;
                case "No":
                    dgvPeople.DataSource = clsUser.GetAllUsers(column, value);
                    break;
            }
            lblCount.Text = (dgvPeople.Rows.Count).ToString();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            new frmUserInfo().ShowDialog();
            _refreshUsersList();
        }
    }
}
