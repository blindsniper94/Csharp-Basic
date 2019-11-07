using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_113
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOfNumbers Numero1 = new ClassOfNumbers();
            ClassOfNumbers Numero2 = new ClassOfNumbers();
            Console.WriteLine("Please give me a number");
            Numero1.NumeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give me another number");
            Numero2.NumeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You choose numbers: "+ Numero1.NumeroUno +" and "+ Numero2.NumeroUno);
            Console.ReadLine();
            ClassOfNumbers.TwoNumbersToTango(Numero1: Numero1, Numero2: Numero2);
            Console.WriteLine(Numero2.NumeroUno);
            Console.ReadLine();




        }
    }
}
