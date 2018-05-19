using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var filePath = @"C:\Example\Greeting.txt";
            var lines = File.ReadLines(filePath, Encoding.UTF8);
            
            foreach (var line in lines)
            {
                if (line.StartsWith("b"))
                {
                    break;
                }
               // Console.WriteLine(line);
            }

            sw.Stop();

            double second = sw.Elapsed.TotalSeconds;
            Console.WriteLine(second);

        }

    }
}
