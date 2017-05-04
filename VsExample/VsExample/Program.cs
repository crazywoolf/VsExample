using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {

            }

            ConfigureCUI();

            Console.ReadLine();
        }

        private static void ConfigureCUI()
        {
            //Настройка консольного интерфейса (CUI).
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************");
            Console.WriteLine("**** Welcome to My Rocking App *****");
            Console.WriteLine("************************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
