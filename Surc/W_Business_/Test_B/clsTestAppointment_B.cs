using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.Test_D;
using W_Business_.Application_B;
using W_Data_.Application_D;
using System.Data;
// Finish
namespace W_Business_.Test_B
{
    public class clsTestAppointment_B
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public bool IsLocked { set; get; }
        public clsTestType_B.enTestTypeID TestTypeID { set; get; }

        public int RetakeTestAppID { set; get; }
        public clsApplication_B ObjRetakeTestAppInfo { set; get; }

        public int LocalLicenseAppID { set; get; }
        public int CreatedByUserID { set; get; }

        public int TestID
        {
            get { return GetTestID_B(); }

        }

        public clsTestAppointment_B()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestType_B.enTestTypeID.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestAppID = -1;

            Mode = enMode.AddNew;

        }

        public clsTestAppointment_B(int TestAppointmentID, clsTestType_B.enTestTypeID TestTypeID,
         int LocalLicenseAppID, DateTime AppointmentDate, float PaidFees,
         int CreatedByUserID, bool IsLocked, int RetakeTestAppID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;//5 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            this.LocalLicenseAppID = LocalLicenseAppID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestAppID = RetakeTestAppID;
            this.ObjRetakeTestAppInfo = clsApplication_B.FindBaseApp_B(RetakeTestAppID);

            Mode = enMode.Update;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool AddNewTestAppointment_B()
        {
            //call DataAccess Layer 

            this.TestAppointmentID = clsTestAppointment_D.AddNewTestAppointment_D((int)this.TestTypeID, this.LocalLicenseAppID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.RetakeTestAppID);

            return (this.TestAppointmentID != -1);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool UpdateTestAppointment_B()
        {
            //call DataAccess Layer 

            return clsTestAppointment_D.UpdateTestAppointment_D(this.TestAppointmentID, (int) this.TestTypeID, this.LocalLicenseAppID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static clsTestAppointment_B Find_TA_B(int TestAppointmentID)
        {
            int TestTypeID = 1; int LocalLicenseAppID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestAppID = -1;

            if (clsTestAppointment_D.GetTestAppointmentInfoByID_D(TestAppointmentID, ref TestTypeID, ref LocalLicenseAppID,
                                 ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppID))

                return new clsTestAppointment_B(TestAppointmentID, (clsTestType_B.enTestTypeID)TestTypeID, LocalLicenseAppID,
                       AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID);

            else
                return null;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static clsTestAppointment_B GetLastTestAppointment_B(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID)
        {
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestAppID = -1;

            if (clsTestAppointment_D.GetLastTestAppointment_D(LocalLicenseAppID, (int)TestTypeID, ref TestAppointmentID,
                 ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppID))

                return new clsTestAppointment_B(TestAppointmentID, TestTypeID, LocalLicenseAppID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID);

            else
                return null;

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointment_D.GetAllTestAppointments_D();

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public DataTable GetAppTestAppointmentsPerTestTypeID_B(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsTestAppointment_D.GetAppTestAppointmentsPerTestTypeID_D(this.LocalLicenseAppID, (int)TestTypeID);

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsTestAppointment_D.GetAppTestAppointmentsPerTestTypeID_D(LocalLicenseAppID, (int)TestTypeID);

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTestAppointment_B())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateTestAppointment_B();

            }

            return false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private int GetTestID_B()
        {
            return clsTestAppointment_D.GetTestID_D(TestAppointmentID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
