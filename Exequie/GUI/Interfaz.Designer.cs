
namespace Exequie.GUI
{
    partial class Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            this.pn_contenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbrol = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_botones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnDifuntos = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btn_Sucursales = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btnPoliticas = new System.Windows.Forms.Button();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pn_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_contenedor
            // 
            this.pn_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contenedor.Location = new System.Drawing.Point(181, 134);
            this.pn_contenedor.Name = "pn_contenedor";
            this.pn_contenedor.Size = new System.Drawing.Size(1032, 573);
            this.pn_contenedor.TabIndex = 4;
            this.pn_contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_contenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbrol);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(181, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 134);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(195, 69);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(117, 33);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "TITULO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "rol:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbrol
            // 
            this.lbrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbrol.AutoSize = true;
            this.lbrol.BackColor = System.Drawing.Color.Transparent;
            this.lbrol.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrol.Location = new System.Drawing.Point(387, 9);
            this.lbrol.Name = "lbrol";
            this.lbrol.Size = new System.Drawing.Size(28, 13);
            this.lbrol.TabIndex = 3;
            this.lbrol.Text = "rol";
            this.lbrol.Click += new System.EventHandler(this.lbrol_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(527, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(75, 5);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(14, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = ".";
            this.lbUsuario.Click += new System.EventHandler(this.lbUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pn_botones
            // 
            this.pn_botones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_botones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_botones.BackgroundImage")));
            this.pn_botones.Controls.Add(this.pictureBox1);
            this.pn_botones.Controls.Add(this.btn_CerrarSesion);
            this.pn_botones.Controls.Add(this.btn_Usuarios);
            this.pn_botones.Controls.Add(this.btnInformacion);
            this.pn_botones.Controls.Add(this.btnMovimientos);
            this.pn_botones.Controls.Add(this.btnDifuntos);
            this.pn_botones.Controls.Add(this.btnContratos);
            this.pn_botones.Controls.Add(this.btn_Sucursales);
            this.pn_botones.Controls.Add(this.btn_Clientes);
            this.pn_botones.Controls.Add(this.btnPoliticas);
            this.pn_botones.Controls.Add(this.btn_Personal);
            this.pn_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_botones.Location = new System.Drawing.Point(0, 0);
            this.pn_botones.Name = "pn_botones";
            this.pn_botones.Size = new System.Drawing.Size(181, 707);
            this.pn_botones.TabIndex = 3;
            this.pn_botones.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_botones_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = global::Exequie.Properties.Resources.logo_consolador;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Exequie.Properties.Resources.logo_consolador;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.Image")));
            this.btn_CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(7, 640);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(167, 42);
            this.btn_CerrarSesion.TabIndex = 9;
            this.btn_CerrarSesion.Text = "Cerrar sesion";
            this.btn_CerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click_1);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.Image")));
            this.btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Usuarios.Location = new System.Drawing.Point(7, 474);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(167, 39);
            this.btn_Usuarios.TabIndex = 8;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click_1);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacion.Image")));
            this.btnInformacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInformacion.Location = new System.Drawing.Point(7, 591);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(167, 43);
            this.btnInformacion.TabIndex = 7;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Image")));
            this.btnMovimientos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMovimientos.Location = new System.Drawing.Point(7, 254);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(167, 40);
            this.btnMovimientos.TabIndex = 6;
            this.btnMovimientos.Text = "Abonos";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnDifuntos
            // 
            this.btnDifuntos.Image = ((System.Drawing.Image)(resources.GetObject("btnDifuntos.Image")));
            this.btnDifuntos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDifuntos.Location = new System.Drawing.Point(7, 300);
            this.btnDifuntos.Name = "btnDifuntos";
            this.btnDifuntos.Size = new System.Drawing.Size(167, 38);
            this.btnDifuntos.TabIndex = 5;
            this.btnDifuntos.Text = "Entregas";
            this.btnDifuntos.UseVisualStyleBackColor = true;
            this.btnDifuntos.Click += new System.EventHandler(this.btnDifuntos_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.Image = ((System.Drawing.Image)(resources.GetObject("btnContratos.Image")));
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnContratos.Location = new System.Drawing.Point(7, 208);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(167, 40);
            this.btnContratos.TabIndex = 4;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btn_Sucursales
            // 
            this.btn_Sucursales.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sucursales.Image")));
            this.btn_Sucursales.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Sucursales.Location = new System.Drawing.Point(7, 386);
            this.btn_Sucursales.Name = "btn_Sucursales";
            this.btn_Sucursales.Size = new System.Drawing.Size(167, 38);
            this.btn_Sucursales.TabIndex = 3;
            this.btn_Sucursales.Text = "Sucursales";
            this.btn_Sucursales.UseVisualStyleBackColor = true;
            this.btn_Sucursales.Click += new System.EventHandler(this.btn_Sucursales_Click_1);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clientes.Image")));
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Clientes.Location = new System.Drawing.Point(7, 165);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(167, 37);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click_1);
            // 
            // btnPoliticas
            // 
            this.btnPoliticas.Image = ((System.Drawing.Image)(resources.GetObject("btnPoliticas.Image")));
            this.btnPoliticas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPoliticas.Location = new System.Drawing.Point(7, 430);
            this.btnPoliticas.Name = "btnPoliticas";
            this.btnPoliticas.Size = new System.Drawing.Size(167, 38);
            this.btnPoliticas.TabIndex = 1;
            this.btnPoliticas.Text = "Politicas de Negocios";
            this.btnPoliticas.UseVisualStyleBackColor = true;
            this.btnPoliticas.Click += new System.EventHandler(this.btnSercicios_Click);
            // 
            // btn_Personal
            // 
            this.btn_Personal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Personal.Image")));
            this.btn_Personal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Personal.Location = new System.Drawing.Point(7, 344);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(167, 36);
            this.btn_Personal.TabIndex = 0;
            this.btn_Personal.Text = "Empleados";
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click_1);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 707);
            this.Controls.Add(this.pn_contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_botones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfaz";
            this.Text = "FUNERARIAS \"EL CONSOLADOR\"";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pn_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_contenedor;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnDifuntos;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btn_Sucursales;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btnPoliticas;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Panel pn_botones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitulo;
    }
}