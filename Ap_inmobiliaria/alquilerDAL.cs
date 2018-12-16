using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ap_inmobiliaria
{
    class alquilerDAL
    {


        public static int Agregar(alquiler palquiler)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into alquiler (dni_cliente,localidad,domicilio,tipo,ambientes,precio,estado,detalles,prohibiciones,inventario,fecha_ini,fecha_fin)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                   palquiler.dni_cliente, palquiler.localidad, palquiler.domicilio, palquiler.tipo, palquiler.ambientes, palquiler.precio, palquiler.estado, palquiler.detalles, palquiler.prohibiciones, palquiler.inventario, palquiler.fecha_ini, palquiler.fecha_fin), Conn);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }

        public static List<alquiler> Buscaralquiler(String ptipo, String pambientes)
        {
            List<alquiler> Lista = new List<alquiler>();
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                        "Select id, dni_cliente,localidad,domicilio,tipo,ambientes,precio,estado,detalles,prohibiciones,inventario,fecha_ini,fecha_fin from alquiler where tipo like'%{0}%' and ambientes like '%{1}%' ", ptipo, pambientes), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    alquiler palquiler = new alquiler();
                    palquiler.id = reader.GetInt64(0);
                    palquiler.dni_cliente = reader.GetString(1);
                    palquiler.localidad = reader.GetString(2);
                    palquiler.domicilio = reader.GetString(3);
                    palquiler.tipo = reader.GetString(4);
                    palquiler.ambientes = reader.GetString(5);
                                    
                   palquiler.precio = Convert.ToString(reader.GetDecimal(6));
                   palquiler.estado = reader.GetString(7);
                   palquiler.detalles = reader.GetString(8);
                   palquiler.prohibiciones = reader.GetString(9);
                    palquiler.inventario = reader.GetString(10);
                    palquiler.fecha_ini = Convert.ToString(reader.GetDateTime(11));
                    palquiler.fecha_fin = Convert.ToString(reader.GetDateTime(12));

                    Lista.Add (palquiler);



                }
                conexion.Close();
                return Lista;

            }

        }



        public static alquiler Obteneralquiler(Int64 pid)
        {

            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                alquiler palquiler = new alquiler();
                SqlCommand comando = new SqlCommand(string.Format(
                        "Select id, dni_cliente,localidad,domicilio,tipo,ambientes,precio,estado,inventario,prohibiciones,detalles,fecha_ini,fecha_fin from alquiler where id={0}", pid), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    palquiler.id = reader.GetInt64(0);
                    palquiler.dni_cliente = reader.GetString(1);
                    palquiler.localidad = reader.GetString(2);
                    palquiler.domicilio = reader.GetString(3);
                    palquiler.tipo = reader.GetString(4);
                    palquiler.ambientes = reader.GetString(5);

                    palquiler.precio = Convert.ToString(reader.GetDecimal(6));
                    palquiler.estado = reader.GetString(7);
                    palquiler.detalles = reader.GetString(8);
                    palquiler.prohibiciones = reader.GetString(9);
                    palquiler.inventario = reader.GetString(10);
                    palquiler.fecha_ini = Convert.ToString(reader.GetDateTime(11));
                    palquiler.fecha_fin = Convert.ToString(reader.GetDateTime(12));



                }
                conexion.Close();
                return palquiler;

            }

        }


        public static int Modificar(alquiler palquiler)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
               SqlCommand comando = new SqlCommand(string.Format("Update alquiler set dni_cliente='{0}',localidad='{1}',domicilio='{2}',tipo='{3}',ambientes='{4}',precio='{5}',estado='{6}',detalles='{7}',prohibiciones='{8}',inventario='{9}',fecha_ini='{10}',fecha_fin='{11}'where id={12}", palquiler.dni_cliente, palquiler.localidad, palquiler.domicilio, palquiler.tipo, palquiler.ambientes, palquiler.precio, palquiler.estado, palquiler.detalles, palquiler.prohibiciones,palquiler.inventario,palquiler.fecha_ini,palquiler.fecha_fin,palquiler.id), conexion);
               retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }

            return retorno;

      }


        public static int eliminar(Int64 pid)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete from alquiler where id={0}", pid), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }









    }
}
