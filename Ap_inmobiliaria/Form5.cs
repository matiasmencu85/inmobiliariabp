using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Ap_inmobiliaria
{
    public partial class Form5 : Form
    {

        SqlConnection conex = new SqlConnection("Data source= VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dtb;
        string ar = "";





        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet4.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.inmobiliariaDataSet4.documentos);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet12.documentos' Puede moverla o quitarla según sea necesario.
         //   this.documentosTableAdapter1.Fill(this.inmobiliariaDataSet12.documentos);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet9.documentos' Puede moverla o quitarla según sea necesario.
       //     this.documentosTableAdapter.Fill(this.inmobiliariaDataSet9.documentos);
            this.txtRuta.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            ar = this.openFileDialog1.FileName;
            this.txtRuta.Text = ar;
        }
        private void Limpiar()
        {
            txtRuta.Clear();
            txtTitulo.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRuta.Text != "" && txtTitulo.Text != "")
                {
                    FileStream fs = new FileStream(ar, FileMode.Open);
                    //Creamos un array de bytes para almacenar los datos leídos por fs.
                    Byte[] data = new byte[fs.Length];
                    //Y guardamos los datos en el array data
                    fs.Read(data, 0, Convert.ToInt32(fs.Length));
                    if (conex.State == 0) { conex.Open(); }
                    cmd = new SqlCommand("UploadDoc", conex);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@doc", SqlDbType.VarBinary).Value = data;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = this.txtTitulo.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guardado Correctamente");
                 //   this.documentosTableAdapter.Fill(this.ejemploDataSet.documentos);
                    conex.Close();
                    fs.Close();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Adjuntar y escribir Título");
                }

            }
            catch (Exception)
            {
                throw;
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.dataGridView1.CurrentRow.Index;
                int cod = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd = new SqlCommand("select doc from documentos where docId=" + cod + "", conex);
                da = new SqlDataAdapter(cmd);
                dtb = new DataTable();
                da.Fill(dtb);
                DataRow f = dtb.Rows[0];
                byte[] bits = ((byte[])(f.ItemArray[0]));
                string sFile = "tmp" + GenerarNombreFichero() + ".doc";
                FileStream fs = new FileStream(sFile, FileMode.Create);
                //Y escribimos en disco el array de bytes que conforman
                //el fichero Word
                fs.Write(bits, 0, Convert.ToInt32(bits.Length));
                fs.Close();
                System.Diagnostics.Process obj = new System.Diagnostics.Process();
                obj.StartInfo.FileName = sFile;
                obj.Start();
            }
            catch (Exception)
            {

                throw;
            }            
        }


        private string GenerarNombreFichero()
        {
            int ultimoTick = 0;
            while (ultimoTick == Environment.TickCount)
            {
                System.Threading.Thread.Sleep(1);
            }
            ultimoTick = Environment.TickCount;
            return DateTime.Now.ToString("yyyyMMddhhmmss") + "." +
            ultimoTick.ToString();
        }
 




    }
}
