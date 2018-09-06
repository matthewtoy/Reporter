using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporterTestConsole
{
    public class Report
    {
        // report text is probably a list of Clinical, Macro, Micro with sublists Spec A, B, C etc.
        private string ReportText { get; set; }
        public DateTime DateCollected { get; set; }
        public DateTime DateReported { get; set; }
        public SpecNo SpecNo { get; set; }
        public string SpecType { get; set; }
        public Patient Patient { get; set; }

        public string GetReport()
        {
            Console.WriteLine("report is output");
            return "Some lovely report";
        }


    }
}
