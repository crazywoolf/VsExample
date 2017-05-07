using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Imlicit Typing *****");
            DeclareExplicitVars();
            Console.ReadLine();
        }
        static void DeclareExplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }
    }
}
