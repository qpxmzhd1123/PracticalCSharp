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
    class Program
    {
        static void Main(string[] args)
        {

            var xdoc = XDocument.Load("novelists.xml");
            var xnovelists = xdoc.Root.Elements()
                .OrderBy(x => (x.Element("name").Attribute("eng").Value));
            foreach (var xnovelist in xnovelists)
            {
                var xname = xnovelist.Element("name");
                var birth = (DateTime)xnovelist.Element("birth");
                Console.WriteLine("{0} {1}", xname.Value, birth.ToShortDateString());
            }
        }
    
    }
}
