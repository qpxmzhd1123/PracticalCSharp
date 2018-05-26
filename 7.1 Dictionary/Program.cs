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
            var text = "<p>가나다라마</p><p>바사아자차</p>";
            var pattern = @"<p>(.*?)</p>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}'", m.Groups[1].Value);
            }
        }

    }
}
