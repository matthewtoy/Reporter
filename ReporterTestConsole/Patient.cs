using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporterTestConsole
{
    public class Patient
    {
        public NhsNumber NhsNumber { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public List<SpecNo> SpecNoList { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                return GetDifferenceInYears(BirthDate, DateTime.Today);
            }
        }

        public static int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            // Copy-pasted from forum.  How tedious that DateTime doesn't do this.
            //Excel documentation says "COMPLETE calendar years in between dates"
            int years = endDate.Year - startDate.Year;

            if (startDate.Month == endDate.Month &&// if the start month and the end month are the same
                endDate.Day < startDate.Day// AND the end day is less than the start day
                || endDate.Month < startDate.Month)// OR if the end month is less than the start month
            {
                years--;
            }
            return years;
        }
        // Also need helper function to deal with two-digit year data - i.e assume 19__ for birthdate and 20__ for recent events.   Assume positive age etc.  Try to scrape age as corroborating data etc.
    }
}
