using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Business_.Application_B;
using W_Business_.ApplicationType_B_W;
using W_Data_.License_D;
using W_Data_.Application;
using W_Data_.Application_D;

namespace W_Business_.License_B
{
    
    public class clsLicense_B
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };
        public enIssueReason IssueReason { set; get; }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText_B(this.IssueReason);
            }
        }
        public DateTime IssueDate { set; get; }

        public int DriverID { set; get; }
        public clsDriver ObjDriverInfo;

        public int LicenseClassID { set; get; }
        public clsLicenseClass_B ObjLicenseClassInfo;

        public int ApplicationID { set; get; }

        public int LicenseID { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }

        public bool IsDetained
        {
            get { return clsDetainedLicense.IsLicenseDetained(this.LicenseID); }
        }
        public clsDetainedLicense ObjDetainedInfo { set; get; }
        
        public clsLicense_B()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        } 

        public clsLicense_B(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            float PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            this.LicenseClassID = LicenseClassID;
            this.ObjLicenseClassInfo = clsLicenseClass_B.FindClass_B(this.LicenseClassID);

            this.DriverID = DriverID;
            this.ObjDriverInfo = clsDriver.FindByDriverID(this.DriverID);
            
            this.ObjDetainedInfo = clsDetainedLicense.FindByLicenseID(this.LicenseID);

            Mode = enMode.Update;
        }

        /////////////////////////////////////////////////////////////////////////

        private bool AddNewLicense_B()
        {
            this.LicenseID = clsLicense_D.AddNewLicense_D(this.ApplicationID, this.DriverID, this.LicenseClassID,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

            return (this.LicenseID != -1);
        }

        /////////////////////////////////////////////////////////////////////////

        private bool UpdateLicense_B()
        {

            return clsLicense_D.UpdateLicense_D(this.ApplicationID, this.LicenseID, this.DriverID, this.LicenseClassID,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

        }

        /////////////////////////////////////////////////////////////////////////

        public static clsLicense_B FindLicense_B(int LicenseID)
        {

            int ApplicationID = -1; int DriverID = -1; int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;
            if (clsLicense_D.GetLicenseInfoByID_D(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID,
                                                    ref IssueDate, ref ExpirationDate, ref Notes,
                                                    ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense_B(LicenseID, ApplicationID, DriverID, LicenseClassID,
                                     IssueDate, ExpirationDate, Notes,
                                     PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);

            }
            else
                return null;

        }

        /////////////////////////////////////////////////////////////////////////

        public static DataTable GetAllLicenses_B()
        {
            return clsLicense_D.GetAllLicenses_D();

        }

        /////////////////////////////////////////////////////////////////////////

        public static DataTable GetDriverLicenses_B(int DriverID)
        {
            return clsLicense_D.GetDriverLicenses_D(DriverID);
        }

        /////////////////////////////////////////////////////////////////////////

        public bool SaveLicense_B()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    
                    if (AddNewLicense_B())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateLicense_B();

            }

            return false;
        }

        /////////////////////////////////////////////////////////////////////////

        public static int GetActiveLicenseIDByPersonID_B(int PersonID, int LicenseClassID)
        {

            return clsLicense_D.GetActiveLicenseIDByPersonID_D(PersonID, LicenseClassID);

        }

        /////////////////////////////////////////////////////////////////////////

        public static bool IsLicenseExistByPersonID_B(int PersonID, int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID_B(PersonID, LicenseClassID) != -1);
        }

        /////////////////////////////////////////////////////////////////////////

        public Boolean IsLicenseExpired_B()
        {

            return (this.ExpirationDate < DateTime.Now);

        }

        /////////////////////////////////////////////////////////////////////////

        public bool DeactivateCurrentLicense_B()
        {
            return (clsLicense_D.DeactivateLicense_D(this.LicenseID));
        }

        /////////////////////////////////////////////////////////////////////////

        public static string GetIssueReasonText_B(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }

        /////////////////////////////////////////////////////////////////////////

        public clsLicense_B RenewLicense(string Notes, int CreatedByUserID)
        {

            
            clsApplication_B Application = new clsApplication_B();

            Application.AppPersonID = this.ObjDriverInfo.PersonID;
            Application.AppDate = DateTime.Now;
            Application.AppTypeID = (int)clsApplication_B.enAppType.RenewLic;
            Application.AppStatus = clsApplication_B.enAppStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType_B.Find((int)clsApplication_B.enAppType.RenewLic).AppFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.SaveApp_B())
            {
                return null;
            }

            clsLicense_B NewLicense = new clsLicense_B();

            NewLicense.ApplicationID = Application.AppID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.ObjLicenseClassInfo.DefaultValidityLength;

            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.ObjLicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicense_B.enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;


            if (!NewLicense.SaveLicense_B())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense_B();

            return NewLicense;
        }

        /////////////////////////////////////////////////////////////////////////

        public clsLicense_B ReplaceLicense(enIssueReason IssueReason, int CreatedByUserID)
        {


            
            clsApplication_B Application = new clsApplication_B();

            Application.AppPersonID = this.ObjDriverInfo.PersonID;
            Application.AppDate = DateTime.Now;

            Application.AppTypeID = (IssueReason == enIssueReason.DamagedReplacement) ?
                (int)clsApplication_B.enAppType.ReplaceDamagedLic :
                (int)clsApplication_B.enAppType.ReplaceLostLic;

            Application.AppStatus = clsApplication_B.enAppStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType_B.Find(Application.AppTypeID).AppFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.SaveApp_B())
            {
                return null;
            }

            clsLicense_B NewLicense = new clsLicense_B();

            NewLicense.ApplicationID = Application.AppID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = CreatedByUserID;



            if (!NewLicense.SaveLicense_B())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense_B();

            return NewLicense;
        }

        /////////////////////////////////////////////////////////////////////////


    
        public int Detain(float FineFees, int CreatedByUserID)
        {
            clsDetainedLicense ObjDetainedLicense = new clsDetainedLicense();
            ObjDetainedLicense.LicenseID = this.LicenseID;
            ObjDetainedLicense.DetainDate = DateTime.Now;
            ObjDetainedLicense.FineFees = Convert.ToSingle(FineFees);
            ObjDetainedLicense.CreatedByUserID = CreatedByUserID;

            if (!ObjDetainedLicense.Save())
            {

                return -1;
            }

            return ObjDetainedLicense.DetainID;
           

        }
      
        public bool ReleaseDetainedLicense(int ReleasedByUserID, ref int ApplicationID)
        {

            clsApplication_B Application = new clsApplication_B();

            Application.AppPersonID = this.ObjDriverInfo.PersonID;
            Application.AppDate = DateTime.Now;
            Application.AppTypeID = (int)clsApplication_B.enAppType.ReleaseDetainedLic;
            Application.AppStatus = clsApplication_B.enAppStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType_B.Find((int)clsApplication_B.enAppType.ReleaseDetainedLic).AppFees;
            Application.CreatedByUserID = ReleasedByUserID;

            if (!Application.SaveApp_B())
            {
                ApplicationID = -1;
                return false;
            }

            ApplicationID = Application.AppID;


            
            return this.ObjDetainedInfo.ReleaseDetainedLicense(ReleasedByUserID, Application.AppID);
            
        }
    
    
    }
}
