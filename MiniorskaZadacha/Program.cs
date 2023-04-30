using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniorskaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string String = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            while (String != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!(resources.ContainsKey(String))) //Какво прави този if: Ако изразът в скобите върне true, тогава на dictionary resources с key String се присвоява стойност 0.
                {
                    resources[String] = 0;
                }
                resources[String] = resources[String] + quantity;
                String = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key}  --> {item.Value}");
            }
        }
    }
}
