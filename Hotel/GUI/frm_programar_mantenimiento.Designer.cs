namespace Hotel.GUI
{
    partial class frm_programar_mantenimiento
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_Mantenimiento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_mantenimiento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eliminar_Mantenimiento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_buscarempleados = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscarempleados = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Limpieza = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Limpieza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_eliminar_limpieza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mantenimiento)).BeginInit();
            this.panel1.SuspendLayout();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Limpieza)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Mantenimiento);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Limpieza);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(809, 450);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv_Mantenimiento
            // 
            this.dgv_Mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Mantenimiento.Location = new System.Drawing.Point(0, 116);
            this.dgv_Mantenimiento.Name = "dgv_Mantenimiento";
            this.dgv_Mantenimiento.Size = new System.Drawing.Size(408, 334);
            this.dgv_Mantenimiento.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_habitaciones);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 116);
            this.panel1.TabIndex = 0;
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btn_mantenimiento,
            this.toolStripSeparator1,
            this.btn_Eliminar_Mantenimiento,
            this.toolStripSeparator3,
            this.txt_buscarempleados,
            this.btn_buscarempleados});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(408, 39);
            this.btn_habitaciones.TabIndex = 3;
            this.btn_habitaciones.Text = "Menu";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_mantenimiento
            // 
            this.btn_mantenimiento.Image = global::Hotel.Properties.Resources._031_broom1;
            this.btn_mantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mantenimiento.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_mantenimiento.Name = "btn_mantenimiento";
            this.btn_mantenimiento.Size = new System.Drawing.Size(168, 36);
            this.btn_mantenimiento.Text = "Programar Mantenimiento";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Eliminar_Mantenimiento
            // 
            this.btn_Eliminar_Mantenimiento.Image = global::Hotel.Properties.Resources.close;
            this.btn_Eliminar_Mantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Eliminar_Mantenimiento.Name = "btn_Eliminar_Mantenimiento";
            this.btn_Eliminar_Mantenimiento.Size = new System.Drawing.Size(70, 36);
            this.btn_Eliminar_Mantenimiento.Text = "Eliminar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // txt_buscarempleados
            // 
            this.txt_buscarempleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarempleados.Name = "txt_buscarempleados";
            this.txt_buscarempleados.Size = new System.Drawing.Size(150, 23);
            // 
            // btn_buscarempleados
            // 
            this.btn_buscarempleados.Image = global::Hotel.Properties.Resources.icon_search;
            this.btn_buscarempleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_buscarempleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscarempleados.Name = "btn_buscarempleados";
            this.btn_buscarempleados.Size = new System.Drawing.Size(78, 36);
            this.btn_buscarempleados.Text = "Buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 40);
            this.label6.TabIndex = 42;
            this.label6.Text = "MANTENIMIENTO";
            // 
            // dgv_Limpieza
            // 
            this.dgv_Limpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Limpieza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Limpieza.Location = new System.Drawing.Point(0, 116);
            this.dgv_Limpieza.Name = "dgv_Limpieza";
            this.dgv_Limpieza.Size = new System.Drawing.Size(397, 334);
            this.dgv_Limpieza.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 116);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "LIMPIEZA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btn_Limpieza,
            this.toolStripSeparator6,
            this.btn_eliminar_limpieza,
            this.toolStripSeparator7,
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(397, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Limpieza
            // 
            this.btn_Limpieza.Image = global::Hotel.Properties.Resources._031_broom1;
            this.btn_Limpieza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Limpieza.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_Limpieza.Name = "btn_Limpieza";
            this.btn_Limpieza.Size = new System.Drawing.Size(133, 36);
            this.btn_Limpieza.Text = "Programar Limpieza";
            this.btn_Limpieza.Click += new System.EventHandler(this.Abrir_Limpieza);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_eliminar_limpieza
            // 
            this.btn_eliminar_limpieza.Image = global::Hotel.Properties.Resources.close;
            this.btn_eliminar_limpieza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar_limpieza.Name = "btn_eliminar_limpieza";
            this.btn_eliminar_limpieza.Size = new System.Drawing.Size(70, 36);
            this.btn_eliminar_limpieza.Text = "Eliminar";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Hotel.Properties.Resources.icon_search;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(78, 36);
            this.toolStripButton5.Text = "Buscar";
            // 
            // frm_programar_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_programar_mantenimiento";
            this.Text = "frm_programar_mantenimiento";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mantenimiento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Limpieza)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Mantenimiento;
        private System.Windows.Forms.DataGridView dgv_Limpieza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_mantenimiento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Eliminar_Mantenimiento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox txt_buscarempleados;
        private System.Windows.Forms.ToolStripButton btn_buscarempleados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Limpieza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_eliminar_limpieza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}