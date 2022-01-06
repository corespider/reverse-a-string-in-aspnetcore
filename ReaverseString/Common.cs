using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaverseString
{
    public static class Common
    {
        internal static string ReverseString(string input)
        {
            string output = string.Empty;
            char[] chars = input.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                output += chars[i];
            }
            return output;
        }
    }
}
