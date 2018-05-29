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
            var dir = @"C:\Example\Greeting.txt";
            var pattern = @"[Vv]ersion=""v4.0""";
            var lines = File.ReadAllLines(dir);
            foreach (var line in lines)
            {
               var result =  Regex.Replace(line, pattern, @"version=""v5.0""");
                Console.WriteLine(result);
            }
            
        }

    }
}
