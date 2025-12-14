namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is Main!!!");
            //Cars audi = new Cars("A3", "Audi", true);
            //Cars bmw = new Cars("I7", "BMW", false);

            //audi._model
            //can't use this because _model is private
            //if _model is public, it only to get but can't modify(set)
            //so in oop, we need to use getter and setter

            //Console.Write("Please enter the Brand name: ");
            // setting brand
            //audi.Brand = Console.ReadLine();
            //getting brand
            //Console.WriteLine("You entered " + audi.Brand);

            //Console.WriteLine("Brand is " + audi.Brand);
            //Console.WriteLine("Brand is " + bmw.Brand);

            //Customer miniks = new Customer("Miniks");
            //Console.WriteLine("Customer name is " + miniks.Name);
            //Customer anna = new Customer("Anna", "MainStreet", "0123456789");
            //Console.WriteLine($"Customer name is {anna.Name}({anna.ContactNumber}) is live at {anna.Address}");

            //Customer myCust = new Customer();
            //Console.Write("Please enter the customer Name: ");
            //myCust.Name = Console.ReadLine()!;
            //Console.WriteLine("Details about customer " + myCust.Name);

            // Rectangle don't have constructor -> default constructor
            //Rectangle rec = new Rectangle();
            //rec.Width = 5;
            //rec.Height = 7;
            //Console.WriteLine("Area of rec is " + rec.Area);

            //rec.Height = 10;
            //Console.WriteLine("Area of rec is " + rec.Area);
            
            //static method call : ClassName.MethodName();
            //static is mean that it belong itself, not any instance/object
           
            //Rectangle.ShapeIntroduce(rec.Width, rec.Height);

            // PART 2
            // -----------------------------------------------------------
            
            Cars car = new Cars();
            Cars car2 = new Cars("A3", "Audi", false);
            Cars car3 = new Cars("I7", "BMW", true);
            Console.WriteLine($"Numbers of cars produced: {Cars.numberOfCars}");

            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer(name: "Miniks", contactNumber: "0987654321");

            //can't access, call, get Password 
            //because it only have set -> Write-only property
            //Console.WriteLine(customer3.Password);
            customer3.Password = "123456";

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            Rectangle rec1 = new Rectangle("Red");
            Rectangle rec2 = new Rectangle("Blue");
            rec1.DisplayDetails();
            rec2.DisplayDetails();

            Console.ReadKey();
        }
    }
}
