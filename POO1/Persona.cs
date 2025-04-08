using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Persona
    {

        public Persona(int edad, float sueldo)
        {
            this.edad = edad;
            this.sueldo = sueldo;
        }
        // se puede sobrecargar el constructor
        public Persona(){}

        ~Persona() // este es el destructor
        {

        }

        private int edad;
        private float sueldo;
        public string Nombre {  get; set; } // aca hace el get y set solo como el de arriba

        public void setEdad(int e) // esto seria un metodo
        {
            edad = e;
        }

        public int getEdad(){
            return edad;
        }


        public float Sueldo // esto seria una propiedad
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public string saludar()
        {
            return "Hola soy " + Nombre;
        }

        public string saludar(string nombre) //Sobrecarga de metodos
        {
            return "Hola " + nombre + " soy " + Nombre;
        }
    }
}
