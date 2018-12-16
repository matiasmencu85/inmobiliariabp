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
    public partial class contrato : Form
    {
        public contrato()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
          {

              try
              {
                  SqlCommand cmd = new SqlCommand("INSERT INTO contratos VALUES(@nombre, @fecha_ini, @fecha_fin)", Conn);
                  Conn.Open();

                  foreach (DataGridViewRow row in dataGridView1.Rows)
                  {

                      if (row.Cells["nombrecon"].Value != null)
                      {

                          cmd.Parameters.Clear();
                          cmd.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["nombrecon"].Value));
                          cmd.Parameters.AddWithValue("@fecha_ini", Convert.ToString(row.Cells["fecha_ini"].Value));
                          cmd.Parameters.AddWithValue("@fecha_fin", Convert.ToString(row.Cells["fecha_fin"].Value));
                          cmd.ExecuteNonQuery();
                      }
                  }
                  
                  MessageBox.Show("GUARDADO CORRECTAMENTE");
                  
              }
              catch (SqlException ex)
              {
                  MessageBox.Show(ex.ToString());
              }
              finally
              {
                  if (Conn.State == ConnectionState.Open)
                      Conn.Close();


              }


          }
   
    
     private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet3.documentos' Puede moverla o quitarla según sea necesario.
            //this.documentosTableAdapter2.Fill(this.ejemploDataSet3.documentos);
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet2.documentos' Puede moverla o quitarla según sea necesario.
           // this.documentosTableAdapter1.Fill(this.ejemploDataSet2.documentos);
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet.documentos' Puede moverla o quitarla según sea necesario.
            //this.documentosTableAdapter.Fill(this.ejemploDataSet.documentos);

        }

       
        
       
      

    /*    private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from contratos where fecha_ini like('%" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Conn.Close();
                       // dataGridView1 = String.Format("fechafin like '%{0}%'", textBox1.Text);
        }
        */
        private void contrato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet6.contratos' Puede moverla o quitarla según sea necesario.
            this.contratosTableAdapter.Fill(this.inmobiliariaDataSet6.contratos);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet5.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.inmobiliariaDataSet5.documentos);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet16.contratos' Puede moverla o quitarla según sea necesario.
          //  this.contratosTableAdapter1.Fill(this.inmobiliariaDataSet16.contratos);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet11.contratos' Puede moverla o quitarla según sea necesario.
          //  this.contratosTableAdapter.Fill(this.inmobiliariaDataSet11.contratos);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet10.documentos' Puede moverla o quitarla según sea necesario.
           // this.documentosTableAdapter1.Fill(this.inmobiliariaDataSet10.documentos);
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet.documentos' Puede moverla o quitarla según sea necesario.
         //   this.documentosTableAdapter.Fill(this.ejemploDataSet.documentos);

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from contratos where fecha_fin like('%" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");

            DialogResult resultado = MessageBox.Show("¿Seguro desea eliminar fecha del contrato?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            SqlCommand comando = new SqlCommand("Delete from contratos where nombre=@nombre", Conn);
            comando.Parameters.AddWithValue("nombre", dataGridView1.CurrentRow.Cells["nombrecon"].Value);

            Conn.Open();
            comando.ExecuteNonQuery();
            Conn.Close();

            MessageBox.Show("fecha borrada");
        }

        private void printgrid_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dataGridView1, myPaintArgs);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
    
    
    
    
    
    
    
    }



