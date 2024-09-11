using Basis_W_App.People.Controls;
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
using W_Business_;
using W_Business_.Application_B;
using W_Business_.ApplicationType_B_W;
using W_Business_.License_B;

namespace Basis_W_App.Applications.Local_Driving_License
{
    public partial class frmAddUpLocalLicApp : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        private int LocalLicenseAppID_ = -1;
        private int SelectedPersonID_ = -1;

        clsLocalLicenseApp_B ObjLocalLicenseApp;

        public frmAddUpLocalLicApp()
        {
            InitializeComponent();
            Mode = enMode.AddNew;  
        }

        public frmAddUpLocalLicApp(int LocalLicenseAppID)
        {
            InitializeComponent();

            Mode = enMode.Update;

            LocalLicenseAppID_ = LocalLicenseAppID;

        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void FillLicenseClassesInCB()
        {
            DataTable dtLicenseClasses = clsLicenseClass_B.GetAllLicenseClasses_B();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cb_LicenseClass.Items.Add(row["ClassName"]);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void ResetDefaultValues()
        {
            FillLicenseClassesInCB();

            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Driving License Application";
                this.Text = lblTitle.Text;
                ObjLocalLicenseApp = new clsLocalLicenseApp_B();
                tp_ApplicationInfo.Enabled = false;

                cb_LicenseClass.SelectedIndex = 2;
                lbl_Fees.Text = clsApplicationType_B.Find((int)clsApplication_B.enAppType.NewLic).AppFees.ToString();
                
                //lbl_Fees.Text = clsApplicationType_B.Find(1).AppFees.ToString(); OKAY
            
                lbl_AppDate.Text = DateTime.Now.ToShortDateString();
                lbl_CreatedByUser.Text = clsLogIn_W.CurrentUser.UserName;

            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tp_ApplicationInfo.Enabled = true;
                btn_Save.Enabled = true;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void LoadData()
        {

            ctrPersonCardWithFilter1.FilterEnabled = false;
            ObjLocalLicenseApp = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID_);

            if (ObjLocalLicenseApp == null)
            {
                MessageBox.Show("No Application with ID = " + LocalLicenseAppID_, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrPersonCardWithFilter1.LoadPersonInfo(ObjLocalLicenseApp.AppPersonID);
            lbl_LocalLicensAppID.Text = ObjLocalLicenseApp.LocalLicenseAppID.ToString();
            lbl_AppDate.Text = clsUtilities_W.DateToShort(ObjLocalLicenseApp.AppDate);
            cb_LicenseClass.SelectedIndex = cb_LicenseClass.FindString(clsLicenseClass_B.FindClass_B(ObjLocalLicenseApp.LicenseClassID).ClassName);
            lbl_Fees.Text = ObjLocalLicenseApp.PaidFees.ToString();
            lbl_CreatedByUser.Text = clsUser_B.FindByUserID(ObjLocalLicenseApp.CreatedByUserID).UserName;

        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void DataBackEvent(object MySender, int PersonID)
        {
            // Handle the data received
            SelectedPersonID_ = PersonID;
            ctrPersonCardWithFilter1.LoadPersonInfo(PersonID);


        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void frmAddUpLocalLicApp_Load(object sender, EventArgs e)
        {
            ResetDefaultValues();

            if (Mode == enMode.Update)
            {
                LoadData();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void btn_AppNextToInfo_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                btn_Save.Enabled = true;
                tp_ApplicationInfo.Enabled = true;
                tc_ApplicationInfo.SelectedTab = tc_ApplicationInfo.TabPages["tp_ApplicationInfo"];
                return;
            }
            if (ctrPersonCardWithFilter1.PersonID != -1) 
            {
                btn_Save.Enabled = true;
                tp_ApplicationInfo.Enabled = true;
                tc_ApplicationInfo.SelectedTab = tc_ApplicationInfo.TabPages["tp_ApplicationInfo"];
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrPersonCardWithFilter1.FilterFocus();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int LicenseClassID = clsLicenseClass_B.FindClass_B(cb_LicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplication_B.GetActiveAppIDForLicenseClass_B
                (SelectedPersonID_,clsApplication_B.enAppType.NewLic,LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with ID = " + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_LicenseClass.Focus();
                return;
            }
            if (clsLicense_B.IsLicenseExistByPersonID_B(ctrPersonCardWithFilter1.PersonID, LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose different driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ObjLocalLicenseApp.AppPersonID = ctrPersonCardWithFilter1.PersonID;
            ObjLocalLicenseApp.LicenseClassID = LicenseClassID;

            ObjLocalLicenseApp.AppStatus = clsApplication_B.enAppStatus.New;
            ObjLocalLicenseApp.AppTypeID = 1;

            ObjLocalLicenseApp.AppDate = DateTime.Now;
            ObjLocalLicenseApp.LastStatusDate = DateTime.Now;
            ObjLocalLicenseApp.PaidFees = Convert.ToSingle(lbl_Fees.Text);
            
            ObjLocalLicenseApp.CreatedByUserID = clsLogIn_W.CurrentUser.UserID;

            if (ObjLocalLicenseApp.Save_LLA_B())
            {
                lbl_LocalLicensAppID.Text = ObjLocalLicenseApp.LocalLicenseAppID.ToString();
                Mode = enMode.Update;
                lblTitle.Text = "Update Local Driving License Application";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void SubscribeEvent_OnPersonSelected(int obj)
        {
            SelectedPersonID_ = obj;
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void frmAddUpLocalLicApp_Activated(object sender, EventArgs e)
        {
            ctrPersonCardWithFilter1.Focus();
        }

        /////////////////////////////////////////////////////////////////////////////////////
    }
}
