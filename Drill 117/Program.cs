using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_117
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Class1 NumberoUno = new Class1();
            Class1 NumberoDos = new Class1();
            string optional = "";
            Console.WriteLine("Please give me a number");
            NumberoUno.stuff = Convert.ToInt32(Console.ReadLine());
            Class1.TwoNumbahs(NumberoUno, out double result);
            Console.ReadLine();
            Console.WriteLine("Please give me another number!");
            optional = Console.ReadLine();
            if (string.IsNullOrEmpty(optional))
            {
                Class1.TwoNumbahs(NumberoUno,out result);
            }
            else
            {
                NumberoDos.stuff = Convert.ToInt32(optional);
                Class1.TwoNumbahs(NumberoUno, NumberoDos, out result);
            }
            Console.WriteLine(result);

        }
    }
}
