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
    public partial class frmApplicationDetails : Form
    {
        private int _LDLAID;
        public frmApplicationDetails(int LDLAID)
        {
            InitializeComponent();
            _LDLAID = LDLAID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplicationDetails_Load(object sender, EventArgs e)
        {
            ucapplicationDetails.LoadPerson(clsApplicationDetails.GetAllAppInfosByID(_LDLAID));
        }
    }
}
