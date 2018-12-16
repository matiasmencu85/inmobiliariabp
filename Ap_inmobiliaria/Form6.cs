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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void limpiar ()
        { 
       textBox1.Clear();
         textBox2.Clear();
         textBox3.Clear();
         textBox4.Clear();
         textBox5.Clear();
         textBox6.Clear();
         textBox7.Clear();
         textBox8.Clear();
         textBox9.Clear();
         textBox10.Clear();
         textBox11.Clear();
         textBox12.Clear();
         textBox13.Clear();
         textBox14.Clear();
         

        }


      
             


        private void button1_Click(object sender, EventArgs e)
        {


                string dni = textBox1.Text;
                string ape = textBox2.Text;
                string nom = textBox3.Text;

                string loc = textBox4.Text;
                string dom = textBox5.Text;
                string tel1 = textBox6.Text;
                string tel2 = textBox7.Text;
                string ema = textBox8.Text;
                string cod = textBox9.Text;
                string obs = textBox10.Text;
                string nac = textBox11.Text;
                string est = textBox12.Text;
                string pro = textBox13.Text;
                string gar = textBox14.Text;
                string tip = comboBox1.Text;



                if (dni != "" & ape != "" & nom != "" & loc != "" & dom != "" & tel1 != "" & tip != "" )
                {

                    SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");




                    SqlCommand comando = new SqlCommand("insert into clientes(dni_cliente,apellido,nombres,localidad,domicilio,telefono1,telefono2,email,cod_postal,observacion,nacionalidad,estado_civil,prohibiciones,garantia,tipocli)values(@dni_cliente,@apellido,@nombres,@localidad,@domicilio,@telefono1,@telefono2,@email,@cod_postal,@observacion,@nacionalidad,@estado_civil,@prohibiciones,@garantia,@tipocli)");
                    comando.Connection = Conn;


                    SqlParameter parametro1 = new SqlParameter();
                    parametro1.ParameterName = "@dni_cliente";
                    parametro1.Value = dni;

                    comando.Parameters.Add(parametro1);

                    SqlParameter parametro2 = new SqlParameter();
                    parametro2.ParameterName = "@apellido";
                    parametro2.Value = ape;

                    comando.Parameters.Add(parametro2);

                    SqlParameter parametro3 = new SqlParameter();
                    parametro3.ParameterName = "@nombres";
                    parametro3.Value = nom;


                    comando.Parameters.Add(parametro3);

                    SqlParameter parametro4 = new SqlParameter();
                    parametro4.ParameterName = "@localidad";
                    parametro4.Value = loc;

                    comando.Parameters.Add(parametro4);

                    SqlParameter parametro5 = new SqlParameter();
                    parametro5.ParameterName = "@domicilio";
                    parametro5.Value = dom;

                    comando.Parameters.Add(parametro5);

                    SqlParameter parametro6 = new SqlParameter();
                    parametro6.ParameterName = "@telefono1";
                    parametro6.Value = tel1;

                    comando.Parameters.Add(parametro6);

                    SqlParameter parametro7 = new SqlParameter();
                    parametro7.ParameterName = "@telefono2";
                    parametro7.Value = tel2;

                    comando.Parameters.Add(parametro7);

                    SqlParameter parametro8 = new SqlParameter();
                    parametro8.ParameterName = "@email";
                    parametro8.Value = ema;

                    comando.Parameters.Add(parametro8);

                    SqlParameter parametro9 = new SqlParameter();
                    parametro9.ParameterName = "@cod_postal";
                    parametro9.Value = cod;

                    comando.Parameters.Add(parametro9);

                    SqlParameter parametro10 = new SqlParameter();
                    parametro10.ParameterName = "@observacion";
                    parametro10.Value = obs;

                    comando.Parameters.Add(parametro10);

                    SqlParameter parametro11 = new SqlParameter();
                    parametro11.ParameterName = "@nacionalidad";
                    parametro11.Value = nac;

                    comando.Parameters.Add(parametro11);

                    SqlParameter parametro12 = new SqlParameter();
                    parametro12.ParameterName = "@estado_civil";
                    parametro12.Value = est;

                    comando.Parameters.Add(parametro12);

                    SqlParameter parametro13 = new SqlParameter();
                    parametro13.ParameterName = "@prohibiciones";
                    parametro13.Value = pro;

                    comando.Parameters.Add(parametro13);

                    SqlParameter parametro14 = new SqlParameter();
                    parametro14.ParameterName = "@garantia";
                    parametro14.Value = gar;

                    comando.Parameters.Add(parametro14);

                    SqlParameter parametro15 = new SqlParameter();
                    parametro15.ParameterName = "@tipocli";
                    parametro15.Value = tip;

                    comando.Parameters.Add(parametro15);





                    try
                    {

                        Conn.Open();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("se ha agregado exitosamente el registro");
                        limpiar();
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show("se ha producido un error, REVISE CAMPOS OBLIGATORIOS" + err + "");


                    }
                    Conn.Close();
                    epError.Clear();

                  
                }

                else{

                    epError.SetError(textBox1, "INTRODUCE EL DNI DEL CLIENTE, CAMPO OBLIGATORIO");
                    textBox1.Focus();
                    epError.SetError(textBox2, "INTRODUCE EL APELLIDO DEL CLIENTE, CAMPO OBLIGATORIO");
                    textBox2.Focus();
                    epError.SetError(textBox6, "INTRODUCE EL TELEFONO DEL CLIENTE, CAMPO OBLIGATORIO");
                    textBox6.Focus();
                    epError.SetError(textBox5, "INTRODUCE EL DOMICILIO DEL CLIENTE, CAMPO OBLIGATORIO");
                    textBox5.Focus();
                    
                    epError.SetError(textBox4, "INTRODUCE EL LOCALIDAD DEL CLIENTE, CAMPO OBLIGATORIO");
                    textBox4.Focus();
                   epError.SetError(textBox3, "INTRODUCE EL NOMBRE DEL CLIENTE, CAMPO OBLIGATORIO");
                   textBox3.Focus();

                    MessageBox.Show("COMPLETE CAMPOS OBLIGATORIOS");
                   

                }
                
     
                }
            
                         

            //  Me.clientesTableAdapter.insertar[textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text]
           // this.clientesTableAdapter.Fill(this.inmobiliariaDataSet13.clientes);

      
       

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");
            
            DialogResult resultado= MessageBox.Show("¿Seguro desea eliminar cliente?","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            
           
            SqlCommand comando = new SqlCommand("Delete from clientes where dni_cliente=@dni_cliente", Conn);
            
            comando.Parameters.AddWithValue("dni_cliente", dataGridView1.CurrentRow.Cells["dni_cliente"].Value);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            Conn.Open();
            comando.ExecuteNonQuery();
            Conn.Close();

            MessageBox.Show("cliente borrado");




        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet3.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.inmobiliariaDataSet3.clientes);
            // TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet17.clientes' Puede moverla o quitarla según sea necesario.
          // this.clientesTableAdapter3.Fill(this.inmobiliariaDataSet17.clientes);

        }

        public static DataTable GetAllClientes()
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select dni_cliente,apellido,nombres,localidad,domicilio,telefono1,telefono2,email,cod_postal,observacion,nacionalidad,estado_civil,prohibiciones,garantia,tipocli from clientes";
            using (Conn)
            {
                Conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;


            }

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");
            
            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where dni_cliente like('%" + textBox15.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Conn.Close();
        }



        //validaciones

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.ToUpper();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.ToUpper();
        }

       


    /*   

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");
            
            try
            {
                

               
               


                Conn.Open();
                

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells["dni_cliente"].Value != null)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO clientes VALUES(@dni_cliente,@apellido,@nombres,@localidad,@domicilio,@telefono1,@telefono2,@email,@cod_postal,@observacion,@nacionalidad,@estado_civil,@prohibiciones,@garantia,@tipocli",Conn);
                        
                              cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@dni_cliente", Convert.ToString(row.Cells["dni_cliente"].Value));
                        cmd.Parameters.AddWithValue("@apellido", Convert.ToString(row.Cells["apellido"].Value));
                        cmd.Parameters.AddWithValue("@nombres", Convert.ToString(row.Cells["nombres"].Value));


                        cmd.Parameters.AddWithValue("@localidad", Convert.ToString(row.Cells["localidad"].Value));
                        cmd.Parameters.AddWithValue("@domicilio", Convert.ToString(row.Cells["domicilio"].Value));
                        cmd.Parameters.AddWithValue("@telefono1", Convert.ToString(row.Cells["telefono1"].Value));


                        cmd.Parameters.AddWithValue("@telefono2", Convert.ToString(row.Cells["telefono2"].Value));
                        cmd.Parameters.AddWithValue("@email", Convert.ToString(row.Cells["email"].Value));
                        cmd.Parameters.AddWithValue("@cod_postal", Convert.ToString(row.Cells["cod_postal"].Value));

                        cmd.Parameters.AddWithValue("@observacion", Convert.ToString(row.Cells["observacion"].Value));
                        cmd.Parameters.AddWithValue("@nacionalidad", Convert.ToString(row.Cells["nacionalidad"].Value));
                        cmd.Parameters.AddWithValue("@estado_civil", Convert.ToString(row.Cells["estado_civil"].Value));

                        cmd.Parameters.AddWithValue("@prohibiciones", Convert.ToString(row.Cells["prohibiciones"].Value));
                        cmd.Parameters.AddWithValue("@garantia", Convert.ToString(row.Cells["garantia"].Value));
                        cmd.Parameters.AddWithValue("@tipocli", (row.Cells["tipocli"].Value));




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


        



        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");

            Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
        */

        

       /* SECTOR DE VALIDACIONES : CAMPOS OBLIGATORIOS, SOLO NUMEROS Y SOLO LETRAS

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                epError.SetError(textBox3, "INTRODUCE EL NOMBRE DEL CLIENTE, CAMPO OBLIGATORIO");
                textBox3.Focus();

            }
            else
            {
                epError.Clear();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "")
            {
                epError.SetError(textBox4, "INTRODUCE EL LOCALIDAD DEL CLIENTE, CAMPO OBLIGATORIO");
                textBox4.Focus();

            }
            else
            {
                epError.Clear();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "")
            {
                epError.SetError(textBox5, "INTRODUCE EL DOMICILIO DEL CLIENTE, CAMPO OBLIGATORIO");
                textBox5.Focus();

            }
            else
            {
                epError.Clear();

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Trim() == "")
            {
                epError.SetError(textBox6, "INTRODUCE EL TELEFONO DEL CLIENTE, CAMPO OBLIGATORIO");
                textBox6.Focus();

            }
            else
            {
                epError.Clear();

            }
        }
        */

      
    }
    
    }

        

  //  private void ClickEnBoton(object sender, DataGridViewCellEventArgs e)
   //    {
   //        if (dataGridView1.CurrentCell.ColumnIndex==15)
   //        {
   //            var row = dataGridView1.CurrentRow;
    //           dataGridView1.Rows.Remove(row);
      //     }


       





    


  
    






// TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet15.clientes' Puede moverla o quitarla según sea necesario.
//this.clientesTableAdapter2.Fill(this.inmobiliariaDataSet15.clientes);
// TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet14.clientes' Puede moverla o quitarla según sea necesario.
//this.clientesTableAdapter1.Fill(this.inmobiliariaDataSet14.clientes);
// TODO: esta línea de código carga datos en la tabla 'inmobiliariaDataSet13.clientes' Puede moverla o quitarla según sea necesario.
// this.clientesTableAdapter.Fill(this.inmobiliariaDataSet13.clientes);

/*    private void button1_Click(object sender, EventArgs e)
    {
        string dni = textBox1.Text;
        string ape = textBox2.Text;
        string nom = textBox3.Text;
        string loc = textBox4.Text;
        string dom = textBox5.Text;
        string tel1 = textBox6.Text;
        string tel2 = textBox7.Text;
        string ema = textBox8.Text;
        string cod = textBox9.Text;
        string obs = textBox10.Text;
        string nac = textBox11.Text;
        string est = textBox12.Text;
        string pro = textBox13.Text;
        string gar = textBox14.Text;
        string tip = comboBox1.Text;

        SqlConnection Conn = new SqlConnection("Data source=MATIASMENCUCCI; Initial Catalog = inmobiliaria; User Id =sa; Password=12");

           


        SqlCommand comando = new SqlCommand("insert into clientes(dni_cliente,apellido,nombres,localidad,domicilio,telefono1,telefono2,email,cod_postal,observacion,nacionalidad,estado_civil,prohibiciones,garantia,tipocli)values(@dni_cliente,@apellido,@nombres,@localidad,@domicilio,@telefono1,@telefono2,@email,@cod_postal,@observacion,@nacionalidad,@estado_civil,@prohibiciones,@garantia,@tipocli)");
        comando.Connection = Conn;

        SqlParameter parametro1 = new SqlParameter();
        parametro1.ParameterName = "@dni_cliente";
        parametro1.Value = dni;

        comando.Parameters.Add(parametro1);

        SqlParameter parametro2 = new SqlParameter();
        parametro2.ParameterName = "@apellido";
        parametro2.Value = ape;

        comando.Parameters.Add(parametro2);

        SqlParameter parametro3 = new SqlParameter();
        parametro3.ParameterName = "@nombres";
        parametro3.Value = nom;

        comando.Parameters.Add(parametro3);

        SqlParameter parametro4 = new SqlParameter();
        parametro4.ParameterName = "@localidad";
        parametro4.Value = loc;

        comando.Parameters.Add(parametro4);

        SqlParameter parametro5 = new SqlParameter();
        parametro5.ParameterName = "@domicilio";
        parametro5.Value = dom;

        comando.Parameters.Add(parametro5);

        SqlParameter parametro6 = new SqlParameter();
        parametro6.ParameterName = "@telefono1";
        parametro6.Value = tel1;

        comando.Parameters.Add(parametro6);

        SqlParameter parametro7 = new SqlParameter();
        parametro7.ParameterName = "@telefono2";
        parametro7.Value = tel2;

        comando.Parameters.Add(parametro7);

        SqlParameter parametro8 = new SqlParameter();
        parametro8.ParameterName = "@email";
        parametro8.Value = ema;

        comando.Parameters.Add(parametro8);

        SqlParameter parametro9 = new SqlParameter();
        parametro9.ParameterName = "@cod_postal";
        parametro9.Value = cod;

        comando.Parameters.Add(parametro9);

        SqlParameter parametro10 = new SqlParameter();
        parametro10.ParameterName = "@observacion";
        parametro10.Value = obs;

        comando.Parameters.Add(parametro10);

        SqlParameter parametro11 = new SqlParameter();
        parametro11.ParameterName = "@nacionalidad";
        parametro11.Value = nac;

        comando.Parameters.Add(parametro11);

        SqlParameter parametro12 = new SqlParameter();
        parametro12.ParameterName = "@estado_civil";
        parametro12.Value = est;

        comando.Parameters.Add(parametro12);

        SqlParameter parametro13 = new SqlParameter();
        parametro13.ParameterName = "@prohibiciones";
        parametro13.Value = pro;

        comando.Parameters.Add(parametro13);

        SqlParameter parametro14 = new SqlParameter();
        parametro14.ParameterName = "@garantia";
        parametro14.Value = gar;

        comando.Parameters.Add(parametro14);

        SqlParameter parametro15 = new SqlParameter();
        parametro15.ParameterName = "@tipocli";
        parametro15.Value = tip;

        comando.Parameters.Add(parametro15);


        try
        {

            Conn.Open();
            comando.ExecuteNonQuery();

            MessageBox.Show("se ha agregado exitosamente el registro");


        }
        catch(Exception err) 
            
        {
            MessageBox.Show("se ha producido un error" + err + "");
            
            
        }
        Conn.Close();








        //  Me.clientesTableAdapter.insertar[textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text]
       // this.clientesTableAdapter.Fill(this.inmobiliariaDataSet13.clientes);

      
    }

    private void button2_Click(object sender, EventArgs e)
    {
       int fil = dataGridView1.CurrentRow.Index;
        dataGridView1.Rows.RemoveAt(fil);
    }


    public static DataTable GetAllClientes()
    {
        SqlConnection Conn = new SqlConnection("Data source=MATIASMENCUCCI; Initial Catalog = inmobiliaria; User Id =sa; Password=12");
        SqlCommand comando = new SqlCommand();
        comando.Connection = Conn;
        comando.CommandType = CommandType.Text;
        comando.CommandText = "select dni_cliente,apellido,nombres,localidad,domicilio,telefono1,telefono2,email,cod_postal,observacion,nacionalidad,estado_civil,prohibiciones,garantia,tipocli from clientes";
        using (Conn)
        {
            Conn.Open();
            SqlDataReader reader = comando.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
            
            
        }
        
    }
        









    private void textBox15_TextChanged(object sender, EventArgs e)
    {
        clientes.Tables[0].DefaultView.RowFilter = ("dni_cliente like '" + textBox15 + "%'");
        dataGridView1.DataSource = clientes.Tables[0].DefaultView;
        
        
    }


*/

