using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap_inmobiliaria
{
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }


        int contador = 0;
        private void btnentrar_Click(object sender, EventArgs e)
        {

            Usuarios UsuarioOb = new Usuarios();
            UsuarioOb.Usuario = this.txtusuario.Text;
            UsuarioOb.Contraseña = this.txtcontraseña.Text;
            UsuarioOb.Tipo = this.comboBox1.SelectedItem.ToString();
            
            if (UsuarioOb.Buscar() == true)
            {

                if (this.comboBox1.Text == "ADMIN")
                {
                    MessageBox.Show(UsuarioOb.Mensaje);
                    ADMINISTRADOR obADMINISTRADOR = new ADMINISTRADOR();
                    obADMINISTRADOR.Show();
                    this.Hide();
                }
                else if (this.comboBox1.Text == "CLIENTE")
                {
                    MessageBox.Show(UsuarioOb.Mensaje);
                    CLIENTE obCLIENTE = new CLIENTE();
                    obCLIENTE.Show();
                    this.Hide();
                }
            }
               
            else
            {
                MessageBox.Show(UsuarioOb.Mensaje, "ERROR");
                
                while(contador <= 2)
                {
                contador=contador + 1;
                MessageBox.Show("INTENTOS REALIZADOS = "+contador,"SOLO DISPONE DE TRES INTENTOS");
                return;
                
                }
                MessageBox.Show("YA REALIZO SUS TRES INTENTOS, SE CERRARA LA APLICACION");
                this.Close();


            }




           /* if(UsuariosDAL.Autentificar(txtusuario.Text,txtcontraseña.Text)>0)
            {

                this.Hide();
                principal f = new principal();
                f.ShowDialog();
            }

            else
            {
                MessageBox.Show(" ERROR EN LOS DATOS");
            }
            
           */ 
            }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {
          
            this.comboBox1.Text = "ADMIN";
       
        }
    }
}
