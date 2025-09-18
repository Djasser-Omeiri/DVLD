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
    public partial class frmUserInfo : Form
    {
        private clsUser _CurrentUser;
        public frmUserInfo(clsUser currentUser)
        {
            InitializeComponent();
            _CurrentUser = currentUser;
        }
        

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }
        private void loaduser()
        {
            lblInputUserID.Text=_CurrentUser.UserID.ToString();
            lblInputUserName.Text=_CurrentUser.UserName.ToString();
            lblInputIsActive.Text = (_CurrentUser.IsActive) ? "Yes" : "No";
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            clsPerson Person=clsPerson.FindPersonByID(_CurrentUser.PersonID);
            ucPersonDetails.LoadPerson(Person);
            loaduser();
        }
    }
}
