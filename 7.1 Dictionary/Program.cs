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
            var dir = @"C:\Example\HTML.txt";
            var pattern = @"<(/?)([A-Z][0-9A-Z]*)(.*)>";
            var lines = File.ReadAllLines(dir, Encoding.Default);
            foreach (var line in lines)
            {
               var result = Regex.Replace(line, pattern, m => { return $"<{m.Groups[1].Value}{m.Groups[2].Value.ToLower()}{m.Groups[3].Value}>"; });
                Console.WriteLine(result);
            }
        }

    }
}
