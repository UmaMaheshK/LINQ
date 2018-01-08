using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Select
    {
        static void Main(string[] args)
        {
            SelectExp1();
            SelectExp2();
            SelectExp3();
            SelectExp4();
        }

        static void SelectExp1()
        {
            IList<string> list = new List<string> { "One", "Two", "Three", "Five", "Six", "Seven", "Eight", "Nine" };
            var newlist = list.Select(e => e.ToUpper());
            foreach (var item in newlist)
            {
                Console.Write("{0}\t", item);
            }
        }

        static void SelectExp2()
        {
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }

        static void SelectExp3()
        {
            IList<string> list = new List<string> { "One", "Two", "Three", "Five", "Six", "Seven", "Eight", "Nine" };
            var newlist = list.Select((e, index) => "[" + index + "] = " + e);
            foreach (var item in newlist)
            {
                Console.WriteLine("{0}", item);
            }
        }

        static void SelectExp4()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            var query = fruits.Select((fruit, index) => new { index, str = fruit.Substring(0, index) });

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }
        }
    }
}