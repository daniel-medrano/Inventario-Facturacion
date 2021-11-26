
namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnProductos = new System.Windows.Forms.Button();
            this.bttnCompras = new System.Windows.Forms.Button();
            this.bttnVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.bttnBorrar = new System.Windows.Forms.Button();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlNuevoP = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.bttnCnlNuevoP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnCrear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bttnHome = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlModificarP = new System.Windows.Forms.Panel();
            this.pnlProductos.SuspendLayout();
            this.pnlNuevoP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlModificarP.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnProductos
            // 
            this.bttnProductos.BackColor = System.Drawing.Color.Transparent;
            this.bttnProductos.FlatAppearance.BorderSize = 0;
            this.bttnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnProductos.Location = new System.Drawing.Point(289, 12);
            this.bttnProductos.Name = "bttnProductos";
            this.bttnProductos.Size = new System.Drawing.Size(86, 25);
            this.bttnProductos.TabIndex = 0;
            this.bttnProductos.Text = "Productos";
            this.bttnProductos.UseVisualStyleBackColor = false;
            this.bttnProductos.Click += new System.EventHandler(this.bttnProductos_Click);
            this.bttnProductos.MouseEnter += new System.EventHandler(this.bttnGreen_MouseEnter);
            this.bttnProductos.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // bttnCompras
            // 
            this.bttnCompras.BackColor = System.Drawing.Color.Transparent;
            this.bttnCompras.FlatAppearance.BorderSize = 0;
            this.bttnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCompras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCompras.Location = new System.Drawing.Point(381, 12);
            this.bttnCompras.Name = "bttnCompras";
            this.bttnCompras.Size = new System.Drawing.Size(86, 25);
            this.bttnCompras.TabIndex = 1;
            this.bttnCompras.Text = "Compras";
            this.bttnCompras.UseVisualStyleBackColor = false;
            this.bttnCompras.Click += new System.EventHandler(this.bttnCompras_Click);
            this.bttnCompras.MouseEnter += new System.EventHandler(this.bttnGreen_MouseEnter);
            this.bttnCompras.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // bttnVentas
            // 
            this.bttnVentas.BackColor = System.Drawing.Color.Transparent;
            this.bttnVentas.FlatAppearance.BorderSize = 0;
            this.bttnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVentas.Location = new System.Drawing.Point(473, 12);
            this.bttnVentas.Name = "bttnVentas";
            this.bttnVentas.Size = new System.Drawing.Size(86, 25);
            this.bttnVentas.TabIndex = 2;
            this.bttnVentas.Text = "Ventas";
            this.bttnVentas.UseVisualStyleBackColor = false;
            this.bttnVentas.Click += new System.EventHandler(this.bttnVentas_Click);
            this.bttnVentas.MouseEnter += new System.EventHandler(this.bttnGreen_MouseEnter);
            this.bttnVentas.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inventario";
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.White;
            this.pnlProductos.Controls.Add(this.textBox9);
            this.pnlProductos.Controls.Add(this.bttnModificar);
            this.pnlProductos.Controls.Add(this.bttnBorrar);
            this.pnlProductos.Controls.Add(this.bttnNuevo);
            this.pnlProductos.Controls.Add(this.listView1);
            this.pnlProductos.Location = new System.Drawing.Point(12, 52);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(560, 327);
            this.pnlProductos.TabIndex = 3;
            // 
            // bttnModificar
            // 
            this.bttnModificar.BackColor = System.Drawing.Color.Transparent;
            this.bttnModificar.FlatAppearance.BorderSize = 0;
            this.bttnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificar.ForeColor = System.Drawing.Color.Black;
            this.bttnModificar.Location = new System.Drawing.Point(210, 287);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(86, 25);
            this.bttnModificar.TabIndex = 3;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.UseVisualStyleBackColor = false;
            this.bttnModificar.Click += new System.EventHandler(this.bttnModificar_Click);
            // 
            // bttnBorrar
            // 
            this.bttnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.bttnBorrar.FlatAppearance.BorderSize = 0;
            this.bttnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.bttnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBorrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBorrar.ForeColor = System.Drawing.Color.Black;
            this.bttnBorrar.Location = new System.Drawing.Point(118, 287);
            this.bttnBorrar.Name = "bttnBorrar";
            this.bttnBorrar.Size = new System.Drawing.Size(86, 25);
            this.bttnBorrar.TabIndex = 2;
            this.bttnBorrar.Text = "Borrar";
            this.bttnBorrar.UseVisualStyleBackColor = false;
            this.bttnBorrar.Click += new System.EventHandler(this.bttnBorrar_Click);
            this.bttnBorrar.MouseEnter += new System.EventHandler(this.bttnRed_MouseEnter);
            this.bttnBorrar.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.bttnNuevo.FlatAppearance.BorderSize = 0;
            this.bttnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNuevo.ForeColor = System.Drawing.Color.Black;
            this.bttnNuevo.Location = new System.Drawing.Point(26, 287);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(86, 25);
            this.bttnNuevo.TabIndex = 1;
            this.bttnNuevo.Text = "Nuevo";
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
            this.bttnNuevo.MouseEnter += new System.EventHandler(this.bttnGreen_MouseEnter);
            this.bttnNuevo.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // listView1
            // 
            this.listView1.AccessibleDescription = "";
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnNombre,
            this.columnDescripcion,
            this.columnPrecio,
            this.columnCantidad});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(531, 268);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            this.columnCodigo.Width = 113;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 106;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripción";
            this.columnDescripcion.Width = 146;
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "Precio";
            this.columnPrecio.Width = 90;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 72;
            // 
            // pnlNuevoP
            // 
            this.pnlNuevoP.Controls.Add(this.label14);
            this.pnlNuevoP.Controls.Add(this.bttnCnlNuevoP);
            this.pnlNuevoP.Controls.Add(this.label6);
            this.pnlNuevoP.Controls.Add(this.textBox5);
            this.pnlNuevoP.Controls.Add(this.label5);
            this.pnlNuevoP.Controls.Add(this.textBox4);
            this.pnlNuevoP.Controls.Add(this.label4);
            this.pnlNuevoP.Controls.Add(this.label3);
            this.pnlNuevoP.Controls.Add(this.textBox2);
            this.pnlNuevoP.Controls.Add(this.label2);
            this.pnlNuevoP.Controls.Add(this.textBox1);
            this.pnlNuevoP.Controls.Add(this.bttnCrear);
            this.pnlNuevoP.Controls.Add(this.panel1);
            this.pnlNuevoP.Location = new System.Drawing.Point(12, 52);
            this.pnlNuevoP.Name = "pnlNuevoP";
            this.pnlNuevoP.Size = new System.Drawing.Size(560, 327);
            this.pnlNuevoP.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 19);
            this.label14.TabIndex = 21;
            this.label14.Text = "Crear Producto Nuevo";
            // 
            // bttnCnlNuevoP
            // 
            this.bttnCnlNuevoP.BackColor = System.Drawing.Color.Transparent;
            this.bttnCnlNuevoP.FlatAppearance.BorderSize = 0;
            this.bttnCnlNuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCnlNuevoP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCnlNuevoP.Location = new System.Drawing.Point(289, 285);
            this.bttnCnlNuevoP.Name = "bttnCnlNuevoP";
            this.bttnCnlNuevoP.Size = new System.Drawing.Size(86, 25);
            this.bttnCnlNuevoP.TabIndex = 18;
            this.bttnCnlNuevoP.Text = "Cancelar";
            this.bttnCnlNuevoP.UseVisualStyleBackColor = false;
            this.bttnCnlNuevoP.Click += new System.EventHandler(this.bttnCnlNuevoP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(116, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 22);
            this.textBox5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(116, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(116, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 6;
            // 
            // bttnCrear
            // 
            this.bttnCrear.BackColor = System.Drawing.Color.Transparent;
            this.bttnCrear.FlatAppearance.BorderSize = 0;
            this.bttnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCrear.Location = new System.Drawing.Point(197, 285);
            this.bttnCrear.Name = "bttnCrear";
            this.bttnCrear.Size = new System.Drawing.Size(86, 25);
            this.bttnCrear.TabIndex = 5;
            this.bttnCrear.Text = "Crear";
            this.bttnCrear.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(116, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 70);
            this.panel1.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 68);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // bttnHome
            // 
            this.bttnHome.BackColor = System.Drawing.Color.Transparent;
            this.bttnHome.FlatAppearance.BorderSize = 0;
            this.bttnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.Location = new System.Drawing.Point(197, 12);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(86, 25);
            this.bttnHome.TabIndex = 20;
            this.bttnHome.Text = "Home";
            this.bttnHome.UseVisualStyleBackColor = false;
            this.bttnHome.Click += new System.EventHandler(this.bttnGeneral_Click);
            this.bttnHome.MouseEnter += new System.EventHandler(this.bttnGreen_MouseEnter);
            this.bttnHome.MouseLeave += new System.EventHandler(this.bttn_MouseLeave);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(333, 290);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(214, 20);
            this.textBox9.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(117, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 70);
            this.panel2.TabIndex = 32;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(194, 68);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(198, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 25);
            this.button4.TabIndex = 22;
            this.button4.Text = "Crear";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(117, 73);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(196, 22);
            this.textBox13.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(29, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "Código:";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(117, 102);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(196, 22);
            this.textBox12.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Nombre:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(29, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "Descripción:";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(117, 207);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(196, 22);
            this.textBox11.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Precio:";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(117, 233);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(196, 22);
            this.textBox10.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Cantidad:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(290, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Modificar Producto";
            // 
            // pnlModificarP
            // 
            this.pnlModificarP.Controls.Add(this.label8);
            this.pnlModificarP.Controls.Add(this.button3);
            this.pnlModificarP.Controls.Add(this.label15);
            this.pnlModificarP.Controls.Add(this.textBox10);
            this.pnlModificarP.Controls.Add(this.label16);
            this.pnlModificarP.Controls.Add(this.textBox11);
            this.pnlModificarP.Controls.Add(this.label17);
            this.pnlModificarP.Controls.Add(this.label18);
            this.pnlModificarP.Controls.Add(this.textBox12);
            this.pnlModificarP.Controls.Add(this.label19);
            this.pnlModificarP.Controls.Add(this.textBox13);
            this.pnlModificarP.Controls.Add(this.button4);
            this.pnlModificarP.Controls.Add(this.panel2);
            this.pnlModificarP.Location = new System.Drawing.Point(12, 52);
            this.pnlModificarP.Name = "pnlModificarP";
            this.pnlModificarP.Size = new System.Drawing.Size(560, 327);
            this.pnlModificarP.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 392);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnVentas);
            this.Controls.Add(this.bttnCompras);
            this.Controls.Add(this.bttnProductos);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.pnlNuevoP);
            this.Controls.Add(this.pnlModificarP);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            this.pnlNuevoP.ResumeLayout(false);
            this.pnlNuevoP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlModificarP.ResumeLayout(false);
            this.pnlModificarP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnProductos;
        private System.Windows.Forms.Button bttnCompras;
        private System.Windows.Forms.Button bttnVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.Button bttnBorrar;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnDescripcion;
        private System.Windows.Forms.ColumnHeader columnPrecio;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private System.Windows.Forms.Panel pnlNuevoP;
        private System.Windows.Forms.Button bttnCnlNuevoP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttnCrear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlModificarP;
    }
}

