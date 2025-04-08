using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    internal class Animal
    {
        public virtual string comunicarse() //para que se pueda sobreescribir tiene que ser virtual
        {
            return "Ruido... ruido...";
        }
    }
}
