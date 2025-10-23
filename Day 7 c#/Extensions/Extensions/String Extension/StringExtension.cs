using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension.String_Extension
{
    public static class StringExtension
    {
        public static string ToTitleCase(this string input)
        {
            TextInfo textinfo = CultureInfo.CurrentCulture.TextInfo;
            return textinfo.ToTitleCase(input);
        }
    }
}
