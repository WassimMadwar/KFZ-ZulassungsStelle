using Basis_W_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_;
using System.IO;

namespace Basis_W_App.People.Controls
{
    public partial class ctrPersonCard : UserControl
    {

        private int _PersonID = -1;
        public int PersonID {get {return _PersonID;}}

        private clsPerson_B _ObjPerson;
        public clsPerson_B SelectedPersonInfo {get {return _ObjPerson; } }
           

        
        public ctrPersonCard()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;

        }

        ///////////////////////////////////////////////////////////////////////////////////

        private void _LoadPersonImage()
        {

            if (_ObjPerson.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _ObjPerson.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        ///////////////////////////////////////////////////////////////////////////////////

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _ObjPerson.PersonID;
            lblPersonID.Text = _ObjPerson.PersonID.ToString();
            lblNationalNo.Text = _ObjPerson.NationalNo;
            lblFullName.Text = _ObjPerson.FullName;
            lblGendor.Text = _ObjPerson.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _ObjPerson.Email;
            lblPhone.Text = _ObjPerson.Phone;
            lblDateOfBirth.Text = _ObjPerson.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry_B.Find(_ObjPerson.NationalityCountryID).CountryName;
            lblAddress.Text = _ObjPerson.Address;
            _LoadPersonImage();

        }

        ///////////////////////////////////////////////////////////////////////////////////

        public void LoadPersonInfo(int PersonID)
        {
            _ObjPerson = clsPerson_B.Find(PersonID);
            if (_ObjPerson == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        ///////////////////////////////////////////////////////////////////////////////////

        public void LoadPersonInfo(string NationalityNo)
        {
            _ObjPerson = clsPerson_B.Find(NationalityNo);
            if (_ObjPerson == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + NationalityNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        ///////////////////////////////////////////////////////////////////////////////////

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }

        ///////////////////////////////////////////////////////////////////////////////////

    }
}
