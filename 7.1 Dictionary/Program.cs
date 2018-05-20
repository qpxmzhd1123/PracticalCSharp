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
            var text = "using System.Text.ReularExpressions;";
            bool isMatch = Regex.IsMatch(text, @"^using");
            if (isMatch)
            {
                Console.WriteLine("'using'으로 시작됩니다.");
            }
            else
            {
                Console.WriteLine("'using'으로 시작되지 않습니다.");
            }
        }

    }
}
