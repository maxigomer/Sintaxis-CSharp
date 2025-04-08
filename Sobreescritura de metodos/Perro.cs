using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    internal class Perro : Animal
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return "Animal " + Nombre; // aca cambio que el metodo tostring devuelva esto
        }

        public override string comunicarse()
        {
            return "Waw... waw...";
        }
    }
}
