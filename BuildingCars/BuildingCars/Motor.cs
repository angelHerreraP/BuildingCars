using System;
namespace BuildingCars
{
    class Motor
    { 
        public Motor(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public string Brand { get; set; }
        public double CurrentSpeed { get; set; }
        public double MaxSpeed { get; set; }

        public void Acelerar(int addSpeed)
        {
            if (addSpeed + CurrentSpeed <= MaxSpeed)
            {
                CurrentSpeed += addSpeed;
            }
            else
            {
                throw new BuildingCars.SpeedLimitExceedException();
            }
        }
    }
}