using System;
namespace BuildingCars
{
    public class SpeedLimitExceedException : Exception
    {
        public SpeedLimitExceedException()
        {
            Console.WriteLine("Excedio el límite de velocidad del motor");
        }
    }
}
