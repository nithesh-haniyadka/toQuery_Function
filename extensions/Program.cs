using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Extensions
{

    public static class StringExtensions
    {
        public static string Left(this string s, int count)
        {
            return s.Substring(0, count);
        }

        public static string Right(this string s, int count)
        {
            return s.Substring(s.Length - count, count);
        }

        public static string Mid(this string s, int index, int count)
        {
            return s.Substring(index, count);
        }

        public static int ToInteger(this string s)
        {
            int integerValue = 0;
            int.TryParse(s, out integerValue);
            return integerValue;
        }

        public static bool IsInteger(this string s)
        {
            Regex regularExpression = new Regex("^-[0-9]+$|^[0-9]+$");
            return regularExpression.Match(s).Success;
        }

    }

}