using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private clsPerson _Person;
        public PersonDetails()
        {
            InitializeComponent();
        }

        public void LoadPerson(clsPerson person)
        {
            if (person == null) return;
            _Person = person;
            lblinputPersonID.Text = person.PersonID.ToString();
            lblinputName.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            lblinputNationalNo.Text = person.NationalNo;
            lblinputDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
            lblinputGendor.Text = (person.Gendor) ? "Female" : "Male";
            lblinputAddress.Text = person.Address;
            lblinputEmail.Text = person.Email;
            lblinputPhone.Text = person.Phone;
            lblinputCountry.Text = clsCountry.GetCountryName(person.NationalityCountryID);
            _LoadPersonImage();
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPersonInfo(int.Parse(lblinputPersonID.Text)).ShowDialog();
            LoadPerson(clsPerson.FindPersonByID(int.Parse(lblinputPersonID.Text)));
        }
        private void _LoadPersonImage()
        {
            if (!_Person.Gendor)
                PicturePerson.Image = Resources.Male_512;
            else
                PicturePerson.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    PicturePerson.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}