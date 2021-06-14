namespace Clientes_Modulo.GUI
{
    partial class ClienteNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteNuevo));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_dui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_oficio = new System.Windows.Forms.TextBox();
            this.dp_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(675, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 42);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(675, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombres";
            // 
            // txb_dui
            // 
            this.txb_dui.Location = new System.Drawing.Point(85, 20);
            this.txb_dui.Name = "txb_dui";
            this.txb_dui.Size = new System.Drawing.Size(169, 20);
            this.txb_dui.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // txb_nombres
            // 
            this.txb_nombres.Location = new System.Drawing.Point(85, 66);
            this.txb_nombres.Name = "txb_nombres";
            this.txb_nombres.Size = new System.Drawing.Size(169, 20);
            this.txb_nombres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DUI";
            // 
            // txb_apellidos
            // 
            this.txb_apellidos.Location = new System.Drawing.Point(85, 104);
            this.txb_apellidos.Name = "txb_apellidos";
            this.txb_apellidos.Size = new System.Drawing.Size(169, 20);
            this.txb_apellidos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(85, 147);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(169, 20);
            this.txb_direccion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(407, 27);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(169, 20);
            this.txb_telefono.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Oficio";
            // 
            // txb_oficio
            // 
            this.txb_oficio.Location = new System.Drawing.Point(407, 104);
            this.txb_oficio.Name = "txb_oficio";
            this.txb_oficio.Size = new System.Drawing.Size(169, 20);
            this.txb_oficio.TabIndex = 16;
            // 
            // dp_fechanacimiento
            // 
            this.dp_fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_fechanacimiento.Location = new System.Drawing.Point(407, 67);
            this.dp_fechanacimiento.Name = "dp_fechanacimiento";
            this.dp_fechanacimiento.Size = new System.Drawing.Size(169, 20);
            this.dp_fechanacimiento.TabIndex = 17;
            // 
            // ClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 195);
            this.Controls.Add(this.dp_fechanacimiento);
            this.Controls.Add(this.txb_oficio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_apellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_nombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_dui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClienteNuevo";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.ClienteNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_dui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_oficio;
        private System.Windows.Forms.DateTimePicker dp_fechanacimiento;
    }
}