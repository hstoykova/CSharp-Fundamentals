/*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue

 */

using _06.VehicleCatalogue;
using Type = _06.VehicleCatalogue.Type;

namespace _06.VehicleCatalogue
{
    enum Type
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Type Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type == "car" ? Type.Car : Type.Truck;
            Model = model;
            Color = color;
            Horsepower = horsePower;
        }
        public override string ToString()
        {
            return $"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {Horsepower}";
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        string input;

        List<Vehicle> vehicles = new List<Vehicle>();

        while ((input = Console.ReadLine()) != "End")
        {
            string[] splittedInput = input.Split();
            string typeOfVehicle = splittedInput[0];
            string model = splittedInput[1];
            string color = splittedInput[2];
            int horsepower = int.Parse(splittedInput[3]);

            Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsepower);

            vehicles.Add(vehicle);
        }

        string vModel;

        while ((vModel = Console.ReadLine()) != "Close the Catalogue")
        {
            Console.WriteLine(vehicles.Find(v => v.Model == vModel));
        }

        List<Vehicle> cars = vehicles.Where(v => v.Type == Type.Car).ToList();

        double carsHp = cars.Count > 0 ? (cars.Select(v => v.Horsepower).Sum() / (double)cars.Count) : 0;
        Console.WriteLine($"Cars have average horsepower of: {carsHp:F2}.");

        List<Vehicle> trucks = vehicles.Where(v => v.Type == Type.Truck).ToList();

        double trucksHp = trucks.Count > 0 ? ( trucks.Select(v => v.Horsepower).Sum() / (double)trucks.Count) : 0;
        Console.WriteLine($"Trucks have average horsepower of: {trucksHp:F2}.");
    }
}