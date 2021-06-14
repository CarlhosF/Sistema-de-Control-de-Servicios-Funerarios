
namespace EntregasModulo.GUI
{
    partial class SeleccionarContrato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarContrato));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_Registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dt_contratos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txb_Filtro = new System.Windows.Forms.ToolStripTextBox();
            this.lb_Filtro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAceptar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_contratos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Registros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(893, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_Registros
            // 
            this.lb_Registros.Name = "lb_Registros";
            this.lb_Registros.Size = new System.Drawing.Size(58, 17);
            this.lb_Registros.Text = "Registros:";
            // 
            // dt_contratos
            // 
            this.dt_contratos.AllowUserToAddRows = false;
            this.dt_contratos.AllowUserToDeleteRows = false;
            this.dt_contratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_contratos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_contratos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_contratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_contratos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_contratos.Location = new System.Drawing.Point(0, 55);
            this.dt_contratos.MultiSelect = false;
            this.dt_contratos.Name = "dt_contratos";
            this.dt_contratos.ReadOnly = true;
            this.dt_contratos.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_contratos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_contratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_contratos.Size = new System.Drawing.Size(893, 461);
            this.dt_contratos.TabIndex = 8;
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
            this.toolStrip1.Size = new System.Drawing.Size(893, 55);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txb_Filtro
            // 
            this.txb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb_Filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Filtro.Name = "txb_Filtro";
            this.txb_Filtro.Size = new System.Drawing.Size(150, 55);
            // 
            // lb_Filtro
            // 
            this.lb_Filtro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lb_Filtro.Name = "lb_Filtro";
            this.lb_Filtro.Size = new System.Drawing.Size(37, 52);
            this.lb_Filtro.Text = "Filtrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(207, 52);
            this.toolStripLabel1.Text = "Seleccione Contrato y click en aceptar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 52);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SeleccionarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dt_contratos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SeleccionarContrato";
            this.Text = "SeleccionarContrato";
            this.Load += new System.EventHandler(this.SeleccionarContrato_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_contratos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_Registros;
        private System.Windows.Forms.DataGridView dt_contratos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txb_Filtro;
        private System.Windows.Forms.ToolStripLabel lb_Filtro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAceptar;
    }
}