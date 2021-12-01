using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventario.Modelos
{
    class Compra
    {
        public int Codigo { get; set; }
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } // Cambiar a tipo Fecha.
        public DateTime FechaModificacion { get; set; }
        //Construtores
        public Compra(int codigo, Producto producto, int cantidad)
        {
            Codigo = codigo;
            CodigoProducto = producto.Codigo;
            NombreProducto = producto.Nombre;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
            FechaModificacion = DateTime.Now;

            producto.Suplir(Cantidad);
        }

        public Compra(int codigo, int codigoProducto, string nombreProducto, int cantidad, string fecha, string fechaModificacion)
        {
            Codigo = codigo;
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Fecha = DateTime.Parse(fecha);
            FechaModificacion = DateTime.Parse(fechaModificacion);
        }

        public Compra() { }

        public bool Modificar(int cantidad, Producto producto)
        {
            int modificacion = cantidad - Cantidad;

            if (producto.ModificarCantidad(modificacion))
            {
                FechaModificacion = DateTime.Now;
                Cantidad = cantidad;
                return Remplazar();
            }
            else
            {
                return false;
            }
        }

        public bool Borrar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText("Compras.txt");
                escribir = File.AppendText("Tempp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) != Codigo)
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Tempp.txt", "Compras.txt", true);
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
                escribir = File.AppendText("Compras.txt");
                escribir.WriteLine(ObtenerCompra());
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
                leer = File.OpenText("Compras.txt");
                escribir = File.AppendText("Tempp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) == Codigo)
                    {
                        escribir.WriteLine(ObtenerCompra());
                    }
                    else
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Tempp.txt", "Compras.txt", true);
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

        public string ObtenerCompra()
        {
            return Codigo + "#" + CodigoProducto + "#" + NombreProducto + "#" + Cantidad + "#" + Fecha.ToString() + "#" + FechaModificacion.ToString();
        }
    }
}
