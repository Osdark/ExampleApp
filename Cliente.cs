using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class Cliente
    {
        private string nombre;
        private string email;
        private int codigo;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
