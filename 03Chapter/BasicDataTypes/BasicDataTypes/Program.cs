using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            NewingDataType();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFormString();
            UseDateaAndTimes();
            UseBigInteger();
            Console.ReadLine();
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("IS biggy an even value?: {0}", biggy.IsEven);//Четное?
            Console.WriteLine("Is biggy of two: {0}", biggy.IsPowerOfTwo);//Степень двойки
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);//Значение reallyBig
            Console.WriteLine();
        }

        static void UseDateaAndTimes()
        {
            Console.WriteLine("=>Dates and Times");
            DateTime dt = new DateTime(2011, 10, 17);

            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();
        }

        static void ParseFormString()
        {
            Console.WriteLine("=>Data type Parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=>char type Functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpase('Hello Tehere', 5): {0}", char.IsWhiteSpace("Hello Tehere", 5));
            Console.WriteLine("char.IsWhiteSpase('Hello Tehere', 6): {0}", char.IsWhiteSpace("Hello Tehere", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=>Data type functionality");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double .Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double .PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double .NegatveInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();

        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

        static void NewingDataType()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double ();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();

        }
    }
}
