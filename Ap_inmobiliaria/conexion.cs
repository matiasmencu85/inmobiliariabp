using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ap_inmobiliaria
{
    class conexion
    {


        public string cadenaconexion;
        protected string sql;
       // protected int resultado;
        protected SqlConnection con;
        protected SqlCommand comandosql;
        protected string mensaje;


        public conexion()
        {

            this.cadenaconexion = (@"Data source = VAIO\SQLEXPRESS ;Initial Catalog = inmobiliaria; integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }

    }
}
