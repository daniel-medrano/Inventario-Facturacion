using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        //public Clase Imagen {get; set;} OPCIONAL
    }
}
