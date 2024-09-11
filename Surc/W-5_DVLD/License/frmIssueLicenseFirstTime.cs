using Basis_W_App.Tools_W;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_.Application_B;

namespace Basis_W_App.License
{
    public partial class frmIssueLicenseFirstTime : Form
    {

        private int LocalLicenseAppID_ = -1;
        private clsLocalLicenseApp_B ObjLocalLicenseApp;
        public frmIssueLicenseFirstTime(int LocalLicenseAppID)
        {
            InitializeComponent();
            LocalLicenseAppID_ = LocalLicenseAppID;
        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
            ObjLocalLicenseApp = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID_);

            if (ObjLocalLicenseApp == null)
            {
                MessageBox.Show("No Application with ID = " + LocalLicenseAppID_.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.Close();
                
                return;
            }

            if (!ObjLocalLicenseApp.PassedAllTests())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = ObjLocalLicenseApp.GetActiveLicenseID_B();
            if (LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID = " + LicenseID.ToString(), " Not Allowed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrLocalLicenseAppInfo1.LoadInfoBy_LocalLicenseAppID(LocalLicenseAppID_);

        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = ObjLocalLicenseApp.IssueLicenseForTheFirstTime(txtNotes.Text.Trim(),clsLogIn_W.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                   "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                 MessageBox.Show("License Was not Issued ! ",
                " Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
