using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number between 0 and 3");
            int indexNum = Convert.ToInt32(Console.ReadLine());

            string[] strArray = { "Blue", "Green", "Yellow", "Red" };

            int[] numArray = { 1, 420, 69, 172};

            List<string> strList = new List<string>();
            strList.Add("I hope you have a mediocre day!");
            strList.Add("I hope you find a lucky penny!");
            strList.Add("I hope you get a 50% raise!");
            strList.Add("I hope you find what you have lost.");

            if (indexNum < 4 && indexNum >= 0)
            {
                Console.WriteLine("You have choosen the color " + strArray[indexNum]);
                Console.ReadLine();
                Console.WriteLine("Choose another number between 0 and 3");
                int indexNum2 = Convert.ToInt32(Console.ReadLine());


                if (indexNum2 < 4 && indexNum2 >= 0)
                {
                    Console.WriteLine("The number at that index is " + numArray[indexNum2]);
                    Console.ReadLine();
                    Console.WriteLine("I hope you like choosing numbers between 0 and 3. Please enter a number between 0 and 3");
                    int indexNum3 = Convert.ToInt32(Console.ReadLine());
                    if (indexNum3 < 4 && indexNum3 >= 0)
                    {
                        Console.WriteLine(strList[indexNum3]);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Im sorry, I needed a number between 0 and 3");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Im sorry, I needed a number between 0 and 3");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Im sorry, I needed a number between 0 and 3");
                Console.ReadLine();
            }
        }
    }
}
