using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace ReporterTestConsole
{
    public class Patient
    {
        private string _NhsNumber;
        public string NhsNumber
        {
            get
            {
                return _NhsNumber;
            }
            set
            {
                if (value.isNhsNumber())
                {
                    _NhsNumber = value;
                }
            }

        }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public List<SpecNo> SpecNoList { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                return MyStaticMethods.GetDifferenceInYears(BirthDate, DateTime.Today);
            }
        }


        // Also need helper function to deal with two-digit year data - i.e assume 19__ for birthdate and 20__ for recent events.   Assume positive age etc.  Try to scrape age as corroborating data etc.
    }
}
