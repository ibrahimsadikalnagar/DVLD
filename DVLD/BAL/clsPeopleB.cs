using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class clsPeopleB
    {
        public static DataTable GetAllContact()
        {
            return clsPeopleD.GetAllContact();
        }
        public static DataTable GetAllCountries()
        {
            return clsPeopleD.GetAllCountries();
        }
            
    }
}
