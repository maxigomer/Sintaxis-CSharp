using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    internal class Gato : Animal
    {
        public override string comunicarse()
        {
            return "Miau... miau...";
        }
    }
}
