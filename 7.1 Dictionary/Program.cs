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
            var text = "foo.htm bar.html baz.htm";
            var pattern = @"\.(htm)\b";
            var replaced = Regex.Replace(text, pattern, ".html");
            Console.WriteLine(replaced);
        }

    }
}
