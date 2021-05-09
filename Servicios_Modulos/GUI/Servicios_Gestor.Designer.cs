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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios_Gestor));
            this.btn_EliminarContrato = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripButton();
            this.btn_EditarContrato = new System.Windows.Forms.ToolStripButton();
            this.btn_AgregarContrato = new System.Windows.Forms.ToolStripButton();
            this.btn_ActualizarContrato = new System.Windows.Forms.ToolStripButton();
            this.btn_EliminarServicio = new System.Windows.Forms.ToolStripButton();
            this.btn_EditarServicio = new System.Windows.Forms.ToolStripButton();
            this.btn_AgregarServicio = new System.Windows.Forms.ToolStripButton();
            this.btn_ActualizarServicio = new System.Windows.Forms.ToolStripButton();
            this.btn_EliminarContrato.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipos de Servicios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 305);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar:";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipos de Contratos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(726, 305);
            this.dataGridView2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(621, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtrar:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel5.Image")));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel5.Text = "Eliminar";
            // 
            // btn_EditarContrato
            // 
            this.btn_EditarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarContrato.Image")));
            this.btn_EditarContrato.Name = "btn_EditarContrato";
            this.btn_EditarContrato.Size = new System.Drawing.Size(57, 22);
            this.btn_EditarContrato.Text = "Editar";
            // 
            // btn_AgregarContrato
            // 
            this.btn_AgregarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarContrato.Image")));
            this.btn_AgregarContrato.Name = "btn_AgregarContrato";
            this.btn_AgregarContrato.Size = new System.Drawing.Size(69, 22);
            this.btn_AgregarContrato.Text = "Agregar";
            // 
            // btn_ActualizarContrato
            // 
            this.btn_ActualizarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarContrato.Image")));
            this.btn_ActualizarContrato.Name = "btn_ActualizarContrato";
            this.btn_ActualizarContrato.Size = new System.Drawing.Size(79, 22);
            this.btn_ActualizarContrato.Text = "Actualizar";
            // 
            // btn_EliminarServicio
            // 
            this.btn_EliminarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_EliminarServicio.Image")));
            this.btn_EliminarServicio.Name = "btn_EliminarServicio";
            this.btn_EliminarServicio.Size = new System.Drawing.Size(70, 22);
            this.btn_EliminarServicio.Text = "Eliminar";
            // 
            // btn_EditarServicio
            // 
            this.btn_EditarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarServicio.Image")));
            this.btn_EditarServicio.Name = "btn_EditarServicio";
            this.btn_EditarServicio.Size = new System.Drawing.Size(57, 22);
            this.btn_EditarServicio.Text = "Editar";
            // 
            // btn_AgregarServicio
            // 
            this.btn_AgregarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarServicio.Image")));
            this.btn_AgregarServicio.Name = "btn_AgregarServicio";
            this.btn_AgregarServicio.Size = new System.Drawing.Size(69, 22);
            this.btn_AgregarServicio.Text = "Agregar";
            this.btn_AgregarServicio.Click += new System.EventHandler(this.btnAgregarS_Click);
            // 
            // btn_ActualizarServicio
            // 
            this.btn_ActualizarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarServicio.Image")));
            this.btn_ActualizarServicio.Name = "btn_ActualizarServicio";
            this.btn_ActualizarServicio.Size = new System.Drawing.Size(79, 22);
            this.btn_ActualizarServicio.Text = "Actualizar";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_EliminarServicio;
        private System.Windows.Forms.ToolStripButton btn_EditarServicio;
        private System.Windows.Forms.ToolStripButton btn_AgregarServicio;
        private System.Windows.Forms.ToolStripButton btn_ActualizarServicio;
        private System.Windows.Forms.ToolStripButton toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btn_EditarContrato;
        private System.Windows.Forms.ToolStripButton btn_AgregarContrato;
        private System.Windows.Forms.ToolStripButton btn_ActualizarContrato;
    }
}