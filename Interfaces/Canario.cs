using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Canario : Animal, Flyable //aca hereda de animal y usa la interfaz Flyable
    {
        public string volar()
        {
            return "Vuela...";
        }
    }
}
