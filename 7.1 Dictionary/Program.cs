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
            var text = "private List<string> results = new List<stirng>();";
            var matches = Regex.Matches(text, @"List<\w+>");
            foreach (Match match in matches)
            {
                Console.WriteLine("Index={0}, Length={1}, Value={2}", match.Index, match.Length, match.Value);
            }
        }

    }
}
