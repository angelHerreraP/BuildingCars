using System;
namespace BuildingCars
{
    public class Car
    {
        public Car(int amountOfWheels, int amountOfDoors, double width, double height)
        {
            CarHeight = height;
            CarWidth = width;
        }

        public object AmountOFDoors { get; set; }
        public object CarWidth { get; set; }
        public object  CarHeight { get; set; }



    }
}
