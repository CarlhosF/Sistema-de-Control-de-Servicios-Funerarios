
namespace Empleados_Modulo.GUI
{
    partial class Empleados_Gestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados_Gestor));
            this.Control_modulo = new System.Windows.Forms.TabControl();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.dt_Empleados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Eliminar_Empleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Editar_Empleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Agragar_Empleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Actualizar_Empleado = new System.Windows.Forms.ToolStripButton();
            this.tb_Filtrar_Empleado = new System.Windows.Forms.ToolStripTextBox();
            this.lb_Filtrar_Empleado = new System.Windows.Forms.ToolStripLabel();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.Roles = new System.Windows.Forms.TabPage();
            this.dt_usuarios = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Eliminar_Usuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Editar_Usuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Agregar_usuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Actualizar_Usuario = new System.Windows.Forms.ToolStripButton();
            this.txb_Filtrar_Usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dt_roles = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.bnt_eliminar_rol = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_editar_rol = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_agregar_rol = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_actualizar_rol = new System.Windows.Forms.ToolStripButton();
            this.txb_filtrar_rol = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Control_modulo.SuspendLayout();
            this.Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Empleados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.Usuarios.SuspendLayout();
            this.Roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_usuarios)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_roles)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_modulo
            // 
            this.Control_modulo.Controls.Add(this.Empleados);
            this.Control_modulo.Controls.Add(this.Usuarios);
            this.Control_modulo.Controls.Add(this.Roles);
            this.Control_modulo.Location = new System.Drawing.Point(4, 0);
            this.Control_modulo.Name = "Control_modulo";
            this.Control_modulo.SelectedIndex = 0;
            this.Control_modulo.Size = new System.Drawing.Size(820, 475);
            this.Control_modulo.TabIndex = 0;
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.dt_Empleados);
            this.Empleados.Controls.Add(this.toolStrip1);
            this.Empleados.Location = new System.Drawing.Point(4, 22);
            this.Empleados.Name = "Empleados";
            this.Empleados.Padding = new System.Windows.Forms.Padding(3);
            this.Empleados.Size = new System.Drawing.Size(812, 449);
            this.Empleados.TabIndex = 0;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // dt_Empleados
            // 
            this.dt_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Empleados.Location = new System.Drawing.Point(4, 36);
            this.dt_Empleados.MultiSelect = false;
            this.dt_Empleados.Name = "dt_Empleados";
            this.dt_Empleados.ReadOnly = true;
            this.dt_Empleados.Size = new System.Drawing.Size(805, 410);
            this.dt_Empleados.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Eliminar_Empleado,
            this.toolStripSeparator1,
            this.btn_Editar_Empleado,
            this.toolStripSeparator2,
            this.btn_Agragar_Empleado,
            this.toolStripSeparator3,
            this.btn_Actualizar_Empleado,
            this.tb_Filtrar_Empleado,
            this.lb_Filtrar_Empleado});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Eliminar_Empleado
            // 
            this.btn_Eliminar_Empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar_Empleado.Image")));
            this.btn_Eliminar_Empleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Eliminar_Empleado.Name = "btn_Eliminar_Empleado";
            this.btn_Eliminar_Empleado.Size = new System.Drawing.Size(70, 22);
            this.btn_Eliminar_Empleado.Text = "Eliminar";
            this.btn_Eliminar_Empleado.Click += new System.EventHandler(this.btn_Eliminar_Empleado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Editar_Empleado
            // 
            this.btn_Editar_Empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar_Empleado.Image")));
            this.btn_Editar_Empleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar_Empleado.Name = "btn_Editar_Empleado";
            this.btn_Editar_Empleado.Size = new System.Drawing.Size(57, 22);
            this.btn_Editar_Empleado.Text = "Editar";
            this.btn_Editar_Empleado.Click += new System.EventHandler(this.btn_Editar_Empleado_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Agragar_Empleado
            // 
            this.btn_Agragar_Empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agragar_Empleado.Image")));
            this.btn_Agragar_Empleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Agragar_Empleado.Name = "btn_Agragar_Empleado";
            this.btn_Agragar_Empleado.Size = new System.Drawing.Size(69, 22);
            this.btn_Agragar_Empleado.Text = "Agregar";
            this.btn_Agragar_Empleado.Click += new System.EventHandler(this.btn_Agragar_Empleado_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Actualizar_Empleado
            // 
            this.btn_Actualizar_Empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar_Empleado.Image")));
            this.btn_Actualizar_Empleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Actualizar_Empleado.Name = "btn_Actualizar_Empleado";
            this.btn_Actualizar_Empleado.Size = new System.Drawing.Size(79, 22);
            this.btn_Actualizar_Empleado.Text = "Actualizar";
            this.btn_Actualizar_Empleado.Click += new System.EventHandler(this.btn_Actualizar_Empleado_Click);
            // 
            // tb_Filtrar_Empleado
            // 
            this.tb_Filtrar_Empleado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tb_Filtrar_Empleado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Filtrar_Empleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Filtrar_Empleado.Name = "tb_Filtrar_Empleado";
            this.tb_Filtrar_Empleado.Size = new System.Drawing.Size(100, 25);
            this.tb_Filtrar_Empleado.TextChanged += new System.EventHandler(this.tb_Filtrar_Empleado_TextChanged);
            // 
            // lb_Filtrar_Empleado
            // 
            this.lb_Filtrar_Empleado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lb_Filtrar_Empleado.Name = "lb_Filtrar_Empleado";
            this.lb_Filtrar_Empleado.Size = new System.Drawing.Size(40, 22);
            this.lb_Filtrar_Empleado.Text = "Filtrar:";
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.dt_usuarios);
            this.Usuarios.Controls.Add(this.toolStrip2);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(812, 449);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            this.Roles.Controls.Add(this.dt_roles);
            this.Roles.Controls.Add(this.toolStrip3);
            this.Roles.Location = new System.Drawing.Point(4, 22);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(812, 449);
            this.Roles.TabIndex = 2;
            this.Roles.Text = "Roles";
            this.Roles.UseVisualStyleBackColor = true;
            // 
            // dt_usuarios
            // 
            this.dt_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_usuarios.Location = new System.Drawing.Point(4, 36);
            this.dt_usuarios.MultiSelect = false;
            this.dt_usuarios.Name = "dt_usuarios";
            this.dt_usuarios.ReadOnly = true;
            this.dt_usuarios.Size = new System.Drawing.Size(805, 410);
            this.dt_usuarios.TabIndex = 3;
            this.dt_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_usuarios_CellContentClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Eliminar_Usuario,
            this.toolStripSeparator4,
            this.btn_Editar_Usuario,
            this.toolStripSeparator5,
            this.btn_Agregar_usuario,
            this.toolStripSeparator6,
            this.btn_Actualizar_Usuario,
            this.txb_Filtrar_Usuario,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(806, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_Eliminar_Usuario
            // 
            this.btn_Eliminar_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar_Usuario.Image")));
            this.btn_Eliminar_Usuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Eliminar_Usuario.Name = "btn_Eliminar_Usuario";
            this.btn_Eliminar_Usuario.Size = new System.Drawing.Size(70, 22);
            this.btn_Eliminar_Usuario.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Editar_Usuario
            // 
            this.btn_Editar_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar_Usuario.Image")));
            this.btn_Editar_Usuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar_Usuario.Name = "btn_Editar_Usuario";
            this.btn_Editar_Usuario.Size = new System.Drawing.Size(57, 22);
            this.btn_Editar_Usuario.Text = "Editar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Agregar_usuario
            // 
            this.btn_Agregar_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar_usuario.Image")));
            this.btn_Agregar_usuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Agregar_usuario.Name = "btn_Agregar_usuario";
            this.btn_Agregar_usuario.Size = new System.Drawing.Size(69, 22);
            this.btn_Agregar_usuario.Text = "Agregar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Actualizar_Usuario
            // 
            this.btn_Actualizar_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar_Usuario.Image")));
            this.btn_Actualizar_Usuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Actualizar_Usuario.Name = "btn_Actualizar_Usuario";
            this.btn_Actualizar_Usuario.Size = new System.Drawing.Size(79, 22);
            this.btn_Actualizar_Usuario.Text = "Actualizar";
            // 
            // txb_Filtrar_Usuario
            // 
            this.txb_Filtrar_Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_Filtrar_Usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txb_Filtrar_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_Filtrar_Usuario.Name = "txb_Filtrar_Usuario";
            this.txb_Filtrar_Usuario.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Filtrar:";
            // 
            // dt_roles
            // 
            this.dt_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_roles.Location = new System.Drawing.Point(4, 37);
            this.dt_roles.MultiSelect = false;
            this.dt_roles.Name = "dt_roles";
            this.dt_roles.ReadOnly = true;
            this.dt_roles.Size = new System.Drawing.Size(805, 410);
            this.dt_roles.TabIndex = 5;
            this.dt_roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_roles_CellContentClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnt_eliminar_rol,
            this.toolStripSeparator7,
            this.btn_editar_rol,
            this.toolStripSeparator8,
            this.btn_agregar_rol,
            this.toolStripSeparator9,
            this.btn_actualizar_rol,
            this.txb_filtrar_rol,
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(812, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // bnt_eliminar_rol
            // 
            this.bnt_eliminar_rol.Image = ((System.Drawing.Image)(resources.GetObject("bnt_eliminar_rol.Image")));
            this.bnt_eliminar_rol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnt_eliminar_rol.Name = "bnt_eliminar_rol";
            this.bnt_eliminar_rol.Size = new System.Drawing.Size(70, 22);
            this.bnt_eliminar_rol.Text = "Eliminar";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_editar_rol
            // 
            this.btn_editar_rol.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar_rol.Image")));
            this.btn_editar_rol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar_rol.Name = "btn_editar_rol";
            this.btn_editar_rol.Size = new System.Drawing.Size(57, 22);
            this.btn_editar_rol.Text = "Editar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_agregar_rol
            // 
            this.btn_agregar_rol.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_rol.Image")));
            this.btn_agregar_rol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_agregar_rol.Name = "btn_agregar_rol";
            this.btn_agregar_rol.Size = new System.Drawing.Size(69, 22);
            this.btn_agregar_rol.Text = "Agregar";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_actualizar_rol
            // 
            this.btn_actualizar_rol.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar_rol.Image")));
            this.btn_actualizar_rol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actualizar_rol.Name = "btn_actualizar_rol";
            this.btn_actualizar_rol.Size = new System.Drawing.Size(79, 22);
            this.btn_actualizar_rol.Text = "Actualizar";
            // 
            // txb_filtrar_rol
            // 
            this.txb_filtrar_rol.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_filtrar_rol.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txb_filtrar_rol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_filtrar_rol.Name = "txb_filtrar_rol";
            this.txb_filtrar_rol.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "Filtrar:";
            // 
            // Empleados_Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 508);
            this.Controls.Add(this.Control_modulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Empleados_Gestor";
            this.Text = "Empleados_Gestor";
            this.Load += new System.EventHandler(this.Empleados_Gestor_Load);
            this.Control_modulo.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Empleados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Usuarios.ResumeLayout(false);
            this.Usuarios.PerformLayout();
            this.Roles.ResumeLayout(false);
            this.Roles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_usuarios)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_roles)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Control_modulo;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Roles;
        private System.Windows.Forms.ToolStripButton btn_Eliminar_Empleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Editar_Empleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Agragar_Empleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Actualizar_Empleado;
        private System.Windows.Forms.ToolStripTextBox tb_Filtrar_Empleado;
        private System.Windows.Forms.ToolStripLabel lb_Filtrar_Empleado;
        private System.Windows.Forms.DataGridView dt_Empleados;
        private System.Windows.Forms.DataGridView dt_usuarios;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Eliminar_Usuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Editar_Usuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_Agregar_usuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_Actualizar_Usuario;
        private System.Windows.Forms.ToolStripTextBox txb_Filtrar_Usuario;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dt_roles;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton bnt_eliminar_rol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_editar_rol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btn_agregar_rol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btn_actualizar_rol;
        private System.Windows.Forms.ToolStripTextBox txb_filtrar_rol;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}