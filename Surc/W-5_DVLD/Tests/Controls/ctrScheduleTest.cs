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
using W_Business_.Test_B;
using W_Business_.Application_B;
using W_Business_.ApplicationType_B_W;
using static Basis_W_App.Tests.Controls.ctrScheduleTest;
using static W_Business_.Test_B.clsTestType_B;
using Basis_W_App.Tools_W;

namespace Basis_W_App.Tests.Controls
{
    
    public partial class ctrScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode_ = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode CreationMode = enCreationMode.FirstTimeSchedule;

        private  clsLocalLicenseApp_B ObjLocalApp_Test;
        private int LocalLicenseAppID_ = -1;

        private clsTestAppointment_B ObjTestAppointment;
        private int TestAppointmentID_ = -1;

        private clsTestType_B.enTestTypeID TestTypeID_ = clsTestType_B.enTestTypeID.VisionTest;
       
        /// <summary>
        /// To switch Pictures 
        /// </summary>
        public clsTestType_B.enTestTypeID TestTypeID
        {
            get
            {
                return TestTypeID_;
            }
            set
            {
                TestTypeID_ = value; // to set in the Control

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

        public ctrScheduleTest()
        {
            InitializeComponent();
        }
        //////////////////////////////////////////////////////////////////////

        public void LoadInfo(int LocalLicenseAppID, int AppointmentID = -1)
        {
            //if no appointment id this means AddNew mode otherwise it's update mode.
            if (AppointmentID == -1)
                Mode_ = enMode.AddNew;
            else
                Mode_ = enMode.Update;

            LocalLicenseAppID_ = LocalLicenseAppID;
            TestAppointmentID_ = AppointmentID;
            ObjLocalApp_Test = clsLocalLicenseApp_B.FindInfoBy_LocalLicenseAppID_B(LocalLicenseAppID_);

            if (ObjLocalApp_Test== null)
            {
                MessageBox.Show("Error : No Local  Driving License Application with ID = " + LocalLicenseAppID_.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Save.Enabled = false;
                return;
            }

            //decide if the createion mode is retake test or not based if the person attended this test before
            if (ObjLocalApp_Test.DoesAttendTestType(TestTypeID_))
            {
                CreationMode = enCreationMode.RetakeTestSchedule;
            }
            else
            {
                CreationMode = enCreationMode.FirstTimeSchedule;

            }


            if (CreationMode == enCreationMode.RetakeTestSchedule)
            {
                lbl_RetakeAppFees.Text = clsApplicationType_B.Find((int)clsApplication_B.enAppType.RetakeTest).AppFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lbl_Title.Text = "Schedule Retake Test";
                lbl_RetakeTestAppID.Text = "0";
            }
            else
            {
                gbRetakeTestInfo.Enabled = false;
                lbl_Title.Text = "Booking or Edit Test  ";
                lbl_RetakeAppFees.Text = "0";
                lbl_RetakeTestAppID.Text = "N/A";
            }

            lbl_LocalLicenseAppID.Text = ObjLocalApp_Test.LocalLicenseAppID.ToString();
            lbl_DrivingClass.Text = ObjLocalApp_Test.ObjLicenseClassInfo.ClassName;
            lbl_FullName.Text = ObjLocalApp_Test.PersonFullName;

            //this will show the trials for this test before  
            lbl_Trial.Text = ObjLocalApp_Test.TotalTrialsPerTest(TestTypeID_).ToString();


            if (Mode_ == enMode.AddNew)
            {
                lbl_Fees.Text = clsTestType_B.Find(TestTypeID_).Fees.ToString();
                dtp_TestDate.MinDate = DateTime.Now;
                lbl_RetakeTestAppID.Text = "N/A";

                ObjTestAppointment = new clsTestAppointment_B();
            }
            else
            {

                if (!LoadTestAppointmentInfo())
                    return;
            }


            lbl_TotalFees.Text = (Convert.ToSingle(lbl_Fees.Text) + Convert.ToSingle(lbl_RetakeAppFees.Text)).ToString();


            if (!HandleActiveTestAppointmentConstraint())
                return;

            if (!HandleAppointmentLockedConstraint())
                return;

            if (!HandlePreviousTestConstraint())
                return;



        }

        //////////////////////////////////////////////////////////////////////

        private bool LoadTestAppointmentInfo()
        {
            ObjTestAppointment = clsTestAppointment_B.Find_TA_B(TestAppointmentID_);

            if (ObjTestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + TestAppointmentID_.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Save.Enabled = false;
                return false;
            }

            lbl_Fees.Text = ObjTestAppointment.PaidFees.ToString();

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, ObjTestAppointment.AppointmentDate) < 0)
                dtp_TestDate.MinDate = DateTime.Now;
            else
                dtp_TestDate.MinDate = ObjTestAppointment.AppointmentDate;

            dtp_TestDate.Value = ObjTestAppointment.AppointmentDate;

            if (ObjTestAppointment.RetakeTestAppID == -1)
            {
                lbl_RetakeAppFees.Text = "0";
                lbl_RetakeTestAppID.Text = "N/A";
            }
            else
            {
                lbl_RetakeAppFees.Text = ObjTestAppointment.ObjRetakeTestAppInfo.PaidFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lbl_Title.Text = "Schedule Retake Test";
                lbl_RetakeTestAppID.Text = ObjTestAppointment.RetakeTestAppID.ToString();

            }
            return true;
        }

        //////////////////////////////////////////////////////////////////////

        private bool HandleActiveTestAppointmentConstraint()/////////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            if (Mode_ == enMode.AddNew && clsLocalLicenseApp_B.IsThereAnActiveScheduledTest(LocalLicenseAppID_, TestTypeID_))
            {
                lbl_UserMessage.Text = "Person AlreadyActive have an active appointment for this test";
                btn_Save.Enabled = false;
                dtp_TestDate.Enabled = false;
                return false;
            }

            return true;
        }

