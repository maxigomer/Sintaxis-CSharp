using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aguila : Animal,Flyable
    {
        public string volar()
        {
            return "Vuela el aguila...";
        }
    }
}
