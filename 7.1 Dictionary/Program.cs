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
            string elmstring =
                @"<novelis>
                    <name kana=""0. Henry"">오 헨리</name>
                    <birth>1862-10-11</birth>
                    <death>1910-06-05</death>
                    <masterpieces>
                        <title>현자의 선물</title>
                        <title>마지막 잎새</title>
                    </masterpiece>
                 </novelist>";
            XElement element = XElement.Parse(elmstring);


        }

    }
}
