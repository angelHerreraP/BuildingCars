using System;
namespace BuildingCars
{
    class Motor: IAccelerate
    {
        // Cuales son los modificadores de acceso de C# -- Tarea Sábado --
        public Motor(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public int SerialNumber { get; set; }
        public string Brand { get; set; }
        public double CurrentSpeed { get; set; }
        public double MaxSpeed { get; set; }

        void IAccelerate.increaseSpeed(int addSpeed)
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
        /*public void Acelerar(int addSpeed)
        {
            if (addSpeed + CurrentSpeed <= MaxSpeed)
            {
                CurrentSpeed += addSpeed;
            }
            else
            {
                throw new BuildingCars.SpeedLimitExceedException();
            }*/
        }
    }
}