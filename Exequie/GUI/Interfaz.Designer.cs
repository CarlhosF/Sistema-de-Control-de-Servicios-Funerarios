
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
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnDifuntos = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btn_Sucursales = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.pn_botones = new System.Windows.Forms.Panel();
            this.lb_session_nombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_session_rol = new System.Windows.Forms.ToolStripStatusLabel();
            this.pn_botones.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_contenedor
            // 
            this.pn_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contenedor.Location = new System.Drawing.Point(93, 0);
            this.pn_contenedor.Name = "pn_contenedor";
            this.pn_contenedor.Size = new System.Drawing.Size(1120, 685);
            this.pn_contenedor.TabIndex = 4;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.Image")));
            this.btn_CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(8, 621);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(79, 62);
            this.btn_CerrarSesion.TabIndex = 9;
            this.btn_CerrarSesion.Text = "Cerrar sesion";
            this.btn_CerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click_1);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.Image")));
            this.btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Usuarios.Location = new System.Drawing.Point(8, 77);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(79, 62);
            this.btn_Usuarios.TabIndex = 8;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click_1);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacion.Image")));
            this.btnInformacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInformacion.Location = new System.Drawing.Point(8, 553);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(79, 62);
            this.btnInformacion.TabIndex = 7;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Image")));
            this.btnMovimientos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMovimientos.Location = new System.Drawing.Point(7, 417);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(79, 62);
            this.btnMovimientos.TabIndex = 6;
            this.btnMovimientos.Text = "Abonos";
            this.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnDifuntos
            // 
            this.btnDifuntos.Image = ((System.Drawing.Image)(resources.GetObject("btnDifuntos.Image")));
            this.btnDifuntos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDifuntos.Location = new System.Drawing.Point(8, 485);
            this.btnDifuntos.Name = "btnDifuntos";
            this.btnDifuntos.Size = new System.Drawing.Size(79, 62);
            this.btnDifuntos.TabIndex = 5;
            this.btnDifuntos.Text = "Entregas";
            this.btnDifuntos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDifuntos.UseVisualStyleBackColor = true;
            this.btnDifuntos.Click += new System.EventHandler(this.btnDifuntos_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.Image = ((System.Drawing.Image)(resources.GetObject("btnContratos.Image")));
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContratos.Location = new System.Drawing.Point(7, 349);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(79, 62);
            this.btnContratos.TabIndex = 4;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btn_Sucursales
            // 
            this.btn_Sucursales.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sucursales.Image")));
            this.btn_Sucursales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sucursales.Location = new System.Drawing.Point(5, 213);
            this.btn_Sucursales.Name = "btn_Sucursales";
            this.btn_Sucursales.Size = new System.Drawing.Size(82, 62);
            this.btn_Sucursales.TabIndex = 3;
            this.btn_Sucursales.Text = "Sucursales";
            this.btn_Sucursales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sucursales.UseVisualStyleBackColor = true;
            this.btn_Sucursales.Click += new System.EventHandler(this.btn_Sucursales_Click_1);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clientes.Image")));
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clientes.Location = new System.Drawing.Point(8, 281);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(79, 62);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(8, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Politicas de Negocio";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSercicios_Click);
            // 
            // btn_Personal
            // 
            this.btn_Personal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Personal.Image")));
            this.btn_Personal.Location = new System.Drawing.Point(8, 145);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(79, 62);
            this.btn_Personal.TabIndex = 0;
            this.btn_Personal.Text = "Empleados";
            this.btn_Personal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click_1);
            // 
            // pn_botones
            // 
            this.pn_botones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pn_botones.Controls.Add(this.btn_CerrarSesion);
            this.pn_botones.Controls.Add(this.btn_Usuarios);
            this.pn_botones.Controls.Add(this.btnInformacion);
            this.pn_botones.Controls.Add(this.btnMovimientos);
            this.pn_botones.Controls.Add(this.btnDifuntos);
            this.pn_botones.Controls.Add(this.btnContratos);
            this.pn_botones.Controls.Add(this.btn_Sucursales);
            this.pn_botones.Controls.Add(this.btn_Clientes);
            this.pn_botones.Controls.Add(this.button2);
            this.pn_botones.Controls.Add(this.btn_Personal);
            this.pn_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_botones.Location = new System.Drawing.Point(0, 0);
            this.pn_botones.Name = "pn_botones";
            this.pn_botones.Size = new System.Drawing.Size(93, 685);
            this.pn_botones.TabIndex = 3;
            // 
            // lb_session_nombre
            // 
            this.lb_session_nombre.Name = "lb_session_nombre";
            this.lb_session_nombre.Size = new System.Drawing.Size(53, 17);
            this.lb_session_nombre.Text = "Usuario: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_session_nombre,
            this.lb_session_rol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1213, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_session_rol
            // 
            this.lb_session_rol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lb_session_rol.Name = "lb_session_rol";
            this.lb_session_rol.Size = new System.Drawing.Size(27, 17);
            this.lb_session_rol.Text = "Rol:";
            this.lb_session_rol.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 707);
            this.Controls.Add(this.pn_contenedor);
            this.Controls.Add(this.pn_botones);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfaz";
            this.Text = "FUNERARIAS \"EL CONSOLADOR\"";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.pn_botones.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Panel pn_botones;
        private System.Windows.Forms.ToolStripStatusLabel lb_session_nombre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_session_rol;
    }
}