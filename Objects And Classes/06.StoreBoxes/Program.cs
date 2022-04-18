using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                List<string> str = input.Split().ToList();
                Item item = new Item(str[1], decimal.Parse(str[3]));
                Box box = new Box(str[0],item,int.Parse(str[2]));
                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.PriceForBox).ToList();
            PrintBoxes(boxes);
        }

        private static void PrintBoxes(List<Box> boxes)
        {
            foreach (var item in boxes)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.PriceForBox:f2}");
            }
        }

        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Box
        {
            public Box(string serialNumber, Item item, int quantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = quantity;
                PriceForBox = quantity * item.Price;
            }

            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForBox { get; set; }
        }
    }
}
