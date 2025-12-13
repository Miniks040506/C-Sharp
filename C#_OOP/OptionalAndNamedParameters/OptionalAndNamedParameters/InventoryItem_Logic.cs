using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalAndNamedParameters
{
    public partial class InventoryItem
    {
        // Method to update stock using Optional/Named Parameters
        // 'user' and 'forceUpdate' are Optional Parameters with default values
        public void UpdateStock(int quantityChange, string user = "System", bool forceUpdate = false)
        {
            int oldQty = StockQuantity;
            int newQty = oldQty + quantityChange;

            if (newQty < 0 && !forceUpdate)
            {
                Console.WriteLine($"[ERROR] Cannot set stock to {newQty}. Use forceUpdate: true to override.");
                return;
            }

            StockQuantity = newQty;

            // Call the Partial Method
            OnStockUpdated(oldQty, newQty, user);

            if (IsLowStock)
            {
                Console.WriteLine($"[ALERT] {Name} is running low on stock ({newQty} remaining).");
            }
        }

        // --- Partial Method Implementation ---
        // Uses the Inner Class to record the update
        partial void OnStockUpdated(int oldQty, int newQty, string user)
        {
            string action = $"User '{user}' changed stock from {oldQty} to {newQty}. Change: {(newQty - oldQty)}.";
            this.auditLog.AddEntry(action); // Uses the Inner Class object
        }
    }
}
