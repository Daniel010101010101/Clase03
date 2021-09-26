using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona1.Entidades
{
    class Profesor : ClsPersona
    {
        private String titulo;
        private String designacion;
        private String dedicacion;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Designacion { get => designacion; set => designacion = value; }
        public string Dedicacion { get => dedicacion; set => dedicacion = value; }
    }
}
