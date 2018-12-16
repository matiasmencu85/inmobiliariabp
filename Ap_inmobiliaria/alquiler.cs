using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_inmobiliaria
{
    public class alquiler
    {


        public Int64 id { get; set; }
        public String dni_cliente { get; set; }
        public String localidad { get; set; }
        public String domicilio { get; set; }
        public String tipo { get; set; }
        public String ambientes { get; set; }
        public String precio { get; set; }
        public String estado { get; set; }
        public String detalles { get; set; }
        public String prohibiciones { get; set; }
        public String inventario { get; set; }
        public String fecha_ini { get; set; }
        public String fecha_fin { get; set; }

        public alquiler() { }

        public alquiler(Int64 pid, String pdni_dueño, String plocalidad, String pdomicilio, String ptipo, String pambientes, String pprecio, String pestado, String pdetalles, String pprohibiciones, String pinventario, String pfecha_ini, String pfecha_fin)
        {

            this.id = pid;
            this.dni_cliente = pdni_dueño;
            this.localidad = plocalidad;
            this.domicilio = pdomicilio;
            this.tipo = ptipo;
            this.ambientes = pambientes;
            this.precio = pprecio;
            this.estado = pestado;
            this.detalles = pdetalles;
            this.prohibiciones = pprohibiciones;
            this.inventario = pinventario;
            this.fecha_ini = pfecha_ini;
            this.fecha_fin = pfecha_fin;

        }

    }
}