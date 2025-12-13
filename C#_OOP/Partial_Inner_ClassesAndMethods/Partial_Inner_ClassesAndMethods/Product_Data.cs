using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Inner_ClassesAndMethods
{
    // PART 1: The class must be declared 'partial'
    public partial class Product
    {
        // Shared constant
        private const decimal TaxRate = 0.08m; // 8% tax

        public string Name { get; set; }
        public decimal BasePrice { get; set; }

        // --- Expression Bodied Property ---
        // Concise definition for a read-only property calculation
        public decimal PriceAfterTax => BasePrice * (1 + TaxRate);

        // Instantiate an object of the Inner Class
        private AuditLog log = new AuditLog();

        // Declare a Partial Method (implementation will be in Product_Logic.cs)
        partial void LogPriceUpdate(decimal oldPrice, decimal newPrice);

        // --- Inner Class (Nested Class) ---
        /// <summary>
        /// Inner Class: Only relevant within the scope of the Product class.
        /// It encapsulates the price logging mechanism. 
        /// </summary>
        public class AuditLog
        {
            // List to store history records
            private List<(decimal oldPrice, decimal newPrice, DateTime timestamp)> history =
                new List<(decimal, decimal, DateTime)>();

            // Expression Bodied Constructor
            public AuditLog() => Console.WriteLine("[Inner Class] AuditLog initialized.");

            public void AddEntry(decimal oldPrice, decimal newPrice)
            {
                history.Add((oldPrice, newPrice, DateTime.Now));
                Console.WriteLine($"[Inner Class] Logged price change: {oldPrice:C} -> {newPrice:C}");
            }

            public void PrintLog()
            {
                foreach (var item in history)
                {
                    Console.WriteLine($"- At {item.timestamp:HH:mm:ss}: Price updated from {item.oldPrice:C} to {item.newPrice:C}");
                }
            }
        }
    }
}
