namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                // You can add more cases for different numbers of tires and vehicle types
                default:
                    throw new ArgumentException("Invalid number of tires");
            }
        }
    }
}

