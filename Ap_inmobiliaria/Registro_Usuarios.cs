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

namespace Ap_inmobiliaria
{
    public partial class Registro_Usuarios : Form
    {
        public Registro_Usuarios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña.Text)
            {
                if (UsuariosDAL.CrearCuentas(txtUsuario.Text, txtContraseña.Text,txttipo.Text) > 0)
                {
                    MessageBox.Show("CUENTA CREADA CON EXITO");
                }

                else
                {
                    MessageBox.Show(" NO SE HA CREADO LA CUENTA");
                }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
