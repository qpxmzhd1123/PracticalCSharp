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
            var strings = new[] { "Microsoft Windows", "Windows Server", "Windows", };
            var regex = new Regex(@"(W|w)indows");//행의 시작과 끝 지점을 나타내는 특수 기호가 없으므로 모든 행에 일치함 
            var count = strings.Count(s => regex.IsMatch(s));
            Console.WriteLine("{0}행과 일치", count);
        }

    }
}
