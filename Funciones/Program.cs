using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10,b = 5;

            

            Console.WriteLine(sumar(a,ref b));
            Console.ReadKey();
        }

        static int sumar(int a,ref int b) // aca modifica el valor original de b
        {
            return a + b;
        }
    }
}
