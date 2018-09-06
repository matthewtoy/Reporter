﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Diagnostics;

namespace ReporterTestConsole
{
    public class NhsNumber
    {
        // This is how to do a property with logic:
        private string _NhsNumberString;
        public string NhsNumberString
        {
            get { return _NhsNumberString; }
            set
            {
                if (IsValid(value))
                {
                    _NhsNumberString = value;
                }
                else
                {
                    throw new InvalidNhsNumberException();
                }
            }
        }
        // static so everything can use it
        public static bool IsValid(string nhsNumber)
        {
            //not implemented
            if (nhsNumber.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Incredibly verbose validation I copied off GitHub from Peter Fisher.  Must replace with my own port from PSL.
        //http://peterfisher.me.uk/projects/nhsnumbervalidator/

        public class NHSNumberValidation
        {
            /// <summary>
            /// The Check Number.  This is the Last number of the NHS Number
            /// </summary>
            private int checkNumber;
            /// <summary>
            /// The NHS Number.  This is a String
            /// </summary>
            private string NHSNumber;
            /// <summary>
            /// A array of multiplers
            /// </summary>
            private int[] multiplers;
            /// <summary>
            /// Is the NHS number valid
            /// </summary>
            private bool isValid;

            /// <summary>
            /// Validates a NHS Number
            /// </summary>
            /// <param name="NHSNumber">String</param>
            public void NHSNumberValdiation(string NHSNumber)
            {
                /// Remove any white space from the NHSNumber
                this.NHSNumber = NHSNumber.Trim();

                /// Create the multipler array
                this.multiplers = new int[9];

                this.multiplers[1] = 10;
                this.multiplers[2] = 9;
                this.multiplers[3] = 8;
                this.multiplers[4] = 7;
                this.multiplers[5] = 6;
                this.multiplers[6] = 5;
                this.multiplers[7] = 4;
                this.multiplers[8] = 3;
                this.multiplers[9] = 2;

                /// Make sure the input is valid
                this.validateInput();
                if (this.isValid)
                {
                    /// Validate the NHSNumber
                    this.validateNHSNumber();
                }
            }
            /// <summary>
            /// Validates the input
            /// Makes sure that the NHSNumber is numeric
            /// </summary>
            protected void validateInput()
            {
                Match match = Regex.Match(this.NHSNumber, "(\\d+)");
                if (match.Success)
                {
                    this.isValid = true;
                }
                else
                {
                    this.isValid = false;
                }
            }
            /// <summary>
            /// Validates the NHSNumber
            /// </summary>
            protected void validateNHSNumber()
            {
                /// The current number
                int currentNumber = 0;
                /// The sum of the multiplers
                int currentSum = 0;
                /// The current Multipler in use
                int currentMultipler = 0;
                /// Get the check number
                string currentString = "";
                string checkDigit = this.NHSNumber.Substring(this.NHSNumber.Length - 1, 1);
                this.checkNumber = Convert.ToInt16(checkDigit);
                /// The remainder after the sum calculations
                int remainder = 0;
                /// The total to be checked against the check number
                int total = 0;

                // Loop over each number in the string and calculate the current sum
                for (int i = 0; i <= 8; i++)
                {
                    currentString = this.NHSNumber.Substring(i, 1);

                    currentNumber = Convert.ToInt16(currentString);
                    currentMultipler = this.multiplers[i + 1];
                    currentSum = currentSum + (currentNumber * currentMultipler);
                }

                /// Calculate the remainder and get the total
                remainder = currentSum % 11;
                total = 11 - remainder;

                /// Now we have our total we can validate it against the check number
                if (total.Equals(11))
                {
                    total = 0;
                }

                if (total.Equals(10))
                {
                    this.isValid = false;
                }

                if (total.Equals(this.checkNumber))
                {
                    this.isValid = true;
                }
                else
                {
                    this.isValid = false;
                }
            }
            /// <summary>
            /// Gets the validation status
            /// </summary>
            /// <returns>Bool True if valid or False otherwise</returns>
            public bool getIsValid()
            {
                return this.isValid;
            }
        }
    }
}




namespace NHSNumberValidation
{
    

}