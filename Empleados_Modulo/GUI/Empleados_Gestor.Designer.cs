
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
            this.Control_modulo.SuspendLayout();
            this.Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Empleados)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.Roles.Location = new System.Drawing.Point(4, 22);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(812, 449);
            this.Roles.TabIndex = 2;
            this.Roles.Text = "Roles";
            this.Roles.UseVisualStyleBackColor = true;
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
    }
}