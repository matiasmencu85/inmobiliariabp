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
    public partial class buscar_venta : Form
    {
        public buscar_venta()
        {
            InitializeComponent();
        }

        public venta ventaSeleccionado { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ventaDAL.buscarVenta(txttipo.Text, txtamb.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                ventaSeleccionado = ventaDAL.Obtenerventa(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("AUN NO HA SELECCIONADO NINGUNA PROPIEDAD  ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtamb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            Abrir.InitialDirectory = "D:/fotos";

            if (Abrir.ShowDialog()==DialogResult.OK)
            {
                String Dir = Abrir.FileName;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Picture = new Bitmap(Dir);

                pictureBox1.Image = (Image)Picture;
            }
        }

        private void buscar_venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet2.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.inmobiliariaDataSet2.venta);

        }

      
    }
}
