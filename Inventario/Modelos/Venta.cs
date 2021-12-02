using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public List<int[]> Productos { get; set; }
        private static double impuesto = 0.13;
        //Constructores
        public Venta(int numero, string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total, List<int[]> productos)
        {
            Numero = numero;
            NombreCliente = nombreCliente;
            CorreoCliente = correoCliente;
            TelefonoCliente = telefonoCliente;
            Subtotal = subtotal;
            Total = total;
            Fecha = DateTime.Now;

            Productos = productos;
        }

        public Venta() { }


        public bool Modificar(string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total)
        {
            NombreCliente = nombreCliente;
            CorreoCliente = correoCliente;
            TelefonoCliente = telefonoCliente;
            Subtotal = subtotal;
            Total = total;
            return Remplazar();
        }

        public bool Borrar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText("Ventas.txt");
                escribir = File.AppendText("Tempp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) != Numero)
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Tempp.txt", "Ventas.txt", true);
                File.Delete("Tempp.txt");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (leer != null)
                    leer.Close();
                if (escribir != null)
                    escribir.Close();
            }
        }

        public bool Insertar()
        {
            StreamWriter escribir = null;

            try
            {
                escribir = File.AppendText("Ventas.txt");
                escribir.WriteLine(ObtenerVenta());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (escribir != null)
                {
                    escribir.Close();
                }
            }
        }

        private bool Remplazar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText("Ventas.txt");
                escribir = File.AppendText("Tempp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) == Numero)
                    {
                        escribir.WriteLine(ObtenerVenta());
                    }
                    else
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Tempp.txt", "Ventas.txt", true);
                File.Delete("Tempp.txt");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (leer != null)
                    leer.Close();
                if (escribir != null)
                    escribir.Close();
            }
        }
        public string ObtenerVenta()
        {
            string productosVenta = ObtenerProductos();

            return Numero + "#" + NombreCliente + "#" + CorreoCliente + "#" + TelefonoCliente + "#" + Subtotal + "#" + Total + "#" + Fecha.ToString() + "#" + ObtenerProductos();
        }

        private string ObtenerProductos()
        {
            string productos = "";
            int[] ultimoRegistro = Productos[Productos.Count - 1];

            foreach (int[] registro in Productos)
            {
                if (registro == ultimoRegistro)
                {
                    productos += registro[0] + "#" + registro[1];
                }
                else
                {
                    productos += registro[0] + "#" + registro[1] + "#";

                }
            }
            return productos;
        }

        private string ObtenerProductosFactura()
        {
            string productos = "";
            int[] ultimoRegistro = Productos[Productos.Count - 1];

            foreach (int[] registro in Productos)
            {

                productos += "Código: " + registro[0] + "\n" + "Cantidad: " + registro[1] + "\n\n";
            }
            return productos;
        }

        public int ObtenerCantidad()
        {
            return Productos.Count;
        }

        public string Factura()
        {
            return "FACTURA\n" +
                "Número de Factura: " + Numero + "\n\n" +
                "DATOS DEL CLIENTE\n" +
                "Nombre: " + NombreCliente + "\n" +
                "Correo: " + CorreoCliente + "\n" +
                "Teléfono: " + TelefonoCliente + "\n\n" +
                "PRODUCTOS\n" +
                ObtenerProductosFactura() +
                "Subtotal: " + Subtotal + "\n" +
                "Total: " + Total + "\n";
        }

        public bool Facturar()
        {
            StreamWriter escribir = null;

            try
            {
                if (File.Exists("Factura.txt"))
                {
                    File.Delete("Factura.txt");
                }
                escribir = File.AppendText("Factura.txt");
                escribir.WriteLine(Factura());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (escribir != null)
                {
                    escribir.Close();
                }
            }
        }

    }
}
