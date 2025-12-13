using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_PassByValueAndReference
{
    public struct Currency
    {
        public int Dollars { get; private set; }
        public int Cents { get; private set; }

        // Constructor: Handles normalization (e.g., 1 dollar and 150 cents -> 2 dollars and 50 cents)
        public Currency(int dollars, int cents)
        {
            // Integer division (/) to calculate carry-over dollars
            // Modulo (%) to calculate remaining cents
            Dollars = dollars + cents / 100;
            Cents = cents % 100;
        }

        // Overrides the ToString() method for better currency display formatting
        public override string ToString()
        {
            // :D2 ensures the cents are always two digits (e.g., $1.05 instead of $1.5)
            return $"${Dollars}.{Cents:D2}";
        }

        // ----------------------------------------------------
        // START: Operator Overloading
        // ----------------------------------------------------

        // Overloading the + operator to add two Currency objects
        // The operator must be placed inside the struct/class definition and must be static
        public static Currency operator +(Currency c1, Currency c2)
        {
            int totalCents = c1.Cents + c2.Cents;
            int totalDollars = c1.Dollars + c2.Dollars;

            // Returns a new Currency object, using the Constructor for automatic normalization
            return new Currency(totalDollars, totalCents);
        }

        // Overloading the * operator to multiply a monetary amount by an integer (e.g., multiply by 3)
        public static Currency operator *(Currency c, int multiplier)
        {
            // Convert to total cents for easier multiplication
            long totalCents = (long)c.Dollars * 100 + c.Cents;
            long newTotalCents = totalCents * multiplier;

            // Returns a new multiplied Currency object
            return new Currency((int)(newTotalCents / 100), (int)(newTotalCents % 100));
        }
    }
}
