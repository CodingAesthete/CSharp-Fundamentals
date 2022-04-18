using System;
using System.Collections.Generic;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string type = command[0];
                string model = command[1];
                string color = command[2];
                int horsepower = int.Parse(command[3]);
                if (type == "car")
                {
                    Cars car = new Cars();
                    car.Type = type;
                    car.Model = model;
                    car.Color = color;
                    car.Horsepower = horsepower;
                    catalog.cars.Add(car);
                }
                else if (type == "truck")
                {
                    Trucks truck = new Trucks();
                    truck.Type = type;
                    truck.Model = model;
                    truck.Color = color;
                    truck.Horsepower = horsepower;
                    catalog.trucks.Add(truck);
                }
            }
            string line;
            while ((line = Console.ReadLine()) != "Close the Catalogue")
            {
                for (int i = 0; i < catalog.cars.Count; i++)
                {
                    if (catalog.cars[i].Model.Contains(line))
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {catalog.cars[i].Model}");
                        Console.WriteLine($"Color: {catalog.cars[i].Color}");
                        Console.WriteLine($"Horsepower: {catalog.cars[i].Horsepower}");
                    }
                }
                for (int i = 0; i < catalog.trucks.Count; i++)
                {
                    if (catalog.trucks[i].Model.Contains(line))
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {catalog.trucks[i].Model}");
                        Console.WriteLine($"Color: {catalog.trucks[i].Color}");
                        Console.WriteLine($"Horsepower: {catalog.trucks[i].Horsepower}");
                    }
                }
            }
            int carsCount = 0;
            int trucksCount = 0;
            double carsPower = 0;
            double trucksPower = 0;
            for (int i = 0; i < catalog.cars.Count; i++)
            {
                carsCount++;
                carsPower += catalog.cars[i].Horsepower;
            }
            for (int i = 0; i < catalog.trucks.Count; i++)
            {
                trucksCount++;
                trucksPower += catalog.trucks[i].Horsepower;
            }
            if (catalog.cars.Count == 0)
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {(carsPower / carsCount):f2}.");
            }
            if (catalog.trucks.Count == 0)
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {(trucksPower / trucksCount):f2}.");
            }
        }
        public class Cars
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }
        public class Trucks
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }
        public class Catalog
        {
            public List<Cars> cars { get; set; }
            public List<Trucks> trucks { get; set; }
            public Catalog()
            {
                cars = new List<Cars>();
                trucks = new List<Trucks>();
            }
        }
    }
}
