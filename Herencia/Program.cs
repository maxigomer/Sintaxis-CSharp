using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer();
            Persona p1 = new Persona();


            Persona p2 = new Developer(); // em este caso se puede cargar un developer en persona pero no al reves, porque developer hereda de persona


            p1.Nombre = "Max";
            Persona p3 = p1; // Estas variables son referencias, en este momento hago que p3 y p1 sean referencias del mismo objeto, entonces cualquier modificacion "Se modifica en los dos"

            Console.WriteLine(p3.Nombre);
            p3.Nombre = "Carlos";
            Console.WriteLine(p1.Nombre);
        }
    }
}
