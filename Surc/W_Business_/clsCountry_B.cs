using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_;

namespace W_Business_
{
    public class clsCountry_B
    {
        public int ID { set; get; }
        public string CountryName { set; get; }

        public clsCountry_B()
        {
            this.ID = -1;
            this.CountryName = "";

        }

        private clsCountry_B(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }

        /// ////////////////////////////////////////////////////////////////

        public static clsCountry_B Find(int ID)
        {
            string CountryName = "";

            if (clsCountry_D.GetCountryInfoByID(ID, ref CountryName))

                return new clsCountry_B(ID, CountryName);
            else
                return null;

        }

        /// ////////////////////////////////////////////////////////////////

        public static clsCountry_B Find(string CountryName)
        {

            int ID = -1;

            if (clsCountry_D.GetCountryInfoByName(CountryName, ref ID))

                return new clsCountry_B(ID, CountryName);
            else
                return null;

        }

        /// ////////////////////////////////////////////////////////////////

        public static DataTable GetAllCountries()
        {
            return clsCountry_D.GetAllCountries();

        }

        /// ////////////////////////////////////////////////////////////////

    }
}
