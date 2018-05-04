using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
   class Abbrreviations
    {
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        //생성자
        public Abbrreviations()
        {
            var lines = File.ReadAllLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('=')).ToDictionary(x => x[0], x => x[1]);
        }

        //요소를 추가한다
        public void Add(string abbrr, string korean)
        {
            _dict[abbrr] = korean;
        }

        // 인덱서: 줄임말을 키로 사용한다
        public string this[string abbr]
        {
            get { return _dict.ContainsKey(abbr) ? _dict[abbr] : null; }
        }

        // 한국어로부터 그에 대응하는 줄임말을 구한다
        public string ToAbbreviation(string korean)
        {
            return _dict.FirstOrDefault(x => x.Value == korean).Key;
        }

        // 한국어의 위치를 인수에 넘겨주고 그것이 포함되는 요소(key, value)를 모두 구한다
        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring)
        {
            foreach (var item in _dict)
            {
                if (item.Value.Contains(substring))
                {
                    yield return item;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
