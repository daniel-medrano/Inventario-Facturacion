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
        AdminVentas adminVentas;
        
        public Form1()
        {
            InitializeComponent();
            bttnActual = bttnHome;
            bttnActual.ForeColor = Color.DarkGreen;
            bttnActual.BackColor = Color.LightGreen;
            adminProductos = new AdminProductos();
            adminCompras = new AdminCompras();
            adminVentas = new AdminVentas();
            ActualizarLsView(lsViewProductos);
            ActualizarComprasLsView();
            ActualizarVentasLsView();
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

            pnlHome.BringToFront();
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

            pnlVentas.BringToFront();
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

        private void ActualizarVentasLsView(List<Venta> ventas = null)
        {

            ListView lsViewTemp = lsViewVentas;
            //Se borran los items para volver ser cargados de la estrutura de datos.
            lsViewTemp.Items.Clear();

            if (ventas == null)
            {
                ventas = adminVentas.ObtenerVentas();
            }
            //Se añade cada venta en ventas al listView.
            foreach (Venta venta in ventas)
            {
                ListViewItem item = new ListViewItem(venta.Numero.ToString());
                item.ImageIndex = 2;
                item.SubItems.Add(venta.NombreCliente);
                item.SubItems.Add(venta.CorreoCliente);
                item.SubItems.Add(venta.TelefonoCliente.ToString());
                item.SubItems.Add(venta.ObtenerCantidad().ToString());
                item.SubItems.Add(venta.Subtotal.ToString());
                item.SubItems.Add(venta.Total.ToString());
                item.SubItems.Add(venta.Fecha.Day + "/" + venta.Fecha.Month + "/" + venta.Fecha.Year);
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
            txtCodigoCompra.Text = "";
        }

        private void LimpiarPnlVender()
        {
            lsViewProdV2.Items.Clear();
            txtNumeroVenta.Text = "";
            txtNombreCliente.Text = "";
            txtCorreoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtCantidadVenta.Text = "";
            lblTotal.Text = "0";
        }

        private void LimpiarPnlModificarCompra()
        {
            txtModificarCan.Text = "";
        }

        //CONTROLES DE BÚSQUEDA ---------------------------------------------------------
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

        private void txtBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            //Criterio de búsqueda. Buscará aquellas compras que empiecen por la string introducida.
            string busqueda = txtBuscarVenta.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                ActualizarVentasLsView();
                return;
            }

            List<Venta> ventas = adminVentas.BuscarPorNombre(busqueda);
            if (ventas.Count >= 1)
            {
                //Se carga el listView con una lista de productos que cumplen el criterio de búsqueda.
                ActualizarVentasLsView(ventas);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                lsViewVentas.Items.Clear();
            }
        }

        private void txtBuscarProductoVender_TextChanged(object sender, EventArgs e)
        {
            //Criterio de búsqueda. Buscará aquellas compras que empiecen por la string introducida.
            string busqueda = txtBuscarProductoVender.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                ActualizarLsView(lsViewProdV1);
                return;
            }

            List<Producto> productos = adminProductos.BuscarPorNombre(busqueda);
            if (productos.Count >= 1)
            {
                //Se carga el listView con una lista de productos que cumplen el criterio de búsqueda.
                ActualizarLsView(lsViewProdV1, productos);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                lsViewProdV1.Items.Clear();
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
            int codigo = 0;
            int cantidad = 0;
            Producto productoComprado = null;
            List<ListViewItem> productos = lsViewSeleccionarP.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 0)
            {
                MessageBox.Show("No selecciono productos.");
                return;
            }
            try
            {
                codigo = int.Parse(txtCodigoCompra.Text);
                cantidad = int.Parse(txtCantidadSuplir.Text); //TODO <-------------------------- MANEJAR EXCEPCIONES
                productoComprado = adminProductos.Buscar(int.Parse(productos[0].Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

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
                Producto producto = adminProductos.Buscar(compraEliminada.CodigoProducto);
                if (producto == null)
                {
                    MessageBox.Show("No se puede eliminar porque el producto ha sido eliminado.");
                    return;
                }

                if (producto.Quitar(compraEliminada.Cantidad))
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
            try
            {
                Producto producto = adminProductos.Buscar(adminCompras.CompraUtil.CodigoProducto);
                int cantidad = int.Parse(txtModificarCan.Text);

                if (!adminCompras.CompraUtil.Modificar(cantidad, producto))
                {
                    MessageBox.Show("No se pudo modificar porque ya se han vendido productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                LimpiarPnlModificarCompra();
            }
            ActualizarComprasLsView();
            pnlCompras.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlVender1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnVender_Click(object sender, EventArgs e)
        {
            ActualizarLsView(lsViewProdV1);
            pnlVender1.BringToFront();
        }

        private void bttnVenderDef_Click(object sender, EventArgs e)
        {
            if (lsViewProdV2.Items.Count <= 0)
            {
                MessageBox.Show("Debe agregar al menos 1 producto para realizar la venta.");
                return;
            }

            int numero = int.Parse(txtNumeroVenta.Text);
            string nombreCliente = txtNombreCliente.Text;
            string correoCliente = txtCorreoCliente.Text;
            int telefonoCliente = int.Parse(txtTelefonoCliente.Text);
            List<int[]> productosVenta = ObtenerProductosVenta();
            double subtotal = adminProductos.ObtenerSubtotal(productosVenta);
            double total = adminProductos.ObtenerTotal(productosVenta);

            adminProductos.RealizarVenta(productosVenta);
            adminVentas.Crear(numero, nombreCliente, correoCliente, telefonoCliente, subtotal, total, productosVenta);
            ActualizarVentasLsView();
            ActualizarLsView(lsViewProductos);
            pnlVentas.BringToFront();
            LimpiarPnlVender();
        }

        private List<int[]> ObtenerProductosVenta()
        {
            List<ListViewItem> productosAVender = lsViewProdV2.Items.Cast<ListViewItem>().ToList();
            List<int[]> productosVenta = new List<int[]>();

            foreach (ListViewItem producto in productosAVender)
            {
                productosVenta.Add(new int[] { int.Parse(producto.Text), int.Parse(producto.SubItems[4].Text) });
            }
            return productosVenta;
        }

        private void bttnBorrarVenta_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> ventas = lsViewVentas.SelectedItems.Cast<ListViewItem>().ToList();

            if (ventas.Count == 0)
            {
                MessageBox.Show("No selecciono ventas.");
                return;
            }

            foreach (ListViewItem venta in ventas)
            {
                Venta ventaEliminada = adminVentas.Buscar(int.Parse(venta.Text));
                adminProductos.DeshacerVenta(ventaEliminada.Productos);
                adminVentas.Borrar(ventaEliminada.Numero);
                lsViewVentas.Items.Remove(venta);

            }
            ActualizarLsView(lsViewProductos);
        }


        private void bttnContinuarVenta_Click(object sender, EventArgs e)
        {
            pnlVender2.BringToFront();
        }

        private void bttnCnlVenta1_Click(object sender, EventArgs e)
        {
            CancelarVenta();
        }

        private void bttnCnlVenta2_Click(object sender, EventArgs e)
        {
            CancelarVenta();
        }

        private void CancelarVenta()
        {
            LimpiarPnlVender();
            pnlVentas.BringToFront();
        }

        private void bttnRegresar_Click(object sender, EventArgs e)
        {
            pnlVender1.BringToFront();
        }


        private void bttnAgregarVenta_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = lsViewProdV1.SelectedItems.Cast<ListViewItem>().ToList();
            int cantidad = 0;

            try
            {
                cantidad = int.Parse(txtCantidadVenta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Inserte una cantidad para poder agregar el producto.");
                return;
            }

            if (productos.Count == 0)
            {
                MessageBox.Show("No selecciono productos.");
                return;
            } 
            else if (cantidad == 0)
            {
                MessageBox.Show("La cantidad debe ser al menos 1.");
                return;
            }

            int cantidadActual = int.Parse(productos[0].SubItems[4].Text);
            if (cantidadActual - cantidad < 0)
            {
                MessageBox.Show("No existe tal cantidad del producto seleccionado.");
                return;
            }

            foreach (ListViewItem producto in productos)
            {
                ListViewItem productoAgregado = (ListViewItem) producto.Clone();
                productoAgregado.SubItems[4].Text = cantidad.ToString();
                producto.SubItems[4].Text = Convert.ToString(cantidadActual - cantidad);

                lsViewProdV2.Items.Add(productoAgregado);
                lblTotal.Text = Convert.ToString(adminProductos.ObtenerTotal(ObtenerProductosVenta()));
            }

        }

        private void bttnBorrarPosibleVenta_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> productos = lsViewProdV2.SelectedItems.Cast<ListViewItem>().ToList();

            if (productos.Count == 0)
            {
                MessageBox.Show("No selecciono productos.");
                return;
            }
            //Itera por los productos a eliminar del listView de la posible venta.
            foreach (ListViewItem producto in productos)
            {
                int codigo = int.Parse(producto.Text);
                int cantidad = int.Parse(producto.SubItems[3].Text);

                ListViewItem productoModificado = BuscarProductoLsView(lsViewProdV1, codigo);
                int cantidadActual = int.Parse(productoModificado.SubItems[3].Text);

                productoModificado.SubItems[3].Text = Convert.ToString(cantidadActual + cantidad);
                lsViewProdV2.Items.Remove(producto);
                lblTotal.Text = Convert.ToString(adminProductos.ObtenerTotal(ObtenerProductosVenta()));
            }
        }
        //Busca un productos de un listView que contenga productos.
        private ListViewItem BuscarProductoLsView(ListView listView, int codigoProducto)
        {
            List<ListViewItem> productos = listView.Items.Cast<ListViewItem>().ToList();

            foreach (ListViewItem producto in productos)
            {
                int codigo = int.Parse(producto.Text);
                if (codigo == codigoProducto)
                {
                    return producto;
                }
            }
            return null;

        }

        private void bttnFacturar_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> ventas = lsViewVentas.SelectedItems.Cast<ListViewItem>().ToList();

            if (ventas.Count != 1)
            {
                MessageBox.Show("No selecciono una venta.");
                return;
            }

            foreach (ListViewItem venta in ventas)
            {
                Venta ventaFacturada = adminVentas.Buscar(int.Parse(venta.Text));
                if (adminVentas.Facturar(ventaFacturada.Numero))
                {
                    MessageBox.Show("La factura ha sido generada donde se encuentre el .exe del programa.");
                }

            }
            ActualizarLsView(lsViewProductos);
        }
    }
}
