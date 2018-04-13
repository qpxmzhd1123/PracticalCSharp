using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowerDict = new Dictionary<string, int>();

            // 딕셔너리 키 추가
            flowerDict["violet"] = 600;

            // 딕셔너리 값 출력
            Console.WriteLine(flowerDict["violet"]);

        }
    }
}
