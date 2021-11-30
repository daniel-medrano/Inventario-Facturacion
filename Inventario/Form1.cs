using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Inventario.Administradores;
using Inventario.Modelos;

namespace Inventario
{
    public partial class Form1 : Form
    {
        Button bttnActual;
        AdminProductos adminProductos;
        ListViewItem producto;
        

        public Form1()
        {
            InitializeComponent();
            bttnActual = bttnProductos;
            adminProductos = new AdminProductos();
            producto = null;
            Actualizar();
        }
        //Botón general para el boton home, productos, compras, etc.
        private void bttnGeneral_Click(object sender, EventArgs e)
        {

            //Pone al boton anterior como estaba por defecto.
            bttnActual.ForeColor = Color.Black;
            bttnActual.BackColor = Color.Transparent;
            //Cambia al boton actual.
            bttnActual = sender as Button;
            bttnActual.ForeColor = Color.DarkGreen;
            bttnActual.BackColor = Color.LightGreen;


        }


        private void bttnProductos_Click(object sender, EventArgs e)
        {
            //Pone al boton anterior como estaba por defecto.
            bttnActual.ForeColor = Color.Black;
            bttnActual.BackColor = Color.Transparent;
            //Cambia al boton actual.
            bttnActual = sender as Button;
            bttnActual.ForeColor = Color.DarkGreen;
            bttnActual.BackColor = Color.LightGreen;

            pnlProductos.BringToFront();
        }

        private void bttnCompras_Click(object sender, EventArgs e)
        {
            //Pone al boton anterior como estaba por defecto.
            bttnActual.ForeColor = Color.Black;
            bttnActual.BackColor = Color.Transparent;
            //Cambia al boton actual.
            bttnActual = sender as Button;
            bttnActual.ForeColor = Color.DarkGreen;
            bttnActual.BackColor = Color.LightGreen;

        }

        private void bttnVentas_Click(object sender, EventArgs e)
        {
            //Pone al boton anterior como estaba por defecto.
            bttnActual.ForeColor = Color.Black;
            bttnActual.BackColor = Color.Transparent;
            //Cambia al boton actual.
            bttnActual = sender as Button;
            bttnActual.ForeColor = Color.DarkGreen;
            bttnActual.BackColor = Color.LightGreen;
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            pnlNuevoP.BringToFront();
        
        }

        private void bttnBorrar_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = listView1.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 0)
            {
                MessageBox.Show("No selecciono productos.");
                return;
            } 

            foreach (ListViewItem producto in productos)
            {
                listView1.Items.Remove(producto);
                adminProductos.Borrar(producto.Text);
            }
        }
        //Método para enseñar el panel con los controles para modificar un producto.
        private void bttnModificar_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = listView1.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 1)
            {
                pnlModificarP.BringToFront();
                Producto producto = adminProductos.Buscar(productos[0].Text);
                txtCodModP.Text = producto.Codigo;
                txtNomModP.Text = producto.Nombre;
                txtDesModP.Text = producto.Descripcion;
                txtPreModP.Text = producto.Precio.ToString();
                txtCanModP.Text = producto.Cantidad.ToString();
            }
            else if (productos.Count > 1)
            {
                MessageBox.Show("Solo puede modificar un producto a la vez.");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto.");
            }
        }
        //Método para modificar definitivamente el producto.
        private void bttnModificarD_Click(object sender, EventArgs e)
        {
            string codigo = txtCodModP.Text;
            string nombre = txtNomModP.Text;
            string descripcion = txtDesModP.Text;
            double precio = double.Parse(txtPreModP.Text);
            int cantidad = int.Parse(txtCanModP.Text);
            adminProductos.Modificar(codigo, nombre, descripcion, precio, cantidad);
            pnlProductos.BringToFront();
            Actualizar();
        }
        //Método para cancelar la modificación de un producto.
        private void bttnCnlModificar_Click(object sender, EventArgs e)
        {
            pnlProductos.BringToFront();
            Limpiar();
        }

        private void bttnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtBoxCodigo.Text;
                string nombre = txtBoxNombre.Text;
                string descripcion = txtBoxDescripcion.Text;
                double precio = double.Parse(txtBoxPrecio.Text);
                int cantidad = int.Parse(txtBoxCantidad.Text);

                adminProductos.Crear(codigo, nombre, descripcion, precio, cantidad);
                Actualizar();

                pnlProductos.BringToFront();
                Limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnCnlNuevoP_Click(object sender, EventArgs e)
        {
            pnlProductos.BringToFront();
            Limpiar();
        }

        private void bttnGreen_MouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;

            bttn.BackColor = Color.LightGreen;
            bttn.ForeColor = Color.DarkGreen;
            

        }

        private void bttnRed_MouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;

            bttn.BackColor = Color.LightCoral;
            bttn.ForeColor = Color.DarkRed;


        }

        private void bttn_MouseLeave(object sender, EventArgs e)
        {
            Button bttn = sender as Button;

            if (bttn != bttnActual)
            {
                bttn.BackColor = Color.Transparent;
                bttn.ForeColor = Color.Black;
            }

        }
        //Método para actualizar los datos del listView.
        private void Actualizar()
        {
            //Se borran los items para volver ser cargados de la estrutura de datos.
            listView1.Items.Clear();
            //Se obtiene una lista con los objetos de clase Producto.
            List<Producto> productos = adminProductos.ObtenerProductos();
            //Se añade cada producto en productos al listView.
            foreach (Producto producto in productos)
            {
                ListViewItem i = new ListViewItem(producto.Codigo);
                i.ImageIndex = 2;
                i.SubItems.Add(producto.Nombre);
                i.SubItems.Add(producto.Descripcion);
                i.SubItems.Add(producto.Precio.ToString());
                i.SubItems.Add(producto.Cantidad.ToString());
                listView1.Items.Add(i);
            }
        }
        //Método para actualizar los datos del listView.
        private void Actualizar(List<Producto> productos)
        {
            //Se borran los items para volver ser cargados de la estrutura de datos.
            listView1.Items.Clear();
            //Se añade cada producto en productos al listView.
            foreach (Producto producto in productos)
            {
                ListViewItem i = new ListViewItem(producto.Codigo);
                i.ImageIndex = 2;
                i.SubItems.Add(producto.Nombre);
                i.SubItems.Add(producto.Descripcion);
                i.SubItems.Add(producto.Precio.ToString());
                i.SubItems.Add(producto.Cantidad.ToString());
                listView1.Items.Add(i);
            }
        }
        //Método para limpiar los textBox.
        private void Limpiar()
        {
            //Panel Nuevo Producto
            txtBoxCodigo.Text = "";
            txtBoxNombre.Text = "";
            txtBoxDescripcion.Text = "";
            txtBoxPrecio.Text = "";
            txtBoxCantidad.Text = "";
        }
        //Método para buscar los productos con un textBox. La manera de hacerlo considero que no es la más eficiente pero es la solución que aplique por cuestiones de tiempo.
        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            //Criterio de búsqueda. Buscará aquellos productos que empiezen por la string introducida.
            string busqueda = txtBuscarP.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                Actualizar();
                return;
            }

            List<Producto> productos = adminProductos.BuscarPorNombre(busqueda);
            if (productos.Count >= 1)
            {
                //Se carga el listView con una lista de productos que cumplen el criterio de búsqueda.
                Actualizar(productos);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                listView1.Items.Clear();
            }
        }
    }
}
