using System;
using System.Collections.Generic;

namespace ReporterTestConsole
{

    public enum HospitalSite { York = 0, Scarborough = 1, }
    public enum HistologyCytologyAutopsy { Histology = 0, Cytology = 1, Autopsy = 2}

    // enums can produce case/switch statement dependencies if extended.  Plan default to always error.
    public struct SpecNo
    {
        public string InFull { get; set; }
        public bool IsYork { get; set; }
    }
}

