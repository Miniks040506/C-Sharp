namespace MethosInClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars myAudi = new Cars("A3", "Audi", false);
            myAudi.Drive();
            //Console.WriteLine();

            Cars myBmw = new Cars("I7", "BMW", true);
            myBmw.Drive();

            Customer myCust = new Customer();
            Customer anna = new Customer("Anna");

            myCust.SetDetails("Miniks", "Main Street 2", "0123456789");
            Console.WriteLine($"My customer is: {myCust.Name}({myCust.ContactNumber}) " +
                $"and he lives in {myCust.Address}.");
            Console.WriteLine($"My customer is: {anna.Name}({anna.ContactNumber}) " +
                $"and he lives in {anna.Address}.");

            Customer customer = new Customer();
            customer.SetDetails("Denis", "Second Road");

            Customer cust3 = new Customer("Herry");
            Console.WriteLine("Contact number of Herry is: " + cust3.ContactNumber);

            //Naming parameter -> using method parameter name and : value
            Console.WriteLine(AddNum(10, 15));
            Console.WriteLine(AddNum(num1: 15, num2: 20));
            

            Console.ReadKey();
        }

        static int AddNum(int num1, int num2) => num1 + num2;
    }
}
