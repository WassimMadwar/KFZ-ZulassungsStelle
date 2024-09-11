using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_;
using W_Data_.License_D;
// Finish
namespace W_Business_.License_B
{
    public class clsLicenseClass_B
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public float ClassFees { set; get; }

    
        public clsLicenseClass_B() 
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 10;
            this.ClassFees = 0;

            Mode = enMode.AddNew;
        }

        public clsLicenseClass_B(int LicenseClassID, string ClassName, string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            Mode = enMode.Update;
        }
        /////////////////////////////////////////////////////////////////////////

        private bool AddNewLicenseClass_B()
        {
            this.LicenseClassID = clsLicenseClass_D.AddNewLicenseClass_D
                (this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
            
            return (this.LicenseClassID != -1);
        }

        /////////////////////////////////////////////////////////////////////////

        private bool UpdateLicenseClass_B()
        {
            return clsLicenseClass_D.UpdateLicenseClass_D(this.LicenseClassID, this.ClassName, this.ClassDescription,
                this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        /////////////////////////////////////////////////////////////////////////

        public static clsLicenseClass_B FindClass_B(int LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;
            
            if(clsLicenseClass_D.GetLicenseClassInfoByID_D(LicenseClassID, ref ClassName, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {

                return new clsLicenseClass_B(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        /////////////////////////////////////////////////////////////////////////

        public static clsLicenseClass_B FindClass_B(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (clsLicenseClass_D.GetLicenseClassInfoByClassName_D(ClassName, ref LicenseClassID, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {

                return new clsLicenseClass_B(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }
       
        /////////////////////////////////////////////////////////////////////////

        public static DataTable GetAllLicenseClasses_B()
        {
            return clsLicenseClass_D.GetAllLicenseClasses_D();
        }

        /////////////////////////////////////////////////////////////////////////

        public bool Save_LC()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewLicenseClass_B())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateLicenseClass_B();

            }

            return false;
        }

        /////////////////////////////////////////////////////////////////////////

    }
}
