using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33.Extensions
{
    public static class Extension
    {
        public static void IsPresent(this string str, string value)
        {
            bool result = str.Contains(value);
            Console.WriteLine(result);
        }
    }
}
