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
            var text = "1024바이트,8바이트 문자,바이트,킬로바이트";
            var pattern = @"(\d+)바이트";
            var replaced = Regex.Replace(text, pattern, "$1byte");
            Console.WriteLine(replaced);
        }

    }
}
