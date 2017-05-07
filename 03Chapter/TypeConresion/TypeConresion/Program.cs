using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConresion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            short numb1 = 10000, numb2 = 10000;
            short answer = (short)Add(numb1, numb2);

            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            ProcessBytes();
            DeclareExplicitVars();
            Console.ReadLine();
        }

        static void DeclareExplicitVars()
        {
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                unchecked
                {
                    byte sum = checked((byte)Add(b1, b2));
                    Console.WriteLine("sum = {0}", sum);
                }
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
