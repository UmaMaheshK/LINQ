using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
    class Order
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public string PaymentMode { get; set; }
    }

    class InnerJoin
    {
        static void Main(string[] args)
        {
            IList<Book> bookList = new List<Book>
                                {
                                    new Book{BookId=1, BookName="DevCurry.com Developer Tips"},
                                    new Book{BookId=2, BookName=".NET and COM for Newbies"},
                                    new Book{BookId=3, BookName="51 jQuery ASP.NET Recipes"},
                                    new Book{BookId=4, BookName="Motivational Gurus"},
                                    new Book{BookId=5, BookName="Spiritual Gurus"}
                                };

            IList<Order> bookOrders = new List<Order>
                        {
                            new Order{OrderId=1, BookId=1, PaymentMode="Cheque"},
                            new Order{OrderId=2, BookId=5, PaymentMode="Credit"},
                            new Order{OrderId=3, BookId=1, PaymentMode="Cash"},
                            new Order{OrderId=4, BookId=3, PaymentMode="Cheque"},
                            new Order{OrderId=5, BookId=5, PaymentMode="Cheque"},
                            new Order{OrderId=6, BookId=4, PaymentMode="Cash"}
                        };
            Console.WriteLine("Linq Query");
            //Linq Query
            //deffered execution.
            var linqQuery = from b in bookList
                            join o in bookOrders on b.BookId equals o.BookId
                            select new { b.BookId, b.BookName, o.PaymentMode };
            //Immediatetly execution
            Stopwatch st = new Stopwatch();
            st.Start();
            Parallel.ForEach(linqQuery, (result) => { Console.WriteLine("{0,2}{1,30}{2,10}", result.BookId, result.BookName, result.PaymentMode); });
            st.Stop();
            Console.WriteLine("Linq Lambda Expression Total Execution Time := {0}", st.ElapsedMilliseconds / 10);

            Console.WriteLine("Linq Lambda Expression");
            st.Start();
            var linqLamdba = bookList.Join(bookOrders, b => b.BookId, o => o.BookId, (b, o) => new { b.BookId, b.BookName, o.PaymentMode });
            linqLamdba.ToList().ForEach(result => { Console.WriteLine("{0,2}{1,30}{2,10}", result.BookId, result.BookName, result.PaymentMode); });
            st.Stop();
            Console.WriteLine("Total Execution Time := {0}", st.ElapsedMilliseconds / 10);
        }
    }
}
