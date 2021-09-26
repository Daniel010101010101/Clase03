using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona1.Entidades;
using Persona1.Negocio; 

namespace Persona1.Vistas
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        Ventas venta = new Ventas();
        private void button1_Click(object sender, EventArgs e)
        {
            ClsPersona personita = new ClsPersona();
            NPersona personota = new NPersona();

            personita.Nombre = textBox1.Text;
            personita.Contraseña = textBox2.Text;

            int val = personota.Acceso(personita);

            if (val == 0)
            {
                venta.Show();
            }
            else
                MessageBox.Show("El nombre del usuario o su contraseña son incorrectas, por favor intente de nuevo");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
