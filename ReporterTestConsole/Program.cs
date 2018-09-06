using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporterTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            var report = new Report();
            report.SpecType = "Hysterectomy, malignant";
            Console.WriteLine("Report specimen type is: " + report.SpecType);
        }


    }

}
