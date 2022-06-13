using System;
namespace BuildingCars
{
    public class Car
    {
        public Car( int amountOfDoors, double width, double height)
        {
            CarHeight = height;
            CarWidth = width;
            VehicleArea CarArea = new VehicleArea();
            //Deben llamarse en contructores
            area = CarArea.GetArea(35.2, 65.3);
        }

        double area;
        public object AmountOFDoors { get; set; }
        public object CarWidth { get; set; }
        public object CarHeight { get; set; }


        
    }
}
