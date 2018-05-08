using System;
using System.Collections.Generic;
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
            var filePath = @"C:\Example\Greeting.txt";
            var lines = File.ReadLines(filePath, Encoding.Default)
                .Count(s => s.Contains("안녕"));
            Console.WriteLine(lines);
                           

            
            

            
        }

       
        
    }
}
