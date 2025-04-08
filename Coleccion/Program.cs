using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Vehiculo v2 = new Vehiculo();
            Vehiculo v3 = new Vehiculo();
            v1.Color = "Rojo";
            v2.Color = "Blanco";
            v3.Color = "Amarillo";

            List<Vehiculo> listaVehiculo = new List<Vehiculo>(); //aca hago una lista de objetos vehiculo

            listaVehiculo.Add(v1); //aca le agrego el elemento v1
            listaVehiculo.Add(v2);
            listaVehiculo.Add(v3);

            v3.Color = "Marron";
            
            Console.WriteLine("La cantidad de vehiculos es: " + listaVehiculo.Count);
            //listaVehiculo[2].Color = "Negro";
            Console.WriteLine("El color es: " + listaVehiculo[2].Color); //muestra marron porque lo cambie, es porque a la lista se agregan referencias de los objetos
            listaVehiculo.Remove(v3); // aca puedo sacar por posicion o directamente la referencia al objeto

            foreach (Vehiculo x in listaVehiculo)
            {
                Console.WriteLine(x.Color);
            }
            
            
            Console.ReadKey();
        }
    }
}
