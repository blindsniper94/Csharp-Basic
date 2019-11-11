using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drill_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeList = new Employee<string>();
            employeeList.things = new List<string>() { "Item1", "Item2", "Item3" };
            
            Employee<int> employeeList2 = new Employee<int>();
            employeeList2.things = new List<int>() { 1, 2, 3 };
            
            //Employee newEmployee = new Employee()
            //{
            //    Id = 1,
            //    firstName = "Sample",
            //    lastName = "Student"
            //};
            //Employee newPerson = new Employee()
            //{
            //    Id = 1,
            //    firstName = "Stevin",
            //    lastName = "Stevinson"
            //};
            //IQuittable quittable = new Employee();

            //newEmployee = newEmployee == newPerson;
            //newEmployee.SayName();
            //quittable.Quit();
            //Console.ReadLine();
            foreach (string i in employeeList.things)
            {
                Console.WriteLine(i);
                
            };
            foreach (int i in employeeList2.things)
            {
                Console.WriteLine(i);
                
            };
            Console.ReadLine();
        }
    }
}
