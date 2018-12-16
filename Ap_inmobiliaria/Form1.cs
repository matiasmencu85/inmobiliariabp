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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txttipo.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public venta ventaActual{get;set;}


        private void btnguardar_Click(object sender, EventArgs e)
        {
            venta venta = new venta();
            venta.dni_cliente = txtdni.Text;
            venta.localidad = txtloc.Text;
            venta.domicilio = txtdom.Text;
            venta.tipo = txttipo.Text;
            venta.ambientes = txtamb.Text;
            venta.precio = txtpre.Text;
            venta.fecha_alta = txtfecha.Text;
            venta.detalles = txtdet.Text;


            int resultado =ventaDAL.Agregar(venta);

            if (resultado > 0 && txtdni.Text != "" && txtloc.Text != "" && txtdom.Text != "" && txttipo.Text != "" && txtamb.Text != "" && txtpre.Text != "" && txtfecha.Text != "")
            {
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("NO SE PUDIERON GUARDAR LOS DATOS / VERIFICAR CAMPOS OBLIGATORIOS", "ERROR AL GUARDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }


        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           buscar_venta pBuscar = new buscar_venta();
            pBuscar.ShowDialog();

            if(pBuscar.ventaSeleccionado  != null)
            {

                ventaActual = pBuscar.ventaSeleccionado;
                  txtdni.Text = pBuscar.ventaSeleccionado.dni_cliente;
                  txtloc.Text = pBuscar.ventaSeleccionado.localidad;
                  txtdom.Text = pBuscar.ventaSeleccionado.domicilio;
                  txttipo.Text = pBuscar.ventaSeleccionado.tipo;
                  txtamb.Text = pBuscar.ventaSeleccionado.ambientes;
                 txtpre.Text = pBuscar.ventaSeleccionado.precio;
                  txtfecha.Text = pBuscar.ventaSeleccionado.fecha_alta;
                  txtdet.Text = pBuscar.ventaSeleccionado.detalles;

                  btnguardar.Enabled = false;
                  btnmodificar.Enabled = true;
                  btneliminar.Enabled = true;

            
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            venta pventa = new venta();
            pventa.dni_cliente = txtdni.Text;
            pventa.localidad = txtloc.Text;
            pventa.domicilio = txtdom.Text;
            pventa.tipo = txttipo.Text;
            pventa.ambientes = txtamb.Text;
            pventa.precio = txtpre.Text;
            pventa.fecha_alta = txtfecha.Text;
            pventa.detalles = txtdet.Text;
            pventa.id = ventaActual.id;


            int resultado = ventaDAL.Modificar(pventa);

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
               MessageBox.Show ("LA PROPIEDAD NO HA SIDO MODIFICADA ", "ERROR AL MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        void limpiar()
        {
            txtdni.Clear();
            txtloc.Clear();
            txtdom.Clear();
            
            txtamb.Clear();
            txtpre.Clear();
            txtfecha.Clear();
            txtdet.Clear();

                        
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            btneliminar.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR LA PROPIEDAD ? ", "ESTA SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int resultado = ventaDAL.eliminar(ventaActual.id);


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

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtamb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtamb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtfecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtpre_TextChanged(object sender, EventArgs e)
        {
          //  txtpre.Text = FormatException(txtpre.Text, "$0.00");
        }

       

      
        }
    
    }

