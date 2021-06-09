namespace CapaPresentacion
{
    partial class FormReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.VerDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ReporteVentas = new System.Windows.Forms.Button();
            this.RB_Fecha = new System.Windows.Forms.RadioButton();
            this.RB_NumVenta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.DTP_Destino = new System.Windows.Forms.DateTimePicker();
            this.DTP_Inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lb_Buscar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_totalVentas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lb_Meta = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.BarraDeProgresoVentasDelDía = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timerVentasDia = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(24, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 487);
            this.panel1.TabIndex = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_Detalle);
            this.groupBox2.Location = new System.Drawing.Point(16, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de la venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medidas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "#";
            // 
            // dgv_Detalle
            // 
            this.dgv_Detalle.AllowUserToAddRows = false;
            this.dgv_Detalle.AllowUserToDeleteRows = false;
            this.dgv_Detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Detalle.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Detalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Detalle.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Detalle.Location = new System.Drawing.Point(6, 54);
            this.dgv_Detalle.Name = "dgv_Detalle";
            this.dgv_Detalle.ReadOnly = true;
            this.dgv_Detalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Detalle.RowHeadersVisible = false;
            this.dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Detalle.Size = new System.Drawing.Size(771, 136);
            this.dgv_Detalle.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dgv_Ventas);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas del Día";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(697, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Ver detalles";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(565, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(415, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Codigo Empleado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Hora";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "#";
            // 
            // dgv_Ventas
            // 
            this.dgv_Ventas.AllowUserToAddRows = false;
            this.dgv_Ventas.AllowUserToDeleteRows = false;
            this.dgv_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ventas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ventas.ColumnHeadersVisible = false;
            this.dgv_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerDetalle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Ventas.Location = new System.Drawing.Point(6, 36);
            this.dgv_Ventas.Name = "dgv_Ventas";
            this.dgv_Ventas.ReadOnly = true;
            this.dgv_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Ventas.RowHeadersVisible = false;
            this.dgv_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Ventas.Size = new System.Drawing.Size(771, 226);
            this.dgv_Ventas.TabIndex = 8;
            this.dgv_Ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ventas_CellContentClick);
            // 
            // VerDetalle
            // 
            this.VerDetalle.HeaderText = "Detalle";
            this.VerDetalle.Image = global::CapaPresentacion.Properties.Resources.Ojo;
            this.VerDetalle.Name = "VerDetalle";
            this.VerDetalle.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_ReporteVentas);
            this.panel3.Controls.Add(this.RB_Fecha);
            this.panel3.Controls.Add(this.RB_NumVenta);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label_A);
            this.panel3.Controls.Add(this.DTP_Destino);
            this.panel3.Controls.Add(this.DTP_Inicio);
            this.panel3.Controls.Add(this.btn_Buscar);
            this.panel3.Controls.Add(this.txt_Buscar);
            this.panel3.Controls.Add(this.lb_Buscar);
            this.panel3.Location = new System.Drawing.Point(24, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 119);
            this.panel3.TabIndex = 80;
            // 
            // btn_ReporteVentas
            // 
            this.btn_ReporteVentas.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ReporteVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ReporteVentas.FlatAppearance.BorderSize = 0;
            this.btn_ReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReporteVentas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReporteVentas.ForeColor = System.Drawing.Color.White;
            this.btn_ReporteVentas.Image = global::CapaPresentacion.Properties.Resources.archivo_excel;
            this.btn_ReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReporteVentas.Location = new System.Drawing.Point(585, 31);
            this.btn_ReporteVentas.Name = "btn_ReporteVentas";
            this.btn_ReporteVentas.Size = new System.Drawing.Size(199, 58);
            this.btn_ReporteVentas.TabIndex = 3;
            this.btn_ReporteVentas.Text = "Generar Reporte \r\nde venta";
            this.btn_ReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReporteVentas.UseVisualStyleBackColor = false;
            this.btn_ReporteVentas.Click += new System.EventHandler(this.btn_ReporteVentas_Click);
            // 
            // RB_Fecha
            // 
            this.RB_Fecha.AutoSize = true;
            this.RB_Fecha.Location = new System.Drawing.Point(239, 69);
            this.RB_Fecha.Name = "RB_Fecha";
            this.RB_Fecha.Size = new System.Drawing.Size(124, 20);
            this.RB_Fecha.TabIndex = 14;
            this.RB_Fecha.TabStop = true;
            this.RB_Fecha.Text = "Buscar por fecha";
            this.RB_Fecha.UseVisualStyleBackColor = true;
            this.RB_Fecha.CheckedChanged += new System.EventHandler(this.RB_Fecha_CheckedChanged);
            // 
            // RB_NumVenta
            // 
            this.RB_NumVenta.AutoSize = true;
            this.RB_NumVenta.Location = new System.Drawing.Point(96, 61);
            this.RB_NumVenta.Name = "RB_NumVenta";
            this.RB_NumVenta.Size = new System.Drawing.Size(121, 36);
            this.RB_NumVenta.TabIndex = 13;
            this.RB_NumVenta.TabStop = true;
            this.RB_NumVenta.Text = "Buscar por\r\nnúmero de venta";
            this.RB_NumVenta.UseVisualStyleBackColor = true;
            this.RB_NumVenta.CheckedChanged += new System.EventHandler(this.RB_NumVenta_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filtros";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(497, 53);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(17, 16);
            this.label_A.TabIndex = 11;
            this.label_A.Text = "A";
            // 
            // DTP_Destino
            // 
            this.DTP_Destino.CustomFormat = "MM/dd/yyyy";
            this.DTP_Destino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Destino.Location = new System.Drawing.Point(520, 47);
            this.DTP_Destino.Name = "DTP_Destino";
            this.DTP_Destino.Size = new System.Drawing.Size(138, 22);
            this.DTP_Destino.TabIndex = 10;
            // 
            // DTP_Inicio
            // 
            this.DTP_Inicio.CustomFormat = "MM/dd/yyyy";
            this.DTP_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Inicio.Location = new System.Drawing.Point(353, 49);
            this.DTP_Inicio.Name = "DTP_Inicio";
            this.DTP_Inicio.Size = new System.Drawing.Size(138, 22);
            this.DTP_Inicio.TabIndex = 2;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.ActiveBorderThickness = 1;
            this.btn_Buscar.ActiveCornerRadius = 20;
            this.btn_Buscar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Buscar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Buscar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Buscar.BackColor = System.Drawing.Color.White;
            this.btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.BackgroundImage")));
            this.btn_Buscar.ButtonText = "Buscar";
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Buscar.IdleBorderThickness = 1;
            this.btn_Buscar.IdleCornerRadius = 20;
            this.btn_Buscar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Buscar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Buscar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Buscar.Location = new System.Drawing.Point(353, 5);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(138, 34);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(78, 12);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(260, 22);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscar_KeyPress);
            // 
            // lb_Buscar
            // 
            this.lb_Buscar.AutoSize = true;
            this.lb_Buscar.Location = new System.Drawing.Point(19, 15);
            this.lb_Buscar.Name = "lb_Buscar";
            this.lb_Buscar.Size = new System.Drawing.Size(53, 16);
            this.lb_Buscar.TabIndex = 16;
            this.lb_Buscar.Text = "Buscar:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel4.Controls.Add(this.lb_Meta);
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.BarraDeProgresoVentasDelDía);
            this.panel4.Location = new System.Drawing.Point(850, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 612);
            this.panel4.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_totalVentas);
            this.panel2.Location = new System.Drawing.Point(71, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 53);
            this.panel2.TabIndex = 18;
            // 
            // lb_totalVentas
            // 
            this.lb_totalVentas.BackColor = System.Drawing.Color.White;
            this.lb_totalVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.75F);
            this.lb_totalVentas.ForeColor = System.Drawing.Color.Black;
            this.lb_totalVentas.Location = new System.Drawing.Point(14, 11);
            this.lb_totalVentas.Name = "lb_totalVentas";
            this.lb_totalVentas.Size = new System.Drawing.Size(87, 33);
            this.lb_totalVentas.TabIndex = 19;
            this.lb_totalVentas.Text = "100";
            this.lb_totalVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Brown;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(58, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 48);
            this.label9.TabIndex = 17;
            this.label9.Text = "Num. ventas \r\nrealizadas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 50;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(41, 306);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Brown;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(169, 169);
            this.bunifuCircleProgressbar1.TabIndex = 16;
            this.bunifuCircleProgressbar1.Value = 100;
            // 
            // lb_Meta
            // 
            this.lb_Meta.AutoSize = true;
            this.lb_Meta.BackColor = System.Drawing.Color.Brown;
            this.lb_Meta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lb_Meta.ForeColor = System.Drawing.Color.White;
            this.lb_Meta.Location = new System.Drawing.Point(42, 249);
            this.lb_Meta.Name = "lb_Meta";
            this.lb_Meta.Size = new System.Drawing.Size(78, 24);
            this.lb_Meta.TabIndex = 15;
            this.lb_Meta.Text = "N de M";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::CapaPresentacion.Properties.Resources.Icono_Ajuste;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(201, 208);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 14;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(46, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Meta del día al";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BarraDeProgresoVentasDelDía
            // 
            this.BarraDeProgresoVentasDelDía.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraDeProgresoVentasDelDía.animated = false;
            this.BarraDeProgresoVentasDelDía.animationIterval = 5;
            this.BarraDeProgresoVentasDelDía.animationSpeed = 50;
            this.BarraDeProgresoVentasDelDía.BackColor = System.Drawing.Color.White;
            this.BarraDeProgresoVentasDelDía.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraDeProgresoVentasDelDía.BackgroundImage")));
            this.BarraDeProgresoVentasDelDía.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.BarraDeProgresoVentasDelDía.ForeColor = System.Drawing.Color.Black;
            this.BarraDeProgresoVentasDelDía.LabelVisible = true;
            this.BarraDeProgresoVentasDelDía.LineProgressThickness = 8;
            this.BarraDeProgresoVentasDelDía.LineThickness = 5;
            this.BarraDeProgresoVentasDelDía.Location = new System.Drawing.Point(41, 69);
            this.BarraDeProgresoVentasDelDía.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BarraDeProgresoVentasDelDía.MaxValue = 100;
            this.BarraDeProgresoVentasDelDía.Name = "BarraDeProgresoVentasDelDía";
            this.BarraDeProgresoVentasDelDía.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.BarraDeProgresoVentasDelDía.ProgressColor = System.Drawing.Color.Brown;
            this.BarraDeProgresoVentasDelDía.Size = new System.Drawing.Size(169, 169);
            this.BarraDeProgresoVentasDelDía.TabIndex = 0;
            this.BarraDeProgresoVentasDelDía.Value = 0;
            // 
            // timerVentasDia
            // 
            this.timerVentasDia.Enabled = true;
            this.timerVentasDia.Interval = 20;
            this.timerVentasDia.Tick += new System.EventHandler(this.timerVentasDia_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Detalle";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.Ojo;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 771;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 693);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteVentas";
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar BarraDeProgresoVentasDelDía;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lb_Buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Detalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Fecha;
        private System.Windows.Forms.RadioButton RB_NumVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.DateTimePicker DTP_Destino;
        private System.Windows.Forms.DateTimePicker DTP_Inicio;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_Ventas;
        private System.Windows.Forms.DataGridViewImageColumn VerDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Timer timerVentasDia;
        private System.Windows.Forms.Label lb_Meta;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_totalVentas;
        private System.Windows.Forms.Button btn_ReporteVentas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}