using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLAB01_2
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dni = txtdni.Text;
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string email = txtemail.Text;
            string fecha = combofecha.Text;

            dgvusuarios.Rows.Add("", dni, nombre, apellido, fecha);


        }
    }
}
