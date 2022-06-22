using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace BuildingCars
{
    class VehicleOwner
    {
        public static void Main(string[] args)
        {
            
        }
    }
}

/*          Car carVolvo = new Car();
            carVolvo.test= "Car1";
            Car carNissan = new Car();
            carNissan.test = "Car2";
            Console.WriteLine(carVolvo);
            Console.WriteLine(carNissan);
            Console.WriteLine("hola, manolo");
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("archivoguardado.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, carNissan);
            Console.WriteLine("Termino");
            stream.Close();*/

// DECLARAR UNA INTEFAZ VEHICLE Y DECLARAR UN  METODO QUE SE LLAME ACCELERATE Y QUE CADA CLASE LO SOBRESCRIBA
// DECLARAR OTRA CLASE AVIÓN QUE SEA IMPLEMENTADO DE LA INTERFAZ.
// DECLARAR UNA CLASE QUE SE LLAME GARAGE QUE PUEDA TENER MULTIPLES VEHICULOS Y EL GARAGE TIENE DIMENSIONES Y CADA VEHICULO TAMBIÉN TIENE
// TIENE VOLUMEN Y EL GARAGE DEBE TENER UNA FUNCION QUE GUARDE UN ARREGLO DE VEHICULOS AL MISMO TIEMPO
// EL GARAGE DDEBE GUARDAR TODOS LOS VEHICULOS Y CADA VEHICULO TIENE ANCHO, ALTO Y PROFUNDIDAD E IGUAL LOS AVIONES
// LA FUNCIÓN DE GUARDAR VEHICULO DEBE GUARDAR LA MAYOR
// ¿CÓMO SE DEBE GUARDAR LOS VEHICULOS?
// VOUMEN ES CLAVE
// DECLARAR COSAS UNA SOLA VEZ