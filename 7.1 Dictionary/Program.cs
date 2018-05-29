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
            var text = "기러기 국제경제국 다들잠들다 너구리 시집간집시 토마토 건조할조건";
            var pattern = @"\b(\w)(\w)(\w)\2\1\b";
            var lines = Regex.Matches(text, pattern);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

    }
}
