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

            var xdoc = XDocument.Load("sample.xml");
            var option = xdoc.Root.Element("option");
            Console.WriteLine((bool)option.Attribute("enabled"));
            Console.WriteLine((int)option.Attribute("min"));
            Console.WriteLine((int)option.Attribute("max"));
            Console.WriteLine((int)option.Attribute("step"));
        }

    }
}
