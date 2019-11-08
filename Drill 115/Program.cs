using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_115
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 num1 = new Class1();
            Class1 num2 = new Class1();
            string optional = "";
            
            Console.WriteLine("Please give me a number.");
            num1.numbah = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine("Please give me another number.");
            optional = Console.ReadLine();
            if (string.IsNullOrEmpty(optional))
            {
                
                Class1.OptionalParam(num1);
            }
            else
            {
                
                num2.numbah = Convert.ToInt32(optional);
                Class1.OptionalParam(num1, num2);
            }
            

                      
            
        }
    }
}
