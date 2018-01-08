using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Zip
    {
        static void Main(string[] args)
        {
            ZipExp1();
            ZipExp2();
            ZipExp3();
        }

        static void ZipExp1()
        {
            string[] words = { "One", "Two", "Three", "Five", "Six", "Seven", "Eight", "Nine" };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = words.Zip(numbers, (w, n) => n + " " + w);
            foreach (var item in result)
                Console.WriteLine(item);
        }

        static void ZipExp2()
        {
            var left = new[] { 1, 2, 3 };
            var right = new[] { 10, 20, 30 };
            var products = left.Zip(right, (m, n) => m * n);
            foreach (var s in products)
                Console.Write(s + " ");
        }

        static void ZipExp3()
        {
            var letters = new string[] { "A", "B", "C", "D", "E" };
            var numbers = new int[] { 1, 2, 3 };
            var q = letters.Zip(numbers, (l, n) => l + n.ToString());
            foreach (var s in q)
                Console.Write(s + " ");//A1 B2 C3
        }
    }
}
