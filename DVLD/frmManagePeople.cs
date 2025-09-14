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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            new frmPersonInfo(-1).ShowDialog();
            _refreshPeopleList();
        }
        private void _refreshPeopleList()
        {
            cbFilters.SelectedIndex = 0;
            dgvPeople.DataSource = clsPerson.GetAllPersonsCustom();
            lblCount.Text = (dgvPeople.Rows.Count).ToString();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _refreshPeopleList();
        }
        private string GetColumnName(string selected)
        {
            switch (selected)
            {
                case "None": return "None";
                case "PersonID": return "p.PersonID";
                case "NationalNo": return "p.NationalNo";
                case "FirstName": return "p.FirstName";
                case "SecondName": return "p.SecondName";
                case "ThirdName": return "p.ThirdName";
                case "LastName": return "p.LastName";
                case "Nationality": return "c.CountryName";
                case "Gendor": return "p.Gendor";
                case "Phone": return "p.Phone";
                case "Email": return "p.Email";
                default: return null;
            }
        }


        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string column = GetColumnName(cbFilters.SelectedItem?.ToString());
            string value = tbFilter.Text.Trim();

            if (column == "None")
            {
                dgvPeople.DataSource = clsPerson.GetAllPersonsCustom();
            }
            else
            {
                dgvPeople.DataSource = clsPerson.GetAllPersonsCustom(column, value);
            }
            lblCount.Text = (dgvPeople.Rows.Count).ToString();



        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex != 0)
                tbFilter.Visible = true;
            else
                tbFilter.Visible = false;

        }

        private void MenuAddNewPerson_Click(object sender, EventArgs e)
        {
            new frmPersonInfo(-1).ShowDialog();
            _refreshPeopleList();
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            new frmPersonInfo(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value)).ShowDialog();
            _refreshPeopleList();
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPerson.DeletePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value)))
                {
                    _refreshPeopleList();
                    MessageBox.Show("Person deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An error occurred while deleting the person.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MenuShowDetails_Click(object sender, EventArgs e)
        {
            new frmPersonDetails(clsPerson.FindPersonByID(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value)), Convert.ToString(dgvPeople.CurrentRow.Cells["Nationality"].Value)).ShowDialog();
        }
    }
}
