using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalAndNamedParameters
{
    public partial class InventoryItem
    {
        // Expression Bodied Method: Returns a full summary string
        public string GetStatusSummary() =>
            $"ID: {ItemID} | Name: {Name} | Price: {UnitPrice:C} | Qty: {StockQuantity} | Low Stock: {IsLowStock}";

        // Expression Bodied Method: Shorthand method to print status to the console
        public void PrintStatus() => Console.WriteLine(GetStatusSummary());

        public void DisplayAuditLog()
        {
            Console.WriteLine("\n--- Displaying Audit Log via Public Method ---");
            this.auditLog.PrintAll();
        }
    }
}
