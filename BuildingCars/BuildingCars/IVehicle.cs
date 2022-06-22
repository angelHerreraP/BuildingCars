using System;
namespace BuildingCars
{
    interface IVehicle
    {
        //public int AmountOfWheels { get; set; }
        int Motor(int amountOfmotors);
        int DoorNumber(int vehicleDoors);
        int SerialNumber(int vehicleSerialNumber);
        double VehicleDimensions(double height, double width);
        //int Accelerate(int currentSpeed, int maxMotorSpeed, int addSpeed);

    }
}
