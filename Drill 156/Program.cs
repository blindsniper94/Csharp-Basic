using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime =  DateTime.Now;
            Console.WriteLine(currentDateTime);
            Console.WriteLine("Please give me a number");
            Double userNum = Convert.ToDouble(Console.ReadLine());
            DateTime difference = currentDateTime.AddHours(userNum);
            Console.WriteLine("In {0} hours it will be {1}", userNum, difference);
            Console.ReadLine();
        }
    }
}
