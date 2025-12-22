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
    public partial class frmUserDetails : Form
    {
        public frmUserDetails()
        {
            InitializeComponent();
        }
       
        private void loaduser()
        {
            lblInputUserID.Text=clsGlobal.CurrentUser.UserID.ToString();
            lblInputUserName.Text= clsGlobal.CurrentUser.UserName.ToString();
            lblInputIsActive.Text = (clsGlobal.CurrentUser.IsActive) ? "Yes" : "No";
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            clsPerson Person=clsPerson.FindPersonByID(clsGlobal.CurrentUser.PersonID);
            ucPersonDetails.LoadPerson(Person);
            loaduser();
        }
    }
}
