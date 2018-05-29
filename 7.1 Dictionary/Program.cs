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
        public static bool IsPhoneNumber(string str)
        {
            string text = str;
            var pattern = @"^(0[7-9]0)-\d{4}-\d{4}";
            var match = Regex.Match(text, pattern);
            return match.Success;
        }
        static void Main(string[] args)
        {
            
            bool result = IsPhoneNumber("070-1241-5678");
            Console.WriteLine(result);
           
        }

    }
}
