namespace Sistema.GUI
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_session_nombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.pn_contenedor = new System.Windows.Forms.Panel();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Sucursales = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.pn_botones = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.pn_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_session_nombre});
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(97, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_session_nombre
            // 
            this.lb_session_nombre.Name = "lb_session_nombre";
            this.lb_session_nombre.Size = new System.Drawing.Size(53, 17);
            this.lb_session_nombre.Text = "Usuario: ";
            // 
            // pn_contenedor
            // 
            this.pn_contenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_contenedor.Location = new System.Drawing.Point(97, 0);
            this.pn_contenedor.Name = "pn_contenedor";
            this.pn_contenedor.Size = new System.Drawing.Size(1092, 671);
            this.pn_contenedor.TabIndex = 1;
            // 
            // btn_Personal
            // 
            this.btn_Personal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Personal.Image")));
            this.btn_Personal.Location = new System.Drawing.Point(3, 157);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(79, 62);
            this.btn_Personal.TabIndex = 0;
            this.btn_Personal.Text = "Empleados";
            this.btn_Personal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(3, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Politicas de Negocio";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clientes.Image")));
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clientes.Location = new System.Drawing.Point(3, 293);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(79, 62);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Sucursales
            // 
            this.btn_Sucursales.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sucursales.Image")));
            this.btn_Sucursales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sucursales.Location = new System.Drawing.Point(0, 225);
            this.btn_Sucursales.Name = "btn_Sucursales";
            this.btn_Sucursales.Size = new System.Drawing.Size(82, 62);
            this.btn_Sucursales.TabIndex = 3;
            this.btn_Sucursales.Text = "Sucursales";
            this.btn_Sucursales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sucursales.UseVisualStyleBackColor = true;
            this.btn_Sucursales.Click += new System.EventHandler(this.btn_Sucursales_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(2, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "Contratos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(3, 497);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 62);
            this.button6.TabIndex = 5;
            this.button6.Text = "Difuntos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.Location = new System.Drawing.Point(2, 429);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 62);
            this.button7.TabIndex = 6;
            this.button7.Text = "Movimientos";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.Location = new System.Drawing.Point(3, 565);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 62);
            this.button8.TabIndex = 7;
            this.button8.Text = "Informacion";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.Image")));
            this.btn_Usuarios.Location = new System.Drawing.Point(3, 89);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(79, 62);
            this.btn_Usuarios.TabIndex = 8;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // pn_botones
            // 
            this.pn_botones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pn_botones.Controls.Add(this.btn_Usuarios);
            this.pn_botones.Controls.Add(this.button8);
            this.pn_botones.Controls.Add(this.button7);
            this.pn_botones.Controls.Add(this.button6);
            this.pn_botones.Controls.Add(this.button5);
            this.pn_botones.Controls.Add(this.btn_Sucursales);
            this.pn_botones.Controls.Add(this.btn_Clientes);
            this.pn_botones.Controls.Add(this.button2);
            this.pn_botones.Controls.Add(this.btn_Personal);
            this.pn_botones.Location = new System.Drawing.Point(-2, 0);
            this.pn_botones.Name = "pn_botones";
            this.pn_botones.Size = new System.Drawing.Size(93, 724);
            this.pn_botones.TabIndex = 0;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 671);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pn_contenedor);
            this.Controls.Add(this.pn_botones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUNERARIA EL CONSOLADOR";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pn_botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_session_nombre;
        private System.Windows.Forms.Panel pn_contenedor;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Sucursales;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Panel pn_botones;
    }
}