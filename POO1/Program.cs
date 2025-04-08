using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(25,60000); // al usar new se llama al constructor de la clase, se puede crear o usar el que esta por defecto(vacio)

            p1.setEdad(23);
            p1.Nombre = "Max";
            Console.WriteLine(p1.saludar("Carlos"));
            Console.WriteLine("La edad es: " + p1.getEdad());

            p1.Sueldo = 15000; // le puedo ingresar el valor de una cuando se utiliza propiedad
            Console.WriteLine("El sueldo es: " + p1.Sueldo);

            Persona[] Personas = new Persona[10];

            p1.Sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("El sueldo es: " + p1.Sueldo);
        }
    }
}
