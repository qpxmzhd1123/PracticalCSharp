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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var regex = new Regex(@"List<\w+>");
            for (int i = 0; i < 1000000; i++)
            {
                var text = "private List<string> results = new List<string>();";
                bool isMatch = Regex.IsMatch(text,@"List<\w+>");
                //bool isMatch = regex.IsMatch(text);
            }
            stopwatch.Stop();
            double result = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine(result);
            
        }

    }
}
