using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_q1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Employees = new List<string>();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            for (; ; )
            {
                String s = Console.ReadLine();
                if (s == "") break;
                else Employees.Add(s);
            }
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            String emp = Console.ReadLine();
            Console.WriteLine(emp+" is in position {0} for promotion.", Employees.IndexOf(emp) + 1);
            Console.ReadKey();

        }
    }
}
