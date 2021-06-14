
namespace MovimientosModulo.GUI
{
    partial class Abonos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_movimientos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbSaldoPendiente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbAbonado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbExtendido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVendedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTipoContrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDContrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_movimientos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dt_movimientos);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 300);
            this.panel1.TabIndex = 0;
            // 
            // dt_movimientos
            // 
            this.dt_movimientos.AllowUserToAddRows = false;
            this.dt_movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_movimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_movimientos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_movimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_movimientos.Location = new System.Drawing.Point(0, 25);
            this.dt_movimientos.MultiSelect = false;
            this.dt_movimientos.Name = "dt_movimientos";
            this.dt_movimientos.ReadOnly = true;
            this.dt_movimientos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_movimientos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_movimientos.Size = new System.Drawing.Size(762, 275);
            this.dt_movimientos.TabIndex = 1;
            this.dt_movimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_movimientos_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton1.Text = "Agregar Abono";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton2.Text = "Eliminar Abono";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.txbEstado);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txbSaldoPendiente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txbAbonado);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txbMonto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txbFecha);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbExtendido);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbCliente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbVendedor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbTipoContrato);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbServicio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbIDContrato);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 188);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(446, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar Contrato";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(672, 147);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.ReadOnly = true;
            this.txbEstado.Size = new System.Drawing.Size(78, 20);
            this.txbEstado.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Estado";
            // 
            // txbSaldoPendiente
            // 
            this.txbSaldoPendiente.Location = new System.Drawing.Point(364, 144);
            this.txbSaldoPendiente.Name = "txbSaldoPendiente";
            this.txbSaldoPendiente.ReadOnly = true;
            this.txbSaldoPendiente.Size = new System.Drawing.Size(51, 20);
            this.txbSaldoPendiente.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Saldo Pendiente";
            // 
            // txbAbonado
            // 
            this.txbAbonado.Location = new System.Drawing.Point(191, 144);
            this.txbAbonado.Name = "txbAbonado";
            this.txbAbonado.ReadOnly = true;
            this.txbAbonado.Size = new System.Drawing.Size(51, 20);
            this.txbAbonado.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Abonado";
            // 
            // txbMonto
            // 
            this.txbMonto.Location = new System.Drawing.Point(52, 141);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.ReadOnly = true;
            this.txbMonto.Size = new System.Drawing.Size(51, 20);
            this.txbMonto.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto";
            // 
            // txbFecha
            // 
            this.txbFecha.Location = new System.Drawing.Point(434, 100);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.ReadOnly = true;
            this.txbFecha.Size = new System.Drawing.Size(234, 20);
            this.txbFecha.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha";
            // 
            // txbExtendido
            // 
            this.txbExtendido.Location = new System.Drawing.Point(84, 100);
            this.txbExtendido.Name = "txbExtendido";
            this.txbExtendido.ReadOnly = true;
            this.txbExtendido.Size = new System.Drawing.Size(270, 20);
            this.txbExtendido.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Extendido en";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(389, 56);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.ReadOnly = true;
            this.txbCliente.Size = new System.Drawing.Size(279, 20);
            this.txbCliente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente";
            // 
            // txbVendedor
            // 
            this.txbVendedor.Location = new System.Drawing.Point(68, 56);
            this.txbVendedor.Name = "txbVendedor";
            this.txbVendedor.ReadOnly = true;
            this.txbVendedor.Size = new System.Drawing.Size(248, 20);
            this.txbVendedor.TabIndex = 10;
            this.txbVendedor.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vendedor";
            // 
            // txbTipoContrato
            // 
            this.txbTipoContrato.Location = new System.Drawing.Point(496, 12);
            this.txbTipoContrato.Name = "txbTipoContrato";
            this.txbTipoContrato.ReadOnly = true;
            this.txbTipoContrato.Size = new System.Drawing.Size(172, 20);
            this.txbTipoContrato.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contrato";
            // 
            // txbServicio
            // 
            this.txbServicio.Location = new System.Drawing.Point(229, 12);
            this.txbServicio.Name = "txbServicio";
            this.txbServicio.ReadOnly = true;
            this.txbServicio.Size = new System.Drawing.Size(174, 20);
            this.txbServicio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servicio";
            // 
            // txbIDContrato
            // 
            this.txbIDContrato.Location = new System.Drawing.Point(61, 12);
            this.txbIDContrato.Name = "txbIDContrato";
            this.txbIDContrato.ReadOnly = true;
            this.txbIDContrato.Size = new System.Drawing.Size(42, 20);
            this.txbIDContrato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contrato";
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abonos";
            this.Text = "Abonos";
            this.Load += new System.EventHandler(this.Abonos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_movimientos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTipoContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIDContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbExtendido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbSaldoPendiente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbAbonado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dt_movimientos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbCliente;
    }
}