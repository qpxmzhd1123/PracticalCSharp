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
            var text = "C# 공부를 쪼끔씩 진행해보자.";
            var pattern = @"쪼금씩|쪼끔씩|쬐끔씩";
            var replaced = Regex.Replace(text, pattern, "조금씩");
            Console.WriteLine(replaced);
        }

    }
}
