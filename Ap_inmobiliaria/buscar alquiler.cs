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
    public partial class buscar_alquiler : Form
    {
        public buscar_alquiler()
        {
            InitializeComponent();
        }

        public alquiler alquilerSeleccionado { get; set; }

        
       

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

        private void button4_Click1(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            Abrir.InitialDirectory = "D:/fotos";

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                String Dir = Abrir.FileName;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Picture = new Bitmap(Dir);

                pictureBox1.Image = (Image)Picture;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = alquilerDAL.Buscaralquiler(txttipo.Text, txtamb.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                alquilerSeleccionado = alquilerDAL.Obteneralquiler(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("AUN NO HA SELECCIONADO NINGUNA PROPIEDAD  ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            Abrir.InitialDirectory = "D:/fotos";

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                String Dir = Abrir.FileName;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Picture = new Bitmap(Dir);

                pictureBox1.Image = (Image)Picture;
            }
        }

        

    
    
    
    
    
    
    
    }
}
