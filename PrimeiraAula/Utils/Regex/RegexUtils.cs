using System;
using System.Text.RegularExpressions;

namespace AllObjects
{
    public class RegexUtils
    {
        public static bool isValidString(string input)
        {
            Regex regexString = new Regex(@"^[A-Za-z\s]+$");
            return regexString.IsMatch(input);
        }

        public static bool isValidNumber(string input)
        {
            Regex regexNumero = new Regex("^[0-9]+$");
            return regexNumero.IsMatch(input);
        }
        
        public static bool IsValidChar(string input)
        {
            Regex regexChar = new Regex("^[SN]$");
            return regexChar.IsMatch(input);
        }
    }
}
