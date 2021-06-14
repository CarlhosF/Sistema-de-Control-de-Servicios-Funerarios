
namespace Sucursales_Modulo.GUI
{
    partial class Sucursal_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursal_Editor));
            this.lb_direccion = new System.Windows.Forms.Label();
            this.lb_idsucursal = new System.Windows.Forms.Label();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txb_idsucursal = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.lb_encargado = new System.Windows.Forms.Label();
            this.dt_encargado = new System.Windows.Forms.DataGridView();
            this.pic_direccion = new System.Windows.Forms.PictureBox();
            this.pic_telefono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_encargado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telefono)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_direccion
            // 
            this.lb_direccion.AutoSize = true;
            this.lb_direccion.Location = new System.Drawing.Point(116, 54);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(55, 13);
            this.lb_direccion.TabIndex = 0;
            this.lb_direccion.Text = "Direccion:";
            // 
            // lb_idsucursal
            // 
            this.lb_idsucursal.AutoSize = true;
            this.lb_idsucursal.Location = new System.Drawing.Point(116, 14);
            this.lb_idsucursal.Name = "lb_idsucursal";
            this.lb_idsucursal.Size = new System.Drawing.Size(18, 13);
            this.lb_idsucursal.TabIndex = 1;
            this.lb_idsucursal.Text = "ID";
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Location = new System.Drawing.Point(116, 102);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(49, 13);
            this.lb_telefono.TabIndex = 2;
            this.lb_telefono.Text = "Telefono";
            this.lb_telefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(25, 356);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(82, 36);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(217, 358);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(77, 34);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txb_idsucursal
            // 
            this.txb_idsucursal.Location = new System.Drawing.Point(177, 11);
            this.txb_idsucursal.Name = "txb_idsucursal";
            this.txb_idsucursal.ReadOnly = true;
            this.txb_idsucursal.Size = new System.Drawing.Size(125, 20);
            this.txb_idsucursal.TabIndex = 5;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(177, 47);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(146, 20);
            this.txb_direccion.TabIndex = 6;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(177, 102);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(148, 20);
            this.txb_telefono.TabIndex = 7;
            // 
            // lb_encargado
            // 
            this.lb_encargado.AutoSize = true;
            this.lb_encargado.Location = new System.Drawing.Point(13, 131);
            this.lb_encargado.Name = "lb_encargado";
            this.lb_encargado.Size = new System.Drawing.Size(144, 13);
            this.lb_encargado.TabIndex = 8;
            this.lb_encargado.Text = "¿Desea cambiar encargado?";
            // 
            // dt_encargado
            // 
            this.dt_encargado.AllowUserToAddRows = false;
            this.dt_encargado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_encargado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_encargado.Location = new System.Drawing.Point(7, 153);
            this.dt_encargado.MultiSelect = false;
            this.dt_encargado.Name = "dt_encargado";
            this.dt_encargado.ReadOnly = true;
            this.dt_encargado.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_encargado.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_encargado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_encargado.Size = new System.Drawing.Size(387, 197);
            this.dt_encargado.TabIndex = 9;
            // 
            // pic_direccion
            // 
            this.pic_direccion.BackColor = System.Drawing.Color.Transparent;
            this.pic_direccion.Image = ((System.Drawing.Image)(resources.GetObject("pic_direccion.Image")));
            this.pic_direccion.Location = new System.Drawing.Point(62, 36);
            this.pic_direccion.Name = "pic_direccion";
            this.pic_direccion.Size = new System.Drawing.Size(48, 44);
            this.pic_direccion.TabIndex = 10;
            this.pic_direccion.TabStop = false;
            // 
            // pic_telefono
            // 
            this.pic_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_telefono.BackColor = System.Drawing.Color.Transparent;
            this.pic_telefono.Image = ((System.Drawing.Image)(resources.GetObject("pic_telefono.Image")));
            this.pic_telefono.Location = new System.Drawing.Point(62, 86);
            this.pic_telefono.Name = "pic_telefono";
            this.pic_telefono.Size = new System.Drawing.Size(48, 36);
            this.pic_telefono.TabIndex = 11;
            this.pic_telefono.TabStop = false;
            // 
            // Sucursal_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 416);
            this.Controls.Add(this.pic_telefono);
            this.Controls.Add(this.pic_direccion);
            this.Controls.Add(this.dt_encargado);
            this.Controls.Add(this.lb_encargado);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.txb_idsucursal);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.lb_telefono);
            this.Controls.Add(this.lb_idsucursal);
            this.Controls.Add(this.lb_direccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sucursal_Editor";
            this.Text = "Sucursal_Editor";
            this.Load += new System.EventHandler(this.Sucursal_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_encargado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.Label lb_idsucursal;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txb_idsucursal;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.Label lb_encargado;
        private System.Windows.Forms.DataGridView dt_encargado;
        private System.Windows.Forms.PictureBox pic_direccion;
        private System.Windows.Forms.PictureBox pic_telefono;
    }
}