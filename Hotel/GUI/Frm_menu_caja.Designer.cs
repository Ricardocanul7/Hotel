namespace Hotel.GUI
{
    partial class Frm_menu_caja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_habitaciones = new System.Windows.Forms.ToolStrip();
            this.btn_nvatransaccion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_reporte_caja = new System.Windows.Forms.ToolStripButton();
            this.dgv_transacciones = new System.Windows.Forms.DataGridView();
            this.dgv_corte = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.btn_habitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corte)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_habitaciones);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_transacciones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_corte);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1204, 540);
            this.splitContainer1.SplitterDistance = 564;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 100);
            this.panel1.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::Hotel.Properties.Resources.cash1;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 40);
            this.label6.TabIndex = 49;
            this.label6.Text = "     TRANSACCIONES";
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btn_habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_habitaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nvatransaccion,
            this.toolStripSeparator1,
            this.btn_reporte_caja});
            this.btn_habitaciones.Location = new System.Drawing.Point(0, 0);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.btn_habitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_habitaciones.Size = new System.Drawing.Size(564, 25);
            this.btn_habitaciones.TabIndex = 51;
            this.btn_habitaciones.Text = "Menu";
            // 
            // btn_nvatransaccion
            // 
            this.btn_nvatransaccion.Image = global::Hotel.Properties.Resources.cash;
            this.btn_nvatransaccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nvatransaccion.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btn_nvatransaccion.Name = "btn_nvatransaccion";
            this.btn_nvatransaccion.Size = new System.Drawing.Size(135, 22);
            this.btn_nvatransaccion.Text = "Agregar Transacción";
            this.btn_nvatransaccion.Click += new System.EventHandler(this.btn_nvatransaccion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_reporte_caja
            // 
            this.btn_reporte_caja.Image = global::Hotel.Properties.Resources._049_notes1;
            this.btn_reporte_caja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reporte_caja.Name = "btn_reporte_caja";
            this.btn_reporte_caja.Size = new System.Drawing.Size(137, 22);
            this.btn_reporte_caja.Text = "imprimir transacción";
            // 
            // dgv_transacciones
            // 
            this.dgv_transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transacciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transacciones.Location = new System.Drawing.Point(0, 0);
            this.dgv_transacciones.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.dgv_transacciones.Name = "dgv_transacciones";
            this.dgv_transacciones.Size = new System.Drawing.Size(564, 540);
            this.dgv_transacciones.TabIndex = 48;
            this.dgv_transacciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_fila_trans);
            // 
            // dgv_corte
            // 
            this.dgv_corte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_corte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_corte.Location = new System.Drawing.Point(0, 125);
            this.dgv_corte.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.dgv_corte.Name = "dgv_corte";
            this.dgv_corte.Size = new System.Drawing.Size(636, 415);
            this.dgv_corte.TabIndex = 54;
            this.dgv_corte.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Selecionar_fila_corte);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 100);
            this.panel2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Hotel.Properties.Resources._024_safety_box1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 40);
            this.label1.TabIndex = 50;
            this.label1.Text = "     CORTES DE CAJA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(636, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Hotel.Properties.Resources._024_safety_box1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton2.Text = "Cerrar Caja";
            this.toolStripButton2.ToolTipText = "Cerrar Caja";
            this.toolStripButton2.Click += new System.EventHandler(this.btn_cerrar_caja_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Hotel.Properties.Resources._049_notes1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(103, 22);
            this.toolStripButton3.Text = "imprimir corte";
            // 
            // Frm_menu_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 540);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_menu_caja";
            this.Text = "Caja";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btn_habitaciones.ResumeLayout(false);
            this.btn_habitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corte)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip btn_habitaciones;
        private System.Windows.Forms.ToolStripButton btn_nvatransaccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_reporte_caja;
        private System.Windows.Forms.DataGridView dgv_transacciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_corte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}