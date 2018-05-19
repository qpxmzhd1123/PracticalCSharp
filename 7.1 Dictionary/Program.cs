using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Program Files\Microsoft Office\Office16\EXCEL.EXE";
            var directoryName = Path.GetDirectoryName(path);
            var fileName = Path.GetFileName(path);
            var extension = Path.GetExtension(path);
            var filenameWithoutExtension = Path.GetFileNameWithoutExtension(path);
            var pathRoot = Path.GetPathRoot(path);

            Console.WriteLine("DirectoryName : {0}", directoryName);
            Console.WriteLine("FileName : {0}", fileName);
            Console.WriteLine("Extension : {0}", extension);
            Console.WriteLine("FilenameWithoutExtension : {0}", filenameWithoutExtension);
            Console.WriteLine("PathRoot : {0}", pathRoot);
        }

    }
}
