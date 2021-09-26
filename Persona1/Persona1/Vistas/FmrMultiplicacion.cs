using Persona1.Entidades;
using Persona1.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona1.Vistas
{
    public partial class FmrMultiplicacion : Form
    {
        public FmrMultiplicacion()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Operacion1 = Convert.ToDouble(textBox5.Text);
            operaciones.Operacion2 = Convert.ToDouble(textBox6.Text);
            ClsOperaciones clsOperaciones = new ClsOperaciones();
            MessageBox.Show(clsOperaciones.Multiplicacion(operaciones).ToString());
        }
    }
}
