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
    public partial class frmMain : Form
    {
        clsUser Currentuser;
        public frmMain(clsUser user)
        {
            InitializeComponent();
            Currentuser = user;
        }

        

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePeople().ShowDialog();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUser().ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserInfo(Currentuser).ShowDialog();
        }
    }
}
