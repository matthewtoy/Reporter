using System;
using System.Collections.Generic;

namespace ReporterTestConsole
{
    public class Report
    {
        public string ReportText { get; set; }
        public DateTime DateCollected { get; set; }
        public DateTime DateReported { get; set; }
        public SpecNo SpecNo { get; set; }
        public string SpecType { get; set; }
        public Patient Patient { get; set; }

       


    }

    public class Patient
    {
        public NhsNumber NhsNumber { get; set; }
        public string FirstName { get; set; }
        public string  Lastname { get; set; }
        public List<SpecNo> SpecNoList { get; set; }

    }

    public struct SpecNo
    {

    }

    public struct NhsNumber
    {

    }
}



