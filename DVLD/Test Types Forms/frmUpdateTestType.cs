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

namespace DVLD.TestTypes
{
    public partial class frmUpdateTestType : Form
    {
        private clsTestTypes _TestType;
        public frmUpdateTestType(clsTestTypes TestType)
        {
            InitializeComponent();
            _TestType = TestType;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                errorProvider1.SetError(tbTitle, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(tbTitle, "");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                errorProvider1.SetError(tbDescription, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(tbDescription, "");
            }
        }

        private void tbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                errorProvider1.SetError(tbFees, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(tbFees, "");
            }
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            lblinputID.Text=_TestType.TestTypeID.ToString();
            tbTitle.Text = _TestType.TestTypeTitle;
            tbDescription.Text=_TestType.TestTypeDesciption;
            tbFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar=='.' && !tbFees.Text.Contains('.')))
            {
                e.Handled = true;
            }
        }
        private bool HasValidationErrors()
        {
            return !string.IsNullOrWhiteSpace(errorProvider1.GetError(tbTitle)) ||
                !string.IsNullOrWhiteSpace(errorProvider1.GetError(tbFees)) ||
                !string.IsNullOrWhiteSpace(errorProvider1.GetError(tbDescription));
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
            _TestType.TestTypeTitle = tbTitle.Text;
            _TestType.TestTypeDesciption=tbDescription.Text;
            _TestType.TestTypeFees = decimal.Parse(tbFees.Text);


            if (_TestType.UpdateTestType())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Data Is Not Saved Successfully.");
            }

        }
    }
}
