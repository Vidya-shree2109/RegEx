using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCodeValidation
{
    public class Validation
    {
        public const string PINCODE_REGEX = "^[0-9]{6}$";
        public void Validate(string pinCode)
        {
            if (Regex.IsMatch(pinCode, PINCODE_REGEX))
            {
                Console.WriteLine("PinCode Matches");
            }
            else
                Console.WriteLine("Verify Pincode Again !");
        }
    }
}
