namespace CapaPresentacion
{
    partial class FrmConsultarCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTituloFrm = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tablaCuentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btNuevoEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btEliminarEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Brown;
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.LblTituloFrm);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1130, 75);
            this.TopPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1082, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblTituloFrm
            // 
            this.LblTituloFrm.AutoSize = true;
            this.LblTituloFrm.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFrm.ForeColor = System.Drawing.Color.White;
            this.LblTituloFrm.Location = new System.Drawing.Point(69, 11);
            this.LblTituloFrm.Name = "LblTituloFrm";
            this.LblTituloFrm.Size = new System.Drawing.Size(387, 33);
            this.LblTituloFrm.TabIndex = 1;
            this.LblTituloFrm.Text = "Consultar cuentas existentes";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.Location = new System.Drawing.Point(66, 106);
            this.TxtBuscar.MaxLength = 30;
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(321, 27);
            this.TxtBuscar.TabIndex = 13;
            this.TxtBuscar.Text = "Usuario | Nombre | Clave empleado";
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(385, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // tablaCuentas
            // 
            this.tablaCuentas.AllowUserToAddRows = false;
            this.tablaCuentas.AllowUserToDeleteRows = false;
            this.tablaCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCuentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCuentas.BackgroundColor = System.Drawing.Color.White;
            this.tablaCuentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCuentas.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCuentas.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaCuentas.Location = new System.Drawing.Point(16, 209);
            this.tablaCuentas.Name = "tablaCuentas";
            this.tablaCuentas.ReadOnly = true;
            this.tablaCuentas.RowHeadersVisible = false;
            this.tablaCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCuentas.Size = new System.Drawing.Size(1100, 504);
            this.tablaCuentas.TabIndex = 15;
            this.tablaCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCuentas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Colonia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Municipio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "CP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(643, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(749, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(833, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "RFC";
            // 
            // btNuevoEmpleado
            // 
            this.btNuevoEmpleado.Activecolor = System.Drawing.Color.Brown;
            this.btNuevoEmpleado.BackColor = System.Drawing.Color.Brown;
            this.btNuevoEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNuevoEmpleado.BorderRadius = 0;
            this.btNuevoEmpleado.ButtonText = "Nuevo empleado";
            this.btNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNuevoEmpleado.DisabledColor = System.Drawing.Color.Brown;
            this.btNuevoEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btNuevoEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btNuevoEmpleado.Iconimage")));
            this.btNuevoEmpleado.Iconimage_right = null;
            this.btNuevoEmpleado.Iconimage_right_Selected = null;
            this.btNuevoEmpleado.Iconimage_Selected = null;
            this.btNuevoEmpleado.IconMarginLeft = 0;
            this.btNuevoEmpleado.IconMarginRight = 0;
            this.btNuevoEmpleado.IconRightVisible = true;
            this.btNuevoEmpleado.IconRightZoom = 0D;
            this.btNuevoEmpleado.IconVisible = true;
            this.btNuevoEmpleado.IconZoom = 70D;
            this.btNuevoEmpleado.IsTab = false;
            this.btNuevoEmpleado.Location = new System.Drawing.Point(692, 99);
            this.btNuevoEmpleado.Name = "btNuevoEmpleado";
            this.btNuevoEmpleado.Normalcolor = System.Drawing.Color.Brown;
            this.btNuevoEmpleado.OnHovercolor = System.Drawing.Color.Brown;
            this.btNuevoEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btNuevoEmpleado.selected = false;
            this.btNuevoEmpleado.Size = new System.Drawing.Size(192, 39);
            this.btNuevoEmpleado.TabIndex = 26;
            this.btNuevoEmpleado.Text = "Nuevo empleado";
            this.btNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNuevoEmpleado.Textcolor = System.Drawing.Color.White;
            this.btNuevoEmpleado.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoEmpleado.Click += new System.EventHandler(this.btNuevoEmpleado_Click);
            // 
            // btEliminarEmpleado
            // 
            this.btEliminarEmpleado.Activecolor = System.Drawing.Color.Brown;
            this.btEliminarEmpleado.BackColor = System.Drawing.Color.Brown;
            this.btEliminarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarEmpleado.BorderRadius = 0;
            this.btEliminarEmpleado.ButtonText = "Eliminar empleado";
            this.btEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminarEmpleado.DisabledColor = System.Drawing.Color.Brown;
            this.btEliminarEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btEliminarEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btEliminarEmpleado.Iconimage")));
            this.btEliminarEmpleado.Iconimage_right = null;
            this.btEliminarEmpleado.Iconimage_right_Selected = null;
            this.btEliminarEmpleado.Iconimage_Selected = null;
            this.btEliminarEmpleado.IconMarginLeft = 0;
            this.btEliminarEmpleado.IconMarginRight = 0;
            this.btEliminarEmpleado.IconRightVisible = true;
            this.btEliminarEmpleado.IconRightZoom = 0D;
            this.btEliminarEmpleado.IconVisible = true;
            this.btEliminarEmpleado.IconZoom = 60D;
            this.btEliminarEmpleado.IsTab = false;
            this.btEliminarEmpleado.Location = new System.Drawing.Point(913, 99);
            this.btEliminarEmpleado.Name = "btEliminarEmpleado";
            this.btEliminarEmpleado.Normalcolor = System.Drawing.Color.Brown;
            this.btEliminarEmpleado.OnHovercolor = System.Drawing.Color.Brown;
            this.btEliminarEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btEliminarEmpleado.selected = false;
            this.btEliminarEmpleado.Size = new System.Drawing.Size(203, 39);
            this.btEliminarEmpleado.TabIndex = 27;
            this.btEliminarEmpleado.Text = "Eliminar empleado";
            this.btEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminarEmpleado.Textcolor = System.Drawing.Color.White;
            this.btEliminarEmpleado.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmConsultarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 725);
            this.Controls.Add(this.btEliminarEmpleado);
            this.Controls.Add(this.btNuevoEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaCuentas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarCuentas";
            this.Load += new System.EventHandler(this.FrmConsultarCuentas_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTituloFrm;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView tablaCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuFlatButton btNuevoEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btEliminarEmpleado;
    }
}