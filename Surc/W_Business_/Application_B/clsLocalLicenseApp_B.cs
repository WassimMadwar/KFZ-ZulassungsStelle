using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Business_.License_B;
using W_Business_.Test_B;
using W_Data_;
using W_Data_.Application_D;
using W_Data_.Test_D;


namespace W_Business_.Application_B
{
  
    public class clsLocalLicenseApp_B : clsApplication_B
    {
        
        public enum enMode { AddNew = 0, Update = 1 };
       
        public enMode Mode_LLA = enMode.AddNew;

        public int LocalLicenseAppID { set; get; }


        public string PersonFullName
        {
            get
            {
                
                
                return clsPerson_B.Find(AppPersonID).FullName;
            }

        }


        public int LicenseClassID { set; get; }
        public clsLicenseClass_B ObjLicenseClassInfo;

        public clsLocalLicenseApp_B()
        {
            this.LicenseClassID = -1;
            this.LocalLicenseAppID = -1;

            Mode_LLA = enMode.AddNew;
        }

        private clsLocalLicenseApp_B(int LocalLicenseAppID, int AppID, int AppPersonID,
            DateTime AppDate, int AppTypeID, enAppStatus AppStatus, float PaidFees,
            DateTime LastStatusDate, int CreatedByUserID, int LicenseClassID)
        {
            this.LocalLicenseAppID= LocalLicenseAppID; 
            this.LicenseClassID = LicenseClassID;
            this.AppID = AppID; 
            this.AppDate = AppDate;
            this.AppPersonID = AppPersonID;
            this.AppStatus = AppStatus;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.AppTypeID = (int)AppTypeID;
            this.LastStatusDate = LastStatusDate;
            this.ObjLicenseClassInfo = clsLicenseClass_B.FindClass_B(LicenseClassID);

            Mode_LLA = enMode.Update;
        }
        //////////////////////////////////////////////////////////////////////

        public static clsLocalLicenseApp_B FindInfoBy_LocalLicenseAppID_B(int LocalLicenseAppID)
        {
             
            int AppID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalLicenseApp_D.GetLocalLicenseAppInfoByID_D(LocalLicenseAppID, ref AppID, ref LicenseClassID);

            if (IsFound)
            {
                clsApplication_B BasisApp =  clsApplication_B.FindBaseApp_B(AppID);


                return new clsLocalLicenseApp_B
                    (LocalLicenseAppID, BasisApp.AppID, BasisApp.AppPersonID, BasisApp.AppDate,
                    BasisApp.AppTypeID, (enAppStatus)BasisApp.AppStatus, BasisApp.PaidFees, 
                    BasisApp.LastStatusDate, BasisApp.CreatedByUserID, LicenseClassID);

            }
            else
            {
                return null;
                
            }
        }

        //////////////////////////////////////////////////////////////////////

        public static clsLocalLicenseApp_B FindLocalLicenseAppInfoBy_BasisAppID_B(int AppID)
        {
            int LocalLicenseAppID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalLicenseApp_D.GetLocalLicenseAppInfoByBasisAppID_D(AppID, ref LocalLicenseAppID, ref LicenseClassID);


            if (IsFound)
            {
                
                clsApplication_B BasisApp = clsApplication_B.FindBaseApp_B(AppID);

                return new clsLocalLicenseApp_B
                     (LocalLicenseAppID, BasisApp.AppID, BasisApp.AppPersonID, BasisApp.AppDate,
                    BasisApp.AppTypeID, (enAppStatus)BasisApp.AppStatus, BasisApp.PaidFees,
                    BasisApp.LastStatusDate, BasisApp.CreatedByUserID, LicenseClassID);
            }
            else
            {
                return null;

            }

        }

        //////////////////////////////////////////////////////////////////////

        public static DataTable GetAllLocalLicenseApp_B()
        {
            return clsLocalLicenseApp_D.GetAllLocalLicenseApp_D();
        }

        //////////////////////////////////////////////////////////////////////

        private bool AddNewLocalLicenseApp_B()
        {
            this.LocalLicenseAppID = clsLocalLicenseApp_D.AddNewLocalLicenseApp_D
                (this.AppID, this.LicenseClassID);

            return (this.LocalLicenseAppID != -1);
        }

        //////////////////////////////////////////////////////////////////////

        private bool UpdateLocalLicenseApp_B()
        {
            return clsLocalLicenseApp_D.UpdateLocalLicenseApp_D(this.LocalLicenseAppID, this.AppID, this.LicenseClassID);
        
        }

