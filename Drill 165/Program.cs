using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if(userAge < 0)
                {
                    throw new FormatException();
                }
                int yearBorn = 2019 - userAge;
                Console.WriteLine("If you had your Birthday already this year you were born in {0}", yearBorn);
                Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Uhh... You entered a number less than zero. So either you're from the future, or you're lying to me. And I hate liars.");
                Console.ReadLine();
                return;
            }
        }
    }
}
