using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ap_inmobiliaria
{
    class UsuariosDAL
    {
    
        public static int CrearCuentas(string pUsuario, string pcontraseña,string ptipo)
        {
            int resultado = 0;
            SqlConnection Conn = BDComun.ObtenerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuarios(Nombre,Contraseña,Tipo) values('{0}','{1}','{2}')", pUsuario, pcontraseña, ptipo), Conn);
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();
            return resultado;
      
        
        }


        public static int Autentificar(String pusuarios, String pcontraseña, String ptipo)
        {
            int resultado = -1;
            SqlConnection conexion = BDComun.ObtenerConexion();
            
                SqlCommand comando = new SqlCommand(string.Format(
                 "Select * From Usuarios where Nombre = '{0}' and PwdCompare( '{1}',Contraseña)=1,Tipo ='{2}'  ", pusuarios, pcontraseña, ptipo), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    resultado = 50;
                }

                conexion.Close();
                return resultado;
        
        }




    }
}