        //////////////////////////////////////////////////////////////////////
        /// <summary>
        /// _LLA_ From clsLocalLicenseApp_B
        /// </summary>
        /// <returns></returns>
        public bool Save_LLA_B()
        {

            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.
           
            
            
            base.Mode = (clsApplication_B.enMode)Mode_LLA; // the Mode will be same in the base class and in sub class
            
            if (!base.SaveApp_B())
                return false;


            //After we save the main application now we save the sub application.
            switch (Mode_LLA)
            {
                case enMode.AddNew:
                    if (AddNewLocalLicenseApp_B())
                    {

                        Mode_LLA = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateLocalLicenseApp_B();

            }

            return false;
        }

        //////////////////////////////////////////////////////////////////////

        public bool Delete_LLA_B()
        {
            bool IsLocalAppDeleted = false;
            bool IsBaseAppDeleted = false;

            IsLocalAppDeleted = clsLocalLicenseApp_D.DeleteLocalLicenseApp_D(this.LocalLicenseAppID);

            if (!IsLocalAppDeleted)
            {
                return false ;
            }
            else
            {
                IsBaseAppDeleted = base.DeleteApp_B();
            }

            return IsBaseAppDeleted;
        }

        //////////////////////////////////////////////////////////////////////

        //  public static bool to use it outof Object ,it take (int LocalLicenseAppID)
        //  public bool to use it in Object ,it take the same obj element

        //////////////////////////////////////////////////////////////////////
        /////////////////// Start Pass Section /////////////////////////
        
        public static bool DoesPassTestType(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.DoesPassTestType_D(LocalLicenseAppID, (int)TestTypeID);
        }

        public bool DoesPassTestType(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.DoesPassTestType_D(this.LocalLicenseAppID, (int)TestTypeID);
        }

        public bool DoesPassPreviousTest(clsTestType_B.enTestTypeID CurrentTestType)
        {

            switch (CurrentTestType)
            {
                case clsTestType_B.enTestTypeID.VisionTest:
                    //in this case no required previous test to pass.
                    return true;

                case clsTestType_B.enTestTypeID.WrittenTest:
                    //Written Test, you cannot schedule it before person passes the vision test.
                    //we check if pass vision test 1.

                    return this.DoesPassTestType(clsTestType_B.enTestTypeID.VisionTest);


                case clsTestType_B.enTestTypeID.StreetTest:

                    //Street Test, you cannot schedule it before person passes the written test.
                    //we check if pass Written 2.
                    return this.DoesPassTestType(clsTestType_B.enTestTypeID.WrittenTest);

                default:
                    return false;


            }
        }

        //////////////////////////////////////////////////////////////////////

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalLicenseAppID);
        }

        public static byte GetPassedTestCount(int LocalLicenseAppID)
        {
            return clsTest.GetPassedTestCount(LocalLicenseAppID);
        }

        //////////////////////////////////////////////////////////////////////

        public bool PassedAllTests()
        {
            return clsTest.IsPassedAllTests(this.LocalLicenseAppID);
        }

        public static bool PassedAllTests_out(int LocalLicenseAppID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return clsTest.IsPassedAllTests(LocalLicenseAppID);
        }

        //////////////////// End Pass Section //////////////////////////////
        //////////////////////////////////////////////////////////////////////

        public bool DoesAttendTestType(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.DoesAttendTestType_D(this.LocalLicenseAppID, (int)TestTypeID);
        }
      
        public bool TotalAttendedTest(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.TotalTrialsPerTest_D(this.LocalLicenseAppID, (int)TestTypeID) > 0;

        }
        
        public static bool TotalAttendedTest(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.TotalTrialsPerTest_D(LocalLicenseAppID, (int)TestTypeID) > 0;

        }

        //////////////////////////////////////////////////////////////////////

        public byte TotalTrialsPerTest(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.TotalTrialsPerTest_D(this.LocalLicenseAppID, (int)TestTypeID);
        }
        public static byte TotalTrialsPerTest(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.TotalTrialsPerTest_D(LocalLicenseAppID, (int)TestTypeID);

        }

        //////////////////////////////////////////////////////////////////////

        public bool IsThereAnActiveScheduledTest(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.IsThereAnActiveScheduledTest_D(this.LocalLicenseAppID, (int)TestTypeID);
        }
        public static bool IsThereAnActiveScheduledTest(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsLocalLicenseApp_D.IsThereAnActiveScheduledTest_D(LocalLicenseAppID, (int)TestTypeID);

        }

        //////////////////////////////////////////////////////////////////////

        public bool IsLicenseIssued_B()
        {
            return (GetActiveLicenseID_B() != -1);
        }

        public int GetActiveLicenseID_B()
        {//this will get the license id that belongs to this application
            return clsLicense_B.GetActiveLicenseIDByPersonID_B(this.AppPersonID, this.LicenseClassID);
        }

        //////////////////////////////////////////////////////////////////////

        public clsTest GetLastTestPerTestType(clsTestType_B.enTestTypeID TestTypeID)
        {
            return clsTest.FindLastTestPerPersonAndTestTypeAndLicenseClass(this.AppPersonID, this.LicenseClassID, TestTypeID);

        }

        //////////////////////////////////////////////////////////////////////
        /// <summary>
///  W_ 6/7 Completed
/// </summary>
/// <param name="Notes"></param>
/// <param name="CreatedByUserID"></param>
/// <returns></returns>
        public int IssueLicenseForTheFirstTime(string Notes, int CreatedByUserID)
        {
                //we check if the driver already there for this person.
            int DriverID = -1;

            clsDriver ObjDriver = clsDriver.FindByPersonID(this.AppPersonID);

            if (ObjDriver == null)
            {
                ObjDriver = new clsDriver();

                ObjDriver.PersonID = this.AppPersonID;
                ObjDriver.CreatedByUserID = CreatedByUserID;
                if (ObjDriver.Save())
                {
                    DriverID = ObjDriver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = ObjDriver.DriverID;
            }
           

            clsLicense_B ObjLicense = new clsLicense_B();
            ObjLicense.ApplicationID = this.AppID;
            ObjLicense.DriverID = DriverID;
            ObjLicense.LicenseClassID = this.LicenseClassID;
            ObjLicense.IssueDate = DateTime.Now;
            ObjLicense.ExpirationDate = DateTime.Now.AddYears(this.ObjLicenseClassInfo.DefaultValidityLength);
            ObjLicense.Notes = Notes;
            ObjLicense.PaidFees = this.ObjLicenseClassInfo.ClassFees;
            ObjLicense.IsActive = true;
            ObjLicense.IssueReason = clsLicense_B.enIssueReason.FirstTime;
            ObjLicense.CreatedByUserID = CreatedByUserID;

            if (ObjLicense.SaveLicense_B())
            {
                //now we should set the application status to complete.
                this.SetCompletedApp_B();

                return ObjLicense.LicenseID;
            }

            else
                return -1;
        }

        //////////////////////////////////////////////

    }

}
