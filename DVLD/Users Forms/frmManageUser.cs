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
            dgvUsers.DataSource = clsUser.GetAllUsers();
            lblCount.Text = (dgvUsers.Rows.Count).ToString();
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
                dgvUsers.DataSource = clsUser.GetAllUsers();
            }
            else
            {
                dgvUsers.DataSource = clsUser.GetAllUsers(column, value);
            }
            lblCount.Text = (dgvUsers.Rows.Count).ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string column = GetColumnName("IsActive");
            string value = (cbIsActive.Text == "Yes") ? "1" : "0";
            switch (cbIsActive.Text)
            {
                case "All":
                    dgvUsers.DataSource = clsUser.GetAllUsers();
                    break;
                case "Yes":
                    dgvUsers.DataSource = clsUser.GetAllUsers(column, value);
                    break;
                case "No":
                    dgvUsers.DataSource = clsUser.GetAllUsers(column, value);
                    break;
            }
            lblCount.Text = (dgvUsers.Rows.Count).ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new frmUserInfo(-1).ShowDialog();
            _refreshUsersList();
        }

        private void MenuAddNewUser_Click(object sender, EventArgs e)
        {
            new frmUserInfo(-1).ShowDialog();
            _refreshUsersList();
        }
       

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value))
                {
                    _refreshUsersList();
                    MessageBox.Show("User deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An error occurred while deleting the User.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MenuSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            new frmUserInfo(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value)).ShowDialog();
            _refreshUsersList();
        }

        private void MenuShowDetails_Click(object sender, EventArgs e)
        {
            new frmUserDetails(clsUser.GetUserByID(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value))).ShowDialog();
        }

        private void MenuChangePassword_Click(object sender, EventArgs e)
        {
            new frmPassword(clsUser.GetUserByID(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value))).ShowDialog();
        }
    }
}
