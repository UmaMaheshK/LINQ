using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }

    class ToLookUp
    {
        static void Main(string[] args)
        {
            //SimpleLookup();
            AdvaceLookupLookup();
            Console.Read();
        }

        public static List<string> GetStringList()
        {
            List<string> list = new List<string>();
            list.Add("Lajapathy");
            list.Add("Sathiya");
            list.Add("Parthiban");
            list.Add("AnandBabu");
            list.Add("Sangita");
            list.Add("Lakshmi");
            return list;
        }

        public static void SimpleLookup()
        {
            IList<string> list = GetStringList();

            //Sets KeyValue pair based on the string length.
            ILookup<int, string> lookup = list.ToLookup(i => i.Length);
            Console.WriteLine();
            Console.WriteLine("String length=7");

            //Iterates only string length having 7.
            foreach (string temp in lookup[7])
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("String length=9");

            //Iterates only string length having 9.
            foreach (string temp in lookup[9])
            {
                Console.WriteLine(temp);
            }
        }
        public static List<Employee> EmployeeList()
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { ID = 100, Name = "Lajapathy", CompanyName = "FE" });
            emp.Add(new Employee { ID = 200, Name = "Parthiban", CompanyName = "FE" });
            emp.Add(new Employee { ID = 400, Name = "Sathiya", CompanyName = "FE" });
            emp.Add(new Employee { ID = 300, Name = "Anand Babu", CompanyName = "FE" });
            emp.Add(new Employee { ID = 300, Name = "Naveen", CompanyName = "HCL" });
            return emp;
        }
        public static void AdvaceLookupLookup()
        {
            //Employee collection
            List<Employee> empList = EmployeeList();
            Console.WriteLine("Here Key based on ID");

            //Creating KeyValue pair based on the ID. we can get items based on the ID.
            ILookup<int, Employee> lookList = empList.ToLookup(id => id.ID);

            //Displaying who having the ID=100.
            foreach (Employee temp in lookList[100])
            {
                Console.WriteLine(temp.Name);
            }
            Console.WriteLine("Here Key based on CompanyName");

            //Creating KeyValue pair based on the CompanyName. 
            //we can get items based on the CompanyName.
            ILookup<string, Employee> lookList2 = empList.ToLookup(id => id.CompanyName);

            //Displaying who are employed in CompanyName=FE.
            foreach (Employee temp in lookList2["FE"])
            {
                Console.WriteLine(temp.Name);
            }
        }
    }
}
