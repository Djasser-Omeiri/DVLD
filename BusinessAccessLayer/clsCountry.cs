using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsCountry
    {
        public static DataTable GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }
        public static string GetCountryName(int CountryID)
        {
            return CountryData.GetNationalityByNationID(CountryID);
        }
    }
}
