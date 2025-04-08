using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            Chasis = new Chasis(); // aca si se crea ya con el chasis incorporado
        }

        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Chasis Chasis { get; }
        public Motor Motor { get; set; } // seria variable agregacion porque no hace falta que se cree con esto ya creado

    }
}
