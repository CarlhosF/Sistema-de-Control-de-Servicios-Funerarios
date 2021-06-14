
namespace EntregasModulo.GUI
{
    partial class EntregaNueva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregaNueva));
            this.dp_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.txbdireccionEntrega = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Causa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbdireccionToma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_apellidos = new System.Windows.Forms.TextBox();
            this.txb_nombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtp_muerte = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dp_fechanacimiento
            // 
            this.dp_fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_fechanacimiento.Location = new System.Drawing.Point(476, 57);
            this.dp_fechanacimiento.Name = "dp_fechanacimiento";
            this.dp_fechanacimiento.Size = new System.Drawing.Size(169, 20);
            this.dp_fechanacimiento.TabIndex = 33;
            // 
            // txbdireccionEntrega
            // 
            this.txbdireccionEntrega.Location = new System.Drawing.Point(139, 148);
            this.txbdireccionEntrega.Name = "txbdireccionEntrega";
            this.txbdireccionEntrega.Size = new System.Drawing.Size(169, 20);
            this.txbdireccionEntrega.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Direccion de Entrega";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Causa de Muerte";
            // 
            // txb_Causa
            // 
            this.txb_Causa.Location = new System.Drawing.Point(476, 17);
            this.txb_Causa.Name = "txb_Causa";
            this.txb_Causa.Size = new System.Drawing.Size(169, 20);
            this.txb_Causa.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // txbdireccionToma
            // 
            this.txbdireccionToma.Location = new System.Drawing.Point(139, 104);
            this.txbdireccionToma.Name = "txbdireccionToma";
            this.txbdireccionToma.Size = new System.Drawing.Size(169, 20);
            this.txbdireccionToma.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Direccion de Toma";
            // 
            // txb_apellidos
            // 
            this.txb_apellidos.Location = new System.Drawing.Point(139, 60);
            this.txb_apellidos.Name = "txb_apellidos";
            this.txb_apellidos.Size = new System.Drawing.Size(169, 20);
            this.txb_apellidos.TabIndex = 25;
            // 
            // txb_nombres
            // 
            this.txb_nombres.Location = new System.Drawing.Point(139, 21);
            this.txb_nombres.Name = "txb_nombres";
            this.txb_nombres.Size = new System.Drawing.Size(169, 20);
            this.txb_nombres.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombres";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(689, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 42);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(689, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 42);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtp_muerte
            // 
            this.dtp_muerte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_muerte.Location = new System.Drawing.Point(476, 105);
            this.dtp_muerte.Name = "dtp_muerte";
            this.dtp_muerte.Size = new System.Drawing.Size(169, 20);
            this.dtp_muerte.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fecha de Fallecimiento";
            // 
            // EntregaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.dtp_muerte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dp_fechanacimiento);
            this.Controls.Add(this.txbdireccionEntrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Causa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbdireccionToma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_apellidos);
            this.Controls.Add(this.txb_nombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "EntregaNueva";
            this.Text = "EntregaNueva";
            this.Load += new System.EventHandler(this.EntregaNueva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dp_fechanacimiento;
        private System.Windows.Forms.TextBox txbdireccionEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Causa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbdireccionToma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_apellidos;
        private System.Windows.Forms.TextBox txb_nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtp_muerte;
        private System.Windows.Forms.Label label8;
    }
}