using System;
using System.Linq;

namespace BuildingCars
{
    public class Garage
    {
        public Garage(double garageWidth, double garageHeight)
        {
            GarageWidth = garageWidth;
            GarageHeight = garageHeight;
            GarageTotalArea = GarageHeight * GarageWidth;
        }
        public double GarageWidth { get; set; }
        public double GarageHeight  { get; set; }
        public double GarageTotalArea { get; set; }

        private string [] VehicleNames= null;
        private double[] VehicleArea = null;
        public void AddingVehicles(string vehicleName, double vehicleArea)
        {
            if (vehicleArea <= GarageTotalArea)
            {
                VehicleNames.Append(vehicleName);
                VehicleArea.Append(vehicleArea);
                foreach (double vehicle in VehicleArea)
                {
                    Array.Sort(VehicleArea);
                }
            }
            else
            {
                Console.WriteLine("There's to many vehicles!");
            }
        }

    }

}

//How To Save Data into Files C# - Sábado
