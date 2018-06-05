using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _7._1_Dictionary
{ 
    class Novelist
    {
        public string Name { get; set; }
        public string KanaName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public IEnumerable<string> Masterpieces { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var element = new XElement("novelist",
                new XElement("name", "찰스 디킨스", new XAttribute("eng", "Charles Dickens")),
                new XElement("birth", "1812-02-07"),
                new XElement("death", "1870-06-09"),
                new XElement("masterpieces",
                    new XElement("title", "올리버 트위스트"),
                    new XElement("title", "크리스마스 캐럴")
                    )
                );
            var xdoc = XDocument.Load("novelists.xml");
            xdoc.Root.AddFirst(element);

            foreach (var xnovelist in xdoc.Root.Elements())
            {
                var xname = xnovelist.Element("name");
                var birth = (DateTime)xnovelist.Element("birth");
                Console.WriteLine("{0} {1}", xname.Value, birth.ToShortDateString());
            }

        }

    }
}
