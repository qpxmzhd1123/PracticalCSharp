using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    class MonthDay
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public MonthDay(int month, int day)
        {
            this.Month = month;
            this.Day = day;
        }

        public override bool Equals(object obj)
        {
            var day = obj as MonthDay;
            return day != null &&
                   Day == day.Day &&
                   Month == day.Month;
        }

        public override int GetHashCode()
        {
            var hashCode = 93243338;
            hashCode = hashCode * -1521134295 + Day.GetHashCode();
            hashCode = hashCode * -1521134295 + Month.GetHashCode();
            return hashCode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<MonthDay, string> dict = new Dictionary<MonthDay, string>
            {
                [new MonthDay(6, 6)] = "현충일",
                [new MonthDay(8, 15)] = "광복절",
                [new MonthDay(10, 3)] = "개천절",

            };
            var md = new MonthDay(8, 15);
            var s = dict[md];
            Console.WriteLine(s);
        }
    }
}
