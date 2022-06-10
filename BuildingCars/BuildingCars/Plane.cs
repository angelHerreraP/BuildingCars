using System;
namespace BuildingCars
{
    class Plane
    {

        public Plane(int amountOfWheels, int amountOfWing, double width, double height)
        {
            PlaneHeight = height;
            PlaneWidth = width;
        }

        public object PlaneWidth { get; set; }
        public object PlaneHeight { get; set; }
        public object AmountOfWheels { get; set; }
        public object AmountOfWings { get; set; }

        VehicleArea AreaForPlanes = new VehicleArea();
        double AreaForPlanes.GetArea();
    }
}