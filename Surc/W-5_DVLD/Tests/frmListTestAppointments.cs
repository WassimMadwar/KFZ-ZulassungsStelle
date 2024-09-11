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
using W_Business_.Application_B;
using W_Business_.Test_B;


namespace Basis_W_App.Tests
{
    public partial class frmListTestAppointments : Form
    {
        private DataTable dtLicenseTestAppointments_;

        private int LocalLicenseAppID_  ;
        private clsTestType_B.enTestTypeID TestTypeID_ = clsTestType_B.enTestTypeID.VisionTest;
        
        public frmListTestAppointments(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTyp)
        {
            InitializeComponent();
            LocalLicenseAppID_ = LocalLicenseAppID;
            TestTypeID_ = TestTyp;
        }
        private void LoadTestTypeImageAndTitle()
        {
            switch (TestTypeID_)
            {

                case clsTestType_B.enTestTypeID.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestType_B.enTestTypeID.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestType_B.enTestTypeID.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }
        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            LoadTestTypeImageAndTitle();

            ctrLocalLicenseAppInfo1.LoadInfoBy_LocalLicenseAppID(LocalLicenseAppID_);
            dtLicenseTestAppointments_ = clsTestAppointment_B.GetApplicationTestAppointmentsPerTestType(LocalLicenseAppID_,TestTypeID_);

            dgvLicenseTestAppointments.DataSource = dtLicenseTestAppointments_;
            lblRecordsCount.Text = dgvLicenseTestAppointments.Rows.Count.ToString();
            if (dgvLicenseTestAppointments.Rows.Count > 0) 
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
            frmBookingTest frm = new frmBookingTest(LocalLicenseAppID_, TestTypeID_, TestAppointmentID);
            frm.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
            frmNewTakeTest frm = new frmNewTakeTest(TestAppointmentID, TestTypeID_);
            frm.ShowDialog();


            frmListTestAppointments_Load(null, null);

        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApp_B ObjLDLApp = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID_);
          
            if (ObjLDLApp.IsThereAnActiveScheduledTest(TestTypeID_))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             clsTest LastTest = ObjLDLApp.GetLastTestPerTestType( TestTypeID_);

            if (LastTest == null)
            {
                frmBookingTest frm1 = new frmBookingTest(LocalLicenseAppID_, TestTypeID_);
                frm1.ShowDialog();
                frmListTestAppointments_Load(null, null);
                return;
            }

              //if person already passed the test s/he cannot reteak it.
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake failed test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmBookingTest frm2 = new frmBookingTest(LastTest.ObjTestAppointment.LocalLicenseAppID,TestTypeID_);
            frm2.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }
    }
}
