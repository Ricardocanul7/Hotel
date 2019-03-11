﻿namespace Hotel.GUI
{
    partial class Frm_mantenimiento
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
            this.Dgr_mantenimiento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nvoproveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_consultar_proveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_prog_mantenimiento = new System.Windows.Forms.ToolStripButton();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_mantenimiento)).BeginInit();
            this.btn_habitaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgr_mantenimiento
            // 
            this.Dgr_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_mantenimiento.Location = new System.Drawing.Point(16, 84);
            this.Dgr_mantenimiento.Name = "Dgr_mantenimiento";
            this.Dgr_mantenimiento.Size = new System.Drawing.Size(938, 163);
            this.Dgr_mantenimiento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mantenimiento programado:";
            // 
            // btn_nvoproveedor
            // 
            this.btn_nvoproveedor.Image = global::Hotel.Properties.Resources.add;
            this.btn_nvoproveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoproveedor.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoproveedor.Name = "btn_nvoproveedor";
            this.btn_nvoproveedor.Size = new System.Drawing.Size(119, 22);
            this.btn_nvoproveedor.Text = "Nuevo Proveedor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_consultar_proveedor
            // 
            this.btn_consultar_proveedor.Image = global::Hotel.Properties.Resources._021_phone;
            this.btn_consultar_proveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_proveedor.Name = "btn_consultar_proveedor";
            this.btn_consultar_proveedor.Size = new System.Drawing.Size(92, 22);
            this.btn_consultar_proveedor.Text = "Proveedores";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_prog_mantenimiento
            // 
            this.btn_prog_mantenimiento.Image = global::Hotel.Properties.Resources._031_broom;
            this.btn_prog_mantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_prog_mantenimiento.Name = "btn_prog_mantenimiento";
            this.btn_prog_mantenimiento.Size = new System.Drawing.Size(168, 22);
            this.btn_prog_mantenimiento.Text = "Programar Mantenimiento";
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nvoproveedor,
            this.toolStripSeparator1,
            this.btn_consultar_proveedor,
            this.toolStripSeparator2,
            this.btn_prog_mantenimiento});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(966, 25);
            this.btn_habitaciones.TabIndex = 3;
            this.btn_habitaciones.Text = "Menu";
            // 
            // Frm_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgr_mantenimiento);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_mantenimiento";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_mantenimiento)).EndInit();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgr_mantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btn_nvoproveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_consultar_proveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_prog_mantenimiento;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
    }
}