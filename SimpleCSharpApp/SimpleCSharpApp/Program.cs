using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            
            //Обработать любые входные аргументы с помощью foreach
            foreach (string arg in args) 
                Console.WriteLine("Arg: {0}", arg);
            //Вспомогательный метод внутри класса Program
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;
        }
        static void ShowEnvironmentDetails()
        {
            //Вывести информацию о дисковых устройствах
            //данной машины и другие интересные детали
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
    }
}
