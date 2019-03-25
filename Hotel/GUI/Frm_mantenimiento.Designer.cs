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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.btn_nvoproveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Buscar_Empresa = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dgv_empresas = new System.Windows.Forms.DataGridView();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).BeginInit();
            this.SuspendLayout();
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
            // btn_nvoproveedor
            // 
            this.btn_nvoproveedor.Image = global::Hotel.Properties.Resources.add;
            this.btn_nvoproveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvoproveedor.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvoproveedor.Name = "btn_nvoproveedor";
            this.btn_nvoproveedor.Size = new System.Drawing.Size(117, 36);
            this.btn_nvoproveedor.Text = "Agregar Empresa";
            this.btn_nvoproveedor.Click += new System.EventHandler(this.Agregar_Empresa);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Hotel.Properties.Resources._036_edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(132, 36);
            this.toolStripButton2.Text = "Actualizar Empresas";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Hotel.Properties.Resources._031_broom1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(168, 36);
            this.toolStripButton4.Text = "Programar Mantenimiento";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // txt_Buscar_Empresa
            // 
            this.txt_Buscar_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar_Empresa.Name = "txt_Buscar_Empresa";
            this.txt_Buscar_Empresa.Size = new System.Drawing.Size(150, 39);
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
            // dgv_empresas
            // 
            this.dgv_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_empresas.Location = new System.Drawing.Point(0, 39);
            this.dgv_empresas.Name = "dgv_empresas";
            this.dgv_empresas.Size = new System.Drawing.Size(966, 411);
            this.dgv_empresas.TabIndex = 0;
            this.dgv_empresas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_Fila);
            // 
            // Frm_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.dgv_empresas);
            this.Controls.Add(this.btn_habitaciones);
            this.Name = "Frm_mantenimiento";
            this.Text = "Mantenimiento";
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btn_nvoproveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox txt_Buscar_Empresa;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgv_empresas;
    }
}