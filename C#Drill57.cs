using System;

namespace CsharpDrill57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string helpWithAnything = Console.ReadLine();
            bool help = Convert.ToBoolean(helpWithAnything);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feeedback you'd like to provide? Please be specific");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int study = Convert.ToInt32(hoursStudy);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
