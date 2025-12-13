namespace BooleanExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Expressions!");
            //Include: Logical operators, Comparative operators, Combining Expressions

            //Logical operators: AND &&, OR ||, NOT !, XOR (only a or b condition true, orther is false)
            bool isRainy = true;
            bool isUmbrella = true;

            if (isRainy)
            {
                Console.WriteLine("It's raining! Go home!");
            }
            if (isUmbrella)
            {
                Console.WriteLine("Don't worry! We have umbrella!");
            }

            // AND &&
            // OR ||
            // NOT !
            if (isRainy && isUmbrella)
            {
                Console.WriteLine("It's ok!");
            }

            Console.WriteLine("Hello, Welcome to Harsha's Club");
            Console.Write("What's your name: ");
            String name = Console.ReadLine()!;
            Console.WriteLine("Hello " + name);

            //age
            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Age must be numeric and positive");
            }

            if (age < 18)
            {
                Console.Write("Do you go with your parent?(y/n)");
                string isParentStr = Console.ReadLine()!;
                bool isParent = (isParentStr == "y") ? true : false;

                if (age >= 13 && isParent)
                {
                    Console.WriteLine("You can go inside but always go with your parent!");
                } 
                else
                {
                    Console.WriteLine($"Oops, sorry! Comeback here after {18 - age} years, when you are 18!");
                }            
            }
            else if (age <= 60)
            {
                Console.WriteLine("You can go inside! Have a nice night!");
            }
            else
                Console.WriteLine("Too old! Please go home!");
            //can also ignore {} if only one statement in

            Console.ReadKey();
        }
    }
}
