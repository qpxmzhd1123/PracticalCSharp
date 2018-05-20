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
            var text = "kor, KOR, Kor";
            var mc = Regex.Matches(text, @"\bkor\b", RegexOptions.IgnoreCase);
            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
            }
        }

    }
}
