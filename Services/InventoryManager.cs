using System;
using System.Collections.Generic;
using System.Linq;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    public class InventoryManager
    {
        private List<Product> inventory;

        public InventoryManager()
        {
            inventory = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            // Validate constraints
            if (product.ProductId <= 0 || 
                product.Price < 0 || 
                product.QuantityInStock < 0)
            {
                return false;
            }

            // Check if product ID already exists
            if (inventory.Any(p => p.ProductId == product.ProductId))
            {
                return false;
            }

            inventory.Add(product);
            return true;
        }

        public bool RemoveProduct(int productId)
        {
            var product = inventory.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                inventory.Remove(product);
                return true;
            }
            return false;
        }

        public bool UpdateProduct(int productId, int newQuantity, decimal newPrice)
        {
            if (newQuantity < 0 || newPrice < 0)
            {
                return false;
            }
            
            var product = inventory.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                product.QuantityInStock = newQuantity;
                product.Price = newPrice;
                return true;
            }
            return false;
        }

        public void ListProducts()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Current Inventory:");
            Console.WriteLine("------------------------------------------");
            foreach (var product in inventory)
            {
                Console.WriteLine(product);
            }
        }

        public decimal GetTotalValue()
        {
            return inventory.Sum(p => p.QuantityInStock * p.Price);
        }
    }
} 
