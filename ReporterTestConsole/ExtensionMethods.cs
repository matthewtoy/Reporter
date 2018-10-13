using System;
using System.Text.RegularExpressions;

//Extension methods are static methods that use a "this" in front of the parameter type
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static bool isNhsNumber(this string nhsNumber)
        {
            var pattern = @"/d{10}";
            Match m = Regex.Match(nhsNumber, pattern);
            return m.Success;
        }
    }

    public static class MyStaticMethods
    {
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
    }
}
