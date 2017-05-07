using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            StringEquality();
            StringsAreTmmutable();
            FunWithStringsBuilder();
            Console.ReadLine();
        }

        static void FunWithStringsBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("***** Fantastic Games *****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" +"2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible war");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        static void StringsAreTmmutable()
        {
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine();
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 = "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 = "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 = "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");

            Console.WriteLine("All finished.\n\n\n\a");
            Console.WriteLine();

            Console.WriteLine(@"C:\MyApp\bin\Debug");
            string myLongString = @"This is very
                      very
                          very
                              long stribg";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation");
            string s1 = "Progremmin the";
            string s2 = " PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();

        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
    }
}
