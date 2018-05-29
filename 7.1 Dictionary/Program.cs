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
            var texts = new[] 
            {
                "Time is money.",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable",
            };
            var pattern = @"\btime\b";
            foreach (var text in texts)
            {
                var mat = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
                if (mat.Success)
                {


                    int index = mat.Index;
                    string str = text;
                    Console.WriteLine($"문자열은 {str} Time의 시작위치는{index}");
                }
            }
            
        }

    }
}
