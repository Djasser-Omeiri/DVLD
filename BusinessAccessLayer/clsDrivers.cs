using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsDrivers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDrivers()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsDrivers(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;
        }

        private bool _AddDriver()
        {
            this.DriverID = DriversData.AddDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return this.DriverID != -1;
        }
        private bool _UpdateDriver()
        {
            return DriversData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }
        public static bool DeleteDriver(int DriverID)
        {
            return DriversData.DeleteDriver(DriverID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case (enMode.AddNew):
                    if (_AddDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateDriver();

            }
            return false;
        }
        public static clsDrivers GetDriverByID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            if (DriversData.GetDriverByID( DriverID, ref  PersonID, ref  CreatedByUserID, ref  CreatedDate))
            {
                return new clsDrivers( DriverID,  PersonID,  CreatedByUserID,  CreatedDate);
            }
            else
            {
                return null;
            }
        }
    }
}
