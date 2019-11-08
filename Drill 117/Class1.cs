using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_117
{
    public class Class1
    {
        public int stuff { get; set; }
        double result;
        
        public static void TwoNumbahs(Class1 NumeroUno, out double result)
        {
            Console.WriteLine("Your number divided by 2 is: ");
            result = NumeroUno.stuff / 2;
            Console.WriteLine(result); 
        }
        public static void TwoNumbahs(Class1 NumeroUno,Class1 NumeroDos, out double result)
        {
            Console.WriteLine("Adding Your numbers and dividing them by 2 is: ");
            result = (NumeroUno.stuff+ NumeroDos.stuff) / 2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    
}
