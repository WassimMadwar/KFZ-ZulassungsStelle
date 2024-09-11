using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Business_.ApplicationType_B_W;
using W_Data_;
using W_Data_.Application;
using W_Data_.Application_D;

namespace W_Business_.Application_B
{
    public class clsApplication_B
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enAppType
        {
            NewLic = 1, RenewLic = 2, ReplaceLostLic = 3,
            ReplaceDamagedLic = 4, ReleaseDetainedLic = 5, NewInternationalLic = 6, RetakeTest = 7
        };

        public enum enAppStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enAppStatus AppStatus { set; get; }
        public string StatusText
        {
            get
            {

                switch (AppStatus)
                {
                    case enAppStatus.New:
                        return "New";
                    case enAppStatus.Cancelled:
                        return "Cancelled";
                    case enAppStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }



        public int AppPersonID { set; get; }
        public string ApplicantFullName
        {
            get
            {
                return ObjPersonInfo.FullName; ;
                //return clsPerson_B.Find(AppPersonID).FullName;
            }
        }
        public clsPerson_B ObjPersonInfo { set; get; }
     
        


        public int AppID { set; get; }
        public DateTime AppDate { set; get; }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        
        public int AppTypeID { set; get; }
        public clsApplicationType_B ObjAppTypeInfo;

        public int CreatedByUserID { set; get; }
        public clsUser_B ObjCreatedByUserInfo;
        
        

        public clsApplication_B()
        {
            this.AppID = -1;
            this.AppTypeID = -1;
            this.AppPersonID = -1;
            this.AppDate = DateTime.Now;
            this.LastStatusDate = DateTime.Now;
            this.AppStatus = enAppStatus.New;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        private clsApplication_B(int AppID, int AppPersonID, DateTime AppDate, int AppTypeID,
             enAppStatus AppStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.AppID = AppID;
            this.AppDate = AppDate;
            this.LastStatusDate = LastStatusDate;
            this.AppStatus = AppStatus;
            this.PaidFees = PaidFees;
           
            this.AppPersonID = AppPersonID;
            this.ObjPersonInfo = clsPerson_B.Find(AppPersonID);

            this.AppTypeID = AppTypeID;
            this.ObjAppTypeInfo = clsApplicationType_B.Find(AppTypeID);

            this.CreatedByUserID = CreatedByUserID;
            this.ObjCreatedByUserInfo = clsUser_B.FindByUserID(CreatedByUserID);

            Mode = enMode.Update;

        }

        /// ////////////////////////////////////////////////////////////////

        public static clsApplication_B FindBaseApp_B(int AppID)
        {
            int AppPersonID = -1;
            DateTime AppDate = DateTime.Now; int AppTypeID = -1;
            byte AppStatus = 1; DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0; int CreatedByUserID = -1;

            bool IsFound = clsApplication_D.GetAppInfoByID_D
                (
                    AppID,ref AppPersonID,ref AppDate,ref AppTypeID,
                    ref AppStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID
                );

            if (IsFound)
            {
                return new clsApplication_B(AppID, AppPersonID, AppDate, AppTypeID,
                          (enAppStatus)AppStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
                
            }
        }

        /// ////////////////////////////////////////////////////////////////

        private bool AddNewApp_B()
        {
            this.AppID = clsApplication_D.AddNewApp_D(this.AppPersonID, this.AppDate, this.AppTypeID,
                (byte)this.AppStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);


                return (this.AppID != -1);
        }

        /// ////////////////////////////////////////////////////////////////

        private bool UpdateApp_B()
        {
            return clsApplication_D.UpdateApp_D(this.AppID,this.AppPersonID, this.AppDate, this.AppTypeID,
                (byte)this.AppStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        /// ////////////////////////////////////////////////////////////////

        public bool CancelApp_B()
        {
            return clsApplication_D.UpdateStatus_D(AppID, 2);
        }

        /// ////////////////////////////////////////////////////////////////
        
        public bool SetCompletedApp_B()
        {
            return clsApplication_D.UpdateStatus_D(AppID, 3);
        }

        /// ////////////////////////////////////////////////////////////////

        public bool SaveApp_B()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewApp_B())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                {
                    return UpdateApp_B();
                }

            }
            
            
            return false;

        }

        /// ////////////////////////////////////////////////////////////////

        public bool DeleteApp_B()
        {
            return clsApplication_D.DeleteApp_D(this.AppID);
        }

        /// ////////////////////////////////////////////////////////////////

        public static bool IsAppExist_B(int ApplicationID)
        {
            return clsApplication_D.IsAppExist_D(ApplicationID);
        }

        /// ////////////////////////////////////////////////////////////////

        public static bool DoesPersonHaveActiveApp_B(int AppPersonID, int AppTypeID)
        {
            return clsApplication_D.DoesPersonHaveActiveApp_D(AppPersonID, AppTypeID);
        }

        /// ////////////////////////////////////////////////////////////////

        public bool HavePersonActiveApp_B(int AppTypeID)
        {
            return DoesPersonHaveActiveApp_B(this.AppPersonID, AppTypeID);
        }

        /// ////////////////////////////////////////////////////////////////

        public static int GetActiveAppID_B(int AppPersonID, clsApplication_B.enAppType AppTypeID)
        {
            return clsApplication_D.GetActiveAppID_D(AppPersonID, (int)AppTypeID);
        }

        /// ////////////////////////////////////////////////////////////////

        public int GetActiveApplicationID_B(clsApplication_B.enAppType AppTypeID)
        {
            return GetActiveAppID_B(this.AppPersonID, AppTypeID);
        }

        /// ////////////////////////////////////////////////////////////////

        public static int GetActiveAppIDForLicenseClass_B(int AppPersonID, clsApplication_B.enAppType AppTypeID, int LicenseClassID)
        {
            return clsApplication_D.GetActiveAppIDForLicenseClass_D(AppPersonID, (int)AppTypeID, LicenseClassID);
        }

        /// ////////////////////////////////////////////////////////////////
        
        /// ////////////////////////////////////////////////////////////////

    }
}
