using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        Button bttnActual;

        public Form1()
        {
            InitializeComponent();
            bttnActual = null;
        }
        //Botón general para el boton home, productos, compras, etc.
        private void bttnGeneral_Click(object sender, EventArgs e)
        {
            bttnActual = sender as Button;


        }


        private void bttnProductos_Click(object sender, EventArgs e)
        {
            pnlProductos.BringToFront();
        }

        private void bttnCompras_Click(object sender, EventArgs e)
        {


            
        }

        private void bttnVentas_Click(object sender, EventArgs e)
        {

        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            pnlNuevoP.BringToFront();
        
        }

        private void bttnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            pnlModificarP.BringToFront();
        }

        private void bttnCnlNuevoP_Click(object sender, EventArgs e)
        {
            pnlProductos.BringToFront();
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

            bttn.BackColor = Color.Transparent;
            bttn.ForeColor = Color.Black;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
