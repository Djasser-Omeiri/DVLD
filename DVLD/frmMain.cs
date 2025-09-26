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
        private bool _isLogout = false;

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
            _isLogout = true;
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserDetails(Currentuser).ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogout)
                Application.Exit();

        }
    }
}
