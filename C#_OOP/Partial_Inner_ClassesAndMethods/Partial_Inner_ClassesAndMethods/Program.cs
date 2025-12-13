namespace Partial_Inner_ClassesAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Starting Combined Demo (Partial + Inner + Expression Bodied) ---");

            // The compiler treats the two partial files as a single class
            Product p = new Product
            {
                Name = "Smart Watch V2",
                BasePrice = 150.00m
            };

            // Uses Expression Bodied Method/Property
            Console.WriteLine(p.GetDescription());

            Console.WriteLine("\n--- Price Change 1 (Triggers Partial Method and Inner Class) ---");
            p.UpdatePrice(165.00m);

            Console.WriteLine("\n--- Price Change 2 ---");
            p.UpdatePrice(160.00m);

            // Calls a method from the Product_Logic.cs file, which uses the Inner Class log
            p.PrintPriceHistory();

            // Demonstrates direct access to the Inner Class (since it is public)
            Console.WriteLine("\n--- Direct Access to Inner Class ---");
            Product.AuditLog externalLog = new Product.AuditLog();

            Console.ReadKey();
        }
    }
}
