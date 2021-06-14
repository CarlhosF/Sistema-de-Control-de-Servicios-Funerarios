
namespace UsuariosModulo.GUI
{
    partial class UsuarioNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioNuevo));
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Rol = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_IdEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Empleado = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_TraerEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // lst_Rol
            // 
            this.lst_Rol.FormattingEnabled = true;
            this.lst_Rol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor ",
            "Gerente"});
            this.lst_Rol.Location = new System.Drawing.Point(70, 83);
            this.lst_Rol.Name = "lst_Rol";
            this.lst_Rol.Size = new System.Drawing.Size(120, 43);
            this.lst_Rol.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // txb_usuario
            // 
            this.txb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_usuario.Location = new System.Drawing.Point(70, 38);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(166, 20);
            this.txb_usuario.TabIndex = 4;
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(70, 144);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.Size = new System.Drawing.Size(166, 20);
            this.txb_clave.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txb_IdEmpleado
            // 
            this.txb_IdEmpleado.Location = new System.Drawing.Point(73, 205);
            this.txb_IdEmpleado.Name = "txb_IdEmpleado";
            this.txb_IdEmpleado.ReadOnly = true;
            this.txb_IdEmpleado.Size = new System.Drawing.Size(34, 20);
            this.txb_IdEmpleado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Empleado:";
            // 
            // txb_Empleado
            // 
            this.txb_Empleado.Location = new System.Drawing.Point(113, 205);
            this.txb_Empleado.Name = "txb_Empleado";
            this.txb_Empleado.ReadOnly = true;
            this.txb_Empleado.Size = new System.Drawing.Size(166, 20);
            this.txb_Empleado.TabIndex = 9;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(21, 271);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 33);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(303, 271);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 33);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_TraerEmpleado
            // 
            this.btn_TraerEmpleado.Location = new System.Drawing.Point(285, 191);
            this.btn_TraerEmpleado.Name = "btn_TraerEmpleado";
            this.btn_TraerEmpleado.Size = new System.Drawing.Size(93, 46);
            this.btn_TraerEmpleado.TabIndex = 12;
            this.btn_TraerEmpleado.Text = "Seleccionar Empleado";
            this.btn_TraerEmpleado.UseVisualStyleBackColor = true;
            this.btn_TraerEmpleado.Click += new System.EventHandler(this.btn_TraerEmpleado_Click);
            // 
            // UsuarioNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(390, 322);
            this.Controls.Add(this.btn_TraerEmpleado);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txb_Empleado);
            this.Controls.Add(this.txb_IdEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Rol);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioNuevo";
            this.Text = "UsuarioNuevo";
            this.Load += new System.EventHandler(this.UsuarioNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_IdEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Empleado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_TraerEmpleado;
    }
}