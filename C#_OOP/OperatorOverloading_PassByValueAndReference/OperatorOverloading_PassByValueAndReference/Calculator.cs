using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_PassByValueAndReference
{
    public class Calculator
    {
        // Method using 'ref' to directly change the original 'amount' variable
        public static void ApplyDiscount(ref Currency amount, int percentDiscount)
        {
            Console.WriteLine($"  -> Applying a {percentDiscount}% discount...");

            // Convert the entire amount to cents for easier calculation
            long totalCents = (long)amount.Dollars * 100 + amount.Cents;

            // Apply the discount
            double discountFactor = (double)(100 - percentDiscount) / 100.0;
            long newTotalCents = (long)(totalCents * discountFactor);

            // Create a new Currency struct and assign it back to the 'amount' parameter.
            // Thanks to the 'ref' keyword, this assignment will change the value of the original variable in Main().
            amount = new Currency((int)(newTotalCents / 100), (int)(newTotalCents % 100));
        }
    }
}
