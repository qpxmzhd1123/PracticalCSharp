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

            var option = new XElement("option");
            option.SetElementValue("enabled", true);
            option.SetElementValue("min", 0);
            option.SetElementValue("max", 100);
            option.SetElementValue("step", 10);
            var root = new XElement("settings", option);
            root.Save("sample.xml");

        }

    }
}
