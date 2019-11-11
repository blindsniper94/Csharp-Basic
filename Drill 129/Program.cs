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
                Id = 1,
                firstName = "Sample",               
                lastName = "Student"
            };
            Employee newPerson = new Employee()
            {
                Id = 1,
                firstName = "Stevin",
                lastName = "Stevinson"
            };
            IQuittable quittable = new Employee();

            newEmployee = newEmployee == newPerson;
            newEmployee.SayName();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
