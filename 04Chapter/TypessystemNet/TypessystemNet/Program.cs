using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypessystemNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Enums ******");

            //Создать тип подрядчика
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine("emp is a {0}.", emp.ToString());
            Console.WriteLine("{0} = 1", emp.ToString(), (int)emp);
            EmpType e2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.ReadLine();
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            //вывести строковое имя и ассоциированое значение используя флаг формата D
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }

        enum EmpType
        {
            Manager = 10,
            Contractor = 20,
            Grunt = 1
        }

        //Использовать перечисления в качестве параметров
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
            }
        }        
    }
}
