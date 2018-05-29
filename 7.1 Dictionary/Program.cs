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
            var fai = @"C:\Example\Greeting.txt";
            var pattern = @"(\w{3,})|(\d{3,})";
            string[] lines = File.ReadAllLines(fai);
            foreach (var line in lines)
            {
                var a = Regex.Matches(line, pattern);
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
