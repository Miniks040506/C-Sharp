namespace MethodVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program pg = new Program();
            //pg.MyMethod();
            //non-static method can't can directly into static method
            MyMethod();
            //MyMethod();
            Console.WriteLine("This is outside of my method!");
            
            Console.Write("Enter your name: ");
            string name =Console.ReadLine()!;
            //calling the method
            GetName(name);

            Console.Write("How old are you: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Age must be numeric and positive!");
                Console.Write("Please again again: ");
            }
            GetName(name, age);

            Console.ReadKey();
        }

        //Method is a block of code that use for reuseable target
        //method format
        //accessModifier returnType MethodName(Parameters) {
        //      codes .......
        //}

        //void method: a method that not return anything
        //void MyMethod()
        static void MyMethod()
        {
            Console.WriteLine("This is the first C# method!");
            Console.WriteLine("Hi, my name is Miniks!");
        }

        static void GetName(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        static void GetName(string name, int age)
        {
            Console.WriteLine($"{name} is {age} years old!");
        }
    }
}
