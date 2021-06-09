namespace CapaPresentacion
{
    partial class FormularioPrincipal
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
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelSubMenu2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSubMenu1 = new System.Windows.Forms.Panel();
            this.panelFoother = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.HoraYFecha = new System.Windows.Forms.Timer(this.components);
            this.EnclarecerFormulario = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.ContornoLateral = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ContornoDelForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ContornoDelSubMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Proveedores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Empleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Inventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_CerrarSesión = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ConsultarCuentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_VerPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_MiCuenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelCabecera.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelSubMenu2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubMenu1.SuspendLayout();
            this.panelFoother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.White;
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.button1);
            this.panelCabecera.Controls.Add(this.btn_Cerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1370, 30);
            this.panelCabecera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(552, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sistema de Gestión de Madereria SystemWoodDB";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(1301, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.White;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Verdana", 11.75F, System.Drawing.FontStyle.Bold);
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Brown;
            this.btn_Cerrar.Location = new System.Drawing.Point(1333, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(28, 24);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(0, 30);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(1370, 5);
            this.panelSombra.TabIndex = 2;
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.Brown;
            this.panelLateral.Controls.Add(this.btn_Proveedores);
            this.panelLateral.Controls.Add(this.btn_Empleados);
            this.panelLateral.Controls.Add(this.btn_Inventario);
            this.panelLateral.Controls.Add(this.panelSubMenu2);
            this.panelLateral.Controls.Add(this.btn_Ventas);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.panelSubMenu1);
            this.panelLateral.Controls.Add(this.btn_MiCuenta);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 35);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(282, 753);
            this.panelLateral.TabIndex = 3;
            // 
            // panelSubMenu2
            // 
            this.panelSubMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSubMenu2.Controls.Add(this.bunifuFlatButton1);
            this.panelSubMenu2.Controls.Add(this.bunifuFlatButton3);
            this.panelSubMenu2.Controls.Add(this.pictureBox3);
            this.panelSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu2.Location = new System.Drawing.Point(0, 276);
            this.panelSubMenu2.Name = "panelSubMenu2";
            this.panelSubMenu2.Size = new System.Drawing.Size(282, 85);
            this.panelSubMenu2.TabIndex = 10;
            this.panelSubMenu2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 225);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Madereria Atlixco";
            // 
            // panelSubMenu1
            // 
            this.panelSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSubMenu1.Controls.Add(this.pictureBox2);
            this.panelSubMenu1.Controls.Add(this.btn_CerrarSesión);
            this.panelSubMenu1.Controls.Add(this.btn_ConsultarCuentas);
            this.panelSubMenu1.Controls.Add(this.btn_VerPerfil);
            this.panelSubMenu1.Location = new System.Drawing.Point(2, 582);
            this.panelSubMenu1.Name = "panelSubMenu1";
            this.panelSubMenu1.Size = new System.Drawing.Size(252, 120);
            this.panelSubMenu1.TabIndex = 6;
            // 
            // panelFoother
            // 
            this.panelFoother.BackColor = System.Drawing.Color.White;
            this.panelFoother.Controls.Add(this.lbFecha);
            this.panelFoother.Controls.Add(this.lbHora);
            this.panelFoother.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoother.Location = new System.Drawing.Point(282, 755);
            this.panelFoother.Name = "panelFoother";
            this.panelFoother.Size = new System.Drawing.Size(1088, 33);
            this.panelFoother.TabIndex = 4;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbFecha.Location = new System.Drawing.Point(789, 8);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(51, 16);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.Brown;
            this.lbHora.Location = new System.Drawing.Point(1028, 8);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(42, 16);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "Hora";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(282, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1088, 720);
            this.panelContenedor.TabIndex = 5;
            // 
            // HoraYFecha
            // 
            this.HoraYFecha.Enabled = true;
            this.HoraYFecha.Tick += new System.EventHandler(this.HoraYFecha_Tick);
            // 
            // EnclarecerFormulario
            // 
            this.EnclarecerFormulario.Delay = 0;
            // 
            // ContornoLateral
            // 
            this.ContornoLateral.ElipseRadius = 6;
            this.ContornoLateral.TargetControl = this.panelLateral;
            // 
            // ContornoDelForm
            // 
            this.ContornoDelForm.ElipseRadius = 5;
            this.ContornoDelForm.TargetControl = this;
            // 
            // ContornoDelSubMenu
            // 
            this.ContornoDelSubMenu.ElipseRadius = 10;
            this.ContornoDelSubMenu.TargetControl = this;
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Proveedores.BackColor = System.Drawing.Color.Brown;
            this.btn_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Proveedores.BorderRadius = 0;
            this.btn_Proveedores.ButtonText = "Proveedores";
            this.btn_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proveedores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Proveedores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Proveedores.Iconimage = global::CapaPresentacion.Properties.Resources.proveedorIcon;
            this.btn_Proveedores.Iconimage_right = null;
            this.btn_Proveedores.Iconimage_right_Selected = null;
            this.btn_Proveedores.Iconimage_Selected = null;
            this.btn_Proveedores.IconMarginLeft = 0;
            this.btn_Proveedores.IconMarginRight = 0;
            this.btn_Proveedores.IconRightVisible = true;
            this.btn_Proveedores.IconRightZoom = 0D;
            this.btn_Proveedores.IconVisible = true;
            this.btn_Proveedores.IconZoom = 90D;
            this.btn_Proveedores.IsTab = false;
            this.btn_Proveedores.Location = new System.Drawing.Point(0, 463);
            this.btn_Proveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Normalcolor = System.Drawing.Color.Brown;
            this.btn_Proveedores.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_Proveedores.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Proveedores.selected = false;
            this.btn_Proveedores.Size = new System.Drawing.Size(282, 51);
            this.btn_Proveedores.TabIndex = 3;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Proveedores.Textcolor = System.Drawing.Color.White;
            this.btn_Proveedores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Empleados.BackColor = System.Drawing.Color.Brown;
            this.btn_Empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Empleados.BorderRadius = 0;
            this.btn_Empleados.ButtonText = "Empleados";
            this.btn_Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Empleados.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Empleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Empleados.Iconimage = global::CapaPresentacion.Properties.Resources.empleado;
            this.btn_Empleados.Iconimage_right = null;
            this.btn_Empleados.Iconimage_right_Selected = null;
            this.btn_Empleados.Iconimage_Selected = null;
            this.btn_Empleados.IconMarginLeft = 0;
            this.btn_Empleados.IconMarginRight = 0;
            this.btn_Empleados.IconRightVisible = true;
            this.btn_Empleados.IconRightZoom = 0D;
            this.btn_Empleados.IconVisible = true;
            this.btn_Empleados.IconZoom = 90D;
            this.btn_Empleados.IsTab = false;
            this.btn_Empleados.Location = new System.Drawing.Point(0, 412);
            this.btn_Empleados.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Normalcolor = System.Drawing.Color.Brown;
            this.btn_Empleados.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_Empleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Empleados.selected = false;
            this.btn_Empleados.Size = new System.Drawing.Size(282, 51);
            this.btn_Empleados.TabIndex = 2;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Empleados.Textcolor = System.Drawing.Color.White;
            this.btn_Empleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Inventario.BackColor = System.Drawing.Color.Brown;
            this.btn_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inventario.BorderRadius = 0;
            this.btn_Inventario.ButtonText = "Inventario";
            this.btn_Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inventario.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Inventario.Iconimage = global::CapaPresentacion.Properties.Resources.inventario;
            this.btn_Inventario.Iconimage_right = null;
            this.btn_Inventario.Iconimage_right_Selected = null;
            this.btn_Inventario.Iconimage_Selected = null;
            this.btn_Inventario.IconMarginLeft = 0;
            this.btn_Inventario.IconMarginRight = 0;
            this.btn_Inventario.IconRightVisible = true;
            this.btn_Inventario.IconRightZoom = 0D;
            this.btn_Inventario.IconVisible = true;
            this.btn_Inventario.IconZoom = 70D;
            this.btn_Inventario.IsTab = false;
            this.btn_Inventario.Location = new System.Drawing.Point(0, 361);
            this.btn_Inventario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Normalcolor = System.Drawing.Color.Brown;
            this.btn_Inventario.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_Inventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Inventario.selected = false;
            this.btn_Inventario.Size = new System.Drawing.Size(282, 51);
            this.btn_Inventario.TabIndex = 1;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Inventario.Textcolor = System.Drawing.Color.White;
            this.btn_Inventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ver ventas del día";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::CapaPresentacion.Properties.Resources.calendario1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 50D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 42);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(282, 32);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Ver ventas del día";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Realizar Venta";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::CapaPresentacion.Properties.Resources.descuento;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 50D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 10);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(282, 32);
            this.bunifuFlatButton3.TabIndex = 5;
            this.bunifuFlatButton3.Text = "Realizar Venta";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.Linea;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(282, 10);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Ventas.BackColor = System.Drawing.Color.Brown;
            this.btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ventas.BorderRadius = 0;
            this.btn_Ventas.ButtonText = "Ventas";
            this.btn_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ventas.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Ventas.Iconimage = global::CapaPresentacion.Properties.Resources.VentasBlanco;
            this.btn_Ventas.Iconimage_right = null;
            this.btn_Ventas.Iconimage_right_Selected = null;
            this.btn_Ventas.Iconimage_Selected = null;
            this.btn_Ventas.IconMarginLeft = 0;
            this.btn_Ventas.IconMarginRight = 0;
            this.btn_Ventas.IconRightVisible = true;
            this.btn_Ventas.IconRightZoom = 30D;
            this.btn_Ventas.IconVisible = true;
            this.btn_Ventas.IconZoom = 90D;
            this.btn_Ventas.IsTab = false;
            this.btn_Ventas.Location = new System.Drawing.Point(0, 225);
            this.btn_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Normalcolor = System.Drawing.Color.Brown;
            this.btn_Ventas.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_Ventas.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ventas.selected = false;
            this.btn_Ventas.Size = new System.Drawing.Size(282, 51);
            this.btn_Ventas.TabIndex = 0;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ventas.Textcolor = System.Drawing.Color.White;
            this.btn_Ventas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LogoRojo2;
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Linea;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 10);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_CerrarSesión
            // 
            this.btn_CerrarSesión.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CerrarSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CerrarSesión.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CerrarSesión.BorderRadius = 0;
            this.btn_CerrarSesión.ButtonText = "Cerrar Sesión";
            this.btn_CerrarSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarSesión.DisabledColor = System.Drawing.Color.Gray;
            this.btn_CerrarSesión.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesión.Iconimage = global::CapaPresentacion.Properties.Resources.IconCerrarSesión;
            this.btn_CerrarSesión.Iconimage_right = null;
            this.btn_CerrarSesión.Iconimage_right_Selected = null;
            this.btn_CerrarSesión.Iconimage_Selected = null;
            this.btn_CerrarSesión.IconMarginLeft = 0;
            this.btn_CerrarSesión.IconMarginRight = 0;
            this.btn_CerrarSesión.IconRightVisible = true;
            this.btn_CerrarSesión.IconRightZoom = 50D;
            this.btn_CerrarSesión.IconVisible = true;
            this.btn_CerrarSesión.IconZoom = 50D;
            this.btn_CerrarSesión.IsTab = false;
            this.btn_CerrarSesión.Location = new System.Drawing.Point(9, 81);
            this.btn_CerrarSesión.Name = "btn_CerrarSesión";
            this.btn_CerrarSesión.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CerrarSesión.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_CerrarSesión.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_CerrarSesión.selected = false;
            this.btn_CerrarSesión.Size = new System.Drawing.Size(239, 25);
            this.btn_CerrarSesión.TabIndex = 7;
            this.btn_CerrarSesión.Text = "Cerrar Sesión";
            this.btn_CerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CerrarSesión.Textcolor = System.Drawing.Color.White;
            this.btn_CerrarSesión.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_ConsultarCuentas
            // 
            this.btn_ConsultarCuentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ConsultarCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ConsultarCuentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConsultarCuentas.BorderRadius = 0;
            this.btn_ConsultarCuentas.ButtonText = "Consultar cuentas de usuarios";
            this.btn_ConsultarCuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultarCuentas.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ConsultarCuentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ConsultarCuentas.Iconimage = global::CapaPresentacion.Properties.Resources.IconoCuentasUsuarios;
            this.btn_ConsultarCuentas.Iconimage_right = null;
            this.btn_ConsultarCuentas.Iconimage_right_Selected = null;
            this.btn_ConsultarCuentas.Iconimage_Selected = null;
            this.btn_ConsultarCuentas.IconMarginLeft = 0;
            this.btn_ConsultarCuentas.IconMarginRight = 0;
            this.btn_ConsultarCuentas.IconRightVisible = true;
            this.btn_ConsultarCuentas.IconRightZoom = 50D;
            this.btn_ConsultarCuentas.IconVisible = true;
            this.btn_ConsultarCuentas.IconZoom = 50D;
            this.btn_ConsultarCuentas.IsTab = false;
            this.btn_ConsultarCuentas.Location = new System.Drawing.Point(10, 49);
            this.btn_ConsultarCuentas.Name = "btn_ConsultarCuentas";
            this.btn_ConsultarCuentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ConsultarCuentas.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_ConsultarCuentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ConsultarCuentas.selected = false;
            this.btn_ConsultarCuentas.Size = new System.Drawing.Size(239, 25);
            this.btn_ConsultarCuentas.TabIndex = 6;
            this.btn_ConsultarCuentas.Text = "Consultar cuentas de usuarios";
            this.btn_ConsultarCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultarCuentas.Textcolor = System.Drawing.Color.White;
            this.btn_ConsultarCuentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarCuentas.Click += new System.EventHandler(this.btn_ConsultarCuentas_Click);
            // 
            // btn_VerPerfil
            // 
            this.btn_VerPerfil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_VerPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_VerPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VerPerfil.BorderRadius = 0;
            this.btn_VerPerfil.ButtonText = "Ver Perfil";
            this.btn_VerPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerPerfil.DisabledColor = System.Drawing.Color.Gray;
            this.btn_VerPerfil.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_VerPerfil.Iconimage = global::CapaPresentacion.Properties.Resources.IconoUsuario;
            this.btn_VerPerfil.Iconimage_right = null;
            this.btn_VerPerfil.Iconimage_right_Selected = null;
            this.btn_VerPerfil.Iconimage_Selected = null;
            this.btn_VerPerfil.IconMarginLeft = 0;
            this.btn_VerPerfil.IconMarginRight = 0;
            this.btn_VerPerfil.IconRightVisible = true;
            this.btn_VerPerfil.IconRightZoom = 50D;
            this.btn_VerPerfil.IconVisible = true;
            this.btn_VerPerfil.IconZoom = 50D;
            this.btn_VerPerfil.IsTab = false;
            this.btn_VerPerfil.Location = new System.Drawing.Point(10, 16);
            this.btn_VerPerfil.Name = "btn_VerPerfil";
            this.btn_VerPerfil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_VerPerfil.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_VerPerfil.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_VerPerfil.selected = false;
            this.btn_VerPerfil.Size = new System.Drawing.Size(239, 25);
            this.btn_VerPerfil.TabIndex = 5;
            this.btn_VerPerfil.Text = "Ver Perfil";
            this.btn_VerPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerPerfil.Textcolor = System.Drawing.Color.White;
            this.btn_VerPerfil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerPerfil.Click += new System.EventHandler(this.btn_VerPerfil_Click);
            // 
            // btn_MiCuenta
            // 
            this.btn_MiCuenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_MiCuenta.BackColor = System.Drawing.Color.Brown;
            this.btn_MiCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MiCuenta.BorderRadius = 0;
            this.btn_MiCuenta.ButtonText = "     Mi Cuenta";
            this.btn_MiCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MiCuenta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_MiCuenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_MiCuenta.Iconimage = null;
            this.btn_MiCuenta.Iconimage_right = global::CapaPresentacion.Properties.Resources.Triangulo1;
            this.btn_MiCuenta.Iconimage_right_Selected = null;
            this.btn_MiCuenta.Iconimage_Selected = null;
            this.btn_MiCuenta.IconMarginLeft = 0;
            this.btn_MiCuenta.IconMarginRight = 0;
            this.btn_MiCuenta.IconRightVisible = true;
            this.btn_MiCuenta.IconRightZoom = 30D;
            this.btn_MiCuenta.IconVisible = true;
            this.btn_MiCuenta.IconZoom = 30D;
            this.btn_MiCuenta.IsTab = false;
            this.btn_MiCuenta.Location = new System.Drawing.Point(2, 541);
            this.btn_MiCuenta.Name = "btn_MiCuenta";
            this.btn_MiCuenta.Normalcolor = System.Drawing.Color.Brown;
            this.btn_MiCuenta.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btn_MiCuenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_MiCuenta.selected = false;
            this.btn_MiCuenta.Size = new System.Drawing.Size(249, 41);
            this.btn_MiCuenta.TabIndex = 4;
            this.btn_MiCuenta.Text = "     Mi Cuenta";
            this.btn_MiCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MiCuenta.Textcolor = System.Drawing.Color.White;
            this.btn_MiCuenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MiCuenta.Load += new System.EventHandler(this.btn_MiCuenta_Load);
            this.btn_MiCuenta.Click += new System.EventHandler(this.btn_MiCuenta_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelFoother);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelSubMenu2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubMenu1.ResumeLayout(false);
            this.panelFoother.ResumeLayout(false);
            this.panelFoother.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelLateral;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Proveedores;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Empleados;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ventas;
        private Bunifu.Framework.UI.BunifuFlatButton btn_MiCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFoother;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer HoraYFecha;
        private Bunifu.Framework.UI.BunifuFormFadeTransition EnclarecerFormulario;
        private Bunifu.Framework.UI.BunifuElipse ContornoLateral;
        private Bunifu.Framework.UI.BunifuElipse ContornoDelForm;
        private Bunifu.Framework.UI.BunifuElipse ContornoDelSubMenu;
        private System.Windows.Forms.Panel panelSubMenu1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CerrarSesión;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ConsultarCuentas;
        private Bunifu.Framework.UI.BunifuFlatButton btn_VerPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSubMenu2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel1;
    }
}