using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            nombre = Console.ReadLine();

            int cant = nombre.Length;
            nombre.ToUpper(); // Pasa todo a mayuscula pero en el momento, no modifica nombre;
        }
    }
}
