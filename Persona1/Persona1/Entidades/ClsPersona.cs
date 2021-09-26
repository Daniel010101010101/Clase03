using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona1.Entidades
{
    class ClsPersona
    {
        private String nombre;
        private String contraseña;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public ClsPersona()
        {
        }
    }
}
