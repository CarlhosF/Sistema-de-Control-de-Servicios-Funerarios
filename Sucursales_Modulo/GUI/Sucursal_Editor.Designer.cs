
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
            this.lb_direccion = new System.Windows.Forms.Label();
            this.lb_idsucursal = new System.Windows.Forms.Label();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txb_idsucursal = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_direccion
            // 
            this.lb_direccion.AutoSize = true;
            this.lb_direccion.Location = new System.Drawing.Point(35, 95);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(55, 13);
            this.lb_direccion.TabIndex = 0;
            this.lb_direccion.Text = "Direccion:";
            // 
            // lb_idsucursal
            // 
            this.lb_idsucursal.AutoSize = true;
            this.lb_idsucursal.Location = new System.Drawing.Point(35, 64);
            this.lb_idsucursal.Name = "lb_idsucursal";
            this.lb_idsucursal.Size = new System.Drawing.Size(18, 13);
            this.lb_idsucursal.TabIndex = 1;
            this.lb_idsucursal.Text = "ID";
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Location = new System.Drawing.Point(35, 131);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(49, 13);
            this.lb_telefono.TabIndex = 2;
            this.lb_telefono.Text = "Telefono";
            this.lb_telefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(38, 230);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(82, 36);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(218, 230);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(77, 34);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txb_idsucursal
            // 
            this.txb_idsucursal.Location = new System.Drawing.Point(96, 57);
            this.txb_idsucursal.Name = "txb_idsucursal";
            this.txb_idsucursal.ReadOnly = true;
            this.txb_idsucursal.Size = new System.Drawing.Size(125, 20);
            this.txb_idsucursal.TabIndex = 5;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(96, 95);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(146, 20);
            this.txb_direccion.TabIndex = 6;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(96, 128);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(148, 20);
            this.txb_telefono.TabIndex = 7;
            // 
            // Sucursal_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 305);
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
    }
}