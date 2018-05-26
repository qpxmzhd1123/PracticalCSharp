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
            var text = "도로를 지나가는 차들이 뛰-뛰뛰하고 경적을 울리면 반대쪽 차들이 빵빵하고 울렸다.";
            var pattern = @"(\w)-\1";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}'", m.Value);
            }
        }

    }
}
