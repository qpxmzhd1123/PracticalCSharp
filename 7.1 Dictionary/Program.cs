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
            string xmlstirng = 
                @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                <novelists>
                    <novelist>
                        <name eng=""Agatha Christie"">아가사 크리스티<\name>
                        <birth>1890-09-15</birth>
                        <death>1976-01-12</death>
                        <masterpieces>
                            <title>그리고 아무도 없었다</title>
                            <title>오리엔트 특급 살인</title>
                        </masterpieces>
                    </novelist>
                </novelists>";
            var xdoc = XDocument.Parse(xmlstirng);


        }

    }
}
