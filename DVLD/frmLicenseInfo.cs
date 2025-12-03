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
    public partial class frmLicenseInfo : Form
    {
        private int _ApplicationID;
        //private clsLicenseDetails _clsLicenseDetails;
        public frmLicenseInfo(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            uclicenseInfoDetails.LoadLicenseInfo(clsLicenseDetails.getAllLicenseDetails(_ApplicationID));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
