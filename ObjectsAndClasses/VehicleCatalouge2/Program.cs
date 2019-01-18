using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalouge2
{
    public class Car
    {
        public Car(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
    public class Truck
    {
        public Truck(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
    public class Catalouge
    {
        public Catalouge()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
        
            string input = Console.ReadLine();
            var catalouge = new Catalouge();

            while (input != "End")
            {
                string[] tockens = input.Split();
                string type = tockens[0].ToLower();
                string model = tockens[1];
                string color = tockens[2];
                double horsePower = double.Parse(tockens[3]);

                if (type == "car")
                {
                    var car = new Car(model, color, horsePower);
                    catalouge.Cars.Add(car);
                }
                else
                {
                    var truck = new Truck(model, color, horsePower);
                    catalouge.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            string dataExtract = Console.ReadLine();

            while (dataExtract != "Close the Catalogue")
            {
                foreach (var car in catalouge.Cars)
                {
                    if (car.Model == dataExtract)
                    {
                        System.Console.WriteLine("Type: Car");
                        System.Console.WriteLine($"Model: {car.Model}");
                        System.Console.WriteLine($"Color: {car.Color}");
                        System.Console.WriteLine($"Horsepower: {car.HorsePower}");
                        break;
                    }
                }

                foreach (var truck in catalouge.Trucks)
                {
                    if (truck.Model == dataExtract)
                    {
                        System.Console.WriteLine("Type: Truck");
                        System.Console.WriteLine($"Model: {truck.Model}");
                        System.Console.WriteLine($"Color: {truck.Color}");
                        System.Console.WriteLine($"Horsepower: {truck.HorsePower}");
                        break;
                    }
                }
                
                dataExtract = Console.ReadLine();
            }
            var totalCarHp = catalouge.Cars.Select(c => c.HorsePower).Sum();
            var averageCarHp = totalCarHp / catalouge.Cars.Count();
            System.Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}."); 
            var totalTruckHp = catalouge.Trucks.Select(t => t.HorsePower).Sum();
            var averageTruckHp = totalTruckHp / catalouge.Trucks.Count();
            System.Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}."); 
        }
    }
}