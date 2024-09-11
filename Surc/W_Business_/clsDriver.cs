using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_;
using W_Data_.License_D;
using W_Business_.License_B;

namespace W_Business_
{
    public class clsDriver
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsPerson_B ObjPerson;
        public int PersonID { set; get; }

        public int DriverID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { get; }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;

        }

        public clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.ObjPerson = clsPerson_B.Find(PersonID);

            Mode = enMode.Update;
        }

        private bool AddNewDriver()
        {
           

            this.DriverID = clsDriver_D.AddNewDriver_D(PersonID, CreatedByUserID);


            return (this.DriverID != -1);
        }

        private bool UpdateDriver()
        {

            return clsDriver_D.UpdateDriver_D(this.DriverID, this.PersonID, this.CreatedByUserID);
        }

        public static clsDriver FindByDriverID(int DriverID)
        {

            int PersonID = -1; int CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            if (clsDriver_D.GetDriverInfoByDriverID_D(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public static clsDriver FindByPersonID(int PersonID)
        {

            int DriverID = -1; int CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            if (clsDriver_D.GetDriverInfoByPersonID_D(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewDriver())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateDriver();

            }

            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriver_D.GetAllDrivers_D();

        }

        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicense_B.GetDriverLicenses_B(DriverID);
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }

    }
}
