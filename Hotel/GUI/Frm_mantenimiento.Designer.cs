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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_Buscar_Empresa = new System.Windows.Forms.ToolStripTextBox();
            this.panel_mantenimiento = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_empresas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_precio_hora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();
            this.txt_rfc_empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nvoproveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_mantenimiento)).BeginInit();
            this.btn_habitaciones.SuspendLayout();
            this.panel_mantenimiento.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgr_mantenimiento
            // 
            this.Dgr_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgr_mantenimiento.Location = new System.Drawing.Point(0, 39);
            this.Dgr_mantenimiento.Name = "Dgr_mantenimiento";
            this.Dgr_mantenimiento.Size = new System.Drawing.Size(966, 411);
            this.Dgr_mantenimiento.TabIndex = 4;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nvoproveedor,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.txt_Buscar_Empresa,
            this.toolStripButton3});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(966, 39);
            this.btn_habitaciones.TabIndex = 3;
            this.btn_habitaciones.Text = "Menu";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // txt_Buscar_Empresa
            // 
            this.txt_Buscar_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar_Empresa.Name = "txt_Buscar_Empresa";
            this.txt_Buscar_Empresa.Size = new System.Drawing.Size(150, 39);
            // 
            // panel_mantenimiento
            // 
            this.panel_mantenimiento.Controls.Add(this.panel1);
            this.panel_mantenimiento.Controls.Add(this.groupBox3);
            this.panel_mantenimiento.Controls.Add(this.pictureBox1);
            this.panel_mantenimiento.Controls.Add(this.label6);
            this.panel_mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_mantenimiento.Location = new System.Drawing.Point(0, 39);
            this.panel_mantenimiento.Name = "panel_mantenimiento";
            this.panel_mantenimiento.Size = new System.Drawing.Size(966, 425);
            this.panel_mantenimiento.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_empresas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 196);
            this.panel1.TabIndex = 40;
            // 
            // dgv_empresas
            // 
            this.dgv_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_empresas.Location = new System.Drawing.Point(0, 3);
            this.dgv_empresas.Name = "dgv_empresas";
            this.dgv_empresas.Size = new System.Drawing.Size(966, 193);
            this.dgv_empresas.TabIndex = 0;
            this.dgv_empresas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_fila);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precio_hora);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_nombre_empresa);
            this.groupBox3.Controls.Add(this.txt_rfc_empresa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(63, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 113);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Empresa:";
            // 
            // txt_precio_hora
            // 
            this.txt_precio_hora.Location = new System.Drawing.Point(120, 93);
            this.txt_precio_hora.Name = "txt_precio_hora";
            this.txt_precio_hora.Size = new System.Drawing.Size(232, 20);
            this.txt_precio_hora.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio por Hora :";
            // 
            // txt_nombre_empresa
            // 
            this.txt_nombre_empresa.Location = new System.Drawing.Point(119, 59);
            this.txt_nombre_empresa.Name = "txt_nombre_empresa";
            this.txt_nombre_empresa.Size = new System.Drawing.Size(232, 20);
            this.txt_nombre_empresa.TabIndex = 16;
            // 
            // txt_rfc_empresa
            // 
            this.txt_rfc_empresa.Location = new System.Drawing.Point(120, 31);
            this.txt_rfc_empresa.Name = "txt_rfc_empresa";
            this.txt_rfc_empresa.Size = new System.Drawing.Size(232, 20);
            this.txt_rfc_empresa.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 40);
            this.label6.TabIndex = 37;
            this.label6.Text = "EMPRESA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(117, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btn_nvoproveedor
            // 
            this.btn_nvoproveedor.Image = global::Hotel.Properties.Resources.add;
            this.btn_nvoproveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoproveedor.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoproveedor.Name = "btn_nvoproveedor";
            this.btn_nvoproveedor.Size = new System.Drawing.Size(117, 36);
            this.btn_nvoproveedor.Text = "Agregar Empresa";
            this.btn_nvoproveedor.Click += new System.EventHandler(this.Guardar_Empresa);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Hotel.Properties.Resources.close;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 36);
            this.toolStripButton1.Text = "Eliminar Empresa";
            this.toolStripButton1.Click += new System.EventHandler(this.Eliminar_Empresa);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Hotel.Properties.Resources._036_edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(132, 36);
            this.toolStripButton2.Text = "Actualizar Empresas";
            this.toolStripButton2.Click += new System.EventHandler(this.Actualizar_Empresa);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Hotel.Properties.Resources.icon_search;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Buscar";
            this.toolStripButton3.Click += new System.EventHandler(this.Buscar_Empresa);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Hotel.Properties.Resources._031_broom1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(168, 36);
            this.toolStripButton4.Text = "Programar Mantenimiento";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // Frm_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.panel_mantenimiento);
            this.Controls.Add(this.Dgr_mantenimiento);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_mantenimiento";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_mantenimiento)).EndInit();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            this.panel_mantenimiento.ResumeLayout(false);
            this.panel_mantenimiento.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgr_mantenimiento;
        private System.Windows.Forms.ToolStripButton btn_nvoproveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.Panel panel_mantenimiento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_nombre_empresa;
        private System.Windows.Forms.TextBox txt_rfc_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_empresas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precio_hora;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox txt_Buscar_Empresa;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}