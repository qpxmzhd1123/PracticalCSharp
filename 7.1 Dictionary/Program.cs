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
            if (File.Exists(@"C:\Example\Greeting.txt"))
            {
                Console.WriteLine("이미 존재합니다.");
            }
        }



    }
}
