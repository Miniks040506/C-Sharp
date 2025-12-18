namespace ObjectList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product {Name = "Apple", Price = 0.99},
                new Product {Name = "Banana", Price = 0.79},
                new Product {Name = "cherry", Price = 2.19}
            };

            products.Add(new Product
            {
                Name = "Berries",
                Price = 2.99
            });

            Console.WriteLine("Available Products: ");
            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            // .Where keyword
            // -> filters a sequence of values based on a predicate
            // like .filter(Predicate test) in java
            //products.Where(p => p.Price < 1.0);
            // .ToList -> convert collect of sequence obj to list 
            List<Product> cheapProducts = products
                .Where(p => p.Price <= 1.0).ToList();

            Console.WriteLine("Cheap Products: ");
            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }


            Console.ReadKey();
        }
    }
}
