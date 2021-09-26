using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persona1.Entidades;

namespace Persona1.Negocio
{
    class NPersona
    {
        public int Acceso (ClsPersona per)
        {
            if (per.Nombre == "Franklin" && per.Contraseña == "123")
            {
                return 0;

            }
            else
                return 1;
        }




    }
}
