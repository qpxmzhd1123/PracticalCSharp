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
            var text = "Regex 클래스를 사용해서 문자ㅕㅇㄹ을 처리하는 방법을 설명합니다.";
            bool isMatch = Regex.IsMatch(text, @"합니다.$");
            if (isMatch)
            {
                Console.WriteLine("'합니다.'로 끝납니다.");
            }
            else
            {
                Console.WriteLine("'합니다.'로 끝나지 않습니다.");
            }
        }

    }
}
