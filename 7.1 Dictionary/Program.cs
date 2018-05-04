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
        public DateTime JoinDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Acount> userDict = new Dictionary<string, Acount>()
            {
                ["abcd"] = new Acount() { Id = "abcd", Pw = "abcd", JoinDate = new DateTime(2018, 12, 30) },
                ["efgh"] = new Acount() { Id = "efgh", Pw = "efgh", JoinDate = new DateTime(2018, 11, 23) },
                ["ijklm"] = new Acount() { Id = "ijklm", Pw = "ijklm", JoinDate = new DateTime(2017, 11, 13) },
                ["nopq"] = new Acount() { Id = "nopq", Pw = "nopq", JoinDate = new DateTime(2018, 1, 20) },
                ["rstu"] = new Acount() { Id = "rstu", Pw = "retu", JoinDate = new DateTime(2008, 5, 15) },

            };

            Dictionary<string, Acount> compareDict = userDict.Where(p => DateTime.Compare(p.Value.JoinDate, new DateTime(2018, 1, 1)) == -1)
                .ToDictionary(p => p.Key, p => p.Value);
            foreach (var item in compareDict)
            {
                Console.WriteLine(item.Value.JoinDate);
            }


        }
    }
}
