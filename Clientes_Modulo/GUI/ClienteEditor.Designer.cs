namespace Clientes_Modulo.GUI
{
    partial class ClienteEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_idclientes = new System.Windows.Forms.TextBox();
            this.txb_dui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_nombres = new System.Windows.Forms.TextBox();
            this.txb_apellidos = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.txb_oficio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dp_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txb_idclientes
            // 
            this.txb_idclientes.Location = new System.Drawing.Point(98, 6);
            this.txb_idclientes.Name = "txb_idclientes";
            this.txb_idclientes.ReadOnly = true;
            this.txb_idclientes.Size = new System.Drawing.Size(148, 20);
            this.txb_idclientes.TabIndex = 1;
            // 
            // txb_dui
            // 
            this.txb_dui.Location = new System.Drawing.Point(98, 57);
            this.txb_dui.Name = "txb_dui";
            this.txb_dui.Size = new System.Drawing.Size(148, 20);
            this.txb_dui.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DUI";
            // 
            // txb_nombres
            // 
            this.txb_nombres.Location = new System.Drawing.Point(98, 100);
            this.txb_nombres.Name = "txb_nombres";
            this.txb_nombres.Size = new System.Drawing.Size(148, 20);
            this.txb_nombres.TabIndex = 6;
            // 
            // txb_apellidos
            // 
            this.txb_apellidos.Location = new System.Drawing.Point(98, 150);
            this.txb_apellidos.Name = "txb_apellidos";
            this.txb_apellidos.Size = new System.Drawing.Size(148, 20);
            this.txb_apellidos.TabIndex = 7;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(446, 57);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(148, 20);
            this.txb_direccion.TabIndex = 9;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(446, 100);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(148, 20);
            this.txb_telefono.TabIndex = 10;
            // 
            // txb_oficio
            // 
            this.txb_oficio.Location = new System.Drawing.Point(446, 150);
            this.txb_oficio.Name = "txb_oficio";
            this.txb_oficio.Size = new System.Drawing.Size(148, 20);
            this.txb_oficio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Oficio";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(678, 29);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 42);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(678, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 42);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dp_fechanacimiento
            // 
            this.dp_fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_fechanacimiento.Location = new System.Drawing.Point(446, 13);
            this.dp_fechanacimiento.Name = "dp_fechanacimiento";
            this.dp_fechanacimiento.Size = new System.Drawing.Size(200, 20);
            this.dp_fechanacimiento.TabIndex = 19;
            // 
            // ClienteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 212);
            this.Controls.Add(this.dp_fechanacimiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_oficio);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.txb_apellidos);
            this.Controls.Add(this.txb_nombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_dui);
            this.Controls.Add(this.txb_idclientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClienteEditor";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ClienteEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_idclientes;
        private System.Windows.Forms.TextBox txb_dui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_nombres;
        private System.Windows.Forms.TextBox txb_apellidos;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.TextBox txb_oficio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dp_fechanacimiento;
    }
}