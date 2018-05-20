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
            var text = "C#에는 《값형》과 《참조형》이라는 두 가지의 형이 존재합니다.";
            var matches = Regex.Matches(text, @"《([^《 》]+)》");
            foreach (Match match in matches)
            {
                // <《값형》> <《참조형》>
                Console.WriteLine("<{0}>", match.Value);
            }
        }

    }
}
