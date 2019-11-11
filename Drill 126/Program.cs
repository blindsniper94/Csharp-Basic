using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_126
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            IQuittable quittable = new Employee();


            newEmployee.SayName();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
