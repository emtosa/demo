using System;
using System.Text.RegularExpressions;

namespace regexsample
{
    public static class StringChecker
    {
        ////public static bool CheckStringForExtraQuotes(string str)
        ////{
        ////    var rgx = new Regex(@"\w");
        ////    if (rgx.IsMatch(str))
        ////    {
        ////        return true;
        ////    }
        ////    return false;
        ////}
        public static bool CheckString(string str, string pattern)
        {
            var rgx = new Regex(pattern);
            return rgx.IsMatch(str);
        }
    }
}
