using System;


namespace BuildingCars
{
    [Serializable]
    public class Car: IVehicle
    {
        public override string ToString()
        {
            return "Car" +test;
        }

        public string test { get; set; }
        //private int amountOfWheels;
        //int IVehicle.AmountOfWheels { get => amountOfWheels; set => amountOfWheels = value; }

        //Cambiar Todo
        int IVehicle.Motor(int amountOfmotors) => amountOfmotors;

        int IVehicle.DoorNumber(int vehicleDoors)
        {
            return vehicleDoors;
        }

        int IVehicle.SerialNumber(int vehicleSerialNumber)
        {
            return vehicleSerialNumber;
        }
        
        double IVehicle.VehicleDimensions(double height, double width)
        {
            double carArea = height * width;
            return carArea;
        }

    }
}
