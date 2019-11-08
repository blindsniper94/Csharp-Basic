using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_120
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public void sayName()
        {
            string writeName = firstName + " " + lastName;
            Console.WriteLine(writeName);
        }
    }
}
