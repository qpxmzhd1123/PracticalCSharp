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
            var text = "1234567890123456";
            var pattern = @"(\d{4})(\d{4})(\d{4})(\d{4})";
            var replaced = Regex.Replace(text, pattern, "$1-$2-$3-$4");
            Console.WriteLine(replaced);
        }

    }
}
