using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Infrastructure
{
    public static class Formatting
    {
        public static string UpperCaseFirstLetters(this string text)
        {
            var upperCaseTextInfo = new CultureInfo("en-US", false).TextInfo;
            return upperCaseTextInfo.ToTitleCase(text.ToLower());
        }

        public static string RemoveWhiteSpaces(this string text)
        {
            return text.Replace(" ", "");
        }
    }
}
