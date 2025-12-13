using System;
using System.Globalization;

namespace DataTypeAndVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Hello {name}");

            //calculate 2 numbers

            //order of evaluation: left - right

            Console.Write("Enter number 1: ");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Num1 must be numeric and positive. Please try again: ");
            }
            Console.Write("Enter number 2: ");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Num2 must be numeric and positive. Please try again: ");
            }

            //cant' do like this because this statement is do by left to right
            //Console.WriteLine("this is the sub: " + num1 - num2);

            int sum = num1 + num2;
            int sub = num1 - num2;
            Console.WriteLine($"{num1} +  {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {sub}");

            int mul = num1 * num2;
            float div = 0.0f;
            Console.WriteLine($"{num1} x {num2} = {mul}");
            if (num2 == 0)
            {
                Console.WriteLine($"Can't divive {num1} to {num2}");
            }
            else
            {
                div = (float) num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {div}");
            }

            double myDouble = 0.0;
            //double myDouble2 = 0.0;
            Console.Write("Enter double number: ");
            // add CultureInfo.InvariantCulture to change from comma(,) input to dot(.) in decimal number
            while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out myDouble))
            {
                Console.Write("Please enter again: ");
            }
            //while (!double.TryParse(Console.ReadLine(), out myDouble))
            //{
            //    Console.Write("Please enter again: ");
            //}
            //double dSum = myDouble + sum;
            Console.WriteLine($"number {myDouble.ToString(CultureInfo.InvariantCulture)} has type {myDouble.GetType()}");
            //Console.WriteLine($"double sum : {(myDouble + div)} has type {(myDouble + div).GetType()}");
            //using ToString(CultureInfo.InvariantCulture) to change decimal print format from , to .
            Console.WriteLine($"double sum : {Math.Round(myDouble + div, 2).ToString(CultureInfo.InvariantCulture)} has type {(myDouble + div).GetType()}");


            //age
            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0) {
                Console.Write("Age must be numeric and positive. Please try again: ");
            }
            bool check = age >= 18;
            if (check)
            {
                Console.WriteLine("You can go to bar!");
            }
            else
            {
                Console.WriteLine($"Go home now! You can come back after {18 - age} years");
            }
            char charA = 'A';
            Console.WriteLine($"char {charA} in ascii is: {(byte) charA}");

            //Data type: byte, signed/unsigned byte (sbyte, byte)
            //short, signed/unsigned short (ushort/short)
            //int, signed/unsigned int (uint, int)
            //long, signed/unsigned long (ulong, long)
            //float, double, decimal 

            //Reference type: object, string, dynamic

            //User-defined type: classes, structs, enums,...

            //pointer

            //structured type: class, record, struct,
            //interface, enum, delegate

            //Nullable<> : use ? (ex: string?, int?)

            short test = 32700;
            Console.WriteLine($"sum of test with 100 is {test + 100}, test type is {test.GetType()} and it type is {(test + 100).GetType()}");

            //implicit convertion
            int i = 123;
            double d = i;
            Console.WriteLine(d);
            //explicit convertion
            d = 12333333333333333333;
            i = (int) d;
            Console.WriteLine(i);
            string boolVal = "true";
            bool boolValue = Convert.ToBoolean(boolVal);
            if (boolValue)
            {
                Console.WriteLine("That's right!");
            }
            else 
            {
                Console.WriteLine("That's not right!");
            }

            //implicitly variables 
            var myString = "This is my String!";
            Console.WriteLine(myString + " Has type: " + myString.GetType());

            Console.ReadKey();
        }
    }
}
