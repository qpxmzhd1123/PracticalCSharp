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
            var text = "private List<string> results = new List<string>();";
            var matches = Regex.Matches(text, @"\b[a-z]+\b")
                               .Cast<Match>()
                               .OrderBy(x => x.Length);
            foreach (Match match in matches)
            {
                Console.WriteLine("Index={0}, Length={1}, value={2}", match.Index, match.Length, match.Value);
            }
        }

    }
}
