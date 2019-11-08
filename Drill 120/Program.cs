using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_120
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Alex";
            person1.lastName = "Nunyabizness";
            Emplyee newEmp = new Emplyee();
            newEmp.firstName = "Sample";
            newEmp.lastName = "Student";
            person1.sayName();
            newEmp.sayName();
            Console.ReadLine();
        }
    }
}
