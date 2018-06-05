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

            var xdoc = XDocument.Load("novelists.xml");
            var element = xdoc.Root.Elements()
                                   .Single(x => x.Element("name").Value == "마크 트웨인")
                                   .Element("masterpieces");
            var newElement = new XElement("masterpieces",
                new XElement("title", "도금시대"),
                new XElement("title", "아서 왕 궁정의 코네티컷 양키")
                );
            
            element.ReplaceWith(newElement);

        }

    }
}
