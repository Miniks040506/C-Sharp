namespace PredicateAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squaringNum = Squaring(10);
            Console.WriteLine($"The result of 10 x 10 is {squaringNum}");
        
            //in C#, a delegate is like a pointer or a reference to a method
            //It allows to pass methods as arguments to other methods,
            //store them in variables, and call them later.
            //--> code -> flexible and able to handle different bahaviors that aren't predetermined.

            List<int> list = new List<int>() { 10, 5, 15, 3, 9, 25, 18, 20, 12, 7, 13};

            //List<int> higherEqual = list.FindAll(x => x > 12);

            // Predicate is a delegate that accept one input T
            // and return boolean(bool) type.
            // public delegate bool Predicate <in T> (T obj) {}
            Predicate<int> isHigherEqual = x => x > 12;
            List<int> higherEqual = list.FindAll(isHigherEqual);
            Console.WriteLine("Result: ");
            foreach (int i in higherEqual)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        //lambda expression consists of 2 parts:
        //1. Parameters 
        //2. Expression or statemant block

        //parameters are written on the left side of '=>'
        //the expression or action to perform is on the right side

        //example:
        //x => x * x -> take an x as input and return x * x 

        //static int Squaring(int num)
        //{
        //    return num * num; 
        //}

        static int Squaring(int num) => num * num;
    }
}
