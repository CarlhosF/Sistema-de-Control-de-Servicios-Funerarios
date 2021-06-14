namespace Servicios_Modulos.GUI
{
    partial class Servicios_Gestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios_Gestor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_EliminarContrato = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dt_Servicios = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_EliminarServicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_EditarServicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_AgregarServicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ActualizarServicio = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dt_TipoDeContrato = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_EliminarTipoContr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_EditarContrato = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_AgregarContrato = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ActualizarContrato = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.btn_EliminarContrato.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Servicios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TipoDeContrato)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_EliminarContrato
            // 
            this.btn_EliminarContrato.Controls.Add(this.tabPage1);
            this.btn_EliminarContrato.Controls.Add(this.tabPage2);
            this.btn_EliminarContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EliminarContrato.Location = new System.Drawing.Point(0, 0);
            this.btn_EliminarContrato.Name = "btn_EliminarContrato";
            this.btn_EliminarContrato.SelectedIndex = 0;
            this.btn_EliminarContrato.Size = new System.Drawing.Size(740, 362);
            this.btn_EliminarContrato.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dt_Servicios);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipos de Servicios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dt_Servicios
            // 
            this.dt_Servicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_Servicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_Servicios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Servicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_Servicios.Location = new System.Drawing.Point(3, 28);
            this.dt_Servicios.MultiSelect = false;
            this.dt_Servicios.Name = "dt_Servicios";
            this.dt_Servicios.ReadOnly = true;
            this.dt_Servicios.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_Servicios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_Servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_Servicios.Size = new System.Drawing.Size(726, 305);
            this.dt_Servicios.TabIndex = 3;
            this.dt_Servicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Servicios_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EliminarServicio,
            this.toolStripSeparator1,
            this.btn_EditarServicio,
            this.toolStripSeparator2,
            this.btn_AgregarServicio,
            this.toolStripSeparator3,
            this.btn_ActualizarServicio});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(726, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_EliminarServicio
            // 
            this.btn_EliminarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_EliminarServicio.Image")));
            this.btn_EliminarServicio.Name = "btn_EliminarServicio";
            this.btn_EliminarServicio.Size = new System.Drawing.Size(70, 22);
            this.btn_EliminarServicio.Text = "Eliminar";
            this.btn_EliminarServicio.Click += new System.EventHandler(this.btn_EliminarServicio_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_EditarServicio
            // 
            this.btn_EditarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarServicio.Image")));
            this.btn_EditarServicio.Name = "btn_EditarServicio";
            this.btn_EditarServicio.Size = new System.Drawing.Size(57, 22);
            this.btn_EditarServicio.Text = "Editar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_AgregarServicio
            // 
            this.btn_AgregarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarServicio.Image")));
            this.btn_AgregarServicio.Name = "btn_AgregarServicio";
            this.btn_AgregarServicio.Size = new System.Drawing.Size(69, 22);
            this.btn_AgregarServicio.Text = "Agregar";
            this.btn_AgregarServicio.Click += new System.EventHandler(this.btnAgregarS_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ActualizarServicio
            // 
            this.btn_ActualizarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarServicio.Image")));
            this.btn_ActualizarServicio.Name = "btn_ActualizarServicio";
            this.btn_ActualizarServicio.Size = new System.Drawing.Size(79, 22);
            this.btn_ActualizarServicio.Text = "Actualizar";
            this.btn_ActualizarServicio.Click += new System.EventHandler(this.btn_ActualizarServicio_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dt_TipoDeContrato);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipos de Contratos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dt_TipoDeContrato
            // 
            this.dt_TipoDeContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_TipoDeContrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_TipoDeContrato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_TipoDeContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_TipoDeContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_TipoDeContrato.Location = new System.Drawing.Point(3, 28);
            this.dt_TipoDeContrato.MultiSelect = false;
            this.dt_TipoDeContrato.Name = "dt_TipoDeContrato";
            this.dt_TipoDeContrato.ReadOnly = true;
            this.dt_TipoDeContrato.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_TipoDeContrato.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_TipoDeContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_TipoDeContrato.Size = new System.Drawing.Size(726, 305);
            this.dt_TipoDeContrato.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EliminarTipoContr,
            this.toolStripSeparator4,
            this.btn_EditarContrato,
            this.toolStripSeparator5,
            this.btn_AgregarContrato,
            this.toolStripSeparator6,
            this.btn_ActualizarContrato});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(726, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_EliminarTipoContr
            // 
            this.btn_EliminarTipoContr.Image = ((System.Drawing.Image)(resources.GetObject("btn_EliminarTipoContr.Image")));
            this.btn_EliminarTipoContr.Name = "btn_EliminarTipoContr";
            this.btn_EliminarTipoContr.Size = new System.Drawing.Size(70, 22);
            this.btn_EliminarTipoContr.Text = "Eliminar";
            this.btn_EliminarTipoContr.Click += new System.EventHandler(this.btn_EliminarTipoContr_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_EditarContrato
            // 
            this.btn_EditarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarContrato.Image")));
            this.btn_EditarContrato.Name = "btn_EditarContrato";
            this.btn_EditarContrato.Size = new System.Drawing.Size(57, 22);
            this.btn_EditarContrato.Text = "Editar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_AgregarContrato
            // 
            this.btn_AgregarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarContrato.Image")));
            this.btn_AgregarContrato.Name = "btn_AgregarContrato";
            this.btn_AgregarContrato.Size = new System.Drawing.Size(69, 22);
            this.btn_AgregarContrato.Text = "Agregar";
            this.btn_AgregarContrato.Click += new System.EventHandler(this.btn_AgregarContrato_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ActualizarContrato
            // 
            this.btn_ActualizarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarContrato.Image")));
            this.btn_ActualizarContrato.Name = "btn_ActualizarContrato";
            this.btn_ActualizarContrato.Size = new System.Drawing.Size(79, 22);
            this.btn_ActualizarContrato.Text = "Actualizar";
            this.btn_ActualizarContrato.Click += new System.EventHandler(this.btn_ActualizarContrato_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(740, 337);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(740, 362);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(740, 337);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(740, 362);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(740, 337);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(740, 362);
            this.toolStripContainer3.TabIndex = 0;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // Servicios_Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 362);
            this.Controls.Add(this.btn_EliminarContrato);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Servicios_Gestor";
            this.Text = "Servicios_Gestor";
            this.Load += new System.EventHandler(this.Servicios_Gestor_Load);
            this.btn_EliminarContrato.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Servicios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TipoDeContrato)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btn_EliminarContrato;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.DataGridView dt_Servicios;
        private System.Windows.Forms.DataGridView dt_TipoDeContrato;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_EditarServicio;
        private System.Windows.Forms.ToolStripButton btn_AgregarServicio;
        private System.Windows.Forms.ToolStripButton btn_ActualizarServicio;
        private System.Windows.Forms.ToolStripButton btn_EliminarTipoContr;
        private System.Windows.Forms.ToolStripButton btn_EditarContrato;
        private System.Windows.Forms.ToolStripButton btn_AgregarContrato;
        private System.Windows.Forms.ToolStripButton btn_ActualizarContrato;
        private System.Windows.Forms.ToolStripButton btn_EliminarServicio;
    }
}