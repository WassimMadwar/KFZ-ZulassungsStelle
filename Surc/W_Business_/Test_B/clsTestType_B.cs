using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.Test_D;
// Finish 
namespace W_Business_.Test_B
{//Services 
    public class clsTestType_B
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enTestTypeID { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public clsTestType_B.enTestTypeID TypeID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public float Fees { set; get; }
       
        public clsTestType_B()
        {
            this.TypeID = clsTestType_B.enTestTypeID.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;

            Mode = enMode.AddNew;
        }

        public clsTestType_B(clsTestType_B.enTestTypeID TypeID, string TestTitle, string Description, float TestFees)
        {
            this.TypeID = TypeID;
            this.Title = TestTitle;
            this.Description = Description;
            this.Fees = TestFees;

            Mode = enMode.Update;
        }

        /// ////////////////////////////////////////////////////////////////

        private bool AddNewTestType()
        {

            this.TypeID = (clsTestType_B.enTestTypeID)clsTestType_D.AddNewTestType_D(this.Title, this.Description, this.Fees);

            return (this.Title != "");
        }

        /// ////////////////////////////////////////////////////////////////

        private bool UpdateTestType()
        {

            return clsTestType_D.UpdateTestType_D((int)this.TypeID, this.Title, this.Description, this.Fees);
        }

        /// ////////////////////////////////////////////////////////////////

        public static clsTestType_B Find(clsTestType_B.enTestTypeID TestTypeID)
        {
            string Title = "", Description = ""; float Fees = 0;

            if (clsTestType_D.GetTestTypeInfoByID_D((int)TestTypeID, ref Title, ref Description, ref Fees))

                return new clsTestType_B(TestTypeID, Title, Description, Fees);
            else
                return null;

        }

        /// ////////////////////////////////////////////////////////////////

        public static DataTable GetAllTestTypes()
        {
            return clsTestType_D.GetAllTestTypes_D();

        }

        /// ////////////////////////////////////////////////////////////////

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTestType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateTestType();

            }

            return false;
        }

        /// ////////////////////////////////////////////////////////////////


    }
}
