namespace OperatorOverloading_PassByValueAndReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- 1. Operator Overloading Demonstration ---

            Console.WriteLine("--- 1. Operator Overloading Demo (Addition and Multiplication) ---");

            Currency itemPrice = new Currency(15, 50); // $15.50
            Currency tax = new Currency(1, 75);       // $1.75

            Console.WriteLine($"Item Price: {itemPrice}");
            Console.WriteLine($"Tax: {tax}");

            // Uses the overloaded + operator
            Currency total = itemPrice + tax;
            Console.WriteLine($"Total (Price + Tax): {total}"); // $17.25

            // Uses the overloaded * operator (e.g., buying 3 items)
            int quantity = 3;
            Currency bulkOrder = total * quantity;
            Console.WriteLine($"Total for {quantity} items: {bulkOrder}"); // $51.75

            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("--- 2. Pass by Reference ('ref') Demo ---");

            // --- 2. Pass by Reference ('ref') Demonstration ---

            Currency originalPrice = new Currency(100, 0); // $100.00

            Console.WriteLine($"Original Price before discount: {originalPrice}");

            // Call the ApplyDiscount method and pass 'originalPrice' using 'ref'
            Calculator.ApplyDiscount(ref originalPrice, 20); // 20% discount

            // The 'originalPrice' variable has been modified because 'ref' was used
            Console.WriteLine($"Price after 20% Discount: {originalPrice}"); // $80.00

            // If 'ref' were not used when calling the method, the value would still be $100.00

            Console.ReadKey();
        }
    }
}
