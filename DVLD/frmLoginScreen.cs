﻿using System;
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
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUser loggedUser = clsUser.LoginCheck(tbUsername.Text.Trim(), tbPassword.Text.Trim());

            if (loggedUser == null)
            {
                MessageBox.Show("Invalid username or password.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!loggedUser.IsActive)
            {
                MessageBox.Show("This user is inactive. Please contact the administrator.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            using (var mainForm = new frmMain(loggedUser))
            {
                mainForm.ShowDialog();
            }
            this.Show();

            tbUsername.Clear();
            tbPassword.Clear();
            tbUsername.Focus();
        }

    }
}
