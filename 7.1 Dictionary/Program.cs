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
            var text = "Word, Excel ,PowerPoint , Outlook,OneNote";
            var pattern = @"\s*,\s*";
            string[] substrings = Regex.Split(text, pattern);
            foreach (var match in substrings)
            {
                Console.WriteLine("'{0}'", match);
            }
        }

    }
}
