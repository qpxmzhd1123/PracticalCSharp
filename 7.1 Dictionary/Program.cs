using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _7._1_Dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var text = "삼겹살-84-58433,상추-95838-488,키보드-840-48484,마우스-3274-38,샴푸-489-58493,치약-38-4839,장갑-48490-483,통조림-3840-203,카레-43-28490,계란-48594-283";

            var pattern = @"\p{IsHangulSyllables}+-[0-9]{2,3}-[0-9]+";

            var matches = Regex.Matches(text, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}'", m.Value);
            }
        }

    }
}
