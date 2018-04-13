using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Dictionary
{
    class Employee
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Employee(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var flowerDict = new Dictionary<string, int>
            {

                // 딕셔너리 키 추가
                ["sumflower"] = 400,
                ["pansy"] = 300,
                ["rulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };
            var employeeDict = new Dictionary<int, Employee>
            {
                [100] = new Employee(100, "이몽룡"),
                [112] = new Employee(112, "변학도"),
                [125] = new Employee(125, "성춘향"),

            };
            var result = flowerDict.Remove("pansy2");

            Console.WriteLine(result);
            

        }
    }
}
