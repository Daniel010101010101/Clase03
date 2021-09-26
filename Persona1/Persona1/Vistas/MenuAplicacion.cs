
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
    public partial class MenuAplicacion : Form
    {
        public MenuAplicacion()
        {
            InitializeComponent();
        }

        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmestudiante = new FrmEstudiante();
            frmestudiante.MdiParent = this; frmestudiante.Show();



        }
    }
}
