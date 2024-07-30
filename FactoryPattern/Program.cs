using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires on the vehicle:");

            if (int.TryParse(Console.ReadLine(), out int numberOfTires))
            {
                try
                {
                    IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
                    vehicle.Drive();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.ReadLine();
        }
    }
}

