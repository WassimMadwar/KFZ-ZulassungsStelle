using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.Test_D;
//Finish
namespace W_Business_.Test_B
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestID { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public int TestAppointmentID { set; get; }
        public clsTestAppointment_B ObjTestAppointment { set; get; }

        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        public clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.ObjTestAppointment = clsTestAppointment_B.Find_TA_B(TestAppointmentID);

            Mode = enMode.Update;
        }

        /////////////////////////////////////////////////////////////////////////////////

        private bool AddNewTest()
        {

            this.TestID = clsTest_D.AddNewTest_D(this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);


            return (this.TestID != -1);
        }

        /////////////////////////////////////////////////////////////////////////////////

        private bool UpdateTest()
        {

            return clsTest_D.UpdateTest_D(this.TestID, this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);
        }
        
        /////////////////////////////////////////////////////////////////////////////////

        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (clsTest_D.GetInfoByTestID_D(TestID,
            ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))
            {

                return new clsTest(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            }
            else
                return null;

        }

        /////////////////////////////////////////////////////////////////////////////////

        public static clsTest FindLastTestPerPersonAndTestTypeAndLicenseClass
         (int PersonID, int LicenseClassID, clsTestType_B.enTestTypeID TestTypeID)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (clsTest_D.GetLastTestByPersonAndTestTypeAndLicenseClass_D
                (PersonID, LicenseClassID, (int)TestTypeID, ref TestID,
            ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))

                return new clsTest(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            else
                return null;

        }

        /////////////////////////////////////////////////////////////////////////////////

        public static DataTable GetAllTests()
        {
            return clsTest_D.GetAllTests_D();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateTest();

            }

            return false;
        }

        /////////////////////////////////////////////////////////////////////////////////

        public static byte GetPassedTestCount(int LocalLicenseAppID)
        {
            return clsTest_D.GetPassedTestCount_D(LocalLicenseAppID);
        }

        /////////////////////////////////////////////////////////////////////////////////

        public static bool IsPassedAllTests(int LocalLicenseAppID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return GetPassedTestCount(LocalLicenseAppID) == 3;
        }

        /////////////////////////////////////////////////////////////////////////////////

    }
}
