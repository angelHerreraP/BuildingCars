using System;
namespace BuildingCars
{
    interface IVehicle
    {
        int Wheels();
        int Motor();
        int DoorNumber();
        int SerialNumber();
        int NumberOfPassengers();
        double VehicleDimensions(double height, double width);

    }
}
