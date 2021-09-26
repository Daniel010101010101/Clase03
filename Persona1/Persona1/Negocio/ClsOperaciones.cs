using Persona1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona1.Negocio
{
    class ClsOperaciones
    {
        public Double Suma(Operaciones num)
        {
            num.Resultado = num.Operacion1 + num.Operacion2;
            return num.Resultado;
        }
        public Double Resta(Operaciones num)
        {
            num.Resultado = num.Operacion1 - num.Operacion2;
            return num.Resultado;
        }
        public Double Multiplicacion(Operaciones num)
        {
            num.Resultado = num.Operacion1 * num.Operacion2;
            return num.Resultado;

        }
        public Double Division(Operaciones num)
        {
            num.Resultado = num.Operacion1 / num.Operacion2;
            return num.Resultado;
        }


        
    }
}
