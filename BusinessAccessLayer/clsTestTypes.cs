using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDesciption { get; set; }
        public decimal TestTypeFees { get; set; }

        public clsTestTypes()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeDesciption = "";
            this.TestTypeFees = 0;
        }
        private clsTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDesciption, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDesciption =TestTypeDesciption;
            this.TestTypeFees = TestTypeFees;
        }
        public bool UpdateTestType()
        {
            return TestTypesData.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDesciption, this.TestTypeFees);
        }
        public static DataTable GetAllTestTypes()
        {
            return TestTypesData.GetAllTestTypes();
        }
        public static clsTestTypes GetTestTypeByID(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDesciption = "";
            decimal TestTypeFees = 0;
            if (TestTypesData.GetTestTypeByID(TestTypeID, ref TestTypeTitle,ref TestTypeDesciption, ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeID, TestTypeTitle, TestTypeDesciption, TestTypeFees);
            }
            else
            {
                return null;
            }
        }
    }
}
