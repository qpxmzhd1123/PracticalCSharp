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
            var di = new DirectoryInfo(@"C:\Example");
            var directories = di.EnumerateFiles("*.txt", SearchOption.AllDirectories);
            foreach (var dicfo in directories)
            {
                Console.WriteLine(dicfo.FullName);
            }
            
            
           

            

        }

    }
}
