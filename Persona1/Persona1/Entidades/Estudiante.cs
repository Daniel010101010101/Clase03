using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona1.Entidades
{
    class Estudiante : ClsPersona
    {
        private String Carrera;
        private int nromatricula;

        public string Carrera1 { get => Carrera; set => Carrera = value; }
    }
}
