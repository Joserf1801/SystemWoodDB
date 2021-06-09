namespace CapaPresentacion
{
    partial class FormularioVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVentas));
            this.PanelBuscador = new System.Windows.Forms.Panel();
            this.txt_Articulos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Medidas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Contenido = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelCantidad = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cabecera = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.Clave_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFichas = new System.Windows.Forms.Panel();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_Articulos = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.Panel_Botones = new System.Windows.Forms.Panel();
            this.btn_CancelarVenta = new System.Windows.Forms.Button();
            this.btn_RealizarVenta = new System.Windows.Forms.Button();
            this.Redondear_Contenido = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Redondear_Buscador = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Redondear_Fichas = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Redondear_PanelBotones = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Redo_RealizarVenta = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Remover = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PanelBuscador.SuspendLayout();
            this.Panel_Contenido.SuspendLayout();
            this.PanelCantidad.SuspendLayout();
            this.Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            this.PanelFichas.SuspendLayout();
            this.Panel_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBuscador
            // 
            this.PanelBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBuscador.BackColor = System.Drawing.Color.White;
            this.PanelBuscador.Controls.Add(this.txt_Articulos);
            this.PanelBuscador.Controls.Add(this.btn_Agregar);
            this.PanelBuscador.Controls.Add(this.label2);
            this.PanelBuscador.Controls.Add(this.cmb_Medidas);
            this.PanelBuscador.Controls.Add(this.label1);
            this.PanelBuscador.Location = new System.Drawing.Point(12, 15);
            this.PanelBuscador.MaximumSize = new System.Drawing.Size(1000, 67);
            this.PanelBuscador.Name = "PanelBuscador";
            this.PanelBuscador.Size = new System.Drawing.Size(777, 57);
            this.PanelBuscador.TabIndex = 11;
            // 
            // txt_Articulos
            // 
            this.txt_Articulos.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Articulos.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Articulos.Location = new System.Drawing.Point(83, 17);
            this.txt_Articulos.Name = "txt_Articulos";
            this.txt_Articulos.Size = new System.Drawing.Size(229, 21);
            this.txt_Articulos.TabIndex = 0;
            this.txt_Articulos.Text = "Ingrese codigo de producto";
            this.txt_Articulos.TextChanged += new System.EventHandler(this.txt_Articulos_TextChanged);
            this.txt_Articulos.Enter += new System.EventHandler(this.txt_Articulos_Enter);
            this.txt_Articulos.Leave += new System.EventHandler(this.txt_Articulos_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medidas:";
            // 
            // cmb_Medidas
            // 
            this.cmb_Medidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Medidas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Medidas.FormattingEnabled = true;
            this.cmb_Medidas.Location = new System.Drawing.Point(395, 17);
            this.cmb_Medidas.Name = "cmb_Medidas";
            this.cmb_Medidas.Size = new System.Drawing.Size(191, 23);
            this.cmb_Medidas.TabIndex = 1;
            this.cmb_Medidas.SelectedIndexChanged += new System.EventHandler(this.cmb_Medidas_SelectedIndexChanged);
            this.cmb_Medidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Medidas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo:";
            // 
            // Panel_Contenido
            // 
            this.Panel_Contenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Contenido.BackColor = System.Drawing.Color.White;
            this.Panel_Contenido.Controls.Add(this.label10);
            this.Panel_Contenido.Controls.Add(this.label8);
            this.Panel_Contenido.Controls.Add(this.label7);
            this.Panel_Contenido.Controls.Add(this.label6);
            this.Panel_Contenido.Controls.Add(this.PanelCantidad);
            this.Panel_Contenido.Controls.Add(this.label5);
            this.Panel_Contenido.Controls.Add(this.dgv_Articulos);
            this.Panel_Contenido.Location = new System.Drawing.Point(12, 84);
            this.Panel_Contenido.MaximumSize = new System.Drawing.Size(1000, 666);
            this.Panel_Contenido.Name = "Panel_Contenido";
            this.Panel_Contenido.Size = new System.Drawing.Size(777, 566);
            this.Panel_Contenido.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Medidas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre";
            // 
            // PanelCantidad
            // 
            this.PanelCantidad.Controls.Add(this.btn_Cancelar);
            this.PanelCantidad.Controls.Add(this.btn_Modificar);
            this.PanelCantidad.Controls.Add(this.txt_Cantidad);
            this.PanelCantidad.Controls.Add(this.pictureBox4);
            this.PanelCantidad.Controls.Add(this.label3);
            this.PanelCantidad.Controls.Add(this.Cabecera);
            this.PanelCantidad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCantidad.Location = new System.Drawing.Point(21, 109);
            this.PanelCantidad.Name = "PanelCantidad";
            this.PanelCantidad.Size = new System.Drawing.Size(284, 161);
            this.PanelCantidad.TabIndex = 5;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Brown;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(158, 124);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(107, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(25, 124);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(107, 24);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cantidad.Location = new System.Drawing.Point(88, 72);
            this.txt_Cantidad.MaxLength = 7;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(166, 14);
            this.txt_Cantidad.TabIndex = 5;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // Cabecera
            // 
            this.Cabecera.BackColor = System.Drawing.Color.Brown;
            this.Cabecera.Controls.Add(this.label4);
            this.Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecera.Location = new System.Drawing.Point(0, 0);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(284, 33);
            this.Cabecera.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modificar Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo";
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.AllowUserToAddRows = false;
            this.dgv_Articulos.AllowUserToDeleteRows = false;
            this.dgv_Articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Articulos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Articulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.ColumnHeadersVisible = false;
            this.dgv_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave_Producto,
            this.Codigo_Producto,
            this.Nombre,
            this.Medida,
            this.Cantidad,
            this.Subtotal,
            this.Remover});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulos.Location = new System.Drawing.Point(12, 57);
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.ReadOnly = true;
            this.dgv_Articulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Articulos.RowHeadersVisible = false;
            this.dgv_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Articulos.Size = new System.Drawing.Size(749, 436);
            this.dgv_Articulos.TabIndex = 6;
            this.dgv_Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulos_CellContentClick);
            // 
            // Clave_Producto
            // 
            this.Clave_Producto.HeaderText = "Clave_Producto";
            this.Clave_Producto.Name = "Clave_Producto";
            this.Clave_Producto.ReadOnly = true;
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.HeaderText = "Codigo";
            this.Codigo_Producto.Name = "Codigo_Producto";
            this.Codigo_Producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // PanelFichas
            // 
            this.PanelFichas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFichas.BackColor = System.Drawing.Color.White;
            this.PanelFichas.Controls.Add(this.lb_Total);
            this.PanelFichas.Controls.Add(this.lb_Articulos);
            this.PanelFichas.Controls.Add(this.lb_Nombre);
            this.PanelFichas.Controls.Add(this.pictureBox3);
            this.PanelFichas.Controls.Add(this.pictureBox2);
            this.PanelFichas.Controls.Add(this.pictureBox1);
            this.PanelFichas.Location = new System.Drawing.Point(795, 12);
            this.PanelFichas.Name = "PanelFichas";
            this.PanelFichas.Size = new System.Drawing.Size(289, 387);
            this.PanelFichas.TabIndex = 12;
            // 
            // lb_Total
            // 
            this.lb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(160, 326);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(26, 16);
            this.lb_Total.TabIndex = 7;
            this.lb_Total.Text = "$ 0";
            // 
            // lb_Articulos
            // 
            this.lb_Articulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Articulos.AutoSize = true;
            this.lb_Articulos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Articulos.Location = new System.Drawing.Point(160, 200);
            this.lb_Articulos.Name = "lb_Articulos";
            this.lb_Articulos.Size = new System.Drawing.Size(69, 16);
            this.lb_Articulos.TabIndex = 6;
            this.lb_Articulos.Text = "0 Articulos";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nombre.Location = new System.Drawing.Point(63, 74);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(165, 16);
            this.lb_Nombre.TabIndex = 5;
            this.lb_Nombre.Text = "Nombre Apellidos Apellidos";
            // 
            // Panel_Botones
            // 
            this.Panel_Botones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Botones.BackColor = System.Drawing.Color.White;
            this.Panel_Botones.Controls.Add(this.btn_CancelarVenta);
            this.Panel_Botones.Controls.Add(this.btn_RealizarVenta);
            this.Panel_Botones.Location = new System.Drawing.Point(795, 405);
            this.Panel_Botones.Name = "Panel_Botones";
            this.Panel_Botones.Size = new System.Drawing.Size(289, 245);
            this.Panel_Botones.TabIndex = 13;
            // 
            // btn_CancelarVenta
            // 
            this.btn_CancelarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelarVenta.BackColor = System.Drawing.Color.Brown;
            this.btn_CancelarVenta.Font = new System.Drawing.Font("Arial", 9.25F);
            this.btn_CancelarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarVenta.Location = new System.Drawing.Point(22, 178);
            this.btn_CancelarVenta.Name = "btn_CancelarVenta";
            this.btn_CancelarVenta.Size = new System.Drawing.Size(253, 44);
            this.btn_CancelarVenta.TabIndex = 4;
            this.btn_CancelarVenta.Text = "Cancelar Venta";
            this.btn_CancelarVenta.UseVisualStyleBackColor = false;
            this.btn_CancelarVenta.Click += new System.EventHandler(this.btn_CancelarVenta_Click);
            // 
            // btn_RealizarVenta
            // 
            this.btn_RealizarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RealizarVenta.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_RealizarVenta.Font = new System.Drawing.Font("Arial", 9.25F);
            this.btn_RealizarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_RealizarVenta.Location = new System.Drawing.Point(22, 128);
            this.btn_RealizarVenta.Name = "btn_RealizarVenta";
            this.btn_RealizarVenta.Size = new System.Drawing.Size(253, 44);
            this.btn_RealizarVenta.TabIndex = 3;
            this.btn_RealizarVenta.Text = "Realizar Venta";
            this.btn_RealizarVenta.UseVisualStyleBackColor = false;
            this.btn_RealizarVenta.Click += new System.EventHandler(this.btn_RealizarVenta_Click);
            // 
            // Redondear_Contenido
            // 
            this.Redondear_Contenido.ElipseRadius = 10;
            this.Redondear_Contenido.TargetControl = this.Panel_Contenido;
            // 
            // Redondear_Buscador
            // 
            this.Redondear_Buscador.ElipseRadius = 10;
            this.Redondear_Buscador.TargetControl = this.PanelBuscador;
            // 
            // Redondear_Fichas
            // 
            this.Redondear_Fichas.ElipseRadius = 10;
            this.Redondear_Fichas.TargetControl = this.PanelFichas;
            // 
            // Redondear_PanelBotones
            // 
            this.Redondear_PanelBotones.ElipseRadius = 10;
            this.Redondear_PanelBotones.TargetControl = this.Panel_Botones;
            // 
            // Redo_RealizarVenta
            // 
            this.Redo_RealizarVenta.ElipseRadius = 10;
            this.Redo_RealizarVenta.TargetControl = this.btn_RealizarVenta;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Remover";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.BorrarIcono;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 107;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.Ficha_Total;
            this.pictureBox3.Location = new System.Drawing.Point(3, 255);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Ficha_Articulos;
            this.pictureBox2.Location = new System.Drawing.Point(3, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Ficha_Empleado;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.Imagen1;
            this.pictureBox4.Location = new System.Drawing.Point(84, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Remover
            // 
            this.Remover.HeaderText = "Remover";
            this.Remover.Image = global::CapaPresentacion.Properties.Resources.BorrarIcono;
            this.Remover.Name = "Remover";
            this.Remover.ReadOnly = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.ActiveBorderThickness = 1;
            this.btn_Agregar.ActiveCornerRadius = 20;
            this.btn_Agregar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Agregar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Agregar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar.BackColor = System.Drawing.Color.White;
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.ButtonText = "Agregar";
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Agregar.IdleBorderThickness = 1;
            this.btn_Agregar.IdleCornerRadius = 20;
            this.btn_Agregar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Agregar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Agregar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Agregar.Location = new System.Drawing.Point(609, 7);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(139, 41);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            this.btn_Agregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_Agregar_KeyPress);
            // 
            // FormularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 683);
            this.Controls.Add(this.Panel_Botones);
            this.Controls.Add(this.PanelFichas);
            this.Controls.Add(this.Panel_Contenido);
            this.Controls.Add(this.PanelBuscador);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioVentas";
            this.Load += new System.EventHandler(this.FormularioVentas_Load);
            this.PanelBuscador.ResumeLayout(false);
            this.PanelBuscador.PerformLayout();
            this.Panel_Contenido.ResumeLayout(false);
            this.Panel_Contenido.PerformLayout();
            this.PanelCantidad.ResumeLayout(false);
            this.PanelCantidad.PerformLayout();
            this.Cabecera.ResumeLayout(false);
            this.Cabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            this.PanelFichas.ResumeLayout(false);
            this.PanelFichas.PerformLayout();
            this.Panel_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBuscador;
        private System.Windows.Forms.Panel Panel_Contenido;
        private System.Windows.Forms.Panel PanelFichas;
        private System.Windows.Forms.Panel Panel_Botones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Medidas;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_RealizarVenta;
        private Bunifu.Framework.UI.BunifuElipse Redondear_Contenido;
        private Bunifu.Framework.UI.BunifuElipse Redondear_Buscador;
        private Bunifu.Framework.UI.BunifuElipse Redondear_Fichas;
        private Bunifu.Framework.UI.BunifuElipse Redondear_PanelBotones;
        private Bunifu.Framework.UI.BunifuElipse Redo_RealizarVenta;
        private System.Windows.Forms.Button btn_CancelarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewImageColumn Remover;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_Articulos;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Panel PanelCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Cabecera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Articulos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}