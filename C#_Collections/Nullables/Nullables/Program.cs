namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //non-nullable type
            //int age = null;
            //to make the type to be null -> type?
            int? age = null;

            int myAge = 20;

            //use has value to check if variable is has value or null
            if (age.HasValue)
            {
                //can't use : age + myAge
                //-> can't convert int? to int
                int sum = age.Value + myAge;
                Console.WriteLine("Age is: " + age.Value);
            }
            else
            {
                //int sum = age.Value + myAge;
                Console.WriteLine("Age is not specified");
            }

                Console.ReadKey();
        }
    }
}
