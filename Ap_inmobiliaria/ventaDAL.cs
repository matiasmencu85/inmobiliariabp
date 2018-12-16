using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Ap_inmobiliaria
{
    public class ventaDAL
    {

        public static int Agregar(venta pventa)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into venta (dni_cliente,localidad,domicilio,tipo,ambientes,precio,fecha_alta,detalles)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                   pventa.dni_cliente, pventa.localidad, pventa.domicilio, pventa.tipo, pventa.ambientes, pventa.precio, pventa.fecha_alta, pventa.detalles), Conn);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }

        public static List <venta> buscarVenta(String ptipo, String pambientes)
        {
            List<venta> Lista = new List<venta>();
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                        "Select id, dni_cliente,localidad,domicilio,tipo,ambientes,precio,fecha_alta,detalles from venta where tipo like'%{0}%' and ambientes like '%{1}%' ", ptipo, pambientes), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    venta pventa = new venta();
                    pventa.id = reader.GetInt64(0);
                    pventa.dni_cliente = reader.GetString(1);
                    pventa.localidad = reader.GetString(2);
                    pventa.domicilio = reader.GetString(3);
                    pventa.tipo = reader.GetString(4);
                    pventa.ambientes = reader.GetString(5);
                    pventa.precio = Convert.ToString(reader.GetDecimal(6));
                    pventa.fecha_alta = Convert.ToString(reader.GetDateTime(7));
                    pventa.detalles = reader.GetString(8);

                    Lista.Add(pventa);



                }
                conexion.Close();
                return Lista;

            }

        }



        public static venta Obtenerventa(Int64 pid)
        {
            
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                venta pventa = new venta();
                SqlCommand comando = new SqlCommand(string.Format(
                        "Select id, dni_cliente,localidad,domicilio,tipo,ambientes,precio,fecha_alta,detalles from venta where id={0}",pid), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    
                    pventa.id = reader.GetInt64(0);
                    pventa.dni_cliente = reader.GetString(1);
                    pventa.localidad = reader.GetString(2);
                    pventa.domicilio = reader.GetString(3);
                    pventa.tipo = reader.GetString(4);
                    pventa.ambientes = reader.GetString(5);
                    pventa.precio = Convert.ToString(reader.GetDecimal(6));
                    pventa.fecha_alta = Convert.ToString(reader.GetDateTime(7));
                    pventa.detalles = reader.GetString(8);

                   



                }
                conexion.Close();
                return pventa;

            }

        }


        public static int Modificar(venta pVenta)
        {
            int retorno = 0; 
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            { 
            SqlCommand comando = new SqlCommand(string.Format("Update venta set dni_cliente='{0}',localidad='{1}',domicilio='{2}',tipo='{3}',ambientes='{4}',precio='{5}',fecha_alta='{6}',detalles='{7}'where id={8}",pVenta.dni_cliente,pVenta.localidad,pVenta.domicilio,pVenta.tipo,pVenta.ambientes,pVenta.precio,pVenta.fecha_alta,pVenta.detalles,pVenta.id),conexion);
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
                SqlCommand comando = new SqlCommand(string.Format("Delete from venta where id={0}", pid), conexion);
                retorno= comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }








    }

    }






    





