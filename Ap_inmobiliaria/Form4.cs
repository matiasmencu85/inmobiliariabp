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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public alquiler alquilerActual { get; set; }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            alquiler alquiler = new alquiler();
            alquiler.dni_cliente = txtdni.Text;
            alquiler.localidad = txtloc.Text;
            alquiler.domicilio = txtdom.Text;
            alquiler.tipo = txttipo.Text;
            alquiler.ambientes = txtamb.Text;
            alquiler.precio = txtpre.Text;
            alquiler.estado = txtest.Text;
            alquiler.detalles = txtdet.Text;
            alquiler.prohibiciones = txtpro.Text;
            alquiler.inventario = txtinv.Text;
            alquiler.fecha_ini = txtfechaini.Text;
            alquiler.fecha_fin = txtfechafin.Text;

            int resultado = alquilerDAL.Agregar(alquiler);







            if (resultado > 0 && txtdni.Text != "" && txtloc.Text != "" && txtdom.Text != "" && txttipo.Text != "" && txtamb.Text != "" && txtpre.Text != ""  && txtfechaini.Text != "" && txtfechafin.Text != "")
            {
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("NO SE PUDIERON GUARDAR LOS DATOS ", "ERROR AL GUARDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        private void alquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {  buscar_alquiler pBuscar = new buscar_alquiler();
            pBuscar.ShowDialog();

            if(pBuscar.alquilerSeleccionado  != null)
            {

                alquilerActual = pBuscar.alquilerSeleccionado;
                  txtdni.Text = pBuscar.alquilerSeleccionado.dni_cliente;
                  txtloc.Text = pBuscar.alquilerSeleccionado.localidad;
                  txtamb.Text = pBuscar.alquilerSeleccionado.ambientes;
                  txtdom.Text = pBuscar.alquilerSeleccionado.domicilio;
                  txttipo.Text = pBuscar.alquilerSeleccionado.tipo;
                  txtpre.Text = pBuscar.alquilerSeleccionado.precio;
                  txtest.Text = pBuscar.alquilerSeleccionado.estado;
                  txtpro.Text = pBuscar.alquilerSeleccionado.prohibiciones;
                  txtinv.Text = pBuscar.alquilerSeleccionado.inventario;
                  txtfechaini.Text = pBuscar.alquilerSeleccionado.fecha_ini;
                  txtfechafin.Text = pBuscar.alquilerSeleccionado.fecha_fin;

                  btnguardar.Enabled = false;
                  btnmodificar.Enabled = true;
                  btneliminar.Enabled = true;

            
            }
        }

        void limpiar()
        {
            txtdni.Clear();
            txtloc.Clear();
            txtdom.Clear();
           // txttipo.Clear();
            txtamb.Clear();
            txtpre.Clear();
            txtfechaini.Clear();
            txtdet.Clear();
            txtpro.Clear();
            txtinv.Clear();
            txtfechaini.Clear();
            txtfechafin.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            alquiler palquiler = new alquiler();
            palquiler.dni_cliente = txtdni.Text;
            palquiler.localidad = txtloc.Text;
            palquiler.domicilio = txtdom.Text;
            palquiler.tipo = txttipo.Text;
            palquiler.ambientes = txtamb.Text;
            palquiler.precio = txtpre.Text;
            palquiler.estado = txtest.Text;
            palquiler.detalles = txtdet.Text;
            palquiler.prohibiciones = txtpro.Text;
            palquiler.inventario = txtinv.Text;
                                   
            palquiler.fecha_ini = txtfechaini.Text;
            palquiler.fecha_fin = txtfechafin.Text;
            palquiler.id = alquilerActual.id;

            int resultado = alquilerDAL.Modificar(palquiler);

            if (resultado > 0)
            {
                MessageBox.Show("PROPIEDAD MODIFICADA CON EXITO", "PROPIEDAD MODIFICADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btneliminar.Enabled = false;
                btnmodificar.Enabled = false;
                btnguardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("LA PROPIEDAD NO HA SIDO MODIFICADA ", "ERROR AL MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            btneliminar.Enabled = true;
        }
      

        private void btneliminar_Click(object sender, EventArgs e)
        {
         if (MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR LA PROPIEDAD ? ", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int resultado = alquilerDAL.eliminar(alquilerActual.id);


                if (resultado > 0)
                {
                    MessageBox.Show("PROPIEDAD ELIMINADA CON EXITO", "PROPIEDAD ELIMINADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    btnguardar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("LA PROPIEDAD NO HA SIDO ELIMINADA ", "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
                MessageBox.Show("SE CANCELO LA ELIMINACION","CANCELADO");
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtamb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtfechaini_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtfechafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

     












    }
}
