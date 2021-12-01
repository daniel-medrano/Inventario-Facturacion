using Inventario.Administradores;
using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        Button bttnActual;
        AdminProductos adminProductos;
        AdminCompras adminCompras;
        ListViewItem producto;
        

        public Form1()
        {
            InitializeComponent();
            bttnActual = bttnProductos;
            adminProductos = new AdminProductos();
            adminCompras = new AdminCompras();
            producto = null;
            ActualizarLsView(lsViewProductos);
            ActualizarComprasLsView();
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

            ActualizarLsView(lsViewProductos);
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

            ActualizarComprasLsView();
            pnlCompras.BringToFront();
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

        private void bttnNuevoProducto_Click(object sender, EventArgs e)
        {
            pnlNuevoP.BringToFront();
        
        }

        private void bttnBorrarProducto_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = lsViewProductos.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 0)
            {
                MessageBox.Show("No selecciono productos.");
                return;
            } 

            foreach (ListViewItem producto in productos)
            {
                lsViewProductos.Items.Remove(producto);
                adminProductos.Borrar(int.Parse(producto.Text));
            }
        }
        //Método para enseñar el panel con los controles para modificar un producto.
        private void bttnModificarProducto_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = lsViewProductos.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 1)
            {
                pnlModificarP.BringToFront();
                Producto producto = adminProductos.Buscar(int.Parse(productos[0].Text));
                txtCodModP.Text = producto.Codigo.ToString();
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
        //TODO <-------------------------------------------------------------------------------------------------------- Cubrir los posibles errores si se introduce una string en vez de una int o double.
        private void bttnModificarProductoDef_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodModP.Text);
            string nombre = txtNomModP.Text;
            string descripcion = txtDesModP.Text;
            double precio = double.Parse(txtPreModP.Text);
            int cantidad = int.Parse(txtCanModP.Text);
            adminProductos.Modificar(codigo, nombre, descripcion, precio, cantidad);
            pnlProductos.BringToFront();
            ActualizarLsView(lsViewProductos);
        }
        //Método para cancelar la modificación de un producto.
        private void bttnCnlModificarProducto_Click(object sender, EventArgs e)
        {
            pnlProductos.BringToFront();
            LimpiarPnlNuevoP();
        }

        private void bttnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtBoxCodigo.Text);
                string nombre = txtBoxNombre.Text;
                string descripcion = txtBoxDescripcion.Text;
                double precio = double.Parse(txtBoxPrecio.Text);
                int cantidad = int.Parse(txtBoxCantidad.Text);

                adminProductos.Crear(codigo, nombre, descripcion, precio, cantidad);
                ActualizarLsView(lsViewProductos);

                pnlProductos.BringToFront();
                LimpiarPnlNuevoP();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnCnlNuevoProducto_Click(object sender, EventArgs e)
        {
            pnlProductos.BringToFront();
            LimpiarPnlNuevoP();
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
        private void ActualizarLsView(ListView listView, List<Producto> productos = null)
        {

            ListView lsViewTemp = listView;
            //Se borran los items para volver ser cargados de la estrutura de datos.
            lsViewTemp.Items.Clear();

            if (productos == null)
            {
                productos = adminProductos.ObtenerProductos();
            }
            //Se añade cada producto en productos al listView.
            foreach (Producto producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.Codigo.ToString());
                item.ImageIndex = 2;
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Cantidad.ToString());
                lsViewTemp.Items.Add(item);
            }
        }

        private void ActualizarComprasLsView(List<Compra> compras = null)
        {

            ListView lsViewTemp = lsViewCompras;
            //Se borran los items para volver ser cargados de la estrutura de datos.
            lsViewTemp.Items.Clear();

            if (compras == null)
            {
                compras = adminCompras.ObtenerCompras();
            }
            //Se añade cada producto en productos al listView.
            foreach (Compra compra in compras)
            {
                ListViewItem item = new ListViewItem(compra.Codigo.ToString());
                item.ImageIndex = 2;
                item.SubItems.Add(compra.CodigoProducto.ToString());
                item.SubItems.Add(compra.NombreProducto);
                item.SubItems.Add(compra.Cantidad.ToString());
                item.SubItems.Add(compra.Fecha.Day + "/" + compra.Fecha.Month + "/" +compra.Fecha.Year);
                lsViewTemp.Items.Add(item);
            }
        }
        //Método para limpiar los textBox de productos.
        private void LimpiarPnlNuevoP()
        {
            //Panel Nuevo Producto
            txtBoxCodigo.Text = "";
            txtBoxNombre.Text = "";
            txtBoxDescripcion.Text = "";
            txtBoxPrecio.Text = "";
            txtBoxCantidad.Text = "";
        }

        private void LimpiarPnlSuplir()
        {
            //Panel Nuevo Producto
            txtCantidadSuplir.Text = "";
            txtBuscarSuplir.Text = "";
        }

        private void LimpiarPnlModificarCompra()
        {
            txtModificarCan.Text = "";
        }
        //Método para buscar los productos con un textBox. La manera de hacerlo considero que no es la más eficiente pero es la solución que aplique por cuestiones de tiempo.
        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            //Criterio de búsqueda. Buscará aquellos productos que empiezen por la string introducida.
            string busqueda = txtBuscarP.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                ActualizarLsView(lsViewProductos);
                return;
            }

            List<Producto> productos = adminProductos.BuscarPorNombre(busqueda);
            if (productos.Count >= 1)
            {
                //Se carga el listView con una lista de productos que cumplen el criterio de búsqueda.
                ActualizarLsView(lsViewProductos, productos);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                lsViewProductos.Items.Clear();
            }
        }

        private void txtBuscarSuplir_TextChanged(object sender, EventArgs e)
        {
            //Criterio de búsqueda. Buscará aquellos productos que empiezen por la string introducida.
            string busqueda = txtBuscarSuplir.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                ActualizarLsView(lsViewSeleccionarP);
                return;
            }

            List<Producto> productos = adminProductos.BuscarPorNombre(busqueda);
            if (productos.Count >= 1)
            {
                //Se carga el listView con una lista de productos que cumplen el criterio de búsqueda.
                ActualizarLsView(lsViewSeleccionarP, productos);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                lsViewSeleccionarP.Items.Clear();
            }
        }

        private void txtBuscarCompra_TextChanged(object sender, EventArgs e)
        {
            //Criterio de búsqueda. Buscará aquellas compras que empiecen por la string introducida.
            string busqueda = txtBuscarCompra.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                ActualizarComprasLsView();
                return;
            }

            List<Compra> compras = adminCompras.BuscarPorNombre(busqueda);
            if (compras.Count >= 1)
            {
                //Se carga el listView con una lista de productos que cumplen el criterio de búsqueda.
                ActualizarComprasLsView(compras);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                lsViewCompras.Items.Clear();
            }
        }

        private void bttnSuplir_Click(object sender, EventArgs e)
        {
            ActualizarLsView(lsViewSeleccionarP);
            pnlSuplir.BringToFront();
        }

        private void bttnSuplirDef_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = lsViewSeleccionarP.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 0)
            {
                MessageBox.Show("No selecciono productos.");
                return;
            }
            int codigo = int.Parse(txtCodigoCompra.Text);
            int cantidad = int.Parse(txtCantidadSuplir.Text); //TODO <-------------------------- MANEJAR EXCEPCIONES
            Producto productoComprado = adminProductos.Buscar(int.Parse(productos[0].Text));

            adminCompras.Crear(codigo, productoComprado, cantidad);
            ActualizarComprasLsView();
            pnlCompras.BringToFront();
        }

        private void bttnCnlSuplir_Click(object sender, EventArgs e)
        {
            pnlCompras.BringToFront();
            LimpiarPnlSuplir();
        }

        private void bttnBorrarCompra_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> compras = lsViewCompras.SelectedItems.Cast<ListViewItem>().ToList();

            if (compras.Count == 0)
            {
                MessageBox.Show("No selecciono registros de compras.");
                return;
            }

            foreach (ListViewItem compra in compras)
            {
                Compra compraEliminada = adminCompras.Buscar(int.Parse(compra.Text));
                if (adminProductos.Buscar(compraEliminada.CodigoProducto).Quitar(compraEliminada.Cantidad))
                {
                    lsViewCompras.Items.Remove(compra);
                    adminCompras.Borrar(compraEliminada.Codigo);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar la compra porque al parecer ya se vendieron productos.");
                }
            }
        }

        private void bttnModificarCompra_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> compras = lsViewCompras.SelectedItems.Cast<ListViewItem>().ToList();

            if (compras.Count == 1)
            {
                pnlModificarCompra.BringToFront();
                adminCompras.AgregarCompraUtilitaria(adminCompras.Buscar(int.Parse(compras[0].Text)));
                txtModificarCan.Text = adminCompras.CompraUtil.Cantidad.ToString();
            }
            else if (compras.Count > 1)
            {
                MessageBox.Show("Solo puede modificar un registo de compra a la vez.");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de compra.");
            }
        }

        private void bttnCnlModificarCompra_Click(object sender, EventArgs e)
        {

            pnlCompras.BringToFront();
            LimpiarPnlModificarCompra();
        }

        private void bttnModificarCompraDef_Click(object sender, EventArgs e)
        {
            Producto producto = adminProductos.Buscar(adminCompras.CompraUtil.CodigoProducto);
            if (!adminCompras.CompraUtil.Modificar(int.Parse(txtModificarCan.Text), producto))
            {
                MessageBox.Show("No se pudo modificar porque ya se han vendido productos.");
            }
            ActualizarComprasLsView();
            pnlCompras.BringToFront();
            LimpiarPnlModificarCompra();
        }
    }
}
