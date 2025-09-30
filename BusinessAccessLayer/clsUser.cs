using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode ;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }
        private  bool _AddUser()
        {
            this.UserID = UserData.AddUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            return UserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        public bool UpdateUserPassword()
        {
            return UserData.UpdateUserPassword(this.UserID, this.Password);
        }
        public static bool DeleteUser(int UserID)
        {
            return UserData.DeleteUser(UserID);
        }
        public static DataTable GetAllUsers(string ColumnName=null,string value=null)
        {
            return UserData.GetAllUsers(ColumnName,value);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static clsUser GetUserByID(int UserID)
        {
            int PersonID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = true;
            if (UserData.GetUserByID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser GetUserByUserName(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = "";
            bool IsActive = true;
            if (UserData.GetUserByUsername(ref UserID,ref PersonID,UserName,ref Password,ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static clsUser LoginCheck(string UserName,string Password)
        {
            clsUser LoggedUser=clsUser.GetUserByUserName(UserName);
            if (LoggedUser == null) return null;
            if (LoggedUser.Password != Password) return null;
            return LoggedUser;
        }


        public static bool IsUserExistsWithUsername(string Username)
        {
            return UserData.IsUserExistsWithUsername(Username);
        }

        public static bool IsPersonLinkedWithUser(int PersonID)
        {
            return UserData.IsPersonLinkedWithUser(PersonID);
        }
    }
}
