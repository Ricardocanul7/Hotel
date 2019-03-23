namespace Hotel.GUI
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.btn_nvoproveedor = new System.Windows.Forms.ToolStripButton();
            this.btn_consultar_proveedor = new System.Windows.Forms.ToolStripButton();
            this.btn_prog_mantenimiento = new System.Windows.Forms.ToolStripButton();
            this.panel_mantenimiento = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();
            this.txt_rfc_empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_empresas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgr_mantenimiento)).BeginInit();
            this.btn_habitaciones.SuspendLayout();
            this.panel_mantenimiento.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgr_mantenimiento
            // 
            this.Dgr_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgr_mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgr_mantenimiento.Location = new System.Drawing.Point(0, 25);
            this.Dgr_mantenimiento.Name = "Dgr_mantenimiento";
            this.Dgr_mantenimiento.Size = new System.Drawing.Size(966, 425);
            this.Dgr_mantenimiento.TabIndex = 4;
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
            // btn_nvoproveedor
            // 
            this.btn_nvoproveedor.Image = global::Hotel.Properties.Resources.add;
            this.btn_nvoproveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoproveedor.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoproveedor.Name = "btn_nvoproveedor";
            this.btn_nvoproveedor.Size = new System.Drawing.Size(109, 22);
            this.btn_nvoproveedor.Text = "Nueva Empresa";

            // 
            // btn_consultar_proveedor
            // 
            this.btn_consultar_proveedor.Image = global::Hotel.Properties.Resources._021_phone;
            this.btn_consultar_proveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar_proveedor.Name = "btn_consultar_proveedor";
            this.btn_consultar_proveedor.Size = new System.Drawing.Size(115, 22);
            this.btn_consultar_proveedor.Text = "Buscar Empresas";
            // 
            // btn_prog_mantenimiento
            // 
            this.btn_prog_mantenimiento.Image = global::Hotel.Properties.Resources._031_broom;
            this.btn_prog_mantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_prog_mantenimiento.Name = "btn_prog_mantenimiento";
            this.btn_prog_mantenimiento.Size = new System.Drawing.Size(168, 22);
            this.btn_prog_mantenimiento.Text = "Programar Mantenimiento";
            // 
            // panel_mantenimiento
            // 
            this.panel_mantenimiento.Controls.Add(this.panel1);
            this.panel_mantenimiento.Controls.Add(this.groupBox3);
            this.panel_mantenimiento.Controls.Add(this.pictureBox1);
            this.panel_mantenimiento.Controls.Add(this.label6);
            this.panel_mantenimiento.Location = new System.Drawing.Point(0, 25);
            this.panel_mantenimiento.Name = "panel_mantenimiento";
            this.panel_mantenimiento.Size = new System.Drawing.Size(966, 425);
            this.panel_mantenimiento.TabIndex = 5;
            // 
            // groupBox3
            // 
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgr_mantenimiento;
        private System.Windows.Forms.ToolStripButton btn_nvoproveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_consultar_proveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_prog_mantenimiento;
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
    }
}