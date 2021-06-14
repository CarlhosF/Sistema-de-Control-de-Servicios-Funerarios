
namespace Sucursales_Modulo.GUI
{
    partial class SucursalNueva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SucursalNueva));
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_Telefono = new System.Windows.Forms.Label();
            this.lb_Encargado = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.dt_empleado = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Location = new System.Drawing.Point(105, 39);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lb_Direccion.TabIndex = 0;
            this.lb_Direccion.Text = "Direccion";
            this.lb_Direccion.Click += new System.EventHandler(this.lb_Direccion_Click);
            // 
            // lb_Telefono
            // 
            this.lb_Telefono.AutoSize = true;
            this.lb_Telefono.Location = new System.Drawing.Point(105, 77);
            this.lb_Telefono.Name = "lb_Telefono";
            this.lb_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lb_Telefono.TabIndex = 1;
            this.lb_Telefono.Text = "Telefono";
            // 
            // lb_Encargado
            // 
            this.lb_Encargado.AutoSize = true;
            this.lb_Encargado.Location = new System.Drawing.Point(145, 108);
            this.lb_Encargado.Name = "lb_Encargado";
            this.lb_Encargado.Size = new System.Drawing.Size(126, 13);
            this.lb_Encargado.TabIndex = 2;
            this.lb_Encargado.Text = "Seleccione el Encargado";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(179, 36);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(261, 20);
            this.txb_direccion.TabIndex = 3;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(179, 70);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(261, 20);
            this.txb_telefono.TabIndex = 4;
            // 
            // dt_empleado
            // 
            this.dt_empleado.AllowUserToAddRows = false;
            this.dt_empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_empleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_empleado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_empleado.Location = new System.Drawing.Point(2, 138);
            this.dt_empleado.MultiSelect = false;
            this.dt_empleado.Name = "dt_empleado";
            this.dt_empleado.ReadOnly = true;
            this.dt_empleado.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_empleado.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_empleado.Size = new System.Drawing.Size(447, 301);
            this.dt_empleado.TabIndex = 5;
            this.dt_empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_empleado_CellContentClick);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(12, 447);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(86, 42);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Agregar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(360, 445);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 46);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // SucursalNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dt_empleado);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.lb_Encargado);
            this.Controls.Add(this.lb_Telefono);
            this.Controls.Add(this.lb_Direccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SucursalNueva";
            this.Text = "SucursalNueva";
            this.Load += new System.EventHandler(this.SucursalNueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Direccion;
        private System.Windows.Forms.Label lb_Telefono;
        private System.Windows.Forms.Label lb_Encargado;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.DataGridView dt_empleado;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}