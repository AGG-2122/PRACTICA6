using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAGG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = tNombre.Text;
            string Apellidos = tApellidos.Text;
            string telefono = tTeléfono.Text;

            tListaSocios.Text = "Nombre: " + Nombre + " Apellidos: " + Apellidos + " Teléfono: " + telefono;
        }
    }
}
