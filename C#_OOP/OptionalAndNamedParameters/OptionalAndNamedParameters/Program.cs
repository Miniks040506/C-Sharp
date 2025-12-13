namespace OptionalAndNamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- INVENTORY MANAGEMENT SYSTEM ---");

            // 1. Object Initialization (Triggers the Inner Class constructor)
            InventoryItem product = new InventoryItem
            {
                ItemID = 501,
                Name = "Wireless Mouse",
                UnitPrice = 25.99m,
                StockQuantity = 15 // Initial stock
            };

            // Uses Expression Bodied Method to print initial status
            product.PrintStatus();

            // --- Demo Optional and Named Parameters ---

            Console.WriteLine("\n--- DEMO ACTIONS ---");

            // 2. Action 1: Decrease by 6 (Uses the default Optional Parameter: user="System")
            Console.WriteLine("\nAction 1: Standard Sale");
            product.UpdateStock(-6);
            product.PrintStatus();

            // 3. Action 2: Increase by 10 (Uses Named Parameters to specify 'user')
            Console.WriteLine("\nAction 2: Incoming Shipment");
            product.UpdateStock(quantityChange: 10, user: "Warehouse Staff");
            product.PrintStatus();

            // 4. Action 3: Attempt over-sale (Denied because 'forceUpdate' is false by default)
            Console.WriteLine("\nAction 3: Attempt Over-Sale");
            //product.UpdateStock(-30, true); -> wrong
            //product.UpdateStock(-30, "Manager"); -> true
            //optional param is only ignore the sequense param from the firse optional param
            //the declare is (qty,option user,option force) -> only accept if call (1 / 1 2 / 1 2 3)
            //if call (1 3) like (qty, force) -> wrong -> system try to call user by force value
            product.UpdateStock(-30, user: "Manager");
            product.PrintStatus();

            // 5. Action 4: Forced over-sale using Named Parameter 'forceUpdate'
            Console.WriteLine("\nAction 4: Forced Stock Adjustment");
            product.UpdateStock(user: "Admin", quantityChange: -30, forceUpdate: true);
            product.PrintStatus();

            // 6. Print full audit log (using the Inner Class)
            product.DisplayAuditLog();

            Console.ReadKey();
        }
    }
}
