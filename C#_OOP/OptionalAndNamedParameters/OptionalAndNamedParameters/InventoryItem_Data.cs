using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalAndNamedParameters
{
    public partial class InventoryItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; } 

        // Inner Class object used for detailed logging
        private LogManager auditLog = new LogManager();

        // Expression Bodied Property: Read-only check for low stock
        public bool IsLowStock => StockQuantity < 10;

        // Partial Method Declaration (implementation in Logic.cs)
        partial void OnStockUpdated(int oldQty, int newQty, string user);

        // --- Inner Class (Nested Class) ---
        /// <summary>
        /// Inner Class: Only meaningful within the scope of InventoryItem.
        /// </summary>
        public class LogManager
        {
            private List<string> entries = new List<string>();

            // Expression Bodied Constructor
            public LogManager() => Console.WriteLine("[LogManager] Audit system initialized.");

            public void AddEntry(string action)
            {
                entries.Add($"[{DateTime.Now:HH:mm:ss}] {action}");
            }

            public void PrintAll()
            {
                Console.WriteLine("\n--- FULL AUDIT LOG ---");
                // Expression Bodied Method used inside a lambda expression
                entries.ForEach(e => Console.WriteLine(e));
            }
        }
    }
}
