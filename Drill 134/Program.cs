using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_134
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Days day = new Days();
                Console.WriteLine("What day of the week is it? In case you forgot The days are:");
                foreach (string DayName in Enum.GetNames(typeof(DaysoftheWeek)))
                {
                    Console.WriteLine(DayName);

                }
                string UserDay = Console.ReadLine();
                Enum.Parse(typeof(DaysoftheWeek), UserDay);


                Console.WriteLine("So it's " + UserDay);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Sorry I didn't understand that. Please try again");
                Console.ReadLine();
            }
        }
    }
    
}
