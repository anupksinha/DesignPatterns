using DesignPatterns.Factory;
using DesignPatterns.Factory.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        string userInput = null;
        Console.WriteLine("Enter Vehicle Type!");

        userInput = Console.ReadLine();

        IVehicle vehicleType = VehicleFactory.CreateVehicleObject(userInput);
        Console.WriteLine($"Name of vehicle: {vehicleType.GetVehicleName()}");
        Console.WriteLine($"No of Wheels: {vehicleType.GetNumberOfWheels()}");

        Console.ReadLine();
    }
}