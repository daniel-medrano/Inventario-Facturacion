using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Modelos;
using System.IO;

namespace Inventario.Administradores
{
    class AdminCompras
    {
        private List<Compra> compras;
        public Compra CompraUtil { get; set; }

        public AdminCompras()
        {
            compras = new List<Compra>();
            CompraUtil = null;
            Cargar();

        }
        //Crea un nuevo producto y lo agrega a productos.
        public bool Crear(int codigo, Producto producto, int cantidad)
        {
            Compra compra = Buscar(codigo);

            if (compra == null)
            {
                Compra nueva = new Compra(codigo, producto, cantidad);
                nueva.Insertar();
                compras.Add(nueva);
                return true;

            }
            return false;
        }

        public bool Borrar(int codigo)
        {
            Compra compra = Buscar(codigo);
            if (compra != null)
            {
                compra.Borrar();
                compras.Remove(compra);
                return true;

            }
            return false;
        }

        public bool Modificar(int codigo, Producto producto, int cantidad)
        {
            Compra compra = Buscar(codigo);
            if (compra != null)
            {
                return compra.Modificar(cantidad, producto);
            }
            return false;
        }

        public Compra Buscar(int codigo)
        {
            foreach (Compra compra in compras)
            {
                if (compra.Codigo == codigo)
                {
                    return compra;
                }
            }
            return null;
        }

        public List<Compra> BuscarPorNombre(string texto)
        {
            //Cantidad de caracteres del texto
            int cantidadChars = texto.Length;
            //Productos que cumplan con el criterio seran devueltos en una lista.
            List<Compra> busquedas = new List<Compra>();

            foreach (Compra compra in compras)
            {
                if (compra.NombreProducto.Length >= cantidadChars)
                {
                    string nombre = compra.NombreProducto.Substring(0, cantidadChars).ToLower();

                    //Compara una porción del nombre si es necesario con el texto.
                    if (nombre.Equals(texto))
                    {
                        busquedas.Add(compra);
                    }
                }
            }
            return busquedas;
        }

        private bool CargarProducto(int codigo, int codigoProducto, string nombreProducto, int cantidad, string fecha, string fechaModificacion)
        {
            Compra compra  = Buscar(codigo);

            if (compra == null)
            {
                compras.Add(new Compra(codigo, codigoProducto, nombreProducto, cantidad, fecha, fechaModificacion));
                return true;

            }
            return false;
        }

        public bool Cargar()
        {
            StreamReader leer = null;
            try
            {
                leer = File.OpenText("Compras.txt");

                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    CargarProducto(int.Parse(partes[0]), int.Parse(partes[1]), partes[2], int.Parse(partes[3]), partes[4], partes[5]);

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

        public List<Compra> ObtenerCompras()
        {
            return compras;
        }

        public void AgregarCompraUtilitaria(Compra compra)
        {
            CompraUtil = compra;
        }

    }
}
