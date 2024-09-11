using System.Data;
using W_Data_.Application;

namespace W_Business_.ApplicationType_B_W
{
    public class clsApplicationType_B
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int AppTypeID { set; get; }
        public string AppTitle { set; get; }
        public float AppFees { set; get; }

        public clsApplicationType_B()
        {
            this.AppTypeID = -1;
            this.AppTitle = "";
            this.AppFees = 0;
            Mode = enMode.AddNew;

        }

        public clsApplicationType_B(int AppTypeID, string AppTitle, float AppFees)
        {
            this.AppTypeID = AppTypeID;
            this.AppTitle = AppTitle;
            this.AppFees = AppFees;
            Mode = enMode.Update;
        }

        /// ////////////////////////////////////////////////////////////////

        public static clsApplicationType_B Find(int AppTypeID)
        {
            string AppTitle = ""; float AppFees = 0;

            if (clsApplicationType_D.GetApplicationTypeInfoByID_D((int)AppTypeID, ref AppTitle, ref AppFees))

                return new clsApplicationType_B(AppTypeID, AppTitle, AppFees);
            else
                return null;

        }

        /// ////////////////////////////////////////////////////////////////

        private bool AddNewApplicationType_B()
        {
            this.AppTypeID = clsApplicationType_D.AddNewApplicationType_D(this.AppTitle, this.AppFees);
            return (this.AppTypeID != -1);
        }

        /// ////////////////////////////////////////////////////////////////

        private bool UpdateApplicationType_B()
        {
            return clsApplicationType_D.UpdateApplicationType_D(this.AppTypeID, this.AppTitle, this.AppFees);
        }

        /// ////////////////////////////////////////////////////////////////

        public static DataTable GetAllAppTypes()
        {
            return clsApplicationType_D.GetAllApplicationTypes_D();
        }

        /// ////////////////////////////////////////////////////////////////

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewApplicationType_B())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateApplicationType_B();

            }

            return false;
        }

        /// ////////////////////////////////////////////////////////////////
        
    }
}
