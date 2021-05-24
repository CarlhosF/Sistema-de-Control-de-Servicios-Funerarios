
namespace EntregasModulo.GUI
{
    partial class EntregasGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregasGestor));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_Registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dt_movimientos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.txb_Filtro = new System.Windows.Forms.ToolStripTextBox();
            this.lb_Filtro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHistorial = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_movimientos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Registros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_Registros
            // 
            this.lb_Registros.Name = "lb_Registros";
            this.lb_Registros.Size = new System.Drawing.Size(58, 17);
            this.lb_Registros.Text = "Registros:";
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
            this.dt_movimientos.Size = new System.Drawing.Size(780, 400);
            this.dt_movimientos.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnAgregar,
            this.toolStripSeparator3,
            this.btnActualizar,
            this.txb_Filtro,
            this.lb_Filtro,
            this.toolStripSeparator1,
            this.btnHistorial});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 22);
            this.btnAgregar.Text = "Gestionar Entregas";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txb_Filtro
            // 
            this.txb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Filtro.Name = "txb_Filtro";
            this.txb_Filtro.Size = new System.Drawing.Size(150, 25);
            this.txb_Filtro.TextChanged += new System.EventHandler(this.txb_Filtro_TextChanged);
            // 
            // lb_Filtro
            // 
            this.lb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lb_Filtro.Name = "lb_Filtro";
            this.lb_Filtro.Size = new System.Drawing.Size(37, 22);
            this.lb_Filtro.Text = "Filtrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(135, 22);
            this.btnHistorial.Text = "Historial de Entregas";
            // 
            // EntregasGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 447);
            this.Controls.Add(this.dt_movimientos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EntregasGestor";
            this.Text = "EntregasGestor";
            this.Load += new System.EventHandler(this.EntregasGestor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_movimientos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_Registros;
        private System.Windows.Forms.DataGridView dt_movimientos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripTextBox txb_Filtro;
        private System.Windows.Forms.ToolStripLabel lb_Filtro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnHistorial;
    }
}