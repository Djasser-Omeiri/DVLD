using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationTypes
{
    public partial class frmUpdateApplicationType : Form
    {
        private clsApplicationTypes _ApplicationTypes;
        public frmUpdateApplicationType(clsApplicationTypes applicationTypes)
        {
            InitializeComponent();
            _ApplicationTypes = applicationTypes;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            lblinputID.Text = _ApplicationTypes.ApplicationTypeID.ToString();
            tbTitle.Text = _ApplicationTypes.ApplicationTypeTitle;
            tbFees.Text = _ApplicationTypes.ApplicationFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (HasValidationErrors())
            {
                MessageBox.Show("Please fix the errors before saving.",
                     "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ApplicationTypes.ApplicationTypeTitle = tbTitle.Text;
            _ApplicationTypes.ApplicationFees = decimal.Parse(tbFees.Text);


            if (_ApplicationTypes.UpdateApplicationType())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Data Is Not Saved Successfully.");
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                errorProvider1.SetError(tbTitle, "This field is required");
            }
            else
            {
                errorProvider1.SetError(tbTitle, "");
            }
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrWhiteSpace(errorProvider1.GetError(tbTitle)) ||
                !string.IsNullOrWhiteSpace(errorProvider1.GetError(tbFees));
        }

        private void tbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFees.Text))
            {
                errorProvider1.SetError(tbFees, "This field is required");
            }
            else
            {
                errorProvider1.SetError(tbFees, "");
            }
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.' && !tbFees.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
    }
}
