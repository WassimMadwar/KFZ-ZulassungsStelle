using Basis_W_App.Properties;
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
using W_Business_.Test_B;

namespace Basis_W_App.Tests.Controls
{
    public partial class ctrTakeTest : UserControl
    {
        public clsTestType_B.enTestTypeID TestTypeID
        {
            get
            {
                return TestTypeID_;
            }
            set
            {
                TestTypeID_ = value;

                switch (TestTypeID_)
                {

                    case clsTestType_B.enTestTypeID.VisionTest:
                        {
                            gb_TestType.Text = "Vision Test";


                            pb_TestTypeImage.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestType_B.enTestTypeID.WrittenTest:
                        {
                            gb_TestType.Text = "Written Test";
                            pb_TestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestType_B.enTestTypeID.StreetTest:
                        {
                            gb_TestType.Text = "Street Test";
                            pb_TestTypeImage.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }
        private clsTestType_B.enTestTypeID TestTypeID_;

        public int TestID
        {
            get
            {
                return TestID_;
            }
        }
        private int TestID_ = -1;

        private int LocalLicenseAppID_ = -1;
        private clsLocalLicenseApp_B ObjLoLicApp;

        public int TestAppointmentID
        {
            get
            {
                return TestAppointmentID_;
            }
        }
        private int TestAppointmentID_ = -1;
        private clsTestAppointment_B ObjTestAppointment;


        public ctrTakeTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID)
        {
            TestAppointmentID_ = TestAppointmentID;
            ObjTestAppointment = clsTestAppointment_B.Find_TA_B(TestAppointmentID_);

            if (ObjTestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + TestAppointmentID_.ToString(),
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TestAppointmentID_ = -1;
                return;
            }

            TestID_ = ObjTestAppointment.TestID;
            LocalLicenseAppID_ = ObjTestAppointment.LocalLicenseAppID;
            ObjLoLicApp = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID_);

            if (ObjLoLicApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + LocalLicenseAppID_.ToString(),
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbl_LocalLicenseAppID.Text = ObjLoLicApp.LocalLicenseAppID.ToString();
            lbl_DrivingClass.Text = ObjLoLicApp.ObjLicenseClassInfo.ClassName;
            lbl_FullName.Text = ObjLoLicApp.PersonFullName;
            lbl_Trial.Text = ObjLoLicApp.TotalTrialsPerTest(TestTypeID_).ToString();
            lbl_Date.Text = clsUtilities_W.DateToShort(ObjTestAppointment.AppointmentDate);
            lbl_Fees.Text = ObjTestAppointment.PaidFees.ToString();
            lbl_TestID.Text = (ObjTestAppointment.TestID == -1) ? "Not Taken Yet" : ObjTestAppointment.TestID.ToString();


        }
    }
}
