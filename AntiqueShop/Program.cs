using System;

namespace AntiqueShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Antique Shoppe");
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

            Customer alice = 
                new Customer("Alice", "Jones", 10m, 100m);

            alice.ExamineItem(chair);
            alice.ExamineItem(vase);
            alice.ExamineItem(painting);
        }
    }
}