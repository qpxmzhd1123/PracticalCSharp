using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    class Acount
    {
        public string Id { get; set; }
        public string Pw { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("aa");
            set.Add("aa");
            set.Add("aa");
            set.Add("aa");
            set.Add("aa");
            set.Add("aa");
            set.Add("aab");



            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