        //////////////////////////////////////////////////////////////////////

        private bool HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (ObjTestAppointment.IsLocked)
            {
                lbl_UserMessage.Visible = true;
                lbl_UserMessage.Text = "Person already sat AppointmentLocked for the test, Appointment locked.";
                dtp_TestDate.Enabled = false;
                btn_Save.Enabled = false;
                return false;

            }
            else
                lbl_UserMessage.Visible = false;

            return true;
        }

        //////////////////////////////////////////////////////////////////////

        private bool HandlePreviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestTypeID)
            {
                case clsTestType_B.enTestTypeID.VisionTest:
                    //in this case no required prvious test to pass.
                    lbl_UserMessage.Visible = false;

                    return true;

                case clsTestType_B.enTestTypeID.WrittenTest:
                    //Written Test, you cannot Schedule it before person passes the vision test.
                    //we check if pass vision test 1.
                    if (!ObjLocalApp_Test.DoesPassTestType(clsTestType_B.enTestTypeID.VisionTest))
                    {
                        lbl_UserMessage.Text = "Cannot Schedule, Vision Test should be passed first";
                        lbl_UserMessage.Visible = true;
                        btn_Save.Enabled = false;
                        dtp_TestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbl_UserMessage.Visible = false;
                        btn_Save.Enabled = true;
                        dtp_TestDate.Enabled = true;
                    }


                    return true;

                case clsTestType_B.enTestTypeID.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!ObjLocalApp_Test.DoesPassTestType(clsTestType_B.enTestTypeID.WrittenTest))
                    {
                        lbl_UserMessage.Text = "Cannot Schedule, Written Test should be passed first";
                        lbl_UserMessage.Visible = true;
                        btn_Save.Enabled = false;
                        dtp_TestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbl_UserMessage.Visible = false;
                        btn_Save.Enabled = true;
                        dtp_TestDate.Enabled = true;
                    }


                    return true;

            }
            return true;

        }

        //////////////////////////////////////////////////////////////////////

        private bool HandleRetakeApplication()
        {
            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will linkit to the appoinment.
            if (Mode_ == enMode.AddNew && CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we linke it with the appointment.

                //First Create Applicaiton 
                clsApplication_B Application = new clsApplication_B();

                Application.AppPersonID = ObjLocalApp_Test.AppPersonID;
                Application.AppDate = DateTime.Now;
                Application.AppTypeID = (int)clsApplication_B.enAppType.RetakeTest;
                Application.AppStatus = clsApplication_B.enAppStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationType_B.Find((int)clsApplication_B.enAppType.RetakeTest).AppFees;
                Application.CreatedByUserID = clsLogIn_W.CurrentUser.UserID;

                if (!Application.SaveApp_B())
                {
                    ObjTestAppointment.RetakeTestAppID = -1;
                    MessageBox.Show("Failed to Create application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                ObjTestAppointment.RetakeTestAppID = Application.AppID;

            }
            return true;
        }

        //////////////////////////////////////////////////////////////////////

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!HandleRetakeApplication())
            {
                return;
            }

            ObjTestAppointment.TestTypeID = TestTypeID_;
            ObjTestAppointment.LocalLicenseAppID = ObjLocalApp_Test.LocalLicenseAppID;
            ObjTestAppointment.AppointmentDate = dtp_TestDate.Value;
            ObjTestAppointment.PaidFees = Convert.ToSingle(lbl_Fees.Text);
            ObjTestAppointment.CreatedByUserID = clsLogIn_W.CurrentUser.UserID;

            if (ObjTestAppointment.Save())
            {
                Mode_ = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error: Data Is not From [btnSave_Click] Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //////////////////////////////////////////////////////////////////////

    }
}
