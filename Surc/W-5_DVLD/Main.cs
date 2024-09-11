using Basis_W_App.Drivers;
using Basis_W_App.People;
using Basis_W_App.Tests.TestTypes;
using Basis_W_App.Tools_W;
using Basis_W_App.User;
using Basis_W_App.Applications;
using Basis_W_App.Applications.ApplicationTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basis_W_App.Applications.Local_Driving_License;
using Basis_W_App.Tests;
using Basis_W_App.License;
using Basis_W_App.Detain;
using Basis_W_App.License.International_License;


namespace Basis_W_App
{
    public partial class Main : Form
    {
        W_frmLogin _FrmLogin;
        public Main(W_frmLogin frm)
        {
            InitializeComponent();
            _FrmLogin = frm;
        }

        /// ////////////////////////////////////////////////////////////////

        private void UserInfoStripMenu_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsLogIn_W.CurrentUser.UserID);
            frm.Show();
        }

        /// ////////////////////////////////////////////////////////////////

        private void ChangePasswordStripMenu_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsLogIn_W.CurrentUser.UserID);
            frm.Show();
        }

        /// ////////////////////////////////////////////////////////////////

        private void SignOutStripMenu_Click(object sender, EventArgs e)
        {
            clsLogIn_W.CurrentUser = null;
            _FrmLogin.Show();
            this.Close();
        }

        /// ////////////////////////////////////////////////////////////////

        private void MangUserStripMenu_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.Show();
        }

        /// ////////////////////////////////////////////////////////////////

        private void PeopleStripMenu_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.Show();
        }

        private void ManageAppStripMenu_Click(object sender, EventArgs e)
        {
            frmListAppTypes frm = new frmListAppTypes();    
            frm.Show();
        }

        private void ListTypesTestStripMenu_Click(object sender, EventArgs e)
        {
            Form frm = new frmTestListTypes();
            frm.Show();
        }

        private void LocalLicenseStripMenu_Click(object sender, EventArgs e)
        {
            Form frm =new frmAddUpLocalLicApp();
            frm.Show();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalLicenseApp frm = new frmListLocalLicenseApp();
            frm.Show();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListLocalLicenseApp frm = new frmListLocalLicenseApp();
            frm.Show();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense frm = new frmRenewLicense();
            frm.Show();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicense frm = new frmReplaceLostOrDamagedLicense();
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApp frm = new frmDetainLicenseApp();    
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense FRM = new frmReleaseDetainedLicense();
            FRM.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense FRM = new frmReleaseDetainedLicense();
            FRM.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();  
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicense frm = new frmListInternationalLicense();    
            frm.ShowDialog();
        }

        /// ////////////////////////////////////////////////////////////////

    }
}
