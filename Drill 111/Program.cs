using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_111
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
           
            Console.WriteLine("What is your age?");
            Person1.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            Person1.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is you height?");
            Person1.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Just to make sure this works. Your age is: " + Person1.age + "\nYour weight is: " + Person1.weight + "\nand your height is: " + Person1.height);
            Console.ReadLine();
            Function1(Person1);
            Function2(Person1);
            Function3(Person1);
            Console.ReadLine();
        }
        public static Person Function1(Person Person1)
        {
            int yearBorn = 2019 - Person1.age;
            Console.WriteLine("If you had your birthday already this year, you were born in " + yearBorn);
            return (Person1);
        }
        public static Person Function2(Person Person1)
        {
            int divdedByTwo = Person1.weight / 2;
            Console.WriteLine("\nYour weight divided by 2 is " + divdedByTwo);
            return (Person1);
        }
        public static Person Function3(Person Person1)
        {
            int fiveIncesTaller = Person1.height + 5;
            Console.WriteLine("\nAnd if you were five inches taller you'd be " + fiveIncesTaller + " inches tall");
            return (Person1);
        }
    }
}
