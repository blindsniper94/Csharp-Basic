using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbList = new List<int>() { 420, 60, 360, 6, 24 };
                Console.WriteLine("Please give me a number");
                int userNumb = Convert.ToInt32(Console.ReadLine());

                foreach (int i in numbList)
                {
                    int quotient = i / userNumb;
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Hmm.. Looks like you tried to divide by zero. According to math that's not possible");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("I need a number like '8' or '62' not 'eight' or 'sixty-two'");
                Console.ReadLine();
            }
        }
    }
}
