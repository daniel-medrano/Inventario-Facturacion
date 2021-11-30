using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    class Compra
    {
        public string Codigo { get; set; } 
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } // Cambiar a tipo Fecha.
        //Construtores
        public Compra(string codigo, int cantidad)
        {
            Codigo = codigo;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }

        public Compra() { }

        public void Modificar() { }
        public void Borrar() { }
        public void Insertar() { }
        public void Remplazar() { }
        public void ObtenerVenta() { }
    }
}
