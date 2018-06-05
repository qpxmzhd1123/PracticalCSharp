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
            var xtitles = xdoc.Root.Descendants("title");
            foreach (var xtitle in xtitles)
            {
                Console.WriteLine(xtitle.Value);
            }
        }
    
    }
}
