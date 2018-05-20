using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _7._1_Dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new[] { "13000", "-50.6", "0.123", "+180.00", "10.2.5",
            "320-0851", " 123", "$1200", "500원", };
            var regex = new Regex(@"^[-+]?(\d+)(\.\d+)?$");
            foreach (var s in strings)
            {
                var isMatch = regex.IsMatch(s);
                if (isMatch)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
