using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Inner_ClassesAndMethods
{
    // PART 2: Must also be declared 'partial' and match the exact class name
    public partial class Product
    {
        // --- Expression Bodied Method ---
        // Returns the product description (using properties from Product_Data.cs)
        public string GetDescription() =>
            $"Product: {Name}, Base Price: {BasePrice:C}, After Tax: {PriceAfterTax:C}";

        // Main business method
        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice != BasePrice)
            {
                decimal oldPrice = BasePrice;
                BasePrice = newPrice;

                // Call the Partial Method (compiler will ensure implementation exists if needed)
                LogPriceUpdate(oldPrice, newPrice);
            }
        }

        // --- Partial Method Implementation ---
        // Provides the body for the method declared in Product_Data.cs
        partial void LogPriceUpdate(decimal oldPrice, decimal newPrice)
        {
            // Uses the Inner Class object 'log' which was instantiated in Product_Data.cs
            this.log.AddEntry(oldPrice, newPrice);
        }

        public void PrintPriceHistory()
        {
            Console.WriteLine("\n--- Audit Log from Product_Logic ---");
            // Calls a method of the Inner Class
            this.log.PrintLog();
        }
    }
}
