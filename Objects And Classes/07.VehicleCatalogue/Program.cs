using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> list = input.Split("/").ToList();
                if (list[0]=="Car")
                {
                    Car car = new Car(list[1],list[2],list[3]);
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(list[1], list[2], list[3]);
                    catalog.Trucks.Add(truck);
                }
            }
            PrintCatalog(catalog);
        }

        private static void PrintCatalog(Catalog catalog)
        {
            if (catalog.Cars.Count!=0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count!=0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }

        public class Truck
        {
            public Truck(string brand, string model, string weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }

        public class Car
        {
            public Car(string brand, string model,string horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
    }
}
