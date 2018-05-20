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
            var strings = new[] { "Microsoft Window", "Window Server", "Windows", };
            var regex = new Regex(@"^(W|w)indows$");
            var count = strings.Count(s => regex.IsMatch(s));
            Console.WriteLine("{0}행과 일치", count);
        }

    }
}
