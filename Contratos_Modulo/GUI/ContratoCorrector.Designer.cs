namespace Contratos_Modulo.GUI
{
    partial class btnSelecBene1
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbExtendido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstbEstado = new System.Windows.Forms.ListBox();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIDcontrato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbContratista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIDContratista = new System.Windows.Forms.TextBox();
            this.txbIDBene1 = new System.Windows.Forms.TextBox();
            this.txbBene1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbIDBene2 = new System.Windows.Forms.TextBox();
            this.txbBene2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEstableceBene1 = new System.Windows.Forms.Button();
            this.btnEstableceBene2 = new System.Windows.Forms.Button();
            this.btnEstablecerContra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(553, 336);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(644, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(69, 53);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extendido:";
            // 
            // txbExtendido
            // 
            this.txbExtendido.Location = new System.Drawing.Point(86, 99);
            this.txbExtendido.Name = "txbExtendido";
            this.txbExtendido.Size = new System.Drawing.Size(315, 20);
            this.txbExtendido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // lstbEstado
            // 
            this.lstbEstado.FormattingEnabled = true;
            this.lstbEstado.Items.AddRange(new object[] {
            "Activo",
            "Moroso",
            "Cancelado",
            "Entregado",
            "Nulo"});
            this.lstbEstado.Location = new System.Drawing.Point(592, 180);
            this.lstbEstado.Name = "lstbEstado";
            this.lstbEstado.Size = new System.Drawing.Size(120, 69);
            this.lstbEstado.TabIndex = 7;
            this.lstbEstado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(420, 37);
            this.txbObservaciones.Multiline = true;
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(292, 103);
            this.txbObservaciones.TabIndex = 9;
            this.txbObservaciones.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observaciones:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbIDcontrato
            // 
            this.txbIDcontrato.Location = new System.Drawing.Point(112, 12);
            this.txbIDcontrato.Name = "txbIDcontrato";
            this.txbIDcontrato.Size = new System.Drawing.Size(46, 20);
            this.txbIDcontrato.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // txbContratista
            // 
            this.txbContratista.Location = new System.Drawing.Point(165, 173);
            this.txbContratista.Name = "txbContratista";
            this.txbContratista.Size = new System.Drawing.Size(236, 20);
            this.txbContratista.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contratista:";
            // 
            // txbIDContratista
            // 
            this.txbIDContratista.Location = new System.Drawing.Point(99, 173);
            this.txbIDContratista.Name = "txbIDContratista";
            this.txbIDContratista.Size = new System.Drawing.Size(53, 20);
            this.txbIDContratista.TabIndex = 14;
            // 
            // txbIDBene1
            // 
            this.txbIDBene1.Location = new System.Drawing.Point(99, 266);
            this.txbIDBene1.Name = "txbIDBene1";
            this.txbIDBene1.Size = new System.Drawing.Size(53, 20);
            this.txbIDBene1.TabIndex = 17;
            // 
            // txbBene1
            // 
            this.txbBene1.Location = new System.Drawing.Point(165, 266);
            this.txbBene1.Name = "txbBene1";
            this.txbBene1.Size = new System.Drawing.Size(236, 20);
            this.txbBene1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Beneficiario 1:";
            // 
            // txbIDBene2
            // 
            this.txbIDBene2.Location = new System.Drawing.Point(99, 313);
            this.txbIDBene2.Name = "txbIDBene2";
            this.txbIDBene2.Size = new System.Drawing.Size(53, 20);
            this.txbIDBene2.TabIndex = 20;
            // 
            // txbBene2
            // 
            this.txbBene2.Location = new System.Drawing.Point(165, 313);
            this.txbBene2.Name = "txbBene2";
            this.txbBene2.Size = new System.Drawing.Size(236, 20);
            this.txbBene2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Beneficiario 2:";
            // 
            // btnEstableceBene1
            // 
            this.btnEstableceBene1.Location = new System.Drawing.Point(407, 264);
            this.btnEstableceBene1.Name = "btnEstableceBene1";
            this.btnEstableceBene1.Size = new System.Drawing.Size(50, 23);
            this.btnEstableceBene1.TabIndex = 21;
            this.btnEstableceBene1.Text = "...";
            this.btnEstableceBene1.UseVisualStyleBackColor = true;
            this.btnEstableceBene1.Click += new System.EventHandler(this.btnEstableceBene1_Click);
            // 
            // btnEstableceBene2
            // 
            this.btnEstableceBene2.Location = new System.Drawing.Point(407, 310);
            this.btnEstableceBene2.Name = "btnEstableceBene2";
            this.btnEstableceBene2.Size = new System.Drawing.Size(50, 23);
            this.btnEstableceBene2.TabIndex = 22;
            this.btnEstableceBene2.Text = "...";
            this.btnEstableceBene2.UseVisualStyleBackColor = true;
            this.btnEstableceBene2.Click += new System.EventHandler(this.btnEstableceBene2_Click);
            // 
            // btnEstablecerContra
            // 
            this.btnEstablecerContra.Location = new System.Drawing.Point(407, 171);
            this.btnEstablecerContra.Name = "btnEstablecerContra";
            this.btnEstablecerContra.Size = new System.Drawing.Size(50, 23);
            this.btnEstablecerContra.TabIndex = 23;
            this.btnEstablecerContra.Text = "...";
            this.btnEstablecerContra.UseVisualStyleBackColor = true;
            this.btnEstablecerContra.Click += new System.EventHandler(this.btnEstablecerContra_Click);
            // 
            // btnSelecBene1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 371);
            this.Controls.Add(this.btnEstablecerContra);
            this.Controls.Add(this.btnEstableceBene2);
            this.Controls.Add(this.btnEstableceBene1);
            this.Controls.Add(this.txbIDBene2);
            this.Controls.Add(this.txbBene2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbIDBene1);
            this.Controls.Add(this.txbBene1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbIDContratista);
            this.Controls.Add(this.txbContratista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbIDcontrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbExtendido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Name = "btnSelecBene1";
            this.Text = "ContratoCorrector";
            this.Load += new System.EventHandler(this.ContratoCorrector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbExtendido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstbEstado;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIDcontrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbContratista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIDContratista;
        private System.Windows.Forms.TextBox txbIDBene1;
        private System.Windows.Forms.TextBox txbBene1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbIDBene2;
        private System.Windows.Forms.TextBox txbBene2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEstableceBene1;
        private System.Windows.Forms.Button btnEstableceBene2;
        private System.Windows.Forms.Button btnEstablecerContra;
    }
}