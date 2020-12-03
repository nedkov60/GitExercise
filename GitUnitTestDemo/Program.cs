using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitUnitTestDemo
{
    class Program
    {
        public static Math math;
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            EnterValues();
            int operation = -1;
            while(operation != 0)
            {
                operation = ChooseOperation();
            }

        }

        static void EnterValues()
        {
            math = new Math();
            Console.Write("Enter value for a: ");
            math.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for b: ");
            math.b = Convert.ToInt32(Console.ReadLine());
        }

        static int ChooseOperation()
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine("5 - Sum digits of a");
            Console.WriteLine("6 - Binary representation of a");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an operation: ");
            var operation = Console.ReadLine();

            switch (operation)
            {
                default:
                    Console.WriteLine("Invalid operation.");
                    return -1;

                case "1":
                    Console.WriteLine("The sum of a and b is: " + math.Add());
                    return 1;
                    

                case "2":
                    Console.WriteLine("a-b is: " + math.Subtract());
                    return 2;

                case "3":
                    Console.WriteLine("a*b is: " + math.Multiply());
                    return 3;

                case "4":
                    Console.WriteLine("a/b is: " + math.Divide());
                    return 4;

                case "5":
                    Console.WriteLine("The sum of digits of a is: " + math.SumDigits());
                    return 5;

                case "6":
                    Console.WriteLine("The binary representation of a is: " + math.Binary());
                    return 6;

                case "0":
                    Console.WriteLine("Goodbye!");
                    return 0;
            }

        }
    }
}
