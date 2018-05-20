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
            var text = "Regex 클래스에 있는 Match 메서드를 사용합니다.";
            Match match = Regex.Match(text, @"\p{IsHangulSyllables}+");
            if (match.Success)
            {
                Console.WriteLine("{0} {1}", match.Index, match.Value);
            }
        }

    }
}
