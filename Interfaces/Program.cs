using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aguila a1 = new Aguila();

            Console.WriteLine(a1.volar());

            List<Animal> animales = new List<Animal>();
            List<Flyable> listaVoladores = new List<Flyable>(); // de flyable si se pueden hacer listas pero no variables, no puedo hacer flyable f1 por ejemplo

            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Canario()); // se pueden agregar los que tengan la interfaz flyable

            
        }
    }
}
