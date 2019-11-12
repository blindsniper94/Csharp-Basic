using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_140
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> ListOfEmployees = new List<Employee>();
            
            ListOfEmployees.Add(new Employee { EmployeeId = 2, firstName = "Joe", lastName = "Mama" });
            ListOfEmployees.Add(new Employee { EmployeeId = 7, firstName = "Joe", lastName = "Fadda" });
            ListOfEmployees.Add(new Employee { EmployeeId = 20, firstName = "Luke", lastName = "Skywalker" });
            ListOfEmployees.Add(new Employee { EmployeeId = 17, firstName = "Peter", lastName = "Parker" });
            ListOfEmployees.Add(new Employee { EmployeeId = 1, firstName = "Tony", lastName = "Stark" });
            ListOfEmployees.Add(new Employee { EmployeeId = 69, firstName = "Stan", lastName = "Lee" });
            ListOfEmployees.Add(new Employee { EmployeeId = 3, firstName = "Bruce", lastName = "Banner" });
            ListOfEmployees.Add(new Employee { EmployeeId = 4, firstName = "Steve", lastName = "Rodgers" });
            ListOfEmployees.Add(new Employee { EmployeeId = 5, firstName = "Scott", lastName = "Lang" });
            ListOfEmployees.Add(new Employee { EmployeeId = 8, firstName = "Natasha", lastName = "Romanova" });
            
            List<Employee> duplicates = new List<Employee>();

            
            foreach (Employee employee in ListOfEmployees)
            {
                if (employee.firstName == "Joe")
                {
                    duplicates.Add(employee);
;
                }
            }
            foreach(Employee employee in duplicates)
            {
                Console.WriteLine(employee.firstName);
            }

            List<Employee> newList = ListOfEmployees.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine("These employees have Joe has their name");
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName+" "+ employee.lastName);
            }
            List<Employee> newList2 = ListOfEmployees.Where(x => x.EmployeeId > 5).ToList();
            Console.WriteLine("These employees have a number greater than 5");
            foreach (Employee employee in newList2)
            {
                
                Console.WriteLine(employee.firstName + " " + employee.lastName +" Id: "+ employee.EmployeeId);
                
            }
            Console.ReadLine();
        }
    }
}
