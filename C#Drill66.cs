using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill66
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Give me a number!");
            string num1 = Console.ReadLine();
            int castNum1 = Convert.ToInt32(num1);
            int total1 = castNum1 + 50;
            Console.WriteLine(num1 + "+ 50 =" + total1);

            Console.WriteLine("Give me another number!");
            string num2 = Console.ReadLine();
            int castNum2 = Convert.ToInt32(num2);
            int total2 = castNum2 + 25;
            Console.WriteLine(num2 + "+ 25 =" + total2);

            Console.WriteLine("Give me another number!");
            string num3 = Console.ReadLine();
            int castNum3 = Convert.ToInt32(num3);
            double total3 = castNum1 / 12.5;
            Console.WriteLine(num3 + "/ 12.5 =" + total3);

            Console.WriteLine("Give me another number!");
            string num4 = Console.ReadLine();
            int castNum4 = Convert.ToInt32(num4);
            bool total4 = castNum4 > 50;
            Console.WriteLine("Is "+ num4 + " greater than 50?" + total4);

            Console.WriteLine("Give me another number!");
            string num5 = Console.ReadLine();
            int castNum5 = Convert.ToInt32(num5);
            int total5 = castNum5 % 7;
            Console.WriteLine("Remainder =" + total5);
            Console.ReadLine();
        }
    }
}
