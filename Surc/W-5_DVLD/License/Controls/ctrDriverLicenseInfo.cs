using Basis_W_App.Properties;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_.License_B;
using Basis_W_App.Tools_W;


namespace Basis_W_App.License.Controls
{
    public partial class ctrDriverLicenseInfo : UserControl
    {
        private int LicenseID_;
        private clsLicense_B ObjLicense;

        public int LicenseID
        {
            get { return LicenseID_; }
        }
        public clsLicense_B ObjTargetLicense
        { 
            get { return ObjLicense; }
        }


        public ctrDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void LoadPersonImage()
        {
            if (ObjLicense.ObjDriverInfo.ObjPerson.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = ObjLicense.ObjDriverInfo.ObjPerson.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadInfo(int LicenseID)
        {
            LicenseID_ = LicenseID;
            ObjLicense = clsLicense_B.FindLicense_B(LicenseID_);
            if (ObjLicense == null)
            {
                MessageBox.Show("Could not find License ID = " + LicenseID_.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LicenseID_ = -1;
                return;
            }

            lblLicenseID.Text = ObjLicense.LicenseID.ToString();
            lblIsActive.Text = ObjLicense.IsActive ? "Yes" : "No";
            lblIsDetained.Text = ObjLicense.IsDetained ? "Yes" : "No";
            lblClass.Text = ObjLicense.ObjLicenseClassInfo.ClassName;
            lblFullName.Text = ObjLicense.ObjDriverInfo.ObjPerson.FullName;
            lblNationalNo.Text = ObjLicense.ObjDriverInfo.ObjPerson.NationalNo;
            lblGendor.Text = ObjLicense.ObjDriverInfo.ObjPerson.Gender == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = clsUtilities_W.DateToShort(ObjLicense.ObjDriverInfo.ObjPerson.DateOfBirth);

            lblDriverID.Text = ObjLicense.DriverID.ToString();
            lblIssueDate.Text = clsUtilities_W.DateToShort(ObjLicense.IssueDate);
            lblExpirationDate.Text = clsUtilities_W.DateToShort(ObjLicense.ExpirationDate);
            lblIssueReason.Text = ObjLicense.IssueReasonText;
            lblNotes.Text = ObjLicense.Notes == "" ? "No Notes" : ObjLicense.Notes;
            LoadPersonImage();



        }
    }
}
