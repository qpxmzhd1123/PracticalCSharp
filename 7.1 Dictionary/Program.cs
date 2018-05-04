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

        public override bool Equals(object obj)
        {
            var acount = obj as Acount;
            return acount != null &&
                   Id == acount.Id;
                  
        }

        public override int GetHashCode()
        {
            var hashCode = -676140440;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            return hashCode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Acount> set = new HashSet<Acount>()
            {
                new Acount{Id = "abcd", Pw = "abcd"},
                new Acount{Id = "abcd", Pw = "abcd"},
                new Acount{Id = "abcd2", Pw = "abcd"},
                new Acount{Id = "abcd3", Pw = "abcd"},
                new Acount{Id = "abcd4", Pw = "abcd"},
                new Acount{Id = "abcd5", Pw = "abcd"},
            };



            foreach (var item in set)
            {
                Console.WriteLine($"ID는 {item.Id} PW는 {item.Pw}");
            }
        }
    }
}
