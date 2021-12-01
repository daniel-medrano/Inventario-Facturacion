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

        private double impuestos = 0.13;
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


        public bool Modificar(int numero, string nombreCliente, string correoCliente, int telefonoCliente, double subtotal, double total)
        {
            Numero = numero;
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
            return Numero + "#" + NombreCliente + "#" + CorreoCliente + "#" + TelefonoCliente + "#" + Subtotal + "#" + Total + "#" + Fecha.ToString();
        }


    }
}
