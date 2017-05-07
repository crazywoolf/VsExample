using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 8;            
            Add(x, y);
            Console.WriteLine("x = {0}, y = {1}, ans = {2}", x, y, Add(x, y));

            int i;
            string str;
            bool b;
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.WriteLine();

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
            Console.WriteLine();

            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            double[] data = { 4.0, 3.2, 5.7 }; 
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.WriteLine();

            //Необязательные аргументы
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data","CFO");
            //Именованные аргументы
            DisplayFancymessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);

            DisplayFancymessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);
                
            Console.ReadLine();
        }

        static void DisplayFancymessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            //Сохранить исходные цвета с целью их восстановления после вывода сообщения
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            //Установить новые цвета и выывести сообщение
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            //Восстановить предыдущие цвета
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of error: {0}", owner);
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static void FillTheseValues(out int i, out string str, out bool b)
        {
            i = 90;
            str = "Hello world";
            b = true;
        }

        static int Add(int x, int y)
        {
            int ans = 0;
            ans = x + y;
            x = 10000;
            y = 99999;
            return ans;           
        }
    }
}
