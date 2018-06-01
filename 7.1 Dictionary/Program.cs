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
            foreach (var xnovelist in xdoc.Root.Elements())
            {
                var xname = xnovelist.Element("name");
                XAttribute xeng = xname.Attribute("eng");
                Console.WriteLine("{0} {1}", xname.Value, xeng?.Value);
            }
           
        }
    
    }
}
