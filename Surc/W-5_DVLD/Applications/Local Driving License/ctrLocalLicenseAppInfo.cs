using Basis_W_App.Applications.Controls;
using Basis_W_App.License;
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
using W_Business_.License_B;


namespace Basis_W_App.Applications.Local_Driving_License
{
    public partial class ctrLocalLicenseAppInfo : UserControl
    {
        private clsLocalLicenseApp_B ObjLocalApp;

        private int LocalLicenseAppID_ = -1;
        
        private int LicenseID_ = -1;
        
        public int LocalLicenseAppID
        { get { return LocalLicenseAppID_; } }

        public ctrLocalLicenseAppInfo()
        {
            InitializeComponent();
        }

        private void ResetLocalLicenseAppInfo()
        {
            LocalLicenseAppID_ = -1;
            ctrAppBasicInfo1.ResetAppInfo();
            lbl_LocalLicenseAppID.Text = "[????]";
            lbl_AppliedFor.Text = "[????]";


        }
        
        private void FillLocalLicenseAppInfo()
        {
            LicenseID_ = ObjLocalApp.GetActiveLicenseID_B();

            //incase there is license enable the show link.
            ll_ShowLicenseInfo.Enabled = (LicenseID_ != -1);


            lbl_LocalLicenseAppID.Text = ObjLocalApp.LocalLicenseAppID.ToString();
            lbl_AppliedFor.Text = clsLicenseClass_B.FindClass_B(ObjLocalApp.LicenseClassID).ClassName;
            lbl_PassedTests.Text = ObjLocalApp.GetPassedTestCount().ToString() + "/3";
            ctrAppBasicInfo1.LoadApplicationInfo(ObjLocalApp.AppID);

        }

        public void LoadInfoBy_LocalLicenseAppID(int LocalLicenseAppID)
        {
            ObjLocalApp = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID);
            if (ObjLocalApp == null)
            {
                ResetLocalLicenseAppInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalLicenseAppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillLocalLicenseAppInfo();
        }

        public void LoadInfoBy_BasisAppID(int AppID)
        {
            ObjLocalApp = clsLocalLicenseApp_B.FindLocalLicenseAppInfoBy_BasisAppID_B(AppID);
            if (ObjLocalApp == null)
            {
                ResetLocalLicenseAppInfo();


                MessageBox.Show("No Application with ApplicationID = " + AppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillLocalLicenseAppInfo();
        }

        private void ll_ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(ObjLocalApp.GetActiveLicenseID_B());
            frm.ShowDialog();
        }



        /////////////////////////////////////////////////////////////////////
    }
}
