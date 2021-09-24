using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab04
{
    public partial class frmConDB : Form
    {
        SqlConnection conn;
        public frmConDB()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            String servidor = txtservidor.Text;
            String bd = txtbasedatos.Text;
            String user = txtusuario.Text;
            String pwd = txtcontraseña.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            if (chkautenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btndesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString ());
            }
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State +
                        "\nVersión del servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del servidor: " + conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" +
                    ex.ToString());
            }
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexión cerrada satisfactoriamente");
                }
                else
                    MessageBox.Show("La conexión ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cerrar la conexión: \n"+
                    ex.ToString());
            }
        }

        private void chkautenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkautenticacion.Checked)
            {
                txtusuario.Enabled = false;
                txtcontraseña.Enabled = false;
            }
            else
            {
                txtusuario.Enabled = true;
                txtcontraseña.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }
    }
}
