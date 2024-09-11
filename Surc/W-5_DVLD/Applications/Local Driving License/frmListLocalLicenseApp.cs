using Basis_W_App.Tests;
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
using W_Business_.Test_B;
using Basis_W_App.Drivers;


namespace Basis_W_App.Applications.Local_Driving_License
{

    public partial class frmListLocalLicenseApp : Form
    {
        private DataTable dtAllLocalLicenseApp;

        public frmListLocalLicenseApp()
        {
            InitializeComponent();
        }

        private void frmListLocalLicenseApp_Load(object sender, EventArgs e)
        {
            dtAllLocalLicenseApp = clsLocalLicenseApp_B.GetAllLocalLicenseApp_B();
            dgvLocalLicenseApp.DataSource = dtAllLocalLicenseApp;

            lbl_RecordsCount.Text = dgvLocalLicenseApp.Rows.Count.ToString();
            if (dgvLocalLicenseApp.Rows.Count > 0)
            {

                dgvLocalLicenseApp.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalLicenseApp.Columns[0].Width = 120;

                dgvLocalLicenseApp.Columns[1].HeaderText = "Driving Class";
                dgvLocalLicenseApp.Columns[1].Width = 300;

                dgvLocalLicenseApp.Columns[2].HeaderText = "National No.";
                dgvLocalLicenseApp.Columns[2].Width = 150;

                dgvLocalLicenseApp.Columns[3].HeaderText = "Full Name";
                dgvLocalLicenseApp.Columns[3].Width = 350;

                dgvLocalLicenseApp.Columns[4].HeaderText = "Application Date";
                dgvLocalLicenseApp.Columns[4].Width = 170;

                dgvLocalLicenseApp.Columns[5].HeaderText = "Passed Tests";
                dgvLocalLicenseApp.Columns[5].Width = 150;
            }

            cb_FilterBy.SelectedIndex = 0;


        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_FilterValue.Visible = (cb_FilterBy.Text != "None");

            if (txt_FilterValue.Visible)
            {
                txt_FilterValue.Text = "";
                txt_FilterValue.Focus();
            }

            dtAllLocalLicenseApp.DefaultView.RowFilter = "";
            lbl_RecordsCount.Text = dgvLocalLicenseApp.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cb_FilterBy.Text)
            {

                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            if (txt_FilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                dtAllLocalLicenseApp.DefaultView.RowFilter = "";
                lbl_RecordsCount.Text = dgvLocalLicenseApp.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.
                dtAllLocalLicenseApp.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txt_FilterValue.Text.Trim());
            else
                dtAllLocalLicenseApp.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txt_FilterValue.Text.Trim());

            lbl_RecordsCount.Text = dgvLocalLicenseApp.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_FilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmAddUpLocalLicApp frm = new frmAddUpLocalLicApp();
            frm.ShowDialog();

            frmListLocalLicenseApp_Load(null, null);

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDetailsSM_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;
            frmShowLocalLicenseAppInfo frm = new frmShowLocalLicenseAppInfo(LocalLicenseAppID);
            frm.ShowDialog();
            //refresh
            frmListLocalLicenseApp_Load(null, null);
        }

        private void EditSM_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;
            frmAddUpLocalLicApp frm = new frmAddUpLocalLicApp(LocalLicenseAppID);
            frm.ShowDialog();
            //refresh
            frmListLocalLicenseApp_Load(null, null);
        }

        private void DeleteAppSM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;

            clsLocalLicenseApp_B ObjToDelete =  clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID);

            if (LocalLicenseAppID != null)
            {
                if (ObjToDelete.Delete_LLA_B())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalLicenseApp_Load(null, null);

                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelAppSM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;

            clsLocalLicenseApp_B ObjToCancel = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID);

            if (LocalLicenseAppID != null)
            {
                if (ObjToCancel.CancelApp_B())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalLicenseApp_Load(null, null);

                }
                else
                {
                    MessageBox.Show("Could not cancel Application, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowLicenseSM_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID).GetActiveLicenseID_B();

            if (LicenseID != -1) 
            {
                Form frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();
                
            }

            frmListLocalLicenseApp_Load(null, null);

        }

        private void IssueLicenseFirstTimeSM_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;
            Form frm = new frmIssueLicenseFirstTime(LocalLicenseAppID);
            frm.ShowDialog();

            frmListLocalLicenseApp_Load(null, null);

        }

        private void ShowPersonLicenseHistorySM_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;

            int PersonId_ = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID).AppPersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonId_);
            frm.ShowDialog();
        }

        /// //////////////////////////////////////////////////////////////////////////////////////

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;
            clsLocalLicenseApp_B ObjLocalLicenseApp =
                    clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID);

            int TotalPassedTests = (int)dgvLocalLicenseApp.CurrentRow.Cells[5].Value;

            bool LicenseExists = ObjLocalLicenseApp.IsLicenseIssued_B();

            //Enabled only if person passed all tests and Does not have license. 
            IssueLicenseFirstTimeSM.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            ShowLicenseSM.Enabled = LicenseExists;
            EditSM.Enabled = !LicenseExists && (ObjLocalLicenseApp.AppStatus == clsApplication_B.enAppStatus.New);
            ScheduleTestsMenue.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            CancelAppSM.Enabled = (ObjLocalLicenseApp.AppStatus == clsApplication_B.enAppStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            DeleteAppSM.Enabled = (ObjLocalLicenseApp.AppStatus == clsApplication_B.enAppStatus.New);




            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = ObjLocalLicenseApp.DoesPassTestType(clsTestType_B. enTestTypeID.VisionTest); 
            bool PassedWrittenTest = ObjLocalLicenseApp.DoesPassTestType(clsTestType_B.enTestTypeID.WrittenTest);
            bool PassedStreetTest = ObjLocalLicenseApp.DoesPassTestType(clsTestType_B .enTestTypeID.StreetTest);

            ScheduleTestsMenue.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (ObjLocalLicenseApp.AppStatus == clsApplication_B.enAppStatus.New);

            if (ScheduleTestsMenue.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                ScheduleVisionTestSM.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                ScheduleWrittenTestSM.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                ScheduleStreetTest.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

        }
       
        private void ScheduleTest(clsTestType_B.enTestTypeID TestType)
        {

            int LocalLicenseAppID = (int)dgvLocalLicenseApp.CurrentRow.Cells[0].Value;
            frmListTestAppointments frm = new frmListTestAppointments(LocalLicenseAppID, TestType);
            frm.ShowDialog();
            //refresh
            frmListLocalLicenseApp_Load(null, null);

        }

        private void ScheduleVisionTestSM_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsTestType_B.enTestTypeID.VisionTest);

        }

        private void ScheduleWrittenTestSM_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsTestType_B.enTestTypeID.WrittenTest);
        }

        private void ScheduleStreetTest_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsTestType_B.enTestTypeID.StreetTest);

        }


    }
}
