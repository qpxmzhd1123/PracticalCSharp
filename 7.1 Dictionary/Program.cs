using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            IsSumEven(out bool b,out int x, out int y, out int sum);
            Console.WriteLine(b);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(sum);
        }

        static void IsSumEven(out bool b, out int x, out int y, out int sum)
        {
            x = 5;
            y = 3;
            sum = x + y;
            b = sum % 2 == 0;

        }
    }
}
