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
using DVLD.Properties;
namespace DVLD
{
    public partial class PersonDetails : UserControl
    {
        public PersonDetails()
        {
            InitializeComponent();
        }

        public void LoadPerson(clsPerson person)
        {
            if (person == null) return;
            lblinputPersonID.Text = person.PersonID.ToString();
            lblinputName.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            lblinputNationalNo.Text = person.NationalNo;
            lblinputDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
            lblinputGendor.Text = (person.Gendor) ? "Female" : "Male";
            lblinputAddress.Text = person.Address;
            lblinputEmail.Text = person.Email;
            lblinputPhone.Text = person.Phone;
            lblinputCountry.Text = clsCountry.GetCountryName(person.NationalityCountryID);
            PicturePerson.Image = (string.IsNullOrEmpty(person.ImagePath) || !System.IO.File.Exists(person.ImagePath)) ? (person.Gendor) ? Properties.Resources.Female_512 : Properties.Resources.Male_512 : Image.FromFile(person.ImagePath);
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPersonInfo(int.Parse(lblinputPersonID.Text)).ShowDialog();
        }
    }
}