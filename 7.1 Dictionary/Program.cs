﻿using System;
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
            var novelists = ReadNovelists();
            foreach (var novelist in novelists)
            {
                Console.WriteLine("{0} ({1}-{2}) - {3}", 
                    novelist.Name, novelist.Birth.Year, novelist.Death.Year, 
                    string.Join(", ", novelist.Masterpieces));
            }
        }

        public static IEnumerable<Novelist> ReadNovelists()
        {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                                .Select(x => new Novelist
                                {
                                    Name = (string)x.Element("name"),
                                    KanaName = (string)(x.Element("name").Attribute("kana")),
                                    Birth = (DateTime)x.Element("birth"),
                                    Death = (DateTime)x.Element("death"),
                                    Masterpieces = x.Element("masterpieces")
                                                    .Elements("title").Select(title => title.Value)
                                                    .ToArray()

                                });
            return novelists.ToArray();
        }

    }
}
