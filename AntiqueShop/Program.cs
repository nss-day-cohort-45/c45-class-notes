using System;
using System.Collections.Generic;

namespace AntiqueShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Antique Shoppe");
            List<AntiqueItem> items = GetAntiqueItems();
            List<Customer> customers = GetCustomers();

            foreach (Customer cust in customers)
            {
                foreach (AntiqueItem item in items)
                {
                    cust.ExamineItem(item);
                }
            }

            foreach (Customer cust in customers)
            {
                cust.PrintReport();
            }
        }

        static List<AntiqueItem> GetAntiqueItems()
        {
            // NOTE: This code shows multiple ways to set properties and to add items to a list
            // In a real app you SHOULD BE CONSISTENT in
            AntiqueItem chair = new AntiqueItem()
            {
                Name = "An old chair",
                Price = 45.50m,
            };

            AntiqueItem vase = new AntiqueItem()
            {
                Name = "A priceless vase",
                Price = 1.00m
            };

            AntiqueItem painting = new AntiqueItem();
            painting.Name = "Washington on a Horse";
            painting.Price = 100.99m;

            List<AntiqueItem> items = new List<AntiqueItem>() { chair, vase, painting };
            items.Add(new AntiqueItem()
            {
                Name = "Snuff box",
                Price = 70.00m,
            });
            items.Add(new AntiqueItem()
            {
                Name = "Some old Diamond",
                Price = 1_000_000m,
            });

            return items;
        }

        static List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer("Alice", "Jones", 10m, 100m),
                new Customer("Roy", "Roybison", 100m, 900m),
                new Customer("Lillian", "Vaughn", 0m, 50m),
                new Customer("Maria", "Maria", 5_000m, 2_000_000m),
            };
        }
    }
}