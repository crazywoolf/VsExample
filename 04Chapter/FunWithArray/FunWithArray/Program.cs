using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Array *****");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> System array Functionality");
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mersy" };
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-> Clear out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }


        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array");
            //Зубчатый многомерный массив
            int[][] myJagArray = new int[5][];
            //Создать зубчатый массив
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            //Вывод
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array");
            //Прямоугольный многомерный массив.
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            //Заполнить массив (6 * 6)
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;

            //Вывод массива (6 * 6)
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(myMatrix[i,j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects");
            //массив объектов может содержать все что угодно
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = "One";
            myObjects[3] = new DateTime(1969, 3, 24);
            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();               
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            //a - на самом деле int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            //b - на самом деле bool[]
            var b = new[] { true, false, false };
            Console.WriteLine("b is b: {0}", b.ToString());

            //c - на самом деле string[]
            var c = new[] { "One", "two", "three" };
            Console.WriteLine("c is c: {0}", c.ToString());
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            //Синтаксис инициализации массива с использованием ключевого слова new.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            //Синтаксис инициализации массива без использования ключевого слова new.
            bool[] boolArray = { false, true, true  };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Синтаксис инициализации массива с использованием ключевого слова new и размера.
            int[] intArray = new int[4] { 23, 20, 4, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            //Создать массив string, содержащий 3 элемента с индексами 0, 1, 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            
            string[] booksOnDotNet = new string[100];
            foreach (int i in myInts)
                Console.WriteLine(i); ;
            Console.WriteLine();

        }  
        
              
    }
}
