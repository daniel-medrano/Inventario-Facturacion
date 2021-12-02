using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Modelos;
using System.IO;

namespace Inventario.Administradores
{
    class AdminProductos
    {

        private List<Producto> productos;

        public AdminProductos()
        {
            productos = new List<Producto>();
            Cargar();
            
        }
        //Crea un nuevo producto y lo agrega a productos.
        public bool Crear(int codigo, string nombre, string descripcion, double precio, int cantidad)
        {
            Producto producto = Buscar(codigo);

            if (producto == null)
            {
                Producto nuevo = new Producto(codigo, nombre, descripcion, precio, cantidad);
                nuevo.Insertar();
                productos.Add(nuevo);
                return true;

            }
            return false;
        }

        public bool Borrar(int codigo)
        {
            Producto producto = Buscar(codigo);
            if (producto != null)
            {
                producto.Borrar();
                productos.Remove(producto);
                return true;

            }
            return false;
        }

        public bool Modificar(int codigo, string nombre, string descripcion, double precio, int cantidad)
        {
            Producto producto = Buscar(codigo);
            if (producto != null)
            {
                return producto.Modificar(nombre, descripcion, precio, cantidad);
            }
            return false;
        }

        public Producto Buscar(int codigo)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Codigo == codigo)
                {
                    return producto;
                }
            }
            return null;
        }

        public List<Producto> BuscarPorNombre(string texto)
        {
            //Cantidad de caracteres del texto
            int cantidadChars = texto.Length;
            //Productos que cumplan con el criterio seran devueltos en una lista.
            List<Producto> busquedas = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Length >= cantidadChars)
                {
                    string nombre = producto.Nombre.Substring(0, cantidadChars).ToLower();

                    //Compara una porción del nombre si es necesario con el texto.
                    if (nombre.Equals(texto))
                    {
                        busquedas.Add(producto);
                    }
                }
            }
            return busquedas;            
        }

        private bool CargarProducto(int codigo, string nombre, string descripcion, double precio, int cantidad)
        {
            Producto producto = Buscar(codigo);

            if (producto == null)
            {
                productos.Add(new Producto(codigo, nombre, descripcion, precio, cantidad));
                return true;

            }
            return false;
        }

        public bool Cargar()
        {
            StreamReader leer = null;
            try
            {
                leer = File.OpenText("Productos.txt");

                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    CargarProducto(int.Parse(partes[0]), partes[1], partes[2], double.Parse(partes[3]), int.Parse(partes[4]));

                    linea = leer.ReadLine();
                }
                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (leer != null)
                {
                    leer.Close();
                }
            }
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        public double ObtenerTotal(List<int[]> productosVenta)
        {
            double subtotal = ObtenerSubtotal(productosVenta);
            double impuestos = subtotal * 0.13;
            return subtotal + impuestos;
        }

        public double ObtenerSubtotal(List<int[]> productosVenta)
        {
            double subtotal = 0;

            foreach (int[] registro in productosVenta)
            {
                Producto producto = Buscar(registro[0]);

                subtotal += producto.ObtenerPrecioPorCantidad(registro[1]);
            }
            return subtotal;
        }


        public void RealizarVenta(List<int[]> productosVenta)
        {
            Producto producto = null;

            foreach (int[] registro in productosVenta)
            {
                producto = Buscar(registro[0]);

                producto.Cantidad -= registro[1];
                producto.Remplazar();
            }
        }

        public void DeshacerVenta(List<int[]> productosVenta)
        {
            Producto producto = null;

            foreach (int[] registro in productosVenta)
            {
                producto = Buscar(registro[0]);
                if (producto == null)
                {
                    continue;
                }
                producto.Cantidad += registro[1];
                producto.Remplazar();
            }
        }
    }
}
