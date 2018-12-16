using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_inmobiliaria
{
   public class venta
    {


       public Int64 id {get;set;}
       public String dni_cliente { get; set; }
       public String localidad { get; set; }
       public String domicilio { get; set; }
       public String tipo { get; set; }
       public String ambientes { get; set; }
       public String precio { get; set; }
       public String fecha_alta { get; set; }
       public String detalles{ get; set; }


       public venta() { }

       public venta(Int64 pid, String pdni_dueño, String plocalidad, String pdomicilio, String ptipo, String pambientes, String pprecio, String pfecha_alta, String pdetalles)
   {
   
   this.id = pid;
   this.dni_cliente = pdni_dueño;
   this.localidad = plocalidad;
   this.domicilio = pdomicilio;
   this.tipo = ptipo;
   this.ambientes = pambientes;
   this.precio = pprecio;
   this.fecha_alta = pfecha_alta;
   this.detalles = pdetalles;
   }


     
    }
}
