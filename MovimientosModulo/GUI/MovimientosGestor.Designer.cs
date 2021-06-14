
namespace MovimientosModulo.GUI
{
    partial class MovimientosGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientosGestor));
            this.dt_movimientos = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_Registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.txb_Filtro = new System.Windows.Forms.ToolStripTextBox();
            this.lb_Filtro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPagoDia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_movimientos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_movimientos
            // 
            this.dt_movimientos.AllowUserToAddRows = false;
            this.dt_movimientos.AllowUserToDeleteRows = false;
            this.dt_movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_movimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_movimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_movimientos.Location = new System.Drawing.Point(0, 25);
            this.dt_movimientos.Name = "dt_movimientos";
            this.dt_movimientos.ReadOnly = true;
            this.dt_movimientos.Size = new System.Drawing.Size(745, 391);
            this.dt_movimientos.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Registros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_Registros
            // 
            this.lb_Registros.Name = "lb_Registros";
            this.lb_Registros.Size = new System.Drawing.Size(58, 17);
            this.lb_Registros.Text = "Registros:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.btnAgregar,
            this.txb_Filtro,
            this.lb_Filtro,
            this.toolStripSeparator5,
            this.btnPagoDia,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.btnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 22);
            this.btnAgregar.Text = "Gestionar Abonos";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 22);
            this.btnActualizar.Text = "Actualizar";
            // 
            // txb_Filtro
            // 
            this.txb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Filtro.Name = "txb_Filtro";
            this.txb_Filtro.Size = new System.Drawing.Size(150, 25);
            this.txb_Filtro.Click += new System.EventHandler(this.txb_Filtro_Click);
            this.txb_Filtro.TextChanged += new System.EventHandler(this.txb_Filtro_TextChanged);
            // 
            // lb_Filtro
            // 
            this.lb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lb_Filtro.Name = "lb_Filtro";
            this.lb_Filtro.Size = new System.Drawing.Size(37, 22);
            this.lb_Filtro.Text = "Filtrar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPagoDia
            // 
            this.btnPagoDia.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoDia.Image")));
            this.btnPagoDia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPagoDia.Name = "btnPagoDia";
            this.btnPagoDia.Size = new System.Drawing.Size(145, 22);
            this.btnPagoDia.Text = "Reportar pagos del dia";
            this.btnPagoDia.Click += new System.EventHandler(this.btnPagoDia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(141, 22);
            this.toolStripButton1.Text = "Reporte Movimientos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MovimientosGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 438);
            this.Controls.Add(this.dt_movimientos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MovimientosGestor";
            this.Text = "MovimientosGestor";
            this.Load += new System.EventHandler(this.MovimientosGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_movimientos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_movimientos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_Registros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripTextBox txb_Filtro;
        private System.Windows.Forms.ToolStripLabel lb_Filtro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnPagoDia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}