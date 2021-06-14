
namespace UsuariosModulo.GUI
{
    partial class UsuarioEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioEditar));
            this.btn_TraerEmpleado = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txb_Empleado = new System.Windows.Forms.TextBox();
            this.txb_IdEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_Rol = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_TraerEmpleado
            // 
            this.btn_TraerEmpleado.Enabled = false;
            this.btn_TraerEmpleado.Location = new System.Drawing.Point(347, 251);
            this.btn_TraerEmpleado.Name = "btn_TraerEmpleado";
            this.btn_TraerEmpleado.Size = new System.Drawing.Size(93, 46);
            this.btn_TraerEmpleado.TabIndex = 24;
            this.btn_TraerEmpleado.Text = "Seleccionar Empleado";
            this.btn_TraerEmpleado.UseVisualStyleBackColor = true;
            this.btn_TraerEmpleado.Click += new System.EventHandler(this.btn_TraerEmpleado_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(365, 331);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 33);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(83, 331);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 33);
            this.btn_Agregar.TabIndex = 22;
            this.btn_Agregar.Text = "Actualizar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txb_Empleado
            // 
            this.txb_Empleado.Location = new System.Drawing.Point(175, 265);
            this.txb_Empleado.Name = "txb_Empleado";
            this.txb_Empleado.ReadOnly = true;
            this.txb_Empleado.Size = new System.Drawing.Size(166, 20);
            this.txb_Empleado.TabIndex = 21;
            // 
            // txb_IdEmpleado
            // 
            this.txb_IdEmpleado.Location = new System.Drawing.Point(135, 265);
            this.txb_IdEmpleado.Name = "txb_IdEmpleado";
            this.txb_IdEmpleado.ReadOnly = true;
            this.txb_IdEmpleado.Size = new System.Drawing.Size(34, 20);
            this.txb_IdEmpleado.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Empleado:";
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(132, 204);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.Size = new System.Drawing.Size(166, 20);
            this.txb_clave.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Clave:";
            // 
            // txb_usuario
            // 
            this.txb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_usuario.Location = new System.Drawing.Point(132, 98);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(166, 20);
            this.txb_usuario.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rol:";
            // 
            // lst_Rol
            // 
            this.lst_Rol.FormattingEnabled = true;
            this.lst_Rol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor ",
            "Gerente"});
            this.lst_Rol.Location = new System.Drawing.Point(132, 143);
            this.lst_Rol.Name = "lst_Rol";
            this.lst_Rol.Size = new System.Drawing.Size(120, 43);
            this.lst_Rol.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(135, 44);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(166, 20);
            this.txbID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID";
            // 
            // UsuarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(456, 385);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label5);
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
            this.Name = "UsuarioEditar";
            this.Text = "UsuarioEditar";
            this.Load += new System.EventHandler(this.UsuarioEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TraerEmpleado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txb_Empleado;
        private System.Windows.Forms.TextBox txb_IdEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_Rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label5;
    }
}