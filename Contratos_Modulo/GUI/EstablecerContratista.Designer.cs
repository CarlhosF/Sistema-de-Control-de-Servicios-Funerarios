
namespace Contratos_Modulo.GUI
{
    partial class EstablecerContratista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstablecerContratista));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_Registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dt_clientes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txb_Filtro = new System.Windows.Forms.ToolStripTextBox();
            this.lb_Filtro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAceptar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_clientes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Registros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_Registros
            // 
            this.lb_Registros.Name = "lb_Registros";
            this.lb_Registros.Size = new System.Drawing.Size(58, 17);
            this.lb_Registros.Text = "Registros:";
            // 
            // dt_clientes
            // 
            this.dt_clientes.AllowUserToAddRows = false;
            this.dt_clientes.AllowUserToDeleteRows = false;
            this.dt_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_clientes.Location = new System.Drawing.Point(0, 40);
            this.dt_clientes.MultiSelect = false;
            this.dt_clientes.Name = "dt_clientes";
            this.dt_clientes.ReadOnly = true;
            this.dt_clientes.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_clientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_clientes.Size = new System.Drawing.Size(794, 320);
            this.dt_clientes.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txb_Filtro,
            this.lb_Filtro,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnAceptar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txb_Filtro
            // 
            this.txb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Filtro.Name = "txb_Filtro";
            this.txb_Filtro.Size = new System.Drawing.Size(150, 40);
            this.txb_Filtro.Click += new System.EventHandler(this.txb_Filtro_Click);
            this.txb_Filtro.TextChanged += new System.EventHandler(this.txb_Filtro_TextChanged);
            // 
            // lb_Filtro
            // 
            this.lb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lb_Filtro.Name = "lb_Filtro";
            this.lb_Filtro.Size = new System.Drawing.Size(37, 37);
            this.lb_Filtro.Text = "Filtrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(218, 37);
            this.toolStripLabel1.Text = "Seleccione Contratiste y click en aceptar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 37);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // EstablecerContratista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dt_clientes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EstablecerContratista";
            this.Text = "EstablecerContratista";
            this.Load += new System.EventHandler(this.EstablecerContratista_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_clientes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_Registros;
        private System.Windows.Forms.DataGridView dt_clientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txb_Filtro;
        private System.Windows.Forms.ToolStripLabel lb_Filtro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAceptar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}