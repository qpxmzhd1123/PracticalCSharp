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
            var filePath = @"C:\Example\고향의봄.txt";
            using (var writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine("나의 살던 고향은");
                writer.WriteLine("꽃피는 산골");
                writer.WriteLine("복숭아꽃 살구꽃");
                writer.WriteLine("아기 진달래");
            }
                            
                
            
        }

       
        
    }
}
