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
            var text = "<person><name>김삿갓</name><age>22</age></person>";
            var pattern = @"<(.+?)>";
            var matches = Regex.Match(text, pattern);
            Console.WriteLine(matches.Groups[1].Value);
            //foreach (Match m in matches)
            //{
            //    Console.WriteLine("'{0}'", m.Groups[1].Value);
            //}
        }

    }
}
