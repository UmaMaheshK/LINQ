using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        enum days { Sunday, Monday, Tuesday, Wednesday, Friday, saturday }
        public enum Color { Red = 1, Blue = 2, Green = 3 }
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N}", Int64.MaxValue);
            Console.WriteLine("{0:N1}", Int64.MaxValue);
        }

        static void EnumFormat()
        {
            //Console.WriteLine("enum days {0} ",Enum.GetNames(days)[0].ToString());

        }
    }
}
