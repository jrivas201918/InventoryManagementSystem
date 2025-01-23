using System;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=====***Inventory Management System***=====\n");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Update Product Quantity");
                Console.WriteLine("4. List Products");
                Console.WriteLine("5. Get Total Inventory Value");
                Console.WriteLine("6. Exit");
                Console.Write("\nSelect an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProductUI(manager);
                            break;
                        case 2:
                            RemoveProductUI(manager);
                            break;
                        case 3:
                            UpdateProductUI(manager);
                            break;
                        case 4:
                            manager.ListProducts();
                            break;
                        case 5:
                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine($"Total Inventory Value: ₱{manager.GetTotalValue():F2}");
                            Console.WriteLine("-------------------------------");
                            break;
                        case 6:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("\n-------------------------------");
                            Console.WriteLine("Invalid option. Please try again.");
                            Console.WriteLine("-------------------------------");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("-------------------------------");
                }
            }
        }

        static void AddProductUI(InventoryManager manager)
        {
            Console.WriteLine("\nAdd New Product");

            int id = 0;
            while (id <= 0)
            {
                Console.Write("Enter Product ID: ");
                if(!int.TryParse(Console.ReadLine(), out id) || id <= 0)
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid ID. Must be a positive integer.");
                    Console.WriteLine("-------------------------------");
                }
            }

            string name = string.Empty;
            while (string.IsNullOrWhiteSpace(name)){
                Console.Write("Enter Product Name: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Please fill up the product name. It cannot be empty.");
                    Console.WriteLine("-------------------------------");
                }
                else
                {
                    name = input;
                }
            }


            int quantity = -1;
            while (quantity < 0)
            {
                Console.Write("Enter Quantity: ");
                if (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                {
                    Console.WriteLine("\n------------------------------");
                    Console.WriteLine("Invalid quantity. Must be a non-negative integer.");
                    Console.WriteLine("-------------------------------");
                }
            }

            decimal price = -1;
            while(true){
                Console.Write("Enter Price: ₱");
                string? input = Console.ReadLine();
                if(decimal.TryParse(input, out price) && price >= 0){
                    break;
                }
                else{
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid price. Must be a non-negative number.");
                    Console.WriteLine("-------------------------------");
                }
            }

            Product product = new Product
            {
                ProductId = id,
                Name = name,
                QuantityInStock = quantity,
                Price = price
            };

            if (manager.AddProduct(product))
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Product added successfully.");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Failed to add product. Product ID may already exist.");
                Console.WriteLine("-------------------------------");
            }
        }

        static void RemoveProductUI(InventoryManager manager)
        {
            int id = 0;
            while(id <= 0){
                Console.Write("\nEnter Product ID to remove: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    if (manager.RemoveProduct(id))
                    {
                        Console.WriteLine("\n-------------------------------");
                        Console.WriteLine("Product removed successfully.");
                        Console.WriteLine("-------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\n-------------------------------");
                        Console.WriteLine("Product not found.");
                        Console.WriteLine("-------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("-------------------------------");
                }
            }
        }
        static void UpdateProductUI(InventoryManager manager)
        {
            int id = 0;
            while (id <= 0)
            {
                Console.Write("\nEnter new product ID: ");
                if (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid ID. Please enter a number.");
                    Console.WriteLine("-------------------------------");
                }
            }
            int quantity = 0;
            while (quantity <= 0)
            {
                Console.Write("\nEnter new quantity: ");
                if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid quantity.");
                    Console.WriteLine("-------------------------------");
                }
            }
            decimal price = -1;
            while(true){
                Console.Write("Enter new price: ₱");
                string? input = Console.ReadLine();
                if(decimal.TryParse(input, out price) && price >= 0){
                    break;
                }
                else{
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine("Invalid price! Please input a non-negative number.");
                    Console.WriteLine("-------------------------------");
                }
            }
            if (manager.UpdateProduct(id, quantity, price))
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Product quantity updated successfully.");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("Failed to update product. Product not found or invalid quantity.");
                Console.WriteLine("-------------------------------");
            }
        }
    }
} 
