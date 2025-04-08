using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Perro p1 = new Perro();

            p1.Nombre = "Gaspi";

            //Console.WriteLine(p1.ToString()); //aca muestra el nombre del namespace.perro que es mi clase, pero se puede sobreescribir ese metodo

            List<Animal> animales = new List<Animal>();

            animales.Add(a1);
            animales.Add(p1);
            animales.Add(new Perro());
            animales.Add(new Gato());

           // Console.WriteLine(p1.comunicarse());
           // Console.WriteLine(a1.comunicarse());

            foreach(Animal x in animales)
            {
                Console.WriteLine(x.comunicarse());
            }

            Animal a2 = p1;
            Perro p6 = (Perro)a2; // De esta forma puedo guardar un animal que yo se que es perro nuevamente en una variable perro, es casteo explicito
            Console.WriteLine(p6.Nombre);
        }
    }
}
