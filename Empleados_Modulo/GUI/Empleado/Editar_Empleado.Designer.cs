
namespace Empleados_Modulo.GUI.Empleado
{
    partial class Editar_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Empleado));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Editar_Empleado = new System.Windows.Forms.Button();
            this.txb_DUI_Empleado = new System.Windows.Forms.TextBox();
            this.lb_DUI_Empleado = new System.Windows.Forms.Label();
            this.dt_Sucursal_Empleado = new System.Windows.Forms.DataGridView();
            this.lb_sucursal_Empleado = new System.Windows.Forms.Label();
            this.txb_telefono_Empleado = new System.Windows.Forms.TextBox();
            this.lb_telefono_Empleado = new System.Windows.Forms.Label();
            this.txb_direccion_Empleado = new System.Windows.Forms.TextBox();
            this.lb_direccion_Empleado = new System.Windows.Forms.Label();
            this.lb_fNacimiento_Empleado = new System.Windows.Forms.Label();
            this.date_FNacimineto_Empleado = new System.Windows.Forms.DateTimePicker();
            this.txb_Apellido_Empleado = new System.Windows.Forms.TextBox();
            this.lb_Apellidos_Empleado = new System.Windows.Forms.Label();
            this.txb_Nombre_Empleado = new System.Windows.Forms.TextBox();
            this.lb_nombre_empleado = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.txb_ID_Empleado = new System.Windows.Forms.TextBox();
            this.dt_puesto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Contratacion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Sucursal_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_puesto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(768, 498);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 39);
            this.btn_Cancelar.TabIndex = 31;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Editar_Empleado
            // 
            this.btn_Editar_Empleado.Location = new System.Drawing.Point(12, 488);
            this.btn_Editar_Empleado.Name = "btn_Editar_Empleado";
            this.btn_Editar_Empleado.Size = new System.Drawing.Size(69, 39);
            this.btn_Editar_Empleado.TabIndex = 30;
            this.btn_Editar_Empleado.Text = "Editar";
            this.btn_Editar_Empleado.UseVisualStyleBackColor = true;
            this.btn_Editar_Empleado.Click += new System.EventHandler(this.btn_Editar_Empleado_Click);
            // 
            // txb_DUI_Empleado
            // 
            this.txb_DUI_Empleado.Location = new System.Drawing.Point(127, 203);
            this.txb_DUI_Empleado.Name = "txb_DUI_Empleado";
            this.txb_DUI_Empleado.Size = new System.Drawing.Size(141, 20);
            this.txb_DUI_Empleado.TabIndex = 29;
            // 
            // lb_DUI_Empleado
            // 
            this.lb_DUI_Empleado.AutoSize = true;
            this.lb_DUI_Empleado.Location = new System.Drawing.Point(58, 210);
            this.lb_DUI_Empleado.Name = "lb_DUI_Empleado";
            this.lb_DUI_Empleado.Size = new System.Drawing.Size(29, 13);
            this.lb_DUI_Empleado.TabIndex = 28;
            this.lb_DUI_Empleado.Text = "DUI:";
            // 
            // dt_Sucursal_Empleado
            // 
            this.dt_Sucursal_Empleado.AllowUserToAddRows = false;
            this.dt_Sucursal_Empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_Sucursal_Empleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_Sucursal_Empleado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_Sucursal_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Sucursal_Empleado.Location = new System.Drawing.Point(649, 31);
            this.dt_Sucursal_Empleado.MultiSelect = false;
            this.dt_Sucursal_Empleado.Name = "dt_Sucursal_Empleado";
            this.dt_Sucursal_Empleado.ReadOnly = true;
            this.dt_Sucursal_Empleado.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_Sucursal_Empleado.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_Sucursal_Empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_Sucursal_Empleado.Size = new System.Drawing.Size(513, 443);
            this.dt_Sucursal_Empleado.TabIndex = 27;
            // 
            // lb_sucursal_Empleado
            // 
            this.lb_sucursal_Empleado.AutoSize = true;
            this.lb_sucursal_Empleado.Location = new System.Drawing.Point(659, 9);
            this.lb_sucursal_Empleado.Name = "lb_sucursal_Empleado";
            this.lb_sucursal_Empleado.Size = new System.Drawing.Size(51, 13);
            this.lb_sucursal_Empleado.TabIndex = 26;
            this.lb_sucursal_Empleado.Text = "Sucursal:";
            // 
            // txb_telefono_Empleado
            // 
            this.txb_telefono_Empleado.Location = new System.Drawing.Point(372, 149);
            this.txb_telefono_Empleado.Name = "txb_telefono_Empleado";
            this.txb_telefono_Empleado.Size = new System.Drawing.Size(141, 20);
            this.txb_telefono_Empleado.TabIndex = 25;
            // 
            // lb_telefono_Empleado
            // 
            this.lb_telefono_Empleado.AutoSize = true;
            this.lb_telefono_Empleado.Location = new System.Drawing.Point(303, 149);
            this.lb_telefono_Empleado.Name = "lb_telefono_Empleado";
            this.lb_telefono_Empleado.Size = new System.Drawing.Size(52, 13);
            this.lb_telefono_Empleado.TabIndex = 24;
            this.lb_telefono_Empleado.Text = "Telefono:";
            // 
            // txb_direccion_Empleado
            // 
            this.txb_direccion_Empleado.Location = new System.Drawing.Point(372, 95);
            this.txb_direccion_Empleado.Name = "txb_direccion_Empleado";
            this.txb_direccion_Empleado.Size = new System.Drawing.Size(141, 20);
            this.txb_direccion_Empleado.TabIndex = 23;
            // 
            // lb_direccion_Empleado
            // 
            this.lb_direccion_Empleado.AutoSize = true;
            this.lb_direccion_Empleado.Location = new System.Drawing.Point(303, 95);
            this.lb_direccion_Empleado.Name = "lb_direccion_Empleado";
            this.lb_direccion_Empleado.Size = new System.Drawing.Size(55, 13);
            this.lb_direccion_Empleado.TabIndex = 22;
            this.lb_direccion_Empleado.Text = "Direccion:";
            // 
            // lb_fNacimiento_Empleado
            // 
            this.lb_fNacimiento_Empleado.AutoSize = true;
            this.lb_fNacimiento_Empleado.Location = new System.Drawing.Point(302, 210);
            this.lb_fNacimiento_Empleado.Name = "lb_fNacimiento_Empleado";
            this.lb_fNacimiento_Empleado.Size = new System.Drawing.Size(111, 13);
            this.lb_fNacimiento_Empleado.TabIndex = 21;
            this.lb_fNacimiento_Empleado.Text = "Fecha de Nacimineto:";
            this.lb_fNacimiento_Empleado.Click += new System.EventHandler(this.lb_fNacimiento_Empleado_Click);
            // 
            // date_FNacimineto_Empleado
            // 
            this.date_FNacimineto_Empleado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_FNacimineto_Empleado.Location = new System.Drawing.Point(419, 210);
            this.date_FNacimineto_Empleado.Name = "date_FNacimineto_Empleado";
            this.date_FNacimineto_Empleado.Size = new System.Drawing.Size(200, 20);
            this.date_FNacimineto_Empleado.TabIndex = 20;
            this.date_FNacimineto_Empleado.ValueChanged += new System.EventHandler(this.date_FNacimineto_Empleado_ValueChanged);
            // 
            // txb_Apellido_Empleado
            // 
            this.txb_Apellido_Empleado.Location = new System.Drawing.Point(117, 157);
            this.txb_Apellido_Empleado.Name = "txb_Apellido_Empleado";
            this.txb_Apellido_Empleado.Size = new System.Drawing.Size(141, 20);
            this.txb_Apellido_Empleado.TabIndex = 19;
            // 
            // lb_Apellidos_Empleado
            // 
            this.lb_Apellidos_Empleado.AutoSize = true;
            this.lb_Apellidos_Empleado.Location = new System.Drawing.Point(48, 157);
            this.lb_Apellidos_Empleado.Name = "lb_Apellidos_Empleado";
            this.lb_Apellidos_Empleado.Size = new System.Drawing.Size(52, 13);
            this.lb_Apellidos_Empleado.TabIndex = 18;
            this.lb_Apellidos_Empleado.Text = "Apellidos:";
            // 
            // txb_Nombre_Empleado
            // 
            this.txb_Nombre_Empleado.Location = new System.Drawing.Point(117, 95);
            this.txb_Nombre_Empleado.Name = "txb_Nombre_Empleado";
            this.txb_Nombre_Empleado.Size = new System.Drawing.Size(141, 20);
            this.txb_Nombre_Empleado.TabIndex = 17;
            // 
            // lb_nombre_empleado
            // 
            this.lb_nombre_empleado.AutoSize = true;
            this.lb_nombre_empleado.Location = new System.Drawing.Point(48, 95);
            this.lb_nombre_empleado.Name = "lb_nombre_empleado";
            this.lb_nombre_empleado.Size = new System.Drawing.Size(52, 13);
            this.lb_nombre_empleado.TabIndex = 16;
            this.lb_nombre_empleado.Text = "Nombres:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(169, 34);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(21, 13);
            this.lb_ID.TabIndex = 32;
            this.lb_ID.Text = "ID:";
            // 
            // txb_ID_Empleado
            // 
            this.txb_ID_Empleado.Location = new System.Drawing.Point(196, 31);
            this.txb_ID_Empleado.Name = "txb_ID_Empleado";
            this.txb_ID_Empleado.ReadOnly = true;
            this.txb_ID_Empleado.Size = new System.Drawing.Size(159, 20);
            this.txb_ID_Empleado.TabIndex = 33;
            // 
            // dt_puesto
            // 
            this.dt_puesto.AllowUserToAddRows = false;
            this.dt_puesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_puesto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_puesto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_puesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_puesto.Location = new System.Drawing.Point(12, 291);
            this.dt_puesto.MultiSelect = false;
            this.dt_puesto.Name = "dt_puesto";
            this.dt_puesto.ReadOnly = true;
            this.dt_puesto.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_puesto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_puesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_puesto.Size = new System.Drawing.Size(636, 183);
            this.dt_puesto.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de Contratacion";
            // 
            // date_Contratacion
            // 
            this.date_Contratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Contratacion.Location = new System.Drawing.Point(372, 265);
            this.date_Contratacion.Name = "date_Contratacion";
            this.date_Contratacion.Size = new System.Drawing.Size(200, 20);
            this.date_Contratacion.TabIndex = 36;
            // 
            // Editar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Contratacion);
            this.Controls.Add(this.dt_puesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_ID_Empleado);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Editar_Empleado);
            this.Controls.Add(this.txb_DUI_Empleado);
            this.Controls.Add(this.lb_DUI_Empleado);
            this.Controls.Add(this.dt_Sucursal_Empleado);
            this.Controls.Add(this.lb_sucursal_Empleado);
            this.Controls.Add(this.txb_telefono_Empleado);
            this.Controls.Add(this.lb_telefono_Empleado);
            this.Controls.Add(this.txb_direccion_Empleado);
            this.Controls.Add(this.lb_direccion_Empleado);
            this.Controls.Add(this.lb_fNacimiento_Empleado);
            this.Controls.Add(this.date_FNacimineto_Empleado);
            this.Controls.Add(this.txb_Apellido_Empleado);
            this.Controls.Add(this.lb_Apellidos_Empleado);
            this.Controls.Add(this.txb_Nombre_Empleado);
            this.Controls.Add(this.lb_nombre_empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editar_Empleado";
            this.Text = "Editar_Empleado";
            this.Load += new System.EventHandler(this.Editar_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Sucursal_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_puesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Editar_Empleado;
        private System.Windows.Forms.TextBox txb_DUI_Empleado;
        private System.Windows.Forms.Label lb_DUI_Empleado;
        private System.Windows.Forms.DataGridView dt_Sucursal_Empleado;
        private System.Windows.Forms.Label lb_sucursal_Empleado;
        private System.Windows.Forms.TextBox txb_telefono_Empleado;
        private System.Windows.Forms.Label lb_telefono_Empleado;
        private System.Windows.Forms.TextBox txb_direccion_Empleado;
        private System.Windows.Forms.Label lb_direccion_Empleado;
        private System.Windows.Forms.Label lb_fNacimiento_Empleado;
        private System.Windows.Forms.DateTimePicker date_FNacimineto_Empleado;
        private System.Windows.Forms.TextBox txb_Apellido_Empleado;
        private System.Windows.Forms.Label lb_Apellidos_Empleado;
        private System.Windows.Forms.TextBox txb_Nombre_Empleado;
        private System.Windows.Forms.Label lb_nombre_empleado;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox txb_ID_Empleado;
        private System.Windows.Forms.DataGridView dt_puesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Contratacion;
    }
}