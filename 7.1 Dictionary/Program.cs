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
            var flowerDict = new Dictionary<string, int>
            {
                {"sumflower", 400 },
                {"pansy", 300 },
                {"tulip", 350 },
                {"rose", 500 },
                {"daglia", 450 },
            };

            Console.WriteLine(flowerDict["sumflower"]);

        }
    }
}
