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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser LoggedUser = clsUser.LoginCheck(tbUsername.Text, tbPassword.Text);
            if (LoggedUser != null)
            {
                this.Hide();
                new frmMain(LoggedUser).ShowDialog();
                this.Show();
                tbUsername.Clear();
                tbPassword.Clear();
                tbUsername.Focus();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
