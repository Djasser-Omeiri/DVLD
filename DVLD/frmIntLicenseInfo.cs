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
    public partial class frmIntLicenseInfo : Form
    {
        private clsInternationalLicenseDetails _IDL;
        public frmIntLicenseInfo(clsInternationalLicenseDetails iDL)
        {
            InitializeComponent();
            _IDL = iDL;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIntLicenseInfo_Load(object sender, EventArgs e)
        {
            ucidlAinfoDetails.LoadLicenseInfo(_IDL);
        }
    }
}
