using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_;
// Finish 
namespace W_Business_
{
    public class clsUser_B
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public clsPerson_B PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsUser_B()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUser_B(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson_B.Find(PersonID);
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        /// ////////////////////////////////////////////////////////////////

        /// ////////////////////////////////////////////////////////////////

        private bool AddNewUser()
        {
            //call DataAccess Layer 

            this.UserID = clsUser_D.AddNewUser_D(this.PersonID, this.UserName,
                this.Password, this.IsActive);

            return (this.UserID != -1);
        }
        
        //////////////////////////////////////////////////////////////////
        
        private bool UpdateUser()
        {
            //call DataAccess Layer 

            return clsUser_D.UpdateUser_D(this.UserID, this.PersonID, this.UserName,
                this.Password, this.IsActive);
        }

        /// ////////////////////////////////////////////////////////////////

        public static clsUser_B FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUser_D.GetUserInfoByUserID
                                (UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser_B(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        
        //////////////////////////////////////////////////////////////////
        
        public static clsUser_B FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUser_D.GetUserInfoByPersonID
                                (PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser_B(UserID, UserID, UserName, Password, IsActive);
            else
                return null;
        }
        
        //////////////////////////////////////////////////////////////////
        
        public static clsUser_B FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;

            bool IsActive = false;

            bool IsFound = clsUser_D.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                return new clsUser_B(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
       
        //////////////////////////////////////////////////////////////////

        public static bool isUserExist(int UserID)
        {
            return clsUser_D.IsUserExist(UserID);
        }
        
        //////////////////////////////////////////////////////////////////

        public static bool isUserExist(string UserName)
        {
            return clsUser_D.IsUserExist(UserName);
        }

        //////////////////////////////////////////////////////////////////
        
        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUser_D.IsUserExistForPersonID(PersonID);
        }

        ///////////////////////////////////////////////////////////////////

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateUser();

            }

            return false;
        }

        /// ////////////////////////////////////////////////////////////////

        public static DataTable GetAllUsers()
        {
            return clsUser_D.GetAllUsers_D(); 
        }

        /// ////////////////////////////////////////////////////////////////

        public static bool DeleteUser(int UserID)
        {
            return clsUser_D.DeleteUser_D(UserID);
        }

        /// ////////////////////////////////////////////////////////////////

        
    }
}
