/*
Car/Audi/A3/110
Car/Maserati/Levante/350
Truck/Mercedes/Actros/9019
Car/Porsche/Panamera/375
end

Car/Subaru/Impreza/152
Car/Peugeot/307/109
end

 */

using System.Reflection;

namespace _07.VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class Catalog
    {
        public Truck Truck { get; set; }
        public Car Car { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splittedInput = input.Split("/");
                string catalog = splittedInput[0];
                string brand = splittedInput[1];
                string model = splittedInput[2];
                string horsePower = splittedInput[3];
                string weight = splittedInput[3];

                Truck truck = new Truck() // object of type "Truck"
                {
                    Brand = brand,
                    Model = model,
                    Weight = weight
                };

                Car car = new Car()
                {
                    Brand = brand,
                    Model = model,
                    HorsePower = horsePower
                };

                if (catalog == "Car")
                {
                    cars.Add(car);
                }
                else
                {
                    trucks.Add(truck);
                }
            }

            List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();
            if (sortedCars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            List<Truck> sortedTrucks = trucks.OrderBy(truck => truck.Brand).ToList();

            if (sortedTrucks.Count != 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

}