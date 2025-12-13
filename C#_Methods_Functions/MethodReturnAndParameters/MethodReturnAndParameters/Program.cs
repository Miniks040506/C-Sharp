namespace MethodReturnAndParameters
{
    internal class Program
    {
        //field / global variable
        static int sum;
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = random.Next(1, 101);
            int num2 = random.Next(1, 101);
            sum = SumOfTwoNum(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

            int rd = random.Next(1, 11);
            Console.WriteLine("Before modify: " + rd);
            // The variable need to be initialized before passing it.
            ModifyValue(ref rd);
            Console.WriteLine("After modify: " + rd);

            //The variable does not need to be initialized before passing it.
            int sum2, product;
            Calculate(num1, num2, out sum2, out product);
            Console.WriteLine($"Sum: {sum2}, Product: {product}");

            //The variable must be initialized before passing it.
            int myNumber = 100;
            PrintValue(in myNumber);

            //nested method
            int SubtractsNum(int num1, int num2)
            {
                return num1 - num2; 
            }
            int subNum = SubtractsNum(random.Next(51, 100), random.Next(1, 51));
            Console.WriteLine($"Result is {subNum}");

            Console.ReadKey();
        }

        //return type is that the method after execute will have the value of this type
        //-> the value is the value in return statement
        static int SumOfTwoNum(int num1, int num2)
        {
            int result = num1 + num2;
            //this statement will save the result to the method
            //method is have 'result' value
            //the value in the teturn statement and return type must be same
            return result;
        }

        //parameter scope: ex: num1, result, num2 are local variable -> only use in the code block
        //parameter modifier: ref, in, out

        //ref :The ref keyword allows us to pass a variable by reference rather than by value.
        //This means that any changes made inside the method will reflect in the original variable.
        static void ModifyValue (ref int number) //pass by reference -> like c pointer
        {
            number += 10;
        }


        //The out modifier is similar to ref,
        //but with one key difference: the method must assign a value to the out parameter before returning.
        static void Calculate(int x, int y, out int sum, out int product)
        {
            //must assign
            sum = x + y;
            product = x * y;
        }


        //The in modifier allows us to pass a variable by reference,
        //but it cannot be modified inside the method.
        static void PrintValue(in int number)
        {
            Console.WriteLine(number); // Allowed
            // number += 10; // Not allowed (will cause a compile error)
        }
    }
}
