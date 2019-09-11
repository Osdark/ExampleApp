using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class Animal
    {
        private int edad;
        private string nombre;
        private bool estaHablando = false;

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public Animal()
        {
        }

        public Animal(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public void hablar()
        {

        }
    }
}
