using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("What is person 1's hourly rate?");
            string hRate1 = Console.ReadLine();
            int hourlyRate1 = Convert.ToInt32(hRate1);
            
            Console.WriteLine("How many hours did person 1 work?");
            string hWork1 = Console.ReadLine();
            int hourWorked1 = Convert.ToInt32(hWork1);
            int pay1 = hourWorked1 * hourlyRate1;

            Console.WriteLine("What is person 2's hourly rate?");
            string hRate2 = Console.ReadLine();
            int hourlyRate2 = Convert.ToInt32(hRate2);

            Console.WriteLine("How many hours did person 2 work?");
            string hWork2 = Console.ReadLine();
            int hourWorked2 = Convert.ToInt32(hWork2);
            int pay2 = hourWorked2 * hourlyRate2;

            bool chkPay = pay1 > pay2;
            Console.WriteLine("Person 1's Pay is " + pay1);
            Console.ReadLine();
            Console.WriteLine("Person 2's Pay is " + pay2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2? " + chkPay);
            Console.ReadLine();
        }
    }
}
