using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_103
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> heroNames = new List<string>() { "Spider-man", "Iron man", "Captian America", "Black Panther", "Ant-man", "Thor", "Nick Fury", "Doctor Strange"};
            List<string> SearchList = new List<string>();
            string[] names = new string[6];
            names[0] = "Dennis";
            names[1] = "Mac";
            names[2] = "Charlie";
            names[3] = "Dee";
            names[4] = "Frank";
            Console.WriteLine("Please give me a name.");
            names[5] = Console.ReadLine();
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            for(int j = 0; j <= 10; j++)
            {
                Console.WriteLine("This iteration will be less than or equal to 10 "+ j);
            }
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("This iteration will be less than 5 " + k);
            }
            Console.WriteLine("Search for...");
            string userSearch = Console.ReadLine();
            for (int i = 0; i < heroNames.Count; i++)
            {
                if (heroNames[i].Contains(userSearch))
                {
                    Console.WriteLine(heroNames[i] + " at index " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry I couldn't find any " + userSearch + " in my DB");
                }
            }
            List<string> fruits = new List<string>() {"Banana", "Apple", "Orange", "Kiwi", "Apple" };

            //var query = fruits.GroupBy(x => x)
            //    .Where(g => g.Count() > 1)
            //    .Select(y => y.Key)
            //    .toList();
            List<string> duplicateFruit = new List<string>() { };
            
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
                if (duplicateFruit.Contains(i)){
                    Console.WriteLine(i + " is a duplicate");
                    Console.ReadLine();
                }
                else
                {
                    duplicateFruit.Add(i);
                }
            }
            
            Console.ReadLine();
        }
    }
}
