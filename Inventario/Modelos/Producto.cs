using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventario.Modelos
{
    class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        //public Clase Imagen {get; set;} OPCIONAL

        public Producto(int codigo, string nombre, string descripcion, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }

        public Producto() { }

        public bool Modificar(string nombre, string descripcion, double precio, int cantidad)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            return Remplazar();
        }

        public bool Borrar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText("Productos.txt");
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
                File.Copy("Tempp.txt", "Productos.txt", true);
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
                escribir = File.AppendText("Productos.txt");
                escribir.WriteLine(ObtenerProducto());
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

        public bool Remplazar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText("Productos.txt");
                escribir = File.AppendText("Tempp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) == Codigo)
                    {
                        escribir.WriteLine(ObtenerProducto());
                    }
                    else
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Tempp.txt", "Productos.txt", true);
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
        //Método para aumentar la cantidad del producto.
        public void Suplir(int cantidad)
        {
            Cantidad += cantidad;
            Remplazar();
        }
        //Método para reducir la cantidad del producto.
        public bool Quitar(int cantidad)
        {
            if (Cantidad - cantidad >= 0)
            {
                Cantidad -= cantidad;
                Remplazar();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ObtenerProducto()
        {
            return Codigo + "#" + Nombre + "#" + Descripcion + "#" + Precio + "#" + Cantidad;
        }

        public double ObtenerPrecioPorCantidad(int cantidad)
        {
            return Precio * cantidad;
        }

        public bool ModificarCantidad(int cantidad)
        {
            int nuevaCantidad = Cantidad + cantidad;
            if (nuevaCantidad >= 0)
            {
                Cantidad = nuevaCantidad;
                Remplazar();
                return true;
            }
            return false;
        }
    }
}
