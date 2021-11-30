using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    class Venta
    {
        public int Numero { get; set; }
        public string NombreCliente { get; set; }
        public string CorreoCliente { get; set; }
        public int TelefonoCliente { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }

        //Constructores
        public Venta(int numero, string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total)
        {
            Numero = numero;
            NombreCliente = nombreCliente;
            CorreoCliente = correoCliente;
            TelefonoCliente = telefonoCliente;
            Subtotal = subtotal;
            Total = total;
            Fecha = DateTime.Now;
        }

        public Venta() { }

        public void Modificar() { }
        public void Borrar() { }
        public void Insertar() { }
        public void Remplazar() { }
        public void ObtenerVenta() { }

    }
}
