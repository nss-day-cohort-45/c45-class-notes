using System;
using System.Collections.Generic;

namespace AntiqueShop
{
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        private decimal _minPrice;
        private decimal _maxPrice;

        private List<AntiqueItem> _purchaseList = new List<AntiqueItem>();
        private List<AntiqueItem> _wishList = new List<AntiqueItem>();

        public Customer(string firstName, string lastName,
            decimal minPrice, decimal maxPrice)
        {
            FirstName = firstName;
            LastName = lastName;
            _minPrice = minPrice;
            _maxPrice = maxPrice;
        }

        public void ExamineItem(AntiqueItem item)
        {
            if (item.Price >= _minPrice && item.Price < _maxPrice)
            {
                _purchaseList.Add(item);
            }
            else if (item.Price >= _maxPrice)
            {
                _wishList.Add(item);
            }
        }

        public void PrintReport()
        {
            Console.WriteLine();
            Console.WriteLine($"Purchase/Wish List Report for {FullName} (Min: ${_minPrice} | Max: ${_maxPrice})");

            Console.WriteLine("Antiques to Purchase");
            foreach (AntiqueItem item in _purchaseList)
            {
                Console.WriteLine($"  {item.Name} (${item.Price})");
            }

            Console.WriteLine("Antiques on Wishlist");
            foreach (AntiqueItem item in _wishList)
            {
                Console.WriteLine($"  {item.Name} (${item.Price})");
            }

            Console.WriteLine();
        }
    }
}