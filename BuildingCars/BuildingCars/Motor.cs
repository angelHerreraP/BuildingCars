using System;
namespace Building.Cars
{
    class Motor
    {
        // Cuales son los modificadores de acceso de C# -- Tarea Sábado --
        // Tipos primitivos -- Tarea Sábado --
        //Garbage Collector  -- Tarea Sábado --
        // Como nombrar las cosas YA


        public Motor(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public int SerialNumber { get; set; }
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
// Done:
//setea maxspeed desde el constructor.
//Si se pasa de la vel arrojar una excepción ¿try? ¿Throw?


//Tareas Jueves 02 de Mayo:-------------------------------------
//En Github
// tarea Clase Carro que llame motor
//Corregir el if (ESTOY MUY CERCA) -- Tarea -- ¿Mayor o igual?
//SpeedLimitExceedExcep Excepciones Personalizadas -- Tareas --
//Excepciones general