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
using W_Business_.License_B;
using System.IO;
using Basis_W_App.Tools_W;

namespace Basis_W_App.License.International_License
{
    public partial class ctrInternationalLicenseInfo : UserControl
    {
        private int InternationalLicenseID_;
        private clsInternationalLicense ObjInternationalLic;

        public int InternationalLicenseID
        {
            get { return InternationalLicenseID_; }
        }
        public ctrInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void LoadPersonImage()
        {
            if (ObjInternationalLic.ObjDriverInfo.ObjPerson.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = ObjInternationalLic.ObjDriverInfo.ObjPerson.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            InternationalLicenseID_ = InternationalLicenseID;
            ObjInternationalLic = clsInternationalLicense.Find(InternationalLicenseID_);
            if (ObjInternationalLic == null)
            {
                MessageBox.Show("Could not find International License ID = " + InternationalLicenseID_.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InternationalLicenseID_ = -1;
                return;
            }

            lblInternationalLicenseID.Text = ObjInternationalLic.InternationalLicenseID.ToString();
            lblApplicationID.Text = ObjInternationalLic.AppID.ToString();
            lblIsActive.Text = ObjInternationalLic.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = ObjInternationalLic.IssuedUsingLocalLicenseID.ToString();
            lblFullName.Text = ObjInternationalLic.ObjDriverInfo.ObjPerson.FullName;
            lblNationalNo.Text = ObjInternationalLic.ObjDriverInfo.ObjPerson.NationalNo;
            lblGendor.Text = ObjInternationalLic.ObjDriverInfo.ObjPerson.Gender == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = clsUtilities_W.DateToShort(ObjInternationalLic.ObjDriverInfo.ObjPerson.DateOfBirth);

            lblDriverID.Text = ObjInternationalLic.DriverID.ToString();
            lblIssueDate.Text = clsUtilities_W.DateToShort(ObjInternationalLic.IssueDate);
            lblExpirationDate.Text = clsUtilities_W.DateToShort(ObjInternationalLic.ExpirationDate);

            LoadPersonImage();



        }
    }
}
