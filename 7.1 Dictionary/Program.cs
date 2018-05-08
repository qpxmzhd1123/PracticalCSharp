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
            var lines = ReadAllLines(filePath, Encoding.Default);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            

            
        }

        static public string[] ReadAllLines(string filePath, Encoding encoding)
        {
            List<string> list = new List<string>();
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath, encoding))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        list.Add(line);
                        // list에 추가 line을
                    }
                }

            }
            return list.ToArray();
        }
    }
}
