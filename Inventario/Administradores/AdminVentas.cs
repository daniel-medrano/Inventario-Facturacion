using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Inventario.Modelos;

namespace Inventario.Administradores
{
    class AdminVentas
    {
        List<Venta> ventas;

        public AdminVentas()
        {
            ventas = new List<Venta>();
            Cargar();
        }

        //Crea un nuevo producto y lo agrega a productos.
        public bool Crear(int numero, string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total, List<int[]> productosVenta)
        {
            Venta venta = Buscar(numero);

            if (venta == null)
            {
                Venta nueva = new Venta(numero, nombreCliente, correoCliente, telefonoCliente, subtotal, total, productosVenta);
                nueva.Insertar();
                ventas.Add(nueva);
                return true;

            }
            return false;
        }

        public bool Borrar(int numero)
        {
            Venta venta = Buscar(numero);
            if (venta != null)
            {
                venta.Borrar();
                ventas.Remove(venta);
                return true;

            }
            return false;
        }

        public bool Modificar(int numero, string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total)
        {
            Venta venta = Buscar(numero);
            if (venta != null)
            {
                return venta.Modificar(nombreCliente, correoCliente, telefonoCliente, subtotal, total);
            }
            return false;
        }

        public Venta Buscar(int numero)
        {
            foreach (Venta venta in ventas)
            {
                if (venta.Numero == numero)
                {
                    return venta;
                }
            }
            return null;
        }

        public List<Venta> BuscarPorNombre(string texto)
        {
            //Cantidad de caracteres del texto
            int cantidadChars = texto.Length;
            //Productos que cumplan con el criterio seran devueltos en una lista.
            List<Venta> busquedas = new List<Venta>();

            foreach (Venta venta in ventas)
            {
                if (venta.NombreCliente.Length >= cantidadChars)
                {
                    string nombre = venta.NombreCliente.Substring(0, cantidadChars).ToLower();

                    //Compara una porción del nombre si es necesario con el texto.
                    if (nombre.Equals(texto))
                    {
                        busquedas.Add(venta);
                    }
                }
            }
            return busquedas;
        }

        private bool CargarVenta(int numero, string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total, List<int[]> productos)
        {
            Venta venta = Buscar(numero);

            if (venta == null)
            {
                ventas.Add(new Venta(numero, nombreCliente, correoCliente, telefonoCliente, subtotal, total, productos));
                return true;

            }
            return false;
        }

        public bool Cargar()
        {
            StreamReader leer = null;
            try
            {
                leer = File.OpenText("Ventas.txt");

                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] partes = linea.Split('#');
                    List<int[]> productosVenta = CargarProductosDeVenta(partes);
                    
                    CargarVenta(int.Parse(partes[0]), partes[1], partes[2], int.Parse(partes[3]), double.Parse(partes[4]), double.Parse(partes[5]), productosVenta);

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

        public List<int[]> CargarProductosDeVenta(string[] partes)
        {
            List<int[]> productosVenta = new List<int[]>();

            for (int i = 7; i < partes.Length; i += 2)
            {
                productosVenta.Add(new int[] { int.Parse(partes[i]), int.Parse(partes[i + 1]) });
            }
            return productosVenta;
        }

        public List<Venta> ObtenerVentas()
        {
            return ventas;
        }

        public bool Facturar(int numero) 
        {
            Venta venta = Buscar(numero);
            return venta.Facturar();
        }

    }
}
