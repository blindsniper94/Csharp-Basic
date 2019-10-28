using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package you're shipping?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else if (packageWeight < 50)
            {
                Console.WriteLine("What is the height of the package you're shipping?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the width of the package you're shipping?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of the package you're shipping?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int packageCaculation = packageHeight * packageWidth * packageLength;
                double packageCost = ((packageHeight + packageWidth + packageLength) * packageWeight)/ 100.00;
                if (packageCaculation > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("Your estimated total comes to : $" + packageCost);
                    Console.ReadLine();
                }
            }
            
        }
    }
}
