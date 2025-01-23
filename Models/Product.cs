using System;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {Name}, Quantity: {QuantityInStock}, Price: ₱{Price:F2}";
        }
    }
}