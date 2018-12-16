using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ap_inmobiliaria
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data source=VAIO\\SQLEXPRESS; Initial Catalog = inmobiliaria;Integrated Security=True");

            Conn.Open();
             return Conn;


        }


    }
}
