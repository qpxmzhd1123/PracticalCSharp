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
            var lines = new[] { "Seoul", "New Delhi", "Bangkok", "London", "Paris", };
            var filePath = @"C:\Example\Cities.txt";
            File.WriteAllLines(filePath, lines);
            
                
            
        }

       
        
    }
}
