using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_126
{
    public class Employee:Person,IQuittable
    {
        
        public override void SayName()
        {
            Console.WriteLine("First and Last Names");
            base.SayName();
            Console.ReadLine();
        }
        public void Quit()
        {
            Console.WriteLine("Woohoo It works!");
        }
        public static Employee operator ==(Employee newEmployee, Employee newPerson)
        {

            bool IdMatch = newEmployee.Id.Equals(newPerson.Id);
            Console.WriteLine("Do these Id's match?" + IdMatch);
            return newEmployee;
            
        }
        public static Employee operator !=(Employee newEmployee, Employee newPerson)
        {

            bool IdMatch = newEmployee.Id.Equals(newPerson.Id);
            Console.WriteLine("Do these Id's match?" + IdMatch);
            return newEmployee;
        }

    }
}
