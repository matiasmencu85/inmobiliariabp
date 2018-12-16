using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ap_inmobiliaria
{
    class Usuarios:conexion
    {
        
        private string usuario;
        private string contraseña;
        private string tipo;
        public Usuarios()
        {
            
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;
        }
       

        public string Usuario
        {

            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }
        }





        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select id from Usuarios where Nombre='{0}' and Contraseña='{1}' and Tipo ='{2}'", this.usuario, this.contraseña, this.tipo);
            this.comandosql = new SqlCommand(this.sql, this.con);
            this.con.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();

            if (Reg.Read())
            {
                Resultado = true;
                this.mensaje = "BIENVENIDO LOS DATOS INGRESADOS SON CORRECTOS";

            }
            else
            {
                this.mensaje = "DATOS INCORRECTOS, VERIFICAR POR FAVOR";
            }

            this.con.Close();
            return Resultado;
        }





    }
}
