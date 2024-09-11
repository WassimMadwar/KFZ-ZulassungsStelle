using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Business_.Application_B;
using W_Data_.Application_D;
using W_Data_.License_D;

namespace W_Business_.License_B
{
    public class clsInternationalLicense : clsApplication_B
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode_IL = enMode.AddNew;

        public clsDriver ObjDriverInfo;
        public int DriverID { set; get; }

        public int IssuedUsingLocalLicenseID { set; get; }

        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int InternationalLicenseID { set; get; }


        public clsInternationalLicense()
        {
            //here we set the application type to New International License.
            this.AppTypeID = (int)clsApplication_B.enAppType.NewInternationalLic;

            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;

            this.IsActive = true;


            Mode_IL = enMode.AddNew;

        }

        public clsInternationalLicense(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
             enAppStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID,
             int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive)
        {
            //this is for the base class
            base.AppPersonID = ApplicantPersonID;
            base.AppID = ApplicationID;
            base.AppDate = ApplicationDate;
            base.AppTypeID = (int)clsApplication_B.enAppType.NewInternationalLic;
            base.AppStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            this.InternationalLicenseID = InternationalLicenseID;
            this.AppID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            this.ObjDriverInfo = clsDriver.FindByDriverID(this.DriverID);

            Mode_IL = enMode.Update;
        }

        private bool AddNewInternationalLicense()
        {

            this.InternationalLicenseID =
                clsInternationalLicense_D.AddNewInternationalLicense_D(this.AppID, this.DriverID, this.IssuedUsingLocalLicenseID,
               this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);



            return (this.InternationalLicenseID != -1);
        }

        private bool UpdateInternationalLicense()
        {
            //call DataAccess Layer 

            return clsInternationalLicense_D.UpdateInternationalLicense_D(this.InternationalLicenseID, this.AppID, this.DriverID,
                 this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);


        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1; int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true; int CreatedByUserID = 1;

            if (clsInternationalLicense_D.GetInternationalLicenseInfoByID_D(InternationalLicenseID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                //now we find the base application
                clsApplication_B Application = clsApplication_B.FindBaseApp_B(ApplicationID);


                return new clsInternationalLicense(Application.AppID, Application.AppPersonID, Application.AppDate,
                                    (enAppStatus)Application.AppStatus, Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID,
                                     InternationalLicenseID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive);


            }

            else
                return null;

        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicense_D.GetAllInternationalLicenses_D();

        }

        public bool Save()
        {

            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.
            base.Mode = (clsApplication_B.enMode)Mode;
            if (!base.SaveApp_B())
                return false;

            switch (Mode_IL)
            {
                case enMode.AddNew:
                    if (AddNewInternationalLicense())
                    {

                        Mode_IL = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateInternationalLicense();

            }

            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return clsInternationalLicense_D.GetActiveInternationalLicenseIDByDriverID_D(DriverID);

        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicense_D.GetInternationalLicensesInfoByDriverID_D(DriverID);
        }
    }
}
