using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalouge
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
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

        public void Fill(List<Car> car)
        {
           
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var catalouge = new Catalouge();

            while (input != "end")
            {
                string[] tockens = input.Split("/");
                string type = tockens[0];
                string brand = tockens[1];
                string model = tockens[2];
                int hpOrWeigth = int.Parse(tockens[3]);

                if (type == "Car")
                {
                    var car = new Car();    
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = hpOrWeigth;
                    catalouge.Cars.Add(car);    
                }
                else
                {
                    var truck = new Truck();   
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = hpOrWeigth;
                    catalouge.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (catalouge.Cars.Count > 0)
            {  
                System.Console.WriteLine("Cars:");
   
                foreach (var cars in catalouge.Cars.OrderBy(c => c.Brand))
                {
                    System.Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                }
            }

            if (catalouge.Trucks.Count > 0)
            {
                System.Console.WriteLine("Trucks:");
                
                foreach (var truck in catalouge.Trucks.OrderBy(t => t.Brand))
                {
                    System.Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
